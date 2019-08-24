Imports MySql.Data.MySqlClient
Imports Plastitodo.conexion

Public Class MarcaCons

    Function Cons_Marcas()

        Dim ds As DataSet = New DataSet
        Dim datatable As New DataTable()
        Dim da As MySqlDataAdapter
        Dim comm As MySqlCommand
        Dim consulta = "select * From marcas"

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
            datatable.Columns.Add("Marca", GetType(String)) '2

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim DataRow As DataRow = datatable.NewRow()
                DataRow("ID") = dr(0)
                DataRow("marca") = dr(1)

                datatable.Rows.Add(DataRow)

                'Agregar botón Editar
                Dim Editar As New DataGridViewButtonColumn()
                Editar.UseColumnTextForButtonValue = True
                Editar.Text = "Editar"
                Editar.Name = "Editar"          'Agregar nombre a columna
                Editar.HeaderText = "Acciones"
                Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                If dgv_marcas.ColumnCount < 3 Then  'Condición para no desplegar otra columna
                    dgv_marcas.Columns.Add(Editar)
                End If

                dgv_marcas.DataSource = datatable
                '-----Determinamos el alto de las filas
                dgv_marcas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                dgv_marcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '--------->Configurar aspectos visuales
                dgv_marcas.BackgroundColor = Color.AliceBlue
                dgv_marcas.AllowUserToAddRows = False
                dgv_marcas.ReadOnly = True       'El control DataGridView será de sólo lectura

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("No se pudo conectar a la Base de Datos", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function
    Private Sub MarcaCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cons_Marcas()
    End Sub

    Private Sub Btn_nvamarca_Click(sender As Object, e As EventArgs) Handles btn_nvamarca.Click
        AltaMarca.Show()

        Me.Close()
    End Sub

    Private Sub dgv_marcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_marcas.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub

        Try
            If dgv_marcas.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id_marca As String
                'para enviar informacion al formulario
                id_marca = dgv_marcas.Rows(e.RowIndex).Cells("ID").Value
                'envia datos al formulario
                Dim mostrarform As New EditarMarcas()
                mostrarform.ObtenerDatos(id_marca)  'envia el ID de la marca seleccionada
                mostrarform.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Cons_Marcas()
    End Sub
End Class