﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Existencias
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
        Me.TExistencias = New System.Windows.Forms.TabControl()
        Me.TBusExistencias = New System.Windows.Forms.TabPage()
        Me.Bbuscarexis = New System.Windows.Forms.Button()
        Me.DataGridViewexis = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TExistencias.SuspendLayout()
        Me.TBusExistencias.SuspendLayout()
        CType(Me.DataGridViewexis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TExistencias
        '
        Me.TExistencias.Controls.Add(Me.TBusExistencias)
        Me.TExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TExistencias.Location = New System.Drawing.Point(12, 12)
        Me.TExistencias.Name = "TExistencias"
        Me.TExistencias.SelectedIndex = 0
        Me.TExistencias.Size = New System.Drawing.Size(464, 287)
        Me.TExistencias.TabIndex = 1
        '
        'TBusExistencias
        '
        Me.TBusExistencias.Controls.Add(Me.Bbuscarexis)
        Me.TBusExistencias.Controls.Add(Me.DataGridViewexis)
        Me.TBusExistencias.Controls.Add(Me.Label1)
        Me.TBusExistencias.Controls.Add(Me.TextBox1)
        Me.TBusExistencias.Location = New System.Drawing.Point(4, 25)
        Me.TBusExistencias.Name = "TBusExistencias"
        Me.TBusExistencias.Padding = New System.Windows.Forms.Padding(3)
        Me.TBusExistencias.Size = New System.Drawing.Size(456, 258)
        Me.TBusExistencias.TabIndex = 0
        Me.TBusExistencias.Text = "Buscar Articulo"
        Me.TBusExistencias.UseVisualStyleBackColor = True
        '
        'Bbuscarexis
        '
        Me.Bbuscarexis.Location = New System.Drawing.Point(353, 9)
        Me.Bbuscarexis.Name = "Bbuscarexis"
        Me.Bbuscarexis.Size = New System.Drawing.Size(75, 23)
        Me.Bbuscarexis.TabIndex = 3
        Me.Bbuscarexis.Text = "Buscar"
        Me.Bbuscarexis.UseVisualStyleBackColor = True
        '
        'DataGridViewexis
        '
        Me.DataGridViewexis.AllowUserToOrderColumns = True
        Me.DataGridViewexis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewexis.Location = New System.Drawing.Point(9, 49)
        Me.DataGridViewexis.Name = "DataGridViewexis"
        Me.DataGridViewexis.Size = New System.Drawing.Size(421, 183)
        Me.DataGridViewexis.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo de Barras"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Existencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 308)
        Me.Controls.Add(Me.TExistencias)
        Me.Name = "Existencias"
        Me.Text = "Existencias"
        Me.TExistencias.ResumeLayout(False)
        Me.TBusExistencias.ResumeLayout(False)
        Me.TBusExistencias.PerformLayout()
        CType(Me.DataGridViewexis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TExistencias As TabControl
    Friend WithEvents TBusExistencias As TabPage
    Friend WithEvents Bbuscarexis As Button
    Friend WithEvents DataGridViewexis As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
