Imports Plastitodo.Globales
Imports Plastitodo.UsuariosMod
Imports System.Security.Cryptography
Public Class UsuariosForm
    Private Sub UsuariosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = GetPerfiles()
        CmbPerfil.DataSource = ds.Tables(0)
        CmbPerfil.DisplayMember = "nombre"
        CmbPerfil.ValueMember = "id"
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