﻿Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Rep_Grid
    Dim reporte As String = Nothing
    Public Sub Obt_Tipo_Reporte(ByVal TR As String)
        'Para obtener datos del formulario de reportes para obtener el tipo de reporte a generar
        reporte = TR
    End Sub
    Private Sub Btn_Busq_Inv_Click(sender As Object, e As EventArgs) Handles Btn_Busq_Inv.Click
        Try
            Dim query2 As String
            Dim query As String
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim bandera As Integer
            Dim adap As New MySqlDataAdapter
            Dim adap2 As New MySqlDataAdapter

            If Txt_CodBar_Inv.Text = "" Then
                query2 = "Select * from inventario where codigo_barras like ?"
                query = "Select * from catalogo_productos 
                        left JOIN marcas on catalogo_productos.marca = marcas.id
                        left JOIN presentacion_prod on catalogo_productos.presentacion = presentacion_prod.id_pp
                        where codigo_barras like ?"
                bandera = 1
            Else
                query2 = "Select * from inventario where codigo_barras = '" & Txt_CodBar_Inv.Text & "'"
                query = "Select * from catalogo_productos 
                        left JOIN marcas on catalogo_productos.marca = marcas.id
                        left JOIN presentacion_prod on catalogo_productos.presentacion = presentacion_prod.id_pp
                        where codigo_barras = '" & Txt_CodBar_Inv.Text & "'"
                bandera = 2
            End If

            If bandera = 1 Then
                adap = New MySqlDataAdapter(query, conexion)
                adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & Txt_CodBar_Inv.Text & "%")
                adap2 = New MySqlDataAdapter(query2, conexion)
                adap2.SelectCommand.Parameters.AddWithValue("@p1", "%" & Txt_CodBar_Inv.Text & "%")
            Else
                adap = New MySqlDataAdapter(query, conexion)
                adap2 = New MySqlDataAdapter(query2, conexion)
            End If

            Dim dt As New DataTable
            Dim dtde As New DataTable
            Dim datafull As New DataTable
            adap.Fill(dt)
            adap2.Fill(dtde)

            datafull.Clear() ' armado de datagrid con las 2 consultas
            datafull.Columns.Add("codigo_barras", GetType(String))
            datafull.Columns.Add("descripcion", GetType(String))
            datafull.Columns.Add("presentacion", GetType(String))
            datafull.Columns.Add("precio")
            datafull.Columns.Add("marca", GetType(String))
            datafull.Columns.Add("existencia", GetType(Int32))
            datafull.Columns.Add("Inv Cto")

            Dim invcto As Double = Nothing

            For Each CP As DataRow In dt.Rows
                Dim dr As DataRow
                dr = datafull.NewRow()
                For Each DE As DataRow In dtde.Rows
                    If (CP("codigo_barras") = DE("codigo_barras")) Then

                        dr("codigo_barras") = CP(1)
                        dr("descripcion") = CP(4)
                        dr("presentacion") = CP(12)
                        dr("precio") = Format(CDec(CP(6)), "$ #,###,##0.00")
                        dr("marca") = CP(10)
                        dr("existencia") = DE("existencia")
                        invcto = DE("existencia") * CP(6)
                        dr("Inv Cto") = Format(CDec(invcto), "$ #,###,##0.00")
                        datafull.Rows.Add(dr)
                    End If
                Next

                'Determinar el alto de las filas
                DGV_Reporte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DGV_Reporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                DGV_Reporte.BackgroundColor = Color.AliceBlue
                DGV_Reporte.AllowUserToAddRows = False
                DGV_Reporte.ReadOnly = True       'El control DataGridView será de sólo lectura
            Next

            'crear archivo XML para generar reporte
            Dim dsxml As New DataSet
            dsxml.Tables.Add(datafull)
            dsxml.WriteXml("c:\XML\inventario.xml", XmlWriteMode.WriteSchema)

            If dt.Rows.Count > 0 Then
                DGV_Reporte.DataSource = dt
                DGV_Reporte.DataSource = datafull
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Btn_report.Enabled = True
    End Sub

    Private Sub Rep_Grid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (reporte <> Nothing) Then
            Select Case reporte
                Case "inventario"
                    Lbl_reporte.Text = "REPORTE DE INVENTARIOS"
                    Panel_Inv.Visible = True
                    Panel_hist_cto.Visible = False
                Case "ventas"
                    Panel_Inv.Visible = False
                    Panel_hist_cto.Visible = False
                Case "historico_c"
                    Lbl_reporte.Text = "REPORTE DE HISTORICO DE COSTOS"
                    Panel_Inv.Visible = False
                    Panel_hist_cto.Visible = True
                Case "historico_v"
                    Panel_Inv.Visible = False
                    Panel_hist_cto.Visible = False
            End Select
        End If
        Btn_report.Enabled = False
    End Sub

    Private Sub Btn_Hist_Cto_busq_Click(sender As Object, e As EventArgs) Handles Btn_Hist_Cto_busq.Click
        Dim sql As String = Nothing
        Dim sql2 As String = Nothing
        Dim ds As DataSet = New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable()
        Dim idprod As Integer = Nothing
        Dim dacod As New MySqlDataAdapter
        Dim dscod As New DataSet
        Dim fechac As Date

        If Txt_codigo_HC.Text <> "" Then    'Valida si se ingreso un codigo en el textbox de busqueda

            'obtener el id de producto para generar la consulta en la tabla de historico de costos
            Try
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()
                sql2 = "SELECT id FROM catalogo_productos where codigo_barras ='" & Txt_codigo_HC.Text & "'"
                dacod = New MySqlDataAdapter(sql2, con_string)
                dscod = New DataSet
                dacod.Fill(dscod)
                con_string.Close()
                For Each drcod As DataRow In dscod.Tables(0).Rows
                    idprod = drcod(0)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al conectarse a la base de datos")
            End Try

            'comprueba si se guardo el valor de id de producto para generar la consulta en la tabla de historico de costos
            If (idprod) Then
                Try
                    con_string = New MySqlConnection
                    con_string.ConnectionString = ConnectionString2
                    con_string.Open()
                    sql = "SELECT * FROM historico_costos 
                        LEFT JOIN catalogo_productos ON historico_costos.`id_catprod` = catalogo_productos.id
                        LEFT JOIN proveedor on historico_costos.Id_Prov = proveedor.idProveedor
                        LEFT JOIN marcas on catalogo_productos.marca = marcas.id
                        WHERE `id_catprod` = '" & idprod.ToString & "'"
                    da = New MySqlDataAdapter(sql, con_string)
                    ds = New DataSet
                    da.Fill(ds)
                    con_string.Close()

                    'se declararan las columnas para el data grid
                    dt.Columns.Add("Codigo de barras", GetType(Int64)) '1
                    dt.Columns.Add("Marca", GetType(String)) '2
                    dt.Columns.Add("Modelo", GetType(String)) '3
                    dt.Columns.Add("Descripcion", GetType(String)) '4
                    dt.Columns.Add("Costo") '5
                    dt.Columns.Add("Fecha") '6
                    dt.Columns.Add("Razon Social", GetType(String)) '7
                    'dt.Columns.Add("Fecha2") '8

                    For Each dr As DataRow In ds.Tables(0).Rows
                        Dim DataRow As DataRow = dt.NewRow()
                        DataRow("Codigo de barras") = dr(7)
                        DataRow("Marca") = dr(25)
                        DataRow("Modelo") = dr(9)
                        DataRow("Descripcion") = dr(10)
                        DataRow("Costo") = Format(CDec(dr(3)), "$ #,###,##0.00")
                        'DataRow("Fecha") = dr(4)
                        fechac = dr(4)
                        DataRow("Fecha") = fechac.ToString("yyyy-MM-dd")
                        DataRow("Razon Social") = dr(16)

                        dt.Rows.Add(DataRow)

                        If DGV_Reporte.ColumnCount < 7 Then  'Condición para no desplegar otra columna
                        End If

                        DGV_Reporte.DataSource = dt
                        'Determinar el alto de las filas
                        DGV_Reporte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DGV_Reporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        'Configurar aspectos visuales
                        DGV_Reporte.BackgroundColor = Color.AliceBlue
                        DGV_Reporte.AllowUserToAddRows = False
                        DGV_Reporte.ReadOnly = True       'El control DataGridView será de sólo lectura
                    Next

                    'crear archivo XML para generar reporte
                    Dim dsxml As New DataSet
                    dsxml.Tables.Add(dt)
                    dsxml.WriteXml("c:\XML\Rep_HistCtos.xml", XmlWriteMode.WriteSchema)

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al conectarse a la base de datos")
                End Try
            Else
                MsgBox("No se obtuvo un id de producto")
            End If
        Else
            MsgBox("Ingrese el codigo a buscar")   'si no se ingreso un codigo a buscar envia mensaje
        End If
        Btn_report.Enabled = True
    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        Select Case reporte
            Case "inventario"
                Dim mostrarform As New Rep_Inv()
                mostrarform.Show()
            Case "ventas"
                Panel_Inv.Visible = False
                Panel_hist_cto.Visible = False
            Case "historico_c"
                Dim mostrarform As New Rep_HisCtos()
                mostrarform.Show()
            Case "historico_v"
                Panel_Inv.Visible = False
                Panel_hist_cto.Visible = False
        End Select
    End Sub
End Class