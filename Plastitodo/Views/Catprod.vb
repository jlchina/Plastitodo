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

    Private Sub Btn_agregarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregarp.Click
        Try
            comando = New MySqlCommand("INSERT INTO catalogo_productos(codigo_barras, Modelo, descripcion, presentacion, precio, marca)" & Chr(13) &
                                       "VALUES(@codigo_barras,@Modelo, @descripcion, @presentacion, @precio, @marca)", con_string)
            comando.Parameters.AddWithValue("@codigo_barras", Txt_codbar.Text)
            comando.Parameters.AddWithValue("@Modelo", Txt_mod.Text)
            comando.Parameters.AddWithValue("@descripcion", Txt_desc.Text)
            comando.Parameters.AddWithValue("@precio", Txt_Cto.Text)
            comando.Parameters.AddWithValue("@marca", Txt_marca.Text)
            comando.Parameters.AddWithValue("@presentacion", Cbo_Pres.Text)
            comando.ExecuteNonQuery()
            MsgBox("Producto guardado con exito")
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el producto, verifique los datos")
        End Try
    End Sub

    Private Sub Catprod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dcmbo As DataTable = New DataTable("tabla")
        Dim fcmbo As DataRow
        dcmbo.Columns.Add("presentacion")

        'para llenado de combobox
        fcmbo = dcmbo.NewRow()
        fcmbo("presentacion") = "PZA"
        dcmbo.Rows.Add(fcmbo)

        fcmbo = dcmbo.NewRow()
        fcmbo("presentacion") = "KG"
        dcmbo.Rows.Add(fcmbo)

        Cbo_Pres.DataSource = dcmbo
        Cbo_Pres.DisplayMember = "presentacion"
    End Sub

    Private Sub Btn_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_filtro.Click
        Try
            ccons = "select * from catalogo_productos WHERE "
            da = New MySqlDataAdapter(ccons, con_string)
            dt = New DataTable
            da.Fill(dt)
            DGVcatprov.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class