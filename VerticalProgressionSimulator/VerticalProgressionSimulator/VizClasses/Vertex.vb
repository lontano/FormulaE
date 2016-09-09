Public Class Vertex
  Public X As Double = 0
  Public Y As Double = 0
  Public Z As Double = 0
  Public ReadOnly Property Length() As Double
    Get
      Return Math.Sqrt(X * X + Y * Y + Z * Z)
    End Get
  End Property

  Public Overrides Function ToString() As String
    Return X & " " & Y & " " & Z
  End Function
End Class
