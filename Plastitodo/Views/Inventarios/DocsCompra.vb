Public Class DocsCompra
    Private Sub DocsCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
        Me.Text = "LISTADO DE DOCUMENTOS DE COMPRAS"
    End Sub

    Private Sub BtnBusq_Click(sender As Object, e As EventArgs) Handles BtnBusq.Click
        Dim ds As DataSet = GetFolios(TxtNombre.Text, TxtFecha.Text)
        Dim DataTable As New DataTable()

        'Declarar columnas para data gridview
        DataTable.Columns.Add("Folio", GetType(String)) '1
        DataTable.Columns.Add("Tipo", GetType(String)) '2
        DataTable.Columns.Add("Proveedor", GetType(String)) '3
        DataTable.Columns.Add("Usuario", GetType(String)) '4
        DataTable.Columns.Add("Total", GetType(String)) '5
        DataTable.Columns.Add("Fecha", GetType(String)) '6


        For Each dr As DataRow In ds.Tables(0).Rows
            Dim DataRow As DataRow = DataTable.NewRow()
            DataRow("Folio") = dr(0)
            DataRow("Tipo") = dr(1)
            DataRow("Proveedor") = dr(2)
            DataRow("Usuario") = dr(4)
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

        If DgvOC.ColumnCount < 6 Then  'Condición para no desplegar otra columna
            DgvOC.Columns.Add(Editar)
        End If

        DgvOC.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvOC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvOC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '--------->Configurar aspectos visuales
        DgvOC.BackgroundColor = Color.AliceBlue
        DgvOC.AllowUserToAddRows = False
        DgvOC.ReadOnly = True       'El control DataGridView será de sólo lectura
    End Sub

    Private Sub DgvOC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOC.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Try
            If DgvOC.Columns(e.ColumnIndex).Name = "Editar" Then
                '--------->Campos enviar a formulario
                Dim folio As String
                Dim tipo As Integer
                folio = DgvOC.Rows(e.RowIndex).Cells("Folio").Value
                If (DgvOC.Rows(e.RowIndex).Cells("Tipo").Value = "Orden de compra") Then
                    tipo = 3
                Else
                    tipo = 4
                End If
                '--------->Instrucción abrir formulario y enviar datos de tabla
                Dim VerForm As New Entrada_compra()
                VerForm.GetDatosFolio(CInt(folio), tipo)
                VerForm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class