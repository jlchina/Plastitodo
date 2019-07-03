Imports MySql.Data.MySqlClient

Public Class Catprod

    Private Sub DGVcatprov_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVcatprov.RowEnter
        ccons = DGVcatprov.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            ccons = "select * from catalogo_productos"
            da = New MySqlDataAdapter(ccons, con_string)
            dt = New DataTable
            da.Fill(dt)
            DGVcatprov.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class