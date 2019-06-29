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
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_direccion = New System.Windows.Forms.Label()
        Me.Lb_nom_cte = New System.Windows.Forms.Label()
        Me.Tab_proveedor.SuspendLayout()
        Me.Tab_cons_p.SuspendLayout()
        Me.Tab_alta_p.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab_proveedor.Size = New System.Drawing.Size(563, 286)
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
        Me.Tab_alta_p.Controls.Add(Me.TextBox7)
        Me.Tab_alta_p.Controls.Add(Me.TextBox6)
        Me.Tab_alta_p.Controls.Add(Me.TextBox5)
        Me.Tab_alta_p.Controls.Add(Me.TextBox4)
        Me.Tab_alta_p.Controls.Add(Me.TextBox3)
        Me.Tab_alta_p.Controls.Add(Me.TextBox2)
        Me.Tab_alta_p.Controls.Add(Me.TextBox1)
        Me.Tab_alta_p.Controls.Add(Me.Label5)
        Me.Tab_alta_p.Controls.Add(Me.Label4)
        Me.Tab_alta_p.Controls.Add(Me.Label3)
        Me.Tab_alta_p.Controls.Add(Me.Label2)
        Me.Tab_alta_p.Controls.Add(Me.Label1)
        Me.Tab_alta_p.Controls.Add(Me.Lb_direccion)
        Me.Tab_alta_p.Controls.Add(Me.Lb_nom_cte)
        Me.Tab_alta_p.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alta_p.Name = "Tab_alta_p"
        Me.Tab_alta_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta_p.Size = New System.Drawing.Size(555, 260)
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
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(170, 226)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(332, 20)
        Me.TextBox7.TabIndex = 27
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(170, 191)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(113, 20)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(170, 156)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 20)
        Me.TextBox5.TabIndex = 25
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(170, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(332, 20)
        Me.TextBox4.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(170, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(332, 20)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(170, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(332, 20)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(332, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Correo electrónico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "C.P."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ciudad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Colonia:"
        '
        'Lb_direccion
        '
        Me.Lb_direccion.AutoSize = True
        Me.Lb_direccion.Location = New System.Drawing.Point(52, 53)
        Me.Lb_direccion.Name = "Lb_direccion"
        Me.Lb_direccion.Size = New System.Drawing.Size(55, 13)
        Me.Lb_direccion.TabIndex = 15
        Me.Lb_direccion.Text = "Dirección:"
        '
        'Lb_nom_cte
        '
        Me.Lb_nom_cte.AutoSize = True
        Me.Lb_nom_cte.Location = New System.Drawing.Point(52, 23)
        Me.Lb_nom_cte.Name = "Lb_nom_cte"
        Me.Lb_nom_cte.Size = New System.Drawing.Size(96, 13)
        Me.Lb_nom_cte.TabIndex = 14
        Me.Lb_nom_cte.Text = "Nombre de cliente:"
        '
        'Cat_Prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 307)
        Me.Controls.Add(Me.Tab_proveedor)
        Me.Name = "Cat_Prov"
        Me.Text = "Cat_Prov"
        Me.Tab_proveedor.ResumeLayout(False)
        Me.Tab_cons_p.ResumeLayout(False)
        Me.Tab_alta_p.ResumeLayout(False)
        Me.Tab_alta_p.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_proveedor As System.Windows.Forms.TabControl
    Friend WithEvents Tab_cons_p As System.Windows.Forms.TabPage
    Friend WithEvents Tab_alta_p As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lb_direccion As System.Windows.Forms.Label
    Friend WithEvents Lb_nom_cte As System.Windows.Forms.Label
End Class
