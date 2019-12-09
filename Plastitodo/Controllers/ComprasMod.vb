Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module ComprasMod
    Public usuariolog As String
    Public iduser As Integer
    Function GetProveedorByID(ByVal id_prov As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM proveedor p WHERE p.idProveedor = @id;"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@id", id_prov))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function GetProveedores(ByVal descripcion As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM proveedor p WHERE p.Nombre Like '%" & descripcion & "%' ORDER BY p.Nombre LIMIT 25;"
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

    Function GetEntradaProducto(ByVal codigo As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT cp.*, p.presentacion as unidad, ifnull(i.existencia,0) as stock,ifnull((select ifnull(hp.p_publico,0) from historico_preciopublico hp where hp.id_catalogo = cp.id order by hp.id desc Limit 1),0) as precio_publico
                    FROM catalogo_productos cp
                    LEFT JOIN presentacion_prod p on cp.presentacion = p.id_pp
                    LEFT JOIN inventario i on cp.codigo_barras = i.codigo_barras
                    WHERE cp.codigo_barras = @codigo  LIMIT 1;"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@codigo", codigo))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function DocumentoCompras(ByVal folio As Integer, ByVal tipo As Integer, prov As Integer, plazo As Integer, usuario As String, comentarios As String, subtotal As Decimal, iva As Decimal, total As Decimal, lineas As DataSet)

        Try
            Dim sql As String = Nothing
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            sql = "INSERT INTO orden_compra (folio, tipo, id_prov, plazo, usuario_comp, comentarios, subtotal, iva, total)" & Chr(13) &
                    "VALUES (@folio, @tipo, @id_prov, @plazo, @usuario_comp, @comentarios, @subtotal, @iva, @total)"
            cmd = New MySqlCommand(sql, conn)

            'Pasar parametros
            cmd.Parameters.AddWithValue("@folio", folio)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            cmd.Parameters.AddWithValue("@id_prov", prov)
            cmd.Parameters.AddWithValue("@plazo", plazo)
            cmd.Parameters.AddWithValue("@usuario_comp", usuario)
            cmd.Parameters.AddWithValue("@comentarios", comentarios)
            cmd.Parameters.AddWithValue("@subtotal", subtotal)
            cmd.Parameters.AddWithValue("@iva", iva)
            cmd.Parameters.AddWithValue("@total", total)

            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try

            For Each dr As DataRow In lineas.Tables(0).Rows
                Dim sql2 As String = Nothing

                '---Abir conexion
                conn = New MySqlConnection
                conn.ConnectionString = ConnectionString2
                conn.Open()

                sql2 = "INSERT INTO orden_detalle (folio,tipo,id_prod, cant, id_pres, precio, descuento, id_iva, subtotal, iva, total)" & Chr(13) &
                    "VALUES (@folio,
                            @tipo,
                            (Select cp.id from catalogo_productos cp where cp.codigo_barras = @cod Limit 1),
                            @cant, 
                            (Select cp.presentacion from catalogo_productos cp where cp.codigo_barras = @cod Limit 1),
                            @precio,
                            @descuento,
                            1,
                            @subtotal,
                            @iva,
                            @total)"

                cmd3 = New MySqlCommand(sql2, conn)

                cmd3.Parameters.AddWithValue("@folio", folio)
                cmd3.Parameters.AddWithValue("@tipo", tipo)
                cmd3.Parameters.AddWithValue("@cod", dr(1))
                cmd3.Parameters.AddWithValue("@cant", dr(2))
                cmd3.Parameters.AddWithValue("@precio", dr(3))
                cmd3.Parameters.AddWithValue("@descuento", dr(4))
                cmd3.Parameters.AddWithValue("@subtotal", dr(5))
                cmd3.Parameters.AddWithValue("@iva", dr(6))
                cmd3.Parameters.AddWithValue("@total", dr(7))

                cmd3.ExecuteNonQuery()
                conn.Close()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return True
    End Function

    Function GetMaxFolio(ByVal tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim ultimo As Integer
        Dim sql = "Select ifnull(max(folio)+1,1) as ultimo
                    From orden_compra"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'cmd.Parameters.Add(New MySqlParameter("@tipo", tipo))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            For Each dr As DataRow In ds.Tables(0).Rows
                ultimo = CInt(dr(0))
            Next

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ultimo
    End Function
End Module
