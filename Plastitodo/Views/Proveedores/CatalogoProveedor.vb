Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class CatalogoProveedor
    Private datos As DataSet

    Private Sub BAgregarprovee_Click(sender As Object, e As EventArgs) Handles BAgregarprovee.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim CONSULTA
            conexion.Open()
            CONSULTA = "INSERT INTO proveedor(Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, correo, contacto)" & Chr(13) &
                                           "VALUES(@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @correo, @contacto)"
            Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)
            COMANDO.Parameters.AddWithValue("@Nombre", Textnombre.Text)
            COMANDO.Parameters.AddWithValue("@Direccion", Textdire.Text)
            COMANDO.Parameters.AddWithValue("@Colonia", Textcol.Text)
            COMANDO.Parameters.AddWithValue("@Ciudad", Textcuidad.Text)
            COMANDO.Parameters.AddWithValue("@Codigo_postal", Textcp.Text)
            COMANDO.Parameters.AddWithValue("@telefono", Texttel.Text)
            COMANDO.Parameters.AddWithValue("@correo", Textcorreo.Text)
            COMANDO.Parameters.AddWithValue("@contacto", Textcontacto.Text)


            COMANDO.ExecuteNonQuery()
            conexion.Close()

            MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
        Catch ex As Exception
            MsgBox("Error de conexion a la BD, Datos no guardados!!")
        End Try

        limpiar()

    End Sub

    Private Sub limpiar()

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