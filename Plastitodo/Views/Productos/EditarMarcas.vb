Imports Plastitodo.conexion
Imports MySql.Data.MySqlClient

Public Class EditarMarcas
    Dim id_marca As Integer
    Public Sub ObtenerDatos(ByVal IdM As String)
        'obtiene datos del formulario consulta de marcas     //JLCS 26-07-19
        id_marca = IdM
    End Sub

    Private Sub EditarMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select * From marcas where id = @id_Marca"

        If (id_marca) Then
            Me.Text = "Editar Marca - ID: " & id_marca.ToString
        End If

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_Marca", id_marca))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)
            con_string.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim DMarca As DataSet = GetDatosPerfil(id_marca)
        'Dim DataModulosPerfiles As DataSet = GetDatosModulosPerfil(id_marca)

        For Each dr As DataRow In ds.Tables(0).Rows
            lbl_IdM.Text = dr(0)
            Txt_marca.Text = dr(1)
        Next

    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'actualizar campo de marca en la BD JCLS 02/08/19
        Dim actualizar As String = "UPDATE marcas SET marca = @marca WHERE id = " & id_marca
        Try
            'Abir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(actualizar, con_string)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@marca", Txt_marca.Text))
            'enviar nuevos datos a la tabla
            cmd.ExecuteNonQuery()
            con_string.Close()

            MsgBox("Registro actualizado")
        Catch ex As Exception

        End Try
    End Sub
End Class