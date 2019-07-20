Imports Plastitodo.Globales
Imports Plastitodo.PerfilesMod
Imports System.Security.Cryptography
Public Class EditarUsuariosForm
    Dim id_usuario As Integer
    Public Sub GetData(ByVal Id As String)
        '--------->Establecer valores obtenidos del GridViewForm id_perfil
        id_usuario = Id
    End Sub
    Private Sub UsuariosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = GetPerfiles()
        CmbPerfil.DataSource = ds.Tables(0)
        CmbPerfil.DisplayMember = "nombre"
        CmbPerfil.ValueMember = "id"

        If (id_usuario) Then
            Dim DataUsuario As DataSet = GetDatosUsuario(id_usuario)
            For Each dr As DataRow In DataUsuario.Tables(0).Rows
                TxtUsuario.Text = dr(1)
                TxtContrasena.Text = dr(2)
                TxtNombre.Text = dr(3)
                TxtAPaterno.Text = dr(4)
                TxtAMaterno.Text = dr(5)
            Next
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (TxtAPaterno.Text <> "" And TxtAMaterno.Text <> "" And TxtNombre.Text <> "" And TxtUsuario.Text <> "" And TxtContrasena.Text <> "") Then
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtContrasena.Text)))
            End Using
            If (AgregarUsuario(TxtNombre.Text, TxtAPaterno.Text, TxtAMaterno.Text, CmbPerfil.SelectedValue, TxtUsuario.Text, HashedPass)) Then
                Me.Hide()
            End If
        Else
            MsgBox("Favor de Llenar todos los campos", MsgBoxStyle.Exclamation, "Información")
        End If
    End Sub
End Class