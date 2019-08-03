Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class EntradasMerca
    Private Sub BGuardardetaentramerca_Click(sender As Object, e As EventArgs) Handles BGuardardetaentramerca.Click
        Dim conexion As New MySqlConnection(ConnectionString2)

        Dim CONSULTA As New StringBuilder
        CONSULTA.Clear()
        CONSULTA.AppendLine("insert into detalle_entrada(id_producto, costo, cantidad)")
        CONSULTA.AppendLine($"values ('{Tcodigo.Text}','{Tcosto.Text}',")
        CONSULTA.AppendLine($"'{Tcantidad.Text}')")



        Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)

        conexion.Open()
        COMANDO.ExecuteNonQuery()


        conexion.Close()
        MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")

    End Sub
End Class