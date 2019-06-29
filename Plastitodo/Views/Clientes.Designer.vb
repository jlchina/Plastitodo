<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.TabClientes = New System.Windows.Forms.TabControl()
        Me.Tab_consulta = New System.Windows.Forms.TabPage()
        Me.Tab_alta = New System.Windows.Forms.TabPage()
        Me.Lb_nom_cte = New System.Windows.Forms.Label()
        Me.Lb_direccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabClientes.SuspendLayout()
        Me.Tab_consulta.SuspendLayout()
        Me.Tab_alta.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabClientes
        '
        Me.TabClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabClientes.Controls.Add(Me.Tab_consulta)
        Me.TabClientes.Controls.Add(Me.Tab_alta)
        Me.TabClientes.Location = New System.Drawing.Point(12, 12)
        Me.TabClientes.Name = "TabClientes"
        Me.TabClientes.SelectedIndex = 0
        Me.TabClientes.Size = New System.Drawing.Size(552, 315)
        Me.TabClientes.TabIndex = 0
        '
        'Tab_consulta
        '
        Me.Tab_consulta.Controls.Add(Me.DataGridView1)
        Me.Tab_consulta.Location = New System.Drawing.Point(4, 22)
        Me.Tab_consulta.Name = "Tab_consulta"
        Me.Tab_consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_consulta.Size = New System.Drawing.Size(544, 289)
        Me.Tab_consulta.TabIndex = 0
        Me.Tab_consulta.Text = "Consulta"
        Me.Tab_consulta.UseVisualStyleBackColor = True
        '
        'Tab_alta
        '
        Me.Tab_alta.Controls.Add(Me.TextBox7)
        Me.Tab_alta.Controls.Add(Me.TextBox6)
        Me.Tab_alta.Controls.Add(Me.TextBox5)
        Me.Tab_alta.Controls.Add(Me.TextBox4)
        Me.Tab_alta.Controls.Add(Me.TextBox3)
        Me.Tab_alta.Controls.Add(Me.TextBox2)
        Me.Tab_alta.Controls.Add(Me.TextBox1)
        Me.Tab_alta.Controls.Add(Me.Label5)
        Me.Tab_alta.Controls.Add(Me.Label4)
        Me.Tab_alta.Controls.Add(Me.Label3)
        Me.Tab_alta.Controls.Add(Me.Label2)
        Me.Tab_alta.Controls.Add(Me.Label1)
        Me.Tab_alta.Controls.Add(Me.Lb_direccion)
        Me.Tab_alta.Controls.Add(Me.Lb_nom_cte)
        Me.Tab_alta.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alta.Name = "Tab_alta"
        Me.Tab_alta.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta.Size = New System.Drawing.Size(544, 289)
        Me.Tab_alta.TabIndex = 1
        Me.Tab_alta.Text = "Alta"
        Me.Tab_alta.UseVisualStyleBackColor = True
        '
        'Lb_nom_cte
        '
        Me.Lb_nom_cte.AutoSize = True
        Me.Lb_nom_cte.Location = New System.Drawing.Point(35, 55)
        Me.Lb_nom_cte.Name = "Lb_nom_cte"
        Me.Lb_nom_cte.Size = New System.Drawing.Size(96, 13)
        Me.Lb_nom_cte.TabIndex = 0
        Me.Lb_nom_cte.Text = "Nombre de cliente:"
        '
        'Lb_direccion
        '
        Me.Lb_direccion.AutoSize = True
        Me.Lb_direccion.Location = New System.Drawing.Point(35, 85)
        Me.Lb_direccion.Name = "Lb_direccion"
        Me.Lb_direccion.Size = New System.Drawing.Size(55, 13)
        Me.Lb_direccion.TabIndex = 1
        Me.Lb_direccion.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Colonia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C.P."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Correo electrónico:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(332, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(332, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(153, 117)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(332, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(153, 153)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(332, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(153, 188)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(153, 223)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(113, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(153, 258)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(332, 20)
        Me.TextBox7.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(532, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 339)
        Me.Controls.Add(Me.TabClientes)
        Me.Name = "Clientes"
        Me.Text = "Catálogo de clientes"
        Me.TabClientes.ResumeLayout(False)
        Me.Tab_consulta.ResumeLayout(False)
        Me.Tab_alta.ResumeLayout(False)
        Me.Tab_alta.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabClientes As System.Windows.Forms.TabControl
    Friend WithEvents Tab_consulta As System.Windows.Forms.TabPage
    Friend WithEvents Tab_alta As System.Windows.Forms.TabPage
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
