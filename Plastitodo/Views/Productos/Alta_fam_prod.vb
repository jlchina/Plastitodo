Imports MySql.Data.MySqlClient
Public Class Alta_fam_prod

    Private Sub Alta_fam_prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            comando = New MySqlCommand("INSERT INTO catalogacion_familias(id_familia, nom_familia)" & Chr(13) &
                                       "VALUES(@id_familia,@nom_familia)", con_string)
            comando.Parameters.AddWithValue("@id_familia", txt_numfam.Text)
            comando.Parameters.AddWithValue("@nom_familia", txt_descfam.Text)
            comando.ExecuteNonQuery()
            MsgBox("Nueva familia de productos guardada con exito")
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guarda, verifique los datos")
        End Try
    End Sub
End Class