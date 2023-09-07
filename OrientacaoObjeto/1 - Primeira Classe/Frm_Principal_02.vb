﻿Public Class Frm_Principal_02

    Dim ContaDaGabriela As New ContaCorrente
    Dim ContaDoBruno As New ContaCorrente

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"

        'Gabriela ------------------------------------------------------------------
        lbl_ValorSacar_Gabriela.Text = "Valor a ser depositado/sacado"
        btm_Sacar_Gabriela.Text = "Efetuar Saque"
        btm_Depositar_Gabriela.Text = "Efetuar Deposito"
        lbl_Saldo_Gabriela.Text = "Novo Saldo"
        lbl_ResultadoSaque_Gabriela.Text = "Resultado do Saque"
        lbl_SaldoAtual_Gabriela.Text = "Saldo atual"
        grp_Gabriela.Text = "Gabriela"

        txt_SaldoAtual_Gabriela.ReadOnly = True
        txt_Saldo_Gabriela.ReadOnly = True
        txt_Resultado_Gabriela.ReadOnly = True
        txt_Extrato_Gabriela.ReadOnly = True

        ' Inicializar os dados da classe:
        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

        lbl_BemVindo_Gabriela.Text = "Bem vindo " + ContaDaGabriela.Titular + " Agencia: " + ContaDaGabriela.Agencia.ToString +
            "- Conta Corrente: " + ContaDaGabriela.Conta.ToString


        'Bruno ------------------------------------------------------------------
        lbl_ValorSacar_Bruno.Text = "Valor a ser depositado/sacado"
        btm_Sacar_Bruno.Text = "Efetuar Saque"
        btm_Depositar_Bruno.Text = "Efetuar Deposito"
        lbl_Saldo_Bruno.Text = "Novo Saldo"
        lbl_ResultadoSaque_Bruno.Text = "Resultado do Saque"
        lbl_SaldoAtual_Bruno.Text = "Saldo atual"
        grp_Bruno.Text = "Bruno"

        txt_SaldoAtual_Bruno.ReadOnly = True
        txt_Saldo_Bruno.ReadOnly = True
        txt_Resultado_Bruno.ReadOnly = True
        txt_Extrato_Bruno.ReadOnly = True

        ' Inicializar os dados da classe:
        ContaDoBruno.Titular = "Bruno"
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863141

        txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

        lbl_BemVindo_Bruno.Text = "Bem vindo " + ContaDoBruno.Titular + " Agencia: " + ContaDoBruno.Agencia.ToString +
            "- Conta Corrente: " + ContaDoBruno.Conta.ToString
    End Sub

    Private Sub btm_Sacar_Click(sender As Object, e As EventArgs) Handles btm_Sacar_Gabriela.Click
        txt_Resultado_Gabriela.Text = ""
        txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(txt_Valor_Gabriela.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque Then
            txt_Resultado_Gabriela.Text = "Saldo realizado com sucesso"
            txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString

            ContaDaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
        Else
            txt_Resultado_Gabriela.Text = "Saque não pode ser realizado"
        End If
    End Sub

    Private Sub btm_Depositar_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Gabriela.Click
        txt_Resultado_Gabriela.Text = ""
        txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(txt_Valor_Gabriela.Text)
        ContaDaGabriela.Depositar(ValorDepositar)
        txt_Resultado_Gabriela.Text = "Deposito realizado com sucesso"
        txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

        ContaDaGabriela.Extrato += Now.ToString + " Deposito de " + ValorDepositar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
        txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
    End Sub

    Private Sub btm_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Bruno.Click
        txt_Resultado_Bruno.Text = ""
        txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(txt_Valor_Bruno.Text)
        ContaDoBruno.Depositar(ValorDepositar)
        txt_Resultado_Bruno.Text = "Deposito realizado com sucesso"
        txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

        ContaDoBruno.Extrato += Now.ToString + " Deposito de " + ValorDepositar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
        txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub btm_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles btm_Sacar_Bruno.Click
        txt_Resultado_Bruno.Text = ""
        txt_Saldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(txt_Valor_Bruno.Text)
        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque Then
            txt_Resultado_Bruno.Text = "Saldo realizado com sucesso"
            txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            ContaDoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
            txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        Else
            txt_Resultado_Bruno.Text = "Saque não pode ser realizado"
        End If
    End Sub
End Class