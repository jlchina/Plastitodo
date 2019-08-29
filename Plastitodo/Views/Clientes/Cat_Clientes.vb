Imports MySql.Data.MySqlClient

Public Class Cat_Clientes
    Private Sub Cat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    comando = New MySqlCommand("INSERT INTO cliente(idCliente, Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email)" & Chr(13) &
        '                               "VALUES(@idCliente,@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email)", con_string)
        '    comando.Parameters.AddWithValue("@idCliente", Text_id.Text)
        '    comando.Parameters.AddWithValue("@Nombre", Text_nomb.Text)
        '    comando.Parameters.AddWithValue("@Direccion", Text_dir.Text)
        '    comando.Parameters.AddWithValue("@Colonia", Text_col.Text)
        '    comando.Parameters.AddWithValue("@Ciudad", Text_cd.Text)
        '    comando.Parameters.AddWithValue("@Codigo_postal", Text_cp.Text)
        '    comando.Parameters.AddWithValue("@telefono", Text_tel.Text)
        '    comando.Parameters.AddWithValue("@email", Text_mail.Text)
        '    comando.ExecuteNonQuery()test
        '    MsgBox("Cliente guardado con exito")
        'Catch ex As Exception
        '    MsgBox(ex.Message, "Hubo un error al guardar el Cliente, verifique los datos")
        'End Try
    End Sub

    Private Sub Btn_agregarc_Click(sender As Object, e As EventArgs) Handles Btn_agregarc.Click
        Try
            If (Text_nomb.Text IsNot "" And Text_dir.Text IsNot "" And Text_col.Text IsNot "" And
                Text_cd.Text IsNot "" And Text_cp.Text IsNot "" And Text_cp.Text IsNot "" And Text_tel.Text And TxtRfc.Text IsNot "") Then
                comando = New MySqlCommand("INSERT INTO cliente(Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email, rfc, razon_social)" & Chr(13) &
                                       "VALUES(@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email, @rfc, @razon_social)", con_string)

                comando.Parameters.AddWithValue("@Nombre", Text_nomb.Text)
                comando.Parameters.AddWithValue("@Direccion", Text_dir.Text)
                comando.Parameters.AddWithValue("@Colonia", Text_col.Text)
                comando.Parameters.AddWithValue("@Ciudad", Text_cd.Text)
                comando.Parameters.AddWithValue("@Codigo_postal", Text_cp.Text)
                comando.Parameters.AddWithValue("@telefono", Text_tel.Text)
                comando.Parameters.AddWithValue("@email", Text_mail.Text)
                comando.Parameters.AddWithValue("@rfc", TxtRfc.Text)
                comando.Parameters.AddWithValue("@razon_social", TxtRazon.Text)
                comando.ExecuteNonQuery()
                MsgBox("Cliente guardado con exito")
            Else
                MessageBox.Show("Favor de llenar la informacion necesaria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el Cliente, verifique los datos")
            limpiar()
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "Select * from cliente where Nombre like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & Textbusclient.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVconsultclient.DataSource = dt
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            DataTable.Columns.Add("Id", GetType(String)) '1
            DataTable.Columns.Add("Nombre", GetType(String)) '2
            DataTable.Columns.Add("Direccion", GetType(String)) '3
            DataTable.Columns.Add("Colonia", GetType(String)) '4
            DataTable.Columns.Add("Ciudad", GetType(String)) '5
            DataTable.Columns.Add("Codigo postal", GetType(String)) '6
            DataTable.Columns.Add("Telefono", GetType(String)) '7
            DataTable.Columns.Add("Email", GetType(String)) '8
            DataTable.Columns.Add("RFC", GetType(String)) '8
            DataTable.Columns.Add("Razon", GetType(String)) '8


            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = DataTable.NewRow()
                DataRow("Id") = dr(0)
                DataRow("Nombre") = dr(1)
                DataRow("Direccion") = dr(2)
                DataRow("Colonia") = dr(3)
                DataRow("Ciudad") = dr(4)
                DataRow("Codigo postal") = dr(5)
                DataRow("Telefono") = dr(6)
                DataRow("Email") = dr(6)
                DataRow("RFC") = dr(7)
                DataRow("Razon") = dr(8)

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
End Class