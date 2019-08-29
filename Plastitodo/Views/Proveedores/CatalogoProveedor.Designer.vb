<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogoProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatalogoProveedor))
        Me.TabAltaprovee = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidpro = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Textdire = New System.Windows.Forms.TextBox()
        Me.Textcol = New System.Windows.Forms.TextBox()
        Me.Textcuidad = New System.Windows.Forms.TextBox()
        Me.Textcp = New System.Windows.Forms.TextBox()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textcorreo = New System.Windows.Forms.TextBox()
        Me.Textcontacto = New System.Windows.Forms.TextBox()
        Me.BAgregarprovee = New System.Windows.Forms.Button()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.TabCprovee = New System.Windows.Forms.TabControl()
        Me.LConsultacontaprovee = New System.Windows.Forms.Label()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.BConsultaProvee = New System.Windows.Forms.Button()
        Me.BConsultaLimpi = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabConsuProvee = New System.Windows.Forms.TabPage()
        Me.TabAltaprovee.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabCprovee.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsuProvee.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabAltaprovee
        '
        Me.TabAltaprovee.Controls.Add(Me.Blimpiar)
        Me.TabAltaprovee.Controls.Add(Me.BAgregarprovee)
        Me.TabAltaprovee.Controls.Add(Me.Panel1)
        Me.TabAltaprovee.Location = New System.Drawing.Point(4, 25)
        Me.TabAltaprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAltaprovee.Name = "TabAltaprovee"
        Me.TabAltaprovee.Padding = New System.Windows.Forms.Padding(4)
        Me.TabAltaprovee.Size = New System.Drawing.Size(976, 445)
        Me.TabAltaprovee.TabIndex = 1
        Me.TabAltaprovee.Text = "Alta Proveedor"
        Me.TabAltaprovee.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Textcontacto)
        Me.Panel1.Controls.Add(Me.Textcorreo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Texttel)
        Me.Panel1.Controls.Add(Me.Textcp)
        Me.Panel1.Controls.Add(Me.Textcuidad)
        Me.Panel1.Controls.Add(Me.Textcol)
        Me.Panel1.Controls.Add(Me.Textdire)
        Me.Panel1.Controls.Add(Me.Textnombre)
        Me.Panel1.Controls.Add(Me.txtidpro)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(4, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 405)
        Me.Panel1.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(38, 21)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "ID Proveedor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 65)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 108)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Direccion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 152)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Colonia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 195)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Cuidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 238)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "CP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 280)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Telefono:"
        '
        'txtidpro
        '
        Me.txtidpro.Location = New System.Drawing.Point(159, 18)
        Me.txtidpro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidpro.Name = "txtidpro"
        Me.txtidpro.Size = New System.Drawing.Size(90, 22)
        Me.txtidpro.TabIndex = 1
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(159, 62)
        Me.Textnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(496, 22)
        Me.Textnombre.TabIndex = 2
        '
        'Textdire
        '
        Me.Textdire.Location = New System.Drawing.Point(159, 105)
        Me.Textdire.Margin = New System.Windows.Forms.Padding(4)
        Me.Textdire.Name = "Textdire"
        Me.Textdire.Size = New System.Drawing.Size(496, 22)
        Me.Textdire.TabIndex = 3
        '
        'Textcol
        '
        Me.Textcol.Location = New System.Drawing.Point(159, 149)
        Me.Textcol.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcol.Name = "Textcol"
        Me.Textcol.Size = New System.Drawing.Size(496, 22)
        Me.Textcol.TabIndex = 4
        '
        'Textcuidad
        '
        Me.Textcuidad.Location = New System.Drawing.Point(159, 192)
        Me.Textcuidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcuidad.Name = "Textcuidad"
        Me.Textcuidad.Size = New System.Drawing.Size(168, 22)
        Me.Textcuidad.TabIndex = 5
        '
        'Textcp
        '
        Me.Textcp.Location = New System.Drawing.Point(159, 235)
        Me.Textcp.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcp.Name = "Textcp"
        Me.Textcp.Size = New System.Drawing.Size(168, 22)
        Me.Textcp.TabIndex = 6
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(159, 278)
        Me.Texttel.Margin = New System.Windows.Forms.Padding(4)
        Me.Texttel.Name = "Texttel"
        Me.Texttel.Size = New System.Drawing.Size(496, 22)
        Me.Texttel.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 323)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 366)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Contacto:"
        '
        'Textcorreo
        '
        Me.Textcorreo.Location = New System.Drawing.Point(159, 320)
        Me.Textcorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcorreo.Name = "Textcorreo"
        Me.Textcorreo.Size = New System.Drawing.Size(496, 22)
        Me.Textcorreo.TabIndex = 19
        '
        'Textcontacto
        '
        Me.Textcontacto.Location = New System.Drawing.Point(159, 361)
        Me.Textcontacto.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcontacto.Name = "Textcontacto"
        Me.Textcontacto.Size = New System.Drawing.Size(496, 22)
        Me.Textcontacto.TabIndex = 20
        '
        'BAgregarprovee
        '
        Me.BAgregarprovee.BackgroundImage = CType(resources.GetObject("BAgregarprovee.BackgroundImage"), System.Drawing.Image)
        Me.BAgregarprovee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAgregarprovee.Location = New System.Drawing.Point(852, 381)
        Me.BAgregarprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.BAgregarprovee.Name = "BAgregarprovee"
        Me.BAgregarprovee.Size = New System.Drawing.Size(57, 47)
        Me.BAgregarprovee.TabIndex = 1
        Me.BAgregarprovee.UseVisualStyleBackColor = True
        '
        'Blimpiar
        '
        Me.Blimpiar.BackgroundImage = CType(resources.GetObject("Blimpiar.BackgroundImage"), System.Drawing.Image)
        Me.Blimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Blimpiar.Location = New System.Drawing.Point(852, 20)
        Me.Blimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(57, 49)
        Me.Blimpiar.TabIndex = 35
        Me.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'TabCprovee
        '
        Me.TabCprovee.Controls.Add(Me.TabConsuProvee)
        Me.TabCprovee.Controls.Add(Me.TabAltaprovee)
        Me.TabCprovee.Location = New System.Drawing.Point(13, 13)
        Me.TabCprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabCprovee.Name = "TabCprovee"
        Me.TabCprovee.SelectedIndex = 0
        Me.TabCprovee.Size = New System.Drawing.Size(984, 474)
        Me.TabCprovee.TabIndex = 1
        '
        'LConsultacontaprovee
        '
        Me.LConsultacontaprovee.AutoSize = True
        Me.LConsultacontaprovee.Location = New System.Drawing.Point(27, 30)
        Me.LConsultacontaprovee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LConsultacontaprovee.Name = "LConsultacontaprovee"
        Me.LConsultacontaprovee.Size = New System.Drawing.Size(63, 16)
        Me.LConsultacontaprovee.TabIndex = 2
        Me.LConsultacontaprovee.Text = "Nombre"
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(117, 30)
        Me.TextBoxnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(690, 22)
        Me.TextBoxnombre.TabIndex = 3
        '
        'BConsultaProvee
        '
        Me.BConsultaProvee.BackgroundImage = CType(resources.GetObject("BConsultaProvee.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaProvee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaProvee.Location = New System.Drawing.Point(863, 18)
        Me.BConsultaProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaProvee.Name = "BConsultaProvee"
        Me.BConsultaProvee.Size = New System.Drawing.Size(61, 41)
        Me.BConsultaProvee.TabIndex = 5
        Me.BConsultaProvee.UseVisualStyleBackColor = True
        '
        'BConsultaLimpi
        '
        Me.BConsultaLimpi.BackgroundImage = CType(resources.GetObject("BConsultaLimpi.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaLimpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaLimpi.Location = New System.Drawing.Point(863, 97)
        Me.BConsultaLimpi.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaLimpi.Name = "BConsultaLimpi"
        Me.BConsultaLimpi.Size = New System.Drawing.Size(61, 48)
        Me.BConsultaLimpi.TabIndex = 6
        Me.BConsultaLimpi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 97)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(777, 226)
        Me.DataGridView1.TabIndex = 7
        '
        'TabConsuProvee
        '
        Me.TabConsuProvee.Controls.Add(Me.DataGridView1)
        Me.TabConsuProvee.Controls.Add(Me.BConsultaLimpi)
        Me.TabConsuProvee.Controls.Add(Me.BConsultaProvee)
        Me.TabConsuProvee.Controls.Add(Me.TextBoxnombre)
        Me.TabConsuProvee.Controls.Add(Me.LConsultacontaprovee)
        Me.TabConsuProvee.Location = New System.Drawing.Point(4, 25)
        Me.TabConsuProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabConsuProvee.Name = "TabConsuProvee"
        Me.TabConsuProvee.Padding = New System.Windows.Forms.Padding(4)
        Me.TabConsuProvee.Size = New System.Drawing.Size(976, 445)
        Me.TabConsuProvee.TabIndex = 0
        Me.TabConsuProvee.Text = "Consulta Proveedor"
        Me.TabConsuProvee.UseVisualStyleBackColor = True
        '
        'CatalogoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 501)
        Me.Controls.Add(Me.TabCprovee)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CatalogoProveedor"
        Me.Text = "Consulta y alta de proveedores"
        Me.TabAltaprovee.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabCprovee.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsuProvee.ResumeLayout(False)
        Me.TabConsuProvee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAltaprovee As TabPage
    Friend WithEvents Blimpiar As Button
    Friend WithEvents BAgregarprovee As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Textcontacto As TextBox
    Friend WithEvents Textcorreo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Texttel As TextBox
    Friend WithEvents Textcp As TextBox
    Friend WithEvents Textcuidad As TextBox
    Friend WithEvents Textcol As TextBox
    Friend WithEvents Textdire As TextBox
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents txtidpro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TabCprovee As TabControl
    Friend WithEvents TabConsuProvee As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BConsultaLimpi As Button
    Friend WithEvents BConsultaProvee As Button
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents LConsultacontaprovee As Label
End Class
