<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Clientes
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
        Me.Tab_proveedor = New System.Windows.Forms.TabControl()
        Me.Tab_cons_p = New System.Windows.Forms.TabPage()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Txtbusclient = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVconsultclient = New System.Windows.Forms.DataGridView()
        Me.Tab_alta_p = New System.Windows.Forms.TabPage()
        Me.Text_mail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_tel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_cd = New System.Windows.Forms.TextBox()
        Me.Text_cp = New System.Windows.Forms.TextBox()
        Me.Text_col = New System.Windows.Forms.TextBox()
        Me.Text_dir = New System.Windows.Forms.TextBox()
        Me.Text_nomb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_cancelarp = New System.Windows.Forms.Button()
        Me.Btn_agregarc = New System.Windows.Forms.Button()
        Me.TabEditCatProv = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Buttonbuscar = New System.Windows.Forms.Button()
        Me.Textbusclient = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGV_Edit_CP = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text_id = New System.Windows.Forms.TextBox()
        Me.Tab_proveedor.SuspendLayout()
        Me.Tab_cons_p.SuspendLayout()
        CType(Me.DGVconsultclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_alta_p.SuspendLayout()
        Me.TabEditCatProv.SuspendLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_proveedor
        '
        Me.Tab_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_proveedor.Controls.Add(Me.Tab_cons_p)
        Me.Tab_proveedor.Controls.Add(Me.Tab_alta_p)
        Me.Tab_proveedor.Controls.Add(Me.TabEditCatProv)
        Me.Tab_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tab_proveedor.Location = New System.Drawing.Point(1, 12)
        Me.Tab_proveedor.Name = "Tab_proveedor"
        Me.Tab_proveedor.SelectedIndex = 0
        Me.Tab_proveedor.Size = New System.Drawing.Size(759, 371)
        Me.Tab_proveedor.TabIndex = 33
        '
        'Tab_cons_p
        '
        Me.Tab_cons_p.Controls.Add(Me.BtnBuscar)
        Me.Tab_cons_p.Controls.Add(Me.Txtbusclient)
        Me.Tab_cons_p.Controls.Add(Me.Label4)
        Me.Tab_cons_p.Controls.Add(Me.DGVconsultclient)
        Me.Tab_cons_p.Location = New System.Drawing.Point(4, 25)
        Me.Tab_cons_p.Name = "Tab_cons_p"
        Me.Tab_cons_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_cons_p.Size = New System.Drawing.Size(751, 342)
        Me.Tab_cons_p.TabIndex = 0
        Me.Tab_cons_p.Text = "Consulta"
        Me.Tab_cons_p.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(638, 19)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Txtbusclient
        '
        Me.Txtbusclient.Location = New System.Drawing.Point(107, 26)
        Me.Txtbusclient.Name = "Txtbusclient"
        Me.Txtbusclient.Size = New System.Drawing.Size(281, 22)
        Me.Txtbusclient.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'DGVconsultclient
        '
        Me.DGVconsultclient.AllowUserToAddRows = False
        Me.DGVconsultclient.AllowUserToDeleteRows = False
        Me.DGVconsultclient.AllowUserToOrderColumns = True
        Me.DGVconsultclient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVconsultclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVconsultclient.Location = New System.Drawing.Point(7, 54)
        Me.DGVconsultclient.Name = "DGVconsultclient"
        Me.DGVconsultclient.ReadOnly = True
        Me.DGVconsultclient.Size = New System.Drawing.Size(719, 279)
        Me.DGVconsultclient.TabIndex = 0
        '
        'Tab_alta_p
        '
        Me.Tab_alta_p.Controls.Add(Me.GroupBox2)
        Me.Tab_alta_p.Controls.Add(Me.GroupBox1)
        Me.Tab_alta_p.Controls.Add(Me.Btn_cancelarp)
        Me.Tab_alta_p.Controls.Add(Me.Btn_agregarc)
        Me.Tab_alta_p.Location = New System.Drawing.Point(4, 25)
        Me.Tab_alta_p.Name = "Tab_alta_p"
        Me.Tab_alta_p.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alta_p.Size = New System.Drawing.Size(751, 342)
        Me.Tab_alta_p.TabIndex = 1
        Me.Tab_alta_p.Text = "Alta"
        Me.Tab_alta_p.UseVisualStyleBackColor = True
        '
        'Text_mail
        '
        Me.Text_mail.Location = New System.Drawing.Point(268, 79)
        Me.Text_mail.Name = "Text_mail"
        Me.Text_mail.Size = New System.Drawing.Size(187, 22)
        Me.Text_mail.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email:"
        '
        'Text_tel
        '
        Me.Text_tel.Location = New System.Drawing.Point(83, 79)
        Me.Text_tel.Name = "Text_tel"
        Me.Text_tel.Size = New System.Drawing.Size(113, 22)
        Me.Text_tel.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Teléfono:"
        '
        'Text_cd
        '
        Me.Text_cd.Location = New System.Drawing.Point(94, 80)
        Me.Text_cd.Name = "Text_cd"
        Me.Text_cd.Size = New System.Drawing.Size(113, 22)
        Me.Text_cd.TabIndex = 5
        '
        'Text_cp
        '
        Me.Text_cp.Location = New System.Drawing.Point(329, 77)
        Me.Text_cp.Name = "Text_cp"
        Me.Text_cp.Size = New System.Drawing.Size(113, 22)
        Me.Text_cp.TabIndex = 6
        '
        'Text_col
        '
        Me.Text_col.Location = New System.Drawing.Point(94, 50)
        Me.Text_col.Name = "Text_col"
        Me.Text_col.Size = New System.Drawing.Size(348, 22)
        Me.Text_col.TabIndex = 4
        '
        'Text_dir
        '
        Me.Text_dir.Location = New System.Drawing.Point(94, 21)
        Me.Text_dir.Name = "Text_dir"
        Me.Text_dir.Size = New System.Drawing.Size(348, 22)
        Me.Text_dir.TabIndex = 3
        '
        'Text_nomb
        '
        Me.Text_nomb.Location = New System.Drawing.Point(83, 48)
        Me.Text_nomb.Name = "Text_nomb"
        Me.Text_nomb.Size = New System.Drawing.Size(372, 22)
        Me.Text_nomb.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Código Postal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ciudad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Colonia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nombre:"
        '
        'Btn_cancelarp
        '
        Me.Btn_cancelarp.Location = New System.Drawing.Point(508, 57)
        Me.Btn_cancelarp.Name = "Btn_cancelarp"
        Me.Btn_cancelarp.Size = New System.Drawing.Size(148, 23)
        Me.Btn_cancelarp.TabIndex = 9
        Me.Btn_cancelarp.Text = "Cancelar/Limpiar"
        Me.Btn_cancelarp.UseVisualStyleBackColor = True
        '
        'Btn_agregarc
        '
        Me.Btn_agregarc.Location = New System.Drawing.Point(543, 24)
        Me.Btn_agregarc.Name = "Btn_agregarc"
        Me.Btn_agregarc.Size = New System.Drawing.Size(75, 23)
        Me.Btn_agregarc.TabIndex = 8
        Me.Btn_agregarc.Text = "Agregar"
        Me.Btn_agregarc.UseVisualStyleBackColor = True
        '
        'TabEditCatProv
        '
        Me.TabEditCatProv.Controls.Add(Me.Button2)
        Me.TabEditCatProv.Controls.Add(Me.Buttonbuscar)
        Me.TabEditCatProv.Controls.Add(Me.Textbusclient)
        Me.TabEditCatProv.Controls.Add(Me.Label12)
        Me.TabEditCatProv.Controls.Add(Me.DGV_Edit_CP)
        Me.TabEditCatProv.Location = New System.Drawing.Point(4, 25)
        Me.TabEditCatProv.Name = "TabEditCatProv"
        Me.TabEditCatProv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditCatProv.Size = New System.Drawing.Size(751, 342)
        Me.TabEditCatProv.TabIndex = 2
        Me.TabEditCatProv.Text = "Editar"
        Me.TabEditCatProv.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(634, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Buttonbuscar
        '
        Me.Buttonbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonbuscar.Location = New System.Drawing.Point(469, 22)
        Me.Buttonbuscar.Name = "Buttonbuscar"
        Me.Buttonbuscar.Size = New System.Drawing.Size(84, 23)
        Me.Buttonbuscar.TabIndex = 7
        Me.Buttonbuscar.Text = "Buscar"
        Me.Buttonbuscar.UseVisualStyleBackColor = True
        '
        'Textbusclient
        '
        Me.Textbusclient.Location = New System.Drawing.Point(101, 25)
        Me.Textbusclient.Name = "Textbusclient"
        Me.Textbusclient.Size = New System.Drawing.Size(97, 22)
        Me.Textbusclient.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Id Cliente:"
        '
        'DGV_Edit_CP
        '
        Me.DGV_Edit_CP.AllowUserToAddRows = False
        Me.DGV_Edit_CP.AllowUserToDeleteRows = False
        Me.DGV_Edit_CP.AllowUserToOrderColumns = True
        Me.DGV_Edit_CP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Edit_CP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Edit_CP.Location = New System.Drawing.Point(6, 57)
        Me.DGV_Edit_CP.Name = "DGV_Edit_CP"
        Me.DGV_Edit_CP.Size = New System.Drawing.Size(739, 238)
        Me.DGV_Edit_CP.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Text_dir)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Text_col)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Text_cd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Text_cp)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 125)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del domicilio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Text_id)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Text_nomb)
        Me.GroupBox2.Controls.Add(Me.Text_mail)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Text_tel)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 120)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion general"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Id:"
        '
        'Text_id
        '
        Me.Text_id.Location = New System.Drawing.Point(83, 19)
        Me.Text_id.Name = "Text_id"
        Me.Text_id.Size = New System.Drawing.Size(113, 22)
        Me.Text_id.TabIndex = 21
        '
        'Cat_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 450)
        Me.Controls.Add(Me.Tab_proveedor)
        Me.Name = "Cat_Clientes"
        Me.Text = "Clientes"
        Me.Tab_proveedor.ResumeLayout(False)
        Me.Tab_cons_p.ResumeLayout(False)
        Me.Tab_cons_p.PerformLayout()
        CType(Me.DGVconsultclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_alta_p.ResumeLayout(False)
        Me.TabEditCatProv.ResumeLayout(False)
        Me.TabEditCatProv.PerformLayout()
        CType(Me.DGV_Edit_CP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_proveedor As TabControl
    Friend WithEvents Tab_cons_p As TabPage
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Txtbusclient As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVconsultclient As DataGridView
    Friend WithEvents Tab_alta_p As TabPage
    Friend WithEvents Text_mail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_tel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_cd As TextBox
    Friend WithEvents Text_cp As TextBox
    Friend WithEvents Text_col As TextBox
    Friend WithEvents Text_dir As TextBox
    Friend WithEvents Text_nomb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_cancelarp As Button
    Friend WithEvents Btn_agregarc As Button
    Friend WithEvents TabEditCatProv As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Buttonbuscar As Button
    Friend WithEvents Textbusclient As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DGV_Edit_CP As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_id As TextBox
End Class
