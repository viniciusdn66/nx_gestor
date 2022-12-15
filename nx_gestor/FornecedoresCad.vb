Public Class FornecedoresCad
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Dim mv As MoveForm
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mv.X = Me.Left - MousePosition.X
        mv.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mv.X + MousePosition.X
        Me.Top = mv.y + MousePosition.Y
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
    Private Sub FornecedoresCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.FormClosing
        Me.TbfornecTableAdapter.Fill(Me.DbforncDataSet.tbfornec)
        Fornecedores.Enabled = False
    End Sub
    Private Sub FornecedoresCad_Load(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Fornecedores.Enabled = True
        Fornecedores.TbfornecTableAdapter.Fill(Fornecedores.DbforncDataSet.tbfornec)
        Fornecedores.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Nome_Razão_SocialTextBox.Text = "" Or CPF_CNPJTextBox.Text = "" Then
            Msg.Label1.Text = ("Alguns campos importantes não estão preenchidos!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Error_icon
            Msg.Show()
        Else
            Me.Validate()
            Me.TbfornecBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbforncDataSet)
            Msg.Label1.Text = ("Fornecedor Cadastrado/Alterado com sucesso!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Fornecedor_icon
            Msg.Show()
            Close()
        End If
        If Nome_Razão_SocialTextBox.Text = "" Then
            Nome_Razão_SocialTextBox.Focus()
            Nome_Razão_SocialTextBox.BackColor = Color.Red
        End If
        If CPF_CNPJTextBox.Text = "" Then
            CPF_CNPJTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class