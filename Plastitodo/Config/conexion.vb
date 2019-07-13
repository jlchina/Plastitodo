Imports MySql.Data.MySqlClient

Module conexion
    Public ConnectionString As String = "Data Source=127.0.0.1; Port=3306;Database=plastitodo; User id=root"
    Public ConnectionString2 As String = "server=127.0.0.1;port=3306;userid=root;password=$Obi1Kenobi;database=plastitodo"
    Public conn As MySqlConnection
    Public con_string As MySqlConnection
    Public dt As DataTable
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ccons As String
    Public comando As MySqlCommand
    Public cmd As MySqlCommand
    Public cmd2 As MySqlCommand
    Public datareader_mysql As MySqlDataReader

    Sub connection()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            Principal.Lblconexion.Text = "Conectado"
        Catch ex As Exception
            Principal.Lblconexion.Text = "Sin conexión"
        End Try
    End Sub
End Module
