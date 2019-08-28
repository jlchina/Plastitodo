<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarGpoProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarGpoProd))
        Me.Cbo_EFamprod = New System.Windows.Forms.ComboBox()
        Me.Txt_NomCat = New System.Windows.Forms.TextBox()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_GpoProd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cbo_EFamprod
        '
        Me.Cbo_EFamprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Cbo_EFamprod.FormattingEnabled = True
        Me.Cbo_EFamprod.Location = New System.Drawing.Point(198, 67)
        Me.Cbo_EFamprod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cbo_EFamprod.Name = "Cbo_EFamprod"
        Me.Cbo_EFamprod.Size = New System.Drawing.Size(262, 24)
        Me.Cbo_EFamprod.TabIndex = 0
        '
        'Txt_NomCat
        '
        Me.Txt_NomCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Txt_NomCat.Location = New System.Drawing.Point(198, 135)
        Me.Txt_NomCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_NomCat.MaxLength = 30
        Me.Txt_NomCat.Name = "Txt_NomCat"
        Me.Txt_NomCat.Size = New System.Drawing.Size(262, 22)
        Me.Txt_NomCat.TabIndex = 1
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Actualizar.BackgroundImage = CType(resources.GetObject("Btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.Location = New System.Drawing.Point(398, 185)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(62, 50)
        Me.Btn_Actualizar.TabIndex = 2
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Familia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grupo de producto: "
        '
        'Lbl_GpoProd
        '
        Me.Lbl_GpoProd.AutoSize = True
        Me.Lbl_GpoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_GpoProd.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GpoProd.Location = New System.Drawing.Point(195, 20)
        Me.Lbl_GpoProd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_GpoProd.Name = "Lbl_GpoProd"
        Me.Lbl_GpoProd.Size = New System.Drawing.Size(78, 16)
        Me.Lbl_GpoProd.TabIndex = 6
        Me.Lbl_GpoProd.Text = "--------------"
        '
        'EditarGpoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 253)
        Me.Controls.Add(Me.Lbl_GpoProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Txt_NomCat)
        Me.Controls.Add(Me.Cbo_EFamprod)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarGpoProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Grupo de productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cbo_EFamprod As ComboBox
    Friend WithEvents Txt_NomCat As TextBox
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_GpoProd As Label
End Class
