Imports Plastitodo.VentasMod
Public Class OfertaVentaForm
    Dim folio As Integer
    Dim id_tipo_documento As Integer

    Public Sub GetCompleteData(ByVal folioDoc As Integer, tipo As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        folio = folioDoc
        id_tipo_documento = tipo
    End Sub

    Public Sub GetClientData(ByVal id_cliente As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        Dim DataClientes As DataSet = GetClientesByID(id_cliente)
        CmbCliente.Items.Clear()

        For Each dr As DataRow In DataClientes.Tables(0).Rows
            CmbCliente.DisplayMember = dr(1)
            CmbCliente.ValueMember = dr(0)
            TxtNombre.Text = dr(1)
        Next

        'CmbCliente.SelectedIndex = 0

        'CmbProducto.Select(CmbProducto.Text.Length + 1, 0)
        'Me.CmbCliente.DroppedDown = True
    End Sub

    Public Sub GetTipo(ByVal tipo As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        id_tipo_documento = tipo
    End Sub

    Dim ImpuestoTotal, Subtotal, Sumtotal As Decimal
    Private Sub OfertaVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
        If (id_tipo_documento) Then
            If (folio = 0) Then
                TxtFolio.Text = GetFolioMax(id_tipo_documento)
                BtnCrear.Text = "Crear"
            Else
                BtnCrear.Text = "Guardar"
            End If
            If (id_tipo_documento = 1) Then
                Me.Text = "Nota de venta - Nuevo"
            Else
                Me.Text = "Oferta de venta - Nuevo"
            End If
        End If
        If (folio > 0 And id_tipo_documento > 0) Then
            BtnCrear.Enabled = False
            Dim DataPerfil As DataSet = GetDocumento(folio, id_tipo_documento)
            For Each dr As DataRow In DataPerfil.Tables(0).Rows
                TxtFolio.Text = dr(1)
                TxtNombre.Text = dr(4)
                TxtVendedor.Text = dr(5)
                TxtComentarios.Text = dr(6)
                TxtSubTotal.Text = Format(CDec(dr(7)), "$ #,###,##0.00")
                TxtImpuestoTotal.Text = Format(CDec(dr(8)), "$ #,###,##0.00")
                TxtTotal.Text = Format(CDec(dr(9)), "$ #,###,##0.00") '
                TxtFecha.Text = dr(14)
                BuscarCliente(dr(13))
            Next
            Listar2()
            BtnCopiara.Enabled = True
            If (id_tipo_documento = 1) Then
                Me.Text = "Nota de venta - Folio: " & TxtFolio.Text
            Else
                Me.Text = "Oferta de venta - Folio: " & TxtFolio.Text
            End If
        Else
            BtnCrear.Enabled = True
        End If
    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbProducto.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            DgvLista.Rows.Add()
            Listar(CmbProducto.SelectedValue, DgvLista.Rows.Count)
            CmbProducto.Text = Nothing
            'CmbProducto.Items.Clear()
        Else
            If (e.KeyCode = Keys.ShiftKey) Then
                If CmbProducto.Text <> "" And CmbProducto.Text.Length >= 3 Then
                    'CmbProducto.Items.Clear()
                    Dim ds As DataSet = GetProductos(CmbProducto.Text)
                    CmbProducto.DataSource = ds.Tables(0)
                    CmbProducto.DisplayMember = "descripcion"
                    CmbProducto.ValueMember = "codigo_barras"

                    'CmbProducto.Select(CmbProducto.Text.Length + 1, 0)
                    Me.CmbProducto.DroppedDown = True
                Else
                    Me.CmbProducto.DroppedDown = False
                    'CmbProducto.Items.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub CmbProducto_DropDown(sender As Object, e As EventArgs) Handles CmbProducto.DropDown
        ' Cursor = Cursors.Arrow
    End Sub

    Private Sub CmbCliente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbCliente.KeyUp
        If (e.KeyCode = Keys.ShiftKey) Then
            If CmbCliente.Text <> "" And CmbCliente.Text.Length >= 3 Then
                BuscarCliente(CmbCliente.Text)
            Else
                Me.CmbCliente.DroppedDown = False
                'CmbProducto.Items.Clear()
            End If
        End If

    End Sub

    Private Sub BuscarCliente(cliente)
        'CmbProducto.Items.Clear()
        Dim ds As DataSet = GetClientes(cliente)
        CmbCliente.DataSource = ds.Tables(0)
        CmbCliente.DisplayMember = "Nombre"
        CmbCliente.ValueMember = "idCliente"

        'CmbProducto.Select(CmbProducto.Text.Length + 1, 0)
        Me.CmbCliente.DroppedDown = True
    End Sub

    Private Sub CmbCliente_DropDown(sender As Object, e As EventArgs) Handles CmbCliente.DropDown
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Listar(ByVal codigo As String, Fila As Integer)
        Try
            Dim ds As DataSet = GetProducto(codigo)

            For Each dr As DataRow In ds.Tables(0).Rows
                DgvLista.Rows(Fila - 1).Cells(10).Value = ""
                DgvLista.Rows(Fila - 1).Cells(0).Value = dr(1) 'Codigo
                DgvLista.Rows(Fila - 1).Cells(1).Value = dr(4) 'Descripcion
                DgvLista.Rows(Fila - 1).Cells(2).Value = dr(9) 'Presentacion
                DgvLista.Rows(Fila - 1).Cells(3).Value = 1 'Cantidad
                DgvLista.Rows(Fila - 1).Cells(4).Value = dr(10) 'Stock
                DgvLista.Rows(Fila - 1).Cells(5).Value = Format(CDec(dr(11)), "$ #,###,##0.00") 'Precio
                DgvLista.Rows(Fila - 1).Cells(6).Value = Format(CDec(dr(11)), "$ #,###,##0.00") 'Sub-total
                DgvLista.Rows(Fila - 1).Cells(7).Value = Format(CDec(0), "##0.00") 'Descuento
                DgvLista.Rows(Fila - 1).Cells(8).Value = Format(CDec(dr(11) * 0.16), "$ #,###,##0.00") 'Iva
                DgvLista.Rows(Fila - 1).Cells(9).Value = Format(CDec(dr(11) * 0.16) + CDec(dr(11)), "$ #,###,##0.00") 'Total
            Next

            DgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Contar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Listar2()
        Try
            Dim ds As DataSet = GetLineasDocumento(folio, id_tipo_documento)

            For Each dr As DataRow In ds.Tables(0).Rows
                DgvLista.Rows.Add()
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(10).Value = dr(0) 'Id
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(0).Value = dr(1) 'Codigo
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(1).Value = dr(2) 'Descripcion
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(2).Value = dr(3) 'Presentacion
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(3).Value = dr(4) 'Cantidad
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(4).Value = dr(10) 'Stock
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(5).Value = Format(CDec(dr(5)), "$ #,###,##0.00") 'Precio
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(6).Value = Format(CDec(dr(6)), "$ #,###,##0.00") 'Sub-total
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(7).Value = Format(CDec(dr(7)), "##0.00") 'Descuento
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(8).Value = Format(CDec(dr(8)), "$ #,###,##0.00") 'Iva
                DgvLista.Rows(DgvLista.Rows.Count - 1).Cells(9).Value = Format(CDec(dr(9)), "$ #,###,##0.00") 'Total
            Next

            DgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Contar()
        ImpuestoTotal = Nothing
        Subtotal = Nothing
        Sumtotal = Nothing

        For Each Dt_Row As DataGridViewRow In DgvLista.Rows
            If Dt_Row.Cells("total").Value <> "" Then
                Subtotal = Subtotal + CDec(Dt_Row.Cells("stotal").Value)
                ImpuestoTotal = Subtotal * 0.16
                Sumtotal = Sumtotal + CDec(Dt_Row.Cells("total").Value)
            End If
        Next
        TxtSubTotal.Text = CStr(Format(CDec(Subtotal), "$ #,###,##0.00"))
        TxtImpuestoTotal.Text = CStr(Format(CDec(ImpuestoTotal), "$ #,###,##0.00"))
        TxtTotal.Text = CStr(Format(Sumtotal, "$ #,###,##0.00"))
    End Sub

    Private Sub BtnCopiara_Click(sender As Object, e As EventArgs) Handles BtnCopiara.Click
        ContextMenuStrip1.Show(BtnCopiara, 0, BtnCopiara.Height)
    End Sub

    Private Sub OfertaDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfertaDeVentaToolStripMenuItem.Click
        folio = Nothing
        id_tipo_documento = 2
        Me.Text = "Oferta de venta - Nuevo"
        TxtFolio.Text = GetFolioMax(id_tipo_documento)
        BtnCrear.Enabled = True
        BtnCrear.Text = "Crear"
    End Sub

    Private Sub NotaDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaDeVentaToolStripMenuItem.Click
        folio = Nothing
        id_tipo_documento = 1
        Me.Text = "Nota de venta - Nuevo"
        TxtFolio.Text = GetFolioMax(id_tipo_documento)
        BtnCrear.Enabled = True
        BtnCrear.Text = "Crear"
    End Sub

    Private Sub DgvLista_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellEndEdit
        Dim Filad As Integer = e.RowIndex

        Select Case DgvLista.Columns(e.ColumnIndex).Name
            Case "cantidad"
                Dim Cantidad As String = DgvLista.Rows(Filad).Cells(3).Value.ToString
                If Cantidad <> "" And Cantidad <> "0" Then
                    DgvLista.Rows(Filad).Cells(6).Value = CStr(Format((CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)), "$ #,###,##0.00"))
                    DgvLista.Rows(Filad).Cells(8).Value = CStr(Format((CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)) * 0.16, "$ #,###,##0.00"))
                    DgvLista.Rows(Filad).Cells(9).Value = CStr(Format((CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)) * 1.16, "$ #,###,##0.00"))
                    Contar()
                Else
                    DgvLista.Rows(Filad).Cells(3).Value = "1"
                End If
            Case "descuento"
                Dim PrecioUnidad, Desc As Decimal
                Dim Cantidad As Decimal = CDec(DgvLista.Rows(Filad).Cells(3).Value.ToString)
                Desc = CDec(DgvLista.Rows(Filad).Cells(6).Value.ToString)
                If Desc <> 0 Then
                    PrecioUnidad = CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) - (CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) * (Desc / 100)) * 1.16
                Else
                    PrecioUnidad = CDec(DgvLista.Rows(Filad).Cells(5).Value.ToString) * 1.16
                End If

                DgvLista.Rows(Filad).Cells(9).Value = CStr(Format(PrecioUnidad * CDec(Cantidad), "$ #,###,##0.00"))
                Contar()

        End Select
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Dim ds As DataSet = New DataSet
        Dim valid As Boolean = False

        Dim lineas As New DataTable
        lineas.Columns.Add("id")
        lineas.Columns.Add("codigo")
        lineas.Columns.Add("cantidad")
        lineas.Columns.Add("precio")
        lineas.Columns.Add("descuento")
        lineas.Columns.Add("subtotal")
        lineas.Columns.Add("iva")
        lineas.Columns.Add("total")

        For Each Dt_Row As DataGridViewRow In DgvLista.Rows
            Dim row As DataRow = lineas.NewRow()
            row("id") = Dt_Row.Cells("id").Value
            row("codigo") = Dt_Row.Cells("codigo").Value
            row("cantidad") = Dt_Row.Cells("cantidad").Value
            row("precio") = CDec(Dt_Row.Cells("precio").Value)
            row("descuento") = CDec(Dt_Row.Cells("descuento").Value)
            row("subtotal") = CDec(Dt_Row.Cells("stotal").Value)
            row("iva") = CDec(Dt_Row.Cells("iva").Value)
            row("total") = CDec(Dt_Row.Cells("total").Value)

            lineas.Rows.Add(row)
            valid = True
        Next

        ds.Tables.Add(lineas)

        If (CmbCliente.SelectedValue > 0 And TxtNombre.Text IsNot "" And TxtVendedor.Text IsNot "" And valid) Then
            If (DocumentoVenta(folio, id_tipo_documento, CmbCliente.SelectedValue, TxtNombre.Text, TxtVendedor.Text, TxtComentarios.Text, CDec(TxtSubTotal.Text), CDec(TxtImpuestoTotal.Text), CDec(TxtTotal.Text), ds)) Then
                MessageBox.Show("Documento guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("Favor de llenar la informacion necesaria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class