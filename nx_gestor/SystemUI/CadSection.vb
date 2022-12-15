Public Class CadSection
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

    Private Sub CadSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbsectionTableAdapter.Fill(Me.DbsectionDataSet.tbsection)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TbsectionBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbsectionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsectionDataSet)
        Msg.Show()
        Msg.PictureBox1.BackgroundImage = My.Resources.VerifIcon
        Msg.Label1.Text = "Informações salva com sucesso"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If InterfUI.Tipo_de_UsuárioTextBox.Text = "Desenvolvedor" Then
            Me.TbsectionBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TbsectionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbsectionDataSet)
        Else
            Msg.Show()
            Msg.PictureBox1.BackgroundImage = My.Resources.Alert_icon
            Msg.Label1.Text = "Usuário sem autorização para executar essa função, restrito a apenas modo Desenvolvedor."
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        SeçãoTextBox.Focus()
    End Sub
End Class