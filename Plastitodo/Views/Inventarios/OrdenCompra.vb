Public Class OrdenCompra
    Dim ImpTotal, Subtot, Sumtot As Decimal
    Private Sub ListaOC(ByVal codigo As String, Fila As Integer)
        Try
            Dim ds As DataSet = GetProducto(codigo)

            For Each dr As DataRow In ds.Tables(0).Rows
                DgvPedido.Rows(Fila - 1).Cells(10).Value = ""
                DgvPedido.Rows(Fila - 1).Cells(0).Value = dr(1) 'Codigo
                DgvPedido.Rows(Fila - 1).Cells(1).Value = dr(4) 'Descripcion
                DgvPedido.Rows(Fila - 1).Cells(2).Value = dr(9) 'Presentacion
                DgvPedido.Rows(Fila - 1).Cells(3).Value = 1 'Cantidad
                DgvPedido.Rows(Fila - 1).Cells(4).Value = dr(10) 'Stock
                DgvPedido.Rows(Fila - 1).Cells(5).Value = Format(CDec(dr(11)), "$ #,###,##0.00") 'Costo
                DgvPedido.Rows(Fila - 1).Cells(6).Value = Format(CDec(dr(11)), "$ #,###,##0.00") 'Sub-total
                DgvPedido.Rows(Fila - 1).Cells(7).Value = Format(CDec(0), "##0.00") 'Descuento
                DgvPedido.Rows(Fila - 1).Cells(8).Value = Format(CDec(dr(11) * 0.16), "$ #,###,##0.00") 'Iva
                DgvPedido.Rows(Fila - 1).Cells(9).Value = Format(CDec(dr(11) * 0.16) + CDec(dr(11)), "$ #,###,##0.00") 'Total
            Next

            DgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            sumandos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetProvData(ByVal id_prov As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        Dim DataClientes As DataSet = GetProveedorByID(id_prov)
        CmbProv.Items.Clear()

        For Each dr As DataRow In DataClientes.Tables(0).Rows
            CmbProv.DisplayMember = dr(1)
            CmbProv.ValueMember = dr(0)
            TxtCiudad.Text = dr(4)
        Next

    End Sub

    Private Sub sumandos()
        ImpTotal = Nothing
        Subtot = Nothing
        Sumtot = Nothing

        For Each Dt_Row As DataGridViewRow In DgvPedido.Rows
            If Dt_Row.Cells("total").Value <> "" Then
                Subtot = Subtot + CDec(Dt_Row.Cells("stotal").Value)
                ImpTotal = Subtot * 0.16
                Subtot = Sumtot + CDec(Dt_Row.Cells("total").Value)
            End If
        Next
        TxtSubTot.Text = CStr(Format(CDec(Subtot), "$ #,###,##0.00"))
        TxtImpTot.Text = CStr(Format(CDec(ImpTotal), "$ #,###,##0.00"))
        TxtTot.Text = CStr(Format(Sumtot, "$ #,###,##0.00"))
    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles CmbProducto.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            DgvPedido.Rows.Add()
            ListaOC(CmbProducto.SelectedValue, DgvPedido.Rows.Count)
            CmbProducto.Text = Nothing
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

    Private Sub DgvPedido_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPedido.CellEndEdit
        Dim Filad As Integer = e.RowIndex

        Select Case DgvPedido.Columns(e.ColumnIndex).Name
            Case "cantidad"
                Dim Cantidad As String = DgvPedido.Rows(Filad).Cells(3).Value.ToString
                If Cantidad <> "" And Cantidad <> "0" Then
                    DgvPedido.Rows(Filad).Cells(6).Value = CStr(Format((CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)), "$ #,###,##0.00"))
                    DgvPedido.Rows(Filad).Cells(8).Value = CStr(Format((CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)) * 0.16, "$ #,###,##0.00"))
                    DgvPedido.Rows(Filad).Cells(9).Value = CStr(Format((CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * CDec(Cantidad)) * 1.16, "$ #,###,##0.00"))
                    sumandos()
                Else
                    DgvPedido.Rows(Filad).Cells(3).Value = "1"
                End If
            Case "descuento"
                Dim PrecioUnit, Descto As Decimal
                Dim Cantidad As Decimal = CDec(DgvPedido.Rows(Filad).Cells(3).Value.ToString)
                Descto = CDec(DgvPedido.Rows(Filad).Cells(6).Value.ToString)
                If Descto <> 0 Then
                    PrecioUnit = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) - (CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * (Descto / 100)) * 1.16
                Else
                    PrecioUnit = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * 1.16
                End If

                DgvPedido.Rows(Filad).Cells(9).Value = CStr(Format(PrecioUnit * CDec(Cantidad), "$ #,###,##0.00"))
                sumandos()

        End Select
    End Sub

    Private Sub CmbProv_KeyUp(sender As Object, e As KeyEventArgs) Handles CmbProv.KeyUp
        If (e.KeyCode = Keys.ShiftKey) Then
            If CmbProv.Text <> "" And CmbProv.Text.Length >= 3 Then
                BuscarProv(CmbProv.Text)
            Else
                Me.CmbProv.DroppedDown = False
                'CmbProducto.Items.Clear()
            End If
        End If
    End Sub

    Private Sub OrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub BuscarProv(Proveedor)
        'CmbProducto.Items.Clear()
        Dim ds As DataSet = GetProveedores(Proveedor)
        CmbProv.DataSource = ds.Tables(0)
        CmbProv.DisplayMember = "Nombre"
        CmbProv.ValueMember = "idProveedor"

        'CmbProducto.Select(CmbProducto.Text.Length + 1, 0)
        Me.CmbProv.DroppedDown = True
    End Sub

    Private Sub CmbProv_DropDown(sender As Object, e As EventArgs) Handles CmbProv.DropDown
        Cursor = Cursors.Arrow
    End Sub
End Class