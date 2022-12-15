Public Class CadUser
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
    Private Sub CadUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbusrdtTableAdapter.Fill(Me.UsrdtDataSet.tbusrdt)
        If Tipo_de_UsuárioComboBox.Text = "Administrador" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TbusrdtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsrdtDataSet)
        UserSetings.TableAdapterManager.UpdateAll(Me.UsrdtDataSet)
        UserSetings.PnForm.Refresh()
        UserSetings.PnForm.Update()
        UserSetings.Refresh()
        UserSetings.Update()
        UserSetings.E_mailLinkLabel.Text = E_mailTextBox.Text
        Msg.Label1.Text = ("Configurações feitas com sucesso!")
        Msg.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TbusrdtBindingSource.RemoveCurrent()

    End Sub
End Class