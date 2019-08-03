Imports Plastitodo.conexion
Imports MySql.Data.MySqlClient
'JLCS 31/07/2019
Public Class EditarGpoProd
    Dim id_GP As Integer
    Dim id_cat As Integer = Nothing
    Dim id_fam As Integer = Nothing 'para guardar el parametro en la actualizacion

    Public Sub Obtener_IdGP(ByVal IdGpoProd As String)
        'obtiene datos del formulario consulta de Alta_fam_prod     //JLCS 31-07-19
        id_GP = IdGpoProd
    End Sub
    Private Sub EditarGpoProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select * From catalogacion where id = @id_GP"

        'Cambia el nombre al formulario
        If (id_GP) Then
            Me.Text = "Editar Grupo de Productos - ID: " & id_GP.ToString
        End If


        'llenar el combobox para llenar la familia de producto
        Dim cons_altagpo As String = Nothing
        Dim datat As New DataTable
        Dim datad As MySqlDataAdapter
        Try
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            cons_altagpo = "SELECT * FROM catalogacion_familias"
            datad = New MySqlDataAdapter(cons_altagpo, con_string)
            datat = New DataTable
            datad.Fill(datat)
            con_string.Close()
            Cbo_EFamprod.DataSource = datat
            Cbo_EFamprod.DisplayMember = "nom_familia"
            Cbo_EFamprod.ValueMember = "id_familia"
        Catch ex As Exception
            MsgBox("Se genero un error al cargar la consulta familias")
        End Try
        'realizar consulta para cargar valores del formulario de consulta en alta grupo de producto
        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_GP", id_GP))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)
            con_string.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each dr As DataRow In ds.Tables(0).Rows
            id_cat = dr(0)
            Lbl_GpoProd.Text = dr(1)
            Cbo_EFamprod.SelectedValue = dr(2)
            Txt_NomCat.Text = dr(4)
            id_fam = dr(2)
        Next
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Dim actualizar As String = "UPDATE catalogacion SET Id_familia = @Id_familia, Nom_categoria = @Nom_categoria WHERE id = " & id_cat
        Try
            'Abir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'Iniciar comando de conexion
            cmd = New MySqlCommand(actualizar, con_string)
            'Pasar parametros
            cmd.Parameters.Add(New MySqlParameter("@Id_familia", id_fam))
            cmd.Parameters.Add(New MySqlParameter("@Nom_categoria", Txt_NomCat.Text))
            'enviar nuevos datos a la tabla
            cmd.ExecuteNonQuery()
            con_string.Close()

            MsgBox("Registro actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo actualizar el registro", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cbo_EFamprod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_EFamprod.SelectedIndexChanged
        If IsNumeric(Cbo_EFamprod.SelectedValue) Then
            id_fam = Cbo_EFamprod.SelectedValue
        Else
            id_fam = Nothing
        End If
    End Sub
End Class