Imports System.Net
Imports System.Net.Mail
Imports System.Reflection.Emit
Imports System.Net.Mime

Public Class Pay_License
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcpf.Text = "" Or txtcpf.Text = "" Or txtchar.Text = "" Then
            Msg.Label1.Text = ("Campos Vazios, preencha e tente novamente!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Error_icon
            Msg.Show()
        Else
            Dim SmtpServer As New SmtpClient()
            SmtpServer.Credentials = New Net.NetworkCredential("debuguser365@outlook.com", "dev12345")
            SmtpServer.Port = "587"
            SmtpServer.Host = "SMTP.office365.com"
            SmtpServer.EnableSsl = True
            Mail.Priority = MailPriority.Normal
            Mail = New MailMessage()
            Dim addr() As String = txtdestino.Text.Split(",")
            Try
                Mail.From = New MailAddress("debuguser365@outlook.com", "USERDEBUG", System.Text.Encoding.UTF8)
                Dim i As Byte
                For i = 0 To addr.Length - 1
                    Mail.To.Add(addr(i))
                Next
                mail.Subject = txtname.Text
                mail.Body = txtname.Text & " " & txtcpf.Text & " " & txtemail.Text & " " & txtchar.Text
                mail.IsBodyHtml = True
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                mail.ReplyTo = New MailAddress(txtdestino.text)
                SmtpServer.Send(Mail)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Msg.Label1.Text = ("Aguarde sua chave de ativação que será recebida no E-mail após a confirmação do pagamento.")
            Msg.PictureBox1.BackgroundImage = My.Resources.Dev_icon
            Msg.Show()
            txtname.Text = ""
            txtcpf.Text = ""
            txtchar.Text = ""
            Status_activ.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtchar.Text = My.Computer.Info.TotalPhysicalMemory * 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Status_activ.Show()
    End Sub
End Class