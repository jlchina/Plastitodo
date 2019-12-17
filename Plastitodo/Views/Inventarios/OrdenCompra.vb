Public Class OrdenCompra
    Dim ImpTotal As Decimal = Nothing
    Dim Subtot As Decimal = Nothing
    Dim Sumtot As Decimal = Nothing

    Public Sub GetProvDatos(ByVal id_prov As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        Dim DataProvs As DataSet = GetProveedorByID(id_prov)
        CmbProv.Items.Clear()

        For Each dr As DataRow In DataProvs.Tables(0).Rows
            CmbProv.DisplayMember = dr(1)
            CmbProv.ValueMember = dr(0)
            TxtCiudad.Text = dr(1)
        Next

    End Sub

    Private Sub OrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbProducto.KeyUp
        Dim fila As Integer = Nothing
        Dim codigo As String = Nothing
        Dim dt As DataTable = New DataTable

        If (e.KeyCode = Keys.Enter) Then
            'ListaOC(CmbProducto.SelectedValue, DgvPedido.Rows.Count)
            codigo = CmbProducto.SelectedValue
            fila = DgvPedido.Rows.Count - 1
            Try
                Dim ds As DataSet = GetProducto(codigo)
                For Each dr As DataRow In ds.Tables(0).Rows
                    DgvPedido.Rows(fila).Cells(10).Value = ""
                    DgvPedido.Rows(fila).Cells(0).Value = dr(1) 'Codigo
                    DgvPedido.Rows(fila).Cells(1).Value = dr(4) 'Descripcion
                    DgvPedido.Rows(fila).Cells(2).Value = dr(9) 'Presentacion
                    DgvPedido.Rows(fila).Cells(3).Value = 1 'Cantidad
                    DgvPedido.Rows(fila).Cells(4).Value = dr(10) 'Stock
                    DgvPedido.Rows(fila).Cells(5).Value = Format(CDec(dr(6)), "$ #,###,##0.00") 'Precio
                    DgvPedido.Rows(fila).Cells(6).Value = Format(CDec(dr(6)), "$ #,###,##0.00") 'Sub-total
                    DgvPedido.Rows(fila).Cells(7).Value = Format(CDec(0), "##0.00") 'Descuento
                    DgvPedido.Rows(fila).Cells(8).Value = Format(CDec(dr(6) * 0.16), "$ #,###,##0.00") 'Iva
                    DgvPedido.Rows(fila).Cells(9).Value = Format(CDec(dr(6) * 0.16) + CDec(dr(11)), "$ #,###,##0.00") 'Total
                    DgvPedido.Rows.Add()
                Next
                DgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                Sumar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Try
            '    Dim ds As DataSet = GetProducto(codigo)

            '    For Each dr As DataRow In ds.Tables(0).Rows
            '        Dim Renglon As DataRow = dt.NewRow()
            '        Renglon("codigo") = dr(1)
            '        Renglon("descripcion") = dr(4)
            '        Renglon("presentacion") = dr(9)
            '        Renglon("cantidad") = 1 'Cantidad
            '        Renglon("stock") = dr(10)
            '        Renglon("precio") = Format(CDec(dr(6)), "$ #,###,##0.00") 'Precio
            '        Renglon("subtotal") = Format(CDec(dr(6)), "$ #,###,##0.00") 'Sub-total
            '        Renglon("descuento") = Format(CDec(0), "##0.00") 'Descuento
            '        Renglon("iva") = Format(CDec(dr(6) * 0.16), "$ #,###,##0.00") 'Iva
            '        Renglon("total") = Format(CDec(dr(6) * 0.16) + CDec(dr(11)), "$ #,###,##0.00") 'Total
            '        Renglon("id") = ""

            '        dt.Rows.Add(Renglon)

            '        Me.DgvPedido.DataSource = dt
            '        DgvPedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            '        DgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '    Next
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            CmbProducto.Text = Nothing
        Else
            If (e.KeyCode = Keys.ShiftKey) Then
                If CmbProducto.Text <> "" And CmbProducto.Text.Length >= 3 Then
                    Dim ds As DataSet = GetProductos(CmbProducto.Text)
                    CmbProducto.DataSource = ds.Tables(0)
                    CmbProducto.DisplayMember = "descripcion"
                    CmbProducto.ValueMember = "codigo_barras"

                    Me.CmbProducto.DroppedDown = True
                Else
                    Me.CmbProducto.DroppedDown = False
                End If
            End If
        End If
    End Sub

    Private Sub CmbProv_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbProv.KeyUp
        If (e.KeyCode = Keys.ShiftKey) Then
            If CmbProv.Text <> "" And CmbProv.Text.Length >= 3 Then
                BuscarProveedores(CmbProv.Text)
            Else
                Me.CmbProv.DroppedDown = False
            End If
        End If

    End Sub

    Private Sub BuscarProveedores(Provs)
        Dim ds As DataSet = GetProveedores(Provs)
        CmbProv.DataSource = ds.Tables(0)
        CmbProv.DisplayMember = "Nombre"
        CmbProv.ValueMember = "idProveedor"

        Me.CmbProv.DroppedDown = True
    End Sub

    Private Sub CmbProv_DropDown(sender As Object, e As EventArgs) Handles CmbProv.DropDown
        Cursor = Cursors.Arrow
    End Sub

    Private Sub ListaOC(ByVal codigo As String, Fila As Integer)
        ListaOC(CmbProducto.SelectedValue, DgvPedido.Rows.Count)
        Try
            Dim ds As DataSet = GetEntradaProducto(codigo)

            For Each dr As DataRow In ds.Tables(0).Rows
                DgvPedido.Rows(Fila - 1).Cells(10).Value = ""
                DgvPedido.Rows(Fila - 1).Cells(0).Value = dr(1) 'Codigo
                DgvPedido.Rows(Fila - 1).Cells(1).Value = dr(4) 'Descripcion
                DgvPedido.Rows(Fila - 1).Cells(2).Value = dr(9) 'Presentacion
                DgvPedido.Rows(Fila - 1).Cells(3).Value = 1 'Cantidad
                DgvPedido.Rows(Fila - 1).Cells(4).Value = dr(10) 'Stock
                DgvPedido.Rows(Fila - 1).Cells(5).Value = Format(CDec(dr(6)), "$ #,###,##0.00") 'Precio
                DgvPedido.Rows(Fila - 1).Cells(6).Value = Format(CDec(dr(6)), "$ #,###,##0.00") 'Sub-total
                DgvPedido.Rows(Fila - 1).Cells(7).Value = Format(CDec(0), "##0.00") 'Descuento
                DgvPedido.Rows(Fila - 1).Cells(8).Value = Format(CDec(dr(6) * 0.16), "$ #,###,##0.00") 'Iva
                DgvPedido.Rows(Fila - 1).Cells(9).Value = Format(CDec(dr(6) * 0.16) + CDec(dr(11)), "$ #,###,##0.00") 'Total
            Next

            DgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Sumar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Sumar()
        For Each Dt_Row As DataGridViewRow In DgvPedido.Rows
            If Dt_Row.Cells("total").Value <> "" Then
                Subtot = Subtot + CDec(Dt_Row.Cells("subtotal").Value)
                ImpTotal = Subtot * 0.16
                Sumtot = Sumtot + CDec(Dt_Row.Cells("total").Value)
            End If
        Next
        TxtSubTot.Text = CStr(Format(CDec(Subtot), "$ #,###,##0.00"))
        TxtImpTot.Text = CStr(Format(CDec(ImpTotal), "$ #,###,##0.00"))
        TxtTot.Text = CStr(Format(Sumtot, "$ #,###,##0.00"))

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
                    Sumar()
                Else
                    DgvPedido.Rows(Filad).Cells(3).Value = "1"
                End If
            Case "descuento"
                Dim PrecioUnidad, Desc As Decimal
                Dim Cantidad As Decimal = CDec(DgvPedido.Rows(Filad).Cells(3).Value.ToString)
                Desc = CDec(DgvPedido.Rows(Filad).Cells(6).Value.ToString)
                If Desc <> 0 Then
                    PrecioUnidad = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) - (CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * (Desc / 100)) * 1.16
                Else
                    PrecioUnidad = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * 1.16
                End If

                DgvPedido.Rows(Filad).Cells(9).Value = CStr(Format(PrecioUnidad * CDec(Cantidad), "$ #,###,##0.00"))
                Sumar()

        End Select
    End Sub

End Class