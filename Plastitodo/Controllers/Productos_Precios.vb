Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient

Module Productos_Precios
    Function GetHistoricoCosto(ByVal Id_Prov As Integer, id_catprod As Integer, precio_cto As Single)    'Funcion para ingresar el historico de costos desde la creacion del producto o actualizacion de costo
        Dim ultimo_id As Integer
        Dim status As Boolean = False

        Try
            'Se inicializa la conexion a la BD JLCS
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'campos a ingresar en la BD desde el formulario
            comando = New MySqlCommand("INSERT INTO historico_costos(Id_Prov, id_catprod, precio_cto)" & Chr(13) &
                                       "VALUES(@Id_Prov, @id_catprod, @precio_cto)", con_string)
            comando.Parameters.AddWithValue("@Id_Prov", Id_Prov)
            comando.Parameters.AddWithValue("@id_catprod", id_catprod)
            comando.Parameters.AddWithValue("@precio_cto", precio_cto)
            comando.ExecuteNonQuery()

            ultimo_id = CInt(comando.LastInsertedId)

            MsgBox("Producto guardado con exito")
            con_string.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If ultimo_id Then
            status = True
        End If

        Return status

    End Function

    Function GetProductoCodigo(ByVal cbarras As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT cp.codigo_barras,cp.descripcion FROM catalogo_productos cp WHERE cp.descripcion Like '%" & cbarras & "%' ORDER BY cp.descripcion LIMIT 3;"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'cmd.Parameters.Add(New MySqlParameter("@descripcion", descripcion))
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
