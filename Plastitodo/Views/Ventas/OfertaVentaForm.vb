Imports Plastitodo.VentasMod
Public Class OfertaVentaForm
    Dim ImpuestoTotal, Subtotal, Sumtotal As Decimal
    Private Sub OfertaVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbProducto.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            DgvLista.Rows.Add()
            Listar(CmbProducto.SelectedValue, DgvLista.Rows.Count)
            CmbProducto.Text = Nothing
            'CmbProducto.Items.Clear()
        Else
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
    End Sub

    Private Sub CmbProducto_DropDown(sender As Object, e As EventArgs) Handles CmbProducto.DropDown
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Listar(ByVal codigo As String, Fila As Integer)
        Try
            Dim ds As DataSet = GetProducto(codigo)

            For Each dr As DataRow In ds.Tables(0).Rows
                DgvLista.Rows(Fila - 1).Cells(0).Value = dr(1)
                DgvLista.Rows(Fila - 1).Cells(1).Value = dr(4)
                DgvLista.Rows(Fila - 1).Cells(2).Value = dr(8)
                DgvLista.Rows(Fila - 1).Cells(3).Value = 1
                DgvLista.Rows(Fila - 1).Cells(5).Value = Format(CDec(dr(6)), "$ #,###,##0.00")
                DgvLista.Rows(Fila - 1).Cells(6).Value = "IVA16"
                DgvLista.Rows(Fila - 1).Cells(7).Value = Format(CDec(dr(6)), "$ #,###,##0.00")
            Next

            DgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Contar()
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
                Subtotal = Subtotal + CDec(Dt_Row.Cells("total").Value)
                ImpuestoTotal = Subtotal * 0.16
                Sumtotal = Sumtotal + CDec(Dt_Row.Cells("total").Value)
            End If
        Next
        TxtSubTotal.Text = CStr(Format(CDec(Subtotal), "$ #,###,##0.00"))
        TxtImpuestoTotal.Text = CStr(Format(CDec(ImpuestoTotal), "$ #,###,##0.00"))
        TxtTotal.Text = CStr(Format(CDec(Sumtotal), "$ #,###,##0.00"))
    End Sub
End Class