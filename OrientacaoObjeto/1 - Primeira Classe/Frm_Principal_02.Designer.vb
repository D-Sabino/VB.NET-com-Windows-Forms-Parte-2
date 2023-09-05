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
        Me.lbl_ValorSacar = New System.Windows.Forms.Label()
        Me.txt_ValorSacar = New System.Windows.Forms.TextBox()
        Me.btm_Sacar = New System.Windows.Forms.Button()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.txt_ResultadoSaque = New System.Windows.Forms.TextBox()
        Me.lbl_ResultadoSaque = New System.Windows.Forms.Label()
        Me.txt_SaldoAtual = New System.Windows.Forms.TextBox()
        Me.lbl_SaldoAtual = New System.Windows.Forms.Label()
        Me.lbl_BemVindo = New System.Windows.Forms.Label()
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
        'lbl_ValorSacar
        '
        Me.lbl_ValorSacar.AutoSize = True
        Me.lbl_ValorSacar.Location = New System.Drawing.Point(12, 169)
        Me.lbl_ValorSacar.Name = "lbl_ValorSacar"
        Me.lbl_ValorSacar.Size = New System.Drawing.Size(51, 17)
        Me.lbl_ValorSacar.TabIndex = 1
        Me.lbl_ValorSacar.Text = "Label1"
        '
        'txt_ValorSacar
        '
        Me.txt_ValorSacar.Location = New System.Drawing.Point(15, 189)
        Me.txt_ValorSacar.Name = "txt_ValorSacar"
        Me.txt_ValorSacar.Size = New System.Drawing.Size(267, 22)
        Me.txt_ValorSacar.TabIndex = 2
        '
        'btm_Sacar
        '
        Me.btm_Sacar.Location = New System.Drawing.Point(15, 217)
        Me.btm_Sacar.Name = "btm_Sacar"
        Me.btm_Sacar.Size = New System.Drawing.Size(267, 29)
        Me.btm_Sacar.TabIndex = 3
        Me.btm_Sacar.Text = "Button1"
        Me.btm_Sacar.UseVisualStyleBackColor = True
        '
        'txt_Saldo
        '
        Me.txt_Saldo.Location = New System.Drawing.Point(15, 290)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.Size = New System.Drawing.Size(267, 22)
        Me.txt_Saldo.TabIndex = 5
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.AutoSize = True
        Me.lbl_Saldo.Location = New System.Drawing.Point(12, 270)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Saldo.TabIndex = 4
        Me.lbl_Saldo.Text = "Label1"
        '
        'txt_ResultadoSaque
        '
        Me.txt_ResultadoSaque.Location = New System.Drawing.Point(15, 340)
        Me.txt_ResultadoSaque.Name = "txt_ResultadoSaque"
        Me.txt_ResultadoSaque.Size = New System.Drawing.Size(267, 22)
        Me.txt_ResultadoSaque.TabIndex = 7
        '
        'lbl_ResultadoSaque
        '
        Me.lbl_ResultadoSaque.AutoSize = True
        Me.lbl_ResultadoSaque.Location = New System.Drawing.Point(12, 320)
        Me.lbl_ResultadoSaque.Name = "lbl_ResultadoSaque"
        Me.lbl_ResultadoSaque.Size = New System.Drawing.Size(51, 17)
        Me.lbl_ResultadoSaque.TabIndex = 6
        Me.lbl_ResultadoSaque.Text = "Label1"
        '
        'txt_SaldoAtual
        '
        Me.txt_SaldoAtual.Location = New System.Drawing.Point(15, 131)
        Me.txt_SaldoAtual.Name = "txt_SaldoAtual"
        Me.txt_SaldoAtual.Size = New System.Drawing.Size(267, 22)
        Me.txt_SaldoAtual.TabIndex = 9
        '
        'lbl_SaldoAtual
        '
        Me.lbl_SaldoAtual.AutoSize = True
        Me.lbl_SaldoAtual.Location = New System.Drawing.Point(12, 111)
        Me.lbl_SaldoAtual.Name = "lbl_SaldoAtual"
        Me.lbl_SaldoAtual.Size = New System.Drawing.Size(51, 17)
        Me.lbl_SaldoAtual.TabIndex = 8
        Me.lbl_SaldoAtual.Text = "Label1"
        '
        'lbl_BemVindo
        '
        Me.lbl_BemVindo.AutoSize = True
        Me.lbl_BemVindo.Location = New System.Drawing.Point(12, 61)
        Me.lbl_BemVindo.Name = "lbl_BemVindo"
        Me.lbl_BemVindo.Size = New System.Drawing.Size(51, 17)
        Me.lbl_BemVindo.TabIndex = 10
        Me.lbl_BemVindo.Text = "Label1"
        '
        'Frm_Principal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_BemVindo)
        Me.Controls.Add(Me.txt_SaldoAtual)
        Me.Controls.Add(Me.lbl_SaldoAtual)
        Me.Controls.Add(Me.txt_ResultadoSaque)
        Me.Controls.Add(Me.lbl_ResultadoSaque)
        Me.Controls.Add(Me.txt_Saldo)
        Me.Controls.Add(Me.lbl_Saldo)
        Me.Controls.Add(Me.btm_Sacar)
        Me.Controls.Add(Me.txt_ValorSacar)
        Me.Controls.Add(Me.lbl_ValorSacar)
        Me.Controls.Add(Me.lbl_Principal02)
        Me.Name = "Frm_Principal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal02"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal02 As Label
    Friend WithEvents lbl_ValorSacar As Label
    Friend WithEvents txt_ValorSacar As TextBox
    Friend WithEvents btm_Sacar As Button
    Friend WithEvents txt_Saldo As TextBox
    Friend WithEvents lbl_Saldo As Label
    Friend WithEvents txt_ResultadoSaque As TextBox
    Friend WithEvents lbl_ResultadoSaque As Label
    Friend WithEvents txt_SaldoAtual As TextBox
    Friend WithEvents lbl_SaldoAtual As Label
    Friend WithEvents lbl_BemVindo As Label
End Class
