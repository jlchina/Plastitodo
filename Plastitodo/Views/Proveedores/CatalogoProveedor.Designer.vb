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
        Me.Textcorreo2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_rfc = New System.Windows.Forms.TextBox()
        Me.Textcontacto2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textcontacto = New System.Windows.Forms.TextBox()
        Me.Textcorreo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.BAgregarprovee = New System.Windows.Forms.Button()
        Me.TabCprovee = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV_Prov = New System.Windows.Forms.DataGridView()
        Me.BConsultaLimpi = New System.Windows.Forms.Button()
        Me.BConsultaProvee = New System.Windows.Forms.Button()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.LConsultacontaprovee = New System.Windows.Forms.Label()
        Me.TabAltaprovee.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabCprovee.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Location = New System.Drawing.Point(22, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 128)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del domicilio"
        '
        'Textcp
        '
        Me.Textcp.Location = New System.Drawing.Point(440, 90)
        Me.Textcp.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcp.MaxLength = 6
        Me.Textcp.Name = "Textcp"
        Me.Textcp.Size = New System.Drawing.Size(88, 22)
        Me.Textcp.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 28)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Direccion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(327, 93)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Código Postal:"
        '
        'Textcuidad
        '
        Me.Textcuidad.Location = New System.Drawing.Point(93, 90)
        Me.Textcuidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcuidad.MaxLength = 45
        Me.Textcuidad.Name = "Textcuidad"
        Me.Textcuidad.Size = New System.Drawing.Size(226, 22)
        Me.Textcuidad.TabIndex = 10
        '
        'Textdire
        '
        Me.Textdire.Location = New System.Drawing.Point(91, 28)
        Me.Textdire.Margin = New System.Windows.Forms.Padding(4)
        Me.Textdire.MaxLength = 50
        Me.Textdire.Name = "Textdire"
        Me.Textdire.Size = New System.Drawing.Size(437, 22)
        Me.Textdire.TabIndex = 8
        '
        'Textcol
        '
        Me.Textcol.Location = New System.Drawing.Point(93, 58)
        Me.Textcol.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcol.MaxLength = 50
        Me.Textcol.Name = "Textcol"
        Me.Textcol.Size = New System.Drawing.Size(435, 22)
        Me.Textcol.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Ciudad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 56)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Colonia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textcorreo2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_rfc)
        Me.GroupBox1.Controls.Add(Me.Textcontacto2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Textcontacto)
        Me.GroupBox1.Controls.Add(Me.Textcorreo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Textnombre)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Texttel)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 153)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion general"
        '
        'Textcorreo2
        '
        Me.Textcorreo2.Location = New System.Drawing.Point(357, 117)
        Me.Textcorreo2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcorreo2.MaxLength = 45
        Me.Textcorreo2.Name = "Textcorreo2"
        Me.Textcorreo2.Size = New System.Drawing.Size(173, 22)
        Me.Textcorreo2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Correo 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "RFC:"
        '
        'Txt_rfc
        '
        Me.Txt_rfc.Location = New System.Drawing.Point(93, 57)
        Me.Txt_rfc.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_rfc.MaxLength = 14
        Me.Txt_rfc.Name = "Txt_rfc"
        Me.Txt_rfc.Size = New System.Drawing.Size(196, 22)
        Me.Txt_rfc.TabIndex = 2
        '
        'Textcontacto2
        '
        Me.Textcontacto2.Location = New System.Drawing.Point(93, 117)
        Me.Textcontacto2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcontacto2.MaxLength = 45
        Me.Textcontacto2.Name = "Textcontacto2"
        Me.Textcontacto2.Size = New System.Drawing.Size(196, 22)
        Me.Textcontacto2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Contacto 2:"
        '
        'Textcontacto
        '
        Me.Textcontacto.Location = New System.Drawing.Point(93, 87)
        Me.Textcontacto.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcontacto.Name = "Textcontacto"
        Me.Textcontacto.Size = New System.Drawing.Size(196, 22)
        Me.Textcontacto.TabIndex = 45
        '
        'Textcorreo
        '
        Me.Textcorreo.Location = New System.Drawing.Point(357, 87)
        Me.Textcorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.Textcorreo.MaxLength = 45
        Me.Textcorreo.Name = "Textcorreo"
        Me.Textcorreo.Size = New System.Drawing.Size(173, 22)
        Me.Textcorreo.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo 1:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 90)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Contacto 1:"
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(93, 28)
        Me.Textnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Textnombre.MaxLength = 45
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(435, 22)
        Me.Textnombre.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Tel:"
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(357, 57)
        Me.Texttel.Margin = New System.Windows.Forms.Padding(4)
        Me.Texttel.MaxLength = 10
        Me.Texttel.Name = "Texttel"
        Me.Texttel.Size = New System.Drawing.Size(171, 22)
        Me.Texttel.TabIndex = 3
        '
        'Blimpiar
        '
        Me.Blimpiar.BackgroundImage = CType(resources.GetObject("Blimpiar.BackgroundImage"), System.Drawing.Image)
        Me.Blimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Blimpiar.Location = New System.Drawing.Point(669, 301)
        Me.Blimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(57, 49)
        Me.Blimpiar.TabIndex = 13
        Me.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'BAgregarprovee
        '
        Me.BAgregarprovee.BackgroundImage = CType(resources.GetObject("BAgregarprovee.BackgroundImage"), System.Drawing.Image)
        Me.BAgregarprovee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAgregarprovee.Location = New System.Drawing.Point(745, 303)
        Me.BAgregarprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.BAgregarprovee.Name = "BAgregarprovee"
        Me.BAgregarprovee.Size = New System.Drawing.Size(57, 47)
        Me.BAgregarprovee.TabIndex = 12
        Me.BAgregarprovee.UseVisualStyleBackColor = True
        '
        'TabCprovee
        '
        Me.TabCprovee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCprovee.Controls.Add(Me.TabAltaprovee)
        Me.TabCprovee.Controls.Add(Me.TabPage1)
        Me.TabCprovee.Location = New System.Drawing.Point(13, 13)
        Me.TabCprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.TabCprovee.Name = "TabCprovee"
        Me.TabCprovee.SelectedIndex = 0
        Me.TabCprovee.Size = New System.Drawing.Size(819, 388)
        Me.TabCprovee.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV_Prov)
        Me.TabPage1.Controls.Add(Me.BConsultaLimpi)
        Me.TabPage1.Controls.Add(Me.BConsultaProvee)
        Me.TabPage1.Controls.Add(Me.TextBoxnombre)
        Me.TabPage1.Controls.Add(Me.LConsultacontaprovee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 359)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Consulta de Proveedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGV_Prov
        '
        Me.DGV_Prov.AllowUserToAddRows = False
        Me.DGV_Prov.AllowUserToDeleteRows = False
        Me.DGV_Prov.AllowUserToOrderColumns = True
        Me.DGV_Prov.AllowUserToResizeRows = False
        Me.DGV_Prov.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Prov.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_Prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Prov.Location = New System.Drawing.Point(8, 70)
        Me.DGV_Prov.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Prov.Name = "DGV_Prov"
        Me.DGV_Prov.ReadOnly = True
        Me.DGV_Prov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Prov.Size = New System.Drawing.Size(795, 274)
        Me.DGV_Prov.TabIndex = 12
        '
        'BConsultaLimpi
        '
        Me.BConsultaLimpi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BConsultaLimpi.BackgroundImage = CType(resources.GetObject("BConsultaLimpi.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaLimpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaLimpi.Location = New System.Drawing.Point(715, 14)
        Me.BConsultaLimpi.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaLimpi.Name = "BConsultaLimpi"
        Me.BConsultaLimpi.Size = New System.Drawing.Size(61, 48)
        Me.BConsultaLimpi.TabIndex = 16
        Me.BConsultaLimpi.UseVisualStyleBackColor = True
        '
        'BConsultaProvee
        '
        Me.BConsultaProvee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BConsultaProvee.BackgroundImage = CType(resources.GetObject("BConsultaProvee.BackgroundImage"), System.Drawing.Image)
        Me.BConsultaProvee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BConsultaProvee.Location = New System.Drawing.Point(627, 14)
        Me.BConsultaProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.BConsultaProvee.Name = "BConsultaProvee"
        Me.BConsultaProvee.Size = New System.Drawing.Size(63, 48)
        Me.BConsultaProvee.TabIndex = 15
        Me.BConsultaProvee.UseVisualStyleBackColor = True
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(117, 23)
        Me.TextBoxnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(488, 22)
        Me.TextBoxnombre.TabIndex = 14
        '
        'LConsultacontaprovee
        '
        Me.LConsultacontaprovee.AutoSize = True
        Me.LConsultacontaprovee.Location = New System.Drawing.Point(27, 23)
        Me.LConsultacontaprovee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LConsultacontaprovee.Name = "LConsultacontaprovee"
        Me.LConsultacontaprovee.Size = New System.Drawing.Size(63, 16)
        Me.LConsultacontaprovee.TabIndex = 8
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV_Prov, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Textcorreo2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_rfc As TextBox
    Friend WithEvents Textcontacto2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV_Prov As DataGridView
    Friend WithEvents BConsultaLimpi As Button
    Friend WithEvents BConsultaProvee As Button
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents LConsultacontaprovee As Label
End Class
