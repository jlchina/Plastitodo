<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catprod_NoUsar
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
        Me.Tab_proveedor = New System.Windows.Forms.TabControl()
        Me.Tab_cons_p = New System.Windows.Forms.TabPage()
        Me.Btn_filtro = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVcatprov = New System.Windows.Forms.DataGridView()
        Me.Tab_alta_p = New System.Windows.Forms.TabPage()
        Me.Pan_prov = New System.Windows.Forms.Panel()
        Me.Cbo_Pres = New System.Windows.Forms.ComboBox()
        Me.Txt_Cto = New System.Windows.Forms.TextBox()
        Me.Txt_desc = New System.Windows.Forms.TextBox()
        Me.Txt_mod = New System.Windows.Forms.TextBox()
        Me.Txt_marca = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV_Edit_CP = New System.Windows.Forms.DataGridView()
        Me.Tab_proveedor.SuspendLayout()
        Me.Tab_cons_p.SuspendLayout()
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_alta_p.SuspendLayout()
        Me.Pan_prov.SuspendLayout()
        Me.TabEditCatProv.SuspendLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_proveedor
        '
        Me.Tab_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_proveedor.Controls.Add(Me.Tab_cons_p)
        Me.Tab_proveedor.Controls.Add(Me.Tab_alta_p)
        Me.Tab_proveedor.Controls.Add(Me.TabEditCatProv)
        Me.Tab_proveedor.Location = New System.Drawing.Point(12, 12)
        Me.Tab_proveedor.Name = "Tab_proveedor"
        Me.Tab_proveedor.SelectedIndex = 0
        Me.Tab_proveedor.Size = New System.Drawing.Size(809, 330)
        Me.Tab_proveedor.TabIndex = 1
        '
        'Tab_cons_p
        '
        Me.Tab_cons_p.Controls.Add(Me.Btn_filtro)
        Me.Tab_cons_p.Controls.Add(Me.BtnBuscar)
        Me.Tab_cons_p.Controls.Add(Me.TxtMarca)
        Me.Tab_cons_p.Controls.Add(Me.Label3)
        Me.Tab_cons_p.Controls.Add(Me.TxtProv)
        Me.Tab_cons_p.Controls.Add(Me.Label2)
        Me.Tab_cons_p.Controls.Add(Me.TxtCodigo)
        Me.Tab_cons_p.Controls.Add(Me.Label1)
        Me.Tab_cons_p.Controls.Add(Me.DGVcatprov)
        Me.Tab_cons_p.Location = New System.Drawing.Point(4, 22)
        Me.Tab_cons_p.Name = "Tab_cons_p"
        Me.Tab_cons_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_cons_p.Size = New System.Drawing.Size(801, 304)
        Me.Tab_cons_p.TabIndex = 0
        Me.Tab_cons_p.Text = "Consulta"
        Me.Tab_cons_p.UseVisualStyleBackColor = True
        '
        'Btn_filtro
        '
        Me.Btn_filtro.Location = New System.Drawing.Point(488, 4)
        Me.Btn_filtro.Name = "Btn_filtro"
        Me.Btn_filtro.Size = New System.Drawing.Size(75, 23)
        Me.Btn_filtro.TabIndex = 6
        Me.Btn_filtro.Text = "Button2"
        Me.Btn_filtro.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(711, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(550, 29)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(152, 20)
        Me.TxtMarca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Marca: "
        '
        'TxtProv
        '
        Me.TxtProv.Location = New System.Drawing.Point(324, 29)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(152, 20)
        Me.TxtProv.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(75, 29)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código:"
        '
        'DGVcatprov
        '
        Me.DGVcatprov.AllowUserToAddRows = False
        Me.DGVcatprov.AllowUserToDeleteRows = False
        Me.DGVcatprov.AllowUserToOrderColumns = True
        Me.DGVcatprov.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVcatprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcatprov.Location = New System.Drawing.Point(3, 57)
        Me.DGVcatprov.Name = "DGVcatprov"
        Me.DGVcatprov.ReadOnly = True
        Me.DGVcatprov.Size = New System.Drawing.Size(792, 241)
        Me.DGVcatprov.TabIndex = 0
        '
        'Tab_alta_p
        '
        Me.Tab_alta_p.Controls.Add(Me.Pan_prov)
        Me.Tab_alta_p.Controls.Add(Me.Btn_cancelarp)
        Me.Tab_alta_p.Controls.Add(Me.Btn_agregarp)
        Me.Tab_alta_p.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alta_p.Name = "Tab_alta_p"
        Me.Tab_alta_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta_p.Size = New System.Drawing.Size(801, 304)
        Me.Tab_alta_p.TabIndex = 1
        Me.Tab_alta_p.Text = "Alta"
        Me.Tab_alta_p.UseVisualStyleBackColor = True
        '
        'Pan_prov
        '
        Me.Pan_prov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_prov.Controls.Add(Me.Cbo_Pres)
        Me.Pan_prov.Controls.Add(Me.Txt_Cto)
        Me.Pan_prov.Controls.Add(Me.Txt_desc)
        Me.Pan_prov.Controls.Add(Me.Txt_mod)
        Me.Pan_prov.Controls.Add(Me.Txt_marca)
        Me.Pan_prov.Controls.Add(Me.Txt_codbar)
        Me.Pan_prov.Controls.Add(Me.Lbl_telp)
        Me.Pan_prov.Controls.Add(Me.Lb_cpp)
        Me.Pan_prov.Controls.Add(Me.Lbl_ciudadp)
        Me.Pan_prov.Controls.Add(Me.lbl_colp)
        Me.Pan_prov.Controls.Add(Me.Lb_direccionp)
        Me.Pan_prov.Controls.Add(Me.Lb_nomp)
        Me.Pan_prov.Location = New System.Drawing.Point(45, 6)
        Me.Pan_prov.Name = "Pan_prov"
        Me.Pan_prov.Size = New System.Drawing.Size(477, 247)
        Me.Pan_prov.TabIndex = 30
        '
        'Cbo_Pres
        '
        Me.Cbo_Pres.FormattingEnabled = True
        Me.Cbo_Pres.Location = New System.Drawing.Point(131, 147)
        Me.Cbo_Pres.Name = "Cbo_Pres"
        Me.Cbo_Pres.Size = New System.Drawing.Size(113, 21)
        Me.Cbo_Pres.TabIndex = 16
        '
        'Txt_Cto
        '
        Me.Txt_Cto.Location = New System.Drawing.Point(131, 184)
        Me.Txt_Cto.Name = "Txt_Cto"
        Me.Txt_Cto.Size = New System.Drawing.Size(113, 20)
        Me.Txt_Cto.TabIndex = 6
        '
        'Txt_desc
        '
        Me.Txt_desc.Location = New System.Drawing.Point(131, 114)
        Me.Txt_desc.Name = "Txt_desc"
        Me.Txt_desc.Size = New System.Drawing.Size(332, 20)
        Me.Txt_desc.TabIndex = 4
        '
        'Txt_mod
        '
        Me.Txt_mod.Location = New System.Drawing.Point(131, 78)
        Me.Txt_mod.Name = "Txt_mod"
        Me.Txt_mod.Size = New System.Drawing.Size(332, 20)
        Me.Txt_mod.TabIndex = 3
        '
        'Txt_marca
        '
        Me.Txt_marca.Location = New System.Drawing.Point(131, 43)
        Me.Txt_marca.Name = "Txt_marca"
        Me.Txt_marca.Size = New System.Drawing.Size(332, 20)
        Me.Txt_marca.TabIndex = 2
        '
        'Txt_codbar
        '
        Me.Txt_codbar.Location = New System.Drawing.Point(131, 8)
        Me.Txt_codbar.Name = "Txt_codbar"
        Me.Txt_codbar.Size = New System.Drawing.Size(332, 20)
        Me.Txt_codbar.TabIndex = 1
        '
        'Lbl_telp
        '
        Me.Lbl_telp.AutoSize = True
        Me.Lbl_telp.Location = New System.Drawing.Point(13, 191)
        Me.Lbl_telp.Name = "Lbl_telp"
        Me.Lbl_telp.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_telp.TabIndex = 15
        Me.Lbl_telp.Text = "Costo unitario:"
        '
        'Lb_cpp
        '
        Me.Lb_cpp.AutoSize = True
        Me.Lb_cpp.Location = New System.Drawing.Point(13, 156)
        Me.Lb_cpp.Name = "Lb_cpp"
        Me.Lb_cpp.Size = New System.Drawing.Size(69, 13)
        Me.Lb_cpp.TabIndex = 14
        Me.Lb_cpp.Text = "Presentación"
        '
        'Lbl_ciudadp
        '
        Me.Lbl_ciudadp.AutoSize = True
        Me.Lbl_ciudadp.Location = New System.Drawing.Point(13, 121)
        Me.Lbl_ciudadp.Name = "Lbl_ciudadp"
        Me.Lbl_ciudadp.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_ciudadp.TabIndex = 13
        Me.Lbl_ciudadp.Text = "Descripción:"
        '
        'lbl_colp
        '
        Me.lbl_colp.AutoSize = True
        Me.lbl_colp.Location = New System.Drawing.Point(13, 85)
        Me.lbl_colp.Name = "lbl_colp"
        Me.lbl_colp.Size = New System.Drawing.Size(45, 13)
        Me.lbl_colp.TabIndex = 12
        Me.lbl_colp.Text = "Modelo:"
        '
        'Lb_direccionp
        '
        Me.Lb_direccionp.AutoSize = True
        Me.Lb_direccionp.Location = New System.Drawing.Point(13, 46)
        Me.Lb_direccionp.Name = "Lb_direccionp"
        Me.Lb_direccionp.Size = New System.Drawing.Size(40, 13)
        Me.Lb_direccionp.TabIndex = 11
        Me.Lb_direccionp.Text = "Marca:"
        '
        'Lb_nomp
        '
        Me.Lb_nomp.AutoSize = True
        Me.Lb_nomp.Location = New System.Drawing.Point(13, 16)
        Me.Lb_nomp.Name = "Lb_nomp"
        Me.Lb_nomp.Size = New System.Drawing.Size(90, 13)
        Me.Lb_nomp.TabIndex = 10
        Me.Lb_nomp.Text = "Código de barras:"
        '
        'Btn_cancelarp
        '
        Me.Btn_cancelarp.Location = New System.Drawing.Point(45, 268)
        Me.Btn_cancelarp.Name = "Btn_cancelarp"
        Me.Btn_cancelarp.Size = New System.Drawing.Size(109, 23)
        Me.Btn_cancelarp.TabIndex = 9
        Me.Btn_cancelarp.Text = "Cancelar/Limpiar"
        Me.Btn_cancelarp.UseVisualStyleBackColor = True
        '
        'Btn_agregarp
        '
        Me.Btn_agregarp.Location = New System.Drawing.Point(447, 268)
        Me.Btn_agregarp.Name = "Btn_agregarp"
        Me.Btn_agregarp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregarp.TabIndex = 8
        Me.Btn_agregarp.Text = "Agregar"
        Me.Btn_agregarp.UseVisualStyleBackColor = True
        '
        'TabEditCatProv
        '
        Me.TabEditCatProv.Controls.Add(Me.Button1)
        Me.TabEditCatProv.Controls.Add(Me.TextBox1)
        Me.TabEditCatProv.Controls.Add(Me.Label4)
        Me.TabEditCatProv.Controls.Add(Me.DGV_Edit_CP)
        Me.TabEditCatProv.Location = New System.Drawing.Point(4, 22)
        Me.TabEditCatProv.Name = "TabEditCatProv"
        Me.TabEditCatProv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditCatProv.Size = New System.Drawing.Size(801, 304)
        Me.TabEditCatProv.TabIndex = 2
        Me.TabEditCatProv.Text = "Editar"
        Me.TabEditCatProv.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(692, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 29)
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
        Me.DGV_Edit_CP.Location = New System.Drawing.Point(6, 57)
        Me.DGV_Edit_CP.Name = "DGV_Edit_CP"
        Me.DGV_Edit_CP.Size = New System.Drawing.Size(792, 241)
        Me.DGV_Edit_CP.TabIndex = 1
        '
        'Catprod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 354)
        Me.Controls.Add(Me.Tab_proveedor)
        Me.Name = "Catprod"
        Me.Text = "Catprod"
        Me.Tab_proveedor.ResumeLayout(False)
        Me.Tab_cons_p.ResumeLayout(False)
        Me.Tab_cons_p.PerformLayout()
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_alta_p.ResumeLayout(False)
        Me.Pan_prov.ResumeLayout(False)
        Me.Pan_prov.PerformLayout()
        Me.TabEditCatProv.ResumeLayout(False)
        Me.TabEditCatProv.PerformLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_proveedor As System.Windows.Forms.TabControl
    Friend WithEvents Tab_cons_p As System.Windows.Forms.TabPage
    Friend WithEvents Tab_alta_p As System.Windows.Forms.TabPage
    Friend WithEvents Pan_prov As System.Windows.Forms.Panel
    Friend WithEvents Txt_Cto As System.Windows.Forms.TextBox
    Friend WithEvents Txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_mod As System.Windows.Forms.TextBox
    Friend WithEvents Txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents Txt_codbar As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_telp As System.Windows.Forms.Label
    Friend WithEvents Lb_cpp As System.Windows.Forms.Label
    Friend WithEvents Lbl_ciudadp As System.Windows.Forms.Label
    Friend WithEvents lbl_colp As System.Windows.Forms.Label
    Friend WithEvents Lb_direccionp As System.Windows.Forms.Label
    Friend WithEvents Lb_nomp As System.Windows.Forms.Label
    Friend WithEvents Btn_cancelarp As System.Windows.Forms.Button
    Friend WithEvents Btn_agregarp As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVcatprov As System.Windows.Forms.DataGridView
    Friend WithEvents TabEditCatProv As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV_Edit_CP As System.Windows.Forms.DataGridView
    Friend WithEvents Cbo_Pres As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_filtro As System.Windows.Forms.Button
End Class
