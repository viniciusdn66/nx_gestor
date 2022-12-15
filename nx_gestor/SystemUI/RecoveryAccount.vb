Imports System.Net
Imports System.Net.Mail

Public Class RecoveryAccount
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
    Dim mail As New MailMessage()
    Dim path As String
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub RecoveryAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbusrdtTableAdapter.Fill(Me.UsrdtDataSet.tbusrdt)
        E_mailTextBox.Text = ""
        Me.Focus()
        txtname.Focus()
    End Sub
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        ComboBox1.Text = txtmail.Text
        If txtmail.Text = "" Then
            Msg.Label1.Text = ("Algo deu errado na sua solicitação!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Error_icon
            Msg.Show()
            Me.Close()
        Else
            txtname.Enabled = False
            txtmail.Enabled = False
            Dim SmtpServer As New SmtpClient()
            SmtpServer.Credentials = New Net.NetworkCredential("debuguser365@outlook.com", "dev12345")
            SmtpServer.Port = "587"
            SmtpServer.Host = "SMTP.office365.com"
            SmtpServer.EnableSsl = True
            mail.Priority = MailPriority.High
            mail = New MailMessage()
            Dim addr() As String = txtmail.Text.Split(",")
            Try
                mail.From = New MailAddress("debuguser365@outlook.com", "USERDEBUG", System.Text.Encoding.UTF8)
                Dim i As Byte
                For i = 0 To addr.Length - 1
                    mail.To.Add(addr(i))
                Next
                mail.Subject = txtname.Text
                mail.Body = "Prezado " & txtname.Text & " você solicitou a recuperação de senha a análise foi feita e aceitamos sua solicitação, seu login é: " & LoginTextBox.Text & " e sua senha atual é: " & SenhaTextBox.Text & ", agradecemos sua atenção."
                mail.IsBodyHtml = True
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                mail.ReplyTo = New MailAddress(txtmail.Text)
                SmtpServer.Send(mail)
            Catch ex As Exception
                Msg.Show()
                Msg.Label1.Text = (ex.ToString())
            End Try
            Msg.Label1.Text = ("Sua solicitação foi enviada para nossa equipe para análise, em breve você receberá um e-mail de confirmação.")
            Msg.PictureBox1.BackgroundImage = My.Resources.Dev_icon
            Msg.Show()
            txtname.Text = ""
            txtmail.Text = ""
            Me.Close()
        End If
    End Sub
End Class