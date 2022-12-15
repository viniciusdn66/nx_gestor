<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim Sub_GrupoLabel As System.Windows.Forms.Label
        Dim SeçãoLabel As System.Windows.Forms.Label
        Dim Ultima_CompraLabel As System.Windows.Forms.Label
        Dim Margem_IdealLabel As System.Windows.Forms.Label
        Dim DescontoLabel As System.Windows.Forms.Label
        Dim Quantidade_InicialLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TdprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbprodDataSet = New nx_gestor.dbprodDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Sub_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.Quantidade_InicialTextBox = New System.Windows.Forms.TextBox()
        Me.DescontoTextBox = New System.Windows.Forms.TextBox()
        Me.SeçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Margem_IdealTextBox = New System.Windows.Forms.TextBox()
        Me.Ultima_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LocalComboBox = New System.Windows.Forms.ComboBox()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TdprodTableAdapter = New nx_gestor.dbprodDataSetTableAdapters.tdprodTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbprodDataSetTableAdapters.TableAdapterManager()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDeBarrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MargemIdealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDeVendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GrupoLabel = New System.Windows.Forms.Label()
        Sub_GrupoLabel = New System.Windows.Forms.Label()
        SeçãoLabel = New System.Windows.Forms.Label()
        Ultima_CompraLabel = New System.Windows.Forms.Label()
        Margem_IdealLabel = New System.Windows.Forms.Label()
        DescontoLabel = New System.Windows.Forms.Label()
        Quantidade_InicialLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbprodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrupoLabel.Location = New System.Drawing.Point(6, 38)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(50, 18)
        GrupoLabel.TabIndex = 84
        GrupoLabel.Text = "Grupo"
        '
        'Sub_GrupoLabel
        '
        Sub_GrupoLabel.AutoSize = True
        Sub_GrupoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sub_GrupoLabel.Location = New System.Drawing.Point(162, 38)
        Sub_GrupoLabel.Name = "Sub_GrupoLabel"
        Sub_GrupoLabel.Size = New System.Drawing.Size(81, 18)
        Sub_GrupoLabel.TabIndex = 89
        Sub_GrupoLabel.Text = "Sub-Grupo"
        '
        'SeçãoLabel
        '
        SeçãoLabel.AutoSize = True
        SeçãoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeçãoLabel.Location = New System.Drawing.Point(318, 38)
        SeçãoLabel.Name = "SeçãoLabel"
        SeçãoLabel.Size = New System.Drawing.Size(51, 18)
        SeçãoLabel.TabIndex = 90
        SeçãoLabel.Text = "Seção"
        '
        'Ultima_CompraLabel
        '
        Ultima_CompraLabel.AutoSize = True
        Ultima_CompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ultima_CompraLabel.Location = New System.Drawing.Point(630, 38)
        Ultima_CompraLabel.Name = "Ultima_CompraLabel"
        Ultima_CompraLabel.Size = New System.Drawing.Size(108, 18)
        Ultima_CompraLabel.TabIndex = 91
        Ultima_CompraLabel.Text = "Ultima Compra"
        '
        'Margem_IdealLabel
        '
        Margem_IdealLabel.AutoSize = True
        Margem_IdealLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Margem_IdealLabel.Location = New System.Drawing.Point(474, 38)
        Margem_IdealLabel.Name = "Margem_IdealLabel"
        Margem_IdealLabel.Size = New System.Drawing.Size(97, 18)
        Margem_IdealLabel.TabIndex = 92
        Margem_IdealLabel.Text = "Margem Ideal"
        '
        'DescontoLabel
        '
        DescontoLabel.AutoSize = True
        DescontoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescontoLabel.Location = New System.Drawing.Point(786, 38)
        DescontoLabel.Name = "DescontoLabel"
        DescontoLabel.Size = New System.Drawing.Size(73, 18)
        DescontoLabel.TabIndex = 93
        DescontoLabel.Text = "Desconto"
        '
        'Quantidade_InicialLabel
        '
        Quantidade_InicialLabel.AutoSize = True
        Quantidade_InicialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quantidade_InicialLabel.Location = New System.Drawing.Point(942, 38)
        Quantidade_InicialLabel.Name = "Quantidade_InicialLabel"
        Quantidade_InicialLabel.Size = New System.Drawing.Size(83, 18)
        Quantidade_InicialLabel.TabIndex = 94
        Quantidade_InicialLabel.Text = "Quantidade"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.DataGridView1)
        Me.PnForm.Controls.Add(Me.GroupBox2)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.GroupBox1)
        Me.PnForm.Controls.Add(Me.Button4)
        Me.PnForm.Controls.Add(Me.Button3)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Controls.Add(Me.LocalComboBox)
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(1067, 684)
        Me.PnForm.TabIndex = 86
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.CodigoDeBarrasDataGridViewTextBoxColumn, Me.DescriçãoDataGridViewTextBoxColumn, Me.MargemIdealDataGridViewTextBoxColumn, Me.ValorDeVendaDataGridViewTextBoxColumn, Me.QuantidadeInicialDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TdprodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 113)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 435)
        Me.DataGridView1.TabIndex = 98
        Me.DataGridView1.VirtualMode = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Sub_GrupoTextBox)
        Me.GroupBox2.Controls.Add(Quantidade_InicialLabel)
        Me.GroupBox2.Controls.Add(Me.GrupoTextBox)
        Me.GroupBox2.Controls.Add(Me.Quantidade_InicialTextBox)
        Me.GroupBox2.Controls.Add(GrupoLabel)
        Me.GroupBox2.Controls.Add(DescontoLabel)
        Me.GroupBox2.Controls.Add(Sub_GrupoLabel)
        Me.GroupBox2.Controls.Add(Me.DescontoTextBox)
        Me.GroupBox2.Controls.Add(Me.SeçãoTextBox)
        Me.GroupBox2.Controls.Add(Margem_IdealLabel)
        Me.GroupBox2.Controls.Add(SeçãoLabel)
        Me.GroupBox2.Controls.Add(Me.Margem_IdealTextBox)
        Me.GroupBox2.Controls.Add(Me.Ultima_CompraTextBox)
        Me.GroupBox2.Controls.Add(Ultima_CompraLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 554)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1059, 123)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "informações do Produto"
        '
        'Sub_GrupoTextBox
        '
        Me.Sub_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Sub-Grupo", True))
        Me.Sub_GrupoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_GrupoTextBox.Location = New System.Drawing.Point(165, 59)
        Me.Sub_GrupoTextBox.Name = "Sub_GrupoTextBox"
        Me.Sub_GrupoTextBox.ReadOnly = True
        Me.Sub_GrupoTextBox.Size = New System.Drawing.Size(150, 24)
        Me.Sub_GrupoTextBox.TabIndex = 90
        '
        'GrupoTextBox
        '
        Me.GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Grupo", True))
        Me.GrupoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoTextBox.Location = New System.Drawing.Point(9, 59)
        Me.GrupoTextBox.Name = "GrupoTextBox"
        Me.GrupoTextBox.ReadOnly = True
        Me.GrupoTextBox.Size = New System.Drawing.Size(150, 24)
        Me.GrupoTextBox.TabIndex = 85
        '
        'Quantidade_InicialTextBox
        '
        Me.Quantidade_InicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Quantidade Inicial", True))
        Me.Quantidade_InicialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantidade_InicialTextBox.Location = New System.Drawing.Point(945, 59)
        Me.Quantidade_InicialTextBox.Name = "Quantidade_InicialTextBox"
        Me.Quantidade_InicialTextBox.ReadOnly = True
        Me.Quantidade_InicialTextBox.Size = New System.Drawing.Size(108, 24)
        Me.Quantidade_InicialTextBox.TabIndex = 95
        '
        'DescontoTextBox
        '
        Me.DescontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Desconto", True))
        Me.DescontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescontoTextBox.Location = New System.Drawing.Point(789, 59)
        Me.DescontoTextBox.Name = "DescontoTextBox"
        Me.DescontoTextBox.ReadOnly = True
        Me.DescontoTextBox.Size = New System.Drawing.Size(150, 24)
        Me.DescontoTextBox.TabIndex = 94
        '
        'SeçãoTextBox
        '
        Me.SeçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Seção", True))
        Me.SeçãoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeçãoTextBox.Location = New System.Drawing.Point(321, 59)
        Me.SeçãoTextBox.Name = "SeçãoTextBox"
        Me.SeçãoTextBox.ReadOnly = True
        Me.SeçãoTextBox.Size = New System.Drawing.Size(150, 24)
        Me.SeçãoTextBox.TabIndex = 91
        '
        'Margem_IdealTextBox
        '
        Me.Margem_IdealTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Margem Ideal", True))
        Me.Margem_IdealTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margem_IdealTextBox.Location = New System.Drawing.Point(477, 59)
        Me.Margem_IdealTextBox.Name = "Margem_IdealTextBox"
        Me.Margem_IdealTextBox.ReadOnly = True
        Me.Margem_IdealTextBox.Size = New System.Drawing.Size(150, 24)
        Me.Margem_IdealTextBox.TabIndex = 93
        '
        'Ultima_CompraTextBox
        '
        Me.Ultima_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TdprodBindingSource, "Ultima Compra", True))
        Me.Ultima_CompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ultima_CompraTextBox.Location = New System.Drawing.Point(633, 59)
        Me.Ultima_CompraTextBox.Name = "Ultima_CompraTextBox"
        Me.Ultima_CompraTextBox.ReadOnly = True
        Me.Ultima_CompraTextBox.Size = New System.Drawing.Size(150, 24)
        Me.Ultima_CompraTextBox.TabIndex = 92
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Alterar_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(118, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Alterar Dados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(436, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 104)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TdprodBindingSource
        Me.ComboBox1.DisplayMember = "Descrição"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(497, 26)
        Me.ComboBox1.TabIndex = 88
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(269, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(134, 22)
        Me.RadioButton3.TabIndex = 86
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Código Balança"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(118, 66)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(145, 22)
        Me.RadioButton2.TabIndex = 85
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Código de Barras"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 22)
        Me.RadioButton1.TabIndex = 84
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descrição"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.nx_gestor.My.Resources.Resources.LocalizaIcon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(514, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 83)
        Me.Button5.TabIndex = 83
        Me.Button5.Text = "Pesquisar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.Error_icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(330, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 104)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Cancelar Sair"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.nx_gestor.My.Resources.Resources.DeleteIcon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(224, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 104)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Excluir Cadastro"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.NewIcon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Cadastrar Novo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LocalComboBox
        '
        Me.LocalComboBox.DataSource = Me.TdprodBindingSource
        Me.LocalComboBox.DisplayMember = "Código"
        Me.LocalComboBox.FormattingEnabled = True
        Me.LocalComboBox.Location = New System.Drawing.Point(961, 35)
        Me.LocalComboBox.Name = "LocalComboBox"
        Me.LocalComboBox.Size = New System.Drawing.Size(67, 24)
        Me.LocalComboBox.TabIndex = 99
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
        Me.NameForm.Size = New System.Drawing.Size(75, 24)
        Me.NameForm.TabIndex = 87
        Me.NameForm.Text = "Produtos"
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
        Me.BtnClose.Location = New System.Drawing.Point(1010, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 88
        Me.BtnClose.UseVisualStyleBackColor = False
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
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Frozen = True
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.MinimumWidth = 70
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        Me.CódigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CódigoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CódigoDataGridViewTextBoxColumn.Width = 70
        '
        'CodigoDeBarrasDataGridViewTextBoxColumn
        '
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Barras"
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.Frozen = True
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "Codigo de Barras"
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.Name = "CodigoDeBarrasDataGridViewTextBoxColumn"
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CodigoDeBarrasDataGridViewTextBoxColumn.Width = 150
        '
        'DescriçãoDataGridViewTextBoxColumn
        '
        Me.DescriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição"
        Me.DescriçãoDataGridViewTextBoxColumn.Frozen = True
        Me.DescriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DescriçãoDataGridViewTextBoxColumn.MinimumWidth = 440
        Me.DescriçãoDataGridViewTextBoxColumn.Name = "DescriçãoDataGridViewTextBoxColumn"
        Me.DescriçãoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriçãoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescriçãoDataGridViewTextBoxColumn.Width = 440
        '
        'MargemIdealDataGridViewTextBoxColumn
        '
        Me.MargemIdealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MargemIdealDataGridViewTextBoxColumn.DataPropertyName = "Margem Ideal"
        Me.MargemIdealDataGridViewTextBoxColumn.Frozen = True
        Me.MargemIdealDataGridViewTextBoxColumn.HeaderText = "Margem Ideal"
        Me.MargemIdealDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.MargemIdealDataGridViewTextBoxColumn.Name = "MargemIdealDataGridViewTextBoxColumn"
        Me.MargemIdealDataGridViewTextBoxColumn.ReadOnly = True
        Me.MargemIdealDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ValorDeVendaDataGridViewTextBoxColumn
        '
        Me.ValorDeVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ValorDeVendaDataGridViewTextBoxColumn.DataPropertyName = "Valor de venda"
        Me.ValorDeVendaDataGridViewTextBoxColumn.Frozen = True
        Me.ValorDeVendaDataGridViewTextBoxColumn.HeaderText = "Valor/Venda"
        Me.ValorDeVendaDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.ValorDeVendaDataGridViewTextBoxColumn.Name = "ValorDeVendaDataGridViewTextBoxColumn"
        Me.ValorDeVendaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorDeVendaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'QuantidadeInicialDataGridViewTextBoxColumn
        '
        Me.QuantidadeInicialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.QuantidadeInicialDataGridViewTextBoxColumn.DataPropertyName = "Quantidade Inicial"
        Me.QuantidadeInicialDataGridViewTextBoxColumn.Frozen = True
        Me.QuantidadeInicialDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeInicialDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.QuantidadeInicialDataGridViewTextBoxColumn.Name = "QuantidadeInicialDataGridViewTextBoxColumn"
        Me.QuantidadeInicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantidadeInicialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1068, 723)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produtos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbprodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DbprodDataSet As dbprodDataSet
    Friend WithEvents TdprodBindingSource As BindingSource
    Friend WithEvents TdprodTableAdapter As dbprodDataSetTableAdapters.tdprodTableAdapter
    Friend WithEvents TableAdapterManager As dbprodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sub_GrupoTextBox As TextBox
    Friend WithEvents GrupoTextBox As TextBox
    Friend WithEvents Quantidade_InicialTextBox As TextBox
    Friend WithEvents DescontoTextBox As TextBox
    Friend WithEvents SeçãoTextBox As TextBox
    Friend WithEvents Margem_IdealTextBox As TextBox
    Friend WithEvents Ultima_CompraTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LocalComboBox As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDeBarrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MargemIdealDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDeVendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeInicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
