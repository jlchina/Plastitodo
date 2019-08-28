<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cons_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cons_prod))
        Me.Btn_filtro = New System.Windows.Forms.Button()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVcatprov = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_filtro
        '
        Me.Btn_filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_filtro.BackColor = System.Drawing.Color.Transparent
        Me.Btn_filtro.BackgroundImage = CType(resources.GetObject("Btn_filtro.BackgroundImage"), System.Drawing.Image)
        Me.Btn_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_filtro.Location = New System.Drawing.Point(631, 32)
        Me.Btn_filtro.Name = "Btn_filtro"
        Me.Btn_filtro.Size = New System.Drawing.Size(59, 42)
        Me.Btn_filtro.TabIndex = 3
        Me.Btn_filtro.UseVisualStyleBackColor = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(326, 45)
        Me.TxtMarca.MaxLength = 20
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(152, 22)
        Me.TxtMarca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Marca:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(85, 46)
        Me.TxtCodigo.MaxLength = 14
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(152, 22)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Código:"
        '
        'DGVcatprov
        '
        Me.DGVcatprov.AllowUserToAddRows = False
        Me.DGVcatprov.AllowUserToDeleteRows = False
        Me.DGVcatprov.AllowUserToOrderColumns = True
        Me.DGVcatprov.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVcatprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcatprov.Location = New System.Drawing.Point(12, 99)
        Me.DGVcatprov.Name = "DGVcatprov"
        Me.DGVcatprov.ReadOnly = True
        Me.DGVcatprov.Size = New System.Drawing.Size(696, 238)
        Me.DGVcatprov.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_filtro)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.TxtMarca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 81)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campos de busqueda"
        '
        'Cons_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVcatprov)
        Me.Name = "Cons_prod"
        Me.Text = "Cons_prod"
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_filtro As Button
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVcatprov As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
