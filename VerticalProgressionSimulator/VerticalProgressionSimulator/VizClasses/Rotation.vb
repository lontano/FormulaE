Public Class Rotation
  Public VizID As Integer = 0
  Public XYZ As New Vertex

  Public Property X() As Double
    Get
      Return Me.XYZ.X
    End Get
    Set(ByVal value As Double)
      Me.XYZ.X = value
    End Set
  End Property

  Public Property Y() As Double
    Get
      Return Me.XYZ.Y
    End Get
    Set(ByVal value As Double)
      Me.XYZ.Y = value
    End Set
  End Property

  Public Property Z() As Double
    Get
      Return Me.XYZ.Z
    End Get
    Set(ByVal value As Double)
      Me.XYZ.Z = value
    End Set
  End Property

  Public Overrides Function ToString() As String
    Return XYZ.ToString
  End Function
End Class
