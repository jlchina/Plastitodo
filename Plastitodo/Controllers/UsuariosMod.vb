Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module UsuariosMod
    Function AgregarUsuario(ByVal nombre As String, ap_paterno As String, ap_materno As String, id_perfil As Integer, username As String, password As String)
        Dim sql = "INSERT INTO usuarios (username,password,nombre,ap_paterno,ap_materno,id_perfil) VALUES (@username,@password,@nombre,@ap_paterno,@ap_materno,@id_perfil)"

        Try
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@username", username))
            cmd.Parameters.Add(New MySqlParameter("@password", password))
            cmd.Parameters.Add(New MySqlParameter("@nombre", nombre))
            cmd.Parameters.Add(New MySqlParameter("@ap_paterno", ap_paterno))
            cmd.Parameters.Add(New MySqlParameter("@ap_materno", ap_materno))
            cmd.Parameters.Add(New MySqlParameter("@id_perfil", id_perfil))

            Using conn As New MySqlConnection(ConnectionString2)
                If conn.State = ConnectionState.Closed Then
                    cmd.Connection = conn
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End If
                'cmd.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 1
    End Function

    Function GetPerfiles()
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT id,nombre FROM perfiles"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function
End Module
