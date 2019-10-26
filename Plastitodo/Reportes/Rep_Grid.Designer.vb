<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Grid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rep_Grid))
        Me.DGV_Reporte = New System.Windows.Forms.DataGridView()
        Me.Panel_Inv = New System.Windows.Forms.Panel()
        Me.Btn_Busq_Inv = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_CodBar_Inv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_hist_cto = New System.Windows.Forms.Panel()
        Me.Btn_Hist_Cto_busq = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Txt_codigo_HC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_reporte = New System.Windows.Forms.Label()
        Me.Btn_report = New System.Windows.Forms.Button()
        CType(Me.DGV_Reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Inv.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hist_cto.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Reporte
        '
        Me.DGV_Reporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Reporte.Location = New System.Drawing.Point(12, 110)
        Me.DGV_Reporte.Name = "DGV_Reporte"
        Me.DGV_Reporte.Size = New System.Drawing.Size(776, 328)
        Me.DGV_Reporte.TabIndex = 0
        '
        'Panel_Inv
        '
        Me.Panel_Inv.Controls.Add(Me.Btn_Busq_Inv)
        Me.Panel_Inv.Controls.Add(Me.PictureBox1)
        Me.Panel_Inv.Controls.Add(Me.Txt_CodBar_Inv)
        Me.Panel_Inv.Controls.Add(Me.Label1)
        Me.Panel_Inv.Location = New System.Drawing.Point(12, 48)
        Me.Panel_Inv.Name = "Panel_Inv"
        Me.Panel_Inv.Size = New System.Drawing.Size(470, 43)
        Me.Panel_Inv.TabIndex = 10
        '
        'Btn_Busq_Inv
        '
        Me.Btn_Busq_Inv.BackgroundImage = CType(resources.GetObject("Btn_Busq_Inv.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Busq_Inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Busq_Inv.Location = New System.Drawing.Point(383, 7)
        Me.Btn_Busq_Inv.Name = "Btn_Busq_Inv"
        Me.Btn_Busq_Inv.Size = New System.Drawing.Size(48, 33)
        Me.Btn_Busq_Inv.TabIndex = 13
        Me.Btn_Busq_Inv.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Txt_CodBar_Inv
        '
        Me.Txt_CodBar_Inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Txt_CodBar_Inv.Location = New System.Drawing.Point(196, 14)
        Me.Txt_CodBar_Inv.MaxLength = 15
        Me.Txt_CodBar_Inv.Name = "Txt_CodBar_Inv"
        Me.Txt_CodBar_Inv.Size = New System.Drawing.Size(181, 22)
        Me.Txt_CodBar_Inv.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo de barras:"
        '
        'Panel_hist_cto
        '
        Me.Panel_hist_cto.Controls.Add(Me.Btn_Hist_Cto_busq)
        Me.Panel_hist_cto.Controls.Add(Me.PictureBox2)
        Me.Panel_hist_cto.Controls.Add(Me.Txt_codigo_HC)
        Me.Panel_hist_cto.Controls.Add(Me.Label2)
        Me.Panel_hist_cto.Location = New System.Drawing.Point(12, 45)
        Me.Panel_hist_cto.Name = "Panel_hist_cto"
        Me.Panel_hist_cto.Size = New System.Drawing.Size(470, 50)
        Me.Panel_hist_cto.TabIndex = 11
        '
        'Btn_Hist_Cto_busq
        '
        Me.Btn_Hist_Cto_busq.BackgroundImage = CType(resources.GetObject("Btn_Hist_Cto_busq.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Hist_Cto_busq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Hist_Cto_busq.Location = New System.Drawing.Point(383, 9)
        Me.Btn_Hist_Cto_busq.Name = "Btn_Hist_Cto_busq"
        Me.Btn_Hist_Cto_busq.Size = New System.Drawing.Size(48, 33)
        Me.Btn_Hist_Cto_busq.TabIndex = 17
        Me.Btn_Hist_Cto_busq.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(134, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Txt_codigo_HC
        '
        Me.Txt_codigo_HC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Txt_codigo_HC.Location = New System.Drawing.Point(196, 16)
        Me.Txt_codigo_HC.MaxLength = 15
        Me.Txt_codigo_HC.Name = "Txt_codigo_HC"
        Me.Txt_codigo_HC.Size = New System.Drawing.Size(181, 22)
        Me.Txt_codigo_HC.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Codigo de barras:"
        '
        'Lbl_reporte
        '
        Me.Lbl_reporte.AutoSize = True
        Me.Lbl_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_reporte.Location = New System.Drawing.Point(7, 9)
        Me.Lbl_reporte.Name = "Lbl_reporte"
        Me.Lbl_reporte.Size = New System.Drawing.Size(222, 29)
        Me.Lbl_reporte.TabIndex = 11
        Me.Lbl_reporte.Text = "Generar Reportes"
        '
        'Btn_report
        '
        Me.Btn_report.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_report.BackgroundImage = CType(resources.GetObject("Btn_report.BackgroundImage"), System.Drawing.Image)
        Me.Btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_report.Location = New System.Drawing.Point(728, 36)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(60, 59)
        Me.Btn_report.TabIndex = 12
        Me.Btn_report.UseVisualStyleBackColor = True
        '
        'Rep_Grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_report)
        Me.Controls.Add(Me.Panel_hist_cto)
        Me.Controls.Add(Me.Lbl_reporte)
        Me.Controls.Add(Me.Panel_Inv)
        Me.Controls.Add(Me.DGV_Reporte)
        Me.Name = "Rep_Grid"
        Me.Text = "Rep_Grid"
        CType(Me.DGV_Reporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Inv.ResumeLayout(False)
        Me.Panel_Inv.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hist_cto.ResumeLayout(False)
        Me.Panel_hist_cto.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Reporte As DataGridView
    Friend WithEvents Panel_Inv As Panel
    Friend WithEvents Btn_Busq_Inv As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_CodBar_Inv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_hist_cto As Panel
    Friend WithEvents Btn_Hist_Cto_busq As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Txt_codigo_HC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_reporte As Label
    Friend WithEvents Btn_report As Button
End Class
