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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarFamiliaProducto))
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
        Me.Txt_NombreFamilia.Location = New System.Drawing.Point(19, 123)
        Me.Txt_NombreFamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_NombreFamilia.MaxLength = 30
        Me.Txt_NombreFamilia.Name = "Txt_NombreFamilia"
        Me.Txt_NombreFamilia.Size = New System.Drawing.Size(310, 22)
        Me.Txt_NombreFamilia.TabIndex = 0
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Location = New System.Drawing.Point(19, 222)
        Me.Txt_Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Descripcion.MaxLength = 80
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(310, 22)
        Me.Txt_Descripcion.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.BackgroundImage = CType(resources.GetObject("Btn_Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Guardar.Location = New System.Drawing.Point(265, 269)
        Me.Btn_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(64, 46)
        Me.Btn_Guardar.TabIndex = 2
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre de la familia de productos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "#ID:"
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_ID.Location = New System.Drawing.Point(80, 23)
        Me.Lbl_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(48, 16)
        Me.Lbl_ID.TabIndex = 6
        Me.Lbl_ID.Text = "----------"
        '
        'EditarFamiliaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 331)
        Me.Controls.Add(Me.Lbl_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Txt_NombreFamilia)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarFamiliaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
