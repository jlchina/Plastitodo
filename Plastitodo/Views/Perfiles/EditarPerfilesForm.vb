Imports Plastitodo.Globales
Imports Plastitodo.PerfilesMod
Public Class EditarPerfilesForm
    Dim UltimaFila As Integer
    Private Sub EditarPerfilesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltimaFila = 1000
        Dim ds As DataSet = GetModulos()

        CmbModulo.DisplayMember = "Seleccionar Modulo"
        CmbModulo.ValueMember = 0

        CmbModulo.DataSource = ds.Tables(0)
        CmbModulo.DisplayMember = "nombre"
        CmbModulo.ValueMember = "id"
        CmbModulo.SelectedIndex = 0

    End Sub

    Private Sub BtnAgregarModulo_Click(sender As Object, e As EventArgs) Handles BtnAgregarModulo.Click
        If (CmbModulo.Text <> "") Then
            DgvModulos.Rows.Add()
            LlenarLista(DgvModulos.Rows.Count, CmbModulo.SelectedValue, CmbModulo.Text)

        End If
    End Sub

    Private Sub LlenarLista(ByVal Fila As Integer, id As Integer, descripcion As String)
        Try
            'If Fila = 1000 Then
            'UltimaFila = 0
            'Fila = UltimaFila
            'Else
            'Fila = UltimaFila + 1
            'UltimaFila = Fila
            'End If

            DgvModulos.Rows(Fila - 1).Cells(0).Value = id
            DgvModulos.Rows(Fila - 1).Cells(1).Value = descripcion
            DgvModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ListaModulos As New List(Of Integer)()

            For Each Dt_Row As DataGridViewRow In DgvModulos.Rows
                ListaModulos.Add(Dt_Row.Cells("ID").Value)
            Next

            If (InsertPerfil(TxtNombre.Text, TxtDescripcion.Text, ListaModulos.ToArray)) Then
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class