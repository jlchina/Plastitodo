<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_Inv
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
        Me.Visor_reportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Inventarios1 = New Plastitodo.Inventarios()
        Me.SuspendLayout()
        '
        'Visor_reportes
        '
        Me.Visor_reportes.ActiveViewIndex = -1
        Me.Visor_reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visor_reportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.Visor_reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visor_reportes.Location = New System.Drawing.Point(0, 0)
        Me.Visor_reportes.Name = "Visor_reportes"
        Me.Visor_reportes.ReportSource = Me.Inventarios1
        Me.Visor_reportes.Size = New System.Drawing.Size(800, 450)
        Me.Visor_reportes.TabIndex = 0
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Visor_reportes)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Visor_reportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Inventarios1 As Inventarios
End Class
