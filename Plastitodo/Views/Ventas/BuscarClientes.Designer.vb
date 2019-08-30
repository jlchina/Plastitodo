<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarClientes))
        Me.TxtFrase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtFrase
        '
        Me.TxtFrase.Location = New System.Drawing.Point(84, 25)
        Me.TxtFrase.Name = "TxtFrase"
        Me.TxtFrase.Size = New System.Drawing.Size(291, 20)
        Me.TxtFrase.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(15, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Frase"
        '
        'DgvClientes
        '
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Location = New System.Drawing.Point(12, 62)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.Size = New System.Drawing.Size(606, 209)
        Me.DgvClientes.TabIndex = 16
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackgroundImage = CType(resources.GetObject("BtnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(573, 16)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(45, 36)
        Me.BtnBuscarCliente.TabIndex = 17
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'BuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 283)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.DgvClientes)
        Me.Controls.Add(Me.TxtFrase)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarClientes"
        Me.Text = "Buscar clientes"
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFrase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents BtnBuscarCliente As Button
End Class
