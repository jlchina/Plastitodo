Public Class Reportes
    Dim enviartipo As String = Nothing
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Inv_Click(sender As Object, e As EventArgs) Handles Btn_Inv.Click
        enviartipo = "inventario"

        Dim mostrarform As New Rep_Grid()
        mostrarform.Obt_Tipo_Reporte(enviartipo)  'envia el tipo de reporte seleccionado
        mostrarform.Show()
    End Sub

    Private Sub Btn_Vtas_Click(sender As Object, e As EventArgs) Handles Btn_Vtas.Click
        enviartipo = "ventas"

        Dim mostrarform As New Rep_Grid()
        mostrarform.Obt_Tipo_Reporte(enviartipo)  'envia el tipo de reporte seleccionado
        mostrarform.Show()
    End Sub

    Private Sub Btn_Hist_Cto_Click(sender As Object, e As EventArgs) Handles Btn_Hist_Cto.Click
        enviartipo = "historico_c"

        Dim mostrarform As New Rep_Grid()
        mostrarform.Obt_Tipo_Reporte(enviartipo)  'envia el tipo de reporte seleccionado
        mostrarform.Show()
    End Sub

    Private Sub Btn_PrecVta_Click(sender As Object, e As EventArgs) Handles Btn_PrecVta.Click
        enviartipo = "historico_v"

        Dim mostrarform As New Rep_Grid()
        mostrarform.Obt_Tipo_Reporte(enviartipo)  'envia el tipo de reporte seleccionado
        mostrarform.Show()
    End Sub
End Class