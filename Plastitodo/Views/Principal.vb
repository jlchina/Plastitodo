Public Class Principal


    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        'Clientes.Show()
        Dim newDichild As New Clientes()
        newDichild.MdiParent = Me
        newDichild.Show()

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim newCatProd As New Catprod()
        newCatProd.MdiParent = Me
        newCatProd.Show()
    End Sub
End Class
