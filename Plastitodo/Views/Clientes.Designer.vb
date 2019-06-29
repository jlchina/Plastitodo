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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_cancelarp = New System.Windows.Forms.Button()
        Me.Btn_agregarp = New System.Windows.Forms.Button()
        Me.Panel_prov = New System.Windows.Forms.Panel()
        Me.Txt_mailc = New System.Windows.Forms.TextBox()
        Me.Txt_telc = New System.Windows.Forms.TextBox()
        Me.Txt_cpc = New System.Windows.Forms.TextBox()
        Me.Txt_ciudadc = New System.Windows.Forms.TextBox()
        Me.Txt_colc = New System.Windows.Forms.TextBox()
        Me.Txt_dirc = New System.Windows.Forms.TextBox()
        Me.txt_nomc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_direccion = New System.Windows.Forms.Label()
        Me.Lb_nom_cte = New System.Windows.Forms.Label()
        Me.TabClientes.SuspendLayout()
        Me.Tab_consulta.SuspendLayout()
        Me.Tab_alta.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_prov.SuspendLayout()
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
        Me.TabClientes.Size = New System.Drawing.Size(575, 349)
        Me.TabClientes.TabIndex = 0
        '
        'Tab_consulta
        '
        Me.Tab_consulta.Controls.Add(Me.DataGridView1)
        Me.Tab_consulta.Location = New System.Drawing.Point(4, 22)
        Me.Tab_consulta.Name = "Tab_consulta"
        Me.Tab_consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_consulta.Size = New System.Drawing.Size(567, 323)
        Me.Tab_consulta.TabIndex = 0
        Me.Tab_consulta.Text = "Consulta"
        Me.Tab_consulta.UseVisualStyleBackColor = True
        '
        'Tab_alta
        '
        Me.Tab_alta.Controls.Add(Me.Panel_prov)
        Me.Tab_alta.Controls.Add(Me.Btn_cancelarp)
        Me.Tab_alta.Controls.Add(Me.Btn_agregarp)
        Me.Tab_alta.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alta.Name = "Tab_alta"
        Me.Tab_alta.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta.Size = New System.Drawing.Size(567, 323)
        Me.Tab_alta.TabIndex = 1
        Me.Tab_alta.Text = "Alta"
        Me.Tab_alta.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(555, 287)
        Me.DataGridView1.TabIndex = 0
        '
        'Btn_cancelarp
        '
        Me.Btn_cancelarp.Location = New System.Drawing.Point(38, 296)
        Me.Btn_cancelarp.Name = "Btn_cancelarp"
        Me.Btn_cancelarp.Size = New System.Drawing.Size(105, 23)
        Me.Btn_cancelarp.TabIndex = 9
        Me.Btn_cancelarp.Text = "Cancelar/Limpiar"
        Me.Btn_cancelarp.UseVisualStyleBackColor = True
        '
        'Btn_agregarp
        '
        Me.Btn_agregarp.Location = New System.Drawing.Point(463, 294)
        Me.Btn_agregarp.Name = "Btn_agregarp"
        Me.Btn_agregarp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregarp.TabIndex = 8
        Me.Btn_agregarp.Text = "Agregar"
        Me.Btn_agregarp.UseVisualStyleBackColor = True
        '
        'Panel_prov
        '
        Me.Panel_prov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_prov.Controls.Add(Me.Txt_mailc)
        Me.Panel_prov.Controls.Add(Me.Txt_telc)
        Me.Panel_prov.Controls.Add(Me.Txt_cpc)
        Me.Panel_prov.Controls.Add(Me.Txt_ciudadc)
        Me.Panel_prov.Controls.Add(Me.Txt_colc)
        Me.Panel_prov.Controls.Add(Me.Txt_dirc)
        Me.Panel_prov.Controls.Add(Me.txt_nomc)
        Me.Panel_prov.Controls.Add(Me.Label5)
        Me.Panel_prov.Controls.Add(Me.Label4)
        Me.Panel_prov.Controls.Add(Me.Label3)
        Me.Panel_prov.Controls.Add(Me.Label2)
        Me.Panel_prov.Controls.Add(Me.Label1)
        Me.Panel_prov.Controls.Add(Me.Lb_direccion)
        Me.Panel_prov.Controls.Add(Me.Lb_nom_cte)
        Me.Panel_prov.Location = New System.Drawing.Point(38, 6)
        Me.Panel_prov.Name = "Panel_prov"
        Me.Panel_prov.Size = New System.Drawing.Size(500, 261)
        Me.Panel_prov.TabIndex = 32
        '
        'Txt_mailc
        '
        Me.Txt_mailc.Location = New System.Drawing.Point(143, 226)
        Me.Txt_mailc.Name = "Txt_mailc"
        Me.Txt_mailc.Size = New System.Drawing.Size(332, 20)
        Me.Txt_mailc.TabIndex = 7
        '
        'Txt_telc
        '
        Me.Txt_telc.Location = New System.Drawing.Point(143, 191)
        Me.Txt_telc.Name = "Txt_telc"
        Me.Txt_telc.Size = New System.Drawing.Size(113, 20)
        Me.Txt_telc.TabIndex = 6
        '
        'Txt_cpc
        '
        Me.Txt_cpc.Location = New System.Drawing.Point(143, 156)
        Me.Txt_cpc.Name = "Txt_cpc"
        Me.Txt_cpc.Size = New System.Drawing.Size(113, 20)
        Me.Txt_cpc.TabIndex = 5
        '
        'Txt_ciudadc
        '
        Me.Txt_ciudadc.Location = New System.Drawing.Point(143, 121)
        Me.Txt_ciudadc.Name = "Txt_ciudadc"
        Me.Txt_ciudadc.Size = New System.Drawing.Size(332, 20)
        Me.Txt_ciudadc.TabIndex = 4
        '
        'Txt_colc
        '
        Me.Txt_colc.Location = New System.Drawing.Point(143, 85)
        Me.Txt_colc.Name = "Txt_colc"
        Me.Txt_colc.Size = New System.Drawing.Size(332, 20)
        Me.Txt_colc.TabIndex = 3
        '
        'Txt_dirc
        '
        Me.Txt_dirc.Location = New System.Drawing.Point(143, 50)
        Me.Txt_dirc.Name = "Txt_dirc"
        Me.Txt_dirc.Size = New System.Drawing.Size(332, 20)
        Me.Txt_dirc.TabIndex = 2
        '
        'txt_nomc
        '
        Me.txt_nomc.Location = New System.Drawing.Point(143, 15)
        Me.txt_nomc.Name = "txt_nomc"
        Me.txt_nomc.Size = New System.Drawing.Size(332, 20)
        Me.txt_nomc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Correo electrónico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "C.P."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ciudad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Colonia:"
        '
        'Lb_direccion
        '
        Me.Lb_direccion.AutoSize = True
        Me.Lb_direccion.Location = New System.Drawing.Point(25, 53)
        Me.Lb_direccion.Name = "Lb_direccion"
        Me.Lb_direccion.Size = New System.Drawing.Size(55, 13)
        Me.Lb_direccion.TabIndex = 11
        Me.Lb_direccion.Text = "Dirección:"
        '
        'Lb_nom_cte
        '
        Me.Lb_nom_cte.AutoSize = True
        Me.Lb_nom_cte.Location = New System.Drawing.Point(25, 23)
        Me.Lb_nom_cte.Name = "Lb_nom_cte"
        Me.Lb_nom_cte.Size = New System.Drawing.Size(96, 13)
        Me.Lb_nom_cte.TabIndex = 10
        Me.Lb_nom_cte.Text = "Nombre de cliente:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 373)
        Me.Controls.Add(Me.TabClientes)
        Me.Name = "Clientes"
        Me.Text = "Catálogo de clientes"
        Me.TabClientes.ResumeLayout(False)
        Me.Tab_consulta.ResumeLayout(False)
        Me.Tab_alta.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_prov.ResumeLayout(False)
        Me.Panel_prov.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabClientes As System.Windows.Forms.TabControl
    Friend WithEvents Tab_consulta As System.Windows.Forms.TabPage
    Friend WithEvents Tab_alta As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_cancelarp As System.Windows.Forms.Button
    Friend WithEvents Btn_agregarp As System.Windows.Forms.Button
    Friend WithEvents Panel_prov As System.Windows.Forms.Panel
    Friend WithEvents Txt_mailc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_telc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cpc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ciudadc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_colc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_dirc As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lb_direccion As System.Windows.Forms.Label
    Friend WithEvents Lb_nom_cte As System.Windows.Forms.Label
End Class
