Imports MySql.Data.MySqlClient

Module conexion
    Public con_string As MySqlConnection

    Sub connection()
        Try
            con_string = New MySqlConnection("servername=localhost; Database=plastibolsas; username=root; password=;")
            con_string.Open()
            Form1.LblStatus.Text = "conectado a la base de datos"
        Catch ex As Exception
            Form1.LblStatus.Text = "sin conexion a la base de datos"
        End Try
    End Sub
End Module
