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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Textcp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Textcuidad = New System.Windows.Forms.TextBox()
        Me.Textdire = New System.Windows.Forms.TextBox()
        Me.Textcol = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Textcontacto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textcorreo = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.BAgregarprovee = New System.Windows.Forms.Button()
        Me.TabCprovee = New System.Windows.Forms.TabControl()
        Me.TabConsuProvee = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BConsultaLimpi = New System.Windows.Forms.Button()
        Me.BConsultaProvee = New System.Windows.Forms.Button()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.LConsultacontaprovee = New System.Windows.Forms.Label()
        Me.TabAltaprovee.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabCprovee.SuspendLayout()
        Me.TabConsuProvee.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAltaprovee
        '
        Me.TabAltaprovee.Controls.Add(Me.PictureBox1)
        Me.TabAltaprovee.Controls.Add(Me.GroupBox2)
        Me.TabAltaprovee.Controls.Add(Me.GroupBox1)
        Me.TabAltaprovee.Controls.Add(Me.Blimpiar)
        Me.TabAltaprovee.Controls.Add(Me.BAgregarprovee)
        Me.TabAltaprovee.Location = New System.Drawing.Point(4, 25)
        Me.TabAltaprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAltaprovee.Name = "TabAltaprovee"
        Me.TabAltaprovee.Padding = New System.Windows.Forms.Padding(4)
        Me.TabAltaprovee.Size = New System.Drawing.Size(811, 359)
        Me.TabAltaprovee.TabIndex = 1
        Me.TabAltaprovee.Text = "Alta Proveedor"
        Me.TabAltaprovee.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(591, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Textcp)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Textcuidad)
        Me.GroupBox2.Controls.Add(Me.Textdire)
        Me.GroupBox2.Controls.Add(Me.Textcol)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 128)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del domicilio"
        '
        'Textcp
        '
        Me.Textcp.Location = New System.Drawing.Point(387, 80)
        Me.Textcp.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcp.Name = "Textcp"
        Me.Textcp.Size = New System.Drawing.Size(141, 22)
        Me.Textcp.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 18)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Direccion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 83)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Código Postal:"
        '
        'Textcuidad
        '
        Me.Textcuidad.Location = New System.Drawing.Point(93, 80)
        Me.Textcuidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcuidad.Name = "Textcuidad"
        Me.Textcuidad.Size = New System.Drawing.Size(168, 22)
        Me.Textcuidad.TabIndex = 5
        '
        'Textdire
        '
        Me.Textdire.Location = New System.Drawing.Point(91, 18)
        Me.Textdire.Margin = New System.Windows.Forms.Padding(4)
        Me.Textdire.Name = "Textdire"
        Me.Textdire.Size = New System.Drawing.Size(437, 22)
        Me.Textdire.TabIndex = 3
        '
        'Textcol
        '
        Me.Textcol.Location = New System.Drawing.Point(93, 48)
        Me.Textcol.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcol.Name = "Textcol"
        Me.Textcol.Size = New System.Drawing.Size(435, 22)
        Me.Textcol.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Ciudad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Colonia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textcontacto)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Textcorreo)
        Me.GroupBox1.Controls.Add(Me.Textnombre)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Texttel)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 130)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion general"
        '
        'Textcontacto
        '
        Me.Textcontacto.Location = New System.Drawing.Point(91, 76)
        Me.Textcontacto.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcontacto.Name = "Textcontacto"
        Me.Textcontacto.Size = New System.Drawing.Size(437, 22)
        Me.Textcontacto.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 18)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 76)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Contacto:"
        '
        'Textcorreo
        '
        Me.Textcorreo.Location = New System.Drawing.Point(374, 43)
        Me.Textcorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcorreo.Name = "Textcorreo"
        Me.Textcorreo.Size = New System.Drawing.Size(154, 22)
        Me.Textcorreo.TabIndex = 19
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(91, 15)
        Me.Textnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(437, 22)
        Me.Textnombre.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo:"
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(91, 43)
        Me.Texttel.Margin = New System.Windows.Forms.Padding(4)
        Me.Texttel.Name = "Texttel"
        Me.Texttel.Size = New System.Drawing.Size(187, 22)
        Me.Texttel.TabIndex = 7
        '
        'Blimpiar
        '
        Me.Blimpiar.BackgroundImage = CType(resources.GetObject("Blimpiar.BackgroundImage"), System.Drawing.Image)
        Me.Blimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Blimpiar.Location = New System.Drawing.Point(22, 302)
        Me.Blimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(57, 49)
        Me.Blimpiar.TabIndex = 35
        Me.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'BAgregarprovee
        '
        Me.BAgregarprovee.BackgroundImage = CType(resources.GetObject("BAgregarprovee.BackgroundImage"), System.Drawing.Image)
        Me.BAgregarprovee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAgregarprovee.Location = New System.Drawing.Point(493, 304)
        Me.BAgregarprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.BAgregarprovee.Name = "BAgregarprovee"
        Me.BAgregarprovee.Size = New System.Drawing.Size(57, 47)
        Me.BAgregarprovee.TabIndex = 1
        Me.BAgregarprovee.UseVisualStyleBackColor = True
        '
        'TabCprovee
        '
        Me.TabCprovee.Controls.Add(Me.TabConsuProvee)
        Me.TabCprovee.Controls.Add(Me.TabAltaprovee)
        Me.TabCprovee.Location = New System.Drawing.Point(13, 13)
        Me.TabCprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabCprovee.Name = "TabCprovee"
        Me.TabCprovee.SelectedIndex = 0
        Me.TabCprovee.Size = New System.Drawing.Size(819, 388)
        Me.TabCprovee.TabIndex = 1
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
        Me.TabConsuProvee.Size = New System.Drawing.Size(811, 359)
        Me.TabConsuProvee.TabIndex = 0
        Me.TabConsuProvee.Text = "Consulta Proveedor"
        Me.TabConsuProvee.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Size = New System.Drawing.Size(573, 226)
        Me.DataGridView1.TabIndex = 7
        '
        'BConsultaLimpi
        '
        Me.BConsultaLimpi.BackgroundImage = CType(resources.GetObject("BConsultaLimpi.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaLimpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaLimpi.Location = New System.Drawing.Point(627, 100)
        Me.BConsultaLimpi.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaLimpi.Name = "BConsultaLimpi"
        Me.BConsultaLimpi.Size = New System.Drawing.Size(61, 48)
        Me.BConsultaLimpi.TabIndex = 6
        Me.BConsultaLimpi.UseVisualStyleBackColor = True
        '
        'BConsultaProvee
        '
        Me.BConsultaProvee.BackgroundImage = CType(resources.GetObject("BConsultaProvee.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaProvee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaProvee.Location = New System.Drawing.Point(627, 21)
        Me.BConsultaProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaProvee.Name = "BConsultaProvee"
        Me.BConsultaProvee.Size = New System.Drawing.Size(61, 41)
        Me.BConsultaProvee.TabIndex = 5
        Me.BConsultaProvee.UseVisualStyleBackColor = True
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(117, 30)
        Me.TextBoxnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(488, 22)
        Me.TextBoxnombre.TabIndex = 3
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
        'CatalogoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 422)
        Me.Controls.Add(Me.TabCprovee)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CatalogoProveedor"
        Me.Text = "Consulta y alta de proveedores"
        Me.TabAltaprovee.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabCprovee.ResumeLayout(False)
        Me.TabConsuProvee.ResumeLayout(False)
        Me.TabConsuProvee.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAltaprovee As TabPage
    Friend WithEvents Blimpiar As Button
    Friend WithEvents BAgregarprovee As Button
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TabCprovee As TabControl
    Friend WithEvents TabConsuProvee As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BConsultaLimpi As Button
    Friend WithEvents BConsultaProvee As Button
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents LConsultacontaprovee As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
