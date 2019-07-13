Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class CatalogoProveedor
    Private datos As DataSet

    Private Sub CProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BAgregarprovee_Click(sender As Object, e As EventArgs) Handles BAgregarprovee.Click
        Dim conexion As New MySqlConnection(ConnectionString2)

        Dim CONSULTA As New StringBuilder
        CONSULTA.Clear()
        CONSULTA.AppendLine("insert into proveedor(idProveedor, Nombre, Direccion, Colonia,")
        CONSULTA.AppendLine("Cuidad,Codigo_postal,telefono,correo, contacto)")
        CONSULTA.AppendLine($"values ('{txtidpro.Text}','{Textnombre.Text}',")
        CONSULTA.AppendLine($"'{Textdire.Text}', '{Textcol.Text}','{Textcuidad.Text}',")
        CONSULTA.AppendLine($"'{Textcp.Text}' , '{Texttel.Text}',")
        CONSULTA.AppendLine($"'{Textcorreo.Text}','{Textcontacto.Text}')")

        Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)

        conexion.Open()
        COMANDO.ExecuteNonQuery()

        conexion.Close()
        MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
        limpiar()

    End Sub

    Private Sub limpiar()

        txtidpro.Text = String.Empty
        Textnombre.Text = String.Empty
        Textdire.Text = String.Empty
        Textcol.Text = String.Empty
        Textcuidad.Text = String.Empty
        Textcp.Text = String.Empty
        Texttel.Text = String.Empty
        Textcorreo.Text = String.Empty
        Textcontacto.Text = String.Empty


    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        limpiar()
    End Sub


    Private Sub BConsultaProvee_Click(sender As Object, e As EventArgs) Handles BConsultaProvee.Click

        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim query = "Select *from proveedor where nombre  like ?"

            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBoxnombre.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt

            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            'DataGridView1.DataSource = dt


            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiarconsulta()
        TextBoxnombre.Text = String.Empty
        DataGridView1.DataSource = String.Empty
    End Sub

    Private Sub BConsultaLimpi_Click(sender As Object, e As EventArgs) Handles BConsultaLimpi.Click
        limpiarconsulta()
    End Sub
End Class