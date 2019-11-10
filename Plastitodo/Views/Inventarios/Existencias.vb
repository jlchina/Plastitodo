Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Existencias

    Private Sub Bbuscarexis_Click_1(sender As Object, e As EventArgs) Handles Bbuscarexis.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query2 = "Select *from inventario where codigo_barras  like ?"
            Dim query = "Select * from catalogo_productos 
                        left JOIN marcas on catalogo_productos.marca = marcas.id
                        left JOIN presentacion_prod on catalogo_productos.presentacion = presentacion_prod.id_pp
                        where codigo_barras like ?"

            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBox1.Text & "%")
            Dim adap2 As New MySqlDataAdapter(query2, conexion)
            adap2.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBox1.Text & "%")
            Dim dt As New DataTable
            Dim dtde As New DataTable
            Dim datafull As New DataTable
            adap.Fill(dt)
            adap2.Fill(dtde)

            datafull.Clear() ' armado de datagrid con las 2 consultas
            datafull.Columns.Add("codigo_barras")
            datafull.Columns.Add("descripcion")
            datafull.Columns.Add("presentacion")
            datafull.Columns.Add("precio")
            datafull.Columns.Add("marca")
            datafull.Columns.Add("existencia")

            For Each CP As DataRow In dt.Rows
                Dim dr As DataRow
                dr = datafull.NewRow()
                For Each DE As DataRow In dtde.Rows
                    If (CP("codigo_barras") = DE("codigo_barras")) Then

                        dr("codigo_barras") = CP(1).ToString().Trim()
                        dr("descripcion") = CP(4).ToString.Trim()
                        dr("presentacion") = CP(12).ToString().Trim()
                        dr("precio") = CP(7).ToString().Trim()
                        dr("marca") = CP(10).ToString().Trim()
                        dr("existencia") = DE("existencia").ToString().Trim()
                        datafull.Rows.Add(dr)
                    End If
                Next
                'Determinar el alto de las filas
                DataGridViewexis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DataGridViewexis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                DataGridViewexis.BackgroundColor = Color.AliceBlue
                DataGridViewexis.AllowUserToAddRows = False
                DataGridViewexis.ReadOnly = True       'El control DataGridView será de sólo lectura
            Next

            'crear archivo XML para generar reporte
            Dim dsxml As New DataSet
            dsxml.Tables.Add(datafull)
            dsxml.WriteXml("c:\XML\inventario.xml", XmlWriteMode.WriteSchema)

            If dt.Rows.Count > 0 Then
                DataGridViewexis.DataSource = dt
                DataGridViewexis.DataSource = datafull
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        Dim mostrarform As New Rep_Inv()
        'Dim nom_rep As String
        'Dim dir_rep As String

        'envía el nombre del reporte al formulario
        'nom_rep = "Inventario"
        'dir_rep = "c:\XML\inventario.xml"
        'mostrarform.obt_reporte(nom_rep, dir_rep)  'envia el nombre del reporte al formulario y el directorio del reporte, a la funcion publica del formulario de reportes
        mostrarform.Show()
    End Sub

    Private Sub Existencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class