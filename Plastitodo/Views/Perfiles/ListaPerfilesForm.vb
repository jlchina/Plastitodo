Imports Plastitodo.Globales
Imports Plastitodo.PerfilesMod
Public Class ListaPerfilesForm
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

        DgvPerfiles.DataSource = DataTable
        '-----Determinamos el alto de las filas
        DgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        EditarPerfilesForm.Show()
    End Sub
End Class