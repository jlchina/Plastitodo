﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Existencias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Existencias))
        Me.Bbuscarexis = New System.Windows.Forms.Button()
        Me.DataGridViewexis = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewexis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bbuscarexis
        '
        Me.Bbuscarexis.BackColor = System.Drawing.Color.Transparent
        Me.Bbuscarexis.BackgroundImage = CType(resources.GetObject("Bbuscarexis.BackgroundImage"), System.Drawing.Image)
        Me.Bbuscarexis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bbuscarexis.Location = New System.Drawing.Point(592, 24)
        Me.Bbuscarexis.Margin = New System.Windows.Forms.Padding(4)
        Me.Bbuscarexis.Name = "Bbuscarexis"
        Me.Bbuscarexis.Size = New System.Drawing.Size(53, 44)
        Me.Bbuscarexis.TabIndex = 7
        Me.Bbuscarexis.UseVisualStyleBackColor = False
        '
        'DataGridViewexis
        '
        Me.DataGridViewexis.AllowUserToOrderColumns = True
        Me.DataGridViewexis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewexis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewexis.Location = New System.Drawing.Point(13, 86)
        Me.DataGridViewexis.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewexis.Name = "DataGridViewexis"
        Me.DataGridViewexis.Size = New System.Drawing.Size(632, 225)
        Me.DataGridViewexis.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo de Barras:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 35)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(355, 22)
        Me.TextBox1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(154, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Existencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 321)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bbuscarexis)
        Me.Controls.Add(Me.DataGridViewexis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Existencias"
        Me.Text = "Consultar existencias"
        CType(Me.DataGridViewexis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bbuscarexis As Button
    Friend WithEvents DataGridViewexis As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
