
Imports System.Reflection

Public NotInheritable Class AppSettings
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of AppSettings)(Function() New AppSettings(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()

  End Sub

  Public Shared ReadOnly Property Instance() As AppSettings
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

#Region "Properties"
  Public Property VizrtHost As String = "localhost"
  Public Property VizrtPort As Integer = 6100
  Public Property ShowOptions As Boolean = True

  Public Property SceneBasePath As String = "FORMULA_E"
  Public Property SceneName As String = "11"
#End Region

  Public Function LlegirConfiguracio(ByVal niNumConfig As Integer) As AppSettings
    Dim sTemp As String = ""
    Dim CMyRegConfig As New RegistryHelper(My.Application.Info.Title, "Config", niNumConfig)

    Dim t As Type = GetType(AppSettings)
    For Each member As MemberInfo In t.GetMembers
      Select Case member.MemberType
        Case MemberTypes.Field
          Debug.Print("This is a field " & member.Name)
        Case MemberTypes.Property
          Debug.Print("This is a property " & member.Name)
          Dim pi As PropertyInfo = t.GetProperty(member.Name)
          Select Case pi.PropertyType.ToString
            Case "System.String"
              Dim value As String = pi.GetValue(AppSettings.Instance)
              value = CStr(CMyRegConfig.ReadValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
              pi.SetValue(AppSettings.Instance, value)
            Case "System.Integer"
              Dim value As Integer = pi.GetValue(AppSettings.Instance)
              value = CInt(CMyRegConfig.ReadValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
              pi.SetValue(AppSettings.Instance, value)
            Case "System.Boolean"
              Dim value As Boolean = pi.GetValue(AppSettings.Instance)
              value = CBool(CMyRegConfig.ReadValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
              pi.SetValue(AppSettings.Instance, value)
          End Select
      End Select
    Next

    Return AppSettings.Instance
  End Function

  Public Sub Save()
    Try
      Me.DesarConfiguracio(0)
    Catch ex As Exception
      'WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub DesarConfiguracio(ByVal niNumConfig As Integer)
    Dim CMyRegConfig As New RegistryHelper(My.Application.Info.Title, "Config", niNumConfig)
    Dim t As Type = GetType(AppSettings)

    For Each member As MemberInfo In t.GetMembers
      Select Case member.MemberType
        Case MemberTypes.Field
          Debug.Print("This is a field " & member.Name)
        Case MemberTypes.Property
          Debug.Print("This is a property " & member.Name)
          Dim pi As PropertyInfo = t.GetProperty(member.Name)
          Select Case pi.PropertyType.ToString
            Case "System.String"
              Dim value As String = pi.GetValue(AppSettings.Instance)
              CMyRegConfig.WriteValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
            Case "System.Integer"
              Dim value As Integer = pi.GetValue(AppSettings.Instance)
              CMyRegConfig.WriteValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
            Case "System.Boolean"
              Dim value As Boolean = pi.GetValue(AppSettings.Instance)
              CMyRegConfig.WriteValue(member.Name, value, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
          End Select
      End Select
    Next

    CMyRegConfig = Nothing
  End Sub

End Class
