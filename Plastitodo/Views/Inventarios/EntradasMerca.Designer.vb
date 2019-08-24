<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradasMerca
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
        Me.TEntradasMerca = New System.Windows.Forms.TabPage()
        Me.BBuscarCodigo = New System.Windows.Forms.Button()
        Me.TextBoxcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxdescrip = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxprovee = New System.Windows.Forms.ComboBox()
        Me.BGuardardetaentramerca = New System.Windows.Forms.Button()
        Me.Tcosto = New System.Windows.Forms.TextBox()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TEntradasMerca.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TEntradasMerca)
        Me.TabControl1.Location = New System.Drawing.Point(15, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(677, 357)
        Me.TabControl1.TabIndex = 1
        '
        'TEntradasMerca
        '
        Me.TEntradasMerca.Controls.Add(Me.BBuscarCodigo)
        Me.TEntradasMerca.Controls.Add(Me.TextBoxcodigo)
        Me.TEntradasMerca.Controls.Add(Me.Label1)
        Me.TEntradasMerca.Controls.Add(Me.DataGridView1)
        Me.TEntradasMerca.Controls.Add(Me.Label6)
        Me.TEntradasMerca.Controls.Add(Me.ComboBoxdescrip)
        Me.TEntradasMerca.Controls.Add(Me.Label5)
        Me.TEntradasMerca.Controls.Add(Me.ComboBoxprovee)
        Me.TEntradasMerca.Controls.Add(Me.BGuardardetaentramerca)
        Me.TEntradasMerca.Controls.Add(Me.Tcosto)
        Me.TEntradasMerca.Controls.Add(Me.Tcantidad)
        Me.TEntradasMerca.Controls.Add(Me.Label4)
        Me.TEntradasMerca.Controls.Add(Me.Label3)
        Me.TEntradasMerca.Location = New System.Drawing.Point(4, 22)
        Me.TEntradasMerca.Name = "TEntradasMerca"
        Me.TEntradasMerca.Padding = New System.Windows.Forms.Padding(3)
        Me.TEntradasMerca.Size = New System.Drawing.Size(669, 331)
        Me.TEntradasMerca.TabIndex = 0
        Me.TEntradasMerca.Text = "Entradas"
        Me.TEntradasMerca.UseVisualStyleBackColor = True
        '
        'BBuscarCodigo
        '
        Me.BBuscarCodigo.Location = New System.Drawing.Point(588, 106)
        Me.BBuscarCodigo.Name = "BBuscarCodigo"
        Me.BBuscarCodigo.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarCodigo.TabIndex = 15
        Me.BBuscarCodigo.Text = "Buscar"
        Me.BBuscarCodigo.UseVisualStyleBackColor = True
        '
        'TextBoxcodigo
        '
        Me.TextBoxcodigo.Location = New System.Drawing.Point(412, 18)
        Me.TextBoxcodigo.Name = "TextBoxcodigo"
        Me.TextBoxcodigo.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxcodigo.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo Barras"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Costo})
        Me.DataGridView1.Location = New System.Drawing.Point(34, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Producto"
        '
        'ComboBoxdescrip
        '
        Me.ComboBoxdescrip.FormattingEnabled = True
        Me.ComboBoxdescrip.Location = New System.Drawing.Point(412, 67)
        Me.ComboBoxdescrip.Name = "ComboBoxdescrip"
        Me.ComboBoxdescrip.Size = New System.Drawing.Size(238, 21)
        Me.ComboBoxdescrip.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedor"
        '
        'ComboBoxprovee
        '
        Me.ComboBoxprovee.FormattingEnabled = True
        Me.ComboBoxprovee.Location = New System.Drawing.Point(123, 17)
        Me.ComboBoxprovee.Name = "ComboBoxprovee"
        Me.ComboBoxprovee.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxprovee.TabIndex = 8
        '
        'BGuardardetaentramerca
        '
        Me.BGuardardetaentramerca.Location = New System.Drawing.Point(588, 270)
        Me.BGuardardetaentramerca.Name = "BGuardardetaentramerca"
        Me.BGuardardetaentramerca.Size = New System.Drawing.Size(75, 23)
        Me.BGuardardetaentramerca.TabIndex = 1
        Me.BGuardardetaentramerca.Text = "Guardar"
        Me.BGuardardetaentramerca.UseVisualStyleBackColor = True
        '
        'Tcosto
        '
        Me.Tcosto.Location = New System.Drawing.Point(412, 131)
        Me.Tcosto.Name = "Tcosto"
        Me.Tcosto.Size = New System.Drawing.Size(100, 20)
        Me.Tcosto.TabIndex = 7
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(123, 68)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(121, 20)
        Me.Tcantidad.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'EntradasMerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 394)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EntradasMerca"
        Me.Text = "Detalle de Entradas Mercancia"
        Me.TabControl1.ResumeLayout(False)
        Me.TEntradasMerca.ResumeLayout(False)
        Me.TEntradasMerca.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TEntradasMerca As TabPage
    Friend WithEvents BBuscarCodigo As Button
    Friend WithEvents TextBoxcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxdescrip As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxprovee As ComboBox
    Friend WithEvents BGuardardetaentramerca As Button
    Friend WithEvents Tcosto As TextBox
    Friend WithEvents Tcantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
