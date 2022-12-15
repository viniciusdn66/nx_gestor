<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadSection
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
        Dim SeçãoLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.SeçãoTextBox = New System.Windows.Forms.TextBox()
        Me.TbsectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsectionDataSet = New nx_gestor.dbsectionDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TbsectionTableAdapter = New nx_gestor.dbsectionDataSetTableAdapters.tbsectionTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbsectionDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        SeçãoLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TbsectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeçãoLabel
        '
        SeçãoLabel.AutoSize = True
        SeçãoLabel.Location = New System.Drawing.Point(3, 285)
        SeçãoLabel.Name = "SeçãoLabel"
        SeçãoLabel.Size = New System.Drawing.Size(116, 18)
        SeçãoLabel.TabIndex = 114
        SeçãoLabel.Text = "Nome da Seção"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(SeçãoLabel)
        Me.PnForm.Controls.Add(Me.SeçãoTextBox)
        Me.PnForm.Controls.Add(Me.DataGridView1)
        Me.PnForm.Controls.Add(Me.Button4)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(344, 462)
        Me.PnForm.TabIndex = 80
        '
        'SeçãoTextBox
        '
        Me.SeçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbsectionBindingSource, "Seção", True))
        Me.SeçãoTextBox.Location = New System.Drawing.Point(6, 306)
        Me.SeçãoTextBox.Name = "SeçãoTextBox"
        Me.SeçãoTextBox.Size = New System.Drawing.Size(329, 24)
        Me.SeçãoTextBox.TabIndex = 115
        '
        'TbsectionBindingSource
        '
        Me.TbsectionBindingSource.DataMember = "tbsection"
        Me.TbsectionBindingSource.DataSource = Me.DbsectionDataSet
        '
        'DbsectionDataSet
        '
        Me.DbsectionDataSet.DataSetName = "dbsectionDataSet"
        Me.DbsectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.SeçãoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbsectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(332, 275)
        Me.DataGridView1.TabIndex = 114
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
        Me.CódigoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CódigoDataGridViewTextBoxColumn.Width = 80
        '
        'SeçãoDataGridViewTextBoxColumn
        '
        Me.SeçãoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SeçãoDataGridViewTextBoxColumn.DataPropertyName = "Seção"
        Me.SeçãoDataGridViewTextBoxColumn.HeaderText = "Seção"
        Me.SeçãoDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.SeçãoDataGridViewTextBoxColumn.Name = "SeçãoDataGridViewTextBoxColumn"
        Me.SeçãoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeçãoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SeçãoDataGridViewTextBoxColumn.Width = 220
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.DeleteIcon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(226, 346)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 104)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "Excluir Cadastro"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.nx_gestor.My.Resources.Resources.Save_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(120, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 104)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Salvar Dados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.nx_gestor.My.Resources.Resources.NewIcon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(14, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 104)
        Me.Button1.TabIndex = 110
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
        Me.BtnClose.Location = New System.Drawing.Point(287, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 82
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TbsectionTableAdapter
        '
        Me.TbsectionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbsectionTableAdapter = Me.TbsectionTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.dbsectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Seção"
        '
        'CadSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(345, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadSection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        CType(Me.TbsectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DbsectionDataSet As dbsectionDataSet
    Friend WithEvents TbsectionBindingSource As BindingSource
    Friend WithEvents TbsectionTableAdapter As dbsectionDataSetTableAdapters.tbsectionTableAdapter
    Friend WithEvents TableAdapterManager As dbsectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SeçãoTextBox As TextBox
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
