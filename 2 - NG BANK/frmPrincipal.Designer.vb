<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpbSaque = New GroupBox()
        txtSaldoAtual = New TextBox()
        lblValorSacar = New Label()
        txtValorSacar = New TextBox()
        btnSacar = New Button()
        lblSaldoAtual = New Label()
        gpbDeposito = New GroupBox()
        txtDeposito = New TextBox()
        btnDepositar = New Button()
        lbldeposito = New Label()
        btnFinalizar = New Button()
        gpbDadosConta = New GroupBox()
        txtConta = New TextBox()
        lblAgencia = New Label()
        txtAgencia = New TextBox()
        lblTitular = New Label()
        txtTitular = New TextBox()
        lblConta = New Label()
        txtResultadoSaque = New TextBox()
        lblResultadoSaque = New Label()
        txtSaldo = New TextBox()
        lblSaldo = New Label()
        lblPrincipal_02 = New Label()
        txtExtrato = New TextBox()
        btnTransferencia = New Button()
        lblTransferencia = New Label()
        txtTranferenciaValor = New TextBox()
        gpbTransferencia = New GroupBox()
        gpbSaque.SuspendLayout()
        gpbDeposito.SuspendLayout()
        gpbDadosConta.SuspendLayout()
        gpbTransferencia.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpbSaque
        ' 
        gpbSaque.Controls.Add(txtSaldoAtual)
        gpbSaque.Controls.Add(lblValorSacar)
        gpbSaque.Controls.Add(txtValorSacar)
        gpbSaque.Controls.Add(btnSacar)
        gpbSaque.Controls.Add(lblSaldoAtual)
        gpbSaque.ForeColor = Color.DarkBlue
        gpbSaque.Location = New Point(13, 36)
        gpbSaque.Name = "gpbSaque"
        gpbSaque.Size = New Size(299, 150)
        gpbSaque.TabIndex = 25
        gpbSaque.TabStop = False
        gpbSaque.Text = "GroupBox1"
        ' 
        ' txtSaldoAtual
        ' 
        txtSaldoAtual.BorderStyle = BorderStyle.FixedSingle
        txtSaldoAtual.Location = New Point(6, 39)
        txtSaldoAtual.Name = "txtSaldoAtual"
        txtSaldoAtual.Size = New Size(100, 23)
        txtSaldoAtual.TabIndex = 9
        ' 
        ' lblValorSacar
        ' 
        lblValorSacar.AutoSize = True
        lblValorSacar.Location = New Point(6, 79)
        lblValorSacar.Name = "lblValorSacar"
        lblValorSacar.Size = New Size(41, 15)
        lblValorSacar.TabIndex = 1
        lblValorSacar.Text = "Label1"
        ' 
        ' txtValorSacar
        ' 
        txtValorSacar.BorderStyle = BorderStyle.FixedSingle
        txtValorSacar.Location = New Point(6, 101)
        txtValorSacar.Name = "txtValorSacar"
        txtValorSacar.Size = New Size(100, 23)
        txtValorSacar.TabIndex = 2
        ' 
        ' btnSacar
        ' 
        btnSacar.BackColor = SystemColors.ScrollBar
        btnSacar.Location = New Point(114, 99)
        btnSacar.Name = "btnSacar"
        btnSacar.Size = New Size(100, 23)
        btnSacar.TabIndex = 3
        btnSacar.Text = "Button1"
        btnSacar.UseVisualStyleBackColor = False
        ' 
        ' lblSaldoAtual
        ' 
        lblSaldoAtual.AutoSize = True
        lblSaldoAtual.Location = New Point(6, 21)
        lblSaldoAtual.Name = "lblSaldoAtual"
        lblSaldoAtual.Size = New Size(41, 15)
        lblSaldoAtual.TabIndex = 8
        lblSaldoAtual.Text = "Label1"
        ' 
        ' gpbDeposito
        ' 
        gpbDeposito.Controls.Add(txtDeposito)
        gpbDeposito.Controls.Add(btnDepositar)
        gpbDeposito.Controls.Add(lbldeposito)
        gpbDeposito.ForeColor = Color.DarkBlue
        gpbDeposito.Location = New Point(13, 289)
        gpbDeposito.Name = "gpbDeposito"
        gpbDeposito.Size = New Size(299, 80)
        gpbDeposito.TabIndex = 24
        gpbDeposito.TabStop = False
        gpbDeposito.Text = "GroupBox1"
        ' 
        ' txtDeposito
        ' 
        txtDeposito.BorderStyle = BorderStyle.FixedSingle
        txtDeposito.Location = New Point(6, 46)
        txtDeposito.Name = "txtDeposito"
        txtDeposito.Size = New Size(100, 23)
        txtDeposito.TabIndex = 14
        ' 
        ' btnDepositar
        ' 
        btnDepositar.BackColor = SystemColors.ScrollBar
        btnDepositar.Location = New Point(125, 46)
        btnDepositar.Name = "btnDepositar"
        btnDepositar.Size = New Size(89, 23)
        btnDepositar.TabIndex = 12
        btnDepositar.Text = "Button1"
        btnDepositar.UseVisualStyleBackColor = False
        ' 
        ' lbldeposito
        ' 
        lbldeposito.AutoSize = True
        lbldeposito.Location = New Point(6, 28)
        lbldeposito.Name = "lbldeposito"
        lbldeposito.Size = New Size(41, 15)
        lbldeposito.TabIndex = 13
        lbldeposito.Text = "Label1"
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.BackColor = SystemColors.ActiveCaption
        btnFinalizar.Location = New Point(44, 260)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(183, 23)
        btnFinalizar.TabIndex = 23
        btnFinalizar.Text = "Button1"
        btnFinalizar.UseVisualStyleBackColor = False
        ' 
        ' gpbDadosConta
        ' 
        gpbDadosConta.Controls.Add(txtConta)
        gpbDadosConta.Controls.Add(lblAgencia)
        gpbDadosConta.Controls.Add(txtAgencia)
        gpbDadosConta.Controls.Add(lblTitular)
        gpbDadosConta.Controls.Add(txtTitular)
        gpbDadosConta.Controls.Add(lblConta)
        gpbDadosConta.ForeColor = Color.DarkBlue
        gpbDadosConta.Location = New Point(412, 36)
        gpbDadosConta.Margin = New Padding(6)
        gpbDadosConta.Name = "gpbDadosConta"
        gpbDadosConta.Size = New Size(210, 198)
        gpbDadosConta.TabIndex = 22
        gpbDadosConta.TabStop = False
        gpbDadosConta.Text = "GroupBox1"
        ' 
        ' txtConta
        ' 
        txtConta.Enabled = False
        txtConta.Location = New Point(4, 164)
        txtConta.Name = "txtConta"
        txtConta.ReadOnly = True
        txtConta.Size = New Size(100, 23)
        txtConta.TabIndex = 16
        ' 
        ' lblAgencia
        ' 
        lblAgencia.AutoSize = True
        lblAgencia.Location = New Point(6, 83)
        lblAgencia.Name = "lblAgencia"
        lblAgencia.Size = New Size(41, 15)
        lblAgencia.TabIndex = 13
        lblAgencia.Text = "Label1"
        ' 
        ' txtAgencia
        ' 
        txtAgencia.Enabled = False
        txtAgencia.Location = New Point(4, 108)
        txtAgencia.Name = "txtAgencia"
        txtAgencia.ReadOnly = True
        txtAgencia.Size = New Size(100, 23)
        txtAgencia.TabIndex = 15
        ' 
        ' lblTitular
        ' 
        lblTitular.AutoSize = True
        lblTitular.Location = New Point(6, 29)
        lblTitular.Name = "lblTitular"
        lblTitular.Size = New Size(41, 15)
        lblTitular.TabIndex = 11
        lblTitular.Text = "Label1"
        ' 
        ' txtTitular
        ' 
        txtTitular.Enabled = False
        txtTitular.Location = New Point(6, 47)
        txtTitular.Name = "txtTitular"
        txtTitular.ReadOnly = True
        txtTitular.Size = New Size(100, 23)
        txtTitular.TabIndex = 14
        ' 
        ' lblConta
        ' 
        lblConta.AutoSize = True
        lblConta.Location = New Point(6, 136)
        lblConta.Name = "lblConta"
        lblConta.Size = New Size(41, 15)
        lblConta.TabIndex = 12
        lblConta.Text = "Label1"
        ' 
        ' txtResultadoSaque
        ' 
        txtResultadoSaque.BackColor = SystemColors.ScrollBar
        txtResultadoSaque.BorderStyle = BorderStyle.FixedSingle
        txtResultadoSaque.Location = New Point(127, 230)
        txtResultadoSaque.Name = "txtResultadoSaque"
        txtResultadoSaque.ReadOnly = True
        txtResultadoSaque.Size = New Size(199, 23)
        txtResultadoSaque.TabIndex = 21
        ' 
        ' lblResultadoSaque
        ' 
        lblResultadoSaque.AutoSize = True
        lblResultadoSaque.Location = New Point(127, 213)
        lblResultadoSaque.Name = "lblResultadoSaque"
        lblResultadoSaque.Size = New Size(41, 15)
        lblResultadoSaque.TabIndex = 20
        lblResultadoSaque.Text = "Label1"
        ' 
        ' txtSaldo
        ' 
        txtSaldo.BackColor = SystemColors.ScrollBar
        txtSaldo.BorderStyle = BorderStyle.FixedSingle
        txtSaldo.Location = New Point(13, 231)
        txtSaldo.Name = "txtSaldo"
        txtSaldo.ReadOnly = True
        txtSaldo.Size = New Size(100, 23)
        txtSaldo.TabIndex = 19
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Location = New Point(13, 213)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(41, 15)
        lblSaldo.TabIndex = 18
        lblSaldo.Text = "Label1"
        ' 
        ' lblPrincipal_02
        ' 
        lblPrincipal_02.AutoSize = True
        lblPrincipal_02.Location = New Point(13, 9)
        lblPrincipal_02.Name = "lblPrincipal_02"
        lblPrincipal_02.Size = New Size(41, 15)
        lblPrincipal_02.TabIndex = 17
        lblPrincipal_02.Text = "Label1"
        ' 
        ' txtExtrato
        ' 
        txtExtrato.BackColor = SystemColors.ScrollBar
        txtExtrato.BorderStyle = BorderStyle.FixedSingle
        txtExtrato.Location = New Point(412, 243)
        txtExtrato.Multiline = True
        txtExtrato.Name = "txtExtrato"
        txtExtrato.ReadOnly = True
        txtExtrato.ScrollBars = ScrollBars.Vertical
        txtExtrato.Size = New Size(213, 256)
        txtExtrato.TabIndex = 26
        ' 
        ' btnTransferencia
        ' 
        btnTransferencia.BackColor = SystemColors.ScrollBar
        btnTransferencia.Location = New Point(119, 44)
        btnTransferencia.Name = "btnTransferencia"
        btnTransferencia.Size = New Size(75, 23)
        btnTransferencia.TabIndex = 27
        btnTransferencia.Text = "Button1"
        btnTransferencia.UseVisualStyleBackColor = False
        ' 
        ' lblTransferencia
        ' 
        lblTransferencia.AutoSize = True
        lblTransferencia.Location = New Point(6, 28)
        lblTransferencia.Name = "lblTransferencia"
        lblTransferencia.Size = New Size(41, 15)
        lblTransferencia.TabIndex = 28
        lblTransferencia.Text = "Label1"
        ' 
        ' txtTranferenciaValor
        ' 
        txtTranferenciaValor.BorderStyle = BorderStyle.FixedSingle
        txtTranferenciaValor.Location = New Point(6, 46)
        txtTranferenciaValor.Name = "txtTranferenciaValor"
        txtTranferenciaValor.Size = New Size(100, 23)
        txtTranferenciaValor.TabIndex = 29
        ' 
        ' gpbTransferencia
        ' 
        gpbTransferencia.Controls.Add(txtTranferenciaValor)
        gpbTransferencia.Controls.Add(btnTransferencia)
        gpbTransferencia.Controls.Add(lblTransferencia)
        gpbTransferencia.ForeColor = Color.DarkBlue
        gpbTransferencia.Location = New Point(13, 383)
        gpbTransferencia.Name = "gpbTransferencia"
        gpbTransferencia.Size = New Size(299, 114)
        gpbTransferencia.TabIndex = 30
        gpbTransferencia.TabStop = False
        gpbTransferencia.Text = "GroupBox1"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(637, 511)
        Controls.Add(gpbTransferencia)
        Controls.Add(txtExtrato)
        Controls.Add(gpbSaque)
        Controls.Add(gpbDeposito)
        Controls.Add(btnFinalizar)
        Controls.Add(gpbDadosConta)
        Controls.Add(txtResultadoSaque)
        Controls.Add(lblResultadoSaque)
        Controls.Add(txtSaldo)
        Controls.Add(lblSaldo)
        Controls.Add(lblPrincipal_02)
        Name = "frmPrincipal"
        Text = "frmPricipal02"
        gpbSaque.ResumeLayout(False)
        gpbSaque.PerformLayout()
        gpbDeposito.ResumeLayout(False)
        gpbDeposito.PerformLayout()
        gpbDadosConta.ResumeLayout(False)
        gpbDadosConta.PerformLayout()
        gpbTransferencia.ResumeLayout(False)
        gpbTransferencia.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gpbSaque As GroupBox
    Friend WithEvents txtSaldoAtual As TextBox
    Friend WithEvents lblValorSacar As Label
    Friend WithEvents txtValorSacar As TextBox
    Friend WithEvents btnSacar As Button
    Friend WithEvents lblSaldoAtual As Label
    Friend WithEvents gpbDeposito As GroupBox
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents btnDepositar As Button
    Friend WithEvents lbldeposito As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents gpbDadosConta As GroupBox
    Friend WithEvents txtConta As TextBox
    Friend WithEvents lblAgencia As Label
    Friend WithEvents txtAgencia As TextBox
    Friend WithEvents lblTitular As Label
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents lblConta As Label
    Friend WithEvents txtResultadoSaque As TextBox
    Friend WithEvents lblResultadoSaque As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblPrincipal_02 As Label
    Friend WithEvents txtExtrato As TextBox
    Friend WithEvents btnTransferencia As Button
    Friend WithEvents lblTransferencia As Label
    Friend WithEvents txtTranferenciaValor As TextBox
    Friend WithEvents gpbTransferencia As GroupBox
End Class

