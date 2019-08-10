<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfertaVentaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfertaVentaForm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarNombre = New System.Windows.Forms.Button()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.CmbNombre = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DtpDocDueDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtDocNum = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgvLista = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCopiara = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtImpuestoTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnBuscarNombre)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.CmbNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CmbCliente)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(376, 90)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion Del cliente"
        '
        'BtnBuscarNombre
        '
        Me.BtnBuscarNombre.BackgroundImage = CType(resources.GetObject("BtnBuscarNombre.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarNombre.Location = New System.Drawing.Point(334, 57)
        Me.BtnBuscarNombre.Name = "BtnBuscarNombre"
        Me.BtnBuscarNombre.Size = New System.Drawing.Size(22, 22)
        Me.BtnBuscarNombre.TabIndex = 4
        Me.BtnBuscarNombre.UseVisualStyleBackColor = True
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackgroundImage = CType(resources.GetObject("BtnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(209, 21)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(22, 22)
        Me.BtnBuscarCliente.TabIndex = 2
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'CmbNombre
        '
        Me.CmbNombre.FormattingEnabled = True
        Me.CmbNombre.Location = New System.Drawing.Point(69, 57)
        Me.CmbNombre.Name = "CmbNombre"
        Me.CmbNombre.Size = New System.Drawing.Size(249, 24)
        Me.CmbNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(69, 21)
        Me.CmbCliente.MaxDropDownItems = 5
        Me.CmbCliente.MaxLength = 7
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(134, 24)
        Me.CmbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DtpDocDueDate)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.TxtDocNum)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(696, 9)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Size = New System.Drawing.Size(323, 90)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        '
        'DtpDocDueDate
        '
        Me.DtpDocDueDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpDocDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDocDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDocDueDate.Location = New System.Drawing.Point(206, 63)
        Me.DtpDocDueDate.Name = "DtpDocDueDate"
        Me.DtpDocDueDate.Size = New System.Drawing.Size(113, 18)
        Me.DtpDocDueDate.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(206, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(113, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TxtDocNum
        '
        Me.TxtDocNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocNum.Location = New System.Drawing.Point(206, 16)
        Me.TxtDocNum.Name = "TxtDocNum"
        Me.TxtDocNum.Size = New System.Drawing.Size(113, 20)
        Me.TxtDocNum.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Fecha del Documento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "No."
        '
        'DgvLista
        '
        Me.DgvLista.AllowUserToAddRows = False
        Me.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.presentacion, Me.cantidad, Me.stock, Me.precio, Me.descuento, Me.iva, Me.total})
        Me.DgvLista.Location = New System.Drawing.Point(9, 188)
        Me.DgvLista.Name = "DgvLista"
        Me.DgvLista.Size = New System.Drawing.Size(1007, 187)
        Me.DgvLista.TabIndex = 32
        '
        'codigo
        '
        Me.codigo.Frozen = True
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.Frozen = True
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 160
        '
        'presentacion
        '
        Me.presentacion.Frozen = True
        Me.presentacion.HeaderText = "Presentación"
        Me.presentacion.Name = "presentacion"
        Me.presentacion.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.Frozen = True
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'stock
        '
        Me.stock.Frozen = True
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'precio
        '
        Me.precio.Frozen = True
        Me.precio.HeaderText = "Precio por Unidad"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'descuento
        '
        Me.descuento.Frozen = True
        Me.descuento.HeaderText = "Descuento %"
        Me.descuento.Name = "descuento"
        '
        'iva
        '
        Me.iva.Frozen = True
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'total
        '
        Me.total.Frozen = True
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCancelar)
        Me.GroupBox4.Controls.Add(Me.BtnCrear)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(9, 391)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(515, 100)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(429, 62)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnCrear
        '
        Me.BtnCrear.Location = New System.Drawing.Point(429, 19)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(75, 23)
        Me.BtnCrear.TabIndex = 8
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(231, 35)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 40)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(228, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comentarios"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Empleado de Ventas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCopiara)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtImpuestoTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(625, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 100)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'BtnCopiara
        '
        Me.BtnCopiara.Enabled = False
        Me.BtnCopiara.Location = New System.Drawing.Point(18, 19)
        Me.BtnCopiara.Name = "BtnCopiara"
        Me.BtnCopiara.Size = New System.Drawing.Size(127, 23)
        Me.BtnCopiara.TabIndex = 11
        Me.BtnCopiara.Text = "Copiar a"
        Me.BtnCopiara.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(284, 69)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(192, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Importe Total:"
        '
        'TxtImpuestoTotal
        '
        Me.TxtImpuestoTotal.Location = New System.Drawing.Point(284, 42)
        Me.TxtImpuestoTotal.Name = "TxtImpuestoTotal"
        Me.TxtImpuestoTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuestoTotal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(183, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Impuesto Total:"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(284, 13)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(204, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sub - Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CmbProducto)
        Me.GroupBox3.Controls.Add(Me.BtnBuscarProducto)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(11, 111)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Size = New System.Drawing.Size(502, 59)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Producto"
        '
        'CmbProducto
        '
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(10, 19)
        Me.CmbProducto.MaxDropDownItems = 15
        Me.CmbProducto.MaxLength = 200
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(450, 24)
        Me.CmbProducto.TabIndex = 23
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.BackgroundImage = CType(resources.GetObject("BtnBuscarProducto.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(466, 19)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(22, 22)
        Me.BtnBuscarProducto.TabIndex = 24
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'OfertaVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 503)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DgvLista)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "OfertaVentaForm"
        Me.Text = "OfertaVentaForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBuscarNombre As Button
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents CmbNombre As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbCliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DtpDocDueDate As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TxtDocNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvLista As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCopiara As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtImpuestoTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbProducto As ComboBox
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents presentacion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
