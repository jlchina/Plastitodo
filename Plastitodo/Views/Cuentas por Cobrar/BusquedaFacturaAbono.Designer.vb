<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaFacturaAbono
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
        Me.DataGridViewBusquedaFactura = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewBusquedaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBusquedaFactura
        '
        Me.DataGridViewBusquedaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBusquedaFactura.Location = New System.Drawing.Point(13, 13)
        Me.DataGridViewBusquedaFactura.Name = "DataGridViewBusquedaFactura"
        Me.DataGridViewBusquedaFactura.Size = New System.Drawing.Size(762, 208)
        Me.DataGridViewBusquedaFactura.TabIndex = 0
        '
        'BusquedaFacturaAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 272)
        Me.Controls.Add(Me.DataGridViewBusquedaFactura)
        Me.Name = "BusquedaFacturaAbono"
        Me.Text = "BusquedaFacturaAbono"
        CType(Me.DataGridViewBusquedaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBusquedaFactura As DataGridView
End Class
