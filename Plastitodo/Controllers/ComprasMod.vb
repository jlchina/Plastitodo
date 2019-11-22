﻿Imports Plastitodo.conexion
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
End Module
