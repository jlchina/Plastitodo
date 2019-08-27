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
        Me.Buttonlimpiardatos = New System.Windows.Forms.Button()
        Me.DataGridViewdetalleentrada = New System.Windows.Forms.DataGridView()
        Me.TextBoxprecio = New System.Windows.Forms.TextBox()
        Me.TextBoxproducto = New System.Windows.Forms.TextBox()
        Me.Labelprecio = New System.Windows.Forms.Label()
        Me.BBuscarCodigo = New System.Windows.Forms.Button()
        Me.TextBoxcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxprovee = New System.Windows.Forms.ComboBox()
        Me.BGuardardetaentramerca = New System.Windows.Forms.Button()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TEntradasMerca.SuspendLayout()
        CType(Me.DataGridViewdetalleentrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TEntradasMerca)
        Me.TabControl1.Location = New System.Drawing.Point(15, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(677, 357)
        Me.TabControl1.TabIndex = 2
        '
        'TEntradasMerca
        '
        Me.TEntradasMerca.Controls.Add(Me.Buttonlimpiardatos)
        Me.TEntradasMerca.Controls.Add(Me.DataGridViewdetalleentrada)
        Me.TEntradasMerca.Controls.Add(Me.TextBoxprecio)
        Me.TEntradasMerca.Controls.Add(Me.TextBoxproducto)
        Me.TEntradasMerca.Controls.Add(Me.Labelprecio)
        Me.TEntradasMerca.Controls.Add(Me.BBuscarCodigo)
        Me.TEntradasMerca.Controls.Add(Me.TextBoxcodigo)
        Me.TEntradasMerca.Controls.Add(Me.Label1)
        Me.TEntradasMerca.Controls.Add(Me.Label6)
        Me.TEntradasMerca.Controls.Add(Me.Label5)
        Me.TEntradasMerca.Controls.Add(Me.ComboBoxprovee)
        Me.TEntradasMerca.Controls.Add(Me.BGuardardetaentramerca)
        Me.TEntradasMerca.Controls.Add(Me.Tcantidad)
        Me.TEntradasMerca.Controls.Add(Me.Label3)
        Me.TEntradasMerca.Location = New System.Drawing.Point(4, 22)
        Me.TEntradasMerca.Name = "TEntradasMerca"
        Me.TEntradasMerca.Padding = New System.Windows.Forms.Padding(3)
        Me.TEntradasMerca.Size = New System.Drawing.Size(669, 331)
        Me.TEntradasMerca.TabIndex = 0
        Me.TEntradasMerca.Text = "Entradas"
        Me.TEntradasMerca.UseVisualStyleBackColor = True
        '
        'Buttonlimpiardatos
        '
        Me.Buttonlimpiardatos.Location = New System.Drawing.Point(522, 54)
        Me.Buttonlimpiardatos.Name = "Buttonlimpiardatos"
        Me.Buttonlimpiardatos.Size = New System.Drawing.Size(97, 23)
        Me.Buttonlimpiardatos.TabIndex = 22
        Me.Buttonlimpiardatos.Text = "Limpiar"
        Me.Buttonlimpiardatos.UseVisualStyleBackColor = True
        '
        'DataGridViewdetalleentrada
        '
        Me.DataGridViewdetalleentrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewdetalleentrada.Location = New System.Drawing.Point(15, 164)
        Me.DataGridViewdetalleentrada.Name = "DataGridViewdetalleentrada"
        Me.DataGridViewdetalleentrada.Size = New System.Drawing.Size(492, 150)
        Me.DataGridViewdetalleentrada.TabIndex = 21
        '
        'TextBoxprecio
        '
        Me.TextBoxprecio.Location = New System.Drawing.Point(386, 95)
        Me.TextBoxprecio.Name = "TextBoxprecio"
        Me.TextBoxprecio.ReadOnly = True
        Me.TextBoxprecio.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxprecio.TabIndex = 20
        '
        'TextBoxproducto
        '
        Me.TextBoxproducto.Enabled = False
        Me.TextBoxproducto.Location = New System.Drawing.Point(68, 54)
        Me.TextBoxproducto.Name = "TextBoxproducto"
        Me.TextBoxproducto.Size = New System.Drawing.Size(219, 20)
        Me.TextBoxproducto.TabIndex = 19
        '
        'Labelprecio
        '
        Me.Labelprecio.AutoSize = True
        Me.Labelprecio.Location = New System.Drawing.Point(303, 95)
        Me.Labelprecio.Name = "Labelprecio"
        Me.Labelprecio.Size = New System.Drawing.Size(37, 13)
        Me.Labelprecio.TabIndex = 17
        Me.Labelprecio.Text = "Precio"
        '
        'BBuscarCodigo
        '
        Me.BBuscarCodigo.Location = New System.Drawing.Point(306, 12)
        Me.BBuscarCodigo.Name = "BBuscarCodigo"
        Me.BBuscarCodigo.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarCodigo.TabIndex = 15
        Me.BBuscarCodigo.Text = "Buscar"
        Me.BBuscarCodigo.UseVisualStyleBackColor = True
        '
        'TextBoxcodigo
        '
        Me.TextBoxcodigo.Location = New System.Drawing.Point(91, 14)
        Me.TextBoxcodigo.Name = "TextBoxcodigo"
        Me.TextBoxcodigo.Size = New System.Drawing.Size(196, 20)
        Me.TextBoxcodigo.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo Barras"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedor"
        '
        'ComboBoxprovee
        '
        Me.ComboBoxprovee.FormattingEnabled = True
        Me.ComboBoxprovee.Location = New System.Drawing.Point(68, 95)
        Me.ComboBoxprovee.Name = "ComboBoxprovee"
        Me.ComboBoxprovee.Size = New System.Drawing.Size(219, 21)
        Me.ComboBoxprovee.TabIndex = 8
        '
        'BGuardardetaentramerca
        '
        Me.BGuardardetaentramerca.Location = New System.Drawing.Point(522, 92)
        Me.BGuardardetaentramerca.Name = "BGuardardetaentramerca"
        Me.BGuardardetaentramerca.Size = New System.Drawing.Size(97, 23)
        Me.BGuardardetaentramerca.TabIndex = 1
        Me.BGuardardetaentramerca.Text = "Guardar"
        Me.BGuardardetaentramerca.UseVisualStyleBackColor = True
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(386, 54)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(121, 20)
        Me.Tcantidad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 58)
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
        CType(Me.DataGridViewdetalleentrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TEntradasMerca As TabPage
    Friend WithEvents Buttonlimpiardatos As Button
    Friend WithEvents DataGridViewdetalleentrada As DataGridView
    Friend WithEvents TextBoxprecio As TextBox
    Friend WithEvents TextBoxproducto As TextBox
    Friend WithEvents Labelprecio As Label
    Friend WithEvents BBuscarCodigo As Button
    Friend WithEvents TextBoxcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxprovee As ComboBox
    Friend WithEvents BGuardardetaentramerca As Button
    Friend WithEvents Tcantidad As TextBox
    Friend WithEvents Label3 As Label
End Class
