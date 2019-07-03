Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data.OleDb

Module conexion
    Public con_string As MySqlConnection
    Public dt As DataTable
    Public da As MySqlDataAdapter
    Public ccons As String
    Public comando As MySqlCommand
    Public datareader_mysql As MySqlDataReader

    Sub connection()
        Try
            con_string = New MySqlConnection
            con_string.ConnectionString = "Data Source=127.0.0.1; Port=3306;Database=plastibolsas; User id=root"
            con_string.Open()
            Principal.Lblconexion.Text = "Conectado"
        Catch ex As Exception
            Principal.Lblconexion.Text = "Sin conexión"
        End Try
    End Sub
End Module
