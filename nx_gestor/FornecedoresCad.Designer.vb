<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FornecedoresCad
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
        Dim CPF_CNPJLabel As System.Windows.Forms.Label
        Dim RG_IELabel As System.Windows.Forms.Label
        Dim CNAELabel As System.Windows.Forms.Label
        Dim SuframaLabel As System.Windows.Forms.Label
        Dim IE_STLabel As System.Windows.Forms.Label
        Dim Paga_ICMS_STLabel As System.Windows.Forms.Label
        Dim Nome_Razão_SocialLabel As System.Windows.Forms.Label
        Dim Nome_Fantasia_ApelidoLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim LimiteLabel As System.Windows.Forms.Label
        Dim Lançamento_CaixaLabel As System.Windows.Forms.Label
        Dim ContatoLabel As System.Windows.Forms.Label
        Dim Fone_ContatoLabel As System.Windows.Forms.Label
        Dim RamalLabel As System.Windows.Forms.Label
        Dim E_mail_ContatoLabel As System.Windows.Forms.Label
        Dim Obs_ContatoLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FoneTextBox = New System.Windows.Forms.TextBox()
        Me.TbfornecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbforncDataSet = New nx_gestor.dbforncDataSet()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.Lançamento_CaixaComboBox = New System.Windows.Forms.ComboBox()
        Me.LimiteTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.UFComboBox = New System.Windows.Forms.ComboBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IE_STTextBox = New System.Windows.Forms.TextBox()
        Me.Paga_ICMS_STComboBox = New System.Windows.Forms.ComboBox()
        Me.CPF_CNPJTextBox = New System.Windows.Forms.TextBox()
        Me.RG_IETextBox = New System.Windows.Forms.TextBox()
        Me.CNAETextBox = New System.Windows.Forms.TextBox()
        Me.SuframaTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_Razão_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_Fantasia_ApelidoTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.Fone_ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.RamalTextBox = New System.Windows.Forms.TextBox()
        Me.E_mail_ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.Obs_ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TbfornecTableAdapter = New nx_gestor.dbforncDataSetTableAdapters.tbfornecTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbforncDataSetTableAdapters.TableAdapterManager()
        CPF_CNPJLabel = New System.Windows.Forms.Label()
        RG_IELabel = New System.Windows.Forms.Label()
        CNAELabel = New System.Windows.Forms.Label()
        SuframaLabel = New System.Windows.Forms.Label()
        IE_STLabel = New System.Windows.Forms.Label()
        Paga_ICMS_STLabel = New System.Windows.Forms.Label()
        Nome_Razão_SocialLabel = New System.Windows.Forms.Label()
        Nome_Fantasia_ApelidoLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        FoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        LimiteLabel = New System.Windows.Forms.Label()
        Lançamento_CaixaLabel = New System.Windows.Forms.Label()
        ContatoLabel = New System.Windows.Forms.Label()
        Fone_ContatoLabel = New System.Windows.Forms.Label()
        RamalLabel = New System.Windows.Forms.Label()
        E_mail_ContatoLabel = New System.Windows.Forms.Label()
        Obs_ContatoLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TbfornecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbforncDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPF_CNPJLabel
        '
        CPF_CNPJLabel.AutoSize = True
        CPF_CNPJLabel.Location = New System.Drawing.Point(487, 12)
        CPF_CNPJLabel.Name = "CPF_CNPJLabel"
        CPF_CNPJLabel.Size = New System.Drawing.Size(82, 18)
        CPF_CNPJLabel.TabIndex = 2
        CPF_CNPJLabel.Text = "CPF/CNPJ"
        '
        'RG_IELabel
        '
        RG_IELabel.AutoSize = True
        RG_IELabel.Location = New System.Drawing.Point(325, 63)
        RG_IELabel.Name = "RG_IELabel"
        RG_IELabel.Size = New System.Drawing.Size(48, 18)
        RG_IELabel.TabIndex = 4
        RG_IELabel.Text = "RG/IE"
        '
        'CNAELabel
        '
        CNAELabel.AutoSize = True
        CNAELabel.Location = New System.Drawing.Point(452, 63)
        CNAELabel.Name = "CNAELabel"
        CNAELabel.Size = New System.Drawing.Size(49, 18)
        CNAELabel.TabIndex = 6
        CNAELabel.Text = "CNAE"
        '
        'SuframaLabel
        '
        SuframaLabel.AutoSize = True
        SuframaLabel.Location = New System.Drawing.Point(579, 63)
        SuframaLabel.Name = "SuframaLabel"
        SuframaLabel.Size = New System.Drawing.Size(64, 18)
        SuframaLabel.TabIndex = 8
        SuframaLabel.Text = "Suframa"
        '
        'IE_STLabel
        '
        IE_STLabel.AutoSize = True
        IE_STLabel.Location = New System.Drawing.Point(3, 24)
        IE_STLabel.Name = "IE_STLabel"
        IE_STLabel.Size = New System.Drawing.Size(191, 18)
        IE_STLabel.TabIndex = 10
        IE_STLabel.Text = "IE de Substituição Tributária"
        '
        'Paga_ICMS_STLabel
        '
        Paga_ICMS_STLabel.AutoSize = True
        Paga_ICMS_STLabel.Location = New System.Drawing.Point(216, 24)
        Paga_ICMS_STLabel.Name = "Paga_ICMS_STLabel"
        Paga_ICMS_STLabel.Size = New System.Drawing.Size(106, 18)
        Paga_ICMS_STLabel.TabIndex = 12
        Paga_ICMS_STLabel.Text = "Paga ICMS ST"
        '
        'Nome_Razão_SocialLabel
        '
        Nome_Razão_SocialLabel.AutoSize = True
        Nome_Razão_SocialLabel.Location = New System.Drawing.Point(3, 12)
        Nome_Razão_SocialLabel.Name = "Nome_Razão_SocialLabel"
        Nome_Razão_SocialLabel.Size = New System.Drawing.Size(142, 18)
        Nome_Razão_SocialLabel.TabIndex = 14
        Nome_Razão_SocialLabel.Text = "Nome/Razão Social"
        '
        'Nome_Fantasia_ApelidoLabel
        '
        Nome_Fantasia_ApelidoLabel.AutoSize = True
        Nome_Fantasia_ApelidoLabel.Location = New System.Drawing.Point(3, 63)
        Nome_Fantasia_ApelidoLabel.Name = "Nome_Fantasia_ApelidoLabel"
        Nome_Fantasia_ApelidoLabel.Size = New System.Drawing.Size(161, 18)
        Nome_Fantasia_ApelidoLabel.TabIndex = 16
        Nome_Fantasia_ApelidoLabel.Text = "Nome Fantasia/Apelido"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(6, 20)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(90, 18)
        EndereçoLabel.TabIndex = 18
        EndereçoLabel.Text = "Rua/Avenida"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(439, 20)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(62, 18)
        NumeroLabel.TabIndex = 20
        NumeroLabel.Text = "Numero"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(566, 20)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(102, 18)
        ComplementoLabel.TabIndex = 22
        ComplementoLabel.Text = "Complemento"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(6, 74)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(48, 18)
        BairroLabel.TabIndex = 24
        BairroLabel.Text = "Bairro"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(6, 122)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(54, 18)
        CidadeLabel.TabIndex = 26
        CidadeLabel.Text = "Cidade"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(566, 120)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(28, 18)
        UFLabel.TabIndex = 28
        UFLabel.Text = "UF"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(530, 72)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(39, 18)
        CEPLabel.TabIndex = 30
        CEPLabel.Text = "CEP"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Location = New System.Drawing.Point(6, 25)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(42, 18)
        FoneLabel.TabIndex = 32
        FoneLabel.Text = "Fone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(133, 25)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(32, 18)
        FaxLabel.TabIndex = 34
        FaxLabel.Text = "Fax"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(260, 25)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(54, 18)
        CelularLabel.TabIndex = 36
        CelularLabel.Text = "Celular"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(387, 25)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 18)
        EmailLabel.TabIndex = 38
        EmailLabel.Text = "Email"
        '
        'LimiteLabel
        '
        LimiteLabel.AutoSize = True
        LimiteLabel.Location = New System.Drawing.Point(7, 86)
        LimiteLabel.Name = "LimiteLabel"
        LimiteLabel.Size = New System.Drawing.Size(47, 18)
        LimiteLabel.TabIndex = 40
        LimiteLabel.Text = "Limite"
        '
        'Lançamento_CaixaLabel
        '
        Lançamento_CaixaLabel.AutoSize = True
        Lançamento_CaixaLabel.Location = New System.Drawing.Point(134, 84)
        Lançamento_CaixaLabel.Name = "Lançamento_CaixaLabel"
        Lançamento_CaixaLabel.Size = New System.Drawing.Size(131, 18)
        Lançamento_CaixaLabel.TabIndex = 42
        Lançamento_CaixaLabel.Text = "Lançamento/Caixa"
        '
        'ContatoLabel
        '
        ContatoLabel.AutoSize = True
        ContatoLabel.Location = New System.Drawing.Point(9, 13)
        ContatoLabel.Name = "ContatoLabel"
        ContatoLabel.Size = New System.Drawing.Size(127, 18)
        ContatoLabel.TabIndex = 54
        ContatoLabel.Text = "Nome do Contato"
        '
        'Fone_ContatoLabel
        '
        Fone_ContatoLabel.AutoSize = True
        Fone_ContatoLabel.Location = New System.Drawing.Point(444, 13)
        Fone_ContatoLabel.Name = "Fone_ContatoLabel"
        Fone_ContatoLabel.Size = New System.Drawing.Size(99, 18)
        Fone_ContatoLabel.TabIndex = 56
        Fone_ContatoLabel.Text = "Fone Contato"
        '
        'RamalLabel
        '
        RamalLabel.AutoSize = True
        RamalLabel.Location = New System.Drawing.Point(571, 13)
        RamalLabel.Name = "RamalLabel"
        RamalLabel.Size = New System.Drawing.Size(55, 18)
        RamalLabel.TabIndex = 58
        RamalLabel.Text = "Ramal:"
        '
        'E_mail_ContatoLabel
        '
        E_mail_ContatoLabel.AutoSize = True
        E_mail_ContatoLabel.Location = New System.Drawing.Point(9, 66)
        E_mail_ContatoLabel.Name = "E_mail_ContatoLabel"
        E_mail_ContatoLabel.Size = New System.Drawing.Size(107, 18)
        E_mail_ContatoLabel.TabIndex = 60
        E_mail_ContatoLabel.Text = "E-mail Contato"
        '
        'Obs_ContatoLabel
        '
        Obs_ContatoLabel.AutoSize = True
        Obs_ContatoLabel.Location = New System.Drawing.Point(9, 114)
        Obs_ContatoLabel.Name = "Obs_ContatoLabel"
        Obs_ContatoLabel.Size = New System.Drawing.Size(93, 18)
        Obs_ContatoLabel.TabIndex = 62
        Obs_ContatoLabel.Text = "Obs Contato"
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
        Me.PnForm.Size = New System.Drawing.Size(717, 718)
        Me.PnForm.TabIndex = 89
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.Save_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(506, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 79
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
        Me.Button2.Location = New System.Drawing.Point(612, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Cancelar Sair"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(717, 609)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(CPF_CNPJLabel)
        Me.TabPage1.Controls.Add(Me.CPF_CNPJTextBox)
        Me.TabPage1.Controls.Add(RG_IELabel)
        Me.TabPage1.Controls.Add(Me.RG_IETextBox)
        Me.TabPage1.Controls.Add(CNAELabel)
        Me.TabPage1.Controls.Add(Me.CNAETextBox)
        Me.TabPage1.Controls.Add(SuframaLabel)
        Me.TabPage1.Controls.Add(Me.SuframaTextBox)
        Me.TabPage1.Controls.Add(Nome_Razão_SocialLabel)
        Me.TabPage1.Controls.Add(Me.Nome_Razão_SocialTextBox)
        Me.TabPage1.Controls.Add(Nome_Fantasia_ApelidoLabel)
        Me.TabPage1.Controls.Add(Me.Nome_Fantasia_ApelidoTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(709, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informações Gerais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FoneTextBox)
        Me.GroupBox3.Controls.Add(FoneLabel)
        Me.GroupBox3.Controls.Add(Me.FaxTextBox)
        Me.GroupBox3.Controls.Add(FaxLabel)
        Me.GroupBox3.Controls.Add(Me.CelularTextBox)
        Me.GroupBox3.Controls.Add(CelularLabel)
        Me.GroupBox3.Controls.Add(EmailLabel)
        Me.GroupBox3.Controls.Add(Me.Lançamento_CaixaComboBox)
        Me.GroupBox3.Controls.Add(Lançamento_CaixaLabel)
        Me.GroupBox3.Controls.Add(Me.LimiteTextBox)
        Me.GroupBox3.Controls.Add(LimiteLabel)
        Me.GroupBox3.Controls.Add(Me.EmailTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 182)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Outras Informações"
        '
        'FoneTextBox
        '
        Me.FoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fone", True))
        Me.FoneTextBox.Location = New System.Drawing.Point(9, 46)
        Me.FoneTextBox.Name = "FoneTextBox"
        Me.FoneTextBox.Size = New System.Drawing.Size(121, 24)
        Me.FoneTextBox.TabIndex = 33
        '
        'TbfornecBindingSource
        '
        Me.TbfornecBindingSource.DataMember = "tbfornec"
        Me.TbfornecBindingSource.DataSource = Me.DbforncDataSet
        '
        'DbforncDataSet
        '
        Me.DbforncDataSet.DataSetName = "dbforncDataSet"
        Me.DbforncDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(136, 46)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(121, 24)
        Me.FaxTextBox.TabIndex = 35
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(263, 46)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(121, 24)
        Me.CelularTextBox.TabIndex = 37
        '
        'Lançamento_CaixaComboBox
        '
        Me.Lançamento_CaixaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Lançamento/Caixa", True))
        Me.Lançamento_CaixaComboBox.FormattingEnabled = True
        Me.Lançamento_CaixaComboBox.Location = New System.Drawing.Point(137, 105)
        Me.Lançamento_CaixaComboBox.Name = "Lançamento_CaixaComboBox"
        Me.Lançamento_CaixaComboBox.Size = New System.Drawing.Size(156, 26)
        Me.Lançamento_CaixaComboBox.TabIndex = 43
        '
        'LimiteTextBox
        '
        Me.LimiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Limite", True))
        Me.LimiteTextBox.Location = New System.Drawing.Point(10, 107)
        Me.LimiteTextBox.Name = "LimiteTextBox"
        Me.LimiteTextBox.Size = New System.Drawing.Size(121, 24)
        Me.LimiteTextBox.TabIndex = 41
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(390, 46)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(300, 24)
        Me.EmailTextBox.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EndereçoTextBox)
        Me.GroupBox2.Controls.Add(Me.BairroTextBox)
        Me.GroupBox2.Controls.Add(BairroLabel)
        Me.GroupBox2.Controls.Add(Me.ComplementoTextBox)
        Me.GroupBox2.Controls.Add(ComplementoLabel)
        Me.GroupBox2.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox2.Controls.Add(NumeroLabel)
        Me.GroupBox2.Controls.Add(EndereçoLabel)
        Me.GroupBox2.Controls.Add(Me.UFComboBox)
        Me.GroupBox2.Controls.Add(Me.CEPTextBox)
        Me.GroupBox2.Controls.Add(CEPLabel)
        Me.GroupBox2.Controls.Add(UFLabel)
        Me.GroupBox2.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox2.Controls.Add(CidadeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 183)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(9, 41)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(427, 24)
        Me.EndereçoTextBox.TabIndex = 19
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(9, 95)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(518, 24)
        Me.BairroTextBox.TabIndex = 25
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(569, 41)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(121, 24)
        Me.ComplementoTextBox.TabIndex = 23
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(442, 41)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(121, 24)
        Me.NumeroTextBox.TabIndex = 21
        '
        'UFComboBox
        '
        Me.UFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "UF", True))
        Me.UFComboBox.FormattingEnabled = True
        Me.UFComboBox.Location = New System.Drawing.Point(569, 141)
        Me.UFComboBox.Name = "UFComboBox"
        Me.UFComboBox.Size = New System.Drawing.Size(121, 26)
        Me.UFComboBox.TabIndex = 29
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(533, 93)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(157, 24)
        Me.CEPTextBox.TabIndex = 31
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(9, 143)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(554, 24)
        Me.CidadeTextBox.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IE_STTextBox)
        Me.GroupBox1.Controls.Add(Me.Paga_ICMS_STComboBox)
        Me.GroupBox1.Controls.Add(Paga_ICMS_STLabel)
        Me.GroupBox1.Controls.Add(IE_STLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 85)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Fiscais"
        '
        'IE_STTextBox
        '
        Me.IE_STTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "IE ST", True))
        Me.IE_STTextBox.Location = New System.Drawing.Point(6, 45)
        Me.IE_STTextBox.Name = "IE_STTextBox"
        Me.IE_STTextBox.Size = New System.Drawing.Size(207, 24)
        Me.IE_STTextBox.TabIndex = 11
        '
        'Paga_ICMS_STComboBox
        '
        Me.Paga_ICMS_STComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Paga ICMS ST", True))
        Me.Paga_ICMS_STComboBox.FormattingEnabled = True
        Me.Paga_ICMS_STComboBox.Location = New System.Drawing.Point(219, 45)
        Me.Paga_ICMS_STComboBox.Name = "Paga_ICMS_STComboBox"
        Me.Paga_ICMS_STComboBox.Size = New System.Drawing.Size(121, 26)
        Me.Paga_ICMS_STComboBox.TabIndex = 13
        '
        'CPF_CNPJTextBox
        '
        Me.CPF_CNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "CPF/CNPJ", True))
        Me.CPF_CNPJTextBox.Location = New System.Drawing.Point(490, 33)
        Me.CPF_CNPJTextBox.Name = "CPF_CNPJTextBox"
        Me.CPF_CNPJTextBox.Size = New System.Drawing.Size(213, 24)
        Me.CPF_CNPJTextBox.TabIndex = 3
        '
        'RG_IETextBox
        '
        Me.RG_IETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "RG/IE", True))
        Me.RG_IETextBox.Location = New System.Drawing.Point(328, 84)
        Me.RG_IETextBox.Name = "RG_IETextBox"
        Me.RG_IETextBox.Size = New System.Drawing.Size(121, 24)
        Me.RG_IETextBox.TabIndex = 5
        '
        'CNAETextBox
        '
        Me.CNAETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "CNAE", True))
        Me.CNAETextBox.Location = New System.Drawing.Point(455, 84)
        Me.CNAETextBox.Name = "CNAETextBox"
        Me.CNAETextBox.Size = New System.Drawing.Size(121, 24)
        Me.CNAETextBox.TabIndex = 7
        '
        'SuframaTextBox
        '
        Me.SuframaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Suframa", True))
        Me.SuframaTextBox.Location = New System.Drawing.Point(582, 84)
        Me.SuframaTextBox.Name = "SuframaTextBox"
        Me.SuframaTextBox.Size = New System.Drawing.Size(121, 24)
        Me.SuframaTextBox.TabIndex = 9
        '
        'Nome_Razão_SocialTextBox
        '
        Me.Nome_Razão_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Nome/Razão Social", True))
        Me.Nome_Razão_SocialTextBox.Location = New System.Drawing.Point(6, 33)
        Me.Nome_Razão_SocialTextBox.Name = "Nome_Razão_SocialTextBox"
        Me.Nome_Razão_SocialTextBox.Size = New System.Drawing.Size(478, 24)
        Me.Nome_Razão_SocialTextBox.TabIndex = 15
        '
        'Nome_Fantasia_ApelidoTextBox
        '
        Me.Nome_Fantasia_ApelidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Nome Fantasia/Apelido", True))
        Me.Nome_Fantasia_ApelidoTextBox.Location = New System.Drawing.Point(6, 84)
        Me.Nome_Fantasia_ApelidoTextBox.Name = "Nome_Fantasia_ApelidoTextBox"
        Me.Nome_Fantasia_ApelidoTextBox.Size = New System.Drawing.Size(316, 24)
        Me.Nome_Fantasia_ApelidoTextBox.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(ContatoLabel)
        Me.TabPage2.Controls.Add(Me.ContatoTextBox)
        Me.TabPage2.Controls.Add(Fone_ContatoLabel)
        Me.TabPage2.Controls.Add(Me.Fone_ContatoTextBox)
        Me.TabPage2.Controls.Add(RamalLabel)
        Me.TabPage2.Controls.Add(Me.RamalTextBox)
        Me.TabPage2.Controls.Add(E_mail_ContatoLabel)
        Me.TabPage2.Controls.Add(Me.E_mail_ContatoTextBox)
        Me.TabPage2.Controls.Add(Obs_ContatoLabel)
        Me.TabPage2.Controls.Add(Me.Obs_ContatoTextBox)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(709, 580)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados Complementares"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ContatoTextBox
        '
        Me.ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Contato", True))
        Me.ContatoTextBox.Location = New System.Drawing.Point(12, 34)
        Me.ContatoTextBox.Name = "ContatoTextBox"
        Me.ContatoTextBox.Size = New System.Drawing.Size(429, 24)
        Me.ContatoTextBox.TabIndex = 55
        '
        'Fone_ContatoTextBox
        '
        Me.Fone_ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fone Contato", True))
        Me.Fone_ContatoTextBox.Location = New System.Drawing.Point(447, 34)
        Me.Fone_ContatoTextBox.Name = "Fone_ContatoTextBox"
        Me.Fone_ContatoTextBox.Size = New System.Drawing.Size(121, 24)
        Me.Fone_ContatoTextBox.TabIndex = 57
        '
        'RamalTextBox
        '
        Me.RamalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Ramal", True))
        Me.RamalTextBox.Location = New System.Drawing.Point(574, 34)
        Me.RamalTextBox.Name = "RamalTextBox"
        Me.RamalTextBox.Size = New System.Drawing.Size(121, 24)
        Me.RamalTextBox.TabIndex = 59
        '
        'E_mail_ContatoTextBox
        '
        Me.E_mail_ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "E-mail Contato", True))
        Me.E_mail_ContatoTextBox.Location = New System.Drawing.Point(12, 87)
        Me.E_mail_ContatoTextBox.Name = "E_mail_ContatoTextBox"
        Me.E_mail_ContatoTextBox.Size = New System.Drawing.Size(293, 24)
        Me.E_mail_ContatoTextBox.TabIndex = 61
        '
        'Obs_ContatoTextBox
        '
        Me.Obs_ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Obs Contato", True))
        Me.Obs_ContatoTextBox.Location = New System.Drawing.Point(12, 135)
        Me.Obs_ContatoTextBox.Multiline = True
        Me.Obs_ContatoTextBox.Name = "Obs_ContatoTextBox"
        Me.Obs_ContatoTextBox.Size = New System.Drawing.Size(683, 428)
        Me.Obs_ContatoTextBox.TabIndex = 63
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DataSource = Me.TbfornecBindingSource
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(624, 35)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(67, 24)
        Me.LocalComboBox.TabIndex = 102
        Me.LocalComboBox.ValueMember = "Código"
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
        Me.BtnClose.Location = New System.Drawing.Point(660, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 91
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.NameForm.Size = New System.Drawing.Size(253, 24)
        Me.NameForm.TabIndex = 90
        Me.NameForm.Text = "Cadastro/Alteração Fornecedores"
        '
        'TbfornecTableAdapter
        '
        Me.TbfornecTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbfornecTableAdapter = Me.TbfornecTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.dbforncDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FornecedoresCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(718, 757)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FornecedoresCad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FornecedoresCad"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TbfornecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbforncDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DbforncDataSet As dbforncDataSet
    Friend WithEvents TbfornecBindingSource As BindingSource
    Friend WithEvents TbfornecTableAdapter As dbforncDataSetTableAdapters.tbfornecTableAdapter
    Friend WithEvents TableAdapterManager As dbforncDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CPF_CNPJTextBox As TextBox
    Friend WithEvents RG_IETextBox As TextBox
    Friend WithEvents CNAETextBox As TextBox
    Friend WithEvents SuframaTextBox As TextBox
    Friend WithEvents IE_STTextBox As TextBox
    Friend WithEvents Paga_ICMS_STComboBox As ComboBox
    Friend WithEvents Nome_Razão_SocialTextBox As TextBox
    Friend WithEvents Nome_Fantasia_ApelidoTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents UFComboBox As ComboBox
    Friend WithEvents CEPTextBox As TextBox
    Friend WithEvents FoneTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LimiteTextBox As TextBox
    Friend WithEvents Lançamento_CaixaComboBox As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ContatoTextBox As TextBox
    Friend WithEvents Fone_ContatoTextBox As TextBox
    Friend WithEvents RamalTextBox As TextBox
    Friend WithEvents E_mail_ContatoTextBox As TextBox
    Friend WithEvents Obs_ContatoTextBox As TextBox
    Friend WithEvents LocalComboBox As ComboBox
End Class
