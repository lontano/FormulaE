Public Class frmMain


  Private _container As New Container
  Private _slots As New List(Of Slot)

  Private _initialize As Boolean = False

  Private WithEvents _vizControl As VizCommands.VizControl

  Private ReadOnly Property SceneFullPath As String
    Get
      Return System.IO.Path.Combine(AppSettings.Instance.SceneBasePath, AppSettings.Instance.SceneName)
    End Get
  End Property

  Private Sub TimerFrame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFrame.Tick
    OnFrame()
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      AppSettings.Instance.LlegirConfiguracio(0)

      If AppSettings.Instance.ShowOptions Then
        Dim sHost As String = InputBox("vizrt host", My.Application.Info.AssemblyName, AppSettings.Instance.VizrtHost)
        If sHost <> "" Then
          AppSettings.Instance.VizrtHost = sHost
          AppSettings.Instance.DesarConfiguracio(0)
        End If
      End If

      InitRender()

      _initialize = True
      Me.TextBoxSceneBasePath.Text = AppSettings.Instance.SceneBasePath
      Me.TextBoxSceneName.Text = AppSettings.Instance.SceneName
      _initialize = False

      InitSlots(20)

    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Private Sub InitRender()
    Try
      If Not _vizControl Is Nothing Then _vizControl.CloseSockets()
      _vizControl = New VizCommands.VizControl
      _vizControl.Config = New VizCommands.tyConfigVizrt
      _vizControl.Config.TCPHost = AppSettings.Instance.VizrtHost
      _vizControl.Config.TCPPort = AppSettings.Instance.VizrtPort
      _vizControl.Config.SceneBasePath = AppSettings.Instance.SceneBasePath
      _vizControl.InitializeSockets()
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
    Me.UpdateStatusLabel()
  End Sub

  Private Sub UpdateOptions()
    If _initialize = True Then Exit Sub
    AppSettings.Instance.SceneBasePath = Me.TextBoxSceneBasePath.Text
    AppSettings.Instance.SceneName = Me.TextBoxSceneName.Text
    AppSettings.Instance.Save()
  End Sub
  Private Sub UpdateStatusLabel()
    Try
      If _vizControl Is Nothing Then
        Me.LabelVizEngine.BackColor = Color.Red
      Else
        Select Case _vizControl.SocketStateTCP
          Case VizCommands.eSocketState.Connected
            Me.LabelVizEngine.BackColor = Color.Green
          Case VizCommands.eSocketState.Connecting
            Me.LabelVizEngine.BackColor = Color.Orange
          Case VizCommands.eSocketState.Disconnected
            Me.LabelVizEngine.BackColor = Color.Red
          Case VizCommands.eSocketState.ErrorState
            Me.LabelVizEngine.BackColor = Color.Red
        End Select
      End If

    Catch ex As Exception
    End Try
  End Sub

  Private Sub Settings_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSceneBasePath.TextChanged, TextBoxSceneName.TextChanged
    UpdateOptions()
  End Sub

  Private Sub InitSlots(count As Integer)
    Try
      Dim i As Integer
      Dim cont As tyContainerData

      For i = 0 To _containers.Count - 1
        cont = _containers(i)
        RemoveHandler cont.myContainer.Clicked, AddressOf Container_Clicked
      Next


      Me.UcSlots1.InitSlots(count)

      InitContainers()

      For i = 0 To _containers.Count - 1
        cont = _containers(i)
        cont.myContainer.vizId = i
        AddHandler cont.myContainer.Clicked, AddressOf Container_Clicked
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Container_Clicked(ByVal sender As Container, ByVal e As System.EventArgs)
    Dim i As Integer
    Dim cont As tyContainerData
    Dim updated As Boolean = False
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      If cont.myContainer.vizId = sender.vizId Then
        cont.expanded = Not cont.expanded
        updated = True
        _containers(i) = cont
      End If
    Next
    If updated Then
      UpdateExpandedContainers()
    End If
  End Sub

  Private _containers As New List(Of tyContainerData)

  Private Sub ButtonAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAction.Click
    For Each ucSlot As UCSlot In UcSlots1.Slots
      ucSlot.Slot.Position = ucSlot.Slot.Position + CInt((0.5 - Rnd()) * 3)
      ucSlot.UpdateSlotInfo()
    Next
    Dim i As Integer
    Dim cont As tyContainerData

    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.slot = cont.slot + CInt((0.5 - Rnd()) * 3)
      'cont.slot = (cont.slot + 1) Mod _containers.Count
      cont.index = cont.slot
      'cont.expanded = (Rnd() > 0.8)
      _containers(i) = cont
    Next

    Quicksort(_containers, 0, _containers.Count - 1)

    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.slot = i + 1
      cont.index = cont.slot
      _containers(i) = cont
    Next
    Dim y As Double = _defaultPositionY
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.PositionAnimation.Y_init = cont.myContainer.Position.Y
      cont.PositionAnimation.Y_final = y '
      y += IIf(cont.expanded, _slotSideMax, _slotSideMin)
      cont.index = cont.slot
      _containers(i) = cont
    Next
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      Dim difY As Double = cont.PositionAnimation.Y_final - cont.PositionAnimation.Y_init

      If difY <> 0 Then
        cont.PositionAnimation.progress = 0
        cont.PositionAnimation.duration = _defaultDuration
        cont.PositionAnimation.offset = 0
        cont.index = cont.slot
      End If

      _containers(i) = cont
    Next
  End Sub

  Private Sub ButtonExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExpand.Click
    For Each ucSlot As UCSlot In UcSlots1.Slots
      ucSlot.Slot.Expanded = (Rnd() > 0.5)
      ucSlot.UpdateSlotInfo()
    Next
    Dim i As Integer
    Dim cont As tyContainerData

    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.expanded = (Rnd() > 0.75)
      _containers(i) = cont
    Next

    Dim y As Double = _defaultPositionY
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.PositionAnimation.Y_init = cont.myContainer.Position.Y
      cont.PositionAnimation.Y_final = y '
      y += IIf(cont.expanded, _slotSideMax, _slotSideMin)
      cont.index = cont.slot
      _containers(i) = cont
    Next
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      Dim difY As Double = cont.PositionAnimation.Y_final - cont.PositionAnimation.Y_init

      If difY <> 0 Then
        cont.PositionAnimation.progress = 0
        cont.PositionAnimation.duration = _defaultDuration
        cont.PositionAnimation.offset = 0
        cont.index = cont.slot
      End If

      _containers(i) = cont
    Next
  End Sub

  Private Sub UpdateExpandedContainers()
    Dim i As Integer
    Dim cont As tyContainerData
    Dim firstToMove As Integer = Integer.MaxValue
    Dim lastToMove As Integer = Integer.MinValue

    Dim y As Double = _defaultPositionY
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      If y <> cont.myContainer.Position.Y Then
        firstToMove = Math.Min(firstToMove, i)
        lastToMove = Math.Max(firstToMove, i)
      End If
      cont.PositionAnimation.Y_init = cont.myContainer.Position.Y
      cont.PositionAnimation.Y_final = y '
      y += IIf(cont.expanded, _slotSideMax, _slotSideMin)
      'cont.PositionAnimation.duration = _defaultDuration
      'cont.PositionAnimation.progress = 0
      'cont.PositionAnimation.offset = 25 * (_containers.Count - i)
      cont.index = cont.slot
      cont.expandedFormer = cont.expanded
      _containers(i) = cont
    Next

    For i = firstToMove To lastToMove
      cont = _containers(i)
      Dim difY As Double = cont.PositionAnimation.Y_final - cont.PositionAnimation.Y_init

      If difY <> 0 Then
        cont.PositionAnimation.progress = 0
        cont.PositionAnimation.duration = _defaultDuration
        cont.PositionAnimation.offset = 0
        cont.index = cont.slot

        If difY < 0 Then
          cont.PositionAnimation.offset = (cont.slot - firstToMove) * 15
        Else
          cont.PositionAnimation.offset = (lastToMove - i) * 15
        End If
      End If

      _containers(i) = cont
    Next

  End Sub

#Region "Script"
  Private Structure tyContainerData
    Dim myContainer As Container
    Dim positionIndexFormer As Integer
    Dim positionIndex As Integer
    Dim progress As Double
    Dim index As Integer

    Dim expandedFormer As Boolean
    Dim expanded As Boolean

    Dim slotFormer As Integer
    Dim slot As Integer

    Dim PositionAnimation As tyPositionAnimation

  End Structure

  Private Structure tyDirectorAnimation
    Dim Director As Director
    Dim offset As Double
    Dim progress As Double
  End Structure

  Private Structure tyPositionAnimation
    Dim progress As Double
    Dim offset As Double
    Dim duration As Double
    Dim Y_init As Double
    Dim Y_final As Double
    Dim Z_amplitude As Double
    Dim animationProgress As Double
  End Structure

  Dim _minPosition As Double = 10

  Dim _slotSideMin As Double = 30
  Dim _slotSideMax As Double = 50

  Dim _defaultPositionX As Double
  Dim _defaultPositionY As Double
  Dim _defaultPositionZ As Double

  Dim _defaultDuration As Double


  Private Sub InitContainers()
    Dim i As Integer

    _defaultPositionX = 0
    _defaultPositionY = 0
    _defaultPositionZ = 0
    _defaultDuration = 100


    For Each ucSlot As UCSlot In Me.UcSlots1.Slots
      Dim myCont As New Container
      myCont.Name = "SLOT_" & ucSlot.Slot.Index
      myCont.Width = Me.PanelContainer.ClientSize.Width
      Me.PanelContainer.Controls.Add(myCont)
      _container._childContainers.Add(myCont)
    Next


    For i = 0 To _container.ChildContainerCount - 1
      Dim myCont As tyContainerData
      myCont.myContainer = _container.GetChildContainerByIndex(i)
      myCont.myContainer.Position.X = 0
      myCont.myContainer.Position.Y = 0
      myCont.expanded = False
      myCont.expandedFormer = False

      myCont.slot = i + 1

      myCont.PositionAnimation.animationProgress = 0
      myCont.PositionAnimation.duration = 0
      myCont.PositionAnimation.offset = 0
      myCont.PositionAnimation.progress = 0
      myCont.PositionAnimation.Y_init = 0
      myCont.PositionAnimation.Y_final = i * _slotSideMin
      myCont.PositionAnimation.Z_amplitude = 0

      _containers.Add(myCont)
    Next


  End Sub

  Private Sub OnFrame()
    'Dim sw As New Stopwatch
    'sw.Start()
    Dim i As Integer
    For i = 0 To _containers.Count - 1
      ComputeContainerPosition(_containers(i))
    Next
    'sw.Stop()
    'Debug.Print("OnFrame " & sw.ElapsedMilliseconds)
  End Sub

  Private Function ComputeContainerPosition(ByRef cont As tyContainerData) As Double
    Dim res As Double = 0

    'cont.myContainer.Text = " Position " & cont.index
    'cont.myContainer.Position.X = 0
    'res = _minPosition + cont.index * _slotSideMin
    'cont.myContainer.Position.Y = res
    If cont.PositionAnimation.duration = 0 Then
      cont.myContainer.Position.X = _defaultPositionX
      cont.myContainer.Position.Y = cont.PositionAnimation.Y_final
      cont.myContainer.Position.Z = _defaultPositionZ
    Else
      If cont.PositionAnimation.progress < cont.PositionAnimation.duration + cont.PositionAnimation.offset Then
        cont.PositionAnimation.progress += 1

        If cont.PositionAnimation.progress < cont.PositionAnimation.offset Then
          cont.myContainer.Position.X = _defaultPositionX
          cont.myContainer.Position.Y = cont.PositionAnimation.Y_init
          cont.myContainer.Position.Z = _defaultPositionZ
        ElseIf cont.PositionAnimation.progress < cont.PositionAnimation.duration + cont.PositionAnimation.offset Then
          Dim progress As Double
          progress = (cont.PositionAnimation.progress - cont.PositionAnimation.offset) / cont.PositionAnimation.duration
          cont.myContainer.Position.X = _defaultPositionX
          cont.myContainer.Position.Y = progress * cont.PositionAnimation.Y_final + (1 - progress) * cont.PositionAnimation.Y_init
          cont.myContainer.Position.Z = _defaultPositionZ
        Else
          cont.myContainer.Position.X = _defaultPositionX
          cont.myContainer.Position.Y = cont.PositionAnimation.Y_final
          cont.myContainer.Position.Z = _defaultPositionZ
          cont.slotFormer = cont.slot
          cont.PositionAnimation.Y_init = cont.PositionAnimation.Y_final
        End If
      End If
    End If


    Return res
  End Function

  Private Sub Quicksort(ByVal list() As tyContainerData, ByVal min As Integer, ByVal max As Integer)
    Dim random_number As New Random
    Dim med_value As tyContainerData
    Dim hi As Integer
    Dim lo As Integer
    Dim i As Integer

    ' If min >= max, the list contains 0 or 1 items so
    ' it is sorted.
    If min >= max Then Exit Sub

    ' Pick the dividing value.
    i = random_number.Next(min, max + 1)
    med_value = list(i)

    ' Swap it to the front.
    list(i) = list(min)

    lo = min
    hi = max
    Do
      ' Look down from hi for a value < med_value.
      Do While list(hi).index >= med_value.index
        hi = hi - 1
        If hi <= lo Then Exit Do
      Loop
      If hi <= lo Then
        list(lo) = med_value
        Exit Do
      End If

      ' Swap the lo and hi values.
      list(lo) = list(hi)

      ' Look up from lo for a value >= med_value.
      lo = lo + 1
      Do While list(lo).index < med_value.index
        lo = lo + 1
        If lo >= hi Then Exit Do
      Loop
      If lo >= hi Then
        lo = hi
        list(hi) = med_value
        Exit Do
      End If

      ' Swap the lo and hi values.
      list(hi) = list(lo)
    Loop

    ' Sort the two sublists.
    Quicksort(list, min, lo - 1)
    Quicksort(list, lo + 1, max)
  End Sub
#End Region


  Private Sub Quicksort(ByVal list As List(Of tyContainerData), ByVal min As Integer, ByVal max As Integer)
    Dim random_number As New Random
    Dim med_value As tyContainerData
    Dim hi As Integer
    Dim lo As Integer
    Dim i As Integer

    ' If min >= max, the list contains 0 or 1 items so
    ' it is sorted.
    If min >= max Then Exit Sub

    ' Pick the dividing value.
    i = random_number.Next(min, max + 1)
    med_value = list(i)

    ' Swap it to the front.
    list(i) = list(min)

    lo = min
    hi = max
    Do
      ' Look down from hi for a value < med_value.
      Do While list(hi).index >= med_value.index
        hi = hi - 1
        If hi <= lo Then Exit Do
      Loop
      If hi <= lo Then
        list(lo) = med_value
        Exit Do
      End If

      ' Swap the lo and hi values.
      list(lo) = list(hi)

      ' Look up from lo for a value >= med_value.
      lo = lo + 1
      Do While list(lo).index < med_value.index
        lo = lo + 1
        If lo >= hi Then Exit Do
      Loop
      If lo >= hi Then
        lo = hi
        list(hi) = med_value
        Exit Do
      End If

      ' Swap the lo and hi values.
      list(hi) = list(lo)
    Loop

    ' Sort the two sublists.
    Quicksort(list, min, lo - 1)
    Quicksort(list, lo + 1, max)
  End Sub

  Private Function GetContainerIndexByName(name As String) As Integer
    Dim res As Integer = -1
    Try
      For i As Integer = 0 To _container._childContainers.Count - 1
        If _containers(i).myContainer.Name = name Then
          res = i
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Private Sub UcSlots1_SlotsUpdated() Handles UcSlots1.SlotsUpdated
    UpdateSlotsPosition()

    Dim i As Integer
    Dim cont As tyContainerData

    For i = 0 To UcSlots1.Slots.Count - 1
      Dim name As String = "SLOT_" & UcSlots1.Slots(i).Slot.Index
      Dim index As Integer = GetContainerIndexByName(name)
      cont = _containers(index)
      cont.expanded = UcSlots1.Slots(i).Slot.Expanded
      cont.index = cont.slot
      _containers(index) = cont
    Next

    Quicksort(_containers, 0, _containers.Count - 1)

    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.slot = i + 1
      cont.index = cont.slot
      _containers(i) = cont
    Next
    Dim y As Double = _defaultPositionY
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.PositionAnimation.Y_init = cont.myContainer.Position.Y
      cont.PositionAnimation.Y_final = y '
      y += IIf(cont.expanded, _slotSideMax, _slotSideMin)
      cont.index = cont.slot
      _containers(i) = cont
    Next
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      Dim difY As Double = cont.PositionAnimation.Y_final - cont.PositionAnimation.Y_init

      If difY <> 0 Then
        cont.PositionAnimation.progress = 0
        cont.PositionAnimation.duration = _defaultDuration
        cont.PositionAnimation.offset = 0
        cont.index = cont.slot
      End If

      _containers(i) = cont
    Next
  End Sub

  Private Sub UcSlots1_SlotsUpdated_old()
    UpdateSlotsPosition()

    Dim i As Integer
    Dim cont As tyContainerData

    For i = 0 To UcSlots1.Slots.Count - 1
      Dim name As String = "SLOT_" & UcSlots1.Slots(i).Slot.Index
      Dim index As Integer = GetContainerIndexByName(name)
      cont = _containers(index)
      cont.slotFormer = cont.slot
      cont.slot = UcSlots1.Slots(i).Slot.Position
      cont.expanded = UcSlots1.Slots(i).Slot.Expanded
      'cont.slot = (cont.slot + 1) Mod _containers.Count
      cont.index = cont.slot
      'cont.expanded = (Rnd() > 0.8)
      _containers(index) = cont
    Next

    Quicksort(_containers, 0, _containers.Count - 1)

    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.slotFormer = cont.slot
      cont.slot = i + 1
      cont.index = cont.slot
      _containers(i) = cont
    Next
    Dim y As Double = _defaultPositionY
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      cont.PositionAnimation.Y_init = cont.myContainer.Position.Y
      cont.PositionAnimation.Y_final = y '
      y += IIf(cont.expanded, _slotSideMax, _slotSideMin)
      cont.index = cont.slot
      _containers(i) = cont
    Next
    For i = 0 To _containers.Count - 1
      cont = _containers(i)
      Dim difY As Double = cont.PositionAnimation.Y_final - cont.PositionAnimation.Y_init

      If difY <> 0 Then
        cont.PositionAnimation.progress = 0
        cont.PositionAnimation.duration = _defaultDuration
        cont.PositionAnimation.offset = 0
        cont.index = cont.slot
      End If

      _containers(i) = cont
    Next
  End Sub

  Private Sub _vizControl_TCPSocketConnected() Handles _vizControl.TCPSocketConnected
    UpdateStatusLabel()
  End Sub

  Private Sub _vizControl_TCPSocketDisconnected() Handles _vizControl.TCPSocketDisconnected
    UpdateStatusLabel()
  End Sub

  Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
    _vizControl.UnloadScenes()
    _vizControl.LoadScene(Me.SceneFullPath)
  End Sub

  Private Sub ButtonActivateScene_Click(sender As Object, e As EventArgs) Handles ButtonActivateScene.Click
    _vizControl.ActivateScene(Me.SceneFullPath)
  End Sub

  Private Sub ButtonShowDIR_VERTICAL_Click(sender As Object, e As EventArgs) Handles ButtonShowDIR_VERTICAL.Click
    _vizControl.DirectorContinue("DIR_VERTICAL")
  End Sub

  Private Sub ButtonHideDIR_VERTICAL_Click(sender As Object, e As EventArgs) Handles ButtonHideDIR_VERTICAL.Click
    _vizControl.DirectorContinueReverse("DIR_VERTICAL")
  End Sub

  Private Sub ButtonSendEachSlotInfo_Click(sender As Object, e As EventArgs) Handles ButtonSendEachSlotInfo.Click
    SendSlotsInfo()
  End Sub

  Private Sub SendSlotsInfo()
    Try
      For Each ucSlot As UCSlot In Me.UcSlots1.Slots
        SendSlotInfo(ucSlot.Slot)
      Next
      For i As Integer = Me.UcSlots1.Slots.Count To 40
        SendSlotAway(i + 1)
      Next
    Catch ex As Exception
    End Try
  End Sub

  Private Sub UpdateSlotsPosition()
    Try
      Dim action As String = "GOTO_POSITIONS:"
      Dim rootNode As String = "$ALL"
      Dim myUCSlot As UCSlot
      For pos As Integer = 1 To Me.UcSlots1.Slots.Count
        myUCSlot = Nothing
        For Each ucSlot As UCSlot In Me.UcSlots1.Slots
          If ucSlot.Slot.Position = pos Then
            myUCSlot = ucSlot
            Exit For
          End If
        Next
        If Not myUCSlot Is Nothing Then
          UpdateSlotPosition(myUCSlot.Slot)
          action = action & CStr(myUCSlot.Slot.Index) & "."
          action = action & IIf(myUCSlot.CheckBoxExpand.Checked, "1", "0") & "~"
        End If
      Next
      'For Each ucSlot As UCSlot In Me.UcSlots1.Slots
      '  UpdateSlotPosition(ucSlot.Slot)
      '  action = action & CStr(ucSlot.Slot.Index) & "~"
      'Next
      _vizControl.SetControlObjectValue(rootNode, "POSITION_CONTROL", action)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SendSlotInfo(slot As Slot)
    Try
      Dim index As Integer = slot.Index
      Dim rootNode As String = "$ALL"
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_SURNAME", slot.SurName)
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_NUMBER", slot.Number)
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_SURNAME", slot.SurName)
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_TEAM_NAME", slot.TeamName)
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_POSITION", "JUMPTO:" & slot.Position)
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_POSITION_TXT", slot.Index)

      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_ANIMATION_CONTROL", "RESET_ALL")

    Catch ex As Exception
    End Try
  End Sub

  Private Sub UpdateSlotPosition(slot As Slot)
    Try
      Dim index As Integer = slot.Index
      Dim rootNode As String = "$ALL"
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_POSITION", "GOTO:" & slot.Position)
      '_vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_ANIMATION_CONTROL", IIf(slot.Expanded, "SHOW_EXPANDED_INFO", "HIDE_EXPANDED_INFO"))

      '_vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_ANIMATION_CONTROL", IIf(slot.InPits, "SHOW_PITSTOP", "HIDE_PITSTOP"))
      '_vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_ANIMATION_CONTROL", IIf(slot.CarChanged, "SHOW_PITSTOP_STATE", "HIDE_PITSTOP_STATE"))
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SendSlotAway(index)
    Try
      Dim rootNode As String = "$ALL"
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_SURNAME", "")
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_NUMBER", "")
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_SURNAME", "")
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_TEAM_NAME", "")
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_POSITION", "JUMPTO:100")
      _vizControl.SetControlObjectValue(rootNode, "DRIVER_" & index & "_POSITION_TXT", "")
    Catch ex As Exception
    End Try
  End Sub

  Private Sub UcSlots1_Load(sender As Object, e As EventArgs) Handles UcSlots1.Load

  End Sub
End Class

