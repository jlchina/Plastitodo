Imports MySql.Data.MySqlClient


Public Class ModCatprod
    ' Dim con_datos As String
    Dim idf As Integer = Nothing

    Private Sub Btn_agregarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregarp.Click
        Try
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            comando = New MySqlCommand("INSERT INTO catalogo_productos(codigo_barras, marca, Modelo, descripcion, presentacion, precio, id_familia)" & Chr(13) &
                                       "VALUES(@codigo_barras, @marca, @Modelo, @descripcion, @presentacion, @precio, @id_familia)", con_string)
            comando.Parameters.AddWithValue("@codigo_barras", Txt_codbar.Text)
            comando.Parameters.AddWithValue("@marca", Txt_marca.Text)
            comando.Parameters.AddWithValue("@Modelo", Txt_mod.Text)
            comando.Parameters.AddWithValue("@descripcion", Txt_desc.Text)
            comando.Parameters.AddWithValue("@presentacion", Cbo_Pres.Text)
            comando.Parameters.AddWithValue("@precio", Txt_Cto.Text)
            comando.Parameters.AddWithValue("@id_familia", idf)
            comando.ExecuteNonQuery()
            MsgBox("Producto guardado con exito")
            con_string.Close()
            'borra el valo de la variable con la categoria que fue seleccionada
            idf = Nothing
            'despues de guardar limpia la ventana
            Txt_codbar.Text = String.Empty
            Txt_marca.Text = String.Empty
            Txt_mod.Text = String.Empty
            Txt_desc.Text = String.Empty
            Txt_Cto.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el producto, verifique los datos")
            Txt_codbar.Text = String.Empty
            Txt_marca.Text = String.Empty
            Txt_mod.Text = String.Empty
            Txt_desc.Text = String.Empty
            Txt_Cto.Text = String.Empty
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

        Try
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            consulta = "SELECT id,Nom_categoria FROM catalogacion"
            da = New MySqlDataAdapter(consulta, con_string)
            dt = New DataTable
            da.Fill(dt)
            Cbo_gpoprod.DataSource = dt
            Cbo_gpoprod.DisplayMember = "Nom_categoria"
            Cbo_gpoprod.ValueMember = "id"
            Cbo_gpoprod.Text = "Seleccione una categoria"
            con_string.Close()
        Catch ex As Exception
            MsgBox("Error al cargar las categorias", vbCritical)
        End Try

        

    End Sub

    Private Sub Btn_cancelarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelarp.Click
        Txt_codbar.Text = String.Empty
        Txt_marca.Text = String.Empty
        Txt_mod.Text = String.Empty
        Txt_desc.Text = String.Empty
        Txt_Cto.Text = String.Empty
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim sql As String = Nothing
        Dim where As String = Nothing

        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()

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
        con_string.Close()
    End Sub

    Private Sub BtnCambiosEd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Dim actualizar As String
        actualizar = "UPDATE catalogo_productos SET "
    End Sub

    Private Sub Cbo_gpoprod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_gpoprod.SelectedIndexChanged
        If IsNumeric(Cbo_gpoprod.SelectedValue) Then
            idf = Cbo_gpoprod.SelectedValue
        Else
            idf = Nothing
        End If
    End Sub
End Class