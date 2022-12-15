<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSetings
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
        Dim LoginLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim AtivoLabel As System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AtivoComboBox = New System.Windows.Forms.ComboBox()
        Me.TbusrdtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsrdtDataSet = New nx_gestor.usrdtDataSet()
        Me.Tipo_de_UsuárioLabel1 = New System.Windows.Forms.Label()
        Me.LoginLabel1 = New System.Windows.Forms.Label()
        Me.NomeLabel1 = New System.Windows.Forms.Label()
        Me.E_mailLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTASSUNTO = New System.Windows.Forms.TextBox()
        Me.TXTMESSAGE = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TXTDESTINO = New System.Windows.Forms.TextBox()
        Me.TbusrdtTableAdapter = New nx_gestor.usrdtDataSetTableAdapters.tbusrdtTableAdapter()
        Me.TableAdapterManager = New nx_gestor.usrdtDataSetTableAdapters.TableAdapterManager()
        LoginLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        AtivoLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Location = New System.Drawing.Point(211, 26)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(112, 20)
        LoginLabel.TabIndex = 84
        LoginLabel.Text = "Logado para: "
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(356, 192)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(216, 20)
        E_mailLabel.TabIndex = 88
        E_mailLabel.Text = "Seu e-mail de Recuperação"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(213, 55)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(61, 20)
        SenhaLabel.TabIndex = 90
        SenhaLabel.Text = "Senha:"
        '
        'AtivoLabel
        '
        AtivoLabel.AutoSize = True
        AtivoLabel.Location = New System.Drawing.Point(551, 38)
        AtivoLabel.Name = "AtivoLabel"
        AtivoLabel.Size = New System.Drawing.Size(118, 40)
        AtivoLabel.TabIndex = 98
        AtivoLabel.Text = " Modo de Cor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Experimental)"
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
        Me.BtnClose.Location = New System.Drawing.Point(863, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 69
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'NameForm
        '
        Me.NameForm.AutoSize = True
        Me.NameForm.BackColor = System.Drawing.Color.Transparent
        Me.NameForm.Enabled = False
        Me.NameForm.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameForm.ForeColor = System.Drawing.Color.White
        Me.NameForm.Location = New System.Drawing.Point(13, 8)
        Me.NameForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameForm.Name = "NameForm"
        Me.NameForm.Size = New System.Drawing.Size(166, 24)
        Me.NameForm.TabIndex = 68
        Me.NameForm.Text = "Configurações Gerais"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.TabControl1)
        Me.PnForm.Location = New System.Drawing.Point(0, 39)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(921, 525)
        Me.PnForm.TabIndex = 70
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(919, 523)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.PictureBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(911, 487)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Informações Adicionais"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 146)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status da Ativação"
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button6.Image = Global.nx_gestor.My.Resources.Resources.ProIcon
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(361, 36)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(208, 81)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Ativar versão PRO"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "txt"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button5.Image = Global.nx_gestor.My.Resources.Resources.BuyIcon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(255, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 81)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Comprar Licença"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(898, 181)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações de Hardware"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "text"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "text"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "text"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 136)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações de Software"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "text"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.nx_gestor.My.Resources.Resources.Logo_img
        Me.PictureBox2.Location = New System.Drawing.Point(-15, -43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(337, 251)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(AtivoLabel)
        Me.TabPage2.Controls.Add(Me.AtivoComboBox)
        Me.TabPage2.Controls.Add(Me.Tipo_de_UsuárioLabel1)
        Me.TabPage2.Controls.Add(LoginLabel)
        Me.TabPage2.Controls.Add(Me.LoginLabel1)
        Me.TabPage2.Controls.Add(Me.NomeLabel1)
        Me.TabPage2.Controls.Add(E_mailLabel)
        Me.TabPage2.Controls.Add(Me.E_mailLinkLabel)
        Me.TabPage2.Controls.Add(SenhaLabel)
        Me.TabPage2.Controls.Add(Me.SenhaTextBox)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(911, 487)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Usuários e senhas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(407, 55)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 102
        Me.Button8.Text = "Alterar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Image = Global.nx_gestor.My.Resources.Resources.SecurityIcon
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(299, 378)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 104)
        Me.Button7.TabIndex = 101
        Me.Button7.Text = "Restaurar Senha"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(802, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Alterar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AtivoComboBox
        '
        Me.AtivoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Ativo", True))
        Me.AtivoComboBox.FormattingEnabled = True
        Me.AtivoComboBox.Items.AddRange(New Object() {"Claro", "Escuro"})
        Me.AtivoComboBox.Location = New System.Drawing.Point(675, 47)
        Me.AtivoComboBox.Name = "AtivoComboBox"
        Me.AtivoComboBox.Size = New System.Drawing.Size(121, 28)
        Me.AtivoComboBox.TabIndex = 99
        '
        'TbusrdtBindingSource
        '
        Me.TbusrdtBindingSource.DataMember = "tbusrdt"
        Me.TbusrdtBindingSource.DataSource = Me.UsrdtDataSet
        '
        'UsrdtDataSet
        '
        Me.UsrdtDataSet.DataSetName = "usrdtDataSet"
        Me.UsrdtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipo_de_UsuárioLabel1
        '
        Me.Tipo_de_UsuárioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Tipo de Usuário", True))
        Me.Tipo_de_UsuárioLabel1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Tipo_de_UsuárioLabel1.Location = New System.Drawing.Point(23, 245)
        Me.Tipo_de_UsuárioLabel1.Name = "Tipo_de_UsuárioLabel1"
        Me.Tipo_de_UsuárioLabel1.Size = New System.Drawing.Size(175, 23)
        Me.Tipo_de_UsuárioLabel1.TabIndex = 98
        Me.Tipo_de_UsuárioLabel1.Text = "Label1"
        Me.Tipo_de_UsuárioLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginLabel1
        '
        Me.LoginLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Login", True))
        Me.LoginLabel1.Location = New System.Drawing.Point(329, 26)
        Me.LoginLabel1.Name = "LoginLabel1"
        Me.LoginLabel1.Size = New System.Drawing.Size(140, 23)
        Me.LoginLabel1.TabIndex = 85
        Me.LoginLabel1.Text = "Label1"
        '
        'NomeLabel1
        '
        Me.NomeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Nome", True))
        Me.NomeLabel1.Location = New System.Drawing.Point(23, 205)
        Me.NomeLabel1.Name = "NomeLabel1"
        Me.NomeLabel1.Size = New System.Drawing.Size(179, 54)
        Me.NomeLabel1.TabIndex = 87
        Me.NomeLabel1.Text = "Label1"
        Me.NomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'E_mailLinkLabel
        '
        Me.E_mailLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "E-mail", True))
        Me.E_mailLinkLabel.Location = New System.Drawing.Point(272, 212)
        Me.E_mailLinkLabel.Name = "E_mailLinkLabel"
        Me.E_mailLinkLabel.Size = New System.Drawing.Size(380, 23)
        Me.E_mailLinkLabel.TabIndex = 89
        Me.E_mailLinkLabel.TabStop = True
        Me.E_mailLinkLabel.Text = "LinkLabel1"
        Me.E_mailLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(280, 52)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.ReadOnly = True
        Me.SenhaTextBox.Size = New System.Drawing.Size(121, 27)
        Me.SenhaTextBox.TabIndex = 91
        Me.SenhaTextBox.UseSystemPasswordChar = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataSource = Me.TbusrdtBindingSource
        Me.ComboBox1.DisplayMember = "ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 452)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 28)
        Me.ComboBox1.TabIndex = 82
        Me.ComboBox1.ValueMember = "ID"
        Me.ComboBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.nx_gestor.My.Resources.Resources.User_img
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 176)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Alterar_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(405, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Alterar Dados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.AddNewUserIcon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(511, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Novo Usuário"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.TXTDESTINO)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(911, 487)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Relatar Erros"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TXTASSUNTO)
        Me.GroupBox4.Controls.Add(Me.TXTMESSAGE)
        Me.GroupBox4.Controls.Add(Me.LinkLabel1)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(902, 477)
        Me.GroupBox4.TabIndex = 93
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Erro/Bug"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.Enviar_icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(795, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 104)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Enviar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 24)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Relate ou sugira melhorias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 436)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 24)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Contacte-nos para orçamentos"
        '
        'TXTASSUNTO
        '
        Me.TXTASSUNTO.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTASSUNTO.Location = New System.Drawing.Point(12, 51)
        Me.TXTASSUNTO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTASSUNTO.Name = "TXTASSUNTO"
        Me.TXTASSUNTO.Size = New System.Drawing.Size(776, 30)
        Me.TXTASSUNTO.TabIndex = 1
        '
        'TXTMESSAGE
        '
        Me.TXTMESSAGE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMESSAGE.Location = New System.Drawing.Point(7, 127)
        Me.TXTMESSAGE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTMESSAGE.Multiline = True
        Me.TXTMESSAGE.Name = "TXTMESSAGE"
        Me.TXTMESSAGE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTMESSAGE.Size = New System.Drawing.Size(888, 305)
        Me.TXTMESSAGE.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(249, 436)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(223, 24)
        Me.LinkLabel1.TabIndex = 91
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "developersmaint@gmail.com"
        '
        'TXTDESTINO
        '
        Me.TXTDESTINO.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESTINO.Location = New System.Drawing.Point(758, 16)
        Me.TXTDESTINO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTDESTINO.Name = "TXTDESTINO"
        Me.TXTDESTINO.Size = New System.Drawing.Size(132, 30)
        Me.TXTDESTINO.TabIndex = 0
        Me.TXTDESTINO.Text = "vinicius.daniel179@gmail.com"
        Me.TXTDESTINO.Visible = False
        '
        'TbusrdtTableAdapter
        '
        Me.TbusrdtTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbusrdtTableAdapter = Me.TbusrdtTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.usrdtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserSetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(921, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.Controls.Add(Me.PnForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserSetings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserSetings"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents PnForm As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents UsrdtDataSet As usrdtDataSet
    Friend WithEvents TbusrdtBindingSource As BindingSource
    Friend WithEvents TbusrdtTableAdapter As usrdtDataSetTableAdapters.tbusrdtTableAdapter
    Friend WithEvents TableAdapterManager As usrdtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LoginLabel1 As Label
    Friend WithEvents NomeLabel1 As Label
    Friend WithEvents E_mailLinkLabel As LinkLabel
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Tipo_de_UsuárioLabel1 As Label
    Friend WithEvents AtivoComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TXTMESSAGE As TextBox
    Friend WithEvents TXTDESTINO As TextBox
    Friend WithEvents TXTASSUNTO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button8 As Button
End Class
