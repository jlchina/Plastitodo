Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module PrincipalMod
    Function Permisos(ByVal id_perfil As Integer)
        Dim ListaModulos As New List(Of Integer)()
        Dim sql = "SELECT rpm.id_modulo FROM relacion_perfiles_modulos rpm where rpm.id_perfil = @id_perfil"

        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@id_perfil", id_perfil))
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    '--------->Obtener valores de consulta
                    ListaModulos.Add(dr(0))

                End While
            End If

            dr.Close()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ListaModulos.ToArray
    End Function
End Module
