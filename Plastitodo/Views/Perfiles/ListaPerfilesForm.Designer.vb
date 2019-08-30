<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaPerfilesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaPerfilesForm))
        Me.DgvPerfiles = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.DgvPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPerfiles
        '
        Me.DgvPerfiles.AllowUserToAddRows = False
        Me.DgvPerfiles.AllowUserToDeleteRows = False
        Me.DgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPerfiles.Location = New System.Drawing.Point(12, 48)
        Me.DgvPerfiles.Name = "DgvPerfiles"
        Me.DgvPerfiles.ReadOnly = True
        Me.DgvPerfiles.Size = New System.Drawing.Size(315, 225)
        Me.DgvPerfiles.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNuevo.Location = New System.Drawing.Point(297, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(30, 30)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'ListaPerfilesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 285)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvPerfiles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListaPerfilesForm"
        Me.Text = "Perfiles"
        CType(Me.DgvPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvPerfiles As DataGridView
    Friend WithEvents BtnNuevo As Button
End Class
