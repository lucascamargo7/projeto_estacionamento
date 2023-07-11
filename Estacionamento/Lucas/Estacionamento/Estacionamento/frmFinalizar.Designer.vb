<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalizar
    'Inherits System.Windows.Forms.Form

    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Form overrides dispose to clean up the component list.

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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSaida = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSaida1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEntrada = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblEntrada1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblValor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalHora = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfirma = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.85911!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(593, 142)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblSaida, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSaida1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(301, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.80282!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.19718!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(289, 136)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'lblSaida
        '
        Me.lblSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblSaida.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblSaida.Location = New System.Drawing.Point(107, 3)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Size = New System.Drawing.Size(74, 39)
        Me.lblSaida.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.TabIndex = 6
        Me.lblSaida.Values.Text = "Saída"
        '
        'lblSaida1
        '
        Me.lblSaida1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblSaida1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblSaida1.Location = New System.Drawing.Point(16, 48)
        Me.lblSaida1.Name = "lblSaida1"
        Me.lblSaida1.Size = New System.Drawing.Size(256, 85)
        Me.lblSaida1.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida1.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida1.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida1.TabIndex = 5
        Me.lblSaida1.Values.Text = "00:00:00"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblEntrada, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEntrada1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.80282!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.19718!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 136)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'lblEntrada
        '
        Me.lblEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblEntrada.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblEntrada.Location = New System.Drawing.Point(97, 3)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(98, 39)
        Me.lblEntrada.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.TabIndex = 6
        Me.lblEntrada.Values.Text = "Entrada"
        '
        'lblEntrada1
        '
        Me.lblEntrada1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblEntrada1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblEntrada1.Location = New System.Drawing.Point(18, 48)
        Me.lblEntrada1.Name = "lblEntrada1"
        Me.lblEntrada1.Size = New System.Drawing.Size(256, 85)
        Me.lblEntrada1.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada1.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada1.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada1.TabIndex = 5
        Me.lblEntrada1.Values.Text = "00:00:00"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblValor, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTotalHora, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtValorPago, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.88889!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(599, 520)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblValor.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblValor.Location = New System.Drawing.Point(155, 271)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(288, 92)
        Me.lblValor.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.TabIndex = 7
        Me.lblValor.Values.Text = "R$ 0,00"
        '
        'lblTotalHora
        '
        Me.lblTotalHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTotalHora.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblTotalHora.Location = New System.Drawing.Point(187, 151)
        Me.lblTotalHora.Name = "lblTotalHora"
        Me.lblTotalHora.Size = New System.Drawing.Size(225, 114)
        Me.lblTotalHora.StateCommon.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHora.StateDisabled.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHora.StateNormal.ShortText.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHora.TabIndex = 6
        Me.lblTotalHora.Values.Text = "00:00"
        '
        'txtValorPago
        '
        Me.txtValorPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtValorPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPago.Location = New System.Drawing.Point(3, 369)
        Me.txtValorPago.Multiline = True
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(593, 72)
        Me.txtValorPago.TabIndex = 8
        Me.txtValorPago.Text = "0,00"
        Me.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.00674!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.99325!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnConfirma, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 447)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(593, 70)
        Me.TableLayoutPanel5.TabIndex = 9
        '
        'btnConfirma
        '
        Me.btnConfirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirma.Location = New System.Drawing.Point(430, 3)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.btnConfirma.Size = New System.Drawing.Size(160, 64)
        Me.btnConfirma.TabIndex = 0
        Me.btnConfirma.Values.Text = "Confirmar"
        '
        'frmFinalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 520)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinalizar"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "'"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblSaida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSaida1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblEntrada As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEntrada1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblTotalHora As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblValor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnConfirma As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
