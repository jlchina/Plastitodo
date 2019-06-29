<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Prov
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
        Me.Tab_alta_p = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_agregarp = New System.Windows.Forms.Button()
        Me.Btn_cancelarp = New System.Windows.Forms.Button()
        Me.Pan_prov = New System.Windows.Forms.Panel()
        Me.Txt_mailprov = New System.Windows.Forms.TextBox()
        Me.Txt_telprov = New System.Windows.Forms.TextBox()
        Me.Txt_cp_prov = New System.Windows.Forms.TextBox()
        Me.Txt_ciudadprov = New System.Windows.Forms.TextBox()
        Me.Txt_colprov = New System.Windows.Forms.TextBox()
        Me.Txt_dirprov = New System.Windows.Forms.TextBox()
        Me.Txt_nomprov = New System.Windows.Forms.TextBox()
        Me.Lbl_mailp = New System.Windows.Forms.Label()
        Me.Lbl_telp = New System.Windows.Forms.Label()
        Me.Lb_cpp = New System.Windows.Forms.Label()
        Me.Lbl_ciudadp = New System.Windows.Forms.Label()
        Me.lbl_colp = New System.Windows.Forms.Label()
        Me.Lb_direccionp = New System.Windows.Forms.Label()
        Me.Lb_nomp = New System.Windows.Forms.Label()
        Me.Tab_proveedor.SuspendLayout()
        Me.Tab_cons_p.SuspendLayout()
        Me.Tab_alta_p.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_prov.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_proveedor
        '
        Me.Tab_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_proveedor.Controls.Add(Me.Tab_cons_p)
        Me.Tab_proveedor.Controls.Add(Me.Tab_alta_p)
        Me.Tab_proveedor.Location = New System.Drawing.Point(12, 21)
        Me.Tab_proveedor.Name = "Tab_proveedor"
        Me.Tab_proveedor.SelectedIndex = 0
        Me.Tab_proveedor.Size = New System.Drawing.Size(563, 332)
        Me.Tab_proveedor.TabIndex = 0
        '
        'Tab_cons_p
        '
        Me.Tab_cons_p.Controls.Add(Me.DataGridView1)
        Me.Tab_cons_p.Location = New System.Drawing.Point(4, 22)
        Me.Tab_cons_p.Name = "Tab_cons_p"
        Me.Tab_cons_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_cons_p.Size = New System.Drawing.Size(555, 260)
        Me.Tab_cons_p.TabIndex = 0
        Me.Tab_cons_p.Text = "Consulta"
        Me.Tab_cons_p.UseVisualStyleBackColor = True
        '
        'Tab_alta_p
        '
        Me.Tab_alta_p.Controls.Add(Me.Pan_prov)
        Me.Tab_alta_p.Controls.Add(Me.Btn_cancelarp)
        Me.Tab_alta_p.Controls.Add(Me.Btn_agregarp)
        Me.Tab_alta_p.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alta_p.Name = "Tab_alta_p"
        Me.Tab_alta_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta_p.Size = New System.Drawing.Size(555, 306)
        Me.Tab_alta_p.TabIndex = 1
        Me.Tab_alta_p.Text = "Alta"
        Me.Tab_alta_p.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'Btn_agregarp
        '
        Me.Btn_agregarp.Location = New System.Drawing.Point(447, 268)
        Me.Btn_agregarp.Name = "Btn_agregarp"
        Me.Btn_agregarp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregarp.TabIndex = 28
        Me.Btn_agregarp.Text = "Agregar"
        Me.Btn_agregarp.UseVisualStyleBackColor = True
        '
        'Btn_cancelarp
        '
        Me.Btn_cancelarp.Location = New System.Drawing.Point(45, 268)
        Me.Btn_cancelarp.Name = "Btn_cancelarp"
        Me.Btn_cancelarp.Size = New System.Drawing.Size(109, 23)
        Me.Btn_cancelarp.TabIndex = 29
        Me.Btn_cancelarp.Text = "Cancelar/Limpiar"
        Me.Btn_cancelarp.UseVisualStyleBackColor = True
        '
        'Pan_prov
        '
        Me.Pan_prov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_prov.Controls.Add(Me.Txt_mailprov)
        Me.Pan_prov.Controls.Add(Me.Txt_telprov)
        Me.Pan_prov.Controls.Add(Me.Txt_cp_prov)
        Me.Pan_prov.Controls.Add(Me.Txt_ciudadprov)
        Me.Pan_prov.Controls.Add(Me.Txt_colprov)
        Me.Pan_prov.Controls.Add(Me.Txt_dirprov)
        Me.Pan_prov.Controls.Add(Me.Txt_nomprov)
        Me.Pan_prov.Controls.Add(Me.Lbl_mailp)
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
        'Txt_mailprov
        '
        Me.Txt_mailprov.Location = New System.Drawing.Point(131, 219)
        Me.Txt_mailprov.Name = "Txt_mailprov"
        Me.Txt_mailprov.Size = New System.Drawing.Size(332, 20)
        Me.Txt_mailprov.TabIndex = 41
        '
        'Txt_telprov
        '
        Me.Txt_telprov.Location = New System.Drawing.Point(131, 184)
        Me.Txt_telprov.Name = "Txt_telprov"
        Me.Txt_telprov.Size = New System.Drawing.Size(113, 20)
        Me.Txt_telprov.TabIndex = 40
        '
        'Txt_cp_prov
        '
        Me.Txt_cp_prov.Location = New System.Drawing.Point(131, 149)
        Me.Txt_cp_prov.Name = "Txt_cp_prov"
        Me.Txt_cp_prov.Size = New System.Drawing.Size(113, 20)
        Me.Txt_cp_prov.TabIndex = 39
        '
        'Txt_ciudadprov
        '
        Me.Txt_ciudadprov.Location = New System.Drawing.Point(131, 114)
        Me.Txt_ciudadprov.Name = "Txt_ciudadprov"
        Me.Txt_ciudadprov.Size = New System.Drawing.Size(332, 20)
        Me.Txt_ciudadprov.TabIndex = 38
        '
        'Txt_colprov
        '
        Me.Txt_colprov.Location = New System.Drawing.Point(131, 78)
        Me.Txt_colprov.Name = "Txt_colprov"
        Me.Txt_colprov.Size = New System.Drawing.Size(332, 20)
        Me.Txt_colprov.TabIndex = 37
        '
        'Txt_dirprov
        '
        Me.Txt_dirprov.Location = New System.Drawing.Point(131, 43)
        Me.Txt_dirprov.Name = "Txt_dirprov"
        Me.Txt_dirprov.Size = New System.Drawing.Size(332, 20)
        Me.Txt_dirprov.TabIndex = 36
        '
        'Txt_nomprov
        '
        Me.Txt_nomprov.Location = New System.Drawing.Point(131, 8)
        Me.Txt_nomprov.Name = "Txt_nomprov"
        Me.Txt_nomprov.Size = New System.Drawing.Size(332, 20)
        Me.Txt_nomprov.TabIndex = 35
        '
        'Lbl_mailp
        '
        Me.Lbl_mailp.AutoSize = True
        Me.Lbl_mailp.Location = New System.Drawing.Point(13, 226)
        Me.Lbl_mailp.Name = "Lbl_mailp"
        Me.Lbl_mailp.Size = New System.Drawing.Size(96, 13)
        Me.Lbl_mailp.TabIndex = 34
        Me.Lbl_mailp.Text = "Correo electrónico:"
        '
        'Lbl_telp
        '
        Me.Lbl_telp.AutoSize = True
        Me.Lbl_telp.Location = New System.Drawing.Point(13, 191)
        Me.Lbl_telp.Name = "Lbl_telp"
        Me.Lbl_telp.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_telp.TabIndex = 33
        Me.Lbl_telp.Text = "Telefono:"
        '
        'Lb_cpp
        '
        Me.Lb_cpp.AutoSize = True
        Me.Lb_cpp.Location = New System.Drawing.Point(13, 156)
        Me.Lb_cpp.Name = "Lb_cpp"
        Me.Lb_cpp.Size = New System.Drawing.Size(27, 13)
        Me.Lb_cpp.TabIndex = 32
        Me.Lb_cpp.Text = "C.P."
        '
        'Lbl_ciudadp
        '
        Me.Lbl_ciudadp.AutoSize = True
        Me.Lbl_ciudadp.Location = New System.Drawing.Point(13, 121)
        Me.Lbl_ciudadp.Name = "Lbl_ciudadp"
        Me.Lbl_ciudadp.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_ciudadp.TabIndex = 31
        Me.Lbl_ciudadp.Text = "Ciudad:"
        '
        'lbl_colp
        '
        Me.lbl_colp.AutoSize = True
        Me.lbl_colp.Location = New System.Drawing.Point(13, 85)
        Me.lbl_colp.Name = "lbl_colp"
        Me.lbl_colp.Size = New System.Drawing.Size(45, 13)
        Me.lbl_colp.TabIndex = 30
        Me.lbl_colp.Text = "Colonia:"
        '
        'Lb_direccionp
        '
        Me.Lb_direccionp.AutoSize = True
        Me.Lb_direccionp.Location = New System.Drawing.Point(13, 46)
        Me.Lb_direccionp.Name = "Lb_direccionp"
        Me.Lb_direccionp.Size = New System.Drawing.Size(55, 13)
        Me.Lb_direccionp.TabIndex = 29
        Me.Lb_direccionp.Text = "Dirección:"
        '
        'Lb_nomp
        '
        Me.Lb_nomp.AutoSize = True
        Me.Lb_nomp.Location = New System.Drawing.Point(13, 16)
        Me.Lb_nomp.Name = "Lb_nomp"
        Me.Lb_nomp.Size = New System.Drawing.Size(96, 13)
        Me.Lb_nomp.TabIndex = 28
        Me.Lb_nomp.Text = "Nombre de cliente:"
        '
        'Cat_Prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 353)
        Me.Controls.Add(Me.Tab_proveedor)
        Me.Name = "Cat_Prov"
        Me.Text = "Cat_Prov"
        Me.Tab_proveedor.ResumeLayout(False)
        Me.Tab_cons_p.ResumeLayout(False)
        Me.Tab_alta_p.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_prov.ResumeLayout(False)
        Me.Pan_prov.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_proveedor As System.Windows.Forms.TabControl
    Friend WithEvents Tab_cons_p As System.Windows.Forms.TabPage
    Friend WithEvents Tab_alta_p As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_cancelarp As System.Windows.Forms.Button
    Friend WithEvents Btn_agregarp As System.Windows.Forms.Button
    Friend WithEvents Pan_prov As System.Windows.Forms.Panel
    Friend WithEvents Txt_mailprov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_telprov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cp_prov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ciudadprov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_colprov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_dirprov As System.Windows.Forms.TextBox
    Friend WithEvents Txt_nomprov As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_mailp As System.Windows.Forms.Label
    Friend WithEvents Lbl_telp As System.Windows.Forms.Label
    Friend WithEvents Lb_cpp As System.Windows.Forms.Label
    Friend WithEvents Lbl_ciudadp As System.Windows.Forms.Label
    Friend WithEvents lbl_colp As System.Windows.Forms.Label
    Friend WithEvents Lb_direccionp As System.Windows.Forms.Label
    Friend WithEvents Lb_nomp As System.Windows.Forms.Label
End Class
