<Serializable()> Public Class UCSlot
  Implements IComparable

  Public Event SlotUpdated(sender As UCSlot)

  Private _initializing As Boolean = False

  Private _slot As Slot
  Public Property Slot As Slot
    Get
      Return _slot
    End Get
    Set(value As Slot)
      _slot = value
      Me.UpdateSlotInfo()
    End Set
  End Property

  Public Sub UpdateSlotInfo()
    Try
      _initializing = True
      Me.LabelIndex.Text = _slot.Index
      Me.NumericUpDownPosition.Value = _slot.Position
      Me.TextBoxNumber.Text = _slot.Number
      Me.CheckBoxExpand.Checked = _slot.Expanded
      Me.CheckBoxCarChanged.Checked = _slot.CarChanged
      Me.CheckBoxInPits.Checked = _slot.InPits
    Catch ex As Exception

    End Try
    _initializing = False
  End Sub

  Private Sub NumericUpDownPosition_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownPosition.ValueChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.Position = Me.NumericUpDownPosition.Value Then
      _slot.Position = Me.NumericUpDownPosition.Value
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub

  Private Sub CheckBoxExpand_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExpand.CheckedChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.Expanded = Me.CheckBoxExpand.Checked Then
      _slot.Expanded = Me.CheckBoxExpand.Checked
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub

  Private Sub TextBoxNumber_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumber.TextChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.Number = Me.TextBoxNumber.Text Then
      _slot.Number = Me.TextBoxNumber.Text
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub

  Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.Number = Me.TextBoxName.Text Then
      _slot.Name = Me.TextBoxName.Text
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      Dim aux As UCSlot = CType(obj, UCSlot)
      If aux.Slot.Position > Me.Slot.Position Then
        res = -1
      ElseIf aux.Slot.Position < Me.Slot.Position Then
        res = 1
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Overrides Function ToString() As String
    If Me.Slot Is Nothing Then
      Return MyBase.ToString()
    Else
      Return "index = " & Me.Slot.Index & ". position = " & Me.Slot.Position & " name = " & Me.Slot.Name
    End If

  End Function

  Private Sub CheckBoxCarChanged_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCarChanged.CheckedChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.CarChanged = Me.CheckBoxCarChanged.Checked Then
      _slot.CarChanged = Me.CheckBoxCarChanged.Checked
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub

  Private Sub CheckBoxInPits_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInPits.CheckedChanged
    If _initializing Then Exit Sub
    If _slot Is Nothing Then Exit Sub

    If Not _slot.InPits = Me.CheckBoxInPits.Checked Then
      _slot.InPits = Me.CheckBoxInPits.Checked
      RaiseEvent SlotUpdated(Me)
    End If
  End Sub
End Class
