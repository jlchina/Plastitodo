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
        Me.TabCprovee = New System.Windows.Forms.TabControl()
        Me.TabConsuProvee = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BConsultaLimpi = New System.Windows.Forms.Button()
        Me.BConsultaProvee = New System.Windows.Forms.Button()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.LConsultacontaprovee = New System.Windows.Forms.Label()
        Me.TabAltaprovee = New System.Windows.Forms.TabPage()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.BAgregarprovee = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Textcontacto = New System.Windows.Forms.TextBox()
        Me.Textcorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Texttel = New System.Windows.Forms.TextBox()
        Me.Textcp = New System.Windows.Forms.TextBox()
        Me.Textcuidad = New System.Windows.Forms.TextBox()
        Me.Textcol = New System.Windows.Forms.TextBox()
        Me.Textdire = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.txtidpro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LModiElimi = New System.Windows.Forms.TabPage()
        Me.TabCprovee.SuspendLayout()
        Me.TabConsuProvee.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAltaprovee.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCprovee
        '
        Me.TabCprovee.Controls.Add(Me.TabConsuProvee)
        Me.TabCprovee.Controls.Add(Me.TabAltaprovee)
        Me.TabCprovee.Controls.Add(Me.LModiElimi)
        Me.TabCprovee.Location = New System.Drawing.Point(12, 12)
        Me.TabCprovee.Name = "TabCprovee"
        Me.TabCprovee.SelectedIndex = 0
        Me.TabCprovee.Size = New System.Drawing.Size(656, 385)
        Me.TabCprovee.TabIndex = 1
        '
        'TabConsuProvee
        '
        Me.TabConsuProvee.Controls.Add(Me.DataGridView1)
        Me.TabConsuProvee.Controls.Add(Me.BConsultaLimpi)
        Me.TabConsuProvee.Controls.Add(Me.BConsultaProvee)
        Me.TabConsuProvee.Controls.Add(Me.TextBoxnombre)
        Me.TabConsuProvee.Controls.Add(Me.LConsultacontaprovee)
        Me.TabConsuProvee.Location = New System.Drawing.Point(4, 22)
        Me.TabConsuProvee.Name = "TabConsuProvee"
        Me.TabConsuProvee.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConsuProvee.Size = New System.Drawing.Size(648, 359)
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
        Me.DataGridView1.Location = New System.Drawing.Point(21, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(518, 184)
        Me.DataGridView1.TabIndex = 7
        '
        'BConsultaLimpi
        '
        Me.BConsultaLimpi.Location = New System.Drawing.Point(558, 66)
        Me.BConsultaLimpi.Name = "BConsultaLimpi"
        Me.BConsultaLimpi.Size = New System.Drawing.Size(75, 23)
        Me.BConsultaLimpi.TabIndex = 6
        Me.BConsultaLimpi.Text = "Limpiar"
        Me.BConsultaLimpi.UseVisualStyleBackColor = True
        '
        'BConsultaProvee
        '
        Me.BConsultaProvee.Location = New System.Drawing.Point(558, 24)
        Me.BConsultaProvee.Name = "BConsultaProvee"
        Me.BConsultaProvee.Size = New System.Drawing.Size(75, 23)
        Me.BConsultaProvee.TabIndex = 5
        Me.BConsultaProvee.Text = "Buscar"
        Me.BConsultaProvee.UseVisualStyleBackColor = True
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(78, 24)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(461, 20)
        Me.TextBoxnombre.TabIndex = 3
        '
        'LConsultacontaprovee
        '
        Me.LConsultacontaprovee.AutoSize = True
        Me.LConsultacontaprovee.Location = New System.Drawing.Point(18, 24)
        Me.LConsultacontaprovee.Name = "LConsultacontaprovee"
        Me.LConsultacontaprovee.Size = New System.Drawing.Size(44, 13)
        Me.LConsultacontaprovee.TabIndex = 2
        Me.LConsultacontaprovee.Text = "Nombre"
        '
        'TabAltaprovee
        '
        Me.TabAltaprovee.Controls.Add(Me.Blimpiar)
        Me.TabAltaprovee.Controls.Add(Me.BAgregarprovee)
        Me.TabAltaprovee.Controls.Add(Me.Panel1)
        Me.TabAltaprovee.Location = New System.Drawing.Point(4, 22)
        Me.TabAltaprovee.Name = "TabAltaprovee"
        Me.TabAltaprovee.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAltaprovee.Size = New System.Drawing.Size(648, 359)
        Me.TabAltaprovee.TabIndex = 1
        Me.TabAltaprovee.Text = "Alta Proveedor"
        Me.TabAltaprovee.UseVisualStyleBackColor = True
        '
        'Blimpiar
        '
        Me.Blimpiar.Location = New System.Drawing.Point(549, 63)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Blimpiar.TabIndex = 35
        Me.Blimpiar.Text = "Limpiar"
        Me.Blimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'BAgregarprovee
        '
        Me.BAgregarprovee.Location = New System.Drawing.Point(550, 19)
        Me.BAgregarprovee.Name = "BAgregarprovee"
        Me.BAgregarprovee.Size = New System.Drawing.Size(75, 23)
        Me.BAgregarprovee.TabIndex = 1
        Me.BAgregarprovee.Text = "Agregar"
        Me.BAgregarprovee.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(3, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 330)
        Me.Panel1.TabIndex = 34
        '
        'Textcontacto
        '
        Me.Textcontacto.Location = New System.Drawing.Point(143, 293)
        Me.Textcontacto.Name = "Textcontacto"
        Me.Textcontacto.Size = New System.Drawing.Size(332, 20)
        Me.Textcontacto.TabIndex = 20
        '
        'Textcorreo
        '
        Me.Textcorreo.Location = New System.Drawing.Point(143, 260)
        Me.Textcorreo.Name = "Textcorreo"
        Me.Textcorreo.Size = New System.Drawing.Size(332, 20)
        Me.Textcorreo.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Contacto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo:"
        '
        'Texttel
        '
        Me.Texttel.Location = New System.Drawing.Point(143, 226)
        Me.Texttel.Name = "Texttel"
        Me.Texttel.Size = New System.Drawing.Size(332, 20)
        Me.Texttel.TabIndex = 7
        '
        'Textcp
        '
        Me.Textcp.Location = New System.Drawing.Point(143, 191)
        Me.Textcp.Name = "Textcp"
        Me.Textcp.Size = New System.Drawing.Size(113, 20)
        Me.Textcp.TabIndex = 6
        '
        'Textcuidad
        '
        Me.Textcuidad.Location = New System.Drawing.Point(143, 156)
        Me.Textcuidad.Name = "Textcuidad"
        Me.Textcuidad.Size = New System.Drawing.Size(113, 20)
        Me.Textcuidad.TabIndex = 5
        '
        'Textcol
        '
        Me.Textcol.Location = New System.Drawing.Point(143, 121)
        Me.Textcol.Name = "Textcol"
        Me.Textcol.Size = New System.Drawing.Size(332, 20)
        Me.Textcol.TabIndex = 4
        '
        'Textdire
        '
        Me.Textdire.Location = New System.Drawing.Point(143, 85)
        Me.Textdire.Name = "Textdire"
        Me.Textdire.Size = New System.Drawing.Size(332, 20)
        Me.Textdire.TabIndex = 3
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(143, 50)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(332, 20)
        Me.Textnombre.TabIndex = 2
        '
        'txtidpro
        '
        Me.txtidpro.Location = New System.Drawing.Point(143, 15)
        Me.txtidpro.Name = "txtidpro"
        Me.txtidpro.Size = New System.Drawing.Size(61, 20)
        Me.txtidpro.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Telefono:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "CP:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Cuidad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Colonia:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Direccion:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Nombre:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "ID Proveedor"
        '
        'LModiElimi
        '
        Me.LModiElimi.Location = New System.Drawing.Point(4, 22)
        Me.LModiElimi.Name = "LModiElimi"
        Me.LModiElimi.Padding = New System.Windows.Forms.Padding(3)
        Me.LModiElimi.Size = New System.Drawing.Size(648, 359)
        Me.LModiElimi.TabIndex = 2
        Me.LModiElimi.Text = "Modificar/Eliminar"
        Me.LModiElimi.UseVisualStyleBackColor = True
        '
        'CatalogoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 472)
        Me.Controls.Add(Me.TabCprovee)
        Me.Name = "CatalogoProveedor"
        Me.Text = "CatalogoProveedor"
        Me.TabCprovee.ResumeLayout(False)
        Me.TabConsuProvee.ResumeLayout(False)
        Me.TabConsuProvee.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAltaprovee.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCprovee As TabControl
    Friend WithEvents TabConsuProvee As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BConsultaLimpi As Button
    Friend WithEvents BConsultaProvee As Button
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents LConsultacontaprovee As Label
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
    Friend WithEvents LModiElimi As TabPage
End Class
