Public Class Container
  Public Uuid As New Uuid
  Public vizId As Integer = 0

  Public Event Clicked(ByVal sender As Container, ByVal e As System.EventArgs)

  Public ParentContainer As Container = Nothing

  Public _childContainers As New List(Of Container)

  Public ReadOnly Property ChildContainer() As Container
    Get
      If _childContainers.Count > 0 Then
        Return _childContainers(0)
      Else
        Return New Container()
      End If
    End Get
  End Property

  Public ReadOnly Property FirstChildContainer() As Container
    Get
      If _childContainers.Count > 0 Then
        Return _childContainers(0)
      Else
        Return New Container()
      End If
    End Get
  End Property

  Public ReadOnly Property LastChildContainer() As Container
    Get
      If _childContainers.Count > 0 Then
        Return _childContainers(_childContainers.Count - 1)
      Else
        Return New Container()
      End If
    End Get
  End Property

  Public ReadOnly Property ChildContainerCount() As Integer
    Get
      Return _childContainers.Count
    End Get
  End Property

  Public Function GetChildContainerByIndex(ByVal index As Integer) As Container
    Dim res As Container = New Container
    If index < _childContainers.Count Then
      res = _childContainers(index)
    End If
    Return res
  End Function

  Private _name As String = ""
  Public Overloads Property Name() As String
    Get
      Return _name
    End Get
    Set(ByVal value As String)
      _name = value
      UpdateLabels()
    End Set
  End Property

#Region "Position"
  Private WithEvents _position As New Position
  Private _updating As Boolean

  Public Property Position() As Position
    Get
      Return _position
    End Get
    Set(ByVal value As Position)
      _position = value
      UpdateLabels()
    End Set
  End Property

  Private Sub _position_DataChanged(ByVal sender As Position) Handles _position.DataChanged
    Me.Left = _position.X
    Me.Top = _position.Y
    'Me.UpdateLabels()
  End Sub
#End Region

  Private _rotation As New Rotation
  Public Property Rotation() As Rotation
    Get
      Return _rotation
    End Get
    Set(ByVal value As Rotation)
      _rotation = value
      'UpdateLabels()
    End Set
  End Property

  Private _scaling As New Scaling
  Public Property Scaling() As Scaling
    Get
      Return _scaling
    End Get
    Set(ByVal value As Scaling)
      _scaling = value
      ' UpdateLabels()
    End Set
  End Property

  Private Sub UpdateLabels()
    Me.LabelName.Text = _name
    'Me.LabelPosition.Text = _position.ToString
    'Me.LabelRotation.Text = _rotation.ToString
    'Me.LabelScaling.Text = _scaling.ToString
  End Sub

  Private Sub LabelName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelName.Click
    RaiseEvent Clicked(Me, e)
  End Sub
End Class
