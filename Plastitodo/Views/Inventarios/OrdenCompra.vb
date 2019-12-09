Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class OrdenCompra
    Dim ImpTotal As Decimal = Nothing
    Dim Subtot As Decimal = Nothing
    Dim Sumtot As Decimal = Nothing
    Dim NoProv As Integer = Nothing

    Public Sub GetProvDatos(ByVal id_prov As Integer)
        '--------->Establecer valores obtenidos del GridViewForm
        Dim DataProvs As DataSet = GetProveedorByID(id_prov)
        CmbProv.Items.Clear()

        For Each dr As DataRow In DataProvs.Tables(0).Rows
            CmbProv.DisplayMember = dr(1)
            CmbProv.ValueMember = dr(0)
        Next

    End Sub

    Private Sub OrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
        TxtUsuario.Text = usuariolog
        Me.Text = "GENERAR ORDEN DE COMPRA"

        'extraer el numero maximo de folios creados
        Try
            Dim foliomax As String = Nothing

            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            foliomax = "Select ifnull(max(folio)+1,1) as MaxFol From orden_compra"
            cmd = New MySqlCommand(foliomax, con_string)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    'obtener valores de la consulta
                    TxtFolio.Text = dr.Item("MaxFol").ToString 'si quieres mostrar el resultado en este textbox
                End While
            End If
            dr.Close()
            con_string.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CmbProducto_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbProducto.KeyUp
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

    Private Sub DgvPedido_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPedido.CellEndEdit

        'si se editan los valores del dgv, aqui se realizan calculos de acuerdo a los cambios ingresados
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
                Desc = CDec(DgvPedido.Rows(Filad).Cells(7).Value.ToString)

                If Desc <> 0 Then
                    PrecioUnidad = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString) * (1 - (Desc / 100))
                Else
                    PrecioUnidad = CDec(DgvPedido.Rows(Filad).Cells(5).Value.ToString)
                End If

                DgvPedido.Rows(Filad).Cells(6).Value = CStr(Format(PrecioUnidad * CDec(Cantidad), "$ #,###,##0.00"))
                DgvPedido.Rows(Filad).Cells(8).Value = CStr(Format((PrecioUnidad * 0.16) * CDec(Cantidad), "$ #,###,##0.00"))
                DgvPedido.Rows(Filad).Cells(9).Value = CStr(Format((PrecioUnidad * 1.16) * CDec(Cantidad), "$ #,###,##0.00"))

                Sumar()

        End Select
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim ds As DataSet = New DataSet
        Dim valid As Boolean = False
        Dim lineas As New DataTable
        Dim documento As Integer = 3

        lineas.Columns.Add("id")
        lineas.Columns.Add("codigo")
        lineas.Columns.Add("cantidad")
        lineas.Columns.Add("precio")
        lineas.Columns.Add("descuento")
        lineas.Columns.Add("subtotal")
        lineas.Columns.Add("iva")
        lineas.Columns.Add("total")

        For Each Dt_Row As DataGridViewRow In DgvPedido.Rows
            Dim row As DataRow = lineas.NewRow()
            row("id") = Dt_Row.Cells("id").Value
            row("codigo") = Dt_Row.Cells("codigo").Value
            row("cantidad") = Dt_Row.Cells("cantidad").Value
            row("precio") = CDec(Dt_Row.Cells("precio").Value)
            row("descuento") = CDec(Dt_Row.Cells("descuento").Value)
            row("subtotal") = CDec(Dt_Row.Cells("subtotal").Value)
            row("iva") = CDec(Dt_Row.Cells("iva").Value)
            row("total") = CDec(Dt_Row.Cells("total").Value)

            lineas.Rows.Add(row)
            valid = True
        Next

        ds.Tables.Add(lineas)

        If (CmbProv.SelectedValue > 0 And TxtUsuario.Text IsNot "" And TxtSubTot.Text IsNot "" And valid) Then
            If (DocumentoCompras(TxtFolio.Text, documento, CmbProv.SelectedValue, TxtPlazo.Text, TxtUsuario.Text, TxtComentarios.Text, CDec(TxtSubTot.Text), CDec(TxtImpTot.Text), CDec(TxtTot.Text), ds)) Then
                MessageBox.Show("se ha creado el documento de compras exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("Favor de llenar la informacion necesaria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class