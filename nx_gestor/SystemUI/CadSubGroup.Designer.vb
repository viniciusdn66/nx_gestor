<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadSubGroup
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
        Dim Sub_GrupoLabel As System.Windows.Forms.Label
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.Sub_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.TbsubgroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsubgroupDataSet = New nx_gestor.dbsubgroupDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TbsubgroupTableAdapter = New nx_gestor.dbsubgroupDataSetTableAdapters.tbsubgroupTableAdapter()
        Me.TableAdapterManager = New nx_gestor.dbsubgroupDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Sub_GrupoLabel = New System.Windows.Forms.Label()
        Me.PnForm.SuspendLayout()
        CType(Me.TbsubgroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsubgroupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sub_GrupoLabel
        '
        Sub_GrupoLabel.AutoSize = True
        Sub_GrupoLabel.Location = New System.Drawing.Point(1, 286)
        Sub_GrupoLabel.Name = "Sub_GrupoLabel"
        Sub_GrupoLabel.Size = New System.Drawing.Size(147, 18)
        Sub_GrupoLabel.TabIndex = 113
        Sub_GrupoLabel.Text = "Nome do Sub-Grupo"
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Controls.Add(Sub_GrupoLabel)
        Me.PnForm.Controls.Add(Me.Sub_GrupoTextBox)
        Me.PnForm.Controls.Add(Me.DataGridView1)
        Me.PnForm.Controls.Add(Me.Button4)
        Me.PnForm.Controls.Add(Me.Button2)
        Me.PnForm.Controls.Add(Me.Button1)
        Me.PnForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(343, 456)
        Me.PnForm.TabIndex = 80
        '
        'Sub_GrupoTextBox
        '
        Me.Sub_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbsubgroupBindingSource, "Sub-Grupo", True))
        Me.Sub_GrupoTextBox.Location = New System.Drawing.Point(4, 305)
        Me.Sub_GrupoTextBox.Name = "Sub_GrupoTextBox"
        Me.Sub_GrupoTextBox.Size = New System.Drawing.Size(332, 24)
        Me.Sub_GrupoTextBox.TabIndex = 114
        '
        'TbsubgroupBindingSource
        '
        Me.TbsubgroupBindingSource.DataMember = "tbsubgroup"
        Me.TbsubgroupBindingSource.DataSource = Me.DbsubgroupDataSet
        '
        'DbsubgroupDataSet
        '
        Me.DbsubgroupDataSet.DataSetName = "dbsubgroupDataSet"
        Me.DbsubgroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.SubGrupoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbsubgroupBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 7)
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
        Me.DataGridView1.TabIndex = 113
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
        'SubGrupoDataGridViewTextBoxColumn
        '
        Me.SubGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubGrupoDataGridViewTextBoxColumn.DataPropertyName = "Sub-Grupo"
        Me.SubGrupoDataGridViewTextBoxColumn.HeaderText = "Sub-Grupo"
        Me.SubGrupoDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.SubGrupoDataGridViewTextBoxColumn.Name = "SubGrupoDataGridViewTextBoxColumn"
        Me.SubGrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubGrupoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SubGrupoDataGridViewTextBoxColumn.Width = 220
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.nx_gestor.My.Resources.Resources.DeleteIcon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(223, 340)
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
        Me.Button2.Location = New System.Drawing.Point(117, 340)
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
        Me.Button1.Location = New System.Drawing.Point(11, 340)
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
        Me.BtnClose.Location = New System.Drawing.Point(286, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 82
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TbsubgroupTableAdapter
        '
        Me.TbsubgroupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbsubgroupTableAdapter = Me.TbsubgroupTableAdapter
        Me.TableAdapterManager.UpdateOrder = nx_gestor.dbsubgroupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Sub-Grupo"
        '
        'CadSubGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(344, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadSubGroup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.TopMost = True
        Me.PnForm.ResumeLayout(False)
        Me.PnForm.PerformLayout()
        CType(Me.TbsubgroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsubgroupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DbsubgroupDataSet As dbsubgroupDataSet
    Friend WithEvents TbsubgroupBindingSource As BindingSource
    Friend WithEvents TbsubgroupTableAdapter As dbsubgroupDataSetTableAdapters.tbsubgroupTableAdapter
    Friend WithEvents Sub_GrupoTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableAdapterManager As dbsubgroupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
