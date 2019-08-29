<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntradasMerca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradasMerca))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxproducto = New System.Windows.Forms.TextBox()
        Me.Labelprecio = New System.Windows.Forms.Label()
        Me.TextBoxprecio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxcodigo = New System.Windows.Forms.TextBox()
        Me.BBuscarCodigo = New System.Windows.Forms.Button()
        Me.Buttonlimpiardatos = New System.Windows.Forms.Button()
        Me.DataGridViewdetalleentrada = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxprovee = New System.Windows.Forms.ComboBox()
        Me.BGuardardetaentramerca = New System.Windows.Forms.Button()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewdetalleentrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxproducto)
        Me.GroupBox2.Controls.Add(Me.Labelprecio)
        Me.GroupBox2.Controls.Add(Me.TextBoxprecio)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 126)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Descripción:"
        '
        'TextBoxproducto
        '
        Me.TextBoxproducto.Enabled = False
        Me.TextBoxproducto.Location = New System.Drawing.Point(137, 41)
        Me.TextBoxproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxproducto.Name = "TextBoxproducto"
        Me.TextBoxproducto.Size = New System.Drawing.Size(326, 22)
        Me.TextBoxproducto.TabIndex = 19
        '
        'Labelprecio
        '
        Me.Labelprecio.AutoSize = True
        Me.Labelprecio.Location = New System.Drawing.Point(7, 91)
        Me.Labelprecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprecio.Name = "Labelprecio"
        Me.Labelprecio.Size = New System.Drawing.Size(53, 16)
        Me.Labelprecio.TabIndex = 17
        Me.Labelprecio.Text = "Precio"
        '
        'TextBoxprecio
        '
        Me.TextBoxprecio.Location = New System.Drawing.Point(137, 88)
        Me.TextBoxprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxprecio.Name = "TextBoxprecio"
        Me.TextBoxprecio.ReadOnly = True
        Me.TextBoxprecio.Size = New System.Drawing.Size(180, 22)
        Me.TextBoxprecio.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxcodigo)
        Me.GroupBox1.Controls.Add(Me.BBuscarCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 78)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo Barras:"
        '
        'TextBoxcodigo
        '
        Me.TextBoxcodigo.Location = New System.Drawing.Point(138, 34)
        Me.TextBoxcodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxcodigo.MaxLength = 15
        Me.TextBoxcodigo.Name = "TextBoxcodigo"
        Me.TextBoxcodigo.Size = New System.Drawing.Size(213, 22)
        Me.TextBoxcodigo.TabIndex = 14
        '
        'BBuscarCodigo
        '
        Me.BBuscarCodigo.BackgroundImage = CType(resources.GetObject("BBuscarCodigo.BackgroundImage"), System.Drawing.Image)
        Me.BBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscarCodigo.Location = New System.Drawing.Point(398, 22)
        Me.BBuscarCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarCodigo.Name = "BBuscarCodigo"
        Me.BBuscarCodigo.Size = New System.Drawing.Size(57, 45)
        Me.BBuscarCodigo.TabIndex = 15
        Me.BBuscarCodigo.UseVisualStyleBackColor = True
        '
        'Buttonlimpiardatos
        '
        Me.Buttonlimpiardatos.BackgroundImage = CType(resources.GetObject("Buttonlimpiardatos.BackgroundImage"), System.Drawing.Image)
        Me.Buttonlimpiardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonlimpiardatos.Location = New System.Drawing.Point(874, 265)
        Me.Buttonlimpiardatos.Margin = New System.Windows.Forms.Padding(4)
        Me.Buttonlimpiardatos.Name = "Buttonlimpiardatos"
        Me.Buttonlimpiardatos.Size = New System.Drawing.Size(80, 62)
        Me.Buttonlimpiardatos.TabIndex = 31
        Me.Buttonlimpiardatos.UseVisualStyleBackColor = True
        '
        'DataGridViewdetalleentrada
        '
        Me.DataGridViewdetalleentrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewdetalleentrada.Location = New System.Drawing.Point(13, 230)
        Me.DataGridViewdetalleentrada.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewdetalleentrada.Name = "DataGridViewdetalleentrada"
        Me.DataGridViewdetalleentrada.Size = New System.Drawing.Size(738, 220)
        Me.DataGridViewdetalleentrada.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Proveedor:"
        '
        'ComboBoxprovee
        '
        Me.ComboBoxprovee.FormattingEnabled = True
        Me.ComboBoxprovee.Location = New System.Drawing.Point(123, 31)
        Me.ComboBoxprovee.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxprovee.Name = "ComboBoxprovee"
        Me.ComboBoxprovee.Size = New System.Drawing.Size(326, 24)
        Me.ComboBoxprovee.TabIndex = 28
        '
        'BGuardardetaentramerca
        '
        Me.BGuardardetaentramerca.BackgroundImage = CType(resources.GetObject("BGuardardetaentramerca.BackgroundImage"), System.Drawing.Image)
        Me.BGuardardetaentramerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BGuardardetaentramerca.Location = New System.Drawing.Point(874, 352)
        Me.BGuardardetaentramerca.Margin = New System.Windows.Forms.Padding(4)
        Me.BGuardardetaentramerca.Name = "BGuardardetaentramerca"
        Me.BGuardardetaentramerca.Size = New System.Drawing.Size(80, 62)
        Me.BGuardardetaentramerca.TabIndex = 25
        Me.BGuardardetaentramerca.UseVisualStyleBackColor = True
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(123, 85)
        Me.Tcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(180, 22)
        Me.Tcantidad.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Cantidad"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBoxprovee)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Tcantidad)
        Me.GroupBox3.Location = New System.Drawing.Point(515, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 126)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrada de mercancías"
        '
        'EntradasMerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 463)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Buttonlimpiardatos)
        Me.Controls.Add(Me.DataGridViewdetalleentrada)
        Me.Controls.Add(Me.BGuardardetaentramerca)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EntradasMerca"
        Me.Text = "Detalle de Entradas Mercancia"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewdetalleentrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxproducto As TextBox
    Friend WithEvents Labelprecio As Label
    Friend WithEvents TextBoxprecio As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxcodigo As TextBox
    Friend WithEvents BBuscarCodigo As Button
    Friend WithEvents Buttonlimpiardatos As Button
    Friend WithEvents DataGridViewdetalleentrada As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxprovee As ComboBox
    Friend WithEvents BGuardardetaentramerca As Button
    Friend WithEvents Tcantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
