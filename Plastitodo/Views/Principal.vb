Imports Plastitodo.Globales
Imports Plastitodo.PrincipalMod
Imports System
Public Class Principal
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

        lbl_time.Text = DateTime.Now.ToShortTimeString

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newCatProd As New Cons_prod()
        newCatProd.MdiParent = Me
        newCatProd.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim newUsuariosForm As New EditarUsuariosForm()
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
                End
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Principal_FormClosing(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Desea Cerrar y Guardar los Cambios Efectuados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If e.CloseReason = CloseReason.UserClosing Then
            If dlgRes = Windows.Forms.DialogResult.Yes Then
                Me.Dispose()
            End If

            If dlgRes = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click
        Dim newListaForm As New ListaPerfilesForm()
        newListaForm.MdiParent = Me
        newListaForm.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim newProveedor As New CatalogoProveedor()
        newProveedor.MdiParent = Me
        newProveedor.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim newConsulta As New Cons_prod()
        newConsulta.MdiParent = Me
        newConsulta.Show()
    End Sub

    Private Sub AltaYoEditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaYoEditarToolStripMenuItem.Click
        Dim newCatProd As New ModCatprod()
        newCatProd.MdiParent = Me
        newCatProd.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim newListaUsuarios As New ListaUsuariosForm()
        newListaUsuarios.MdiParent = Me
        newListaUsuarios.Show()
    End Sub

    Private Sub CrearFamiliaDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearFamiliaDeProductoToolStripMenuItem.Click
        Dim newfamilia As New Alta_fam_prod()
        newfamilia.MdiParent = Me
        newfamilia.Show()
    End Sub

    Private Sub CrearGrupoDeProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearGrupoDeProductoToolStripMenuItem.Click
        Dim newgrupo As New AltaGpoProd()
        newgrupo.MdiParent = Me
        newgrupo.Show()
    End Sub

    Private Sub MarcaCrearOModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaCrearOModificarToolStripMenuItem.Click
        Dim newmarca As New MarcaCons()
        newmarca.MdiParent = Me
        newmarca.Show()
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciasToolStripMenuItem.Click
        Dim newBusExis As New Existencias()
        newBusExis.MdiParent = Me
        newBusExis.Show()
    End Sub

    Private Sub EntradasMercanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasMercanciaToolStripMenuItem.Click
        Dim newEntraMerca As New EntradasMerca()
        newEntraMerca.MdiParent = Me
        newEntraMerca.Show()
    End Sub

    Private Sub EditarEliminarMercanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEliminarMercanciaToolStripMenuItem.Click
        Dim newEdiMerca As New Editar_Mercancia()
        newEdiMerca.MdiParent = Me
        newEdiMerca.Show()
    End Sub

    Private Sub OfertaDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfertaDeVentaToolStripMenuItem.Click
        Dim newForm As New OfertaVentaForm()
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub PresentaciónDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónDeProductosToolStripMenuItem.Click
        Dim newpresprod As New Presentacion_Prod()
        newpresprod.MdiParent = Me
        newpresprod.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim newForm As New Cat_Clientes()
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
End Class
