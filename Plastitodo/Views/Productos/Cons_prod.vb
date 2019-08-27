Imports MySql.Data.MySqlClient

Public Class Cons_prod

    Dim con_datos As String

    Private Sub DGVcatprov_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVcatprov.RowEnter
        con_datos = DGVcatprov.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub Btn_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_filtro.Click
        Dim sql As String = Nothing
        Dim where1 As String = Nothing

        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()

        Try
            If TxtCodigo.Text <> "" Then
                where1 = "codigo_barras =" & TxtCodigo.Text & " "
            End If

            If TxtMarca.Text <> "" Then
                If where1 <> Nothing Then
                    where1 = where1 & " and marca LIKE '%" & TxtMarca.Text & "%' "
                Else
                    where1 = " marca LIKE '%" & TxtMarca.Text & "%' "
                End If
            End If

            If where1 <> Nothing Then
                sql = "Select * from catalogo_productos where " & where1
            Else
                sql = "Select * from catalogo_productos"
            End If
            da = New MySqlDataAdapter(sql, con_string)
            dt = New DataTable
            da.Fill(dt)
            DGVcatprov.DataSource = dt
            DGVcatprov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "hubo un error al extraer la información")
        End Try
        con_string.Close()
    End Sub

    Private Sub BtnCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModCatprod.Show()
        Me.Close()
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigo.KeyPress
        solonumeros(e)
    End Sub
End Class