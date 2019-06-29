Public Class Principal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnconect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconect.Click
        connection()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()

    End Sub
End Class
