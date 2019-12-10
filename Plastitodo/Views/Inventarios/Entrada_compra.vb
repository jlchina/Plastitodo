Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class Entrada_compra
    Dim ImpTotal As Decimal = Nothing
    Dim Subtot As Decimal = Nothing
    Dim Sumtot As Decimal = Nothing
    Dim folio As Integer
    Dim Id_TipoCompra As Integer
    Private Sub Entrada_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "ENTREADA DE MERCANCIAS POR ORDEN DE COMPRA"
        TxtFolio.Text = folio
    End Sub

    Public Sub GetDatosFolio(ByVal folioComp As Integer, tipo As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        folio = folioComp
        Id_TipoCompra = tipo
    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles CmbProducto.KeyUp
        Dim fila As Integer = Nothing
        Dim codigo As String = Nothing
        Dim dt As DataTable = New DataTable

        If (e.KeyCode = Keys.Enter) Then    'una vez presionada la tecla enter ingresa la informacion del codigo en el data grid

            codigo = CmbProducto.SelectedValue  'obtiene informacion del codigo
            DgvPedido.Rows.Add()
            fila = DgvPedido.Rows.Count - 1
            Try
                Dim ds As DataSet = GetProducto(codigo) 'busca la informacion del codigo en la bd
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
                    DgvPedido.Rows(fila).Cells(9).Value = Format(CDec(dr(6) * 0.16) + CDec(dr(6)), "$ #,###,##0.00") 'Total

                Next
                DgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                Sumar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            CmbProducto.Text = Nothing
        Else
            If (e.KeyCode = Keys.ShiftKey) Then 'si se presiona la tecla shift busca informacion relacionada del articulo en la bd
                If CmbProducto.Text <> "" And CmbProducto.Text.Length >= 3 Then 'comprueba que sean al menos 3 letras ingresadas
                    Dim ds As DataSet = GetProductos(CmbProducto.Text)  'busca la informacion del codigo en la bd
                    CmbProducto.DataSource = ds.Tables(0)       'Llena la tabla con la informacion buscada ne la bd
                    CmbProducto.DisplayMember = "descripcion"
                    CmbProducto.ValueMember = "codigo_barras"

                    Me.CmbProducto.DroppedDown = True
                Else
                    Me.CmbProducto.DroppedDown = False
                End If
            End If
        End If
    End Sub

    Private Sub Sumar()
        'se limpian los valores para no duplicar sumas
        ImpTotal = Nothing
        Subtot = Nothing
        Sumtot = Nothing

        'se lee el dgv para obtener la informacion y realizar las operaciones
        For Each Dt_Row As DataGridViewRow In DgvPedido.Rows
            If Dt_Row.Cells("total").Value <> "" Then
                Subtot = Subtot + CDec(Dt_Row.Cells("subtotal").Value)
                ImpTotal = Subtot * 0.16
                Sumtot = Sumtot + CDec(Dt_Row.Cells("total").Value)
            End If
        Next
        'una vez obtenida la informacion se llenan los textbox con los totales
        TxtSubTot.Text = CStr(Format(CDec(Subtot), "$ #,###,##0.00"))
        TxtImpTot.Text = CStr(Format(CDec(ImpTotal), "$ #,###,##0.00"))
        TxtTot.Text = CStr(Format(Sumtot, "$ #,###,##0.00"))

    End Sub
End Class