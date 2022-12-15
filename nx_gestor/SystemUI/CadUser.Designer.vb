<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadUser
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim Dica_para_SenhaLabel As System.Windows.Forms.Label
        Dim Tipo_de_UsuárioLabel As System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TbusrdtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsrdtDataSet = New nx_gestor.usrdtDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tipo_de_UsuárioComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.Dica_para_SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbusrdtTableAdapter = New nx_gestor.usrdtDataSetTableAdapters.tbusrdtTableAdapter()
        Me.TableAdapterManager = New nx_gestor.usrdtDataSetTableAdapters.TableAdapterManager()
        LoginLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        Dica_para_SenhaLabel = New System.Windows.Forms.Label()
        Tipo_de_UsuárioLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginLabel.Location = New System.Drawing.Point(6, 165)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(125, 18)
        LoginLabel.TabIndex = 2
        LoginLabel.Text = "Nome de Usuário"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(10, 51)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(49, 18)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_mailLabel.Location = New System.Drawing.Point(8, 99)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(50, 18)
        E_mailLabel.TabIndex = 6
        E_mailLabel.Text = "E-mail"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.Location = New System.Drawing.Point(6, 213)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(50, 18)
        SenhaLabel.TabIndex = 8
        SenhaLabel.Text = "Senha"
        '
        'Dica_para_SenhaLabel
        '
        Dica_para_SenhaLabel.AutoSize = True
        Dica_para_SenhaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dica_para_SenhaLabel.Location = New System.Drawing.Point(6, 318)
        Dica_para_SenhaLabel.Name = "Dica_para_SenhaLabel"
        Dica_para_SenhaLabel.Size = New System.Drawing.Size(117, 18)
        Dica_para_SenhaLabel.TabIndex = 14
        Dica_para_SenhaLabel.Text = "Dica para Senha"
        '
        'Tipo_de_UsuárioLabel
        '
        Tipo_de_UsuárioLabel.AutoSize = True
        Tipo_de_UsuárioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_UsuárioLabel.Location = New System.Drawing.Point(6, 268)
        Tipo_de_UsuárioLabel.Name = "Tipo_de_UsuárioLabel"
        Tipo_de_UsuárioLabel.Size = New System.Drawing.Size(113, 18)
        Tipo_de_UsuárioLabel.TabIndex = 79
        Tipo_de_UsuárioLabel.Text = "Tipo de Usuário"
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
        Me.BtnClose.Location = New System.Drawing.Point(492, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 76
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
        Me.NameForm.Size = New System.Drawing.Size(205, 24)
        Me.NameForm.TabIndex = 75
        Me.NameForm.Text = "Configurações de Usuários"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.ComboBox1)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.GroupBox2)
        Me.PnForm.Controls.Add(Me.GroupBox1)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Location = New System.Drawing.Point(0, 37)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(550, 417)
        Me.PnForm.TabIndex = 74
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbusrdtBindingSource
        Me.ComboBox1.DisplayMember = "ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(472, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(53, 24)
        Me.ComboBox1.TabIndex = 83
        Me.ComboBox1.ValueMember = "ID"
        Me.ComboBox1.Visible = False
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
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Sec_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(436, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Excluir Cadastro"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NomeTextBox)
        Me.GroupBox2.Controls.Add(Me.E_mailTextBox)
        Me.GroupBox2.Controls.Add(E_mailLabel)
        Me.GroupBox2.Controls.Add(NomeLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(224, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 385)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações de Recuperação"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(11, 72)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(181, 24)
        Me.NomeTextBox.TabIndex = 5
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "E-mail", True))
        Me.E_mailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(11, 120)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(177, 24)
        Me.E_mailTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Tipo_de_UsuárioLabel)
        Me.GroupBox1.Controls.Add(Me.Tipo_de_UsuárioComboBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(LoginLabel)
        Me.GroupBox1.Controls.Add(Me.SenhaTextBox)
        Me.GroupBox1.Controls.Add(SenhaLabel)
        Me.GroupBox1.Controls.Add(Me.LoginTextBox)
        Me.GroupBox1.Controls.Add(Dica_para_SenhaLabel)
        Me.GroupBox1.Controls.Add(Me.Dica_para_SenhaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 385)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações de entrada"
        '
        'Tipo_de_UsuárioComboBox
        '
        Me.Tipo_de_UsuárioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Tipo de Usuário", True))
        Me.Tipo_de_UsuárioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_UsuárioComboBox.FormattingEnabled = True
        Me.Tipo_de_UsuárioComboBox.Items.AddRange(New Object() {"Administrador", "Padrão", "Consultor"})
        Me.Tipo_de_UsuárioComboBox.Location = New System.Drawing.Point(9, 289)
        Me.Tipo_de_UsuárioComboBox.Name = "Tipo_de_UsuárioComboBox"
        Me.Tipo_de_UsuárioComboBox.Size = New System.Drawing.Size(183, 26)
        Me.Tipo_de_UsuárioComboBox.TabIndex = 80
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.nx_gestor.My.Resources.Resources.User_img
        Me.PictureBox1.Location = New System.Drawing.Point(49, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Senha", True))
        Me.SenhaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaTextBox.Location = New System.Drawing.Point(9, 237)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(183, 24)
        Me.SenhaTextBox.TabIndex = 9
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Login", True))
        Me.LoginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTextBox.Location = New System.Drawing.Point(9, 186)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(183, 24)
        Me.LoginTextBox.TabIndex = 3
        '
        'Dica_para_SenhaTextBox
        '
        Me.Dica_para_SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Dica para Senha", True))
        Me.Dica_para_SenhaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dica_para_SenhaTextBox.Location = New System.Drawing.Point(9, 339)
        Me.Dica_para_SenhaTextBox.Name = "Dica_para_SenhaTextBox"
        Me.Dica_para_SenhaTextBox.Size = New System.Drawing.Size(183, 24)
        Me.Dica_para_SenhaTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.Save_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(436, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Salvar Alterações"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        'CadUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(550, 454)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.Controls.Add(Me.PnForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadUser"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents PnForm As Panel
    Friend WithEvents UsrdtDataSet As usrdtDataSet
    Friend WithEvents TbusrdtBindingSource As BindingSource
    Friend WithEvents TbusrdtTableAdapter As usrdtDataSetTableAdapters.tbusrdtTableAdapter
    Friend WithEvents TableAdapterManager As usrdtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents Dica_para_SenhaTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tipo_de_UsuárioComboBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
