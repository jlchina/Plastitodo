Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Existencias
    Private Sub Blimpiar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BAgregarprovee_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Textcorreo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bbuscarexis_Click(sender As Object, e As EventArgs) Handles Bbuscarexis.Click

        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select * from catalogo_productos where codigo_barras  like ?"
            Dim query2 = "Select * from detalle_entrada where id_producto  like ?"

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
            datafull.Columns.Add("cantidad")

            For Each CP As DataRow In dt.Rows
                Dim dr As DataRow
                dr = datafull.NewRow()
                For Each DE As DataRow In dtde.Rows
                    If (CP("codigo_barras") = DE("id_producto")) Then

                        dr("codigo_barras") = CP("codigo_barras").ToString().Trim()
                        dr("descripcion") = CP("descripcion").ToString.Trim()
                        dr("presentacion") = CP("presentacion").ToString().Trim()
                        dr("precio") = CP("precio").ToString().Trim()
                        dr("marca") = CP("marca").ToString().Trim()
                        dr("cantidad") = DE("cantidad").ToString().Trim()
                        datafull.Rows.Add(dr)
                    End If
                Next
            Next




            If dt.Rows.Count > 0 Then
                'DataGridViewexis.DataSource = dt
                DataGridViewexis.DataSource = datafull

            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            'DataGridView1.DataSource = dt


            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class