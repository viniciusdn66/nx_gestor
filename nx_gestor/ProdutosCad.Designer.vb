<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutosCad
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Codigo_de_BarrasLabel As System.Windows.Forms.Label
        Dim GTINLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim Codigo_BalançaLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Descrição_ECFLabel As System.Windows.Forms.Label
        Dim UnidadeLabel As System.Windows.Forms.Label
        Dim AtivoLabel As System.Windows.Forms.Label
        Dim Ativo_VendaLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim Sub_GrupoLabel As System.Windows.Forms.Label
        Dim SeçãoLabel As System.Windows.Forms.Label
        Dim Ultima_CompraLabel As System.Windows.Forms.Label
        Dim Margem_IdealLabel As System.Windows.Forms.Label
        Dim Valor_de_vendaLabel As System.Windows.Forms.Label
        Dim DescontoLabel As System.Windows.Forms.Label
        Dim Valor_MinimoLabel As System.Windows.Forms.Label
        Dim Quantidade_InicialLabel As System.Windows.Forms.Label
        Dim InformaçõesLabel As System.Windows.Forms.Label
        Dim Info_VendasLabel As System.Windows.Forms.Label
        Dim Origem_CSTLabel As System.Windows.Forms.Label
        Dim NCMLabel As System.Windows.Forms.Label
        Dim Consultoria_AtivaLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SeçãoComboBox = New System.Windows.Forms.ComboBox()
        Me.TdprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbprodDataSet = New nx_gestor.dbprodDataSet()
        Me.Sub_GrupoComboBox = New System.Windows.Forms.ComboBox()
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox()
        Me.Ativo_VendaComboBox = New System.Windows.Forms.ComboBox()
        Me.AtivoComboBox = New System.Windows.Forms.ComboBox()
        Me.UnidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.Descrição_ECFTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Codigo_BalançaTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.GTINComboBox = New System.Windows.Forms.ComboBox()
        Me.Codigo_de_BarrasTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Info_VendasTextBox = New System.Windows.Forms.TextBox()
        Me.InformaçõesTextBox = New System.Windows.Forms.TextBox()
        Me.Quantidade_InicialTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_MinimoTextBox = New System.Windows.Forms.TextBox()
        Me.DescontoTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_de_vendaTextBox = New System.Windows.Forms.TextBox()
        Me.Margem_IdealTextBox = New System.Windows.Forms.TextBox()
        Me.Ultima_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Consultoria_AtivaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NCMTextBox = New System.Windows.Forms.TextBox()
        Me.Origem_CSTComboBox = New System.Windows.Forms.ComboBox()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TdprodTableAdapter = New nx_gestor.dbprodDataSetTableAdapters.tdprodTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbprodDataSetTableAdapters.TableAdapterManager()
        Me.BtnClose = New System.Windows.Forms.Button()
        Codigo_de_BarrasLabel = New System.Windows.Forms.Label()
        GTINLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        Codigo_BalançaLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        Descrição_ECFLabel = New System.Windows.Forms.Label()
        UnidadeLabel = New System.Windows.Forms.Label()
        AtivoLabel = New System.Windows.Forms.Label()
        Ativo_VendaLabel = New System.Windows.Forms.Label()
        GrupoLabel = New System.Windows.Forms.Label()
        Sub_GrupoLabel = New System.Windows.Forms.Label()
        SeçãoLabel = New System.Windows.Forms.Label()
        Ultima_CompraLabel = New System.Windows.Forms.Label()
        Margem_IdealLabel = New System.Windows.Forms.Label()
        Valor_de_vendaLabel = New System.Windows.Forms.Label()
        DescontoLabel = New System.Windows.Forms.Label()
        Valor_MinimoLabel = New System.Windows.Forms.Label()
        Quantidade_InicialLabel = New System.Windows.Forms.Label()
        InformaçõesLabel = New System.Windows.Forms.Label()
        Info_VendasLabel = New System.Windows.Forms.Label()
        Origem_CSTLabel = New System.Windows.Forms.Label()
        NCMLabel = New System.Windows.Forms.Label()
        Consultoria_AtivaLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TdprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbprodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Codigo_de_BarrasLabel
        '
        Codigo_de_BarrasLabel.AutoSize = True
        Codigo_de_BarrasLabel.Location = New System.Drawing.Point(6, 12)
        Codigo_de_BarrasLabel.Name = "Codigo_de_BarrasLabel"
        Codigo_de_BarrasLabel.Size = New System.Drawing.Size(124, 18)
        Codigo_de_BarrasLabel.TabIndex = 0
        Codigo_de_BarrasLabel.Text = "Codigo de Barras"
        '
        'GTINLabel
        '
        GTINLabel.AutoSize = True
        GTINLabel.Location = New System.Drawing.Point(179, 10)
        GTINLabel.Name = "GTINLabel"
        GTINLabel.Size = New System.Drawing.Size(43, 18)
        GTINLabel.TabIndex = 2
        GTINLabel.Text = "GTIN"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(279, 12)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(79, 18)
        ReferenciaLabel.TabIndex = 4
        ReferenciaLabel.Text = "Referencia"
        '
        'Codigo_BalançaLabel
        '
        Codigo_BalançaLabel.AutoSize = True
        Codigo_BalançaLabel.Location = New System.Drawing.Point(416, 106)
        Codigo_BalançaLabel.Name = "Codigo_BalançaLabel"
        Codigo_BalançaLabel.Size = New System.Drawing.Size(113, 18)
        Codigo_BalançaLabel.TabIndex = 6
        Codigo_BalançaLabel.Text = "Codigo Balança"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(6, 58)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(76, 18)
        DescriçãoLabel.TabIndex = 8
        DescriçãoLabel.Text = "Descrição"
        '
        'Descrição_ECFLabel
        '
        Descrição_ECFLabel.AutoSize = True
        Descrição_ECFLabel.Location = New System.Drawing.Point(6, 106)
        Descrição_ECFLabel.Name = "Descrição_ECFLabel"
        Descrição_ECFLabel.Size = New System.Drawing.Size(110, 18)
        Descrição_ECFLabel.TabIndex = 10
        Descrição_ECFLabel.Text = "Descrição ECF"
        '
        'UnidadeLabel
        '
        UnidadeLabel.AutoSize = True
        UnidadeLabel.Location = New System.Drawing.Point(6, 154)
        UnidadeLabel.Name = "UnidadeLabel"
        UnidadeLabel.Size = New System.Drawing.Size(62, 18)
        UnidadeLabel.TabIndex = 12
        UnidadeLabel.Text = "Unidade"
        '
        'AtivoLabel
        '
        AtivoLabel.AutoSize = True
        AtivoLabel.Location = New System.Drawing.Point(112, 154)
        AtivoLabel.Name = "AtivoLabel"
        AtivoLabel.Size = New System.Drawing.Size(40, 18)
        AtivoLabel.TabIndex = 14
        AtivoLabel.Text = "Ativo"
        '
        'Ativo_VendaLabel
        '
        Ativo_VendaLabel.AutoSize = True
        Ativo_VendaLabel.Location = New System.Drawing.Point(208, 152)
        Ativo_VendaLabel.Name = "Ativo_VendaLabel"
        Ativo_VendaLabel.Size = New System.Drawing.Size(85, 18)
        Ativo_VendaLabel.TabIndex = 16
        Ativo_VendaLabel.Text = "Ativo Venda"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(304, 154)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(50, 18)
        GrupoLabel.TabIndex = 18
        GrupoLabel.Text = "Grupo"
        '
        'Sub_GrupoLabel
        '
        Sub_GrupoLabel.AutoSize = True
        Sub_GrupoLabel.Location = New System.Drawing.Point(6, 204)
        Sub_GrupoLabel.Name = "Sub_GrupoLabel"
        Sub_GrupoLabel.Size = New System.Drawing.Size(81, 18)
        Sub_GrupoLabel.TabIndex = 20
        Sub_GrupoLabel.Text = "Sub-Grupo"
        '
        'SeçãoLabel
        '
        SeçãoLabel.AutoSize = True
        SeçãoLabel.Location = New System.Drawing.Point(279, 204)
        SeçãoLabel.Name = "SeçãoLabel"
        SeçãoLabel.Size = New System.Drawing.Size(51, 18)
        SeçãoLabel.TabIndex = 22
        SeçãoLabel.Text = "Seção"
        '
        'Ultima_CompraLabel
        '
        Ultima_CompraLabel.AutoSize = True
        Ultima_CompraLabel.Location = New System.Drawing.Point(6, 3)
        Ultima_CompraLabel.Name = "Ultima_CompraLabel"
        Ultima_CompraLabel.Size = New System.Drawing.Size(108, 18)
        Ultima_CompraLabel.TabIndex = 0
        Ultima_CompraLabel.Text = "Ultima Compra"
        '
        'Margem_IdealLabel
        '
        Margem_IdealLabel.AutoSize = True
        Margem_IdealLabel.Location = New System.Drawing.Point(141, 3)
        Margem_IdealLabel.Name = "Margem_IdealLabel"
        Margem_IdealLabel.Size = New System.Drawing.Size(97, 18)
        Margem_IdealLabel.TabIndex = 2
        Margem_IdealLabel.Text = "Margem Ideal"
        '
        'Valor_de_vendaLabel
        '
        Valor_de_vendaLabel.AutoSize = True
        Valor_de_vendaLabel.Location = New System.Drawing.Point(276, 3)
        Valor_de_vendaLabel.Name = "Valor_de_vendaLabel"
        Valor_de_vendaLabel.Size = New System.Drawing.Size(105, 18)
        Valor_de_vendaLabel.TabIndex = 4
        Valor_de_vendaLabel.Text = "Valor de venda"
        '
        'DescontoLabel
        '
        DescontoLabel.AutoSize = True
        DescontoLabel.Location = New System.Drawing.Point(436, 3)
        DescontoLabel.Name = "DescontoLabel"
        DescontoLabel.Size = New System.Drawing.Size(73, 18)
        DescontoLabel.TabIndex = 6
        DescontoLabel.Text = "Desconto"
        '
        'Valor_MinimoLabel
        '
        Valor_MinimoLabel.AutoSize = True
        Valor_MinimoLabel.Location = New System.Drawing.Point(5, 51)
        Valor_MinimoLabel.Name = "Valor_MinimoLabel"
        Valor_MinimoLabel.Size = New System.Drawing.Size(95, 18)
        Valor_MinimoLabel.TabIndex = 8
        Valor_MinimoLabel.Text = "Valor Minimo"
        '
        'Quantidade_InicialLabel
        '
        Quantidade_InicialLabel.AutoSize = True
        Quantidade_InicialLabel.Location = New System.Drawing.Point(140, 51)
        Quantidade_InicialLabel.Name = "Quantidade_InicialLabel"
        Quantidade_InicialLabel.Size = New System.Drawing.Size(72, 18)
        Quantidade_InicialLabel.TabIndex = 10
        Quantidade_InicialLabel.Text = "Qtd Inicial"
        '
        'InformaçõesLabel
        '
        InformaçõesLabel.AutoSize = True
        InformaçõesLabel.Location = New System.Drawing.Point(3, 99)
        InformaçõesLabel.Name = "InformaçõesLabel"
        InformaçõesLabel.Size = New System.Drawing.Size(91, 18)
        InformaçõesLabel.TabIndex = 0
        InformaçõesLabel.Text = "Informações"
        '
        'Info_VendasLabel
        '
        Info_VendasLabel.AutoSize = True
        Info_VendasLabel.Location = New System.Drawing.Point(5, 203)
        Info_VendasLabel.Name = "Info_VendasLabel"
        Info_VendasLabel.Size = New System.Drawing.Size(101, 18)
        Info_VendasLabel.TabIndex = 14
        Info_VendasLabel.Text = "Fornecedores"
        '
        'Origem_CSTLabel
        '
        Origem_CSTLabel.AutoSize = True
        Origem_CSTLabel.Location = New System.Drawing.Point(6, 3)
        Origem_CSTLabel.Name = "Origem_CSTLabel"
        Origem_CSTLabel.Size = New System.Drawing.Size(95, 18)
        Origem_CSTLabel.TabIndex = 0
        Origem_CSTLabel.Text = "Origem CST:"
        '
        'NCMLabel
        '
        NCMLabel.AutoSize = True
        NCMLabel.Location = New System.Drawing.Point(6, 53)
        NCMLabel.Name = "NCMLabel"
        NCMLabel.Size = New System.Drawing.Size(43, 18)
        NCMLabel.TabIndex = 2
        NCMLabel.Text = "NCM"
        '
        'Consultoria_AtivaLabel
        '
        Consultoria_AtivaLabel.AutoSize = True
        Consultoria_AtivaLabel.Location = New System.Drawing.Point(6, 101)
        Consultoria_AtivaLabel.Name = "Consultoria_AtivaLabel"
        Consultoria_AtivaLabel.Size = New System.Drawing.Size(119, 18)
        Consultoria_AtivaLabel.TabIndex = 5
        Consultoria_AtivaLabel.Text = "Consultoria Ativa"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.TabControl1)
        Me.PnForm.Controls.Add(Me.LocalComboBox)
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(600, 462)
        Me.PnForm.TabIndex = 86
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.Save_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(389, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Salvar Cadastro"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Error_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(495, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Cancelar Sair"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(596, 327)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(SeçãoLabel)
        Me.TabPage1.Controls.Add(Me.SeçãoComboBox)
        Me.TabPage1.Controls.Add(Sub_GrupoLabel)
        Me.TabPage1.Controls.Add(Me.Sub_GrupoComboBox)
        Me.TabPage1.Controls.Add(GrupoLabel)
        Me.TabPage1.Controls.Add(Me.GrupoComboBox)
        Me.TabPage1.Controls.Add(Ativo_VendaLabel)
        Me.TabPage1.Controls.Add(Me.Ativo_VendaComboBox)
        Me.TabPage1.Controls.Add(AtivoLabel)
        Me.TabPage1.Controls.Add(Me.AtivoComboBox)
        Me.TabPage1.Controls.Add(UnidadeLabel)
        Me.TabPage1.Controls.Add(Me.UnidadeComboBox)
        Me.TabPage1.Controls.Add(Descrição_ECFLabel)
        Me.TabPage1.Controls.Add(Me.Descrição_ECFTextBox)
        Me.TabPage1.Controls.Add(DescriçãoLabel)
        Me.TabPage1.Controls.Add(Me.DescriçãoTextBox)
        Me.TabPage1.Controls.Add(Codigo_BalançaLabel)
        Me.TabPage1.Controls.Add(Me.Codigo_BalançaTextBox)
        Me.TabPage1.Controls.Add(ReferenciaLabel)
        Me.TabPage1.Controls.Add(Me.ReferenciaTextBox)
        Me.TabPage1.Controls.Add(GTINLabel)
        Me.TabPage1.Controls.Add(Me.GTINComboBox)
        Me.TabPage1.Controls.Add(Codigo_de_BarrasLabel)
        Me.TabPage1.Controls.Add(Me.Codigo_de_BarrasTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(588, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informações Gerais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SeçãoComboBox
        '
        Me.SeçãoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Seção", True))
        Me.SeçãoComboBox.FormattingEnabled = True
        Me.SeçãoComboBox.Location = New System.Drawing.Point(282, 225)
        Me.SeçãoComboBox.Name = "SeçãoComboBox"
        Me.SeçãoComboBox.Size = New System.Drawing.Size(298, 26)
        Me.SeçãoComboBox.TabIndex = 12
        '
        'TdprodBindingSource
        '
        Me.TdprodBindingSource.DataMember = "tdprod"
        Me.TdprodBindingSource.DataSource = Me.DbprodDataSet
        '
        'DbprodDataSet
        '
        Me.DbprodDataSet.DataSetName = "dbprodDataSet"
        Me.DbprodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sub_GrupoComboBox
        '
        Me.Sub_GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Sub-Grupo", True))
        Me.Sub_GrupoComboBox.FormattingEnabled = True
        Me.Sub_GrupoComboBox.Location = New System.Drawing.Point(9, 225)
        Me.Sub_GrupoComboBox.Name = "Sub_GrupoComboBox"
        Me.Sub_GrupoComboBox.Size = New System.Drawing.Size(267, 26)
        Me.Sub_GrupoComboBox.TabIndex = 11
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Grupo", True))
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(307, 175)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(273, 26)
        Me.GrupoComboBox.TabIndex = 10
        '
        'Ativo_VendaComboBox
        '
        Me.Ativo_VendaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Ativo Venda", True))
        Me.Ativo_VendaComboBox.FormattingEnabled = True
        Me.Ativo_VendaComboBox.Location = New System.Drawing.Point(211, 173)
        Me.Ativo_VendaComboBox.Name = "Ativo_VendaComboBox"
        Me.Ativo_VendaComboBox.Size = New System.Drawing.Size(90, 26)
        Me.Ativo_VendaComboBox.TabIndex = 9
        '
        'AtivoComboBox
        '
        Me.AtivoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Ativo", True))
        Me.AtivoComboBox.FormattingEnabled = True
        Me.AtivoComboBox.Location = New System.Drawing.Point(115, 175)
        Me.AtivoComboBox.Name = "AtivoComboBox"
        Me.AtivoComboBox.Size = New System.Drawing.Size(90, 26)
        Me.AtivoComboBox.TabIndex = 8
        '
        'UnidadeComboBox
        '
        Me.UnidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Unidade", True))
        Me.UnidadeComboBox.FormattingEnabled = True
        Me.UnidadeComboBox.Location = New System.Drawing.Point(11, 175)
        Me.UnidadeComboBox.Name = "UnidadeComboBox"
        Me.UnidadeComboBox.Size = New System.Drawing.Size(98, 26)
        Me.UnidadeComboBox.TabIndex = 7
        '
        'Descrição_ECFTextBox
        '
        Me.Descrição_ECFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Descrição ECF", True))
        Me.Descrição_ECFTextBox.Location = New System.Drawing.Point(9, 127)
        Me.Descrição_ECFTextBox.MaxLength = 30
        Me.Descrição_ECFTextBox.Name = "Descrição_ECFTextBox"
        Me.Descrição_ECFTextBox.Size = New System.Drawing.Size(404, 24)
        Me.Descrição_ECFTextBox.TabIndex = 5
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(9, 79)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(571, 24)
        Me.DescriçãoTextBox.TabIndex = 4
        '
        'Codigo_BalançaTextBox
        '
        Me.Codigo_BalançaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Codigo Balança", True))
        Me.Codigo_BalançaTextBox.Location = New System.Drawing.Point(419, 127)
        Me.Codigo_BalançaTextBox.Name = "Codigo_BalançaTextBox"
        Me.Codigo_BalançaTextBox.Size = New System.Drawing.Size(161, 24)
        Me.Codigo_BalançaTextBox.TabIndex = 6
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(282, 31)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(298, 24)
        Me.ReferenciaTextBox.TabIndex = 3
        '
        'GTINComboBox
        '
        Me.GTINComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "GTIN", True))
        Me.GTINComboBox.FormattingEnabled = True
        Me.GTINComboBox.Location = New System.Drawing.Point(182, 31)
        Me.GTINComboBox.Name = "GTINComboBox"
        Me.GTINComboBox.Size = New System.Drawing.Size(94, 26)
        Me.GTINComboBox.TabIndex = 2
        '
        'Codigo_de_BarrasTextBox
        '
        Me.Codigo_de_BarrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Codigo de Barras", True))
        Me.Codigo_de_BarrasTextBox.Location = New System.Drawing.Point(9, 31)
        Me.Codigo_de_BarrasTextBox.Name = "Codigo_de_BarrasTextBox"
        Me.Codigo_de_BarrasTextBox.Size = New System.Drawing.Size(167, 24)
        Me.Codigo_de_BarrasTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Info_VendasLabel)
        Me.TabPage2.Controls.Add(Me.Info_VendasTextBox)
        Me.TabPage2.Controls.Add(InformaçõesLabel)
        Me.TabPage2.Controls.Add(Me.InformaçõesTextBox)
        Me.TabPage2.Controls.Add(Quantidade_InicialLabel)
        Me.TabPage2.Controls.Add(Me.Quantidade_InicialTextBox)
        Me.TabPage2.Controls.Add(Valor_MinimoLabel)
        Me.TabPage2.Controls.Add(Me.Valor_MinimoTextBox)
        Me.TabPage2.Controls.Add(DescontoLabel)
        Me.TabPage2.Controls.Add(Me.DescontoTextBox)
        Me.TabPage2.Controls.Add(Valor_de_vendaLabel)
        Me.TabPage2.Controls.Add(Me.Valor_de_vendaTextBox)
        Me.TabPage2.Controls.Add(Margem_IdealLabel)
        Me.TabPage2.Controls.Add(Me.Margem_IdealTextBox)
        Me.TabPage2.Controls.Add(Ultima_CompraLabel)
        Me.TabPage2.Controls.Add(Me.Ultima_CompraTextBox)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(588, 298)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Compra / Venda"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Info_VendasTextBox
        '
        Me.Info_VendasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Info Vendas", True))
        Me.Info_VendasTextBox.Location = New System.Drawing.Point(8, 224)
        Me.Info_VendasTextBox.Multiline = True
        Me.Info_VendasTextBox.Name = "Info_VendasTextBox"
        Me.Info_VendasTextBox.Size = New System.Drawing.Size(571, 68)
        Me.Info_VendasTextBox.TabIndex = 15
        '
        'InformaçõesTextBox
        '
        Me.InformaçõesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Informações", True))
        Me.InformaçõesTextBox.Location = New System.Drawing.Point(6, 120)
        Me.InformaçõesTextBox.Multiline = True
        Me.InformaçõesTextBox.Name = "InformaçõesTextBox"
        Me.InformaçõesTextBox.Size = New System.Drawing.Size(574, 80)
        Me.InformaçõesTextBox.TabIndex = 13
        '
        'Quantidade_InicialTextBox
        '
        Me.Quantidade_InicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Quantidade Inicial", True))
        Me.Quantidade_InicialTextBox.Location = New System.Drawing.Point(143, 72)
        Me.Quantidade_InicialTextBox.Name = "Quantidade_InicialTextBox"
        Me.Quantidade_InicialTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Quantidade_InicialTextBox.TabIndex = 18
        '
        'Valor_MinimoTextBox
        '
        Me.Valor_MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Valor Minimo", True))
        Me.Valor_MinimoTextBox.Location = New System.Drawing.Point(8, 72)
        Me.Valor_MinimoTextBox.Name = "Valor_MinimoTextBox"
        Me.Valor_MinimoTextBox.Size = New System.Drawing.Size(129, 24)
        Me.Valor_MinimoTextBox.TabIndex = 17
        '
        'DescontoTextBox
        '
        Me.DescontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Desconto", True))
        Me.DescontoTextBox.Location = New System.Drawing.Point(439, 24)
        Me.DescontoTextBox.Name = "DescontoTextBox"
        Me.DescontoTextBox.Size = New System.Drawing.Size(141, 24)
        Me.DescontoTextBox.TabIndex = 16
        '
        'Valor_de_vendaTextBox
        '
        Me.Valor_de_vendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Valor de venda", True))
        Me.Valor_de_vendaTextBox.Location = New System.Drawing.Point(279, 24)
        Me.Valor_de_vendaTextBox.Name = "Valor_de_vendaTextBox"
        Me.Valor_de_vendaTextBox.Size = New System.Drawing.Size(154, 24)
        Me.Valor_de_vendaTextBox.TabIndex = 15
        '
        'Margem_IdealTextBox
        '
        Me.Margem_IdealTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Margem Ideal", True))
        Me.Margem_IdealTextBox.Location = New System.Drawing.Point(144, 24)
        Me.Margem_IdealTextBox.Name = "Margem_IdealTextBox"
        Me.Margem_IdealTextBox.Size = New System.Drawing.Size(129, 24)
        Me.Margem_IdealTextBox.TabIndex = 14
        '
        'Ultima_CompraTextBox
        '
        Me.Ultima_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Ultima Compra", True))
        Me.Ultima_CompraTextBox.Location = New System.Drawing.Point(9, 24)
        Me.Ultima_CompraTextBox.Name = "Ultima_CompraTextBox"
        Me.Ultima_CompraTextBox.Size = New System.Drawing.Size(129, 24)
        Me.Ultima_CompraTextBox.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Consultoria_AtivaLabel)
        Me.TabPage3.Controls.Add(Me.Consultoria_AtivaComboBox)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(NCMLabel)
        Me.TabPage3.Controls.Add(Me.NCMTextBox)
        Me.TabPage3.Controls.Add(Origem_CSTLabel)
        Me.TabPage3.Controls.Add(Me.Origem_CSTComboBox)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(588, 298)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dados Fiscais"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Consultoria_AtivaComboBox
        '
        Me.Consultoria_AtivaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Consultoria Ativa", True))
        Me.Consultoria_AtivaComboBox.FormattingEnabled = True
        Me.Consultoria_AtivaComboBox.Location = New System.Drawing.Point(9, 122)
        Me.Consultoria_AtivaComboBox.Name = "Consultoria_AtivaComboBox"
        Me.Consultoria_AtivaComboBox.Size = New System.Drawing.Size(121, 26)
        Me.Consultoria_AtivaComboBox.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(494, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Localizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NCMTextBox
        '
        Me.NCMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "NCM", True))
        Me.NCMTextBox.Location = New System.Drawing.Point(9, 74)
        Me.NCMTextBox.Name = "NCMTextBox"
        Me.NCMTextBox.Size = New System.Drawing.Size(479, 24)
        Me.NCMTextBox.TabIndex = 3
        '
        'Origem_CSTComboBox
        '
        Me.Origem_CSTComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Origem CST", True))
        Me.Origem_CSTComboBox.FormattingEnabled = True
        Me.Origem_CSTComboBox.Location = New System.Drawing.Point(9, 24)
        Me.Origem_CSTComboBox.Name = "Origem_CSTComboBox"
        Me.Origem_CSTComboBox.Size = New System.Drawing.Size(570, 26)
        Me.Origem_CSTComboBox.TabIndex = 1
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DataSource = Me.TdprodBindingSource
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(512, 20)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(67, 24)
        Me.LocalComboBox.TabIndex = 100
        Me.LocalComboBox.ValueMember = "Código"
        '
        'NameForm
        '
        Me.NameForm.AutoSize = True
        Me.NameForm.BackColor = System.Drawing.Color.Transparent
        Me.NameForm.Enabled = False
        Me.NameForm.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameForm.ForeColor = System.Drawing.Color.White
        Me.NameForm.Location = New System.Drawing.Point(13, 9)
        Me.NameForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameForm.Name = "NameForm"
        Me.NameForm.Size = New System.Drawing.Size(219, 24)
        Me.NameForm.TabIndex = 87
        Me.NameForm.Text = "Cadastro/Alteração Produtos"
        '
        'TdprodTableAdapter
        '
        Me.TdprodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tdprodTableAdapter = Me.TdprodTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.dbprodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.BackgroundImage = Global.nx_gestor.My.Resources.Resources.Close_icon
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(543, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 88
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ProdutosCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(601, 501)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProdutosCad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProdutosCad"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TdprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbprodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DbprodDataSet As dbprodDataSet
    Friend WithEvents TdprodBindingSource As BindingSource
    Friend WithEvents TdprodTableAdapter As dbprodDataSetTableAdapters.tdprodTableAdapter
    Friend WithEvents TableAdapterManager As dbprodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Descrição_ECFTextBox As TextBox
    Friend WithEvents DescriçãoTextBox As TextBox
    Friend WithEvents Codigo_BalançaTextBox As TextBox
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents GTINComboBox As ComboBox
    Friend WithEvents Codigo_de_BarrasTextBox As TextBox
    Friend WithEvents SeçãoComboBox As ComboBox
    Friend WithEvents Sub_GrupoComboBox As ComboBox
    Friend WithEvents GrupoComboBox As ComboBox
    Friend WithEvents Ativo_VendaComboBox As ComboBox
    Friend WithEvents AtivoComboBox As ComboBox
    Friend WithEvents UnidadeComboBox As ComboBox
    Friend WithEvents Valor_de_vendaTextBox As TextBox
    Friend WithEvents Margem_IdealTextBox As TextBox
    Friend WithEvents Ultima_CompraTextBox As TextBox
    Friend WithEvents DescontoTextBox As TextBox
    Friend WithEvents Info_VendasTextBox As TextBox
    Friend WithEvents InformaçõesTextBox As TextBox
    Friend WithEvents Quantidade_InicialTextBox As TextBox
    Friend WithEvents Valor_MinimoTextBox As TextBox
    Friend WithEvents Consultoria_AtivaComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents NCMTextBox As TextBox
    Friend WithEvents Origem_CSTComboBox As ComboBox
    Friend WithEvents LocalComboBox As ComboBox
End Class
