<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaMarca))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.Txt_marca = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la marca:"
        '
        'Btn_agregar
        '
        Me.Btn_agregar.BackgroundImage = CType(resources.GetObject("Btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_agregar.Location = New System.Drawing.Point(337, 99)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(50, 42)
        Me.Btn_agregar.TabIndex = 2
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'Txt_marca
        '
        Me.Txt_marca.Location = New System.Drawing.Point(181, 49)
        Me.Txt_marca.MaxLength = 20
        Me.Txt_marca.Name = "Txt_marca"
        Me.Txt_marca.Size = New System.Drawing.Size(206, 20)
        Me.Txt_marca.TabIndex = 1
        '
        'AltaMarca
        '
        Me.ClientSize = New System.Drawing.Size(403, 153)
        Me.Controls.Add(Me.Txt_marca)
        Me.Controls.Add(Me.Btn_agregar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaMarca"
        Me.Text = "Marca: Dar de alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_agregar As Button
    Friend WithEvents Txt_marca As TextBox
End Class
