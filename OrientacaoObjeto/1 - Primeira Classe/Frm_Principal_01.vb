Public Class Frm_Principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira classe"
        lbl_Principal.Text = "1 - Primeira classe"
        btm_acao.Text = "Conta Daniela"
        btm_acao2.Text = "Conta Bruno"
        btm_ValRef.Text = "Clique aqui"
        lbl_saldo.Text = "Saldo"
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

    Private Sub btm_acao2_Click(sender As Object, e As EventArgs) Handles btm_acao2.Click
        Dim ContaDoBruno As New ContaCorrente



    End Sub

    Private Sub btm_ValRef_Click(sender As Object, e As EventArgs) Handles btm_ValRef.Click

        'Variavel de valor
        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        idade = 30

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        'Variavel de referencia
        Dim ContaGabriela As New ContaCorrente()
        Dim ContaDaGabrielaCosta As New ContaCorrente()

        ContaGabriela.Titular = "Gabriela"
        ContaGabriela.Agencia = 863
        ContaGabriela.Conta = 863141

        ContaDaGabrielaCosta = ContaGabriela

        MsgBox("Valor da ContaGabriela " + ContaGabriela.Saldo.ToString + " ContaDaGabrielaCosta " + ContaDaGabrielaCosta.Saldo.ToString)

        ContaGabriela.Saldo = 300

        MsgBox("Valor da ContaGabriela " + ContaGabriela.Saldo.ToString + " ContaDaGabrielaCosta " + ContaDaGabrielaCosta.Saldo.ToString)


    End Sub
End Class
