Imports _2___NG_BANK.NGBank
Public Class frmPrincipal

    Dim contaCorrente As New contaCorrente
    Dim contaCorrente2 As New contaCorrente

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = " NG BANK"
        lblPrincipal_02.Text = "Área de Operações "
        lblValorSacar.Text = "Valor a ser sacado"
        btnSacar.Text = "Confirma"
        lblSaldo.Text = "Novo Saldo"
        lblResultadoSaque.Text = "Resultado da Operação"
        lblSaldoAtual.Text = "Saldo Atual"
        btnFinalizar.Text = "Finalizar Operação"
        gpbSaque.Text = "Saque"

        lblTitular.Text = "Titular"
        lblAgencia.Text = "Agencia"
        lblConta.Text = "Conta"
        gpbDadosConta.Text = "Dados da Conta"


        btnDepositar.Text = "Confirma"
        lbldeposito.Text = "Valor do depósito"
        gpbDeposito.Text = "Depósito"

        'INICIALIZAR OS DADOS DA CLASSE

        Dim Gabriela As New Cliente()
        Gabriela.Nome = "Gabriela"
        Gabriela.Sobrenome = "Portela"
        Gabriela.genero = "Feminimo"
        Gabriela.idade = 35
        Gabriela.cpf = "7023595200"
        Gabriela.profissao = "Analista de Sistemas"
        Gabriela.cidade = "Rio de Janeiro"


        contaCorrente.titular = Gabriela
        contaCorrente.agencia = "86956"
        contaCorrente.conta = "12569874"
        contaCorrente.saldo = "2000"
        txtSaldoAtual.Text = contaCorrente.saldo.ToString
        txtTitular.Text = Gabriela.Nome + "  " + Gabriela.Sobrenome
        txtAgencia.Text = contaCorrente.agencia
        txtConta.Text = contaCorrente.conta

        btnTransferencia.Text = "Confirma"
        lblTransferencia.Text = "Realizar Transferência"
        gpbTransferencia.Text = "Transferência"

        'INICIALIZAR OS DADOS DA CLASSE
        Dim Tales As New Cliente()
        Tales.Nome = "Tales"
        Tales.cpf = "50267894125"
        Tales.profissao = "Cabelereiro"
        Tales.cidade = "Alexandria"

        contaCorrente2.titular = Tales
        contaCorrente2.agencia = "65987523"
        contaCorrente2.conta = "65987523"


    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click


        Dim valorSacar As Double = (txtValorSacar.Text)


        Dim retornoSaque As Boolean = contaCorrente.sacar(valorSacar)

        If retornoSaque = False Then
            txtResultadoSaque.ForeColor = Color.Red
            txtResultadoSaque.Text = "Não foi possível realizar o saque!"

        Else retornoSaque = True
            txtSaldo.Text = contaCorrente.saldo.ToString
            txtResultadoSaque.ForeColor = Color.Green
            txtResultadoSaque.Text = "Saque efetuado com sucesso!"
            txtSaldoAtual.Text = txtSaldo.Text
            contaCorrente.extrato += Now.ToString + vbCrLf + "Saque de R$  " + valorSacar.ToString + vbCrLf + "Saldo R$  " + contaCorrente.saldo.ToString + vbCrLf
            txtExtrato.Text = contaCorrente.extrato

        End If



    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click


        txtResultadoSaque.Text = " "
        txtValorSacar.Text = " "
        txtSaldo.Text = " "
        txtDeposito.Text = " "
        txtExtrato.Text = " "

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click

        txtResultadoSaque.Text = " "
        txtSaldo.Text = " "

        Dim valorDepositar As Double = Val(txtDeposito.Text)
        contaCorrente.Depositar(valorDepositar)
        txtSaldo.Text = contaCorrente.saldo.ToString
        txtResultadoSaque.ForeColor = Color.Green
        txtResultadoSaque.Text = "Depósito efetuado com sucesso!"
        txtSaldoAtual.Text = txtSaldo.Text

        contaCorrente.extrato += Now.ToString + vbCrLf + " Depósito de R$  " + valorDepositar.ToString + vbCrLf + "Saldo R$  " + contaCorrente.saldo.ToString + vbCrLf
        txtExtrato.Text = contaCorrente.extrato




    End Sub

    Private Sub txtExtrato_TextChanged(sender As Object, e As EventArgs) Handles txtExtrato.TextChanged

    End Sub

    Private Sub btnTransferencia_Click(sender As Object, e As EventArgs) Handles btnTransferencia.Click
        txtResultadoSaque.Text = " "
        txtSaldo.Text = " "

        Dim valorTransferir As Double = Val(txtTranferenciaValor.Text)

        Dim retornoTransferencia As Boolean = contaCorrente.transferir(valorTransferir, contaCorrente2)

        If retornoTransferencia = False Then
            txtResultadoSaque.ForeColor = Color.Red
            txtResultadoSaque.Text = "Não foi possível realizar a tranferencia!"

        Else retornoTransferencia = True
            txtSaldo.Text = contaCorrente.saldo.ToString
            txtResultadoSaque.ForeColor = Color.Green
            txtResultadoSaque.Text = "Transferência  efetuada com sucesso!"
            txtSaldoAtual.Text = txtSaldo.Text
            contaCorrente.extrato += Now.ToString + vbCrLf + " Transferência de R$  " + valorTransferir.ToString + vbCrLf + "Saldo R$  " + contaCorrente.saldo.ToString + vbCrLf
            txtExtrato.Text = contaCorrente.extrato

        End If

    End Sub

End Class
