<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    'Inherits System.Windows.Forms.Form
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Divisao1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblModelo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlaca = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMovimentacao = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnConfirmar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblHora = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.HoraAtual = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtgVeiculos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_meiahora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_acrescimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.Divisao1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dtgVeiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Divisao1
        '
        Me.Divisao1.ColumnCount = 1
        Me.Divisao1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0679!))
        Me.Divisao1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Divisao1.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.Divisao1.Controls.Add(Me.lblHora, 0, 0)
        Me.Divisao1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Divisao1.Location = New System.Drawing.Point(3, 3)
        Me.Divisao1.Name = "Divisao1"
        Me.Divisao1.RowCount = 2
        Me.Divisao1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.40367!))
        Me.Divisao1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.59633!))
        Me.Divisao1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Divisao1.Size = New System.Drawing.Size(329, 588)
        Me.Divisao1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KryptonLabel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblModelo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPlaca, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPlaca, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescricao, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipo, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(323, 439)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 203)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(317, 34)
        Me.KryptonLabel1.TabIndex = 10
        Me.KryptonLabel1.Values.Text = "Tipo"
        '
        'lblModelo
        '
        Me.lblModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblModelo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblModelo.Location = New System.Drawing.Point(3, 103)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(317, 34)
        Me.lblModelo.TabIndex = 7
        Me.lblModelo.Values.Text = "Descrição"
        '
        'lblPlaca
        '
        Me.lblPlaca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaca.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblPlaca.Location = New System.Drawing.Point(3, 3)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(317, 34)
        Me.lblPlaca.TabIndex = 5
        Me.lblPlaca.Values.Text = "Placa"
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(3, 43)
        Me.txtPlaca.MaxLength = 10
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(317, 49)
        Me.txtPlaca.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(3, 143)
        Me.txtDescricao.MaxLength = 20
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(317, 49)
        Me.txtDescricao.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnMovimentacao, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnConfirmar, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(37, 375)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(283, 61)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'btnMovimentacao
        '
        Me.btnMovimentacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMovimentacao.Location = New System.Drawing.Point(3, 3)
        Me.btnMovimentacao.Name = "btnMovimentacao"
        Me.btnMovimentacao.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.btnMovimentacao.Size = New System.Drawing.Size(135, 55)
        Me.btnMovimentacao.TabIndex = 1
        Me.btnMovimentacao.Values.Text = "Movimentação"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirmar.Location = New System.Drawing.Point(144, 3)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(136, 55)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Values.Text = "Confirmar"
        '
        'cmbTipo
        '
        Me.cmbTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.ItemHeight = 37
        Me.cmbTipo.Location = New System.Drawing.Point(3, 243)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(317, 45)
        Me.cmbTipo.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblHora.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblHora.Location = New System.Drawing.Point(36, 3)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(256, 137)
        Me.lblHora.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.TabIndex = 4
        Me.lblHora.Values.Text = "00:00:00"
        '
        'HoraAtual
        '
        Me.HoraAtual.Enabled = True
        Me.HoraAtual.Interval = 1000
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.86192!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.13808!))
        Me.TableLayoutPanel2.Controls.Add(Me.Divisao1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(717, 594)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dtgVeiculos, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtPesquisar, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(338, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.07483!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92517!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(376, 588)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'dtgVeiculos
        '
        Me.dtgVeiculos.AllowUserToAddRows = False
        Me.dtgVeiculos.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtgVeiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgVeiculos.ColumnHeadersHeight = 40
        Me.dtgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgVeiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.placa, Me.valor_meiahora, Me.valor_acrescimo, Me.tipo, Me.valor_hora})
        Me.dtgVeiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgVeiculos.Location = New System.Drawing.Point(3, 3)
        Me.dtgVeiculos.MultiSelect = False
        Me.dtgVeiculos.Name = "dtgVeiculos"
        Me.dtgVeiculos.ReadOnly = True
        Me.dtgVeiculos.RowHeadersVisible = False
        Me.dtgVeiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgVeiculos.RowTemplate.Height = 50
        Me.dtgVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgVeiculos.Size = New System.Drawing.Size(370, 505)
        Me.dtgVeiculos.StateCommon.Background.Color1 = System.Drawing.Color.AliceBlue
        Me.dtgVeiculos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgVeiculos.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White
        Me.dtgVeiculos.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White
        Me.dtgVeiculos.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.dtgVeiculos.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "entrada"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.Format = "t"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn1.HeaderText = "ENTRADA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 89
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descricao"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIÇÃO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'placa
        '
        Me.placa.DataPropertyName = "placa"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placa.DefaultCellStyle = DataGridViewCellStyle16
        Me.placa.HeaderText = "PLACA"
        Me.placa.Name = "placa"
        Me.placa.ReadOnly = True
        '
        'valor_meiahora
        '
        Me.valor_meiahora.DataPropertyName = "valor_meiahora"
        Me.valor_meiahora.HeaderText = "valor_meiahora"
        Me.valor_meiahora.Name = "valor_meiahora"
        Me.valor_meiahora.ReadOnly = True
        Me.valor_meiahora.Visible = False
        '
        'valor_acrescimo
        '
        Me.valor_acrescimo.DataPropertyName = "valor_acrescimo"
        Me.valor_acrescimo.HeaderText = "valor_acrescimo"
        Me.valor_acrescimo.Name = "valor_acrescimo"
        Me.valor_acrescimo.ReadOnly = True
        Me.valor_acrescimo.Visible = False
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Visible = False
        '
        'valor_hora
        '
        Me.valor_hora.DataPropertyName = "valor_hora"
        Me.valor_hora.HeaderText = "valor_hora"
        Me.valor_hora.Name = "valor_hora"
        Me.valor_hora.ReadOnly = True
        Me.valor_hora.Visible = False
        '
        'txtPesquisar
        '
        Me.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar.Location = New System.Drawing.Point(3, 514)
        Me.txtPesquisar.Multiline = True
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(370, 71)
        Me.txtPesquisar.TabIndex = 25
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 594)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "frmPrincipal"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Divisao1.ResumeLayout(False)
        Me.Divisao1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dtgVeiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Divisao1 As TableLayoutPanel
    Friend WithEvents HoraAtual As Timer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblHora As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblModelo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPlaca As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnConfirmar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtgVeiculos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents btnMovimentacao As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents placa As DataGridViewTextBoxColumn
    Friend WithEvents valor_meiahora As DataGridViewTextBoxColumn
    Friend WithEvents valor_acrescimo As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents valor_hora As DataGridViewTextBoxColumn
End Class
