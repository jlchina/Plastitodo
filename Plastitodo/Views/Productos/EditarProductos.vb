Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class EditarProductos
    Dim id_prod As Integer
    Public Sub obtprod(ByVal IdP As String)
        'Para obtener datos del formulario de productos y póder realizar modificación
        id_prod = IdP
    End Sub
    Private Sub EditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select * From catalogo_productos where id = @id_Prod"

        If (id_prod) Then
            Me.Text = "Editar Producto - ID: " & id_prod.ToString
        End If

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comm = New MySqlCommand(consulta, con_string)
            comm.Parameters.Add(New MySqlParameter("@id_Prod", id_prod))
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)
            con_string.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim DataRow As DataRow = dt.NewRow()
            Txt_CodBar.Text = dr(1)
            Cbo_Marca.SelectedItem = dr(2)
            Txt_Modelo.Text = dr(3)
            Txt_Desc.Text = dr(4)
            Cbo_GpoProd.SelectedItem = dr(5)
            Cbo_Pres.SelectedItem = dr(6)
            Txt_Cto.Text = dr(7)
        Next

    End Sub
End Class