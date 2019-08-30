<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presentacion_Prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion_Prod))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Txt_Presentacion = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Dgv_Presentacion = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_Presentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 304)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Btn_Guardar)
        Me.TabPage1.Controls.Add(Me.Txt_Presentacion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(624, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Presentacion del producto:"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackgroundImage = CType(resources.GetObject("Btn_Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Guardar.Location = New System.Drawing.Point(505, 179)
        Me.Btn_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(53, 45)
        Me.Btn_Guardar.TabIndex = 1
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Txt_Presentacion
        '
        Me.Txt_Presentacion.Location = New System.Drawing.Point(244, 86)
        Me.Txt_Presentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Presentacion.Name = "Txt_Presentacion"
        Me.Txt_Presentacion.Size = New System.Drawing.Size(314, 22)
        Me.Txt_Presentacion.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Btn_Actualizar)
        Me.TabPage2.Controls.Add(Me.Dgv_Presentacion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(624, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar / Editar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackgroundImage = CType(resources.GetObject("Btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Actualizar.FlatAppearance.BorderSize = 0
        Me.Btn_Actualizar.Location = New System.Drawing.Point(9, 2)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(48, 39)
        Me.Btn_Actualizar.TabIndex = 1
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Dgv_Presentacion
        '
        Me.Dgv_Presentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Presentacion.Location = New System.Drawing.Point(9, 43)
        Me.Dgv_Presentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Presentacion.Name = "Dgv_Presentacion"
        Me.Dgv_Presentacion.Size = New System.Drawing.Size(602, 222)
        Me.Dgv_Presentacion.TabIndex = 0
        '
        'Presentacion_Prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 334)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(684, 373)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(684, 373)
        Me.Name = "Presentacion_Prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion de los productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv_Presentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txt_Presentacion As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_Presentacion As DataGridView
    Friend WithEvents Btn_Actualizar As Button
End Class
