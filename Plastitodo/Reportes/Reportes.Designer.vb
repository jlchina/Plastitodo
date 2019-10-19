<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_PrecVta = New System.Windows.Forms.Button()
        Me.Btn_Hist_Cto = New System.Windows.Forms.Button()
        Me.Btn_Inv = New System.Windows.Forms.Button()
        Me.Btn_Vtas = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Generar Reportes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(84, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "VENTAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(319, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INVENTARIOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(52, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "HISTORICO DE COSTOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(303, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRECIO DE VENTA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(507, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Btn_PrecVta
        '
        Me.Btn_PrecVta.BackgroundImage = CType(resources.GetObject("Btn_PrecVta.BackgroundImage"), System.Drawing.Image)
        Me.Btn_PrecVta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_PrecVta.Location = New System.Drawing.Point(294, 280)
        Me.Btn_PrecVta.Name = "Btn_PrecVta"
        Me.Btn_PrecVta.Size = New System.Drawing.Size(121, 103)
        Me.Btn_PrecVta.TabIndex = 3
        Me.Btn_PrecVta.UseVisualStyleBackColor = True
        '
        'Btn_Hist_Cto
        '
        Me.Btn_Hist_Cto.BackgroundImage = CType(resources.GetObject("Btn_Hist_Cto.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Hist_Cto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Hist_Cto.Location = New System.Drawing.Point(55, 280)
        Me.Btn_Hist_Cto.Name = "Btn_Hist_Cto"
        Me.Btn_Hist_Cto.Size = New System.Drawing.Size(121, 103)
        Me.Btn_Hist_Cto.TabIndex = 2
        Me.Btn_Hist_Cto.UseVisualStyleBackColor = True
        '
        'Btn_Inv
        '
        Me.Btn_Inv.BackgroundImage = CType(resources.GetObject("Btn_Inv.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Inv.Location = New System.Drawing.Point(294, 105)
        Me.Btn_Inv.Name = "Btn_Inv"
        Me.Btn_Inv.Size = New System.Drawing.Size(121, 103)
        Me.Btn_Inv.TabIndex = 1
        Me.Btn_Inv.UseVisualStyleBackColor = True
        '
        'Btn_Vtas
        '
        Me.Btn_Vtas.BackgroundImage = CType(resources.GetObject("Btn_Vtas.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Vtas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Vtas.Location = New System.Drawing.Point(55, 105)
        Me.Btn_Vtas.Name = "Btn_Vtas"
        Me.Btn_Vtas.Size = New System.Drawing.Size(121, 103)
        Me.Btn_Vtas.TabIndex = 0
        Me.Btn_Vtas.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_PrecVta)
        Me.Controls.Add(Me.Btn_Hist_Cto)
        Me.Controls.Add(Me.Btn_Inv)
        Me.Controls.Add(Me.Btn_Vtas)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Vtas As Button
    Friend WithEvents Btn_Inv As Button
    Friend WithEvents Btn_Hist_Cto As Button
    Friend WithEvents Btn_PrecVta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
