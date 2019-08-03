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
        Me.dgv_marcas = New System.Windows.Forms.DataGridView()
        Me.btn_nvamarca = New System.Windows.Forms.Button()
        CType(Me.dgv_marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_marcas
        '
        Me.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_marcas.Location = New System.Drawing.Point(12, 69)
        Me.dgv_marcas.Name = "dgv_marcas"
        Me.dgv_marcas.Size = New System.Drawing.Size(339, 271)
        Me.dgv_marcas.TabIndex = 0
        '
        'btn_nvamarca
        '
        Me.btn_nvamarca.Location = New System.Drawing.Point(13, 28)
        Me.btn_nvamarca.Name = "btn_nvamarca"
        Me.btn_nvamarca.Size = New System.Drawing.Size(75, 23)
        Me.btn_nvamarca.TabIndex = 1
        Me.btn_nvamarca.Text = "Crear Marca"
        Me.btn_nvamarca.UseVisualStyleBackColor = True
        '
        'MarcaCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 352)
        Me.Controls.Add(Me.btn_nvamarca)
        Me.Controls.Add(Me.dgv_marcas)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(379, 391)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(379, 391)
        Me.Name = "MarcaCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de marcas"
        CType(Me.dgv_marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_marcas As DataGridView
    Friend WithEvents btn_nvamarca As Button
End Class
