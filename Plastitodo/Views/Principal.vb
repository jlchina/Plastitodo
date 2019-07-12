Imports Plastitodo.Globales
Imports Plastitodo.PrincipalMod
Public Class Principal


    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Clientes.Show()
        Dim newDichild As New Clientes()
        newDichild.MdiParent = Me
        newDichild.Show()

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        Dim Modulos = Permisos(Id_perfil)

        For Each item As Integer In Modulos
            Select Case item
                Case 1 'Modulo de usuarios
                    UsuariosToolStripMenuItem.Enabled = True
                Case 2 'Modulo de perfiles
                    PerfilesToolStripMenuItem.Enabled = True
                Case 3 'Modulo de clientes
                    ClientesToolStripMenuItem.Enabled = True
                Case 4 'Modulo de proveedores
                    ProveedoresToolStripMenuItem.Enabled = True
                Case 5 'Modulos de productos
                    ProductosToolStripMenuItem.Enabled = True
                Case 6 'Modulos de inventarios
                    InventariosToolStripMenuItem.Enabled = True
            End Select
        Next

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newCatProd As New Catprod()
        newCatProd.MdiParent = Me
        newCatProd.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim newUsuariosForm As New UsuariosForm()
        newUsuariosForm.MdiParent = Me
        newUsuariosForm.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            '--------->Mensaje para confirmar salir del sistema
            'Dim Msg As String
            Dim Title As String
            Dim Style As MsgBoxStyle
            Dim Response As MsgBoxResult
            'Msg = "Cerrar Sesión"
            Style = MsgBoxStyle.YesNo
            Title = "Mensaje Sistema"

            Response = MsgBox("Cerrar Conexion", Style, "Error")

            If Response = MsgBoxResult.Yes Then
                Application.Exit()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
