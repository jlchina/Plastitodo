<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaGpoProd
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
        Me.cmbo_nomfam = New System.Windows.Forms.ComboBox()
        Me.Btn_agregarp = New System.Windows.Forms.Button()
        Me.txt_gpoprod = New System.Windows.Forms.TextBox()
        Me.txt_nomcat = New System.Windows.Forms.TextBox()
        Me.txt_cat = New System.Windows.Forms.TextBox()
        Me.txt_idfamilia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbo_nomfam
        '
        Me.cmbo_nomfam.FormattingEnabled = True
        Me.cmbo_nomfam.Location = New System.Drawing.Point(459, 29)
        Me.cmbo_nomfam.Name = "cmbo_nomfam"
        Me.cmbo_nomfam.Size = New System.Drawing.Size(172, 21)
        Me.cmbo_nomfam.TabIndex = 22
        '
        'Btn_agregarp
        '
        Me.Btn_agregarp.Location = New System.Drawing.Point(556, 246)
        Me.Btn_agregarp.Name = "Btn_agregarp"
        Me.Btn_agregarp.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregarp.TabIndex = 21
        Me.Btn_agregarp.Text = "Agregar"
        Me.Btn_agregarp.UseVisualStyleBackColor = True
        '
        'txt_gpoprod
        '
        Me.txt_gpoprod.Location = New System.Drawing.Point(157, 145)
        Me.txt_gpoprod.Name = "txt_gpoprod"
        Me.txt_gpoprod.ReadOnly = True
        Me.txt_gpoprod.Size = New System.Drawing.Size(100, 20)
        Me.txt_gpoprod.TabIndex = 20
        '
        'txt_nomcat
        '
        Me.txt_nomcat.Location = New System.Drawing.Point(459, 87)
        Me.txt_nomcat.Name = "txt_nomcat"
        Me.txt_nomcat.Size = New System.Drawing.Size(172, 20)
        Me.txt_nomcat.TabIndex = 18
        '
        'txt_cat
        '
        Me.txt_cat.Location = New System.Drawing.Point(157, 87)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.Size = New System.Drawing.Size(100, 20)
        Me.txt_cat.TabIndex = 16
        '
        'txt_idfamilia
        '
        Me.txt_idfamilia.Location = New System.Drawing.Point(157, 29)
        Me.txt_idfamilia.Name = "txt_idfamilia"
        Me.txt_idfamilia.Size = New System.Drawing.Size(100, 20)
        Me.txt_idfamilia.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Grupo de producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Id Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Id Familia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id Familia:"
        '
        'AltaGpoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 299)
        Me.Controls.Add(Me.cmbo_nomfam)
        Me.Controls.Add(Me.Btn_agregarp)
        Me.Controls.Add(Me.txt_gpoprod)
        Me.Controls.Add(Me.txt_nomcat)
        Me.Controls.Add(Me.txt_cat)
        Me.Controls.Add(Me.txt_idfamilia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaGpoProd"
        Me.Text = "AltaGpoProd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbo_nomfam As ComboBox
    Friend WithEvents Btn_agregarp As Button
    Friend WithEvents txt_gpoprod As TextBox
    Friend WithEvents txt_nomcat As TextBox
    Friend WithEvents txt_cat As TextBox
    Friend WithEvents txt_idfamilia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
