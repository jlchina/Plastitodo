Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class CuentasCobrar
    Dim miDataTable As New DataTable



    Private Sub listacliente()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()

        Dim consulta As String
        consulta = "select * from cliente"
        Dim adaptador = New MySqlDataAdapter(consulta, conexion)
        Dim datos = New DataSet
        datos.Tables.Add("cliente")
        adaptador.Fill(datos.Tables("cliente"))
        ComboBoxcliente.DataSource = datos.Tables("cliente")
        ComboBoxcliente.DisplayMember = "Nombre"
        conexion.Close()

    End Sub
End Class