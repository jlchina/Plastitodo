<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcaCons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarcaCons))
        Me.dgv_marcas = New System.Windows.Forms.DataGridView()
        Me.btn_nvamarca = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        CType(Me.dgv_marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_marcas
        '
        Me.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_marcas.Location = New System.Drawing.Point(18, 85)
        Me.dgv_marcas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_marcas.Name = "dgv_marcas"
        Me.dgv_marcas.Size = New System.Drawing.Size(508, 334)
        Me.dgv_marcas.TabIndex = 0
        '
        'btn_nvamarca
        '
        Me.btn_nvamarca.BackColor = System.Drawing.Color.Transparent
        Me.btn_nvamarca.BackgroundImage = CType(resources.GetObject("btn_nvamarca.BackgroundImage"), System.Drawing.Image)
        Me.btn_nvamarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nvamarca.Location = New System.Drawing.Point(20, 13)
        Me.btn_nvamarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nvamarca.Name = "btn_nvamarca"
        Me.btn_nvamarca.Size = New System.Drawing.Size(55, 49)
        Me.btn_nvamarca.TabIndex = 1
        Me.btn_nvamarca.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Actualizar.BackgroundImage = CType(resources.GetObject("Btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Actualizar.Location = New System.Drawing.Point(463, 13)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(63, 49)
        Me.Btn_Actualizar.TabIndex = 2
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'MarcaCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 433)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.btn_nvamarca)
        Me.Controls.Add(Me.dgv_marcas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 472)
        Me.Name = "MarcaCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de marcas"
        CType(Me.dgv_marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_marcas As DataGridView
    Friend WithEvents btn_nvamarca As Button
    Friend WithEvents Btn_Actualizar As Button
End Class
