Imports MySql.Data.MySqlClient


Public Class ModCatprod
    ' Dim con_datos As String

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
        'llenar el cmbo box para piezas o kilogramos
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

        'llenar el combo box para catalogacion del articulo
        Dim consulta As String = Nothing

        consulta = "SELECT Gpo_prod,Nom_categoria FROM catalogacion"
        da = New MySqlDataAdapter(consulta, con_string)
        dt = New DataTable
        da.Fill(dt)
        Cbo_gpoprod.DataSource = dt
        Cbo_gpoprod.DisplayMember = "Nom_categoria"

    End Sub

    Private Sub Btn_cancelarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelarp.Click
        AltaGpoProd.Show()
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim sql As String = Nothing
        Dim where As String = Nothing

        Try
            If txtCodigoEd.Text <> "" Then
                where = "codigo_barras =" & txtCodigoEd.Text & " "
            End If

            If TxtModeloEd.Text <> "" Then
                If where <> Nothing Then
                    where = where & " and marca LIKE '%" & TxtModeloEd.Text & "%' "
                Else
                    where = " modelo LIKE '%" & TxtModeloEd.Text & "%' "
                End If
            End If

            If where <> Nothing Then
                sql = "Select * from catalogo_productos where " & where
            Else
                sql = "Select * from catalogo_productos"
            End If
            da = New MySqlDataAdapter(sql, con_string)
            dt = New DataTable
            da.Fill(dt)
            DGV_Edit_CP.DataSource = dt
            DGV_Edit_CP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "hubo un error al extraer la información")
        End Try
    End Sub

    Private Sub BtnCambiosEd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiosEd.Click
        Dim actualizar As String
        actualizar = "UPDATE catalogo_productos SET "
    End Sub

End Class