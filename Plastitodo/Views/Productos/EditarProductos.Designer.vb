<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProductos
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
        Me.Txt_CodBar = New System.Windows.Forms.TextBox()
        Me.Cbo_Marca = New System.Windows.Forms.ComboBox()
        Me.Txt_Modelo = New System.Windows.Forms.TextBox()
        Me.Txt_Desc = New System.Windows.Forms.TextBox()
        Me.Cbo_GpoProd = New System.Windows.Forms.ComboBox()
        Me.Cbo_Pres = New System.Windows.Forms.ComboBox()
        Me.Txt_Cto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_CodBar
        '
        Me.Txt_CodBar.Location = New System.Drawing.Point(264, 44)
        Me.Txt_CodBar.Name = "Txt_CodBar"
        Me.Txt_CodBar.Size = New System.Drawing.Size(255, 20)
        Me.Txt_CodBar.TabIndex = 0
        '
        'Cbo_Marca
        '
        Me.Cbo_Marca.FormattingEnabled = True
        Me.Cbo_Marca.Location = New System.Drawing.Point(264, 84)
        Me.Cbo_Marca.Name = "Cbo_Marca"
        Me.Cbo_Marca.Size = New System.Drawing.Size(255, 21)
        Me.Cbo_Marca.TabIndex = 1
        '
        'Txt_Modelo
        '
        Me.Txt_Modelo.Location = New System.Drawing.Point(264, 126)
        Me.Txt_Modelo.Name = "Txt_Modelo"
        Me.Txt_Modelo.Size = New System.Drawing.Size(255, 20)
        Me.Txt_Modelo.TabIndex = 2
        '
        'Txt_Desc
        '
        Me.Txt_Desc.Location = New System.Drawing.Point(264, 165)
        Me.Txt_Desc.Name = "Txt_Desc"
        Me.Txt_Desc.Size = New System.Drawing.Size(255, 20)
        Me.Txt_Desc.TabIndex = 3
        '
        'Cbo_GpoProd
        '
        Me.Cbo_GpoProd.FormattingEnabled = True
        Me.Cbo_GpoProd.Location = New System.Drawing.Point(264, 203)
        Me.Cbo_GpoProd.Name = "Cbo_GpoProd"
        Me.Cbo_GpoProd.Size = New System.Drawing.Size(255, 21)
        Me.Cbo_GpoProd.TabIndex = 4
        '
        'Cbo_Pres
        '
        Me.Cbo_Pres.FormattingEnabled = True
        Me.Cbo_Pres.Location = New System.Drawing.Point(264, 242)
        Me.Cbo_Pres.Name = "Cbo_Pres"
        Me.Cbo_Pres.Size = New System.Drawing.Size(133, 21)
        Me.Cbo_Pres.TabIndex = 5
        '
        'Txt_Cto
        '
        Me.Txt_Cto.Location = New System.Drawing.Point(264, 280)
        Me.Txt_Cto.Name = "Txt_Cto"
        Me.Txt_Cto.Size = New System.Drawing.Size(133, 20)
        Me.Txt_Cto.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo de barras:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Modelo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Grupo de productos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Presentación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Costo unitario"
        '
        'EditarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 377)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Cto)
        Me.Controls.Add(Me.Cbo_Pres)
        Me.Controls.Add(Me.Cbo_GpoProd)
        Me.Controls.Add(Me.Txt_Desc)
        Me.Controls.Add(Me.Txt_Modelo)
        Me.Controls.Add(Me.Cbo_Marca)
        Me.Controls.Add(Me.Txt_CodBar)
        Me.Name = "EditarProductos"
        Me.Text = "EditarProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_CodBar As TextBox
    Friend WithEvents Cbo_Marca As ComboBox
    Friend WithEvents Txt_Modelo As TextBox
    Friend WithEvents Txt_Desc As TextBox
    Friend WithEvents Cbo_GpoProd As ComboBox
    Friend WithEvents Cbo_Pres As ComboBox
    Friend WithEvents Txt_Cto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
