﻿Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module UsuariosMod
    Function GetUsuarios()
        Dim ds As DataSet = New DataSet
        Dim sql = "select u.id,u.username, CONCAT(u.nombre, ' ', u.ap_paterno,' ',ifnull(u.ap_materno,'')) as nombre_usuario, p.nombre as perfil from usuarios u left join perfiles p on u.id_perfil = p.id"
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

    Function GetDatosUsuario(ByVal id As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM usuarios WHERE id = @id_usuario"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@id_usuario", id))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function
    Function AgregarUsuario(ByVal id As Integer, nombre As String, ap_paterno As String, ap_materno As String, id_perfil As Integer, username As String, password As String)
        Dim sql = Nothing
        If (id) Then
            sql = "UPDATE usuarios SET username = @username,nombre = @nombre ,ap_paterno = @ap_paterno, ap_materno = @ap_materno, id_perfil = @id_perfil "
            If (password <> Nothing And password <> "") Then
                sql = sql & ", password = @password "
            End If

            sql = sql & "WHERE id = @id"
        Else
            sql = "INSERT INTO usuarios (username,password,nombre,ap_paterno,ap_materno,id_perfil) VALUES (@username,@password,@nombre,@ap_paterno,@ap_materno,@id_perfil)"
        End If


        Try
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@username", username))
            If (password <> Nothing And password <> "") Then
                cmd.Parameters.Add(New MySqlParameter("@password", password))
            End If
            cmd.Parameters.Add(New MySqlParameter("@nombre", nombre))
            cmd.Parameters.Add(New MySqlParameter("@ap_paterno", ap_paterno))
            cmd.Parameters.Add(New MySqlParameter("@ap_materno", ap_materno))
            cmd.Parameters.Add(New MySqlParameter("@id_perfil", id_perfil))
            If (id) Then
                cmd.Parameters.Add(New MySqlParameter("@id", id))
            End If

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
End Module
