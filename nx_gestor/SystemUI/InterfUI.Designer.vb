<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfUI
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim AtivoLabel As System.Windows.Forms.Label
        Dim Tipo_de_UsuárioLabel As System.Windows.Forms.Label
        Dim Dica_para_SenhaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfUI))
        Me.PnLogin = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfLogin = New System.Windows.Forms.Label()
        Me.USERTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.InfSys = New System.Windows.Forms.Label()
        Me.UsrdtDataSet = New nx_gestor.usrdtDataSet()
        Me.TbusrdtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbusrdtTableAdapter = New nx_gestor.usrdtDataSetTableAdapters.tbusrdtTableAdapter()
        Me.TableAdapterManager = New nx_gestor.usrdtDataSetTableAdapters.TableAdapterManager()
        Me.TbusrdtBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbusrdtBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.AtivoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_UsuárioTextBox = New System.Windows.Forms.TextBox()
        Me.Dica_para_SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.UsrStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PnIntiUI = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PNInterfU = New System.Windows.Forms.Panel()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnUserSec = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnRelatar_erro = New System.Windows.Forms.Button()
        Me.btnVendas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnFornecedores = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LicenseDataSet = New nx_gestor.LicenseDataSet()
        Me.TblicenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblicenseTableAdapter = New nx_gestor.LicenseDataSetTableAdapters.tblicenseTableAdapter()
        Me.TableAdapterManager1 = New nx_gestor.LicenseDataSetTableAdapters.TableAdapterManager()
        Me.ChaveTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_CompletoTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        AtivoLabel = New System.Windows.Forms.Label()
        Tipo_de_UsuárioLabel = New System.Windows.Forms.Label()
        Dica_para_SenhaLabel = New System.Windows.Forms.Label()
        Me.PnLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbusrdtBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbusrdtBindingNavigator.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PnIntiUI.SuspendLayout()
        Me.PNInterfU.SuspendLayout()
        CType(Me.LicenseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblicenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(94, 465)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(23, 16)
        IDLabel.TabIndex = 24
        IDLabel.Text = "ID:"
        '
        'LoginLabel
        '
        LoginLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        LoginLabel.AutoSize = True
        LoginLabel.Location = New System.Drawing.Point(229, 465)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(43, 16)
        LoginLabel.TabIndex = 26
        LoginLabel.Text = "Login:"
        '
        'NomeLabel
        '
        NomeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(401, 465)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(47, 16)
        NomeLabel.TabIndex = 28
        NomeLabel.Text = "Nome:"
        '
        'E_mailLabel
        '
        E_mailLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(70, 493)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(48, 16)
        E_mailLabel.TabIndex = 30
        E_mailLabel.Text = "E-mail:"
        '
        'SenhaLabel
        '
        SenhaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(229, 496)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(49, 16)
        SenhaLabel.TabIndex = 32
        SenhaLabel.Text = "Senha:"
        '
        'AtivoLabel
        '
        AtivoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        AtivoLabel.AutoSize = True
        AtivoLabel.Location = New System.Drawing.Point(399, 496)
        AtivoLabel.Name = "AtivoLabel"
        AtivoLabel.Size = New System.Drawing.Size(46, 16)
        AtivoLabel.TabIndex = 34
        AtivoLabel.Text = "Tema:"
        '
        'Tipo_de_UsuárioLabel
        '
        Tipo_de_UsuárioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Tipo_de_UsuárioLabel.AutoSize = True
        Tipo_de_UsuárioLabel.Location = New System.Drawing.Point(6, 521)
        Tipo_de_UsuárioLabel.Name = "Tipo_de_UsuárioLabel"
        Tipo_de_UsuárioLabel.Size = New System.Drawing.Size(107, 16)
        Tipo_de_UsuárioLabel.TabIndex = 36
        Tipo_de_UsuárioLabel.Text = "Tipo de Usuário:"
        '
        'Dica_para_SenhaLabel
        '
        Dica_para_SenhaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Dica_para_SenhaLabel.AutoSize = True
        Dica_para_SenhaLabel.Location = New System.Drawing.Point(337, 524)
        Dica_para_SenhaLabel.Name = "Dica_para_SenhaLabel"
        Dica_para_SenhaLabel.Size = New System.Drawing.Size(111, 16)
        Dica_para_SenhaLabel.TabIndex = 38
        Dica_para_SenhaLabel.Text = "Dica para Senha:"
        '
        'PnLogin
        '
        Me.PnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PnLogin.BackgroundImage = Global.nx_gestor.My.Resources.Resources.Background
        Me.PnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnLogin.Controls.Add(Me.Label3)
        Me.PnLogin.Controls.Add(Me.Button2)
        Me.PnLogin.Controls.Add(Me.Label2)
        Me.PnLogin.Controls.Add(Me.Label1)
        Me.PnLogin.Controls.Add(Me.InfLogin)
        Me.PnLogin.Controls.Add(Me.USERTextBox)
        Me.PnLogin.Controls.Add(Me.Button1)
        Me.PnLogin.Controls.Add(Me.PASSWORDTextBox)
        Me.PnLogin.Controls.Add(Me.PictureBox1)
        Me.PnLogin.Controls.Add(Me.PictureBox2)
        Me.PnLogin.Controls.Add(Me.InfSys)
        Me.PnLogin.Location = New System.Drawing.Point(0, -6)
        Me.PnLogin.Name = "PnLogin"
        Me.PnLogin.Size = New System.Drawing.Size(1320, 617)
        Me.PnLogin.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.SecurityIcon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(773, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 78)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Recovery"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Usuário"
        '
        'InfLogin
        '
        Me.InfLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InfLogin.BackColor = System.Drawing.Color.Transparent
        Me.InfLogin.ForeColor = System.Drawing.Color.Red
        Me.InfLogin.Location = New System.Drawing.Point(476, 410)
        Me.InfLogin.Name = "InfLogin"
        Me.InfLogin.Size = New System.Drawing.Size(210, 23)
        Me.InfLogin.TabIndex = 24
        Me.InfLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'USERTextBox
        '
        Me.USERTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.USERTextBox.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERTextBox.Location = New System.Drawing.Point(476, 328)
        Me.USERTextBox.Name = "USERTextBox"
        Me.USERTextBox.Size = New System.Drawing.Size(210, 27)
        Me.USERTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.nx_gestor.My.Resources.Resources.Start_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(692, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 78)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PASSWORDTextBox
        '
        Me.PASSWORDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PASSWORDTextBox.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORDTextBox.Location = New System.Drawing.Point(476, 380)
        Me.PASSWORDTextBox.Name = "PASSWORDTextBox"
        Me.PASSWORDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PASSWORDTextBox.Size = New System.Drawing.Size(210, 27)
        Me.PASSWORDTextBox.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.nx_gestor.My.Resources.Resources.Loading
        Me.PictureBox1.Location = New System.Drawing.Point(609, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.nx_gestor.My.Resources.Resources.Logo_img
        Me.PictureBox2.Location = New System.Drawing.Point(439, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(439, 267)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'InfSys
        '
        Me.InfSys.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfSys.BackColor = System.Drawing.Color.Transparent
        Me.InfSys.Location = New System.Drawing.Point(12, 585)
        Me.InfSys.Name = "InfSys"
        Me.InfSys.Size = New System.Drawing.Size(210, 23)
        Me.InfSys.TabIndex = 22
        Me.InfSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsrdtDataSet
        '
        Me.UsrdtDataSet.DataSetName = "usrdtDataSet"
        Me.UsrdtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbusrdtBindingSource
        '
        Me.TbusrdtBindingSource.DataMember = "tbusrdt"
        Me.TbusrdtBindingSource.DataSource = Me.UsrdtDataSet
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
        'TbusrdtBindingNavigator
        '
        Me.TbusrdtBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbusrdtBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TbusrdtBindingNavigator.BindingSource = Me.TbusrdtBindingSource
        Me.TbusrdtBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbusrdtBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbusrdtBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TbusrdtBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TbusrdtBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbusrdtBindingNavigatorSaveItem})
        Me.TbusrdtBindingNavigator.Location = New System.Drawing.Point(511, 546)
        Me.TbusrdtBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbusrdtBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbusrdtBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbusrdtBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbusrdtBindingNavigator.Name = "TbusrdtBindingNavigator"
        Me.TbusrdtBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbusrdtBindingNavigator.Size = New System.Drawing.Size(334, 27)
        Me.TbusrdtBindingNavigator.TabIndex = 24
        Me.TbusrdtBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TbusrdtBindingNavigatorSaveItem
        '
        Me.TbusrdtBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbusrdtBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbusrdtBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbusrdtBindingNavigatorSaveItem.Name = "TbusrdtBindingNavigatorSaveItem"
        Me.TbusrdtBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TbusrdtBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(123, 462)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 25
        '
        'LoginTextBox
        '
        Me.LoginTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Login", True))
        Me.LoginTextBox.Location = New System.Drawing.Point(282, 462)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LoginTextBox.TabIndex = 27
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(454, 462)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NomeTextBox.TabIndex = 29
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(123, 490)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.E_mailTextBox.TabIndex = 31
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(282, 493)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SenhaTextBox.TabIndex = 33
        '
        'AtivoTextBox
        '
        Me.AtivoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AtivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Ativo", True))
        Me.AtivoTextBox.Location = New System.Drawing.Point(454, 493)
        Me.AtivoTextBox.Name = "AtivoTextBox"
        Me.AtivoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AtivoTextBox.TabIndex = 35
        '
        'Tipo_de_UsuárioTextBox
        '
        Me.Tipo_de_UsuárioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tipo_de_UsuárioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Tipo de Usuário", True))
        Me.Tipo_de_UsuárioTextBox.Location = New System.Drawing.Point(123, 518)
        Me.Tipo_de_UsuárioTextBox.Name = "Tipo_de_UsuárioTextBox"
        Me.Tipo_de_UsuárioTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Tipo_de_UsuárioTextBox.TabIndex = 37
        '
        'Dica_para_SenhaTextBox
        '
        Me.Dica_para_SenhaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Dica_para_SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Dica para Senha", True))
        Me.Dica_para_SenhaTextBox.Location = New System.Drawing.Point(454, 521)
        Me.Dica_para_SenhaTextBox.Name = "Dica_para_SenhaTextBox"
        Me.Dica_para_SenhaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Dica_para_SenhaTextBox.TabIndex = 39
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsrStrip, Me.DateStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1320, 26)
        Me.StatusStrip1.TabIndex = 41
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'UsrStrip
        '
        Me.UsrStrip.Name = "UsrStrip"
        Me.UsrStrip.Size = New System.Drawing.Size(130, 20)
        Me.UsrStrip.Text = "Logado em: nome"
        '
        'DateStrip
        '
        Me.DateStrip.Name = "DateStrip"
        Me.DateStrip.Size = New System.Drawing.Size(153, 20)
        Me.DateStrip.Text = "ToolStripStatusLabel2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(849, 545)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(133, 28)
        Me.ProgressBar1.TabIndex = 25
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'PnIntiUI
        '
        Me.PnIntiUI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnIntiUI.BackColor = System.Drawing.Color.White
        Me.PnIntiUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnIntiUI.Controls.Add(Me.Button3)
        Me.PnIntiUI.Controls.Add(Me.PNInterfU)
        Me.PnIntiUI.Location = New System.Drawing.Point(0, 1)
        Me.PnIntiUI.Name = "PnIntiUI"
        Me.PnIntiUI.Size = New System.Drawing.Size(1320, 610)
        Me.PnIntiUI.TabIndex = 40
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Image = Global.nx_gestor.My.Resources.Resources.ProIcon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(1120, 484)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 88)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Compre sua licença PRO"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'PNInterfU
        '
        Me.PNInterfU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PNInterfU.BackColor = System.Drawing.Color.DarkGray
        Me.PNInterfU.Controls.Add(Me.btnConfig)
        Me.PNInterfU.Controls.Add(Me.btnUserSec)
        Me.PNInterfU.Controls.Add(Me.btnInfo)
        Me.PNInterfU.Controls.Add(Me.btnRelatar_erro)
        Me.PNInterfU.Controls.Add(Me.btnVendas)
        Me.PNInterfU.Controls.Add(Me.btnClientes)
        Me.PNInterfU.Controls.Add(Me.btnCompras)
        Me.PNInterfU.Controls.Add(Me.btnFornecedores)
        Me.PNInterfU.Controls.Add(Me.btnProdutos)
        Me.PNInterfU.Location = New System.Drawing.Point(174, 0)
        Me.PNInterfU.Name = "PNInterfU"
        Me.PNInterfU.Size = New System.Drawing.Size(970, 124)
        Me.PNInterfU.TabIndex = 42
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfig.Image = Global.nx_gestor.My.Resources.Resources.CadAllsIcon
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfig.Location = New System.Drawing.Point(541, 11)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(100, 104)
        Me.btnConfig.TabIndex = 8
        Me.btnConfig.Text = "Funções Especiais"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnUserSec
        '
        Me.btnUserSec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUserSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUserSec.Image = Global.nx_gestor.My.Resources.Resources.Sec_icon
        Me.btnUserSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUserSec.Location = New System.Drawing.Point(753, 11)
        Me.btnUserSec.Name = "btnUserSec"
        Me.btnUserSec.Size = New System.Drawing.Size(100, 104)
        Me.btnUserSec.TabIndex = 7
        Me.btnUserSec.Text = "Usuários e Segurança"
        Me.btnUserSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUserSec.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnInfo.Image = Global.nx_gestor.My.Resources.Resources.Info_icon
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInfo.Location = New System.Drawing.Point(859, 11)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 104)
        Me.btnInfo.TabIndex = 6
        Me.btnInfo.Text = "Informações Adicionais"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnRelatar_erro
        '
        Me.btnRelatar_erro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRelatar_erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRelatar_erro.Image = Global.nx_gestor.My.Resources.Resources.ErrorRelat_icon
        Me.btnRelatar_erro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelatar_erro.Location = New System.Drawing.Point(647, 11)
        Me.btnRelatar_erro.Name = "btnRelatar_erro"
        Me.btnRelatar_erro.Size = New System.Drawing.Size(100, 104)
        Me.btnRelatar_erro.TabIndex = 5
        Me.btnRelatar_erro.Text = "Relatar Erro"
        Me.btnRelatar_erro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatar_erro.UseVisualStyleBackColor = True
        '
        'btnVendas
        '
        Me.btnVendas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVendas.Image = Global.nx_gestor.My.Resources.Resources.Vendas_icon
        Me.btnVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVendas.Location = New System.Drawing.Point(329, 11)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(100, 104)
        Me.btnVendas.TabIndex = 4
        Me.btnVendas.Text = "Vendas"
        Me.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVendas.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClientes.Image = Global.nx_gestor.My.Resources.Resources.Client_icon
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(435, 11)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(100, 104)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompras.Image = Global.nx_gestor.My.Resources.Resources.Compras_icon
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCompras.Location = New System.Drawing.Point(223, 11)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(100, 104)
        Me.btnCompras.TabIndex = 2
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnFornecedores
        '
        Me.btnFornecedores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFornecedores.Image = Global.nx_gestor.My.Resources.Resources.Fornecedor_icon
        Me.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFornecedores.Location = New System.Drawing.Point(117, 11)
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(100, 104)
        Me.btnFornecedores.TabIndex = 1
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFornecedores.UseVisualStyleBackColor = True
        '
        'btnProdutos
        '
        Me.btnProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProdutos.Image = Global.nx_gestor.My.Resources.Resources.Prod_icons
        Me.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProdutos.Location = New System.Drawing.Point(11, 11)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(100, 104)
        Me.btnProdutos.TabIndex = 0
        Me.btnProdutos.Text = "Produtos"
        Me.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProdutos.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataSource = Me.TbusrdtBindingSource
        Me.ComboBox1.DisplayMember = "Login"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(589, 493)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "Login"
        '
        'LicenseDataSet
        '
        Me.LicenseDataSet.DataSetName = "LicenseDataSet"
        Me.LicenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblicenseBindingSource
        '
        Me.TblicenseBindingSource.DataMember = "tblicense"
        Me.TblicenseBindingSource.DataSource = Me.LicenseDataSet
        '
        'TblicenseTableAdapter
        '
        Me.TblicenseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblicenseTableAdapter = Me.TblicenseTableAdapter
        Me.TableAdapterManager1.UpdateOrder = nx_gestor.LicenseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ChaveTextBox
        '
        Me.ChaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblicenseBindingSource, "Chave", True))
        Me.ChaveTextBox.Location = New System.Drawing.Point(1116, 537)
        Me.ChaveTextBox.Name = "ChaveTextBox"
        Me.ChaveTextBox.Size = New System.Drawing.Size(172, 22)
        Me.ChaveTextBox.TabIndex = 44
        '
        'Nome_CompletoTextBox
        '
        Me.Nome_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblicenseBindingSource, "Nome Completo", True))
        Me.Nome_CompletoTextBox.Location = New System.Drawing.Point(1116, 509)
        Me.Nome_CompletoTextBox.Name = "Nome_CompletoTextBox"
        Me.Nome_CompletoTextBox.Size = New System.Drawing.Size(172, 22)
        Me.Nome_CompletoTextBox.TabIndex = 45
        '
        'InterfUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 611)
        Me.Controls.Add(Me.PnLogin)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnIntiUI)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(LoginLabel)
        Me.Controls.Add(Me.LoginTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(AtivoLabel)
        Me.Controls.Add(Me.AtivoTextBox)
        Me.Controls.Add(Tipo_de_UsuárioLabel)
        Me.Controls.Add(Me.Tipo_de_UsuárioTextBox)
        Me.Controls.Add(Dica_para_SenhaLabel)
        Me.Controls.Add(Me.Dica_para_SenhaTextBox)
        Me.Controls.Add(Me.TbusrdtBindingNavigator)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ChaveTextBox)
        Me.Controls.Add(Me.Nome_CompletoTextBox)
        Me.Name = "InterfUI"
        Me.Text = "InterfUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnLogin.ResumeLayout(False)
        Me.PnLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbusrdtBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbusrdtBindingNavigator.ResumeLayout(False)
        Me.TbusrdtBindingNavigator.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PnIntiUI.ResumeLayout(False)
        Me.PNInterfU.ResumeLayout(False)
        CType(Me.LicenseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblicenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnLogin As Panel
    Friend WithEvents USERTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PASSWORDTextBox As TextBox
    Friend WithEvents UsrdtDataSet As usrdtDataSet
    Friend WithEvents TbusrdtBindingSource As BindingSource
    Friend WithEvents TbusrdtTableAdapter As usrdtDataSetTableAdapters.tbusrdtTableAdapter
    Friend WithEvents TableAdapterManager As usrdtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbusrdtBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TbusrdtBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents AtivoTextBox As TextBox
    Friend WithEvents Tipo_de_UsuárioTextBox As TextBox
    Friend WithEvents Dica_para_SenhaTextBox As TextBox
    Friend WithEvents InfSys As Label
    Friend WithEvents InfLogin As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents UsrStrip As ToolStripStatusLabel
    Friend WithEvents DateStrip As ToolStripStatusLabel
    Friend WithEvents PNInterfU As Panel
    Friend WithEvents btnProdutos As Button
    Friend WithEvents PnIntiUI As Panel
    Friend WithEvents btnFornecedores As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnUserSec As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnRelatar_erro As Button
    Friend WithEvents btnVendas As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LicenseDataSet As LicenseDataSet
    Friend WithEvents TblicenseBindingSource As BindingSource
    Friend WithEvents TblicenseTableAdapter As LicenseDataSetTableAdapters.tblicenseTableAdapter
    Friend WithEvents TableAdapterManager1 As LicenseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChaveTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Nome_CompletoTextBox As TextBox
End Class
