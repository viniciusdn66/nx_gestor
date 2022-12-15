<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesCad
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
        Dim Tipo_PessoaLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim NascimentoLabel As System.Windows.Forms.Label
        Dim Nome_Razão_SocialLabel As System.Windows.Forms.Label
        Dim Nome_FantasiaLabel As System.Windows.Forms.Label
        Dim CPF_CNPJLabel As System.Windows.Forms.Label
        Dim RG_IELabel As System.Windows.Forms.Label
        Dim EmissorLabel As System.Windows.Forms.Label
        Dim Nome_da_MãeLabel As System.Windows.Forms.Label
        Dim Nome_do_PaiLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim A_vistaLabel As System.Windows.Forms.Label
        Dim JurosLabel As System.Windows.Forms.Label
        Dim BloqueioLabel As System.Windows.Forms.Label
        Dim RendaLabel As System.Windows.Forms.Label
        Dim LimiteLabel As System.Windows.Forms.Label
        Dim Limite_mensalLabel As System.Windows.Forms.Label
        Dim Capital_EmpresaLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim PrazoLabel As System.Windows.Forms.Label
        Dim PagamentoLabel As System.Windows.Forms.Label
        Dim Destaca_ICMS_STLabel As System.Windows.Forms.Label
        Dim Grupo_Fiscal_Pis_CofinsLabel As System.Windows.Forms.Label
        Dim Contas_a_PagarLabel As System.Windows.Forms.Label
        Dim Total_a_PagarLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.TbclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbclientDataSet = New nx_gestor.dbclientDataSet()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.FoneTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.UFComboBox = New System.Windows.Forms.ComboBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Nome_do_PaiTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_da_MãeTextBox = New System.Windows.Forms.TextBox()
        Me.EmissorTextBox = New System.Windows.Forms.TextBox()
        Me.RG_IETextBox = New System.Windows.Forms.TextBox()
        Me.CPF_CNPJTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_FantasiaTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_Razão_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_PessoaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.NascimentoTextBox = New System.Windows.Forms.TextBox()
        Me.SexoComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Grupo_Fiscal_Pis_CofinsComboBox = New System.Windows.Forms.ComboBox()
        Me.Destaca_ICMS_STComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PagamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.PrazoComboBox = New System.Windows.Forms.ComboBox()
        Me.VendedorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Capital_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.RendaTextBox = New System.Windows.Forms.TextBox()
        Me.Limite_mensalTextBox = New System.Windows.Forms.TextBox()
        Me.BloqueioComboBox = New System.Windows.Forms.ComboBox()
        Me.LimiteTextBox = New System.Windows.Forms.TextBox()
        Me.JurosComboBox = New System.Windows.Forms.ComboBox()
        Me.A_vistaComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Total_a_PagarTextBox = New System.Windows.Forms.TextBox()
        Me.Contas_a_PagarListBox = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TbclientTableAdapter = New nx_gestor.dbclientDataSetTableAdapters.tbclientTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbclientDataSetTableAdapters.TableAdapterManager()
        Tipo_PessoaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        NascimentoLabel = New System.Windows.Forms.Label()
        Nome_Razão_SocialLabel = New System.Windows.Forms.Label()
        Nome_FantasiaLabel = New System.Windows.Forms.Label()
        CPF_CNPJLabel = New System.Windows.Forms.Label()
        RG_IELabel = New System.Windows.Forms.Label()
        EmissorLabel = New System.Windows.Forms.Label()
        Nome_da_MãeLabel = New System.Windows.Forms.Label()
        Nome_do_PaiLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        FoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        A_vistaLabel = New System.Windows.Forms.Label()
        JurosLabel = New System.Windows.Forms.Label()
        BloqueioLabel = New System.Windows.Forms.Label()
        RendaLabel = New System.Windows.Forms.Label()
        LimiteLabel = New System.Windows.Forms.Label()
        Limite_mensalLabel = New System.Windows.Forms.Label()
        Capital_EmpresaLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        PrazoLabel = New System.Windows.Forms.Label()
        PagamentoLabel = New System.Windows.Forms.Label()
        Destaca_ICMS_STLabel = New System.Windows.Forms.Label()
        Grupo_Fiscal_Pis_CofinsLabel = New System.Windows.Forms.Label()
        Contas_a_PagarLabel = New System.Windows.Forms.Label()
        Total_a_PagarLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TbclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbclientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tipo_PessoaLabel
        '
        Tipo_PessoaLabel.AutoSize = True
        Tipo_PessoaLabel.Location = New System.Drawing.Point(514, 26)
        Tipo_PessoaLabel.Name = "Tipo_PessoaLabel"
        Tipo_PessoaLabel.Size = New System.Drawing.Size(92, 18)
        Tipo_PessoaLabel.TabIndex = 0
        Tipo_PessoaLabel.Text = "Tipo Pessoa"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(641, 25)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(72, 18)
        CategoriaLabel.TabIndex = 2
        CategoriaLabel.Text = "Categoria"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(384, 24)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(42, 18)
        SexoLabel.TabIndex = 4
        SexoLabel.Text = "Sexo"
        '
        'NascimentoLabel
        '
        NascimentoLabel.AutoSize = True
        NascimentoLabel.Location = New System.Drawing.Point(225, 77)
        NascimentoLabel.Name = "NascimentoLabel"
        NascimentoLabel.Size = New System.Drawing.Size(88, 18)
        NascimentoLabel.TabIndex = 6
        NascimentoLabel.Text = "Nascimento"
        '
        'Nome_Razão_SocialLabel
        '
        Nome_Razão_SocialLabel.AutoSize = True
        Nome_Razão_SocialLabel.Location = New System.Drawing.Point(14, 26)
        Nome_Razão_SocialLabel.Name = "Nome_Razão_SocialLabel"
        Nome_Razão_SocialLabel.Size = New System.Drawing.Size(142, 18)
        Nome_Razão_SocialLabel.TabIndex = 8
        Nome_Razão_SocialLabel.Text = "Nome/Razão Social"
        '
        'Nome_FantasiaLabel
        '
        Nome_FantasiaLabel.AutoSize = True
        Nome_FantasiaLabel.Location = New System.Drawing.Point(14, 79)
        Nome_FantasiaLabel.Name = "Nome_FantasiaLabel"
        Nome_FantasiaLabel.Size = New System.Drawing.Size(161, 18)
        Nome_FantasiaLabel.TabIndex = 10
        Nome_FantasiaLabel.Text = "Nome Fantasia/Apelido"
        '
        'CPF_CNPJLabel
        '
        CPF_CNPJLabel.AutoSize = True
        CPF_CNPJLabel.Location = New System.Drawing.Point(348, 77)
        CPF_CNPJLabel.Name = "CPF_CNPJLabel"
        CPF_CNPJLabel.Size = New System.Drawing.Size(82, 18)
        CPF_CNPJLabel.TabIndex = 12
        CPF_CNPJLabel.Text = "CPF/CNPJ"
        '
        'RG_IELabel
        '
        RG_IELabel.AutoSize = True
        RG_IELabel.Location = New System.Drawing.Point(573, 77)
        RG_IELabel.Name = "RG_IELabel"
        RG_IELabel.Size = New System.Drawing.Size(48, 18)
        RG_IELabel.TabIndex = 14
        RG_IELabel.Text = "RG/IE"
        '
        'EmissorLabel
        '
        EmissorLabel.AutoSize = True
        EmissorLabel.Location = New System.Drawing.Point(679, 77)
        EmissorLabel.Name = "EmissorLabel"
        EmissorLabel.Size = New System.Drawing.Size(64, 18)
        EmissorLabel.TabIndex = 16
        EmissorLabel.Text = "Emissor"
        '
        'Nome_da_MãeLabel
        '
        Nome_da_MãeLabel.AutoSize = True
        Nome_da_MãeLabel.Location = New System.Drawing.Point(12, 20)
        Nome_da_MãeLabel.Name = "Nome_da_MãeLabel"
        Nome_da_MãeLabel.Size = New System.Drawing.Size(102, 18)
        Nome_da_MãeLabel.TabIndex = 0
        Nome_da_MãeLabel.Text = "Nome da Mãe"
        '
        'Nome_do_PaiLabel
        '
        Nome_do_PaiLabel.AutoSize = True
        Nome_do_PaiLabel.Location = New System.Drawing.Point(367, 20)
        Nome_do_PaiLabel.Name = "Nome_do_PaiLabel"
        Nome_do_PaiLabel.Size = New System.Drawing.Size(95, 18)
        Nome_do_PaiLabel.TabIndex = 2
        Nome_do_PaiLabel.Text = "Nome do Pai"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(6, 29)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(90, 18)
        EndereçoLabel.TabIndex = 0
        EndereçoLabel.Text = "Rua/Avenida"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(521, 29)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(62, 18)
        NumeroLabel.TabIndex = 2
        NumeroLabel.Text = "Numero"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(6, 77)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(48, 18)
        BairroLabel.TabIndex = 4
        BairroLabel.Text = "Bairro"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(624, 29)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(102, 18)
        ComplementoLabel.TabIndex = 6
        ComplementoLabel.Text = "Complemento"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(350, 77)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(54, 18)
        CidadeLabel.TabIndex = 8
        CidadeLabel.Text = "Cidade"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(596, 77)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(28, 18)
        UFLabel.TabIndex = 10
        UFLabel.Text = "UF"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(660, 77)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(39, 18)
        CEPLabel.TabIndex = 12
        CEPLabel.Text = "CEP"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Location = New System.Drawing.Point(6, 29)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(42, 18)
        FoneLabel.TabIndex = 0
        FoneLabel.Text = "Fone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(131, 29)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(32, 18)
        FaxLabel.TabIndex = 2
        FaxLabel.Text = "Fax"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(256, 29)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(54, 18)
        CelularLabel.TabIndex = 4
        CelularLabel.Text = "Celular"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(381, 29)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(50, 18)
        E_mailLabel.TabIndex = 6
        E_mailLabel.Text = "E-mail"
        '
        'A_vistaLabel
        '
        A_vistaLabel.AutoSize = True
        A_vistaLabel.Location = New System.Drawing.Point(3, 22)
        A_vistaLabel.Name = "A_vistaLabel"
        A_vistaLabel.Size = New System.Drawing.Size(51, 18)
        A_vistaLabel.TabIndex = 0
        A_vistaLabel.Text = "A vista"
        '
        'JurosLabel
        '
        JurosLabel.AutoSize = True
        JurosLabel.Location = New System.Drawing.Point(84, 22)
        JurosLabel.Name = "JurosLabel"
        JurosLabel.Size = New System.Drawing.Size(46, 18)
        JurosLabel.TabIndex = 2
        JurosLabel.Text = "Juros"
        '
        'BloqueioLabel
        '
        BloqueioLabel.AutoSize = True
        BloqueioLabel.Location = New System.Drawing.Point(165, 22)
        BloqueioLabel.Name = "BloqueioLabel"
        BloqueioLabel.Size = New System.Drawing.Size(66, 18)
        BloqueioLabel.TabIndex = 4
        BloqueioLabel.Text = "Bloqueio"
        '
        'RendaLabel
        '
        RendaLabel.AutoSize = True
        RendaLabel.Location = New System.Drawing.Point(246, 22)
        RendaLabel.Name = "RendaLabel"
        RendaLabel.Size = New System.Drawing.Size(51, 18)
        RendaLabel.TabIndex = 6
        RendaLabel.Text = "Renda"
        '
        'LimiteLabel
        '
        LimiteLabel.AutoSize = True
        LimiteLabel.Location = New System.Drawing.Point(352, 22)
        LimiteLabel.Name = "LimiteLabel"
        LimiteLabel.Size = New System.Drawing.Size(47, 18)
        LimiteLabel.TabIndex = 1
        LimiteLabel.Text = "Limite"
        '
        'Limite_mensalLabel
        '
        Limite_mensalLabel.AutoSize = True
        Limite_mensalLabel.Location = New System.Drawing.Point(458, 22)
        Limite_mensalLabel.Name = "Limite_mensalLabel"
        Limite_mensalLabel.Size = New System.Drawing.Size(99, 18)
        Limite_mensalLabel.TabIndex = 3
        Limite_mensalLabel.Text = "Limite mensal"
        '
        'Capital_EmpresaLabel
        '
        Capital_EmpresaLabel.AutoSize = True
        Capital_EmpresaLabel.Location = New System.Drawing.Point(564, 22)
        Capital_EmpresaLabel.Name = "Capital_EmpresaLabel"
        Capital_EmpresaLabel.Size = New System.Drawing.Size(117, 18)
        Capital_EmpresaLabel.TabIndex = 5
        Capital_EmpresaLabel.Text = "Capital Empresa"
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Location = New System.Drawing.Point(6, 29)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(71, 18)
        VendedorLabel.TabIndex = 0
        VendedorLabel.Text = "Vendedor"
        '
        'PrazoLabel
        '
        PrazoLabel.AutoSize = True
        PrazoLabel.Location = New System.Drawing.Point(165, 25)
        PrazoLabel.Name = "PrazoLabel"
        PrazoLabel.Size = New System.Drawing.Size(48, 18)
        PrazoLabel.TabIndex = 2
        PrazoLabel.Text = "Prazo"
        '
        'PagamentoLabel
        '
        PagamentoLabel.AutoSize = True
        PagamentoLabel.Location = New System.Drawing.Point(292, 27)
        PagamentoLabel.Name = "PagamentoLabel"
        PagamentoLabel.Size = New System.Drawing.Size(84, 18)
        PagamentoLabel.TabIndex = 4
        PagamentoLabel.Text = "Pagamento"
        '
        'Destaca_ICMS_STLabel
        '
        Destaca_ICMS_STLabel.AutoSize = True
        Destaca_ICMS_STLabel.Location = New System.Drawing.Point(6, 102)
        Destaca_ICMS_STLabel.Name = "Destaca_ICMS_STLabel"
        Destaca_ICMS_STLabel.Size = New System.Drawing.Size(127, 18)
        Destaca_ICMS_STLabel.TabIndex = 0
        Destaca_ICMS_STLabel.Text = "Destaca ICMS ST"
        '
        'Grupo_Fiscal_Pis_CofinsLabel
        '
        Grupo_Fiscal_Pis_CofinsLabel.AutoSize = True
        Grupo_Fiscal_Pis_CofinsLabel.Location = New System.Drawing.Point(377, 102)
        Grupo_Fiscal_Pis_CofinsLabel.Name = "Grupo_Fiscal_Pis_CofinsLabel"
        Grupo_Fiscal_Pis_CofinsLabel.Size = New System.Drawing.Size(165, 18)
        Grupo_Fiscal_Pis_CofinsLabel.TabIndex = 2
        Grupo_Fiscal_Pis_CofinsLabel.Text = "Grupo Fiscal Pis/Cofins"
        '
        'Contas_a_PagarLabel
        '
        Contas_a_PagarLabel.AutoSize = True
        Contas_a_PagarLabel.Location = New System.Drawing.Point(6, 3)
        Contas_a_PagarLabel.Name = "Contas_a_PagarLabel"
        Contas_a_PagarLabel.Size = New System.Drawing.Size(111, 18)
        Contas_a_PagarLabel.TabIndex = 0
        Contas_a_PagarLabel.Text = "Contas a Pagar"
        '
        'Total_a_PagarLabel
        '
        Total_a_PagarLabel.AutoSize = True
        Total_a_PagarLabel.Location = New System.Drawing.Point(647, 442)
        Total_a_PagarLabel.Name = "Total_a_PagarLabel"
        Total_a_PagarLabel.Size = New System.Drawing.Size(96, 18)
        Total_a_PagarLabel.TabIndex = 2
        Total_a_PagarLabel.Text = "Total a Pagar"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Controls.Add(Me.TabControl1)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.LocalComboBox)
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(795, 642)
        Me.PnForm.TabIndex = 86
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.Save_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(584, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Salvar Cadastro"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(791, 524)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(783, 493)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informações Pessoais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(E_mailLabel)
        Me.GroupBox4.Controls.Add(Me.E_mailTextBox)
        Me.GroupBox4.Controls.Add(CelularLabel)
        Me.GroupBox4.Controls.Add(Me.CelularTextBox)
        Me.GroupBox4.Controls.Add(FaxLabel)
        Me.GroupBox4.Controls.Add(Me.FaxTextBox)
        Me.GroupBox4.Controls.Add(FoneLabel)
        Me.GroupBox4.Controls.Add(Me.FoneTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 386)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(769, 103)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fones e Contatos"
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(384, 50)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(379, 24)
        Me.E_mailTextBox.TabIndex = 7
        '
        'TbclientBindingSource
        '
        Me.TbclientBindingSource.DataMember = "tbclient"
        Me.TbclientBindingSource.DataSource = Me.DbclientDataSet
        '
        'DbclientDataSet
        '
        Me.DbclientDataSet.DataSetName = "dbclientDataSet"
        Me.DbclientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(259, 50)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(119, 24)
        Me.CelularTextBox.TabIndex = 5
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(134, 50)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(119, 24)
        Me.FaxTextBox.TabIndex = 3
        '
        'FoneTextBox
        '
        Me.FoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Fone", True))
        Me.FoneTextBox.Location = New System.Drawing.Point(9, 50)
        Me.FoneTextBox.Name = "FoneTextBox"
        Me.FoneTextBox.Size = New System.Drawing.Size(119, 24)
        Me.FoneTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(CEPLabel)
        Me.GroupBox3.Controls.Add(Me.CEPTextBox)
        Me.GroupBox3.Controls.Add(UFLabel)
        Me.GroupBox3.Controls.Add(Me.UFComboBox)
        Me.GroupBox3.Controls.Add(CidadeLabel)
        Me.GroupBox3.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox3.Controls.Add(ComplementoLabel)
        Me.GroupBox3.Controls.Add(Me.ComplementoTextBox)
        Me.GroupBox3.Controls.Add(BairroLabel)
        Me.GroupBox3.Controls.Add(Me.BairroTextBox)
        Me.GroupBox3.Controls.Add(NumeroLabel)
        Me.GroupBox3.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox3.Controls.Add(EndereçoLabel)
        Me.GroupBox3.Controls.Add(Me.EndereçoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(769, 150)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações de Endereço"
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(663, 98)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 24)
        Me.CEPTextBox.TabIndex = 7
        '
        'UFComboBox
        '
        Me.UFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "UF", True))
        Me.UFComboBox.FormattingEnabled = True
        Me.UFComboBox.ItemHeight = 18
        Me.UFComboBox.Location = New System.Drawing.Point(599, 98)
        Me.UFComboBox.Name = "UFComboBox"
        Me.UFComboBox.Size = New System.Drawing.Size(58, 26)
        Me.UFComboBox.TabIndex = 11
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(353, 98)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(240, 24)
        Me.CidadeTextBox.TabIndex = 5
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(630, 50)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(133, 24)
        Me.ComplementoTextBox.TabIndex = 3
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(9, 98)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(336, 24)
        Me.BairroTextBox.TabIndex = 4
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(524, 50)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 24)
        Me.NumeroTextBox.TabIndex = 2
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(9, 50)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(509, 24)
        Me.EndereçoTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EmissorLabel)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.EmissorTextBox)
        Me.GroupBox1.Controls.Add(RG_IELabel)
        Me.GroupBox1.Controls.Add(Me.RG_IETextBox)
        Me.GroupBox1.Controls.Add(CPF_CNPJLabel)
        Me.GroupBox1.Controls.Add(Me.CPF_CNPJTextBox)
        Me.GroupBox1.Controls.Add(Nome_FantasiaLabel)
        Me.GroupBox1.Controls.Add(Me.Nome_FantasiaTextBox)
        Me.GroupBox1.Controls.Add(Me.Nome_Razão_SocialTextBox)
        Me.GroupBox1.Controls.Add(Nome_Razão_SocialLabel)
        Me.GroupBox1.Controls.Add(Me.Tipo_PessoaComboBox)
        Me.GroupBox1.Controls.Add(Tipo_PessoaLabel)
        Me.GroupBox1.Controls.Add(NascimentoLabel)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.NascimentoTextBox)
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(SexoLabel)
        Me.GroupBox1.Controls.Add(Me.SexoComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Pessoais"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Nome_do_PaiLabel)
        Me.GroupBox2.Controls.Add(Me.Nome_do_PaiTextBox)
        Me.GroupBox2.Controls.Add(Nome_da_MãeLabel)
        Me.GroupBox2.Controls.Add(Me.Nome_da_MãeTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 83)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filiação"
        '
        'Nome_do_PaiTextBox
        '
        Me.Nome_do_PaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Nome do Pai", True))
        Me.Nome_do_PaiTextBox.Location = New System.Drawing.Point(370, 41)
        Me.Nome_do_PaiTextBox.Name = "Nome_do_PaiTextBox"
        Me.Nome_do_PaiTextBox.Size = New System.Drawing.Size(349, 24)
        Me.Nome_do_PaiTextBox.TabIndex = 2
        '
        'Nome_da_MãeTextBox
        '
        Me.Nome_da_MãeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Nome da Mãe", True))
        Me.Nome_da_MãeTextBox.Location = New System.Drawing.Point(15, 41)
        Me.Nome_da_MãeTextBox.Name = "Nome_da_MãeTextBox"
        Me.Nome_da_MãeTextBox.Size = New System.Drawing.Size(349, 24)
        Me.Nome_da_MãeTextBox.TabIndex = 1
        '
        'EmissorTextBox
        '
        Me.EmissorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Emissor", True))
        Me.EmissorTextBox.Location = New System.Drawing.Point(682, 98)
        Me.EmissorTextBox.Name = "EmissorTextBox"
        Me.EmissorTextBox.Size = New System.Drawing.Size(81, 24)
        Me.EmissorTextBox.TabIndex = 9
        '
        'RG_IETextBox
        '
        Me.RG_IETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "RG/IE", True))
        Me.RG_IETextBox.Location = New System.Drawing.Point(576, 98)
        Me.RG_IETextBox.Name = "RG_IETextBox"
        Me.RG_IETextBox.Size = New System.Drawing.Size(100, 24)
        Me.RG_IETextBox.TabIndex = 8
        '
        'CPF_CNPJTextBox
        '
        Me.CPF_CNPJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "CPF/CNPJ", True))
        Me.CPF_CNPJTextBox.Location = New System.Drawing.Point(351, 98)
        Me.CPF_CNPJTextBox.Name = "CPF_CNPJTextBox"
        Me.CPF_CNPJTextBox.Size = New System.Drawing.Size(219, 24)
        Me.CPF_CNPJTextBox.TabIndex = 7
        '
        'Nome_FantasiaTextBox
        '
        Me.Nome_FantasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Nome Fantasia", True))
        Me.Nome_FantasiaTextBox.Location = New System.Drawing.Point(17, 98)
        Me.Nome_FantasiaTextBox.Name = "Nome_FantasiaTextBox"
        Me.Nome_FantasiaTextBox.Size = New System.Drawing.Size(205, 24)
        Me.Nome_FantasiaTextBox.TabIndex = 5
        '
        'Nome_Razão_SocialTextBox
        '
        Me.Nome_Razão_SocialTextBox.BackColor = System.Drawing.Color.White
        Me.Nome_Razão_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Nome/Razão Social", True))
        Me.Nome_Razão_SocialTextBox.Location = New System.Drawing.Point(17, 47)
        Me.Nome_Razão_SocialTextBox.Name = "Nome_Razão_SocialTextBox"
        Me.Nome_Razão_SocialTextBox.Size = New System.Drawing.Size(364, 24)
        Me.Nome_Razão_SocialTextBox.TabIndex = 1
        '
        'Tipo_PessoaComboBox
        '
        Me.Tipo_PessoaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Tipo Pessoa", True))
        Me.Tipo_PessoaComboBox.FormattingEnabled = True
        Me.Tipo_PessoaComboBox.Items.AddRange(New Object() {"Pessoa Fisica", "Pessoa Juridica"})
        Me.Tipo_PessoaComboBox.Location = New System.Drawing.Point(517, 47)
        Me.Tipo_PessoaComboBox.Name = "Tipo_PessoaComboBox"
        Me.Tipo_PessoaComboBox.Size = New System.Drawing.Size(121, 26)
        Me.Tipo_PessoaComboBox.TabIndex = 3
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Categoria", True))
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(644, 47)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(119, 26)
        Me.CategoriaComboBox.TabIndex = 4
        '
        'NascimentoTextBox
        '
        Me.NascimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Nascimento", True))
        Me.NascimentoTextBox.Location = New System.Drawing.Point(228, 98)
        Me.NascimentoTextBox.Name = "NascimentoTextBox"
        Me.NascimentoTextBox.Size = New System.Drawing.Size(117, 24)
        Me.NascimentoTextBox.TabIndex = 6
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Sexo", True))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.ItemHeight = 18
        Me.SexoComboBox.Location = New System.Drawing.Point(387, 45)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(121, 26)
        Me.SexoComboBox.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(783, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informações Adicionais"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Grupo_Fiscal_Pis_CofinsLabel)
        Me.GroupBox7.Controls.Add(Me.Grupo_Fiscal_Pis_CofinsComboBox)
        Me.GroupBox7.Controls.Add(Destaca_ICMS_STLabel)
        Me.GroupBox7.Controls.Add(Me.Destaca_ICMS_STComboBox)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 226)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(768, 261)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Informações Fiscais"
        '
        'Grupo_Fiscal_Pis_CofinsComboBox
        '
        Me.Grupo_Fiscal_Pis_CofinsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Grupo Fiscal Pis/Cofins", True))
        Me.Grupo_Fiscal_Pis_CofinsComboBox.FormattingEnabled = True
        Me.Grupo_Fiscal_Pis_CofinsComboBox.Location = New System.Drawing.Point(380, 123)
        Me.Grupo_Fiscal_Pis_CofinsComboBox.Name = "Grupo_Fiscal_Pis_CofinsComboBox"
        Me.Grupo_Fiscal_Pis_CofinsComboBox.Size = New System.Drawing.Size(382, 26)
        Me.Grupo_Fiscal_Pis_CofinsComboBox.TabIndex = 2
        '
        'Destaca_ICMS_STComboBox
        '
        Me.Destaca_ICMS_STComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Destaca ICMS ST", True))
        Me.Destaca_ICMS_STComboBox.FormattingEnabled = True
        Me.Destaca_ICMS_STComboBox.Location = New System.Drawing.Point(9, 123)
        Me.Destaca_ICMS_STComboBox.Name = "Destaca_ICMS_STComboBox"
        Me.Destaca_ICMS_STComboBox.Size = New System.Drawing.Size(365, 26)
        Me.Destaca_ICMS_STComboBox.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(PagamentoLabel)
        Me.GroupBox6.Controls.Add(Me.PagamentoComboBox)
        Me.GroupBox6.Controls.Add(PrazoLabel)
        Me.GroupBox6.Controls.Add(Me.PrazoComboBox)
        Me.GroupBox6.Controls.Add(VendedorLabel)
        Me.GroupBox6.Controls.Add(Me.VendedorTextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 101)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(768, 119)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Informações de venda"
        '
        'PagamentoComboBox
        '
        Me.PagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Pagamento", True))
        Me.PagamentoComboBox.FormattingEnabled = True
        Me.PagamentoComboBox.Location = New System.Drawing.Point(295, 48)
        Me.PagamentoComboBox.Name = "PagamentoComboBox"
        Me.PagamentoComboBox.Size = New System.Drawing.Size(121, 26)
        Me.PagamentoComboBox.TabIndex = 3
        '
        'PrazoComboBox
        '
        Me.PrazoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Prazo", True))
        Me.PrazoComboBox.FormattingEnabled = True
        Me.PrazoComboBox.Location = New System.Drawing.Point(168, 48)
        Me.PrazoComboBox.Name = "PrazoComboBox"
        Me.PrazoComboBox.Size = New System.Drawing.Size(121, 26)
        Me.PrazoComboBox.TabIndex = 2
        '
        'VendedorTextBox
        '
        Me.VendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Vendedor", True))
        Me.VendedorTextBox.Location = New System.Drawing.Point(9, 50)
        Me.VendedorTextBox.Name = "VendedorTextBox"
        Me.VendedorTextBox.Size = New System.Drawing.Size(153, 24)
        Me.VendedorTextBox.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Capital_EmpresaLabel)
        Me.GroupBox5.Controls.Add(RendaLabel)
        Me.GroupBox5.Controls.Add(Me.Capital_EmpresaTextBox)
        Me.GroupBox5.Controls.Add(Me.RendaTextBox)
        Me.GroupBox5.Controls.Add(Limite_mensalLabel)
        Me.GroupBox5.Controls.Add(BloqueioLabel)
        Me.GroupBox5.Controls.Add(Me.Limite_mensalTextBox)
        Me.GroupBox5.Controls.Add(Me.BloqueioComboBox)
        Me.GroupBox5.Controls.Add(LimiteLabel)
        Me.GroupBox5.Controls.Add(JurosLabel)
        Me.GroupBox5.Controls.Add(Me.LimiteTextBox)
        Me.GroupBox5.Controls.Add(Me.JurosComboBox)
        Me.GroupBox5.Controls.Add(A_vistaLabel)
        Me.GroupBox5.Controls.Add(Me.A_vistaComboBox)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(769, 89)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dados Financeiros"
        '
        'Capital_EmpresaTextBox
        '
        Me.Capital_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Capital Empresa", True))
        Me.Capital_EmpresaTextBox.Location = New System.Drawing.Point(567, 43)
        Me.Capital_EmpresaTextBox.Name = "Capital_EmpresaTextBox"
        Me.Capital_EmpresaTextBox.Size = New System.Drawing.Size(140, 24)
        Me.Capital_EmpresaTextBox.TabIndex = 7
        '
        'RendaTextBox
        '
        Me.RendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Renda", True))
        Me.RendaTextBox.Location = New System.Drawing.Point(249, 43)
        Me.RendaTextBox.Name = "RendaTextBox"
        Me.RendaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.RendaTextBox.TabIndex = 4
        '
        'Limite_mensalTextBox
        '
        Me.Limite_mensalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Limite mensal", True))
        Me.Limite_mensalTextBox.Location = New System.Drawing.Point(461, 43)
        Me.Limite_mensalTextBox.Name = "Limite_mensalTextBox"
        Me.Limite_mensalTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Limite_mensalTextBox.TabIndex = 6
        '
        'BloqueioComboBox
        '
        Me.BloqueioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Bloqueio", True))
        Me.BloqueioComboBox.FormattingEnabled = True
        Me.BloqueioComboBox.Location = New System.Drawing.Point(168, 43)
        Me.BloqueioComboBox.Name = "BloqueioComboBox"
        Me.BloqueioComboBox.Size = New System.Drawing.Size(75, 26)
        Me.BloqueioComboBox.TabIndex = 3
        '
        'LimiteTextBox
        '
        Me.LimiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Limite", True))
        Me.LimiteTextBox.Location = New System.Drawing.Point(355, 43)
        Me.LimiteTextBox.Name = "LimiteTextBox"
        Me.LimiteTextBox.Size = New System.Drawing.Size(100, 24)
        Me.LimiteTextBox.TabIndex = 5
        '
        'JurosComboBox
        '
        Me.JurosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Juros", True))
        Me.JurosComboBox.FormattingEnabled = True
        Me.JurosComboBox.Location = New System.Drawing.Point(87, 43)
        Me.JurosComboBox.Name = "JurosComboBox"
        Me.JurosComboBox.Size = New System.Drawing.Size(75, 26)
        Me.JurosComboBox.TabIndex = 2
        '
        'A_vistaComboBox
        '
        Me.A_vistaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "A vista", True))
        Me.A_vistaComboBox.FormattingEnabled = True
        Me.A_vistaComboBox.Location = New System.Drawing.Point(6, 43)
        Me.A_vistaComboBox.Name = "A_vistaComboBox"
        Me.A_vistaComboBox.Size = New System.Drawing.Size(75, 26)
        Me.A_vistaComboBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Total_a_PagarLabel)
        Me.TabPage3.Controls.Add(Me.Total_a_PagarTextBox)
        Me.TabPage3.Controls.Add(Contas_a_PagarLabel)
        Me.TabPage3.Controls.Add(Me.Contas_a_PagarListBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(783, 489)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contas a Pagar "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Total_a_PagarTextBox
        '
        Me.Total_a_PagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Total a Pagar", True))
        Me.Total_a_PagarTextBox.Location = New System.Drawing.Point(650, 463)
        Me.Total_a_PagarTextBox.Name = "Total_a_PagarTextBox"
        Me.Total_a_PagarTextBox.Size = New System.Drawing.Size(124, 24)
        Me.Total_a_PagarTextBox.TabIndex = 3
        '
        'Contas_a_PagarListBox
        '
        Me.Contas_a_PagarListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbclientBindingSource, "Contas a Pagar", True))
        Me.Contas_a_PagarListBox.FormattingEnabled = True
        Me.Contas_a_PagarListBox.ItemHeight = 18
        Me.Contas_a_PagarListBox.Location = New System.Drawing.Point(9, 24)
        Me.Contas_a_PagarListBox.Name = "Contas_a_PagarListBox"
        Me.Contas_a_PagarListBox.Size = New System.Drawing.Size(765, 400)
        Me.Contas_a_PagarListBox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Error_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(690, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Cancelar Sair"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DataSource = Me.TbclientBindingSource
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(715, 7)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(67, 24)
        Me.LocalComboBox.TabIndex = 101
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
        Me.BtnClose.Location = New System.Drawing.Point(738, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 88
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
        Me.NameForm.Size = New System.Drawing.Size(212, 24)
        Me.NameForm.TabIndex = 87
        Me.NameForm.Text = "Cadastro/Alteração Clientes"
        '
        'TbclientTableAdapter
        '
        Me.TbclientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbclientTableAdapter = Me.TbclientTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.dbclientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(796, 681)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClientesCad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesCad"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TbclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbclientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents DbclientDataSet As dbclientDataSet
    Friend WithEvents TbclientBindingSource As BindingSource
    Friend WithEvents TbclientTableAdapter As dbclientDataSetTableAdapters.tbclientTableAdapter
    Friend WithEvents TableAdapterManager As dbclientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Nome_do_PaiTextBox As TextBox
    Friend WithEvents Nome_da_MãeTextBox As TextBox
    Friend WithEvents EmissorTextBox As TextBox
    Friend WithEvents RG_IETextBox As TextBox
    Friend WithEvents CPF_CNPJTextBox As TextBox
    Friend WithEvents Nome_FantasiaTextBox As TextBox
    Friend WithEvents Nome_Razão_SocialTextBox As TextBox
    Friend WithEvents Tipo_PessoaComboBox As ComboBox
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents NascimentoTextBox As TextBox
    Friend WithEvents SexoComboBox As ComboBox
    Friend WithEvents CEPTextBox As TextBox
    Friend WithEvents UFComboBox As ComboBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents FoneTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Grupo_Fiscal_Pis_CofinsComboBox As ComboBox
    Friend WithEvents Destaca_ICMS_STComboBox As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PagamentoComboBox As ComboBox
    Friend WithEvents PrazoComboBox As ComboBox
    Friend WithEvents VendedorTextBox As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Capital_EmpresaTextBox As TextBox
    Friend WithEvents RendaTextBox As TextBox
    Friend WithEvents Limite_mensalTextBox As TextBox
    Friend WithEvents BloqueioComboBox As ComboBox
    Friend WithEvents LimiteTextBox As TextBox
    Friend WithEvents JurosComboBox As ComboBox
    Friend WithEvents A_vistaComboBox As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Total_a_PagarTextBox As TextBox
    Friend WithEvents Contas_a_PagarListBox As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LocalComboBox As ComboBox
End Class
