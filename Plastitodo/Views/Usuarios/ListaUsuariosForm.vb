Public Class ListaUsuariosForm
    Private Sub ListaUsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = GetUsuarios()
        Dim DataTable As New DataTable()

        'Declarar columnas para data gridview
        DataTable.Columns.Add("ID", GetType(Int32)) '1
        DataTable.Columns.Add("USUARIO", GetType(String)) '2
        DataTable.Columns.Add("NOMBRE", GetType(String)) '3
        DataTable.Columns.Add("PERFIL", GetType(String)) '4

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim DataRow As DataRow = DataTable.NewRow()
            DataRow("ID") = dr(0)
            DataRow("USUARIO") = dr(1)
            DataRow("NOMBRE") = dr(2)
            DataRow("PERFIL") = dr(3)

            DataTable.Rows.Add(DataRow)
        Next

        '--------->Agregar botón Ver
        Dim Editar As New DataGridViewButtonColumn()
        Editar.UseColumnTextForButtonValue = True
        Editar.Text = "Editar"
        Editar.Name = "Editar"          'Agregar nombre a columna
        Editar.HeaderText = "Acciones"
        Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If DgvUsuarios.ColumnCount < 5 Then  'Condición para no desplegar otra columna
            DgvUsuarios.Columns.Add(Editar)
        End If

        DgvUsuarios.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '--------->Configurar aspectos visuales
        DgvUsuarios.BackgroundColor = Color.AliceBlue
        DgvUsuarios.AllowUserToAddRows = False
        DgvUsuarios.ReadOnly = True       'El control DataGridView será de sólo lectura
    End Sub
End Class