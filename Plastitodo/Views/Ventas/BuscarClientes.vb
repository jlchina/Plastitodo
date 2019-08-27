Public Class BuscarClientes
    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Dim ds As DataSet = GetSearchClientes(TxtFrase.Text)
        Dim DataTable As New DataTable()

        'Declarar columnas para data gridview
        DataTable.Columns.Add("Id", GetType(String)) '1
        DataTable.Columns.Add("Nombre", GetType(String)) '2
        DataTable.Columns.Add("Direccion", GetType(String)) '3
        DataTable.Columns.Add("Colonia", GetType(String)) '4
        DataTable.Columns.Add("Ciudad", GetType(String)) '5
        DataTable.Columns.Add("Codigo postal", GetType(String)) '6
        DataTable.Columns.Add("Telefono", GetType(String)) '7
        DataTable.Columns.Add("Email", GetType(String)) '8

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

            DataTable.Rows.Add(DataRow)
        Next

        '--------->Agregar botón Ver
        Dim Editar As New DataGridViewButtonColumn()
        Editar.UseColumnTextForButtonValue = True
        Editar.Text = "Agregar"
        Editar.Name = "Agregar"          'Agregar nombre a columna
        Editar.HeaderText = "Acciones"
        Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If DgvClientes.ColumnCount < 8 Then  'Condición para no desplegar otra columna
            DgvClientes.Columns.Add(Editar)
        End If

        DgvClientes.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '--------->Configurar aspectos visuales
        DgvClientes.BackgroundColor = Color.AliceBlue
        DgvClientes.AllowUserToAddRows = False
        DgvClientes.ReadOnly = True       'El control DataGridView será de sólo lectura
    End Sub

    Private Sub DgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        'Dim con2 As Integer = 0
        Try
            If DgvClientes.Columns(e.ColumnIndex).Name = "Agregar" Then
                '--------->Campos enviar a formulario
                Dim id As String
                id = DgvClientes.Rows(e.RowIndex).Cells("Id").Value
                '--------->Instrucción abrir formulario y enviar datos de tabla
                OfertaVentaForm.GetClientData(CInt(id))
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class