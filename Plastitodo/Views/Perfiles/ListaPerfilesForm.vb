Imports Plastitodo.Globales
Imports Plastitodo.PerfilesMod
Public Class ListaPerfilesForm
    'Ultima actualizacion 20/07/2019 alejandro
    'Pantalla inicial
    Private Sub ListaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = GetPerfiles()
        Dim DataTable As New DataTable()

        'Declarar columnas para data gridview
        DataTable.Columns.Add("ID", GetType(Int32)) '1
        DataTable.Columns.Add("NOMBRE", GetType(String)) '2
        DataTable.Columns.Add("DESCRIPCION", GetType(String)) '3

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim DataRow As DataRow = DataTable.NewRow()
            DataRow("ID") = dr(0)
            DataRow("NOMBRE") = dr(1)
            DataRow("DESCRIPCION") = dr(2)

            DataTable.Rows.Add(DataRow)
        Next

        '--------->Agregar botón Ver
        Dim Editar As New DataGridViewButtonColumn()
        Editar.UseColumnTextForButtonValue = True
        Editar.Text = "Editar"
        Editar.Name = "Editar"          'Agregar nombre a columna
        Editar.HeaderText = "Acciones"
        Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If DgvPerfiles.ColumnCount < 4 Then  'Condición para no desplegar otra columna
            DgvPerfiles.Columns.Add(Editar)
        End If

        DgvPerfiles.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '--------->Configurar aspectos visuales
        DgvPerfiles.BackgroundColor = Color.AliceBlue
        DgvPerfiles.AllowUserToAddRows = False
        DgvPerfiles.ReadOnly = True       'El control DataGridView será de sólo lectura
    End Sub

    Private Sub DgvPerfiles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPerfiles.CellClick
        If e.ColumnIndex <> 0 Then Exit Sub
        'Dim con2 As Integer = 0
        Try
            If DgvPerfiles.Columns(e.ColumnIndex).Name = "Editar" Then
                '--------->Campos enviar a formulario
                Dim id_perfil As String
                id_perfil = DgvPerfiles.Rows(e.RowIndex).Cells("ID").Value
                '--------->Instrucción abrir formulario y enviar datos de tabla
                Dim VerForm As New EditarPerfilesForm()
                VerForm.GetData(id_perfil)
                VerForm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim VerForm As New EditarPerfilesForm()

        VerForm.Show()
    End Sub
End Class