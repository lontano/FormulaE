Imports VerticalProgressionSimulator

<Serializable()> Public Class UCSlots
  Public Event SlotsUpdated()

  'Private _slots As New List(Of UCSlot)
  Public ReadOnly Property Slots As New List(Of UCSlot)
  '  Get
  '    Dim res As New List(Of UCSlot)

  '    For Each ctl As Control In Me.PanelSlots.Controls
  '      Try
  '        Dim aux As UCSlot = CType(ctl, UCSlot)
  '        res.Add(aux)
  '      Catch ex As Exception

  '      End Try
  '    Next
  '    Return res
  '  End Get
  'End Property


  Public Sub InitSlots(count As Integer)
    Try
      For Each ucSlot As UCSlot In Me.Slots
        RemoveHandler ucSlot.SlotUpdated, AddressOf Slot_SlotUpdated
      Next

      Me.PanelSlots.Controls.Clear()

      For i As Integer = 1 To count
        Dim ucSlot As New UCSlot

        Dim slot As New Slot
        slot.Index = i
        slot.Position = i
        slot.Number = slot.Index
        slot.Name = "NAME " & slot.Number
        slot.SurName = "SURNAME " & slot.Number
        slot.ShortName = "SHRT " & slot.Number
        slot.TeamName = "TEAM " & ((slot.Number) \ 2 + 1)

        ucSlot.Slot = slot

        Me.PanelSlots.Controls.Add(ucSlot)
        Me.Slots.Add(ucSlot)
      Next

      FixSlotOrder()
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Public Sub FixSlotOrder()
    Try
      Slots.Sort()
      For i As Integer = 0 To Me.Slots.Count - 1
        Me.Slots(i).Slot.Position = i + 1
        Me.Slots(i).UpdateSlotInfo()
      Next
      ShowSlots()
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Public Sub ShowSlots()
    Try
      Dim lastY As Double = 0
      For i As Integer = 0 To Me.Slots.Count - 1
        Dim ucSlot As UCSlot = Me.Slots(i)
        ucSlot.Left = 0
        ucSlot.Height = 25
        ucSlot.BorderStyle = BorderStyle.FixedSingle
        ucSlot.Width = Me.ClientSize.Width
        ucSlot.Top = lastY + 5
        lastY = ucSlot.Top + ucSlot.Height
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Slot_SlotUpdated(sender As UCSlot)
  End Sub

  Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
    Me.FixSlotOrder()
    RaiseEvent SlotsUpdated()
  End Sub
End Class
