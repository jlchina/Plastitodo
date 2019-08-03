<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarFamiliaProducto
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
        Me.Txt_NombreFamilia = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_NombreFamilia
        '
        Me.Txt_NombreFamilia.Location = New System.Drawing.Point(132, 93)
        Me.Txt_NombreFamilia.Name = "Txt_NombreFamilia"
        Me.Txt_NombreFamilia.Size = New System.Drawing.Size(208, 20)
        Me.Txt_NombreFamilia.TabIndex = 0
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Location = New System.Drawing.Point(132, 168)
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(208, 20)
        Me.Txt_Descripcion.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(265, 211)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 2
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre de la familia de productos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "#ID:"
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Location = New System.Drawing.Point(53, 19)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_ID.TabIndex = 6
        Me.Lbl_ID.Text = "----------"
        '
        'EditarFamiliaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 259)
        Me.Controls.Add(Me.Lbl_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Txt_NombreFamilia)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarFamiliaProducto"
        Me.Text = "Editar Familia De Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_NombreFamilia As TextBox
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_ID As Label
End Class
