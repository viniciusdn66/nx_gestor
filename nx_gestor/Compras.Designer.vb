<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.NameForm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PnForm
        '
        Me.PnForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnForm.BackColor = System.Drawing.Color.White
        Me.PnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnForm.Location = New System.Drawing.Point(1, 38)
        Me.PnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(773, 396)
        Me.PnForm.TabIndex = 80
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
        Me.BtnClose.Location = New System.Drawing.Point(716, 1)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 38)
        Me.BtnClose.TabIndex = 82
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
        Me.NameForm.Size = New System.Drawing.Size(134, 24)
        Me.NameForm.TabIndex = 81
        Me.NameForm.Text = "Comprar Licença"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(774, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.NameForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compras"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents NameForm As Label
End Class
