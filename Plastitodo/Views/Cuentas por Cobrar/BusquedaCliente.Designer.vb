<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCliente
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
        Me.DataGridViewbusquedacliente = New System.Windows.Forms.DataGridView()
        Me.Aceptar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewbusquedacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewbusquedacliente
        '
        Me.DataGridViewbusquedacliente.AllowUserToAddRows = False
        Me.DataGridViewbusquedacliente.AllowUserToDeleteRows = False
        Me.DataGridViewbusquedacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewbusquedacliente.Location = New System.Drawing.Point(4, 12)
        Me.DataGridViewbusquedacliente.Name = "DataGridViewbusquedacliente"
        Me.DataGridViewbusquedacliente.ReadOnly = True
        Me.DataGridViewbusquedacliente.Size = New System.Drawing.Size(784, 158)
        Me.DataGridViewbusquedacliente.TabIndex = 0
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(702, 176)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'BusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.DataGridViewbusquedacliente)
        Me.Name = "BusquedaCliente"
        Me.Text = "BusquedaCliente"
        CType(Me.DataGridViewbusquedacliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewbusquedacliente As DataGridView
    Friend WithEvents Aceptar As Button
End Class
