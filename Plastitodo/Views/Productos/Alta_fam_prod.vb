Imports MySql.Data.MySqlClient
Public Class Alta_fam_prod

    Public Sub solonumeros(ByRef numerico As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(numerico.KeyChar) Then
            numerico.Handled = False
        ElseIf Char.IsControl(numerico.KeyChar) Then
            numerico.Handled = False
        Else
            numerico.Handled = True
        End If

        MsgBox(numerico.KeyChar.ToString)
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()
        Try
            comando = New MySqlCommand("INSERT INTO catalogacion_familias(nom_familia, descripcion_fam)" & Chr(13) &
                                       "VALUES(@nom_familia,@descripcion_fam)", con_string)
            comando.Parameters.AddWithValue("@nom_familia", txt_nomfam.Text)
            comando.Parameters.AddWithValue("@descripcion_fam", txt_descfam.Text)
            comando.ExecuteNonQuery()
            MsgBox("Nueva familia de productos guardada con exito")
            txt_nomfam.Text = String.Empty
            txt_descfam.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar, verifique los datos")
            txt_nomfam.Text = String.Empty
            txt_descfam.Text = String.Empty
        End Try
        con_string.Close()
    End Sub

   
    Private Sub txt_nomfam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nomfam.KeyPress
        onlyletters(e)
    End Sub

    Private Sub txt_descfam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descfam.KeyPress
        onlyletters(e)
    End Sub

    Private Sub Alta_fam_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class