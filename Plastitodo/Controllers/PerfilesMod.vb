Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module PerfilesMod
    Function GetPerfiles()
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM perfiles"
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

    Function GetModulos()
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM modulos"
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

    Function GetDatosPerfil(ByVal id As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM perfiles WHERE id = @id_perfil"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@id_perfil", id))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function GetDatosModulosPerfil(ByVal id As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT m.id,m.nombre FROM relacion_perfiles_modulos rpm LEFT JOIN modulos m ON rpm.id_modulo = m.id WHERE rpm.id_perfil = @id_perfil"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@id_perfil", id))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function GuardarPerfil(ByVal id As Integer, nombre As String, descripcion As String, list As Array)
        Dim id_perfil As Integer

        Dim sql
        If (id) Then
            id_perfil = id
            sql = "UPDATE perfiles SET nombre = @nombre, descripcion = @descripcion WHERE id = @id_perfil"
        Else
            sql = "INSERT INTO perfiles (nombre,descripcion) VALUES (@nombre,@descripcion)"
        End If

        Try
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)

            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@nombre", nombre))
            cmd.Parameters.Add(New MySqlParameter("@descripcion", descripcion))
            If (id) Then
                cmd.Parameters.Add(New MySqlParameter("@id_perfil", id_perfil))
            End If
            cmd.ExecuteNonQuery()

            If (id) Then
                cmd3 = New MySqlCommand("DELETE FROM relacion_perfiles_modulos WHERE id_perfil = @id_perfil", conn)
                cmd3.Parameters.Add(New MySqlParameter("@id_perfil", id_perfil))
                cmd3.ExecuteScalar()
            Else
                id_perfil = CInt(cmd.LastInsertedId)
            End If

            Dim sql2 = "INSERT INTO relacion_perfiles_modulos (id_perfil,id_modulo) VALUES "
            Dim valid As Boolean = False
            For Each row As Integer In list
                If (valid) Then
                    sql2 = sql2 & ",(" & id_perfil & "," & row & ")"
                Else
                    sql2 = sql2 & "(" & id_perfil & "," & row & ")"
                    valid = True
                End If
            Next
            'Iniciar comando de conexion
            cmd3 = New MySqlCommand(sql2, conn)
            cmd3.ExecuteScalar()

            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 1
    End Function

End Module
