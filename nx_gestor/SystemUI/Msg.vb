Public Class Msg
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

    Private Sub Msg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If InterfUI.AtivoTextBox.Text = "Escuro" Then
            Me.BackColor = Color.Black
            NameForm.ForeColor = Color.White
            Label1.ForeColor = Color.White
        Else
            Me.BackColor = Color.DarkGray
            NameForm.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close
    End Sub
End Class