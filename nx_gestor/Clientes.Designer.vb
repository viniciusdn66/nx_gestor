<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim FoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.TbclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbclientDataSet = New nx_gestor.dbclientDataSet()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.FoneTextBox = New System.Windows.Forms.TextBox()
        Me.UFTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeRazãoSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFantasiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFCNPJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPessoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TbclientTableAdapter = New nx_gestor.dbclientDataSetTableAdapters.tbclientTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbclientDataSetTableAdapters.TableAdapterManager()
        EndereçoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        FoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TbclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbclientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(12, 504)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(72, 18)
        EndereçoLabel.TabIndex = 99
        EndereçoLabel.Text = "Endereço"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(361, 502)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(62, 18)
        NumeroLabel.TabIndex = 100
        NumeroLabel.Text = "Numero"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(467, 502)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(48, 18)
        BairroLabel.TabIndex = 101
        BairroLabel.Text = "Bairro"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(688, 502)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(102, 18)
        ComplementoLabel.TabIndex = 102
        ComplementoLabel.Text = "Complemento"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(810, 502)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(54, 18)
        CidadeLabel.TabIndex = 103
        CidadeLabel.Text = "Cidade"
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(1085, 504)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(28, 18)
        UFLabel.TabIndex = 104
        UFLabel.Text = "UF"
        '
        'FoneLabel
        '
        FoneLabel.AutoSize = True
        FoneLabel.Location = New System.Drawing.Point(12, 550)
        FoneLabel.Name = "FoneLabel"
        FoneLabel.Size = New System.Drawing.Size(42, 18)
        FoneLabel.TabIndex = 105
        FoneLabel.Text = "Fone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(118, 550)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(32, 18)
        FaxLabel.TabIndex = 106
        FaxLabel.Text = "Fax"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(224, 550)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(54, 18)
        CelularLabel.TabIndex = 107
        CelularLabel.Text = "Celular"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(330, 550)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(50, 18)
        E_mailLabel.TabIndex = 108
        E_mailLabel.Text = "E-mail"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(E_mailLabel)
        Me.PnForm.Controls.Add(Me.E_mailTextBox)
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
        Me.PnForm.Controls.Add(ComplementoLabel)
        Me.PnForm.Controls.Add(Me.ComplementoTextBox)
        Me.PnForm.Controls.Add(BairroLabel)
        Me.PnForm.Controls.Add(Me.BairroTextBox)
        Me.PnForm.Controls.Add(NumeroLabel)
        Me.PnForm.Controls.Add(Me.NumeroTextBox)
        Me.PnForm.Controls.Add(EndereçoLabel)
        Me.PnForm.Controls.Add(Me.EndereçoTextBox)
        Me.PnForm.Controls.Add(Me.DataGridView1)
        Me.PnForm.Controls.Add(Me.GroupBox1)
        Me.PnForm.Controls.Add(Me.Button5)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.Button4)
        Me.PnForm.Controls.Add(Me.Button3)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(1160, 612)
        Me.PnForm.TabIndex = 83
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(333, 571)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.ReadOnly = True
        Me.E_mailTextBox.Size = New System.Drawing.Size(320, 24)
        Me.E_mailTextBox.TabIndex = 109
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
        Me.CelularTextBox.Location = New System.Drawing.Point(227, 571)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.ReadOnly = True
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 24)
        Me.CelularTextBox.TabIndex = 108
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(121, 571)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.ReadOnly = True
        Me.FaxTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FaxTextBox.TabIndex = 107
        '
        'FoneTextBox
        '
        Me.FoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Fone", True))
        Me.FoneTextBox.Location = New System.Drawing.Point(15, 571)
        Me.FoneTextBox.Name = "FoneTextBox"
        Me.FoneTextBox.ReadOnly = True
        Me.FoneTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FoneTextBox.TabIndex = 106
        '
        'UFTextBox
        '
        Me.UFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "UF", True))
        Me.UFTextBox.Location = New System.Drawing.Point(1088, 523)
        Me.UFTextBox.Name = "UFTextBox"
        Me.UFTextBox.ReadOnly = True
        Me.UFTextBox.Size = New System.Drawing.Size(52, 24)
        Me.UFTextBox.TabIndex = 105
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(813, 523)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.ReadOnly = True
        Me.CidadeTextBox.Size = New System.Drawing.Size(269, 24)
        Me.CidadeTextBox.TabIndex = 104
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(694, 523)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.ReadOnly = True
        Me.ComplementoTextBox.Size = New System.Drawing.Size(113, 24)
        Me.ComplementoTextBox.TabIndex = 103
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(470, 523)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.ReadOnly = True
        Me.BairroTextBox.Size = New System.Drawing.Size(218, 24)
        Me.BairroTextBox.TabIndex = 102
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(364, 523)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.ReadOnly = True
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 24)
        Me.NumeroTextBox.TabIndex = 101
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(15, 523)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.ReadOnly = True
        Me.EndereçoTextBox.Size = New System.Drawing.Size(343, 24)
        Me.EndereçoTextBox.TabIndex = 100
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.NomeRazãoSocialDataGridViewTextBoxColumn, Me.NomeFantasiaDataGridViewTextBoxColumn, Me.CPFCNPJDataGridViewTextBoxColumn, Me.TipoPessoaDataGridViewTextBoxColumn, Me.LimiteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbclientBindingSource
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
        Me.DataGridView1.Size = New System.Drawing.Size(1150, 379)
        Me.DataGridView1.TabIndex = 99
        Me.DataGridView1.VirtualMode = True
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.MinimumWidth = 80
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        Me.CódigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CódigoDataGridViewTextBoxColumn.Width = 80
        '
        'NomeRazãoSocialDataGridViewTextBoxColumn
        '
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.DataPropertyName = "Nome/Razão Social"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.HeaderText = "Nome/Razão Social"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.MinimumWidth = 400
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.Name = "NomeRazãoSocialDataGridViewTextBoxColumn"
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeRazãoSocialDataGridViewTextBoxColumn.Width = 400
        '
        'NomeFantasiaDataGridViewTextBoxColumn
        '
        Me.NomeFantasiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Nome Fantasia"
        Me.NomeFantasiaDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia"
        Me.NomeFantasiaDataGridViewTextBoxColumn.MinimumWidth = 240
        Me.NomeFantasiaDataGridViewTextBoxColumn.Name = "NomeFantasiaDataGridViewTextBoxColumn"
        Me.NomeFantasiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeFantasiaDataGridViewTextBoxColumn.Width = 240
        '
        'CPFCNPJDataGridViewTextBoxColumn
        '
        Me.CPFCNPJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPF/CNPJ"
        Me.CPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ"
        Me.CPFCNPJDataGridViewTextBoxColumn.MinimumWidth = 130
        Me.CPFCNPJDataGridViewTextBoxColumn.Name = "CPFCNPJDataGridViewTextBoxColumn"
        Me.CPFCNPJDataGridViewTextBoxColumn.ReadOnly = True
        Me.CPFCNPJDataGridViewTextBoxColumn.Width = 130
        '
        'TipoPessoaDataGridViewTextBoxColumn
        '
        Me.TipoPessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TipoPessoaDataGridViewTextBoxColumn.DataPropertyName = "Tipo Pessoa"
        Me.TipoPessoaDataGridViewTextBoxColumn.HeaderText = "Tipo Pessoa"
        Me.TipoPessoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoPessoaDataGridViewTextBoxColumn.Name = "TipoPessoaDataGridViewTextBoxColumn"
        Me.TipoPessoaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoPessoaDataGridViewTextBoxColumn.Width = 125
        '
        'LimiteDataGridViewTextBoxColumn
        '
        Me.LimiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LimiteDataGridViewTextBoxColumn.DataPropertyName = "Limite"
        Me.LimiteDataGridViewTextBoxColumn.HeaderText = "Limite"
        Me.LimiteDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.LimiteDataGridViewTextBoxColumn.Name = "LimiteDataGridViewTextBoxColumn"
        Me.LimiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimiteDataGridViewTextBoxColumn.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.LocalComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(533, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 104)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbclientBindingSource
        Me.ComboBox1.DisplayMember = "Nome/Razão Social"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(497, 26)
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
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.nx_gestor.My.Resources.Resources.LocalizaIcon
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(514, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 83)
        Me.Button6.TabIndex = 83
        Me.Button6.Text = "Pesquisar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DataSource = Me.TbclientBindingSource
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(530, 43)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(67, 26)
        Me.LocalComboBox.TabIndex = 102
        Me.LocalComboBox.ValueMember = "Código"
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.nx_gestor.My.Resources.Resources.Error_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(427, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 104)
        Me.Button5.TabIndex = 89
        Me.Button5.Text = "Cancelar Sair"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
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
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Alterar Dados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.PayIcon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(321, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 104)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "Contas a Pagar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.Button3.TabIndex = 86
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
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Cadastrar Novo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.BtnClose.Location = New System.Drawing.Point(1103, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 85
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
        Me.NameForm.Size = New System.Drawing.Size(68, 24)
        Me.NameForm.TabIndex = 84
        Me.NameForm.Text = "Clientes"
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1161, 651)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        CType(Me.TbclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbclientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DbclientDataSet As dbclientDataSet
    Friend WithEvents TbclientBindingSource As BindingSource
    Friend WithEvents TbclientTableAdapter As dbclientDataSetTableAdapters.tbclientTableAdapter
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents FoneTextBox As TextBox
    Friend WithEvents UFTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeRazãoSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeFantasiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPFCNPJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoPessoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As dbclientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalComboBox As ComboBox
End Class
