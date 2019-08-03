<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_Mercancia
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
        Me.TabEdiMerca = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BActualizar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextMarca = New System.Windows.Forms.TextBox()
        Me.TextPresen = New System.Windows.Forms.TextBox()
        Me.TxtDescrip = New System.Windows.Forms.TextBox()
        Me.Costo = New System.Windows.Forms.Label()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.DataGridViewBusEdi = New System.Windows.Forms.DataGridView()
        Me.BBuscarEdi = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LCodigoBusc = New System.Windows.Forms.Label()
        Me.TabEdiMerca.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewBusEdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabEdiMerca
        '
        Me.TabEdiMerca.Controls.Add(Me.TabPage1)
        Me.TabEdiMerca.Location = New System.Drawing.Point(19, 25)
        Me.TabEdiMerca.Name = "TabEdiMerca"
        Me.TabEdiMerca.SelectedIndex = 0
        Me.TabEdiMerca.Size = New System.Drawing.Size(610, 353)
        Me.TabEdiMerca.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BActualizar)
        Me.TabPage1.Controls.Add(Me.BEditar)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextMarca)
        Me.TabPage1.Controls.Add(Me.TextPresen)
        Me.TabPage1.Controls.Add(Me.TxtDescrip)
        Me.TabPage1.Controls.Add(Me.Costo)
        Me.TabPage1.Controls.Add(Me.Txtprecio)
        Me.TabPage1.Controls.Add(Me.DataGridViewBusEdi)
        Me.TabPage1.Controls.Add(Me.BBuscarEdi)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.LCodigoBusc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(602, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editar "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BActualizar
        '
        Me.BActualizar.Location = New System.Drawing.Point(490, 247)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BActualizar.TabIndex = 13
        Me.BActualizar.Text = "Actualizar"
        Me.BActualizar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(490, 203)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(75, 23)
        Me.BEditar.TabIndex = 12
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Presentacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descripcion"
        '
        'TextMarca
        '
        Me.TextMarca.Location = New System.Drawing.Point(352, 251)
        Me.TextMarca.Name = "TextMarca"
        Me.TextMarca.Size = New System.Drawing.Size(100, 20)
        Me.TextMarca.TabIndex = 8
        '
        'TextPresen
        '
        Me.TextPresen.Location = New System.Drawing.Point(352, 214)
        Me.TextPresen.Name = "TextPresen"
        Me.TextPresen.Size = New System.Drawing.Size(100, 20)
        Me.TextPresen.TabIndex = 7
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(132, 214)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescrip.TabIndex = 6
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Location = New System.Drawing.Point(10, 251)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(34, 13)
        Me.Costo.TabIndex = 5
        Me.Costo.Text = "Costo"
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(132, 251)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.Txtprecio.TabIndex = 4
        '
        'DataGridViewBusEdi
        '
        Me.DataGridViewBusEdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBusEdi.Location = New System.Drawing.Point(10, 80)
        Me.DataGridViewBusEdi.Name = "DataGridViewBusEdi"
        Me.DataGridViewBusEdi.Size = New System.Drawing.Size(442, 85)
        Me.DataGridViewBusEdi.TabIndex = 3
        '
        'BBuscarEdi
        '
        Me.BBuscarEdi.Location = New System.Drawing.Point(490, 29)
        Me.BBuscarEdi.Name = "BBuscarEdi"
        Me.BBuscarEdi.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarEdi.TabIndex = 2
        Me.BBuscarEdi.Text = "Buscar"
        Me.BBuscarEdi.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LCodigoBusc
        '
        Me.LCodigoBusc.AutoSize = True
        Me.LCodigoBusc.Location = New System.Drawing.Point(7, 34)
        Me.LCodigoBusc.Name = "LCodigoBusc"
        Me.LCodigoBusc.Size = New System.Drawing.Size(73, 13)
        Me.LCodigoBusc.TabIndex = 0
        Me.LCodigoBusc.Text = "Codigo Barras"
        '
        'Editar_Mercancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 402)
        Me.Controls.Add(Me.TabEdiMerca)
        Me.Name = "Editar_Mercancia"
        Me.Text = "Editar_Mercancia"
        Me.TabEdiMerca.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewBusEdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabEdiMerca As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BActualizar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextMarca As TextBox
    Friend WithEvents TextPresen As TextBox
    Friend WithEvents TxtDescrip As TextBox
    Friend WithEvents Costo As Label
    Friend WithEvents Txtprecio As TextBox
    Friend WithEvents DataGridViewBusEdi As DataGridView
    Friend WithEvents BBuscarEdi As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LCodigoBusc As Label
End Class
