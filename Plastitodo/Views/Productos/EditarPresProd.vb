Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class EditarPresProd
    Dim id_PresProd

    Public Sub obt_PresProd(ByVal ID_Pre_Pro As String)
        id_PresProd = ID_Pre_Pro
    End Sub

    Private Sub EditarPresProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "SELECT * FROM presentacion_prod WHERE id_pp = @id_pp"

        If (id_PresProd) Then
            Me.Text = "Editar Presentacion del Producto - ID: " & id_PresProd.ToString
        End If

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            'iniciar comando para conexion y consulta a partir de los datos obtenidos del formulario de modificar catalogo
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_pp", id_PresProd))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)

            con_string.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de conexión no se pudieron importar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each dr As DataRow In ds.Tables(0).Rows
            Lbl_Id.Text = dr(0)
            Txt_NomPresP.Text = dr(1)
        Next
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Dim actualizar As String = "UPDATE presentacion_prod SET presentacion = @presentacion WHERE id_pp = " & Lbl_Id.Text

        Try
            'Abir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(actualizar, con_string)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@presentacion", Txt_NomPresP.Text))
            'enviar nuevos datos a la tabla
            cmd.ExecuteNonQuery()
            con_string.Close()

            MsgBox("Registro actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class