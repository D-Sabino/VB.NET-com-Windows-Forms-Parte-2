<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Principal02 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Principal02
        '
        Me.lbl_Principal02.AutoSize = True
        Me.lbl_Principal02.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Principal02.Name = "lbl_Principal02"
        Me.lbl_Principal02.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal02.TabIndex = 0
        Me.lbl_Principal02.Text = "Label1"
        '
        'Frm_Principal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Principal02)
        Me.Name = "Frm_Principal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal02"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal02 As Label
End Class
