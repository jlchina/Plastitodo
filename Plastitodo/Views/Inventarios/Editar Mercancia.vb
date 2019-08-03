Imports MySql.Data.MySqlClient
Public Class Editar_Mercancia
    Private Sub BBuscarEdi_Click(sender As Object, e As EventArgs) Handles BBuscarEdi.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select *from catalogo_productos where codigo_barras like ?"

            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBox1.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridViewBusEdi.DataSource = dt

            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            'DataGridView1.DataSource = dt


            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub buscar(codigo_barras As Int32)
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = $"Select *from catalogo_productos where codigo_barras = '{codigo_barras}'"

            Dim adap As New MySqlDataAdapter(query, conexion)
            'adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBox1.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridViewBusEdi.DataSource = dt

            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            'DataGridView1.DataSource = dt


            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DataGridViewBusEdi_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewBusEdi.DoubleClick
        'Txtprecio.Text = DataGridViewBusEdi.CurrentRow.Cells("precio").Value
        'TxtDescrip.Text = DataGridViewBusEdi.CurrentRow.Cells("descripcion").Value
        'TextMarca.Text = DataGridViewBusEdi.CurrentRow.Cells("marca").Value
        'TextPresen.Text = DataGridViewBusEdi.CurrentRow.Cells("presentacion").Value

    End Sub

    Private Sub Editar_Mercancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtprecio.Enabled = False
        TxtDescrip.Enabled = False
        TextMarca.Enabled = False
        TextPresen.Enabled = False
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Txtprecio.Enabled = True
    End Sub

    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()
        Dim query = $"update catalogo_productos set precio = '{Txtprecio.Text}'  where codigo_barras = {TextBox1.Text.ToString()}"

        Dim adap As New MySqlCommand(query, conexion)
        If (adap.ExecuteNonQuery() = 1) Then
            MessageBox.Show(" DATO MODIFICADO ", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ERROR AL GUARDAR ", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conexion.Close()
        limpiar()
        buscar(TextBox1.Text)
    End Sub

    Private Sub limpiar()
        Txtprecio.Text = String.Empty
        TxtDescrip.Text = String.Empty
        TextMarca.Text = String.Empty
        TextPresen.Text = String.Empty
    End Sub

    Private Sub DataGridViewBusEdi_Click(sender As Object, e As EventArgs) Handles DataGridViewBusEdi.Click
        Txtprecio.Text = DataGridViewBusEdi.CurrentRow.Cells("precio").Value
        TxtDescrip.Text = DataGridViewBusEdi.CurrentRow.Cells("descripcion").Value
        TextMarca.Text = DataGridViewBusEdi.CurrentRow.Cells("marca").Value
        TextPresen.Text = DataGridViewBusEdi.CurrentRow.Cells("presentacion").Value

    End Sub
End Class