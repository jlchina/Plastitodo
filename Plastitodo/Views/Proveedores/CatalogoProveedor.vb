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
        Dim band As Boolean
        Dim cmd As MySqlCommand
        Dim val As Integer = Nothing

        Try
            'buscar duplicidad de registros 16-11-2019
            If Txt_rfc.Text <> "" Then
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()
                sql = "SELECT rfc FROM proveedor WHERE rfc ='" & Txt_rfc.Text & "'"
                da = New MySqlDataAdapter(sql, con_string)
                da.Fill(ds1)
                con_string.Close()
                For Each datar As DataRow In ds1.Tables(0).Rows
                    BusReg = datar(0)
                Next
                If BusReg = "" Then
                    val = 1
                Else
                    val = 0
                End If
            Else MessageBox.Show("Favor de ingresar el RFC")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

        If val > 0 Then
            band = False
        Else band = True
        End If

        If (Textnombre.Text IsNot "" And Textdire.Text IsNot "" And Textcol.Text IsNot "" And Textcuidad.Text IsNot "" And Textcp.Text IsNot "" And Texttel.Text IsNot "" And Textcorreo.Text IsNot "" And Textcontacto.Text IsNot "" And Textcontacto2.Text IsNot "" And Textcorreo.Text IsNot "" And Txt_rfc.Text IsNot "") Then
            band = True
        End If

        If band = False Then
            Try
                Dim email As String
                email = Textcorreo.Text
                If Len(email) > 0 Then
                    If (validar_mail(email) = True) Then

                        'Se inicializa la conexion a la BD 19-11-19
                        con_string = New MySqlConnection
                        con_string.ConnectionString = ConnectionString2
                        con_string.Open()
                        cmd = New MySqlCommand("INSERT INTO proveedor(Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, correo, contacto, contacto2, correo2, rfc)" & Chr(13) &
                                       "VALUES(@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @correo, @contacto, @contacto2, @correo2, @rfc)", con_string)

                        cmd.Parameters.AddWithValue("@Nombre", Textnombre.Text)
                        cmd.Parameters.AddWithValue("@Direccion", Textdire.Text)
                        cmd.Parameters.AddWithValue("@Colonia", Textcol.Text)
                        cmd.Parameters.AddWithValue("@Ciudad", Textcuidad.Text)
                        cmd.Parameters.AddWithValue("@Codigo_postal", Textcp.Text)
                        cmd.Parameters.AddWithValue("@telefono", Texttel.Text)
                        cmd.Parameters.AddWithValue("@correo", Textcorreo.Text)
                        cmd.Parameters.AddWithValue("@contacto", Textcontacto.Text)
                        cmd.Parameters.AddWithValue("@contacto2", Textcontacto2.Text)
                        cmd.Parameters.AddWithValue("@correo2", Textcorreo2.Text)
                        cmd.Parameters.AddWithValue("@rfc", Txt_rfc.Text)
                        cmd.ExecuteNonQuery()
                        con_string.Close()

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
        Else MessageBox.Show("El RFC ingresado ya existe o no se han llenado todos los datos, verifique la informacion")
        End If
        val = Nothing
        band = Nothing
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
        Textcorreo2.Text = String.Empty
        Textcontacto2.Text = String.Empty
        Txt_rfc.Text = String.Empty

    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        limpiar()
    End Sub


    Private Sub BConsultaProvee_Click(sender As Object, e As EventArgs)

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

    Private Sub BConsultaLimpi_Click(sender As Object, e As EventArgs)
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