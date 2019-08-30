<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPresProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarPresProd))
        Me.Txt_NomPresP = New System.Windows.Forms.TextBox()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_NomPresP
        '
        Me.Txt_NomPresP.Location = New System.Drawing.Point(245, 84)
        Me.Txt_NomPresP.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_NomPresP.Name = "Txt_NomPresP"
        Me.Txt_NomPresP.Size = New System.Drawing.Size(167, 22)
        Me.Txt_NomPresP.TabIndex = 0
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Actualizar.BackgroundImage = CType(resources.GetObject("Btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Actualizar.Location = New System.Drawing.Point(358, 151)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(54, 43)
        Me.Btn_Actualizar.TabIndex = 1
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Presentacion del producto: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID:"
        '
        'Lbl_Id
        '
        Me.Lbl_Id.AutoSize = True
        Me.Lbl_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Id.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Id.Location = New System.Drawing.Point(64, 18)
        Me.Lbl_Id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Id.Name = "Lbl_Id"
        Me.Lbl_Id.Size = New System.Drawing.Size(52, 16)
        Me.Lbl_Id.TabIndex = 4
        Me.Lbl_Id.Text = "-----------"
        '
        'EditarPresProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 221)
        Me.Controls.Add(Me.Lbl_Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Txt_NomPresP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 260)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 260)
        Me.Name = "EditarPresProd"
        Me.Text = "Editar presentacion de productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_NomPresP As TextBox
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Id As Label
End Class
