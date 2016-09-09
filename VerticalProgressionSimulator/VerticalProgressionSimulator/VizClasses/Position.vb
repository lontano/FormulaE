Public Class Position
  Public VizID As Integer = 0
  Public XYZ As New Vertex

  Public Event DataChanged(ByVal sender As Position)

  Public Property X() As Double
    Get
      Return Me.XYZ.X
    End Get
    Set(ByVal value As Double)
      Me.XYZ.X = value
      RaiseEvent DataChanged(Me)
    End Set
  End Property

  Public Property Y() As Double
    Get
      Return Me.XYZ.Y
    End Get
    Set(ByVal value As Double)
      Me.XYZ.Y = value
      RaiseEvent DataChanged(Me)
    End Set
  End Property

  Public Property Z() As Double
    Get
      Return Me.XYZ.Z
    End Get
    Set(ByVal value As Double)
      Me.XYZ.Z = value
      RaiseEvent DataChanged(Me)
    End Set
  End Property

  Public Overrides Function ToString() As String
    Return XYZ.ToString
  End Function
End Class

