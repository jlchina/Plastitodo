<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.Btn_ingresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(59, 58)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(43, 13)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "Usuario"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(124, 58)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(100, 20)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(124, 84)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 3
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(59, 84)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(61, 13)
        Me.lbl_pass.TabIndex = 2
        Me.lbl_pass.Text = "Contraseña"
        '
        'Btn_ingresar
        '
        Me.Btn_ingresar.Location = New System.Drawing.Point(62, 129)
        Me.Btn_ingresar.Name = "Btn_ingresar"
        Me.Btn_ingresar.Size = New System.Drawing.Size(162, 33)
        Me.Btn_ingresar.TabIndex = 4
        Me.Btn_ingresar.Text = "&Ingresar"
        Me.Btn_ingresar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 202)
        Me.Controls.Add(Me.Btn_ingresar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents lbl_pass As Label
    Friend WithEvents Btn_ingresar As Button
End Class
