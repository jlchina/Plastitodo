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

    Function GetFolios(ByVal prov As String, fecha As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select o.folio, td.descripcion as tipo_documento,p.Nombre as proveedor,o.id_prov,o.usuario_comp,o.total,o.fecha_creacion as fecha_documento
                    from orden_compra o
                    left join tipos_documento td on o.tipo = td.id
                    left join proveedor p on o.id_prov = p.idProveedor"
        Dim where = ""
        If (prov IsNot "") Then
            where = where & "Where d.nombre like '%" & prov & "%'"
        End If

        If (fecha IsNot "") Then
            If (where IsNot "") Then
                where = where & " and date(o.fecha_creacion) = '" & fecha & "'"
            Else
                where = where & " Where date(o.fecha_creacion) = '" & fecha & "'"
            End If
        End If

        sql = sql & where

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

    Function GetDocCompra(ByVal folio As Integer, tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select OC.*,p.Nombre as proveedor, date(oc.fecha_creacion) as fecha
                    from orden_compra oc
                    left join proveedor p on oc.id_prov = p.idProveedor
                    Where oc.folio = @folio and oc.tipo = @tipo;"
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

    Function EntradaCompras(ByVal folio As Integer, tipocompras As Integer, proveedor As Integer, plazo As Integer, usuario As String, comentarios As String, subtotal As Decimal, iva As Decimal, total As Decimal, lineas As DataSet)
        Dim folio_compras As Integer
        Dim tipo_compras As Integer
        Dim sql = Nothing
        Dim prov As Integer = proveedor
        Dim user As String = usuario
        tipo_compras = tipocompras

        If tipo_compras = 3 Then
            tipo_compras = 4
        End If

        If (folio) Then
            folio_compras = folio
            sql = "UPDATE orden_compra SET
                    folio = @folio,
                    tipo = @tipo,
                    id_prov = @id_prov,
                    plazo = @plazo,
                    usuario_comp = @usuario_comp,
                    comentarios = @comentarios,
                    subtotal = @subtotal,
                    iva = @iva,
                    total = @total
                    WHERE folio = @folio and tipo = @tipo;"
        Else
            MsgBox("No se ha podido actualizar la orden de compra, revise la información")
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
            cmd.Parameters.Add(New MySqlParameter("@folio", folio))
            cmd.Parameters.Add(New MySqlParameter("@tipo", tipo_compras))
            cmd.Parameters.Add(New MySqlParameter("@id_prov", prov))
            cmd.Parameters.Add(New MySqlParameter("@plazo", plazo))
            cmd.Parameters.Add(New MySqlParameter("@comentarios", comentarios))
            cmd.Parameters.Add(New MySqlParameter("@usuario_comp", user))
            cmd.Parameters.Add(New MySqlParameter("@subtotal", subtotal))
            cmd.Parameters.Add(New MySqlParameter("@iva", iva))
            cmd.Parameters.Add(New MySqlParameter("@total", total))
            'cmd.Parameters.Add(New MySqlParameter("@id_usuario", Id_usuario))
            'If (folio) Then
            '    cmd.Parameters.Add(New MySqlParameter("@folio", folio))
            'End If
            cmd.ExecuteNonQuery()

            If (folio) Then
            Else
                folio_compras = CInt(cmd.LastInsertedId)
            End If

            For Each dr As DataRow In lineas.Tables(0).Rows
                Dim sql2 = ""

                If (folio) Then
                    sql2 = "UPDATE plastibolsas.orden_detalle SET
                            folio = @folio,
                            tipo = @tipo,
                            id_prod = (Select cp.id from catalogo_productos cp where cp.codigo_barras = @codigo Limit 1),
                            cant = @cant,
                            id_pres = (Select cp.presentacion from catalogo_productos cp where cp.codigo_barras = @id_prod Limit 1),
                            precio = @precio,
                            descuento = @descuento,
                            id_iva = 1,
                            subtotal = @subtotal,
                            iva = @iva,
                            total = @total
                            WHERE id = @id;"
                End If

                cmd3 = New MySqlCommand(sql2, conn)
                cmd3.Parameters.Add(New MySqlParameter("@folio", folio_compras))
                cmd3.Parameters.Add(New MySqlParameter("@tipo", tipo_compras))
                cmd3.Parameters.Add(New MySqlParameter("@id_prod", dr(1)))
                cmd3.Parameters.Add(New MySqlParameter("@cant", dr(2)))
                cmd3.Parameters.Add(New MySqlParameter("@id_prod", dr(2)))
                cmd3.Parameters.Add(New MySqlParameter("@precio", dr(3)))
                cmd3.Parameters.Add(New MySqlParameter("@descuento", dr(4)))
                cmd3.Parameters.Add(New MySqlParameter("@subtotal", dr(5)))
                cmd3.Parameters.Add(New MySqlParameter("@iva", dr(6)))
                cmd3.Parameters.Add(New MySqlParameter("@total", dr(7)))
                'If (folio) Then
                '    cmd3.Parameters.Add(New MySqlParameter("@id", dr(0)))
                'End If
                cmd3.ExecuteNonQuery()

                cmd2 = New MySqlCommand("Update inventario SET existencia = (Select * from (select (i.existencia+@cantidad) from inventario i where i.codigo_barras = @codigo Limit 1)t)  WHERE codigo_barras = @codigo", conn)
                cmd2.Parameters.Add(New MySqlParameter("@codigo", dr(1)))
                cmd2.Parameters.Add(New MySqlParameter("@cantidad", dr(2)))
                cmd2.ExecuteScalar()

            Next
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
End Module
