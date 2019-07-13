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
        Me.BtnCambios = New System.Windows.Forms.Button()
        Me.Btn_filtro = New System.Windows.Forms.Button()
        Me.TxtProv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVcatprov = New System.Windows.Forms.DataGridView()
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCambios
        '
        Me.BtnCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambios.Location = New System.Drawing.Point(613, 23)
        Me.BtnCambios.Name = "BtnCambios"
        Me.BtnCambios.Size = New System.Drawing.Size(90, 43)
        Me.BtnCambios.TabIndex = 19
        Me.BtnCambios.Text = "Guardar Cambios"
        Me.BtnCambios.UseVisualStyleBackColor = True
        '
        'Btn_filtro
        '
        Me.Btn_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_filtro.Location = New System.Drawing.Point(520, 23)
        Me.Btn_filtro.Name = "Btn_filtro"
        Me.Btn_filtro.Size = New System.Drawing.Size(87, 43)
        Me.Btn_filtro.TabIndex = 18
        Me.Btn_filtro.Text = "Buscar Articulo"
        Me.Btn_filtro.UseVisualStyleBackColor = True
        '
        'TxtProv
        '
        Me.TxtProv.Location = New System.Drawing.Point(349, 23)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(152, 20)
        Me.TxtProv.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Proveedor: "
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(82, 51)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(152, 20)
        Me.TxtMarca.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Marca:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(83, 24)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.TxtCodigo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 24)
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
        Me.DGVcatprov.Location = New System.Drawing.Point(12, 89)
        Me.DGVcatprov.Name = "DGVcatprov"
        Me.DGVcatprov.ReadOnly = True
        Me.DGVcatprov.Size = New System.Drawing.Size(696, 248)
        Me.DGVcatprov.TabIndex = 20
        '
        'Cons_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 361)
        Me.Controls.Add(Me.BtnCambios)
        Me.Controls.Add(Me.Btn_filtro)
        Me.Controls.Add(Me.TxtProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVcatprov)
        Me.Name = "Cons_prod"
        Me.Text = "Cons_prod"
        CType(Me.DGVcatprov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCambios As Button
    Friend WithEvents Btn_filtro As Button
    Friend WithEvents TxtProv As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVcatprov As DataGridView
End Class
