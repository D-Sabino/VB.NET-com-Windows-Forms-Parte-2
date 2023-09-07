Public Class ContaCorrente
    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double = 100

    Public Function Sacar(ValorSacar As Double) As Boolean
        Dim Retorno As Boolean

        If Saldo < ValorSacar Then
            Retorno = False
        Else
            Saldo -= ValorSacar
            Retorno = True
        End If

        Return Retorno
    End Function

    Public Sub Depositar(ValorDepositar As Double)
        Saldo += ValorDepositar
    End Sub

End Class

