Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Imports System.Text.RegularExpressions
Public Class CatalogoProveedor
    Private datos As DataSet



    Private Sub BAgregarprovee_Click(sender As Object, e As EventArgs) Handles BAgregarprovee.Click
        Try
            Dim email As String

            email = Textcorreo.Text

            If Len(email) > 0 Then
                If (validar_mail(email) = True) Then
                    Dim conexion As New MySqlConnection(ConnectionString2)

                    Dim CONSULTA As New StringBuilder
                    CONSULTA.Clear()
                    CONSULTA.AppendLine("insert into proveedor(Nombre, Direccion, Colonia,")
                    CONSULTA.AppendLine("Ciudad,Codigo_postal,telefono,correo, contacto)")
                    CONSULTA.AppendLine($"values ('{Textnombre.Text}',")
                    CONSULTA.AppendLine($"'{Textdire.Text}', '{Textcol.Text}','{Textcuidad.Text}',")
                    CONSULTA.AppendLine($"'{Textcp.Text}' , '{Texttel.Text}',")
                    CONSULTA.AppendLine($"'{Textcorreo.Text}','{Textcontacto.Text}')")

                    Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)

                    conexion.Open()
                    COMANDO.ExecuteNonQuery()

                    conexion.Close()
                    MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
                    limpiar()
                Else
                    MessageBox.Show("Verificar Correo")
                End If
            Else
                MessageBox.Show("Favor de Ingresar un Correo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Texttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texttel.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Textcp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textcp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
        'Static emailExpression As New Regex("/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/igm")

        'Return emailExpression.IsMatch(sMail)
    End Function

    Private Sub CatalogoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class