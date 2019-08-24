Module solo_num_let
    Public Sub solonumeros(ByRef numerico As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(numerico.KeyChar) Then
            numerico.Handled = False
        ElseIf Char.IsControl(numerico.KeyChar) Then
            numerico.Handled = False
        Else
            numerico.Handled = True
        End If

        'MsgBox(numerico.KeyChar.ToString)
    End Sub

    Public Sub onlyletters(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Module
