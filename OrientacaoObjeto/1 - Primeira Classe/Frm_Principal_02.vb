Public Class Frm_Principal_02

    Dim ContaDaGabriela As New ContaCorrente

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"

        lbl_ValorSacar.Text = "Valor a ser sacado"
        btm_Sacar.Text = "Efetuar Saque"
        lbl_Saldo.Text = "Novo Saldo"
        lbl_ResultadoSaque.Text = "Resultado do Saque"
        lbl_SaldoAtual.Text = "Saldo atual"

        ' Inicializar os dados da classe:
        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        txt_SaldoAtual.Text = ContaDaGabriela.Saldo.ToString

        lbl_BemVindo.Text = "Bem vindo " + ContaDaGabriela.Titular + " Agencia: " + ContaDaGabriela.Agencia.ToString +
            "- Conta Corrente: " + ContaDaGabriela.Conta.ToString

    End Sub

    Private Sub btm_Sacar_Click(sender As Object, e As EventArgs) Handles btm_Sacar.Click

        Dim ValorSacar As Double = Val(txt_ValorSacar.Text)

        If ContaDaGabriela.Saldo >= ValorSacar Then
            ContaDaGabriela.Saldo -= ValorSacar

            txt_Saldo.Text = ContaDaGabriela.Saldo.ToString
            txt_ResultadoSaque.Text = "Saldo realizado com sucesso"

            txt_SaldoAtual.Text = ContaDaGabriela.Saldo.ToString
        Else
            txt_ResultadoSaque.Text = "Saque não pode ser realizado"
        End If
    End Sub
End Class