﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFamiliaDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearGrupoDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaYoEditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaCrearOModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusConexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lblconexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ModulosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(818, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.PerfilesToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Enabled = False
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.Enabled = False
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PerfilesToolStripMenuItem.Text = "Perfiles"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripMenuItem2.Text = "Salir"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.InventariosToolStripMenuItem})
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem2, Me.CrearToolStripMenuItem2})
        Me.ClientesToolStripMenuItem.Enabled = False
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ListaToolStripMenuItem2
        '
        Me.ListaToolStripMenuItem2.Enabled = False
        Me.ListaToolStripMenuItem2.Name = "ListaToolStripMenuItem2"
        Me.ListaToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.ListaToolStripMenuItem2.Text = "Lista"
        '
        'CrearToolStripMenuItem2
        '
        Me.CrearToolStripMenuItem2.Enabled = False
        Me.CrearToolStripMenuItem2.Name = "CrearToolStripMenuItem2"
        Me.CrearToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.CrearToolStripMenuItem2.Text = "Crear"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Enabled = False
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFamiliaDeProductoToolStripMenuItem, Me.CrearGrupoDeProductoToolStripMenuItem, Me.AltaYoEditarToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.MarcaCrearOModificarToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Enabled = False
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CrearFamiliaDeProductoToolStripMenuItem
        '
        Me.CrearFamiliaDeProductoToolStripMenuItem.Name = "CrearFamiliaDeProductoToolStripMenuItem"
        Me.CrearFamiliaDeProductoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CrearFamiliaDeProductoToolStripMenuItem.Text = "Crear familia de producto"
        '
        'CrearGrupoDeProductoToolStripMenuItem
        '
        Me.CrearGrupoDeProductoToolStripMenuItem.Name = "CrearGrupoDeProductoToolStripMenuItem"
        Me.CrearGrupoDeProductoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CrearGrupoDeProductoToolStripMenuItem.Text = "Crear grupo de producto"
        '
        'AltaYoEditarToolStripMenuItem
        '
        Me.AltaYoEditarToolStripMenuItem.Name = "AltaYoEditarToolStripMenuItem"
        Me.AltaYoEditarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AltaYoEditarToolStripMenuItem.Text = "Alta y/o editar producto"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta de productos"
        '
        'MarcaCrearOModificarToolStripMenuItem
        '
        Me.MarcaCrearOModificarToolStripMenuItem.Name = "MarcaCrearOModificarToolStripMenuItem"
        Me.MarcaCrearOModificarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MarcaCrearOModificarToolStripMenuItem.Text = "Marca crear o modificar"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.Enabled = False
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.InventariosToolStripMenuItem.Text = "Inventarios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusConexion, Me.Lblconexion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(818, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusConexion
        '
        Me.StatusConexion.Name = "StatusConexion"
        Me.StatusConexion.Size = New System.Drawing.Size(90, 17)
        Me.StatusConexion.Text = "Conexión a BD: "
        '
        'Lblconexion
        '
        Me.Lblconexion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Lblconexion.Name = "Lblconexion"
        Me.Lblconexion.Size = New System.Drawing.Size(107, 17)
        Me.Lblconexion.Text = "--------------------"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 425)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Plastibolsas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusConexion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Lblconexion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaYoEditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearFamiliaDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearGrupoDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaCrearOModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
