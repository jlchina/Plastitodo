<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCatprod
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModCatprod))
        Me.Tab_proveedor = New System.Windows.Forms.TabControl()
        Me.Tab_alta_p = New System.Windows.Forms.TabPage()
        Me.Pan_prov = New System.Windows.Forms.Panel()
        Me.Cbo_Proveedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbo_Marca = New System.Windows.Forms.ComboBox()
        Me.Cbo_gpoprod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbo_Pres = New System.Windows.Forms.ComboBox()
        Me.Txt_Cto = New System.Windows.Forms.TextBox()
        Me.Txt_desc = New System.Windows.Forms.TextBox()
        Me.Txt_mod = New System.Windows.Forms.TextBox()
        Me.Txt_codbar = New System.Windows.Forms.TextBox()
        Me.Lbl_telp = New System.Windows.Forms.Label()
        Me.Lb_cpp = New System.Windows.Forms.Label()
        Me.Lbl_ciudadp = New System.Windows.Forms.Label()
        Me.lbl_colp = New System.Windows.Forms.Label()
        Me.Lb_direccionp = New System.Windows.Forms.Label()
        Me.Lb_nomp = New System.Windows.Forms.Label()
        Me.Btn_cancelarp = New System.Windows.Forms.Button()
        Me.Btn_agregarp = New System.Windows.Forms.Button()
        Me.TabEditCatProv = New System.Windows.Forms.TabPage()
        Me.TxtModeloEd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigoEd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV_Edit_CP = New System.Windows.Forms.DataGridView()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Tab_proveedor.SuspendLayout()
        Me.Tab_alta_p.SuspendLayout()
        Me.Pan_prov.SuspendLayout()
        Me.TabEditCatProv.SuspendLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_proveedor
        '
        Me.Tab_proveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tab_proveedor.Controls.Add(Me.Tab_alta_p)
        Me.Tab_proveedor.Controls.Add(Me.TabEditCatProv)
        Me.Tab_proveedor.Location = New System.Drawing.Point(18, 15)
        Me.Tab_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_proveedor.Name = "Tab_proveedor"
        Me.Tab_proveedor.SelectedIndex = 0
        Me.Tab_proveedor.Size = New System.Drawing.Size(914, 476)
        Me.Tab_proveedor.TabIndex = 2
        '
        'Tab_alta_p
        '
        Me.Tab_alta_p.Controls.Add(Me.Pan_prov)
        Me.Tab_alta_p.Controls.Add(Me.Btn_cancelarp)
        Me.Tab_alta_p.Controls.Add(Me.Btn_agregarp)
        Me.Tab_alta_p.Location = New System.Drawing.Point(4, 25)
        Me.Tab_alta_p.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_alta_p.Name = "Tab_alta_p"
        Me.Tab_alta_p.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_alta_p.Size = New System.Drawing.Size(906, 447)
        Me.Tab_alta_p.TabIndex = 1
        Me.Tab_alta_p.Text = "Alta"
        Me.Tab_alta_p.UseVisualStyleBackColor = True
        '
        'Pan_prov
        '
        Me.Pan_prov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_prov.Controls.Add(Me.Cbo_Proveedor)
        Me.Pan_prov.Controls.Add(Me.Label3)
        Me.Pan_prov.Controls.Add(Me.Cbo_Marca)
        Me.Pan_prov.Controls.Add(Me.Cbo_gpoprod)
        Me.Pan_prov.Controls.Add(Me.Label2)
        Me.Pan_prov.Controls.Add(Me.Cbo_Pres)
        Me.Pan_prov.Controls.Add(Me.Txt_Cto)
        Me.Pan_prov.Controls.Add(Me.Txt_desc)
        Me.Pan_prov.Controls.Add(Me.Txt_mod)
        Me.Pan_prov.Controls.Add(Me.Txt_codbar)
        Me.Pan_prov.Controls.Add(Me.Lbl_telp)
        Me.Pan_prov.Controls.Add(Me.Lb_cpp)
        Me.Pan_prov.Controls.Add(Me.Lbl_ciudadp)
        Me.Pan_prov.Controls.Add(Me.lbl_colp)
        Me.Pan_prov.Controls.Add(Me.Lb_direccionp)
        Me.Pan_prov.Controls.Add(Me.Lb_nomp)
        Me.Pan_prov.Location = New System.Drawing.Point(8, 7)
        Me.Pan_prov.Margin = New System.Windows.Forms.Padding(4)
        Me.Pan_prov.Name = "Pan_prov"
        Me.Pan_prov.Size = New System.Drawing.Size(714, 365)
        Me.Pan_prov.TabIndex = 30
        '
        'Cbo_Proveedor
        '
        Me.Cbo_Proveedor.FormattingEnabled = True
        Me.Cbo_Proveedor.Location = New System.Drawing.Point(202, 332)
        Me.Cbo_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Proveedor.Name = "Cbo_Proveedor"
        Me.Cbo_Proveedor.Size = New System.Drawing.Size(496, 24)
        Me.Cbo_Proveedor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 336)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Proveedor:"
        '
        'Cbo_Marca
        '
        Me.Cbo_Marca.FormattingEnabled = True
        Me.Cbo_Marca.Location = New System.Drawing.Point(202, 55)
        Me.Cbo_Marca.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Marca.Name = "Cbo_Marca"
        Me.Cbo_Marca.Size = New System.Drawing.Size(496, 24)
        Me.Cbo_Marca.TabIndex = 2
        '
        'Cbo_gpoprod
        '
        Me.Cbo_gpoprod.FormattingEnabled = True
        Me.Cbo_gpoprod.Location = New System.Drawing.Point(202, 194)
        Me.Cbo_gpoprod.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_gpoprod.Name = "Cbo_gpoprod"
        Me.Cbo_gpoprod.Size = New System.Drawing.Size(262, 24)
        Me.Cbo_gpoprod.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Grupo de productos:"
        '
        'Cbo_Pres
        '
        Me.Cbo_Pres.FormattingEnabled = True
        Me.Cbo_Pres.Location = New System.Drawing.Point(202, 241)
        Me.Cbo_Pres.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Pres.Name = "Cbo_Pres"
        Me.Cbo_Pres.Size = New System.Drawing.Size(262, 24)
        Me.Cbo_Pres.TabIndex = 6
        '
        'Txt_Cto
        '
        Me.Txt_Cto.Location = New System.Drawing.Point(202, 287)
        Me.Txt_Cto.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Cto.Name = "Txt_Cto"
        Me.Txt_Cto.Size = New System.Drawing.Size(168, 22)
        Me.Txt_Cto.TabIndex = 7
        '
        'Txt_desc
        '
        Me.Txt_desc.Location = New System.Drawing.Point(202, 149)
        Me.Txt_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_desc.MaxLength = 45
        Me.Txt_desc.Name = "Txt_desc"
        Me.Txt_desc.Size = New System.Drawing.Size(496, 22)
        Me.Txt_desc.TabIndex = 4
        '
        'Txt_mod
        '
        Me.Txt_mod.Location = New System.Drawing.Point(202, 105)
        Me.Txt_mod.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_mod.MaxLength = 20
        Me.Txt_mod.Name = "Txt_mod"
        Me.Txt_mod.Size = New System.Drawing.Size(496, 22)
        Me.Txt_mod.TabIndex = 3
        '
        'Txt_codbar
        '
        Me.Txt_codbar.Location = New System.Drawing.Point(202, 18)
        Me.Txt_codbar.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_codbar.MaxLength = 15
        Me.Txt_codbar.Name = "Txt_codbar"
        Me.Txt_codbar.Size = New System.Drawing.Size(496, 22)
        Me.Txt_codbar.TabIndex = 1
        '
        'Lbl_telp
        '
        Me.Lbl_telp.AutoSize = True
        Me.Lbl_telp.Location = New System.Drawing.Point(26, 290)
        Me.Lbl_telp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_telp.Name = "Lbl_telp"
        Me.Lbl_telp.Size = New System.Drawing.Size(107, 16)
        Me.Lbl_telp.TabIndex = 15
        Me.Lbl_telp.Text = "Costo unitario:"
        '
        'Lb_cpp
        '
        Me.Lb_cpp.AutoSize = True
        Me.Lb_cpp.Location = New System.Drawing.Point(26, 247)
        Me.Lb_cpp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_cpp.Name = "Lb_cpp"
        Me.Lb_cpp.Size = New System.Drawing.Size(99, 16)
        Me.Lb_cpp.TabIndex = 14
        Me.Lb_cpp.Text = "Presentación"
        '
        'Lbl_ciudadp
        '
        Me.Lbl_ciudadp.AutoSize = True
        Me.Lbl_ciudadp.Location = New System.Drawing.Point(26, 153)
        Me.Lbl_ciudadp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_ciudadp.Name = "Lbl_ciudadp"
        Me.Lbl_ciudadp.Size = New System.Drawing.Size(95, 16)
        Me.Lbl_ciudadp.TabIndex = 13
        Me.Lbl_ciudadp.Text = "Descripción:"
        '
        'lbl_colp
        '
        Me.lbl_colp.AutoSize = True
        Me.lbl_colp.Location = New System.Drawing.Point(26, 108)
        Me.lbl_colp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_colp.Name = "lbl_colp"
        Me.lbl_colp.Size = New System.Drawing.Size(64, 16)
        Me.lbl_colp.TabIndex = 12
        Me.lbl_colp.Text = "Modelo:"
        '
        'Lb_direccionp
        '
        Me.Lb_direccionp.AutoSize = True
        Me.Lb_direccionp.Location = New System.Drawing.Point(26, 60)
        Me.Lb_direccionp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_direccionp.Name = "Lb_direccionp"
        Me.Lb_direccionp.Size = New System.Drawing.Size(55, 16)
        Me.Lb_direccionp.TabIndex = 11
        Me.Lb_direccionp.Text = "Marca:"
        '
        'Lb_nomp
        '
        Me.Lb_nomp.AutoSize = True
        Me.Lb_nomp.Location = New System.Drawing.Point(26, 21)
        Me.Lb_nomp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_nomp.Name = "Lb_nomp"
        Me.Lb_nomp.Size = New System.Drawing.Size(133, 16)
        Me.Lb_nomp.TabIndex = 10
        Me.Lb_nomp.Text = "Código de barras:"
        '
        'Btn_cancelarp
        '
        Me.Btn_cancelarp.BackgroundImage = CType(resources.GetObject("Btn_cancelarp.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancelarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_cancelarp.Location = New System.Drawing.Point(755, 8)
        Me.Btn_cancelarp.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_cancelarp.Name = "Btn_cancelarp"
        Me.Btn_cancelarp.Size = New System.Drawing.Size(73, 61)
        Me.Btn_cancelarp.TabIndex = 10
        Me.Btn_cancelarp.UseVisualStyleBackColor = True
        '
        'Btn_agregarp
        '
        Me.Btn_agregarp.BackgroundImage = CType(resources.GetObject("Btn_agregarp.BackgroundImage"), System.Drawing.Image)
        Me.Btn_agregarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agregarp.Location = New System.Drawing.Point(755, 317)
        Me.Btn_agregarp.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_agregarp.Name = "Btn_agregarp"
        Me.Btn_agregarp.Size = New System.Drawing.Size(73, 55)
        Me.Btn_agregarp.TabIndex = 9
        Me.Btn_agregarp.UseVisualStyleBackColor = True
        '
        'TabEditCatProv
        '
        Me.TabEditCatProv.Controls.Add(Me.TxtModeloEd)
        Me.TabEditCatProv.Controls.Add(Me.Label1)
        Me.TabEditCatProv.Controls.Add(Me.BtnBuscar)
        Me.TabEditCatProv.Controls.Add(Me.txtCodigoEd)
        Me.TabEditCatProv.Controls.Add(Me.Label4)
        Me.TabEditCatProv.Controls.Add(Me.DGV_Edit_CP)
        Me.TabEditCatProv.Location = New System.Drawing.Point(4, 25)
        Me.TabEditCatProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TabEditCatProv.Name = "TabEditCatProv"
        Me.TabEditCatProv.Padding = New System.Windows.Forms.Padding(4)
        Me.TabEditCatProv.Size = New System.Drawing.Size(906, 447)
        Me.TabEditCatProv.TabIndex = 2
        Me.TabEditCatProv.Text = "Editar"
        Me.TabEditCatProv.UseVisualStyleBackColor = True
        '
        'TxtModeloEd
        '
        Me.TxtModeloEd.Location = New System.Drawing.Point(500, 31)
        Me.TxtModeloEd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtModeloEd.MaxLength = 20
        Me.TxtModeloEd.Name = "TxtModeloEd"
        Me.TxtModeloEd.Size = New System.Drawing.Size(226, 22)
        Me.TxtModeloEd.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modelo:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(834, 7)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(62, 55)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'txtCodigoEd
        '
        Me.txtCodigoEd.Location = New System.Drawing.Point(128, 31)
        Me.txtCodigoEd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoEd.MaxLength = 14
        Me.txtCodigoEd.Name = "txtCodigoEd"
        Me.txtCodigoEd.Size = New System.Drawing.Size(226, 22)
        Me.txtCodigoEd.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Código:"
        '
        'DGV_Edit_CP
        '
        Me.DGV_Edit_CP.AllowUserToAddRows = False
        Me.DGV_Edit_CP.AllowUserToDeleteRows = False
        Me.DGV_Edit_CP.AllowUserToOrderColumns = True
        Me.DGV_Edit_CP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Edit_CP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Edit_CP.Location = New System.Drawing.Point(9, 70)
        Me.DGV_Edit_CP.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Edit_CP.Name = "DGV_Edit_CP"
        Me.DGV_Edit_CP.Size = New System.Drawing.Size(887, 364)
        Me.DGV_Edit_CP.TabIndex = 1
        '
        'ModCatprod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 506)
        Me.Controls.Add(Me.Tab_proveedor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(975, 545)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(975, 545)
        Me.Name = "ModCatprod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de productos: Alta, Consulta y Edicion"
        Me.Tab_proveedor.ResumeLayout(False)
        Me.Tab_alta_p.ResumeLayout(False)
        Me.Pan_prov.ResumeLayout(False)
        Me.Pan_prov.PerformLayout()
        Me.TabEditCatProv.ResumeLayout(False)
        Me.TabEditCatProv.PerformLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_proveedor As TabControl
    Friend WithEvents Tab_alta_p As TabPage
    Friend WithEvents Pan_prov As Panel
    Friend WithEvents Cbo_gpoprod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbo_Pres As ComboBox
    Friend WithEvents Txt_Cto As TextBox
    Friend WithEvents Txt_desc As TextBox
    Friend WithEvents Txt_mod As TextBox
    Friend WithEvents Txt_codbar As TextBox
    Friend WithEvents Lbl_telp As Label
    Friend WithEvents Lb_cpp As Label
    Friend WithEvents Lbl_ciudadp As Label
    Friend WithEvents lbl_colp As Label
    Friend WithEvents Lb_direccionp As Label
    Friend WithEvents Lb_nomp As Label
    Friend WithEvents Btn_cancelarp As Button
    Friend WithEvents Btn_agregarp As Button
    Friend WithEvents TabEditCatProv As TabPage
    Friend WithEvents TxtModeloEd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents txtCodigoEd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV_Edit_CP As DataGridView
    Friend WithEvents Cbo_Marca As ComboBox
    Friend WithEvents Cbo_Proveedor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
End Class
