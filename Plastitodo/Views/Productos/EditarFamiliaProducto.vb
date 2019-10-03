Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

'JLCS 29/07/2019
Public Class EditarFamiliaProducto
    Dim id_fam As Integer
    Public Sub obtfamp(ByVal IdFam As String)
        'Para obtener datos del formulario de productos y póder realizar modificación
        id_fam = IdFam
    End Sub
    Private Sub EditarFamiliaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "SELECT * FROM catalogacion_familias WHERE id_familia = @id_familia"

        If (id_fam) Then
            Me.Text = "Editar Familia de Producto - ID: " & id_fam.ToString
        End If

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            'iniciar comando para conexion y consulta a partir de los datos obtenidos del formulario de modificar catalogo
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_familia", id_fam))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)

            con_string.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de conexión no se pudieron importar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each dr As DataRow In ds.Tables(0).Rows
            Lbl_ID.Text = dr(0)
            Txt_NombreFamilia.Text = dr(1)
            Txt_Descripcion.Text = dr(2)
        Next

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim actualizar As String = "UPDATE catalogacion_familias SET nom_familia = @nomfam, descripcion_fam = @descripcion WHERE id_familia = " & Lbl_ID.Text
        Dim verif As Boolean

        If (Txt_NombreFamilia.Text IsNot "" And Txt_Descripcion.Text IsNot "") Then
            verif = True
        Else
            verif = False
        End If

        If verif = False Then
            Try
                'Abir conexion
                con_string = New MySqlConnection
                con_string.ConnectionString = ConnectionString2
                con_string.Open()
                'Iniciar comando de conexion
                cmd = New MySqlCommand(actualizar, con_string)
                'Pasar parametros
                cmd.Parameters.Add(New MySqlParameter("@nomfam", Txt_NombreFamilia.Text))
                cmd.Parameters.Add(New MySqlParameter("@descripcion", Txt_Descripcion.Text))
                'enviar nuevos datos a la tabla
                cmd.ExecuteNonQuery()
                con_string.Close()

                MsgBox("Registro actualizado")
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("No se han llenado todos los campos, verifique la información")
        End If

    End Sub
End Class