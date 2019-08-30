<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editar_Mercancia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editar_Mercancia))
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
        Me.TabEdiMerca.Location = New System.Drawing.Point(13, 13)
        Me.TabEdiMerca.Margin = New System.Windows.Forms.Padding(4)
        Me.TabEdiMerca.Name = "TabEdiMerca"
        Me.TabEdiMerca.SelectedIndex = 0
        Me.TabEdiMerca.Size = New System.Drawing.Size(915, 434)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(907, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editar "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BActualizar
        '
        Me.BActualizar.BackgroundImage = CType(resources.GetObject("BActualizar.BackgroundImage"), System.Drawing.Image)
        Me.BActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BActualizar.Location = New System.Drawing.Point(759, 290)
        Me.BActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(70, 43)
        Me.BActualizar.TabIndex = 13
        Me.BActualizar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.BackgroundImage = CType(resources.GetObject("BEditar.BackgroundImage"), System.Drawing.Image)
        Me.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BEditar.Location = New System.Drawing.Point(759, 146)
        Me.BEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(70, 57)
        Me.BEditar.TabIndex = 12
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 308)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 267)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Presentacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 263)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descripcion"
        '
        'TextMarca
        '
        Me.TextMarca.Location = New System.Drawing.Point(528, 309)
        Me.TextMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.TextMarca.Name = "TextMarca"
        Me.TextMarca.Size = New System.Drawing.Size(148, 22)
        Me.TextMarca.TabIndex = 8
        '
        'TextPresen
        '
        Me.TextPresen.Location = New System.Drawing.Point(528, 263)
        Me.TextPresen.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPresen.Name = "TextPresen"
        Me.TextPresen.Size = New System.Drawing.Size(148, 22)
        Me.TextPresen.TabIndex = 7
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(198, 263)
        Me.TxtDescrip.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(148, 22)
        Me.TxtDescrip.TabIndex = 6
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Location = New System.Drawing.Point(15, 309)
        Me.Costo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(48, 16)
        Me.Costo.TabIndex = 5
        Me.Costo.Text = "Costo"
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(198, 309)
        Me.Txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(148, 22)
        Me.Txtprecio.TabIndex = 4
        '
        'DataGridViewBusEdi
        '
        Me.DataGridViewBusEdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBusEdi.Location = New System.Drawing.Point(15, 98)
        Me.DataGridViewBusEdi.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewBusEdi.Name = "DataGridViewBusEdi"
        Me.DataGridViewBusEdi.Size = New System.Drawing.Size(663, 105)
        Me.DataGridViewBusEdi.TabIndex = 3
        '
        'BBuscarEdi
        '
        Me.BBuscarEdi.BackgroundImage = CType(resources.GetObject("BBuscarEdi.BackgroundImage"), System.Drawing.Image)
        Me.BBuscarEdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscarEdi.Location = New System.Drawing.Point(759, 31)
        Me.BBuscarEdi.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarEdi.Name = "BBuscarEdi"
        Me.BBuscarEdi.Size = New System.Drawing.Size(70, 43)
        Me.BBuscarEdi.TabIndex = 2
        Me.BBuscarEdi.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(478, 22)
        Me.TextBox1.TabIndex = 1
        '
        'LCodigoBusc
        '
        Me.LCodigoBusc.AutoSize = True
        Me.LCodigoBusc.Location = New System.Drawing.Point(10, 42)
        Me.LCodigoBusc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCodigoBusc.Name = "LCodigoBusc"
        Me.LCodigoBusc.Size = New System.Drawing.Size(108, 16)
        Me.LCodigoBusc.TabIndex = 0
        Me.LCodigoBusc.Text = "Codigo Barras"
        '
        'Editar_Mercancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 456)
        Me.Controls.Add(Me.TabEdiMerca)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
