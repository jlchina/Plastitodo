Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class AltaMarca
    Private Sub AltaMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_agregar.Enabled = False
    End Sub

    Private Sub Txt_marca_LostFocus(sender As Object, e As EventArgs) Handles Txt_marca.LostFocus
        If Txt_marca.Text <> "" Then
            Btn_agregar.Enabled = True
        Else
            Btn_agregar.Enabled = False
        End If
    End Sub

    Private Sub Txt_marca_ModifiedChanged(sender As Object, e As EventArgs) Handles Txt_marca.ModifiedChanged
        If Txt_marca.Text <> "" Then
            Btn_agregar.Enabled = True
        Else
            Btn_agregar.Enabled = False
        End If
    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles Btn_agregar.Click
        'abrir conexion
        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()

        If Txt_marca.Text <> "" Then
            Try
                'especifica la tabla y los campos donde se ha de agregar informacion
                comando = New MySqlCommand("INSERT INTO marcas (marca)" & Chr(13) &
                                       "VALUES(@marca)", con_string)    'indica a que valor hara referencia la consulta para transferir los datos

                comando.Parameters.AddWithValue("@marca", Txt_marca.Text)
                comando.ExecuteNonQuery()   'ejecuta la consulta para guardar el registro en la tabla
                MsgBox("Nueva marca guardada con exito")

                con_string.Close()

                Txt_marca.Text = String.Empty
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MsgBox("Por favor ingrese el nombre de la marca primero")
        End If
    End Sub
End Class