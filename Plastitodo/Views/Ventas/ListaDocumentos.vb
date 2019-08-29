Public Class ListaDocumentos
    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Dim ds As DataSet = GetDocumentos(TxtNombre.Text, TxtFecha.Text)
        Dim DataTable As New DataTable()

        'Declarar columnas para data gridview
        DataTable.Columns.Add("Folio", GetType(String)) '1
        DataTable.Columns.Add("Tipo", GetType(String)) '2
        DataTable.Columns.Add("Cliente", GetType(String)) '3
        DataTable.Columns.Add("Nombre", GetType(String)) '4
        DataTable.Columns.Add("Vendedor", GetType(String)) '5
        DataTable.Columns.Add("Total", GetType(String)) '6
        DataTable.Columns.Add("Fecha", GetType(String)) '7


        For Each dr As DataRow In ds.Tables(0).Rows
            Dim DataRow As DataRow = DataTable.NewRow()
            DataRow("Folio") = dr(0)
            DataRow("Tipo") = dr(1)
            DataRow("Cliente") = dr(2)
            DataRow("Nombre") = dr(3)
            DataRow("Vendedor") = dr(4)
            DataRow("Total") = Format(CDec(dr(5)), "$ #,###,##0.00")
            DataRow("Fecha") = dr(6)


            DataTable.Rows.Add(DataRow)
        Next

        '--------->Agregar botón Ver
        Dim Editar As New DataGridViewButtonColumn()
        Editar.UseColumnTextForButtonValue = True
        Editar.Text = "Editar"
        Editar.Name = "Editar"          'Agregar nombre a columna
        Editar.HeaderText = "Acciones"
        Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If DgvDocumentos.ColumnCount < 7 Then  'Condición para no desplegar otra columna
            DgvDocumentos.Columns.Add(Editar)
        End If

        DgvDocumentos.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvDocumentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '--------->Configurar aspectos visuales
        DgvDocumentos.BackgroundColor = Color.AliceBlue
        DgvDocumentos.AllowUserToAddRows = False
        DgvDocumentos.ReadOnly = True       'El control DataGridView será de sólo lectura
    End Sub

    Private Sub DgvDocumentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDocumentos.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        'Dim con2 As Integer = 0
        Try
            If DgvDocumentos.Columns(e.ColumnIndex).Name = "Editar" Then
                '--------->Campos enviar a formulario
                Dim folio As String
                Dim tipo As Integer
                folio = DgvDocumentos.Rows(e.RowIndex).Cells("Folio").Value
                If (DgvDocumentos.Rows(e.RowIndex).Cells("Tipo").Value = "Nota de venta") Then
                    tipo = 1
                Else
                    tipo = 2
                End If
                '--------->Instrucción abrir formulario y enviar datos de tabla
                Dim VerForm As New OfertaVentaForm()
                VerForm.GetCompleteData(CInt(folio), tipo)
                VerForm.Show()
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListaDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
End Class