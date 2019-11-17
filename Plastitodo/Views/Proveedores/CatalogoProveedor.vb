Imports System.Text
Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Imports System.Text.RegularExpressions
Public Class CatalogoProveedor
    Private datos As DataSet

    Private Sub BAgregarprovee_Click(sender As Object, e As EventArgs) Handles BAgregarprovee.Click
        Dim ds1 As DataSet = New DataSet
        Dim sql As String
        Dim BusReg As String = Nothing
        Dim band As Integer = Nothing
        Try
            'buscar duplicidad de registros 16-11-2019
            If Txt_rfc.Text <> "" Then
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()
                sql = "SELECT rfc FROM catalogo_productos WHERE rfc =" & Txt_rfc.Text
                da = New MySqlDataAdapter(Sql, con_string)
                da.Fill(ds1)
                con_string.Close()
                For Each datar As DataRow In ds1.Tables(0).Rows
                    BusReg = datar(0)
                Next
                If BusReg <> "" Then
                    band = True
                Else
                    band = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

        'If (idmarca.ToString <= 0 And Txt_mod.Text IsNot "" And Txt_desc.Text IsNot "" And idpresp.ToString <= 0 And Txt_Cto.Text IsNot "" And idf.ToString <= 0 And idprov.ToString <= 0) Then
        '    Val = True
        'End If

        Try
            Dim email As String
            email = Textcorreo.Text
            If Len(email) > 0 Then
                If (validar_mail(email) = True) Then
                    Dim conexion As New MySqlConnection(ConnectionString2)

                    Dim CONSULTA As New StringBuilder
                    CONSULTA.Clear()
                    CONSULTA.AppendLine("insert into proveedor(Nombre, Direccion, Colonia,")
                    CONSULTA.AppendLine("Ciudad,Codigo_postal,telefono,correo, contacto)")
                    CONSULTA.AppendLine($"values ('{Textnombre.Text}',")
                    CONSULTA.AppendLine($"'{Textdire.Text}', '{Textcol.Text}','{Textcuidad.Text}',")
                    CONSULTA.AppendLine($"'{Textcp.Text}' , '{Texttel.Text}',")
                    CONSULTA.AppendLine($"'{Textcorreo.Text}','{Textcontacto.Text}')")

                    Dim COMANDO As New MySqlCommand(CONSULTA.ToString(), conexion)

                    conexion.Open()
                    COMANDO.ExecuteNonQuery()

                    conexion.Close()
                    MsgBox("DATOS GUARDADOS CORRECTAMENTE!!")
                    limpiar()
                Else
                    MessageBox.Show("Verificar Correo")
                End If
            Else
                MessageBox.Show("Favor de Ingresar un Correo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub limpiar()
        Textnombre.Text = String.Empty
        Textdire.Text = String.Empty
        Textcol.Text = String.Empty
        Textcuidad.Text = String.Empty
        Textcp.Text = String.Empty
        Texttel.Text = String.Empty
        Textcorreo.Text = String.Empty
        Textcontacto.Text = String.Empty
    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        limpiar()
    End Sub


    Private Sub BConsultaProvee_Click(sender As Object, e As EventArgs) Handles BConsultaProvee.Click

        Dim datatable As New DataTable()
        Dim dataset As DataSet = New DataSet

        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "Select * from proveedor where nombre  like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & TextBoxnombre.Text & "%")
            'Dim dt As New DataTable
            'adap.Fill(datatable)
            adap.Fill(dataset)
            conexion.Close()

            'Declarar columnas para data gridview
            datatable.Columns.Add("RFC", GetType(String)) '1
            datatable.Columns.Add("Nombre", GetType(String)) '2
            datatable.Columns.Add("Direccion", GetType(String)) '3
            datatable.Columns.Add("Colonia", GetType(String)) '4
            datatable.Columns.Add("Ciudad", GetType(String)) '5
            datatable.Columns.Add("Codigo postal", GetType(String)) '6
            datatable.Columns.Add("Telefono", GetType(String)) '7
            datatable.Columns.Add("Contacto 1", GetType(String)) '8
            datatable.Columns.Add("Email 1", GetType(String)) '9
            datatable.Columns.Add("Contacto 2", GetType(String)) '8
            datatable.Columns.Add("Email 2", GetType(String)) '9

            For Each dr As DataRow In dataset.Tables(0).Rows
                Dim DataRow As DataRow = datatable.NewRow()
                DataRow("RFC") = dr(11)
                DataRow("Nombre") = dr(1)
                DataRow("Direccion") = dr(2)
                DataRow("Colonia") = dr(3)
                DataRow("Ciudad") = dr(4)
                DataRow("Codigo postal") = dr(5)
                DataRow("Telefono") = dr(6)
                DataRow("Contacto 1") = dr(8)
                DataRow("Email 1") = dr(7)
                DataRow("Contacto 2") = dr(9)
                DataRow("Email 2") = dr(10)

                datatable.Rows.Add(DataRow)

                If DGV_Prov.ColumnCount < 11 Then  'Condición para no desplegar otra columna
                End If

                DGV_Prov.DataSource = datatable
                'Determinar el alto de las filas
                DGV_Prov.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DGV_Prov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                DGV_Prov.BackgroundColor = Color.AliceBlue
                DGV_Prov.AllowUserToAddRows = False
                DGV_Prov.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiarconsulta()
        TextBoxnombre.Text = String.Empty
        DGV_Prov.DataSource = String.Empty
    End Sub

    Private Sub BConsultaLimpi_Click(sender As Object, e As EventArgs) Handles BConsultaLimpi.Click
        limpiarconsulta()
    End Sub

    Private Sub Texttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texttel.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Textcp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textcp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
        'Static emailExpression As New Regex("/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/igm")

        'Return emailExpression.IsMatch(sMail)
    End Function

    Private Sub CatalogoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datatable As New DataTable()
        Dim dataset As DataSet = New DataSet

        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "Select * from proveedor"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.Fill(dataset)
            conexion.Close()

            'Declarar columnas para data gridview
            datatable.Columns.Add("RFC", GetType(String)) '1
            datatable.Columns.Add("Nombre", GetType(String)) '2
            datatable.Columns.Add("Direccion", GetType(String)) '3
            datatable.Columns.Add("Colonia", GetType(String)) '4
            datatable.Columns.Add("Ciudad", GetType(String)) '5
            datatable.Columns.Add("Codigo postal", GetType(String)) '6
            datatable.Columns.Add("Telefono", GetType(String)) '7
            datatable.Columns.Add("Contacto 1", GetType(String)) '8
            datatable.Columns.Add("Email 1", GetType(String)) '9
            datatable.Columns.Add("Contacto 2", GetType(String)) '8
            datatable.Columns.Add("Email 2", GetType(String)) '9

            For Each dr As DataRow In dataset.Tables(0).Rows
                Dim DataRow As DataRow = datatable.NewRow()
                DataRow("RFC") = dr(11)
                DataRow("Nombre") = dr(1)
                DataRow("Direccion") = dr(2)
                DataRow("Colonia") = dr(3)
                DataRow("Ciudad") = dr(4)
                DataRow("Codigo postal") = dr(5)
                DataRow("Telefono") = dr(6)
                DataRow("Contacto 1") = dr(8)
                DataRow("Email 1") = dr(7)
                DataRow("Contacto 2") = dr(9)
                DataRow("Email 2") = dr(10)

                datatable.Rows.Add(DataRow)

                If DGV_Prov.ColumnCount < 11 Then  'Condición para no desplegar otra columna
                End If

                DGV_Prov.DataSource = datatable
                'Determinar el alto de las filas
                DGV_Prov.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DGV_Prov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'Configurar aspectos visuales
                DGV_Prov.BackgroundColor = Color.AliceBlue
                DGV_Prov.AllowUserToAddRows = False
                DGV_Prov.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class