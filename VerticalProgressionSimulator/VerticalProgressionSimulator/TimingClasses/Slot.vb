<Serializable()> Public Class Slot
  Public Index As Integer
  Public Position As Integer
  Public Name As String
  Public ShortName As String
  Public SurName As String
  Public TeamName As String
  Public Number As Integer
  Public Flag As String
  Public Color As Color
  Public DriverClass As String
  Public posGanadasOPerdidas As Integer

  Public CarChanged As Boolean = False
  Public InPits As Boolean = False

  Public Expanded As Boolean = False
End Class
