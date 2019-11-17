Imports MySql.Data.MySqlClient

Public Class Cat_Clientes
    Dim id_cliente As Integer
    Private Sub Cat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_agregarc_Click(sender As Object, e As EventArgs) Handles Btn_agregarc.Click
        Try
            If (Text_nomb.Text IsNot "" And Text_dir.Text IsNot "" And Text_col.Text IsNot "" And
                Text_cd.Text IsNot "" And Text_cp.Text IsNot "" And Text_cp.Text IsNot "" And Text_tel.Text And TxtRfc.Text IsNot "") Then

                Dim sql = ""

                If (id_cliente > 0) Then
                    sql = "UPDATE cliente
                            SET
                            Nombre = @Nombre,
                            Direccion = @Direccion,
                            Colonia = @Colonia,
                            Ciudad = @Ciudad,
                            Codigo_postal = @Codigo_postal,
                            telefono = @telefono,
                            email = @email,
                            rfc = @rfc,
                            razon_social = @razon_social
                            WHERE idCliente = @id;"
                Else
                    sql = "INSERT INTO cliente(Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email, rfc, razon_social) " & Chr(13) &
                           "VALUES(@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email, @rfc, @razon_social)"
                End If
                conn = New MySqlConnection
                conn.ConnectionString = ConnectionString2
                conn.Open()

                cmd = New MySqlCommand(sql, conn)
                If (id_cliente > 0) Then
                    cmd.Parameters.AddWithValue("@id", id_cliente)
                End If
                cmd.Parameters.AddWithValue("@Nombre", Text_nomb.Text)
                cmd.Parameters.AddWithValue("@Direccion", Text_dir.Text)
                cmd.Parameters.AddWithValue("@Colonia", Text_col.Text)
                cmd.Parameters.AddWithValue("@Ciudad", Text_cd.Text)
                cmd.Parameters.AddWithValue("@Codigo_postal", Text_cp.Text)
                cmd.Parameters.AddWithValue("@telefono", Text_tel.Text)
                cmd.Parameters.AddWithValue("@email", Text_mail.Text)
                cmd.Parameters.AddWithValue("@rfc", TxtRfc.Text)
                cmd.Parameters.AddWithValue("@razon_social", TxtRazon.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Cliente guardado con exito")
                id_cliente = 0
                Tab_proveedor.TabPages(0).Text = "Alta"
                limpiar()
            Else
                MessageBox.Show("Favor de llenar la informacion necesaria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el Cliente, verifique los datos")
            limpiar()
        End Try
    End Sub

    Private Sub limpiar()
        Text_nomb.Text = String.Empty
        Text_dir.Text = String.Empty
        Text_col.Text = String.Empty
        Text_cd.Text = String.Empty
        Text_cp.Text = String.Empty
        Text_tel.Text = String.Empty
        Text_mail.Text = String.Empty
        TxtRfc.Text = String.Empty
        TxtRazon.Text = String.Empty

    End Sub

    Private Sub Btn_cancelarp_Click(sender As Object, e As EventArgs) Handles Btn_cancelarp.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonbuscar.Click
        Dim ds As DataSet = New DataSet
        Dim DataTable As New DataTable()
        Dim sql = "Select * From cliente c
                   Where c.nombre like '%" & Textbusclient.Text & "%' or c.direccion Like '%" & Textbusclient.Text & "%' or c.Ciudad Like '%" & Textbusclient.Text & "%';"

        Try
            '---Abir conexion
            conn = New MySqlConnection
            conn.ConnectionString = ConnectionString2
            conn.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(sql, conn)
            'cmd.Parameters.Add(New MySqlParameter("@descripcion", descripcion))
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()

            'Declarar columnas para data gridview
            DataTable.Columns.Add("Nombre", GetType(String)) '2
            DataTable.Columns.Add("Direccion", GetType(String)) '3
            DataTable.Columns.Add("Colonia", GetType(String)) '4
            DataTable.Columns.Add("Ciudad", GetType(String)) '5
            DataTable.Columns.Add("Codigo postal", GetType(String)) '6
            DataTable.Columns.Add("Telefono", GetType(String)) '7
            DataTable.Columns.Add("Email", GetType(String)) '8
            DataTable.Columns.Add("RFC", GetType(String)) '9
            DataTable.Columns.Add("Razon", GetType(String)) '10


            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = DataTable.NewRow()
                DataRow("Nombre") = dr(1)
                DataRow("Direccion") = dr(2)
                DataRow("Colonia") = dr(3)
                DataRow("Ciudad") = dr(4)
                DataRow("Codigo postal") = dr(5)
                DataRow("Telefono") = dr(6)
                DataRow("Email") = dr(7)
                DataRow("RFC") = dr(8)
                DataRow("Razon") = dr(9)

                DataTable.Rows.Add(DataRow)
            Next
            'nuevo push
            '--------->Agregar botón Ver
            Dim Editar As New DataGridViewButtonColumn()
            Editar.UseColumnTextForButtonValue = True
            Editar.Text = "Editar"
            Editar.Name = "Editar"          'Agregar nombre a columna
            Editar.HeaderText = "Acciones"
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            If DGV_Edit_CP.ColumnCount < 9 Then  'Condición para no desplegar otra columna
                DGV_Edit_CP.Columns.Add(Editar)
            End If

            DGV_Edit_CP.DataSource = DataTable
            '-----Determinamos el alto de las filas
            DGV_Edit_CP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DGV_Edit_CP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '--------->Configurar aspectos visuales
            DGV_Edit_CP.BackgroundColor = Color.AliceBlue
            DGV_Edit_CP.AllowUserToAddRows = False
            DGV_Edit_CP.ReadOnly = True       'El control DataGridView será de sólo lectura

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Textbusclient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbusclient.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub DGV_Edit_CP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Edit_CP.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        'Dim con2 As Integer = 0
        Try
            If DGV_Edit_CP.Columns(e.ColumnIndex).Name = "Editar" Then
                '--------->Campos enviar a formulario
                Dim id As String
                id = DGV_Edit_CP.Rows(e.RowIndex).Cells("Id").Value
                '--------->Instrucción abrir formulario y enviar datos de tabla
                Dim ds As DataSet = GetClientesByID(CInt(id))

                For Each dr As DataRow In ds.Tables(0).Rows
                    id_cliente = dr(0)
                    Text_nomb.Text = dr(1)
                    Text_dir.Text = dr(2)
                    Text_col.Text = dr(3)
                    Text_cd.Text = dr(4)
                    Text_cp.Text = dr(5)
                    Text_tel.Text = dr(6)
                    Text_mail.Text = dr(7)
                    TxtRfc.Text = dr(8)
                    TxtRazon.Text = dr(9)
                Next

                Tab_proveedor.TabPages(0).Text = "Editar"
                Tab_proveedor.SelectedIndex = 0

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class