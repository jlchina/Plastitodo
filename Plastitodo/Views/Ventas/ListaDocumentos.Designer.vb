﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaDocumentos))
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        CType(Me.DgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(74, 20)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(291, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(371, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Fecha del Documento"
        '
        'DgvDocumentos
        '
        Me.DgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDocumentos.Location = New System.Drawing.Point(12, 46)
        Me.DgvDocumentos.Name = "DgvDocumentos"
        Me.DgvDocumentos.Size = New System.Drawing.Size(721, 283)
        Me.DgvDocumentos.TabIndex = 15
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackgroundImage = CType(resources.GetObject("BtnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(688, 4)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(45, 36)
        Me.BtnBuscarCliente.TabIndex = 16
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(536, 20)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(125, 20)
        Me.TxtFecha.TabIndex = 17
        '
        'ListaDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 364)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.DgvDocumentos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListaDocumentos"
        Me.Text = "Documentos de venta"
        CType(Me.DgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DgvDocumentos As DataGridView
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtFecha As TextBox
End Class
