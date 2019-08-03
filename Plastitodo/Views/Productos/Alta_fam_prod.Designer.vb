<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_fam_prod
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_nomfam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descfam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Dgv_FamiliaProducto = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_FamiliaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(486, 302)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_guardar)
        Me.TabPage1.Controls.Add(Me.txt_nomfam)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_descfam)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(478, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(340, 219)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(91, 28)
        Me.btn_guardar.TabIndex = 9
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_nomfam
        '
        Me.txt_nomfam.Location = New System.Drawing.Point(191, 25)
        Me.txt_nomfam.Name = "txt_nomfam"
        Me.txt_nomfam.Size = New System.Drawing.Size(262, 20)
        Me.txt_nomfam.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Familia:"
        '
        'txt_descfam
        '
        Me.txt_descfam.Location = New System.Drawing.Point(191, 93)
        Me.txt_descfam.Name = "txt_descfam"
        Me.txt_descfam.Size = New System.Drawing.Size(262, 20)
        Me.txt_descfam.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Descripcion de la familia: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dgv_FamiliaProducto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(478, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar / Editar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Dgv_FamiliaProducto
        '
        Me.Dgv_FamiliaProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_FamiliaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_FamiliaProducto.Location = New System.Drawing.Point(3, 20)
        Me.Dgv_FamiliaProducto.Name = "Dgv_FamiliaProducto"
        Me.Dgv_FamiliaProducto.Size = New System.Drawing.Size(469, 253)
        Me.Dgv_FamiliaProducto.TabIndex = 0
        '
        'Alta_fam_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 301)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Alta_fam_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Familia de Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv_FamiliaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_nomfam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descfam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Dgv_FamiliaProducto As DataGridView
End Class
