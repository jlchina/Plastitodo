Public Class Rep_Inv
    Dim idrep As String = Nothing   'para guardar el valor de referencia del tipo de reporte
    Dim loc_rep As String = Nothing 'almacena la localizacion del reporte para usarlo en el reporte
    Public Sub obt_reporte(ByVal Id_rep As String, ubicacion As String)
        idrep = Id_rep
        loc_rep = ubicacion
    End Sub
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cambia el nombre al formulario
        If (idrep <> "") Then
            Me.Text = "Reporte de: " & idrep.ToString
        End If
    End Sub
End Class