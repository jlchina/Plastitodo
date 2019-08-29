Imports Plastitodo.conexion
Imports Plastitodo.Globales
Imports MySql.Data.MySqlClient
Module VentasMod
    Function GetVendedores()
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT u.id, concat(u.nombre, ' ', u.ap_paterno, ' ', ifnull(u.ap_materno,'')) as nombre FROM usuarios u WHERE u.id_perfil = 2 AND u.estatus = 1;"
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
    Function GetClientes(ByVal descripcion As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM cliente c WHERE c.Nombre Like '%" & descripcion & "%' ORDER BY c.Nombre LIMIT 25;"
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

    Function GetSearchClientes(ByVal descripcion As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select * From cliente c
                    Where c.nombre like '%" & descripcion & "%' or c.direccion Like '%" & descripcion & "%' or c.Ciudad Like '%" & descripcion & "%';"
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

    Function GetClientesByID(ByVal id_cliente As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT * FROM cliente c WHERE c.idCliente = @id;"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@id", id_cliente))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Function GetProductos(ByVal descripcion As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT cp.codigo_barras,cp.descripcion FROM catalogo_productos cp WHERE cp.descripcion Like '%" & descripcion & "%' ORDER BY cp.descripcion LIMIT 10;"
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
    Function GetProducto(ByVal codigo As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "SELECT cp.*, p.presentacion as unidad, ifnull(i.existencia,0) as stock
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
    Function GetFolioMax(ByVal tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim ultimo As Integer
        Dim sql = "Select ifnull(max(d.folio)+1,1) as ultimo
                    From documentos d
                    Where d.id_tipo_documento =@tipo;"
        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Add(New MySqlParameter("@tipo", tipo))
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
    Function GetDocumentos(ByVal nombre As String, fecha As String)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select d.folio, td.descripcion as tipo_documento,c.Nombre as cliente, d.nombre,d.vendedor,d.total,d.fecha_creacion as fecha_documento
                    from documentos d
                    left join tipos_documento td on d.id_tipo_documento = td.id
                    left join cliente c on d.id_cliente = c.idCliente"
        Dim where = ""
        If (nombre IsNot "") Then
            where = where & "Where d.nombre like '%" & nombre & "%'"
        End If

        If (fecha IsNot "") Then
            If (where IsNot "") Then
                where = where & " and date(d.fecha_creacion) = '" & fecha & "'"
            Else
                where = where & " Where date(d.fecha_creacion) = '" & fecha & "'"
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

    Function GetDocumento(ByVal folio As Integer, tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select D.*,c.Nombre as cliente
                    from documentos d
                    left join cliente c on d.id_cliente = c.idCliente
                    Where d.folio = @folio and d.id_tipo_documento = @tipo;"
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

    Function GetLineasDocumento(ByVal folio As Integer, tipo As Integer)
        Dim ds As DataSet = New DataSet
        Dim sql = "Select ld.id,cp.codigo_barras,cp.descripcion,pp.presentacion,ld.cantidad,ld.precio,ld.subtotal,ld.descuento,ld.iva,ld.total,ifnull(i.existencia,0) as stock
                    From lineas_documento ld
                    left join catalogo_productos cp on ld.id_producto = cp.id
                    left join presentacion_prod pp on ld.id_presentacion = pp.id_pp
                    left join inventario i on cp.codigo_barras = i.codigo_barras
                    Where ld.id_documento = (select d.id from documentos d where d.folio = @folio) and ld.id_tipo_documento = @tipo;"
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

    Function DocumentoVenta(ByVal folio As Integer, id_tipo_documento As Integer, id_cliente As Integer, nombre As String, vendedor As String, comentarios As String, subtotal As Decimal, iva As Decimal, total As Decimal, lineas As DataSet)
        Dim folio_documento As Integer
        Dim id_documento As Integer

        Dim sql

        If (folio) Then
            folio_documento = folio
            sql = "UPDATE documentos
                    SET
                    id_cliente = @id_cliente,
                    nombre = @nombre,
                    vendedor = @vendedor,
                    comentarios = @comentarios,
                    subtotal = @subtotal,
                    iva = @iva,
                    total = @total,
                    id_usuario = @id_usuario
                    WHERE folio = @folio and id_tipo_documento = @id_tipo_documento;"
        Else
            sql = "INSERT INTO documentos (folio,id_tipo_documento,id_cliente,nombre,vendedor,comentarios,subtotal,iva,total,id_usuario) 
                    VALUES ((select ifnull(max(d.folio)+1,1) from documentos d Where d.id_tipo_documento = @id_tipo_documento),@id_tipo_documento,@id_cliente,@nombre,@vendedor,@comentarios,@subtotal,@iva,@total,@id_usuario)"
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
            cmd.Parameters.Add(New MySqlParameter("@id_tipo_documento", id_tipo_documento))
            cmd.Parameters.Add(New MySqlParameter("@id_cliente", id_cliente))
            cmd.Parameters.Add(New MySqlParameter("@nombre", nombre))
            cmd.Parameters.Add(New MySqlParameter("@vendedor", vendedor))
            cmd.Parameters.Add(New MySqlParameter("@comentarios", comentarios))
            cmd.Parameters.Add(New MySqlParameter("@subtotal", subtotal))
            cmd.Parameters.Add(New MySqlParameter("@iva", iva))
            cmd.Parameters.Add(New MySqlParameter("@total", total))
            cmd.Parameters.Add(New MySqlParameter("@id_usuario", Id_usuario))
            If (folio) Then
                cmd.Parameters.Add(New MySqlParameter("@folio", folio))
            End If
            cmd.ExecuteNonQuery()

            If (folio) Then
            Else
                id_documento = CInt(cmd.LastInsertedId)
            End If

            For Each dr As DataRow In lineas.Tables(0).Rows
                Dim sql2 = ""

                If (folio) Then
                    sql2 = "UPDATE plastibolsas.lineas_documento
                            SET                            
                            id_producto = (Select cp.id from catalogo_productos cp where cp.codigo_barras = @codigo),
                            cantidad = @cantidad,
                            id_presentacion = (Select cp.presentacion from catalogo_productos cp where cp.codigo_barras = @codigo),
                            precio = @precio,
                            descuento = @descuento,
                            id_iva = 1,
                            subtotal = @stotal,
                            iva = @iva,
                            total = @total
                            WHERE id = @id;"
                Else
                    sql2 = "INSERT INTO lineas_documento (id_documento,id_tipo_documento,id_producto, cantidad, id_presentacion, precio, descuento, id_iva, subtotal, iva, total) VALUES 
                            (@id_documento,
                             @id_tipo_documento,
                             (Select cp.id from catalogo_productos cp where cp.codigo_barras = @codigo),
                             @cantidad, 
                             (Select cp.presentacion from catalogo_productos cp where cp.codigo_barras = @codigo),
                             @precio,
                             @descuento,
                             1,
                             @stotal,
                             @iva,
                             @total)"

                End If
                cmd3 = New MySqlCommand(sql2, conn)
                cmd3.Parameters.Add(New MySqlParameter("@id_documento", id_documento))
                cmd3.Parameters.Add(New MySqlParameter("@id_tipo_documento", id_tipo_documento))
                cmd3.Parameters.Add(New MySqlParameter("@codigo", dr(1)))
                cmd3.Parameters.Add(New MySqlParameter("@cantidad", dr(2)))
                cmd3.Parameters.Add(New MySqlParameter("@precio", dr(3)))
                cmd3.Parameters.Add(New MySqlParameter("@descuento", dr(4)))
                cmd3.Parameters.Add(New MySqlParameter("@stotal", dr(5)))
                cmd3.Parameters.Add(New MySqlParameter("@iva", dr(6)))
                cmd3.Parameters.Add(New MySqlParameter("@total", dr(7)))
                If (folio) Then
                    cmd3.Parameters.Add(New MySqlParameter("@id", dr(0)))
                End If
                cmd3.ExecuteScalar()

                cmd2 = New MySqlCommand("Update inventario SET existencia = (Select (i.existencia-@cantidad) from inventario i where i.codigo_barras = @codigo)  WHERE codigo_barras = @codigo", conn)
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
    End Function
End Module
