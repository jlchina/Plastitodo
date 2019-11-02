Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class BusquedaCliente
    Private Sub BusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select Nombre,telefono,email,rfc,razon_social from cliente where Nombre like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & CuentasCobrar.TextBoxCliente.Text & "%")

            Dim dt As New DataTable

            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridViewbusquedacliente.DataSource = dt
                CuentasCobrar.TextBoxCliente.Text = dt.Rows(0).Item(0)
                CuentasCobrar.TextBoxTelefono.Text = dt.Rows(0).Item(1)
                CuentasCobrar.TextBoxEmail.Text = dt.Rows(0).Item(2)
                CuentasCobrar.TextBoxRfc.Text = dt.Rows(0).Item(3)
                CuentasCobrar.TextBoxRazonSocial.Text = dt.Rows(0).Item(4)
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class