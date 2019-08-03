<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradasMerca
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TEntradasMerca = New System.Windows.Forms.TabPage()
        Me.BGuardardetaentramerca = New System.Windows.Forms.Button()
        Me.Tcosto = New System.Windows.Forms.TextBox()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Tdescripcion = New System.Windows.Forms.TextBox()
        Me.Tcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TEntradasMerca.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TEntradasMerca)
        Me.TabControl1.Location = New System.Drawing.Point(8, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 342)
        Me.TabControl1.TabIndex = 1
        '
        'TEntradasMerca
        '
        Me.TEntradasMerca.Controls.Add(Me.BGuardardetaentramerca)
        Me.TEntradasMerca.Controls.Add(Me.Tcosto)
        Me.TEntradasMerca.Controls.Add(Me.Tcantidad)
        Me.TEntradasMerca.Controls.Add(Me.Tdescripcion)
        Me.TEntradasMerca.Controls.Add(Me.Tcodigo)
        Me.TEntradasMerca.Controls.Add(Me.Label4)
        Me.TEntradasMerca.Controls.Add(Me.Label3)
        Me.TEntradasMerca.Controls.Add(Me.Label2)
        Me.TEntradasMerca.Controls.Add(Me.Label1)
        Me.TEntradasMerca.Location = New System.Drawing.Point(4, 22)
        Me.TEntradasMerca.Name = "TEntradasMerca"
        Me.TEntradasMerca.Padding = New System.Windows.Forms.Padding(3)
        Me.TEntradasMerca.Size = New System.Drawing.Size(570, 316)
        Me.TEntradasMerca.TabIndex = 0
        Me.TEntradasMerca.Text = "Entradas"
        Me.TEntradasMerca.UseVisualStyleBackColor = True
        '
        'BGuardardetaentramerca
        '
        Me.BGuardardetaentramerca.Location = New System.Drawing.Point(489, 278)
        Me.BGuardardetaentramerca.Name = "BGuardardetaentramerca"
        Me.BGuardardetaentramerca.Size = New System.Drawing.Size(75, 23)
        Me.BGuardardetaentramerca.TabIndex = 1
        Me.BGuardardetaentramerca.Text = "Guardar"
        Me.BGuardardetaentramerca.UseVisualStyleBackColor = True
        '
        'Tcosto
        '
        Me.Tcosto.Location = New System.Drawing.Point(132, 212)
        Me.Tcosto.Name = "Tcosto"
        Me.Tcosto.Size = New System.Drawing.Size(100, 20)
        Me.Tcosto.TabIndex = 7
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(132, 158)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(100, 20)
        Me.Tcantidad.TabIndex = 6
        '
        'Tdescripcion
        '
        Me.Tdescripcion.Location = New System.Drawing.Point(132, 80)
        Me.Tdescripcion.Name = "Tdescripcion"
        Me.Tdescripcion.Size = New System.Drawing.Size(343, 20)
        Me.Tdescripcion.TabIndex = 5
        '
        'Tcodigo
        '
        Me.Tcodigo.Location = New System.Drawing.Point(132, 18)
        Me.Tcodigo.Name = "Tcodigo"
        Me.Tcodigo.Size = New System.Drawing.Size(165, 20)
        Me.Tcodigo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'EntradasMerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 394)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EntradasMerca"
        Me.Text = "Detalle de Entradas Mercancia"
        Me.TabControl1.ResumeLayout(False)
        Me.TEntradasMerca.ResumeLayout(False)
        Me.TEntradasMerca.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TEntradasMerca As TabPage
    Friend WithEvents BGuardardetaentramerca As Button
    Friend WithEvents Tcosto As TextBox
    Friend WithEvents Tcantidad As TextBox
    Friend WithEvents Tdescripcion As TextBox
    Friend WithEvents Tcodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
