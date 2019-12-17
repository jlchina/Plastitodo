Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module ComprasMod
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

    Function GetDetalleOrdenCompra(ByVal folio As Integer, tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select od.id,cp.codigo_barras,cp.descripcion,pp.presentacion,od.cant,od.precio,od.subtotal,od.descuento,od.iva,od.total,ifnull(i.existencia,0) as stock
                    From orden_detalle od
                    left join catalogo_productos cp on od.id_prod = cp.id
                    left join presentacion_prod pp on od.id_pres = pp.id_pp
                    left join inventario i on cp.codigo_barras = i.codigo_barras
                    Where od.folio = @folio"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@folio", folio))
            cmd.Parameters.Add(New MySqlParameter("@tipo", tipo))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function EntradaCompras(ByVal folio As Integer, tipocompras As Integer, proveedor As Integer, plazo As Integer, usuario As String, comentarios As String, subtotal As Decimal, iva As Decimal, total As Decimal, lineas As DataSet, fa_not As String)
        Dim folio_compras As Integer
        Dim tipo_compras As Integer
        Dim fac_not As String
        Dim sql = Nothing
        Dim sql2 = Nothing
        Dim prov As Integer = proveedor
        Dim user As String = usuario

        tipo_compras = tipocompras
        fac_not = fa_not

        If tipo_compras = 3 Then
            tipo_compras = 4
        End If

        sql = "UPDATE orden_compra SET
                    folio = @folio,
                    tipo = @tipo,
                    id_prov = @id_prov,
                    plazo = @plazo,
                    factura_nota = @fn,
                    usuario_comp = @usuario_comp,
                    comentarios = @comentarios,
                    subtotal = @subtotal,
                    iva = @iva,
                    total = @total
                    WHERE folio = @folio;"
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
            cmd.Parameters.Add(New MySqlParameter("@folio", folio))
            cmd.Parameters.Add(New MySqlParameter("@tipo", tipo_compras))
            cmd.Parameters.Add(New MySqlParameter("@id_prov", prov))
            cmd.Parameters.Add(New MySqlParameter("@plazo", plazo))
            cmd.Parameters.Add(New MySqlParameter("@fn", fac_not))
            cmd.Parameters.Add(New MySqlParameter("@comentarios", comentarios))
            cmd.Parameters.Add(New MySqlParameter("@usuario_comp", user))
            cmd.Parameters.Add(New MySqlParameter("@subtotal", subtotal))
            cmd.Parameters.Add(New MySqlParameter("@iva", iva))
            cmd.Parameters.Add(New MySqlParameter("@total", total))
            cmd.ExecuteScalar()

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la tabla que contiene la orden de compra", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        Try

            If (folio) Then
            Else
                folio_compras = CInt(cmd.LastInsertedId)
            End If

            For Each dr As DataRow In lineas.Tables(0).Rows
                sql2 = "UPDATE orden_detalle SET
                            folio = @folio,
                            tipo = @tipo,
                            id_prod = (Select cp.id from catalogo_productos cp where cp.codigo_barras = @codigo Limit 1),
                            cant = @cant,
                            id_pres = (Select cp.presentacion from catalogo_productos cp where cp.codigo_barras = @codigo Limit 1),
                            precio = @precio,   
                            descuento = @descuento,
                            id_iva = 1,
                            subtotal = @subtotal,
                            iva = @iva,
                            total = @total
                            WHERE id = @id;"

                'Iniciar comando de conexion
                cmd = New MySqlCommand(sql2, conn)

                '---Abir conexion
                conn = New MySqlConnection
                conn.ConnectionString = ConnectionString2
                conn.Open()
                'Iniciar comando de conexion
                cmd3 = New MySqlCommand(sql2, conn)

                cmd3.Parameters.Add(New MySqlParameter("@folio", folio_compras))
                cmd3.Parameters.Add(New MySqlParameter("@tipo", tipo_compras))
                cmd3.Parameters.Add(New MySqlParameter("@codigo", dr(1)))
                cmd3.Parameters.Add(New MySqlParameter("@cant", dr(2)))
                cmd3.Parameters.Add(New MySqlParameter("@precio", dr(3)))
                cmd3.Parameters.Add(New MySqlParameter("@descuento", dr(4)))
                cmd3.Parameters.Add(New MySqlParameter("@subtotal", dr(5)))
                cmd3.Parameters.Add(New MySqlParameter("@iva", dr(6)))
                cmd3.Parameters.Add(New MySqlParameter("@total", dr(7)))
                cmd3.Parameters.Add(New MySqlParameter("@id", dr(0)))
                cmd3.ExecuteScalar()

                'aqui se insertara una funcion que mande llamar a una consulta para saber si ya existe o no 
                'el codigo en la tabla de inventarios, ya que como esta actualmente no inserta si no existe
                cmd2 = New MySqlCommand("Update inventario SET existencia = (Select * from (select (i.existencia+@cant) from inventario i where i.codigo_barras = @codigo Limit 1)t)  WHERE codigo_barras = @codigo", conn)
                cmd2.Parameters.Add(New MySqlParameter("@codigo", dr(1)))
                cmd2.Parameters.Add(New MySqlParameter("@cant", dr(2)))
                cmd2.ExecuteScalar()

            Next
            conn.Close()
            'Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la tabla que contiene el detalle de la orden de compra", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
End Module
