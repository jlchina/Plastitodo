<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaGpoProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaGpoProd))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.cmbo_nomfam = New System.Windows.Forms.ComboBox()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.txt_gpoprod = New System.Windows.Forms.TextBox()
        Me.txt_nomcat = New System.Windows.Forms.TextBox()
        Me.txt_cat = New System.Windows.Forms.TextBox()
        Me.txt_idfamilia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Dgv_EditarGP = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_EditarGP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(748, 368)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_validar)
        Me.TabPage1.Controls.Add(Me.cmbo_nomfam)
        Me.TabPage1.Controls.Add(Me.Btn_agregar)
        Me.TabPage1.Controls.Add(Me.txt_gpoprod)
        Me.TabPage1.Controls.Add(Me.txt_nomcat)
        Me.TabPage1.Controls.Add(Me.txt_cat)
        Me.TabPage1.Controls.Add(Me.txt_idfamilia)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(740, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_validar
        '
        Me.btn_validar.BackgroundImage = CType(resources.GetObject("btn_validar.BackgroundImage"), System.Drawing.Image)
        Me.btn_validar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_validar.Location = New System.Drawing.Point(30, 245)
        Me.btn_validar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(77, 48)
        Me.btn_validar.TabIndex = 3
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'cmbo_nomfam
        '
        Me.cmbo_nomfam.FormattingEnabled = True
        Me.cmbo_nomfam.Location = New System.Drawing.Point(212, 52)
        Me.cmbo_nomfam.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbo_nomfam.Name = "cmbo_nomfam"
        Me.cmbo_nomfam.Size = New System.Drawing.Size(256, 24)
        Me.cmbo_nomfam.TabIndex = 1
        '
        'Btn_agregar
        '
        Me.Btn_agregar.BackgroundImage = CType(resources.GetObject("Btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agregar.Location = New System.Drawing.Point(391, 245)
        Me.Btn_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(77, 48)
        Me.Btn_agregar.TabIndex = 4
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_gpoprod
        '
        Me.txt_gpoprod.Location = New System.Drawing.Point(212, 173)
        Me.txt_gpoprod.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_gpoprod.Name = "txt_gpoprod"
        Me.txt_gpoprod.ReadOnly = True
        Me.txt_gpoprod.Size = New System.Drawing.Size(148, 22)
        Me.txt_gpoprod.TabIndex = 7
        '
        'txt_nomcat
        '
        Me.txt_nomcat.Location = New System.Drawing.Point(212, 131)
        Me.txt_nomcat.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomcat.MaxLength = 40
        Me.txt_nomcat.Name = "txt_nomcat"
        Me.txt_nomcat.Size = New System.Drawing.Size(256, 22)
        Me.txt_nomcat.TabIndex = 2
        '
        'txt_cat
        '
        Me.txt_cat.Location = New System.Drawing.Point(212, 94)
        Me.txt_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.ReadOnly = True
        Me.txt_cat.Size = New System.Drawing.Size(148, 22)
        Me.txt_cat.TabIndex = 6
        '
        'txt_idfamilia
        '
        Me.txt_idfamilia.Location = New System.Drawing.Point(212, 5)
        Me.txt_idfamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_idfamilia.Name = "txt_idfamilia"
        Me.txt_idfamilia.ReadOnly = True
        Me.txt_idfamilia.Size = New System.Drawing.Size(148, 22)
        Me.txt_idfamilia.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Grupo de producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Id Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre Id Familia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Id Familia:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Btn_Actualizar)
        Me.TabPage2.Controls.Add(Me.Dgv_EditarGP)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(740, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar / Editar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackgroundImage = CType(resources.GetObject("Btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Actualizar.Location = New System.Drawing.Point(9, 7)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(47, 38)
        Me.Btn_Actualizar.TabIndex = 1
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Dgv_EditarGP
        '
        Me.Dgv_EditarGP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_EditarGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_EditarGP.Location = New System.Drawing.Point(9, 53)
        Me.Dgv_EditarGP.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_EditarGP.Name = "Dgv_EditarGP"
        Me.Dgv_EditarGP.Size = New System.Drawing.Size(718, 273)
        Me.Dgv_EditarGP.TabIndex = 0
        '
        'AltaGpoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltaGpoProd"
        Me.Text = "Grupos de producto:  Alta, Edicion y Consulta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv_EditarGP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_validar As Button
    Friend WithEvents cmbo_nomfam As ComboBox
    Friend WithEvents Btn_agregar As Button
    Friend WithEvents txt_gpoprod As TextBox
    Friend WithEvents txt_nomcat As TextBox
    Friend WithEvents txt_cat As TextBox
    Friend WithEvents txt_idfamilia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Dgv_EditarGP As DataGridView
    Friend WithEvents Btn_Actualizar As Button
End Class
