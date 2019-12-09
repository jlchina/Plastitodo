Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_ingresar.Click

        'Verificar que el usuario y contraseña no vienen vacios
        If txt_user.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Por favor completa los campos solicitados", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_user.Focus()
        Else
            'Conectar a Base de Datos
            Try
                Dim HashedPass As String = ""

                'Encriptar contraseña
                Using MD5hash As MD5 = MD5.Create()
                    HashedPass = System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(txt_pass.Text)))
                End Using

                Dim sql = "Select * From usuarios Where username=@username and password=@password"
                Dim Nombre As String
                Nombre = Nothing

                '---Abir conexion
                conn = New MySqlConnection
                conn.ConnectionString = ConnectionString2
                conn.Open()
                'Iniciar comando de conexion
                cmd = New MySqlCommand(sql, conn)
                'Pasar parametros
                cmd.Parameters.Add(New MySqlParameter("@username", txt_user.Text))
                cmd.Parameters.Add(New MySqlParameter("@password", HashedPass))
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        '--------->Obtener valores de consulta
                        Nombre = dr.Item("nombre")
                        Id_perfil = dr.Item("id_perfil")
                        Id_usuario = dr.Item("id")
                        UserName = dr.Item("username")
                    End While
                End If
                usuariolog = Nombre
                iduser = Id_usuario
                dr.Close()
                conn.Close()

                If Nombre <> "" Then
                    Principal.Show()
                    Me.Hide()
                Else
                    'Si el usuario ingresa incorrectamente usuario y contraseña
                    'Mostrar mensaje
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Limpiar cajas
                    txt_user.Text = ""
                    txt_pass.Text = ""

                    txt_user.Focus()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txt_pass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MessageBox.Show("Enter")
            Btn_ingresar_Click(sender, e)
        End If
    End Sub

End Class