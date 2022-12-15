Public Class Clientes
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Dim mv As MoveForm
    Private dv As DataView
    Private cm As CurrencyManager
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
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbclientTableAdapter.Fill(Me.DbclientDataSet.tbclient)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientesCad.Show()
        ClientesCad.TbclientBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientesCad.Show()
        ClientesCad.LocalComboBox.Text = LocalComboBox.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If InterfUI.Tipo_de_UsuárioTextBox.Text = "Desenvolvedor" Then
            Me.TbclientBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TbclientBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbclientDataSet)
        Else
            Msg.Show()
            Msg.PictureBox1.BackgroundImage = My.Resources.Alert_icon
            Msg.Label1.Text = "Usuário sem autorização para executar essa função, restrito a apenas modo Desenvolvedor."
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioButton1.Checked Then
            Dim cm = CType(Me.BindingContext(DataGridView1.DataSource), CurrencyManager)
            TbclientBindingSource.Sort = "Nome/Razão Social"
            Dim x As Integer = TbclientBindingSource.Filter = ComboBox1.Text
            DataGridView1.Rows(x).Selected = True
        End If
        If RadioButton2.Checked Then
            Dim cm = CType(Me.BindingContext(DataGridView1.DataSource), CurrencyManager)
            TbclientBindingSource.Sort = "CPF/CNPJ"
            Dim x As Integer = TbclientBindingSource.Filter = ComboBox1.Text
            DataGridView1.Rows(x).Selected = True
        End If
        If RadioButton3.Checked Then
            Dim cm = CType(Me.BindingContext(DataGridView1.DataSource), CurrencyManager)
            TbclientBindingSource.Sort = "Nome Fantasia"
            Dim x As Integer = TbclientBindingSource.Filter = ComboBox1.Text
            DataGridView1.Rows(x).Selected = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.DisplayMember = "Nome/Razão Social"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox1.DisplayMember = "CPF/CNPJ"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ComboBox1.DisplayMember = "Nome Fantasia"
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ClientesCad.Show()
        ClientesCad.LocalComboBox.Text = LocalComboBox.Text
    End Sub
End Class