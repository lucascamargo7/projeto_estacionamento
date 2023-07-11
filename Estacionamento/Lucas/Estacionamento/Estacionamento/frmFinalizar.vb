Public Class frmFinalizar

    Public valor_total As Double
    Public placa As String
    Public tipo As String
    Public valor_meia_hora As Double
    Public valor_hora As Double
    Public valor_acrescimo As Double

    Private Sub frmFinalizar_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.retornaValores()
        Me.CalculaValor()
        valor_total = Convert.ToDouble(Mid(lblValor.Text.Trim, 3, 10).Trim)
    End Sub

    Private Sub retornaValores()
        Dim cDao As New MovimentacaoDao
        Dim listaPrecos As New List(Of ClsVendas)
        listaPrecos = cDao.retornaValores(tipo)

        For Each c As ClsVendas In listaPrecos
            valor_meia_hora = c.valor_meiahora
            valor_hora = c.valor_hora
            valor_acrescimo = c.valor_acrescimo
        Next
    End Sub


    Private Sub CalculaValor()
        Dim hora As Integer
        Dim minutos As Integer
        Dim valor As Double
        Dim carencia As Integer

        'Dim valor_meia_hora As Double = 3
        'Dim valor_hora As Double = 4
        'Dim valor_acrescimo As Double = 2

        Dim total As String = (Convert.ToDateTime(lblSaida1.Text) - Convert.ToDateTime(lblEntrada1.Text)).ToString
        lblTotalHora.Text = Convert.ToDateTime(total).ToString("HH:mm")

        If Convert.ToDateTime(total) <= Convert.ToDateTime("00:35") Then
            lblValor.Text = valor_meia_hora.ToString("R$ #,###.00")

        Else
            hora = Convert.ToInt32(Convert.ToDateTime(total).ToString("HH"))
            minutos = Convert.ToInt32(Convert.ToDateTime(total).ToString("mm"))

            Select Case minutos
                Case > 30
                    carencia = minutos - 30
                    If carencia >= 5 Then
                        valor = hora * valor_hora + valor_acrescimo * 2
                        lblValor.Text = valor.ToString("R$ #,###.00")
                    Else
                        valor = hora * valor_hora + valor_acrescimo * 1
                        lblValor.Text = valor.ToString("R$ #,###.00")
                    End If
                Case < 30
                    If minutos >= 5 Then
                        valor = hora * valor_hora + valor_acrescimo * 1
                        lblValor.Text = valor.ToString("R$ #,###.00")
                    Else
                        valor = hora * valor_hora
                        lblValor.Text = valor.ToString("R$ #,###.00")
                    End If
            End Select

            'MsgBox("Hora = " & hora & "Minutos = " & minutos)



        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValorPago.TextChanged
        Me.TextBoxMoeda(txtValorPago)
    End Sub

    Private Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try
    End Sub

    Private Sub txtValorPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorPago.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.calculaTroco()
        End If

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub calculaTroco()

        Dim valorAPagar As Double = Convert.ToDouble(Mid(lblValor.Text.Trim, 3, 10).Trim)
        Dim valorPago As Double = Convert.ToDouble(txtValorPago.Text.Trim)


        If valorPago > valorAPagar Then
            lblValor.Text = "Troco " & (valorPago - valorAPagar).ToString("R$ #,###.00")
            txtValorPago.Enabled = False
            btnConfirma.Focus()
        ElseIf valorAPagar = valorPago Then
            lblValor.TabIndex = "R$ 0,00"
            txtValorPago.Enabled = False
            btnConfirma.Focus()
        Else
            lblValor.Text = (valorAPagar - valorPago).ToString("R$ #,###.00")
            txtValorPago.Text = "0,00"
            txtValorPago.Select()
        End If

        'If valorAPagar <= valorPago Then
        '    lblValor.Text = "Troco" & (valorPago - valorAPagar).ToString("R$ #,###.00")
        '    txtValorPago.Enabled = False


        'Else
        '    lblValor.Text = (valorAPagar - valorPago).ToString("R$ #,###.00")
        '    txtValorPago.Text = "0,00"
        '    txtValorPago.Select()

        'End If
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        If txtValorPago.Enabled = False Then
            Me.finalizaVenda()
            Me.Close()
        End If


    End Sub

    Private Sub finalizaVenda()
        Dim c As New ClsVendas
        Dim cDao As New MovimentacaoDao

        c.entrada = lblEntrada1.Text.Trim
        c.saida = lblSaida1.Text.Trim
        c.total_horas = lblTotalHora.Text.Trim
        c.total_valor = valor_total
        c.placa = placa
        cDao.finalizaVenda(c)
    End Sub

    Private Sub frmFinalizar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtValorPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorPago.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub
End Class