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

    Function InsertPerfil(ByVal nombre As String, descripcion As String, list As Array)

        Dim sql = "INSERT INTO perfiles (nombre,descripcion) VALUES (@nombre,@descripcion)"

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
            cmd.ExecuteNonQuery()
            Dim id_result As Integer = CInt(cmd.LastInsertedId)
            Dim sql2 = "INSERT INTO relacion_perfiles_modulos (id_perfil,id_modulo) VALUES "
            Dim valid As Boolean = False
            For Each row As Integer In list
                If (valid) Then
                    sql2 = sql2 & ",(" & id_result & "," & row & ")"
                Else
                    sql2 = sql2 & "(" & id_result & "," & row & ")"
                    valid = True
                End If
            Next
            'Iniciar comando de conexion
            cmd2 = New MySqlCommand(sql2, conn)
            cmd2.ExecuteScalar()

            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 1
    End Function

End Module
