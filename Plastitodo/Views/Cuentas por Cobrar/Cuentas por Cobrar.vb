Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.Globales
Imports Plastitodo.conexion

Public Class CuentasCobrar

    Dim miDataTable2 As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globales.text = TextBoxCliente.Text

        'Dim newbusquedacliente As New BusquedaCliente()
        'newbusquedacliente.MdiParent = Me
        'newbusquedacliente.ShowDialog()

        Dim newbusquedacliente As New BusquedaCliente()
        newbusquedacliente.ShowDialog()
        TextBoxRazonSocial.Text = BusquedaCliente.RazonSocial
        TextBoxEmail.Text = BusquedaCliente.email
        TextBoxRfc.Text = BusquedaCliente.rfc
        TextBoxTelefono.Text = BusquedaCliente.telefono
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtmonto.TextChanged

        Dim total, saldoanterior, monto, abono As Decimal
        If String.IsNullOrEmpty(TxtSaldoAnterior.Text) Then
            saldoanterior = 0
        Else
            saldoanterior = Convert.ToDecimal(TxtSaldoAnterior.Text)
        End If

        If String.IsNullOrEmpty(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrEmpty(TxtAbono.Text) Then
            abono = 0
        Else
            abono = Convert.ToDecimal(TxtAbono.Text)
        End If

        total = (saldoanterior + monto) - abono
        TxtSaldoTotal.Text = total
        ' TxtSaldoTotal.Text = (TxtSaldoAnterior.Text + Txtmonto.Text) - TxtAbono.Text
    End Sub

    Private Sub TxtAbono_TextChanged(sender As Object, e As EventArgs)
        Dim total, saldoanterior, monto, anticipo, abono As Decimal
        If String.IsNullOrEmpty(TxtAnticipo.Text) Then
            saldoanterior = 0
        Else
            saldoanterior = Convert.ToDecimal(TxtAnticipo.Text)
        End If

        If String.IsNullOrEmpty(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrEmpty(TxtAbono.Text) Then
            abono = 0
        Else
            abono = Convert.ToDecimal(TxtAbono.Text)
        End If

        total = anticipo + monto
        TxtSaldoTotal.Text = total
    End Sub

    Private Sub TxtSaldoAnterior_TextChanged(sender As Object, e As EventArgs)
        Dim total, saldoanterior, monto, anticipo, abono As Decimal
        If String.IsNullOrEmpty(TxtAnticipo.Text) Then
            saldoanterior = 0
        Else
            saldoanterior = Convert.ToDecimal(TxtAnticipo.Text)
        End If

        If String.IsNullOrEmpty(Txtmonto.Text) Then
            monto = 0
        Else
            monto = Convert.ToDecimal(Txtmonto.Text)
        End If
        If String.IsNullOrEmpty(TxtAbono.Text) Then
            abono = 0
        Else
            abono = Convert.ToDecimal(TxtAbono.Text)
        End If

        total = anticipo + monto
        TxtSaldoTotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)

            Dim consulta As New StringBuilder
            consulta.Clear()
            consulta.AppendLine("insert into cuenta_cobrar (rfc,monto,abono,No_factura,saldo_total,metodo_pago,plazo,anticipo)")
            consulta.AppendLine($"values ('{TextBoxRfc.Text}','{Txtmonto.Text}',")
            consulta.AppendLine($"'{ TxtAbono.Text}','{Txtnofactura.Text}','{TxtSaldoTotal.Text}','{ComboBoxmetodopago.Text}','{TxtPlazo.Text}')")

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