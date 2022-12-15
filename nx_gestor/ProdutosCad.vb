Public Class ProdutosCad
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
    Private Sub DescriçãoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescriçãoTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            Descrição_ECFTextBox.Text = DescriçãoTextBox.Text
        End If
    End Sub
    Private Sub ProdutosCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TdprodTableAdapter.Fill(Me.DbprodDataSet.tdprod)
        Produtos.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DescriçãoTextBox.Text = "" Or Codigo_de_BarrasTextBox.Text = "" Then
            Msg.Label1.Text = ("Alguns campos importantes não estão preenchidos!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Error_icon
            Msg.Show()
        Else
            Me.Validate()
            Me.TdprodBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbprodDataSet)
            Msg.Label1.Text = ("Produto Cadastrado/Alterado com sucesso!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Prod_icons
            Msg.Show()
            Close()
        End If
        If DescriçãoTextBox.Text = "" Then
            DescriçãoTextBox.Focus()
            DescriçãoTextBox.BackColor = Color.Red
        End If
        If Codigo_de_BarrasTextBox.Text = "" Then
            Codigo_de_BarrasTextBox.BackColor = Color.Red
        End If
    End Sub
    Private Sub ProdutosCad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Produtos.Enabled = True
        Produtos.TdprodTableAdapter.Fill(Produtos.DbprodDataSet.tdprod)
        Produtos.Refresh()
    End Sub
End Class