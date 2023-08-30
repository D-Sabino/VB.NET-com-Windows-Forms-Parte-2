Public Class Frm_Principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira classe"
        lbl_Principal.Text = "1 - Primeira classe"
        btm_acao.Text = "Conta Daniela"
        lbl_saldo = "Saldo"
        lbl_incremento.Text = "Incremento"
    End Sub

    Private Sub btm_acao_Click(sender As Object, e As EventArgs) Handles btm_acao.Click

        'Dim Titular As String = "Gabriela"
        'Dim Agencia As Integer = 863
        'Dim Contar As Integer = 863141
        'Dim Saldo As Integer = 100

        Dim ContaDaDaniela As New ContaCorrente
        ContaDaDaniela.Titular = "Daniela"
        ContaDaDaniela.Agencia = 863
        ContaDaDaniela.Conta = 863141
        ContaDaDaniela.Saldo = Val(txt_saldo.Text)

        MsgBox("O Saldo da " + ContaDaDaniela.Titular + " na C/C " + ContaDaDaniela.Agencia.ToString _
               + " - " + ContaDaDaniela.Conta.ToString + " é " + ContaDaDaniela.Saldo.ToString)

        Dim vIncremento As Double = Val(txt_incremento.Text)
        ContaDaDaniela.Saldo += vIncremento

    End Sub
End Class
