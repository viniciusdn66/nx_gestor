<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContatoLabel As System.Windows.Forms.Label
        Dim Fone_ContatoLabel As System.Windows.Forms.Label
        Dim RamalLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.RamalTextBox = New System.Windows.Forms.TextBox()
        Me.TbfornecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbforncDataSet = New nx_gestor.dbforncDataSet()
        Me.Fone_ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.ContatoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.FoneTextBox = New System.Windows.Forms.TextBox()
        Me.UFTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeRazãoSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFCNPJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RGIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbfornecBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbforncDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TbfornecTableAdapter = New nx_gestor.dbforncDataSetTableAdapters.tbfornecTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbforncDataSetTableAdapters.TableAdapterManager()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        FoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContatoLabel = New System.Windows.Forms.Label()
        Fone_ContatoLabel = New System.Windows.Forms.Label()
        RamalLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TbfornecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbforncDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbfornecBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbforncDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(29, 523)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(72, 18)
        EndereçoLabel.TabIndex = 120
        EndereçoLabel.Text = "Endereço"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(413, 523)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(62, 18)
        NumeroLabel.TabIndex = 121
        NumeroLabel.Text = "Numero"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(519, 523)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(48, 18)
        BairroLabel.TabIndex = 122
        BairroLabel.Text = "Bairro"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(790, 523)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(54, 18)
        CidadeLabel.TabIndex = 123
        CidadeLabel.Text = "Cidade"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(1033, 523)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(28, 18)
        UFLabel.TabIndex = 124
        UFLabel.Text = "UF"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Location = New System.Drawing.Point(29, 581)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(42, 18)
        FoneLabel.TabIndex = 125
        FoneLabel.Text = "Fone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(319, 581)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(32, 18)
        FaxLabel.TabIndex = 126
        FaxLabel.Text = "Fax"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(174, 581)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(54, 18)
        CelularLabel.TabIndex = 127
        CelularLabel.Text = "Celular"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(464, 582)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 18)
        EmailLabel.TabIndex = 128
        EmailLabel.Text = "Email"
        '
        'ContatoLabel
        '
        ContatoLabel.AutoSize = True
        ContatoLabel.Location = New System.Drawing.Point(726, 581)
        ContatoLabel.Name = "ContatoLabel"
        ContatoLabel.Size = New System.Drawing.Size(61, 18)
        ContatoLabel.TabIndex = 129
        ContatoLabel.Text = "Contato"
        '
        'Fone_ContatoLabel
        '
        Fone_ContatoLabel.AutoSize = True
        Fone_ContatoLabel.Location = New System.Drawing.Point(832, 581)
        Fone_ContatoLabel.Name = "Fone_ContatoLabel"
        Fone_ContatoLabel.Size = New System.Drawing.Size(99, 18)
        Fone_ContatoLabel.TabIndex = 130
        Fone_ContatoLabel.Text = "Fone Contato"
        '
        'RamalLabel
        '
        RamalLabel.AutoSize = True
        RamalLabel.Location = New System.Drawing.Point(977, 581)
        RamalLabel.Name = "RamalLabel"
        RamalLabel.Size = New System.Drawing.Size(51, 18)
        RamalLabel.TabIndex = 131
        RamalLabel.Text = "Ramal"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(RamalLabel)
        Me.PnForm.Controls.Add(Me.RamalTextBox)
        Me.PnForm.Controls.Add(Fone_ContatoLabel)
        Me.PnForm.Controls.Add(Me.Fone_ContatoTextBox)
        Me.PnForm.Controls.Add(ContatoLabel)
        Me.PnForm.Controls.Add(Me.ContatoTextBox)
        Me.PnForm.Controls.Add(EmailLabel)
        Me.PnForm.Controls.Add(Me.EmailTextBox)
        Me.PnForm.Controls.Add(CelularLabel)
        Me.PnForm.Controls.Add(Me.CelularTextBox)
        Me.PnForm.Controls.Add(FaxLabel)
        Me.PnForm.Controls.Add(Me.FaxTextBox)
        Me.PnForm.Controls.Add(FoneLabel)
        Me.PnForm.Controls.Add(Me.FoneTextBox)
        Me.PnForm.Controls.Add(UFLabel)
        Me.PnForm.Controls.Add(Me.UFTextBox)
        Me.PnForm.Controls.Add(CidadeLabel)
        Me.PnForm.Controls.Add(Me.CidadeTextBox)
        Me.PnForm.Controls.Add(BairroLabel)
        Me.PnForm.Controls.Add(Me.BairroTextBox)
        Me.PnForm.Controls.Add(NumeroLabel)
        Me.PnForm.Controls.Add(Me.NumeroTextBox)
        Me.PnForm.Controls.Add(EndereçoLabel)
        Me.PnForm.Controls.Add(Me.EndereçoTextBox)
        Me.PnForm.Controls.Add(Me.Button4)
        Me.PnForm.Controls.Add(Me.GroupBox1)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.Button3)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Controls.Add(Me.DataGridView1)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(1122, 642)
        Me.PnForm.TabIndex = 86
        '
        'RamalTextBox
        '
        Me.RamalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Ramal", True))
        Me.RamalTextBox.Location = New System.Drawing.Point(980, 602)
        Me.RamalTextBox.Name = "RamalTextBox"
        Me.RamalTextBox.ReadOnly = True
        Me.RamalTextBox.Size = New System.Drawing.Size(115, 24)
        Me.RamalTextBox.TabIndex = 132
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
        'Fone_ContatoTextBox
        '
        Me.Fone_ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fone Contato", True))
        Me.Fone_ContatoTextBox.Location = New System.Drawing.Point(835, 602)
        Me.Fone_ContatoTextBox.Name = "Fone_ContatoTextBox"
        Me.Fone_ContatoTextBox.ReadOnly = True
        Me.Fone_ContatoTextBox.Size = New System.Drawing.Size(139, 24)
        Me.Fone_ContatoTextBox.TabIndex = 131
        '
        'ContatoTextBox
        '
        Me.ContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Contato", True))
        Me.ContatoTextBox.Location = New System.Drawing.Point(729, 602)
        Me.ContatoTextBox.Name = "ContatoTextBox"
        Me.ContatoTextBox.ReadOnly = True
        Me.ContatoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ContatoTextBox.TabIndex = 130
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(467, 602)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(256, 24)
        Me.EmailTextBox.TabIndex = 129
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(177, 602)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.ReadOnly = True
        Me.CelularTextBox.Size = New System.Drawing.Size(139, 24)
        Me.CelularTextBox.TabIndex = 128
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(322, 602)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.ReadOnly = True
        Me.FaxTextBox.Size = New System.Drawing.Size(139, 24)
        Me.FaxTextBox.TabIndex = 127
        '
        'FoneTextBox
        '
        Me.FoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Fone", True))
        Me.FoneTextBox.Location = New System.Drawing.Point(32, 602)
        Me.FoneTextBox.Name = "FoneTextBox"
        Me.FoneTextBox.ReadOnly = True
        Me.FoneTextBox.Size = New System.Drawing.Size(139, 24)
        Me.FoneTextBox.TabIndex = 126
        '
        'UFTextBox
        '
        Me.UFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "UF", True))
        Me.UFTextBox.Location = New System.Drawing.Point(1036, 544)
        Me.UFTextBox.Name = "UFTextBox"
        Me.UFTextBox.ReadOnly = True
        Me.UFTextBox.Size = New System.Drawing.Size(59, 24)
        Me.UFTextBox.TabIndex = 125
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(793, 544)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.ReadOnly = True
        Me.CidadeTextBox.Size = New System.Drawing.Size(237, 24)
        Me.CidadeTextBox.TabIndex = 124
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(522, 544)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.ReadOnly = True
        Me.BairroTextBox.Size = New System.Drawing.Size(265, 24)
        Me.BairroTextBox.TabIndex = 123
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(416, 544)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.ReadOnly = True
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 24)
        Me.NumeroTextBox.TabIndex = 122
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbfornecBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(32, 544)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.ReadOnly = True
        Me.EndereçoTextBox.Size = New System.Drawing.Size(378, 24)
        Me.EndereçoTextBox.TabIndex = 121
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.Error_icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(321, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 104)
        Me.Button4.TabIndex = 120
        Me.Button4.Text = "Cancelar Sair"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.LocalComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(457, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 104)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.nx_gestor.My.Resources.Resources.LocalizaIcon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(550, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 83)
        Me.Button5.TabIndex = 103
        Me.Button5.Text = "Pesquisar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbfornecBindingSource
        Me.ComboBox1.DisplayMember = "Nome/Razão Social"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(535, 26)
        Me.ComboBox1.TabIndex = 88
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(293, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(182, 22)
        Me.RadioButton3.TabIndex = 86
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Nome Fantasia/Apelido"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(184, 66)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(103, 22)
        Me.RadioButton2.TabIndex = 85
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "CPF/CNPJ"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(163, 22)
        Me.RadioButton1.TabIndex = 84
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nome/Razão Social"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(560, 42)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(54, 26)
        Me.LocalComboBox.TabIndex = 102
        Me.LocalComboBox.ValueMember = "Código"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Alterar_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(109, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "Alterar Dados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.nx_gestor.My.Resources.Resources.DeleteIcon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(215, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 104)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "Excluir Cadastro"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.NewIcon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Cadastrar Novo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.NomeRazãoSocialDataGridViewTextBoxColumn, Me.NomeFantasiaApelidoDataGridViewTextBoxColumn, Me.CPFCNPJDataGridViewTextBoxColumn, Me.RGIEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbfornecBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(3, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1114, 401)
        Me.DataGridView1.TabIndex = 100
        Me.DataGridView1.VirtualMode = True
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        Me.CódigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CódigoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CódigoDataGridViewTextBoxColumn.Width = 125
        '
        'NomeRazãoSocialDataGridViewTextBoxColumn
        '
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.DataPropertyName = "Nome/Razão Social"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.HeaderText = "Nome/Razão Social"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.MinimumWidth = 400
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.Name = "NomeRazãoSocialDataGridViewTextBoxColumn"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.Width = 400
        '
        'NomeFantasiaApelidoDataGridViewTextBoxColumn
        '
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.DataPropertyName = "Nome Fantasia/Apelido"
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia/Apelido"
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.MinimumWidth = 280
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.Name = "NomeFantasiaApelidoDataGridViewTextBoxColumn"
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NomeFantasiaApelidoDataGridViewTextBoxColumn.Width = 280
        '
        'CPFCNPJDataGridViewTextBoxColumn
        '
        Me.CPFCNPJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPF/CNPJ"
        Me.CPFCNPJDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.CPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ"
        Me.CPFCNPJDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.CPFCNPJDataGridViewTextBoxColumn.Name = "CPFCNPJDataGridViewTextBoxColumn"
        Me.CPFCNPJDataGridViewTextBoxColumn.ReadOnly = True
        Me.CPFCNPJDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CPFCNPJDataGridViewTextBoxColumn.Width = 150
        '
        'RGIEDataGridViewTextBoxColumn
        '
        Me.RGIEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RGIEDataGridViewTextBoxColumn.DataPropertyName = "RG/IE"
        Me.RGIEDataGridViewTextBoxColumn.HeaderText = "RG/IE"
        Me.RGIEDataGridViewTextBoxColumn.MinimumWidth = 80
        Me.RGIEDataGridViewTextBoxColumn.Name = "RGIEDataGridViewTextBoxColumn"
        Me.RGIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.RGIEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RGIEDataGridViewTextBoxColumn.Width = 80
        '
        'TbfornecBindingSource1
        '
        Me.TbfornecBindingSource1.DataMember = "tbfornec"
        Me.TbfornecBindingSource1.DataSource = Me.DbforncDataSetBindingSource
        '
        'DbforncDataSetBindingSource
        '
        Me.DbforncDataSetBindingSource.DataSource = Me.DbforncDataSet
        Me.DbforncDataSetBindingSource.Position = 0
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
        Me.BtnClose.Location = New System.Drawing.Point(1065, 1)
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
        Me.NameForm.Size = New System.Drawing.Size(109, 24)
        Me.NameForm.TabIndex = 87
        Me.NameForm.Text = "Fornecedores"
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
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1123, 681)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fornecedores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        CType(Me.TbfornecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbforncDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbfornecBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbforncDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DbforncDataSetBindingSource As BindingSource
    Friend WithEvents DbforncDataSet As dbforncDataSet
    Friend WithEvents TbfornecTableAdapter As dbforncDataSetTableAdapters.tbfornecTableAdapter
    Friend WithEvents LocalComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager As dbforncDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TbfornecBindingSource As BindingSource
    Friend WithEvents TbfornecBindingSource1 As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents RamalTextBox As TextBox
    Friend WithEvents Fone_ContatoTextBox As TextBox
    Friend WithEvents ContatoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents FoneTextBox As TextBox
    Friend WithEvents UFTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeRazãoSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeFantasiaApelidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPFCNPJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RGIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
