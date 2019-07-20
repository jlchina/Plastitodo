Imports Plastitodo.Globales
Imports Plastitodo.PerfilesMod
Public Class EditarPerfilesForm
    Dim id_perfil As Integer

    Public Sub GetData(ByVal Id As String)
        '--------->Establecer valores obtenidos del GridViewForm id_perfil
        id_perfil = Id
    End Sub

    Private Sub EditarPerfilesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (id_perfil) Then
            Me.Text = "Editar Perfil - ID: " & id_perfil.ToString
            Dim DataPerfil As DataSet = GetDatosPerfil(id_perfil)
            Dim DataModulosPerfiles As DataSet = GetDatosModulosPerfil(id_perfil)

            For Each dr As DataRow In DataPerfil.Tables(0).Rows
                TxtNombre.Text = dr(1)
                TxtDescripcion.Text = dr(2)
            Next

            Dim Fila As Integer = 0

            For Each dr As DataRow In DataModulosPerfiles.Tables(0).Rows
                DgvModulos.Rows.Add()
                DgvModulos.Rows(Fila).Cells(0).Value = dr(0)
                DgvModulos.Rows(Fila).Cells(1).Value = dr(1)
                Fila = Fila + 1
            Next
            DgvModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        Else
            Me.Text = "Nuevo Perfil"
        End If
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

            If (TxtNombre.Text <> "" And TxtDescripcion.Text <> "" And DgvModulos.Rows.Count > 0) Then
                If (id_perfil) Then
                    If (GuardarPerfil(id_perfil, TxtNombre.Text, TxtDescripcion.Text, ListaModulos.ToArray)) Then
                        Me.Hide()
                    End If
                Else
                    If (GuardarPerfil(Nothing, TxtNombre.Text, TxtDescripcion.Text, ListaModulos.ToArray)) Then
                        Me.Hide()
                    End If
                End If
            Else
                MsgBox("Favor de Llenar todos los campos", MsgBoxStyle.Exclamation, "Información")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        DgvModulos.Rows.Clear()
    End Sub
End Class