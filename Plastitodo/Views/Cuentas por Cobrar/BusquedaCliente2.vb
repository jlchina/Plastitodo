Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class BusquedaCliente2
    Private Sub BusquedaCliente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select Nombre,telefono,email,rfc,razon_social from cliente where Nombre like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & Globales.text & "%")

            ' Dim query = "select Nombre,telefono,email,cc.rfc,razon_social from cliente c join cuenta_cobrar cc on c.rfc = cc.rfc where cc.No_factura = ' ' "



            Dim dt As New DataTable


            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgViewbusquedacliente.DataSource = dt
                'CuentasCobrar.TextBoxCliente.Text = dt.Rows(0).Item(0)
                'CuentasCobrar.TextBoxTelefono.Text = dt.Rows(0).Item(1)
                'CuentasCobrar.TextBoxEmail.Text = dt.Rows(0).Item(2)
                'CuentasCobrar.TextBoxRfc.Text = dt.Rows(0).Item(3)
                'CuentasCobrar.TextBoxRazonSocial.Text = dt.Rows(0).Item(4)
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            'Dim querysaldoanterior = $"select saldo_anterior from cuenta_cobrar where rfc = {rfc}"
            'Dim adap2 As New MySqlCommand(querysaldoanterior, conexion)
            'adap2.ExecuteNonQuery()



            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Shared RazonSocial As String
    Public Shared telefono As String
    Public Shared email As String
    Public Shared rfc As String
    Private adap As Object

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles BottonSeleccionar.Click


        RazonSocial = dgViewbusquedacliente.CurrentRow.Cells("razon_social").Value.ToString.Trim
        telefono = dgViewbusquedacliente.CurrentRow.Cells("telefono").Value.ToString.Trim
        email = dgViewbusquedacliente.CurrentRow.Cells("email").Value.ToString.Trim
        rfc = dgViewbusquedacliente.CurrentRow.Cells("rfc").Value.ToString.Trim
        Me.Close()


    End Sub
End Class