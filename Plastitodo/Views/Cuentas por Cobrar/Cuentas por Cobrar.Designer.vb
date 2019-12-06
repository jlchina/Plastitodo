<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CuentasCobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentasCobrar))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAnticipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNotaFactura = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxmetodopago = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtmonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxRazonSocial = New System.Windows.Forms.TextBox()
        Me.TextBoxRfc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtRfcAbono = New System.Windows.Forms.TextBox()
        Me.TxtEmailAbono = New System.Windows.Forms.TextBox()
        Me.TxtSaldoFinalAbono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefonoAbono = New System.Windows.Forms.TextBox()
        Me.TxtNombreAbono = New System.Windows.Forms.TextBox()
        Me.DataGridViewabonos = New System.Windows.Forms.DataGridView()
        Me.AbonoCuenta = New System.Windows.Forms.GroupBox()
        Me.ButtonGuardarAbono = New System.Windows.Forms.Button()
        Me.ComboBoxMetodoPagoAbono = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonBuscarFactura = New System.Windows.Forms.Button()
        Me.TxtAbonoAbono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNofacturaAbono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fecha_abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewabonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbonoCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(747, 429)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(739, 403)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alta de Cliente por Cobrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtAnticipo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNotaFactura)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtPlazo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ComboBoxmetodopago)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txtmonto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(679, 158)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alta de Cuenta por Cobrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Anticipo"
        '
        'TxtAnticipo
        '
        Me.TxtAnticipo.Location = New System.Drawing.Point(114, 110)
        Me.TxtAnticipo.Name = "TxtAnticipo"
        Me.TxtAnticipo.Size = New System.Drawing.Size(140, 20)
        Me.TxtAnticipo.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nota/Factura"
        '
        'txtNotaFactura
        '
        Me.txtNotaFactura.Location = New System.Drawing.Point(114, 34)
        Me.txtNotaFactura.Name = "txtNotaFactura"
        Me.txtNotaFactura.Size = New System.Drawing.Size(140, 20)
        Me.txtNotaFactura.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(464, 74)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(133, 20)
        Me.TxtPlazo.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(370, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Plazo"
        '
        'ComboBoxmetodopago
        '
        Me.ComboBoxmetodopago.FormattingEnabled = True
        Me.ComboBoxmetodopago.Location = New System.Drawing.Point(464, 33)
        Me.ComboBoxmetodopago.Name = "ComboBoxmetodopago"
        Me.ComboBoxmetodopago.Size = New System.Drawing.Size(133, 21)
        Me.ComboBoxmetodopago.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(370, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Metodo de Pago"
        '
        'TxtSaldoTotal
        '
        Me.TxtSaldoTotal.Location = New System.Drawing.Point(464, 110)
        Me.TxtSaldoTotal.Name = "TxtSaldoTotal"
        Me.TxtSaldoTotal.Size = New System.Drawing.Size(133, 20)
        Me.TxtSaldoTotal.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo Total"
        '
        'Txtmonto
        '
        Me.Txtmonto.Location = New System.Drawing.Point(114, 75)
        Me.Txtmonto.Name = "Txtmonto"
        Me.Txtmonto.Size = New System.Drawing.Size(140, 20)
        Me.Txtmonto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxCliente)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelefono)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.TextBoxRazonSocial)
        Me.GroupBox1.Controls.Add(Me.TextBoxRfc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 143)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Cliente"
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(81, 18)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(268, 20)
        Me.TextBoxCliente.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(475, 107)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxTelefono.TabIndex = 9
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(81, 107)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(268, 20)
        Me.TextBoxEmail.TabIndex = 8
        '
        'TextBoxRazonSocial
        '
        Me.TextBoxRazonSocial.Location = New System.Drawing.Point(81, 65)
        Me.TextBoxRazonSocial.Name = "TextBoxRazonSocial"
        Me.TextBoxRazonSocial.Size = New System.Drawing.Size(268, 20)
        Me.TextBoxRazonSocial.TabIndex = 7
        '
        'TextBoxRfc
        '
        Me.TextBoxRfc.Location = New System.Drawing.Point(475, 67)
        Me.TextBoxRfc.Name = "TextBoxRfc"
        Me.TextBoxRfc.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxRfc.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(400, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Razon Social"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "RFC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.DataGridViewabonos)
        Me.TabPage2.Controls.Add(Me.AbonoCuenta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(739, 403)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Abonos a Cuenta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TxtRfcAbono)
        Me.GroupBox3.Controls.Add(Me.TxtEmailAbono)
        Me.GroupBox3.Controls.Add(Me.TxtSaldoFinalAbono)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtTelefonoAbono)
        Me.GroupBox3.Controls.Add(Me.TxtNombreAbono)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(703, 112)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion del Cliente"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(407, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "RFC"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(264, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Email"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Nombre"
        '
        'TxtRfcAbono
        '
        Me.TxtRfcAbono.Location = New System.Drawing.Point(441, 22)
        Me.TxtRfcAbono.Name = "TxtRfcAbono"
        Me.TxtRfcAbono.ReadOnly = True
        Me.TxtRfcAbono.Size = New System.Drawing.Size(156, 20)
        Me.TxtRfcAbono.TabIndex = 3
        '
        'TxtEmailAbono
        '
        Me.TxtEmailAbono.Location = New System.Drawing.Point(302, 52)
        Me.TxtEmailAbono.Name = "TxtEmailAbono"
        Me.TxtEmailAbono.ReadOnly = True
        Me.TxtEmailAbono.Size = New System.Drawing.Size(295, 20)
        Me.TxtEmailAbono.TabIndex = 2
        '
        'TxtSaldoFinalAbono
        '
        Me.TxtSaldoFinalAbono.Location = New System.Drawing.Point(92, 78)
        Me.TxtSaldoFinalAbono.Name = "TxtSaldoFinalAbono"
        Me.TxtSaldoFinalAbono.ReadOnly = True
        Me.TxtSaldoFinalAbono.Size = New System.Drawing.Size(140, 20)
        Me.TxtSaldoFinalAbono.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Saldo"
        '
        'TxtTelefonoAbono
        '
        Me.TxtTelefonoAbono.Location = New System.Drawing.Point(92, 52)
        Me.TxtTelefonoAbono.Name = "TxtTelefonoAbono"
        Me.TxtTelefonoAbono.ReadOnly = True
        Me.TxtTelefonoAbono.Size = New System.Drawing.Size(154, 20)
        Me.TxtTelefonoAbono.TabIndex = 1
        '
        'TxtNombreAbono
        '
        Me.TxtNombreAbono.Location = New System.Drawing.Point(92, 22)
        Me.TxtNombreAbono.Name = "TxtNombreAbono"
        Me.TxtNombreAbono.ReadOnly = True
        Me.TxtNombreAbono.Size = New System.Drawing.Size(307, 20)
        Me.TxtNombreAbono.TabIndex = 0
        '
        'DataGridViewabonos
        '
        Me.DataGridViewabonos.AllowUserToAddRows = False
        Me.DataGridViewabonos.AllowUserToDeleteRows = False
        Me.DataGridViewabonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewabonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewabonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewabonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_abono, Me.saldo_anterior, Me.saldo_final})
        Me.DataGridViewabonos.Location = New System.Drawing.Point(6, 225)
        Me.DataGridViewabonos.Name = "DataGridViewabonos"
        Me.DataGridViewabonos.ReadOnly = True
        Me.DataGridViewabonos.Size = New System.Drawing.Size(703, 159)
        Me.DataGridViewabonos.TabIndex = 1
        '
        'AbonoCuenta
        '
        Me.AbonoCuenta.Controls.Add(Me.ButtonGuardarAbono)
        Me.AbonoCuenta.Controls.Add(Me.ComboBoxMetodoPagoAbono)
        Me.AbonoCuenta.Controls.Add(Me.Label19)
        Me.AbonoCuenta.Controls.Add(Me.ButtonBuscarFactura)
        Me.AbonoCuenta.Controls.Add(Me.TxtAbonoAbono)
        Me.AbonoCuenta.Controls.Add(Me.Label11)
        Me.AbonoCuenta.Controls.Add(Me.TxtNofacturaAbono)
        Me.AbonoCuenta.Controls.Add(Me.Label14)
        Me.AbonoCuenta.Location = New System.Drawing.Point(6, 124)
        Me.AbonoCuenta.Name = "AbonoCuenta"
        Me.AbonoCuenta.Size = New System.Drawing.Size(703, 95)
        Me.AbonoCuenta.TabIndex = 0
        Me.AbonoCuenta.TabStop = False
        Me.AbonoCuenta.Text = "Abono a Cuenta"
        '
        'ButtonGuardarAbono
        '
        Me.ButtonGuardarAbono.Location = New System.Drawing.Point(576, 58)
        Me.ButtonGuardarAbono.Name = "ButtonGuardarAbono"
        Me.ButtonGuardarAbono.Size = New System.Drawing.Size(107, 28)
        Me.ButtonGuardarAbono.TabIndex = 23
        Me.ButtonGuardarAbono.Text = "Aplicar Pago"
        Me.ButtonGuardarAbono.UseVisualStyleBackColor = True
        '
        'ComboBoxMetodoPagoAbono
        '
        Me.ComboBoxMetodoPagoAbono.FormattingEnabled = True
        Me.ComboBoxMetodoPagoAbono.Location = New System.Drawing.Point(543, 31)
        Me.ComboBoxMetodoPagoAbono.Name = "ComboBoxMetodoPagoAbono"
        Me.ComboBoxMetodoPagoAbono.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxMetodoPagoAbono.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(451, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Metodo de Pago"
        '
        'ButtonBuscarFactura
        '
        Me.ButtonBuscarFactura.Location = New System.Drawing.Point(145, 58)
        Me.ButtonBuscarFactura.Name = "ButtonBuscarFactura"
        Me.ButtonBuscarFactura.Size = New System.Drawing.Size(65, 23)
        Me.ButtonBuscarFactura.TabIndex = 17
        Me.ButtonBuscarFactura.Text = "Buscar"
        Me.ButtonBuscarFactura.UseVisualStyleBackColor = True
        '
        'TxtAbonoAbono
        '
        Me.TxtAbonoAbono.Location = New System.Drawing.Point(305, 32)
        Me.TxtAbonoAbono.Name = "TxtAbonoAbono"
        Me.TxtAbonoAbono.Size = New System.Drawing.Size(113, 20)
        Me.TxtAbonoAbono.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(229, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Monto abono"
        '
        'TxtNofacturaAbono
        '
        Me.TxtNofacturaAbono.Location = New System.Drawing.Point(99, 32)
        Me.TxtNofacturaAbono.Name = "TxtNofacturaAbono"
        Me.TxtNofacturaAbono.Size = New System.Drawing.Size(111, 20)
        Me.TxtNofacturaAbono.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "No. Factura"
        '
        'fecha_abono
        '
        Me.fecha_abono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_abono.DataPropertyName = "fecha_abono"
        Me.fecha_abono.HeaderText = "Fecha de pago"
        Me.fecha_abono.Name = "fecha_abono"
        Me.fecha_abono.ReadOnly = True
        Me.fecha_abono.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_abono.Width = 74
        '
        'saldo_anterior
        '
        Me.saldo_anterior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.saldo_anterior.DataPropertyName = "saldo_anterior"
        Me.saldo_anterior.HeaderText = "Ultimo abono"
        Me.saldo_anterior.Name = "saldo_anterior"
        Me.saldo_anterior.ReadOnly = True
        Me.saldo_anterior.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.saldo_anterior.Width = 87
        '
        'saldo_final
        '
        Me.saldo_final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.saldo_final.DataPropertyName = "saldo_final"
        Me.saldo_final.HeaderText = "Saldo final"
        Me.saldo_final.Name = "saldo_final"
        Me.saldo_final.ReadOnly = True
        Me.saldo_final.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.saldo_final.Width = 75
        '
        'CuentasCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 476)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CuentasCobrar"
        Me.Text = "CuentasCobrar"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewabonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbonoCuenta.ResumeLayout(False)
        Me.AbonoCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtmonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxRazonSocial As TextBox
    Friend WithEvents TextBoxRfc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSaldoTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxmetodopago As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AbonoCuenta As GroupBox
    Friend WithEvents TxtNofacturaAbono As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAnticipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNotaFactura As TextBox
    Friend WithEvents TxtAbonoAbono As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridViewabonos As DataGridView
    Friend WithEvents TxtSaldoFinalAbono As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonBuscarFactura As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtRfcAbono As TextBox
    Friend WithEvents TxtEmailAbono As TextBox
    Friend WithEvents TxtTelefonoAbono As TextBox
    Friend WithEvents TxtNombreAbono As TextBox
    Friend WithEvents ComboBoxMetodoPagoAbono As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonGuardarAbono As Button
    Friend WithEvents fecha_abono As DataGridViewTextBoxColumn
    Friend WithEvents saldo_anterior As DataGridViewTextBoxColumn
    Friend WithEvents saldo_final As DataGridViewTextBoxColumn
End Class
