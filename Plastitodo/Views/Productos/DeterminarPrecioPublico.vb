Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Imports Plastitodo.Globales

Public Class DeterminarPrecioPublico
    Dim factores As Single = Nothing
    Dim id_CatProd As Integer = Nothing
    Dim id_Costo As Integer = Nothing
    Function consulta_llenado(ByVal sql As String)

        Dim data_set As DataSet = New DataSet
        Dim data_table As New DataTable()
        Dim data_ad As MySqlDataAdapter
        Dim comandos As MySqlCommand
        Dim consulta = "SELECT cp.*, m.marca nom_marca From catalogo_productos cp LEFT JOIN marcas m on cp.marca = m.id where codigo_barras= '"

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comandos = New MySqlCommand(consulta & sql, con_string)
            data_ad = New MySqlDataAdapter(comandos)
            data_ad.Fill(data_set)

            con_string.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return data_set
    End Function
    Private Sub Txt_PrecioPub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PrecioPub.KeyPress
        NumerosyDecimal(Txt_PrecioPub, e)
        If Txt_PrecioPub.TextLength >= 1 Then
            Cbo_Margen.Text = Format(((Txt_PrecioPub.Text / 1.16) - Txt_Cto.Text) / (Txt_PrecioPub.Text / 1.16), "Percent")
        Else
            Txt_PrecioPub.Text = 0
            Cbo_Margen.Text = 0
        End If

    End Sub

    Private Sub Txt_codigobarras_KeyPress(sender As Object, e As KeyPressEventArgs)
        solonumeros(e)
    End Sub

    Private Sub DeterminarPrecioPublico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable("Margen")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Factor")
        dt.Columns.Add("Margen")

        'para el llenado de las filas de las columnas
        Dim dr As DataRow

        'se determinan los valores del combobox con los valores de descuento y su factoraje
        dr = dt.NewRow()
        dr("Factor") = 1.29
        dr("Margen") = "10%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.36
        dr("Margen") = "15%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.45
        dr("Margen") = "20%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.55
        dr("Margen") = "25%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.66
        dr("Margen") = "30%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.78
        dr("Margen") = "35%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 1.93
        dr("Margen") = "40%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 2.11
        dr("Margen") = "45%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 2.32
        dr("Margen") = "50%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 2.58
        dr("Margen") = "55%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 2.9
        dr("Margen") = "60%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 3.31
        dr("Margen") = "65%"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Factor") = 3.87
        dr("Margen") = "70%"
        dt.Rows.Add(dr)

        Cbo_Margen.DataSource = dt
        Cbo_Margen.ValueMember = "Factor"
        Cbo_Margen.DisplayMember = "Margen"
    End Sub

    Private Sub Txt_CodBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CodBar.KeyPress
        Dim sql As String
        sql = Txt_CodBar.Text & "'"
        If Asc(e.KeyChar) = 13 Then

            'llenado de los valores en cajas de texto
            Dim ds As DataSet = consulta_llenado(sql)
            For Each dr As DataRow In ds.Tables(0).Rows
                Txt_Marca.Text = dr(9)
                Txt_Desc.Text = dr(4)
                Txt_Cto.Text = dr(6)
                id_CatProd = dr(0)
            Next

            'Consulta para el llenado de id de costo
            Dim d_set As New DataSet
            Dim d_adap As MySqlDataAdapter
            Dim comand As MySqlCommand
            Dim consulta2 = "SELECT * FROM historico_costos WHERE id_catprod = @id_catprod"
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comand = New MySqlCommand(consulta2, con_string)
            comand.Parameters.Add(New MySqlParameter("@id_catprod", id_CatProd))
            d_adap = New MySqlDataAdapter(comand)
            d_adap.Fill(d_set)
            'guardar valor en variable
            For Each dr As DataRow In d_set.Tables(0).Rows
                id_Costo = dr(0)
            Next

            con_string.Close()

        End If

    End Sub

    Private Sub Cbo_Margen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Margen.SelectedIndexChanged
        If IsNumeric(Cbo_Margen.SelectedValue) Then
            factores = Cbo_Margen.SelectedValue
        Else
            factores = Nothing
        End If
        Txt_PrecioPub.Text = Format(factores * Val(Txt_Cto.Text), "Standard")
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            'Se inicializa la conexion a la BD JLCS
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'campos a ingresar en la BD desde el formulario
            comando = New MySqlCommand("INSERT INTO historico_preciopublico(id_catalogo, id_costo, p_publico, id_usuario)" & Chr(13) &
                                       "VALUES(@id_catalogo, @id_costo, @p_publico,@id_usuario)", con_string)
            comando.Parameters.AddWithValue("@id_catalogo", id_CatProd)
            comando.Parameters.AddWithValue("@id_costo", id_Costo)
            comando.Parameters.AddWithValue("@p_publico", Txt_PrecioPub.Text)
            comando.Parameters.AddWithValue("@id_usuario", Id_usuario)
            comando.ExecuteNonQuery()
            con_string.Close()
            MsgBox("Precio guardado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class