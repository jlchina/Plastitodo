Imports MySql.Data.MySqlClient

Public Class Cat_Clientes
    Private Sub Cat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    comando = New MySqlCommand("INSERT INTO cliente(idCliente, Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email)" & Chr(13) &
        '                               "VALUES(@idCliente,@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email)", con_string)
        '    comando.Parameters.AddWithValue("@idCliente", Text_id.Text)
        '    comando.Parameters.AddWithValue("@Nombre", Text_nomb.Text)
        '    comando.Parameters.AddWithValue("@Direccion", Text_dir.Text)
        '    comando.Parameters.AddWithValue("@Colonia", Text_col.Text)
        '    comando.Parameters.AddWithValue("@Ciudad", Text_cd.Text)
        '    comando.Parameters.AddWithValue("@Codigo_postal", Text_cp.Text)
        '    comando.Parameters.AddWithValue("@telefono", Text_tel.Text)
        '    comando.Parameters.AddWithValue("@email", Text_mail.Text)
        '    comando.ExecuteNonQuery()
        '    MsgBox("Cliente guardado con exito")
        'Catch ex As Exception
        '    MsgBox(ex.Message, "Hubo un error al guardar el Cliente, verifique los datos")
        'End Try
    End Sub

    Private Sub Btn_agregarc_Click(sender As Object, e As EventArgs) Handles Btn_agregarc.Click
        Try
            comando = New MySqlCommand("INSERT INTO cliente(idCliente, Nombre, Direccion, Colonia, Ciudad, Codigo_postal, telefono, email)" & Chr(13) &
                                       "VALUES(@idCliente,@Nombre, @Direccion, @Colonia, @Ciudad, @Codigo_postal, @telefono, @email)", con_string)
            comando.Parameters.AddWithValue("@idCliente", Text_id.Text)
            comando.Parameters.AddWithValue("@Nombre", Text_nomb.Text)
            comando.Parameters.AddWithValue("@Direccion", Text_dir.Text)
            comando.Parameters.AddWithValue("@Colonia", Text_col.Text)
            comando.Parameters.AddWithValue("@Ciudad", Text_cd.Text)
            comando.Parameters.AddWithValue("@Codigo_postal", Text_cp.Text)
            comando.Parameters.AddWithValue("@telefono", Text_tel.Text)
            comando.Parameters.AddWithValue("@email", Text_mail.Text)
            comando.ExecuteNonQuery()
            MsgBox("Cliente guardado con exito")
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar el Cliente, verifique los datos")
            limpiar()
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "Select * from cliente where Nombre like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & Textbusclient.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVconsultclient.DataSource = dt
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()

        Text_id.Text = String.Empty
        Text_nomb.Text = String.Empty
        Text_dir.Text = String.Empty
        Text_col.Text = String.Empty
        Text_cd.Text = String.Empty
        Text_cp.Text = String.Empty
        Text_tel.Text = String.Empty
        Text_mail.Text = String.Empty

    End Sub

    Private Sub Btn_cancelarp_Click(sender As Object, e As EventArgs) Handles Btn_cancelarp.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonbuscar.Click
        Try
            Dim conexion As New MySqlConnection(ConnectionString2)
            Dim query = "Select * from cliente where Nombre like ?"
            Dim adap As New MySqlDataAdapter(query, conexion)
            adap.SelectCommand.Parameters.AddWithValue("@p1", "%" & Textbusclient.Text & "%")
            Dim dt As New DataTable
            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVconsultclient.DataSource = dt
            Else
                MessageBox.Show("No se encontraron coincidencias")
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class