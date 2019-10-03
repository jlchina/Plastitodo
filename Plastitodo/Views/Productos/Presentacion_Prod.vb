Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

'JLCS 29-07-19
Public Class Presentacion_Prod
    Function Cons_PP()
        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select * From presentacion_prod"

        Try
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()
            'iniciar comando para conexion y consulta
            comm = New MySqlCommand(consulta, con_string)
            da = New MySqlDataAdapter(comm)
            da.Fill(ds)

            con_string.Close()

            'Declarar columnas para datagrid
            datatable.Columns.Add("ID", GetType(Int32)) '1
            datatable.Columns.Add("Presentacion", GetType(String)) '2

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = datatable.NewRow()
                DataRow("ID") = dr(0)
                DataRow("Presentacion") = dr(1)

                datatable.Rows.Add(DataRow)

                'Agregar botón Editar
                Dim Editar As New DataGridViewButtonColumn()
                Editar.UseColumnTextForButtonValue = True
                Editar.Text = "Editar"
                Editar.Name = "Editar"          'Agregar nombre a columna
                Editar.HeaderText = "Acciones"
                Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                If Dgv_Presentacion.ColumnCount < 3 Then  'Condición para no desplegar otra columna
                    Dgv_Presentacion.Columns.Add(Editar)
                End If

                Dgv_Presentacion.DataSource = datatable
                '-----Determinamos el alto de las filas
                Dgv_Presentacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                Dgv_Presentacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '--------->Configurar aspectos visuales
                Dgv_Presentacion.BackgroundColor = Color.AliceBlue
                Dgv_Presentacion.AllowUserToAddRows = False
                Dgv_Presentacion.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function
    Private Sub Presentacion_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_Guardar.Enabled = False
        Cons_PP()
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Presentacion.Text IsNot "") Then
            MsgBox("No se han llenado todos los campos, verifique la información")
        Else
            'abrir conexion
            con_string = New MySqlConnection
            con_string.ConnectionString = ConnectionString2
            con_string.Open()

            Try
                'especifica la tabla y los campos donde se ha de agregar informacion
                comando = New MySqlCommand("INSERT INTO presentacion_prod (presentacion)" & Chr(13) &
                                           "VALUES(@presentacion)", con_string)    'indica a que valor hara referencia la consulta para transferir los datos

                comando.Parameters.AddWithValue("@presentacion", Txt_Presentacion.Text)
                comando.ExecuteNonQuery()   'ejecuta la consulta para guardar el registro en la tabla
                MsgBox("Nueva presentacion de productos guardada con exito")
                Txt_Presentacion.Text = String.Empty
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Txt_Presentacion_ModifiedChanged(sender As Object, e As EventArgs) Handles Txt_Presentacion.ModifiedChanged
        If Txt_Presentacion.Text <> "" Then
            Btn_Guardar.Enabled = True
        Else
            Btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Cons_PP()
    End Sub

    Private Sub Dgv_Presentacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Presentacion.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Try
            If Dgv_Presentacion.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id_PProd As String
                'para enviar informacion al formulario
                id_PProd = Dgv_Presentacion.Rows(e.RowIndex).Cells("ID").Value
                'envia datos al formulario
                Dim mostrarform As New EditarPresProd()
                mostrarform.obt_PresProd(id_PProd)  'envia el ID de la marca seleccionada
                mostrarform.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class