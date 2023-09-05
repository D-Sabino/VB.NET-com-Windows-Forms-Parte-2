<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_01
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
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.btm_acao = New System.Windows.Forms.Button()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.lbl_incremento = New System.Windows.Forms.Label()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.txt_incremento = New System.Windows.Forms.TextBox()
        Me.btm_acao2 = New System.Windows.Forms.Button()
        Me.btm_ValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal.TabIndex = 0
        Me.lbl_Principal.Text = "Label1"
        '
        'btm_acao
        '
        Me.btm_acao.Location = New System.Drawing.Point(12, 29)
        Me.btm_acao.Name = "btm_acao"
        Me.btm_acao.Size = New System.Drawing.Size(130, 42)
        Me.btm_acao.TabIndex = 1
        Me.btm_acao.Text = "Button1"
        Me.btm_acao.UseVisualStyleBackColor = True
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Location = New System.Drawing.Point(9, 89)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(51, 17)
        Me.lbl_saldo.TabIndex = 2
        Me.lbl_saldo.Text = "Label1"
        '
        'lbl_incremento
        '
        Me.lbl_incremento.AutoSize = True
        Me.lbl_incremento.Location = New System.Drawing.Point(155, 89)
        Me.lbl_incremento.Name = "lbl_incremento"
        Me.lbl_incremento.Size = New System.Drawing.Size(51, 17)
        Me.lbl_incremento.TabIndex = 3
        Me.lbl_incremento.Text = "Label2"
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(12, 109)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(100, 22)
        Me.txt_saldo.TabIndex = 4
        '
        'txt_incremento
        '
        Me.txt_incremento.Location = New System.Drawing.Point(158, 109)
        Me.txt_incremento.Name = "txt_incremento"
        Me.txt_incremento.Size = New System.Drawing.Size(100, 22)
        Me.txt_incremento.TabIndex = 5
        '
        'btm_acao2
        '
        Me.btm_acao2.Location = New System.Drawing.Point(369, 29)
        Me.btm_acao2.Name = "btm_acao2"
        Me.btm_acao2.Size = New System.Drawing.Size(130, 42)
        Me.btm_acao2.TabIndex = 6
        Me.btm_acao2.Text = "Button1"
        Me.btm_acao2.UseVisualStyleBackColor = True
        '
        'btm_ValRef
        '
        Me.btm_ValRef.Location = New System.Drawing.Point(523, 29)
        Me.btm_ValRef.Name = "btm_ValRef"
        Me.btm_ValRef.Size = New System.Drawing.Size(130, 42)
        Me.btm_ValRef.TabIndex = 7
        Me.btm_ValRef.Text = "Button1"
        Me.btm_ValRef.UseVisualStyleBackColor = True
        '
        'Frm_Principal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btm_ValRef)
        Me.Controls.Add(Me.btm_acao2)
        Me.Controls.Add(Me.txt_incremento)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.lbl_incremento)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.btm_acao)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "Frm_Principal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_acao As Button
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents lbl_incremento As Label
    Friend WithEvents txt_saldo As TextBox
    Friend WithEvents txt_incremento As TextBox
    Friend WithEvents btm_acao2 As Button
    Friend WithEvents btm_ValRef As Button
End Class
