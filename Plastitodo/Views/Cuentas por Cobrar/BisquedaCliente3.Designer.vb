﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BisquedaCliente3
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
        Me.dgViewbusquedacliente = New System.Windows.Forms.DataGridView()
        Me.Aceptar = New System.Windows.Forms.Button()
        CType(Me.dgViewbusquedacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgViewbusquedacliente
        '
        Me.dgViewbusquedacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewbusquedacliente.Location = New System.Drawing.Point(13, 13)
        Me.dgViewbusquedacliente.Name = "dgViewbusquedacliente"
        Me.dgViewbusquedacliente.Size = New System.Drawing.Size(775, 337)
        Me.dgViewbusquedacliente.TabIndex = 0
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(670, 357)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Seleccionar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'BisquedaCliente3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.dgViewbusquedacliente)
        Me.Name = "BisquedaCliente3"
        Me.Text = "BisquedaCliente3"
        CType(Me.dgViewbusquedacliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgViewbusquedacliente As DataGridView
    Friend WithEvents Aceptar As Button
End Class