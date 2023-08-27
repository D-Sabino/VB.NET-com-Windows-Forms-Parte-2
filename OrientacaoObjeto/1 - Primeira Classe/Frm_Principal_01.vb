Public Class Frm_Principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira classe"
        lbl_Principal.Text = "1 - Primeira classe"
        btm_acao.Text = "Clique aqui"
    End Sub

    Private Sub btm_acao_Click(sender As Object, e As EventArgs) Handles btm_acao.Click

        Dim Titular As String = "Gabriela"
        Dim Agencia As Integer = 863
        Dim Contar As Integer = 863141
        Dim Saldo As Integer = 100

    End Sub
End Class
