Imports _2___NG_BANK.NGBank
Public Class contaCorrente
    Public titular As NGBank.Cliente
    Public conta As Integer
    Public agencia As Integer
    Public saldo As Double = 100
    Public extrato As String = " "

    ' Definindo uma função
    Public Function sacar(valorSacar As Double) As Boolean

        Dim retorno As Boolean

        If saldo < valorSacar Then
            retorno = False
        Else
            saldo -= valorSacar
            retorno = True
        End If

        Return retorno


    End Function

    Public Function transferir(valorTransferencia As Double, ByRef contaDestino As contaCorrente) As Boolean
        Dim retorno As Boolean

        If saldo < valorTransferencia Then
            retorno = False
        Else
            saldo -= valorTransferencia
            contaDestino.Depositar(valorTransferencia)
            retorno = True
        End If

        Return retorno


    End Function

    Public Sub Depositar(valorDepositar As Double)
        saldo += valorDepositar
    End Sub

End Class