Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion
Public Class Alta_fam_prod

    Function consulta_familia()
        Dim d_s As DataSet = New DataSet
        Dim d_table As New DataTable()
        Dim d_a As MySqlDataAdapter
        Dim comando As MySqlCommand
        Dim consulta2 = "select * From catalogacion_familias"
        'JLCS 29-07-2019
        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comando = New MySqlCommand(consulta2, con_string)
            d_a = New MySqlDataAdapter(comando)
            d_a.Fill(d_s)

            con_string.Close()

            'Declarar columnas para datagrid
            d_table.Columns.Add("id_familia", GetType(Int32)) '1
            d_table.Columns.Add("nom_familia", GetType(String)) '2
            d_table.Columns.Add("descripcion_fam", GetType(String)) '3

            For Each d_r As DataRow In d_s.Tables(0).Rows
                Dim DataRow As DataRow = d_table.NewRow()
                DataRow("id_familia") = d_r(0)
                DataRow("nom_familia") = d_r(1)
                DataRow("descripcion_fam") = d_r(2)

                d_table.Rows.Add(DataRow)

                'Agregar botón Editar
                Dim Editar As New DataGridViewButtonColumn()
                Editar.UseColumnTextForButtonValue = True
                Editar.Text = "Editar"
                Editar.Name = "Editar"          'Agregar nombre a columna
                Editar.HeaderText = "Acciones"
                Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                If Dgv_FamiliaProducto.ColumnCount < 4 Then  'Condición para no desplegar otra columna
                    Dgv_FamiliaProducto.Columns.Add(Editar)
                End If

                Dgv_FamiliaProducto.DataSource = d_table
                '-----Determinamos el alto de las filas
                Dgv_FamiliaProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                Dgv_FamiliaProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '--------->Configurar aspectos visuales
                Dgv_FamiliaProducto.BackgroundColor = Color.AliceBlue
                Dgv_FamiliaProducto.AllowUserToAddRows = False
                Dgv_FamiliaProducto.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return d_s
    End Function

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        con_string = New MySqlConnection
        con_string.ConnectionString = ConnectionString2
        con_string.Open()
        Try
            comando = New MySqlCommand("INSERT INTO catalogacion_familias(nom_familia, descripcion_fam)" & Chr(13) &
                                       "VALUES(@nom_familia,@descripcion_fam)", con_string)
            comando.Parameters.AddWithValue("@nom_familia", txt_nomfam.Text)
            comando.Parameters.AddWithValue("@descripcion_fam", txt_descfam.Text)
            comando.ExecuteNonQuery()
            MsgBox("Nueva familia de productos guardada con exito")
            txt_nomfam.Text = String.Empty
            txt_descfam.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, "Hubo un error al guardar, verifique los datos")
            txt_nomfam.Text = String.Empty
            txt_descfam.Text = String.Empty
        End Try
        con_string.Close()
    End Sub


    Private Sub txt_nomfam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nomfam.KeyPress
        onlyletters(e)
    End Sub

    Private Sub txt_descfam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descfam.KeyPress
        onlyletters(e)
    End Sub

    Private Sub Alta_fam_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta_familia()
    End Sub

    Private Sub Dgv_FamiliaProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_FamiliaProducto.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Try
            If Dgv_FamiliaProducto.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id_famprod As String
                'para enviar informacion al formulario
                id_famprod = Dgv_FamiliaProducto.Rows(e.RowIndex).Cells("id_familia").Value
                'envia datos al formulario
                Dim mostrarform As New EditarFamiliaProducto()
                mostrarform.obtfamp(id_famprod)  'envia el ID de la marca seleccionada
                mostrarform.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        consulta_familia()
    End Sub
End Class