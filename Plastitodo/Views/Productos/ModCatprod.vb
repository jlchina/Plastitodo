Imports MySql.Data.MySqlClient


Public Class ModCatprod
    ' Dim con_datos As String
    Dim idf As Integer = Nothing
    Dim idpresp As Integer = Nothing
    Dim idmarca As Integer = Nothing

    Private Sub Btn_agregarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregarp.Click
        Try
            'Se inicializa la conexion a la BD JLCS
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'campos a ingresar en la BD desde el formulario
            comando = New MySqlCommand("INSERT INTO catalogo_productos(codigo_barras, marca, Modelo, descripcion, presentacion, precio, id_familia)" & Chr(13) &
                                       "VALUES(@codigo_barras, @marca, @Modelo, @descripcion, @presentacion, @precio, @id_familia)", con_string)
            comando.Parameters.AddWithValue("@codigo_barras", Txt_codbar.Text)
            comando.Parameters.AddWithValue("@marca", idmarca)
            comando.Parameters.AddWithValue("@Modelo", Txt_mod.Text)
            comando.Parameters.AddWithValue("@descripcion", Txt_desc.Text)
            comando.Parameters.AddWithValue("@presentacion", idpresp)
            comando.Parameters.AddWithValue("@precio", Txt_Cto.Text)
            comando.Parameters.AddWithValue("@id_familia", idf)
            comando.ExecuteNonQuery()
            MsgBox("Producto guardado con exito")
            con_string.Close()
            'borra el valor de la variable con la categoria que fue seleccionada
            idf = Nothing
            'despues de guardar limpia la ventana
            Txt_codbar.Text = String.Empty
            Cbo_Marca.Text = "Seleccione una marca"
            Txt_mod.Text = String.Empty
            Txt_desc.Text = String.Empty
            Txt_Cto.Text = String.Empty
            Cbo_gpoprod.Text = "Seleccione una categoria"
            Cbo_Pres.Text = "Selecciona una opción"
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el producto, verifique los datos")
            Txt_codbar.Text = String.Empty
            Cbo_Marca.Text = "Seleccione una marca"
            Txt_mod.Text = String.Empty
            Txt_desc.Text = String.Empty
            Txt_Cto.Text = String.Empty
            Cbo_gpoprod.Text = "Seleccione una categoria"
            Cbo_Pres.Text = "Selecciona una opción"
        End Try
    End Sub

    Private Sub Catprod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenar el combo box para catalogacion del articulo
        Dim consulta As String = Nothing

        Try
            'iniciar conexion
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

        'llenar el combobox de Marca
        Dim cons_marca As String = "SELECT * FROM marcas"
        Dim d_ad As New MySqlDataAdapter
        Dim da_ta As New DataTable
        Try
            'iniciar conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'realizar consulta para extraer datos
            d_ad = New MySqlDataAdapter(cons_marca, con_string)
            da_ta = New DataTable
            d_ad.Fill(da_ta)
            con_string.Close()
            'llenado de informacion en el combobox marca para alta de productos
            Cbo_Marca.DataSource = da_ta
            Cbo_Marca.DisplayMember = "marca"
            Cbo_Marca.ValueMember = "id"
            Cbo_Marca.Text = "Selecciona una marca"
        Catch ex As Exception
            MsgBox("Error de conexion. No se pudo cargar la tabla Marcas", vbCritical)
        End Try

        'llenar combobox de presentacion de productos
        Dim cons_pres As String = "SELECT * FROM presentacion_prod"
        Dim da_presp As New MySqlDataAdapter
        Dim dt_presp As New DataTable
        Try
            'iniciar conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'realizar consulta para extraer datos
            da_presp = New MySqlDataAdapter(cons_pres, con_string)
            dt_presp = New DataTable
            da_presp.Fill(dt_presp)
            con_string.Close()
            'llenado de informacion en el combobox presentacion de productos para alta de productos
            Cbo_Pres.DataSource = dt_presp
            Cbo_Pres.DisplayMember = "presentacion"
            Cbo_Pres.ValueMember = "id_pp"
            Cbo_Pres.Text = "Selecciona una opción"
        Catch ex As Exception
            MsgBox("Error de conexion. No se pudo cargar la tabla presentacion de productos", vbCritical)
        End Try

    End Sub

    Private Sub Btn_cancelarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelarp.Click
        'limpia todas las cajas de texto JLCS
        Txt_codbar.Text = String.Empty
        Txt_mod.Text = String.Empty
        Txt_desc.Text = String.Empty
        Txt_Cto.Text = String.Empty
        Cbo_Pres.Text = "Selecciona una opción"
        Cbo_Marca.Text = "Selecciona una marca"
        Cbo_gpoprod.Text = "Seleccione una categoria"
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim sql As String = Nothing
        Dim where As String = Nothing
        Dim ds As DataSet = New DataSet
        Dim dt As New DataTable()

        Dim sql2 As String = "SELECT id FROM marcas where marca LIKE '%"
        Dim da As New MySqlDataAdapter
        Dim ds2 As New DataSet
        Dim filtro_marca As Integer = Nothing
        Try
            If TxtModeloEd.Text <> "" Then
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()
                sql2 = sql2 & TxtModeloEd.Text & "%' "
                da = New MySqlDataAdapter(sql2, con_string)
                ds2 = New DataSet
                da.Fill(ds2)
                con_string.Close()
                For Each dr2 As DataRow In ds2.Tables(0).Rows
                    'Dim DRow As DataRow = dt.NewRow()
                    'DRow("id") = dr2(0)
                    filtro_marca = dr2(0)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error de conexión, no se pudo conectar a la base de datos 'Marcas'")
        End Try

        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()

        Try
            'Obtiene los valores del formulario para generar la consulta
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
            'genera la consulta a partir de los campos que se llenaron
            If where <> Nothing Then
                sql = "Select * from catalogo_productos where " & where
            Else
                sql = "Select * from catalogo_productos"
            End If
            da = New MySqlDataAdapter(sql, con_string)
            ds = New DataSet
            da.Fill(ds)
            con_string.Close()
            'se declararan las columnas para el data grid
            dt.Columns.Add("ID", GetType(Int32)) '1
            dt.Columns.Add("Codigo de barras", GetType(Int64)) '2
            dt.Columns.Add("Marca", GetType(Int32)) '3
            dt.Columns.Add("Modelo", GetType(String)) '4
            dt.Columns.Add("Descripcion", GetType(String)) '5
            dt.Columns.Add("Presentacion", GetType(String)) '6
            dt.Columns.Add("Precio", GetType(String)) '7
            dt.Columns.Add("Id Familia", GetType(Int32)) '8

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = dt.NewRow()
                DataRow("ID") = dr(0)
                DataRow("Codigo de barras") = dr(1)
                DataRow("Marca") = dr(2)
                DataRow("Modelo") = dr(3)
                DataRow("Descripcion") = dr(4)
                DataRow("Presentacion") = dr(5)
                DataRow("Precio") = dr(6).ToString
                DataRow("Id Familia") = dr(7)

                dt.Rows.Add(DataRow)

                'agergar boton de edicion
                Dim Editar As New DataGridViewButtonColumn()
                Editar.UseColumnTextForButtonValue = True
                Editar.Text = "Editar"
                Editar.Name = "Editar"          'Agregar nombre a columna
                Editar.HeaderText = "Acciones"
                Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                If DGV_Edit_CP.ColumnCount < 9 Then  'Condición para no desplegar otra columna
                    DGV_Edit_CP.Columns.Add(Editar)
                End If

                DGV_Edit_CP.DataSource = dt
                'Determinar el alto de las filas
                DGV_Edit_CP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DGV_Edit_CP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                DGV_Edit_CP.BackgroundColor = Color.AliceBlue
                DGV_Edit_CP.AllowUserToAddRows = False
                DGV_Edit_CP.ReadOnly = True       'El control DataGridView será de sólo lectura
            Next
            'DGV_Edit_CP.DataSource = dt
            'DGV_Edit_CP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "No se pudo conectar a la Base de Datos")
        End Try

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

    Private Sub DGV_Edit_CP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Edit_CP.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Try
            If DGV_Edit_CP.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id_prod As String
                'para enviar informacion al formulario
                id_prod = DGV_Edit_CP.Rows(e.RowIndex).Cells("ID").Value
                'envia datos al formulario
                Dim mostrarform As New EditarProductos()
                mostrarform.obtprod(id_prod)  'envia el ID de la marca seleccionada
                mostrarform.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cbo_Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Marca.SelectedIndexChanged
        If IsNumeric(Cbo_Marca.SelectedValue) Then
            idmarca = Cbo_Marca.SelectedValue
        Else
            idmarca = Nothing
        End If
    End Sub

    Private Sub Cbo_Pres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Pres.SelectedIndexChanged
        If IsNumeric(Cbo_Pres.SelectedValue) Then
            idpresp = Cbo_Pres.SelectedValue
        Else
            idpresp = Nothing
        End If
    End Sub
End Class