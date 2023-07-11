Imports System.Xml
Imports System.Runtime.InteropServices
Imports System
Imports System.IO


Public Class frmPrincipal

    Public entrada As String

    Private Sub HoraAtual_Tick(sender As Object, e As EventArgs) Handles HoraAtual.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.carregarConfiguracoes()

        Me.carregaGrid()
        Me.retornaTipos()

        dtgVeiculos.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        cmbTipo.SelectedIndex = 0
        txtPlaca.Focus()
    End Sub

    Private Sub carregaGrid()
        Dim cDao As New MovimentacaoDao
        dtgVeiculos.DataSource = cDao.retornaListaMovimentacao()

    End Sub

    Private Sub retornaTipos()
        Dim cDao As New MovimentacaoDao
        Dim listaVeiculos As New List(Of ClsVeiculo)
        listaVeiculos = cDao.RetornaListaTiposVeiculos()

        For Each c As ClsVeiculo In listaVeiculos
            cmbTipo.Items.Add(c.tipo)
        Next

    End Sub


    Private Sub btnAdicionarCliente_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If Me.validaVeiculo() = True Then
            Me.gravarEntrada()
            Me.limparCampos()
        End If
    End Sub

    Private Sub limparCampos()
        txtPlaca.Text = ""
        txtDescricao.Text = ""
        cmbTipo.SelectedIndex = 0
    End Sub

    Private Function validaVeiculo() As Boolean
        If txtPlaca.Text = "" Then
            MsgBox("Informe a placa do veículo")
            Return False

        End If

        If txtDescricao.Text = "" Then
            MsgBox("Informe a descrição do veículo")
            Return False
        End If


        Return True

    End Function

    Private Sub gravarEntrada()
        Dim c As New ClsVeiculo
        Dim cDao As New MovimentacaoDao

        c.placa = txtPlaca.Text.Trim
        c.descricao = txtDescricao.Text.Trim
        c.tipo = cmbTipo.SelectedItem.ToString()
        cDao.registroEntrada(c)

        Me.carregaGrid()


    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnMovimentacao.Click
        'Dim FReport As New Report
        'FReport.Load(My.Application.Info.DirectoryPath.ToString & "\MovimentacaoGeral.frx")
        'FReport.Prepare()
        'FReport.ShowPrepared()
    End Sub


    Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
        If txtPesquisar.Text.Trim = "" Then
            Me.carregaGrid()
        Else
            Me.carregaPesquisa()
        End If
    End Sub

    Private Sub carregaPesquisa()
        Dim cDao As New MovimentacaoDao
        dtgVeiculos.DataSource = cDao.retornaListaPesquisaVeiculos(txtPesquisar.Text.Trim)
    End Sub

    Private Sub dtgVeiculos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVeiculos.CellDoubleClick
        Dim finalizaForm As New frmFinalizar

        finalizaForm.lblSaida1.Text = DateTime.Now.ToShortTimeString()
        finalizaForm.lblEntrada1.Text = dtgVeiculos.CurrentRow.Cells(6).Value.ToString()
        finalizaForm.placa = dtgVeiculos.CurrentRow.Cells(0).Value.ToString()
        finalizaForm.tipo = dtgVeiculos.CurrentRow.Cells(2).Value.ToString()
        finalizaForm.Show()
        'Me.finalizar()
    End Sub

    Public Sub finalizar()
        'frmFinalizar.lblEntrada1.Text = dtgVeiculos.CurrentRow.Cells("entrada").Value.ToString()
        'frmFinalizar.lblSaida1.Text = DateTime.Now.ToShortTimeString()
        ' frmFinalizar.Show()
    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.carregaGrid()
    End Sub

    Private Sub txtPlaca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlaca.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtDescricao.Focus()
        End If
    End Sub

    Private Sub txtDescricao_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescricao.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            cmbTipo.Focus()
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnConfirmar.Focus()
        End If
    End Sub

End Class
