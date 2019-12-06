Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class CuentasCobrar

    Dim miDataTable2 As New DataTable
    Dim miDatatableAbono As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globales.text = TextBoxCliente.Text

        'Dim newbusquedacliente As New BusquedaCliente()
        'newbusquedacliente.MdiParent = Me
        'newbusquedacliente.ShowDialog()


        Dim newbusquedacliente As New BisquedaCliente3()
        newbusquedacliente.ShowDialog()
        TextBoxRazonSocial.Text = BisquedaCliente3.RazonSocial
        TextBoxEmail.Text = BisquedaCliente3.email
        TextBoxRfc.Text = BisquedaCliente3.rfc
        TextBoxTelefono.Text = BisquedaCliente3.telefono
    End Sub

    Private Sub listametodopago()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()

        Dim consulta As String
        consulta = "select * from metodo_pago"
        Dim adaptador = New MySqlDataAdapter(consulta, conexion)
        Dim datos = New DataSet
        datos.Tables.Add("metodo_pago")
        adaptador.Fill(datos.Tables("metodo_pago"))
        ComboBoxmetodopago.DataSource = datos.Tables("metodo_pago")
        ComboBoxmetodopago.DisplayMember = "metodo"
        conexion.Close()

    End Sub

    Private Sub CuentasCobrar_load(sender As Object, e As EventArgs) Handles MyBase.Load
        listametodopago()

        miDataTable2.Columns.Add("clave")
        miDataTable2.Columns.Add("metodo")

    End Sub

    Private Sub Txtmonto_TextChanged(sender As Object, e As EventArgs) Handles TxtAnticipo.TextChanged

        Dim total, anticipo, monto As Decimal
        If String.IsNullOrWhiteSpace(TxtSaldoTotal.Text) Then
            total = 0
        Else
            total = Convert.ToDecimal(TxtSaldoTotal.Text)
        End If

        If String.IsNullOrWhiteSpace(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrWhiteSpace(TxtAnticipo.Text) Then
            anticipo = 0
        Else
            anticipo = Convert.ToDecimal(TxtAnticipo.Text)
        End If

        total = monto - anticipo
        TxtSaldoTotal.Text = total

    End Sub

    Private Sub TxtAnticipo_TextChanged(sender As Object, e As EventArgs)
        Dim total, monto, anticipo As Decimal
        If String.IsNullOrWhiteSpace(TxtSaldoTotal.Text) Then
            total = 0
        Else
            total = Convert.ToDecimal(TxtSaldoTotal.Text)
        End If

        If String.IsNullOrWhiteSpace(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrWhiteSpace(TxtAnticipo.Text) Then
            anticipo = 0
        Else
            anticipo = Convert.ToDecimal(TxtAnticipo.Text)
        End If

        total = monto - anticipo
        TxtSaldoTotal.Text = total
    End Sub

    Private Sub TxtSaldoAnterior_TextChanged(sender As Object, e As EventArgs)
        Dim total, monto, anticipo As Decimal

        If String.IsNullOrWhiteSpace(TxtSaldoTotal.Text) Then
            total = 0
        Else
            total = Convert.ToDecimal(TxtSaldoTotal.Text)
        End If

        If String.IsNullOrWhiteSpace(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrWhiteSpace(TxtAnticipo.Text) Then
            anticipo = 0
        Else
            anticipo = Convert.ToDecimal(TxtAnticipo.Text)
        End If

        total = monto - anticipo
        TxtSaldoTotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim consulta As New StringBuilder

            consulta.Clear()
            consulta.AppendLine("insert into cuenta_cobrar (rfc,monto,anticipo,No_factura,saldo_total,metodo_pago,plazo)")
            consulta.AppendLine($"values ('{TextBoxRfc.Text}','{Txtmonto.Text}',")
            consulta.AppendLine($"'{TxtAnticipo.Text}','{txtNotaFactura.Text}','{TxtSaldoTotal.Text}','{ComboBoxmetodopago.Text}','{TxtPlazo.Text}')")
            Dim COMANDO As New MySqlCommand(consulta.ToString(), conexion)

            conexion.Open()
            COMANDO.ExecuteNonQuery()
            conexion.Close()

            Dim consulta2 As New StringBuilder
            consulta2.Clear()
            consulta2.AppendLine("insert into abonos (No_factura, rfc, metodo_pago, saldo_final)")
            consulta2.AppendLine($"values ('{txtNotaFactura.Text}','{TextBoxRfc.Text}','{ComboBoxmetodopago.Text}','{TxtSaldoTotal.Text}')")
            Dim comando2 As New MySqlCommand(consulta2.ToString(), conexion)
            conexion.Open()
            comando2.ExecuteNonQuery()
            conexion.Close()




            MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ButtonBuscarFactura_Click(sender As Object, e As EventArgs) Handles ButtonBuscarFactura.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "select a.fecha_abono, Nombre, telefono, email, a.rfc, razon_social, a.saldo_final, a.saldo_anterior, a.abono from cliente c join abonos a on  c.rfc = a.rfc where a.No_factura = ? order by a.fecha_abono desc "
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", TxtNofacturaAbono.Text)

            Dim dt As New DataTable

            adap.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridViewabonos.DataSource = dt
                TxtSaldoFinalAbono.Text = dt.Rows(0).Item(6).ToString()
                TxtNombreAbono.Text = dt.Rows(0).Item(1).ToString()
                TxtTelefonoAbono.Text = dt.Rows(0).Item(2).ToString()
                TxtEmailAbono.Text = dt.Rows(0).Item(3).ToString()
                TxtRfcAbono.Text = dt.Rows(0).Item(4).ToString()
                TxtAbonoAbono.Text = dt.Rows(0).Item(8).ToString



                With DataGridViewabonos
                    DataGridViewabonos.Columns("Nombre").Visible = False
                    DataGridViewabonos.Columns("telefono").Visible = False
                    DataGridViewabonos.Columns("email").Visible = False
                    DataGridViewabonos.Columns("rfc").Visible = False
                    DataGridViewabonos.Columns("razon_social").Visible = False
                End With
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If

            conexion.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datagridviewabonos_sizechanged(sender As Object, e As System.EventArgs) Handles DataGridViewabonos.SizeChanged
        With DataGridViewabonos
            For Each columna As DataGridViewColumn In .Columns
                columna.MinimumWidth = Int((.Width - .RowHeadersWidth) / .ColumnCount)
                columna.Width = Int((.Width - .RowHeadersWidth) / .ColumnCount)

            Next
        End With

    End Sub

    Private Sub ButtonGuardarAbono_Click(sender As Object, e As EventArgs)
        'Try
        '    Dim conexion As New MySqlConnection(ConnectionString2)


        '    Dim saldo As Decimal = Convert.ToDecimal(TxtSaldoFinalAbono.Text) - Convert.ToDecimal(TxtAbonoAbono.Text)


        '    Dim consulta As New StringBuilder
        '    consulta.Clear()
        '    consulta.AppendLine("insert into abonos (No_factura,abono,saldo_anterior,saldo_final, rfc, metodo_pago)")
        '    consulta.AppendLine($"values ('{TxtNofacturaAbono.Text}','{TxtAbonoAbono.Text}',")
        '    consulta.AppendLine($"'{TxtSaldoAnteriorabono.Text}','{saldo}','{TxtRfcAbono.Text}','{ComboBoxMetodoPagoAbono.Text}')")

        '    Dim COMANDO As New MySqlCommand(consulta.ToString(), conexion)

        '    conexion.Open()
        '    COMANDO.ExecuteNonQuery()
        '    conexion.Close()



        '    MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
    End Sub
    Private Sub listametodopagoabono()
        Dim conexion As New MySqlConnection(ConnectionString2)
        conexion.Open()

        Dim consulta As String
        consulta = "select * from metodo_pago"
        Dim adaptador = New MySqlDataAdapter(consulta, conexion)
        Dim datos = New DataSet
        datos.Tables.Add("metodo_pago")
        adaptador.Fill(datos.Tables("metodo_pago"))
        ComboBoxMetodoPagoAbono.DataSource = datos.Tables("metodo_pago")
        ComboBoxMetodoPagoAbono.DisplayMember = "metodo"
        conexion.Close()
    End Sub

    Private Sub CuentasCobrarAbono_load(sender As Object, e As EventArgs) Handles MyBase.Load
        listametodopagoabono()

        miDatatableAbono.Columns.Add("clave")
        miDatatableAbono.Columns.Add("metodo")

    End Sub

    Private Sub ButtonGuardarAbono_Click_1(sender As Object, e As EventArgs) Handles ButtonGuardarAbono.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)


            Dim saldo As Decimal = Convert.ToDecimal(TxtSaldoFinalAbono.Text) - Convert.ToDecimal(TxtAbonoAbono.Text)


            Dim consulta As New StringBuilder
            consulta.Clear()
            consulta.AppendLine("insert into abonos (No_factura, abono, saldo_anterior, saldo_final, rfc, metodo_pago)")
            consulta.AppendLine($"values ('{TxtNofacturaAbono.Text}','{TxtAbonoAbono.Text}',")
            consulta.AppendLine($"'{TxtSaldoFinalAbono}','{saldo}','{TxtRfcAbono.Text}','{ComboBoxMetodoPagoAbono.Text}')")

            Dim COMANDO As New MySqlCommand(consulta.ToString(), conexion)

            conexion.Open()
            COMANDO.ExecuteNonQuery()
            conexion.Close()



            MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class