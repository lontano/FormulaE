Public Class Uuid
  Private _guid As Guid = Guid.NewGuid

  Public ReadOnly Property FullString() As String
    Get
      Return "<" & _guid.ToString & ">"
    End Get
  End Property

  Public ReadOnly Property [String]() As String
    Get
      Return "<" & _guid.ToString & ">"
    End Get
  End Property

  Public Sub GenerateNewUuid()
    _guid = Guid.NewGuid
  End Sub
End Class
