Imports MySql.Data.MySqlClient

Public Class Cat_Clientes
    Dim id_cliente As Integer

    Private Function BusquedaClientes()
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
            DataTable.Columns.Add("RFC", GetType(String)) '1
            DataTable.Columns.Add("Nombre", GetType(String)) '2
            DataTable.Columns.Add("Razon", GetType(String)) '3
            DataTable.Columns.Add("Direccion", GetType(String)) '4
            DataTable.Columns.Add("Colonia", GetType(String)) '5
            DataTable.Columns.Add("Ciudad", GetType(String)) '6
            DataTable.Columns.Add("Codigo postal", GetType(String)) '7
            DataTable.Columns.Add("Telefono", GetType(String)) '8
            DataTable.Columns.Add("Email", GetType(String)) '9
            DataTable.Columns.Add("Id", GetType(String)) '10


            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = DataTable.NewRow()
                DataRow("RFC") = dr(8)
                DataRow("Nombre") = dr(1)
                DataRow("Razon") = dr(9)
                DataRow("Direccion") = dr(2)
                DataRow("Colonia") = dr(3)
                DataRow("Ciudad") = dr(4)
                DataRow("Codigo postal") = dr(5)
                DataRow("Telefono") = dr(6)
                DataRow("Email") = dr(7)
                DataRow("Id") = dr(0)

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
        Return 0
    End Function
    Private Sub Btn_agregarc_Click(sender As Object, e As EventArgs) Handles Btn_agregarc.Click
        Dim sql As String = Nothing
        Dim busreg As String = Nothing
        Dim ds1 As DataSet = New DataSet
        Dim val As Integer = Nothing
        Dim band As Boolean

        Try
                If (Text_nomb.Text IsNot "" And Text_dir.Text IsNot "" And Text_col.Text IsNot "" And
                    Text_cd.Text IsNot "" And Text_cp.Text IsNot "" And Text_cp.Text IsNot "" And Text_tel.Text And TxtRfc.Text IsNot "") Then

                    Dim sql2 = ""

                    If (id_cliente > 0) Then
                        sql2 = "UPDATE cliente
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
                        sql2 = "INSERT INTO cliente(Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email, rfc, razon_social) " & Chr(13) &
                               "VALUES(@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email, @rfc, @razon_social)"
                    End If

                    Try
                        'buscar duplicidad de registros 23-11-2019
                        If TxtRfc.Text <> "" Then
                            con_string = New MySqlConnection
                            con_string.ConnectionString = ConnectionString2
                            con_string.Open()
                            sql = "SELECT rfc FROM cliente WHERE rfc ='" & TxtRfc.Text & "'"
                            da = New MySqlDataAdapter(sql, con_string)
                            da.Fill(ds1)
                            con_string.Close()
                            For Each datar As DataRow In ds1.Tables(0).Rows
                                busreg = datar(0)
                            Next
                            If busreg = "" Then
                                val = 1
                            Else
                                val = 0
                            End If
                        Else MessageBox.Show("Favor de ingresar el RFC")
                        End If
                    Catch ex As Exception
                        MsgBox("Error")
                    End Try

                    If val > 0 Then
                        band = False
                    Else band = True

                    End If

                    If band = False Then

                        conn = New MySqlConnection
                        conn.ConnectionString = ConnectionString2
                        conn.Open()

                        cmd = New MySqlCommand(sql2, conn)
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
                        MsgBox("El RFC ingresado ya existe, verifique la informacion")
                    End If

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
        BusquedaClientes()
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

    Private Sub Text_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_tel.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Text_nomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_nomb.KeyPress
        onlyletters(e)
    End Sub

    Private Sub Text_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_cp.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Text_cd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_cd.KeyPress
        onlyletters(e)
    End Sub

    Private Sub Cat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BusquedaClientes()
    End Sub

End Class