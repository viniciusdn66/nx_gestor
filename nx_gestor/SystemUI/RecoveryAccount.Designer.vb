<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoveryAccount
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
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.TbusrdtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsrdtDataSet = New nx_gestor.usrdtDataSet()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TbusrdtTableAdapter = New nx_gestor.usrdtDataSetTableAdapters.tbusrdtTableAdapter()
        Me.TableAdapterManager = New nx_gestor.usrdtDataSetTableAdapters.TableAdapterManager()
        Me.PnForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.GroupBox1)
        Me.PnForm.Controls.Add(Me.LoginTextBox)
        Me.PnForm.Controls.Add(Me.btnConfig)
        Me.PnForm.Controls.Add(Me.E_mailTextBox)
        Me.PnForm.Controls.Add(Me.ComboBox1)
        Me.PnForm.Controls.Add(Me.SenhaTextBox)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(406, 265)
        Me.PnForm.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 160)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações de Recuperação"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seu nome"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(12, 114)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(368, 27)
        Me.txtmail.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(12, 56)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(368, 27)
        Me.txtname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "E-mail de recuperação"
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Login", True))
        Me.LoginTextBox.Location = New System.Drawing.Point(10, 73)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(121, 27)
        Me.LoginTextBox.TabIndex = 91
        Me.LoginTextBox.TabStop = False
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
        'btnConfig
        '
        Me.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfig.BackColor = System.Drawing.Color.White
        Me.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.Image = Global.nx_gestor.My.Resources.Resources.SecurityIcon
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfig.Location = New System.Drawing.Point(2, 173)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(398, 89)
        Me.btnConfig.TabIndex = 3
        Me.btnConfig.Text = "Enviar para verificação"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(10, 6)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(121, 27)
        Me.E_mailTextBox.TabIndex = 4
        Me.E_mailTextBox.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbusrdtBindingSource
        Me.ComboBox1.DisplayMember = "E-mail"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.TabStop = False
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbusrdtBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(10, 106)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(121, 27)
        Me.SenhaTextBox.TabIndex = 90
        Me.SenhaTextBox.TabStop = False
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
        Me.BtnClose.Location = New System.Drawing.Point(349, 1)
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
        Me.NameForm.Size = New System.Drawing.Size(80, 24)
        Me.NameForm.TabIndex = 84
        Me.NameForm.Text = "Recovery"
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
        'RecoveryAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(407, 304)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecoveryAccount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecoveryAccount"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbusrdtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrdtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents UsrdtDataSet As usrdtDataSet
    Friend WithEvents TbusrdtBindingSource As BindingSource
    Friend WithEvents TbusrdtTableAdapter As usrdtDataSetTableAdapters.tbusrdtTableAdapter
    Friend WithEvents TableAdapterManager As usrdtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents btnConfig As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
