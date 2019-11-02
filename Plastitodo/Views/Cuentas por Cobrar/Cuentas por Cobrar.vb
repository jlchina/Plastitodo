Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class CuentasCobrar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Dim newbusquedacliente As New BusquedaCliente()
        'newbusquedacliente.MdiParent = Me
        'newbusquedacliente.ShowDialog()

        Dim newbusquedacliente As New BusquedaCliente()
        newbusquedacliente.ShowDialog()
    End Sub

    Private Sub CuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class