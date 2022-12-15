<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_activ
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
        Dim Nome_CompletoLabel As System.Windows.Forms.Label
        Dim ChaveLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nome_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.TblicenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LicenseDataSet = New nx_gestor.LicenseDataSet()
        Me.ChaveTextBox = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.TblicenseTableAdapter = New nx_gestor.LicenseDataSetTableAdapters.tblicenseTableAdapter()
        Me.TableAdapterManager = New nx_gestor.LicenseDataSetTableAdapters.TableAdapterManager()
        Nome_CompletoLabel = New System.Windows.Forms.Label()
        ChaveLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TblicenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_CompletoLabel
        '
        Nome_CompletoLabel.AutoSize = True
        Nome_CompletoLabel.Location = New System.Drawing.Point(11, 13)
        Nome_CompletoLabel.Name = "Nome_CompletoLabel"
        Nome_CompletoLabel.Size = New System.Drawing.Size(129, 20)
        Nome_CompletoLabel.TabIndex = 0
        Nome_CompletoLabel.Text = "Nome Completo"
        '
        'ChaveLabel
        '
        ChaveLabel.AutoSize = True
        ChaveLabel.Location = New System.Drawing.Point(11, 66)
        ChaveLabel.Name = "ChaveLabel"
        ChaveLabel.Size = New System.Drawing.Size(148, 20)
        ChaveLabel.TabIndex = 2
        ChaveLabel.Text = "Chave de Ativação"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Controls.Add(Nome_CompletoLabel)
        Me.PnForm.Controls.Add(Me.Nome_CompletoTextBox)
        Me.PnForm.Controls.Add(ChaveLabel)
        Me.PnForm.Controls.Add(Me.ChaveTextBox)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(410, 228)
        Me.PnForm.TabIndex = 74
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.VerifIcon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(15, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(371, 88)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Ativar versão Pro"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nome_CompletoTextBox
        '
        Me.Nome_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblicenseBindingSource, "Nome Completo", True))
        Me.Nome_CompletoTextBox.Location = New System.Drawing.Point(15, 36)
        Me.Nome_CompletoTextBox.Name = "Nome_CompletoTextBox"
        Me.Nome_CompletoTextBox.Size = New System.Drawing.Size(371, 27)
        Me.Nome_CompletoTextBox.TabIndex = 1
        '
        'TblicenseBindingSource
        '
        Me.TblicenseBindingSource.DataMember = "tblicense"
        Me.TblicenseBindingSource.DataSource = Me.LicenseDataSet
        '
        'LicenseDataSet
        '
        Me.LicenseDataSet.DataSetName = "LicenseDataSet"
        Me.LicenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChaveTextBox
        '
        Me.ChaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblicenseBindingSource, "Chave", True))
        Me.ChaveTextBox.Location = New System.Drawing.Point(15, 89)
        Me.ChaveTextBox.Name = "ChaveTextBox"
        Me.ChaveTextBox.Size = New System.Drawing.Size(371, 27)
        Me.ChaveTextBox.TabIndex = 3
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
        Me.BtnClose.Location = New System.Drawing.Point(353, 1)
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
        Me.NameForm.Size = New System.Drawing.Size(148, 24)
        Me.NameForm.TabIndex = 75
        Me.NameForm.Text = "Status da Ativação"
        '
        'TblicenseTableAdapter
        '
        Me.TblicenseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblicenseTableAdapter = Me.TblicenseTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.LicenseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Status_activ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(411, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Status_activ"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status_activ"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        CType(Me.TblicenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
    Friend WithEvents LicenseDataSet As LicenseDataSet
    Friend WithEvents TblicenseBindingSource As BindingSource
    Friend WithEvents TblicenseTableAdapter As LicenseDataSetTableAdapters.tblicenseTableAdapter
    Friend WithEvents TableAdapterManager As LicenseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nome_CompletoTextBox As TextBox
    Friend WithEvents ChaveTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
