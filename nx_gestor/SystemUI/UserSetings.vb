Imports System.Reflection.Emit
Imports System.Net.Mail
Imports System.Net.Mime
Public Class UserSetings
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mail As New MailMessage()
    Dim path As String
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

    Private Sub btnUserSec_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(TabPage2)
    End Sub

    Private Sub btnRelatar_erro_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(TabPage3)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(TabPage4)
    End Sub

    Private Sub TbusrdtBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbusrdtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsrdtDataSet)

    End Sub

    Private Sub UserSetings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbusrdtTableAdapter.Fill(Me.UsrdtDataSet.tbusrdt)
        If InterfUI.ChaveTextBox.Text = "" Then
            Label1.Text = "Free - Limitado"
            Label1.ForeColor = Color.Red
            Button5.Visible = True
            Button6.Text = "Ativar versão PRO"
        Else
            Label1.Text = "PRO - Ilimitado"
            Label1.ForeColor = Color.Blue
            Button5.Visible = False
            Button6.Text = "Status da Ativação"
        End If
        ComboBox1.Text = InterfUI.IDTextBox.Text
        Label5.Text = "Nome do Produto: " & ProductName
        Label6.Text = "Desenvolvedor: " & CompanyName
        Label7.Text = "Versão de Software: " & ProductVersion
        Label8.Text = "Processador: " & My.Computer.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString")
        Label9.Text = "Fabricante: " & My.Computer.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\BIOS").GetValue("BaseBoardManufacturer")
        Label10.Text = "Modelo: " & My.Computer.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\BIOS").GetValue("SystemProductName")
        Label11.Text = (String.Format("RAM: {0} MBytes", System.Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024)), 2).ToString)
        If InterfUI.AtivoTextBox.Text = "Escuro" Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White

            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black

            TabPage2.BackColor = Color.Black
            TabPage3.BackColor = Color.Black
            TabPage4.BackColor = Color.Black
        Else
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black

            Button1.BackColor = Color.White
            Button2.BackColor = Color.White

            TabPage2.BackColor = Color.White
            TabPage3.BackColor = Color.White
            TabPage4.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CadUser.Show()
        CadUser.TbusrdtBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CadUser.Show()
        CadUser.ComboBox1.Text = ComboBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.TbusrdtBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsrdtDataSet)
        Msg.Label1.Text = ("Tema alterado com sucesso!")
        Msg.Show()
        ComboBox1.Text = InterfUI.IDTextBox.Text
        InterfUI.AtivoTextBox.Text = AtivoComboBox.Text
        If InterfUI.AtivoTextBox.Text = "Escuro" Then
            InterfUI.PnIntiUI.BackgroundImage = My.Resources.Wallpaper2
        Else
            InterfUI.PnIntiUI.BackgroundImage = My.Resources.Wallpaper1
        End If
        If InterfUI.AtivoTextBox.Text = "Escuro" Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White

            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black

            TabPage2.BackColor = Color.Black
            TabPage3.BackColor = Color.Black
            TabPage4.BackColor = Color.Black
        Else
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.Black

            Button1.BackColor = Color.White
            Button2.BackColor = Color.White

            TabPage2.BackColor = Color.White
            TabPage3.BackColor = Color.White
            TabPage4.BackColor = Color.White
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TXTASSUNTO.Text = "" Or TXTMESSAGE.Text = "" Then
            Msg.Label1.Text = ("Campos Vazios, não é possivel relatar!")
            Msg.PictureBox1.BackgroundImage = My.Resources.Error_icon
            Msg.Show()
        Else
            Dim SmtpServer As New SmtpClient()
            SmtpServer.Credentials = New Net.NetworkCredential("debuguser365@outlook.com", "dev12345")
            SmtpServer.Port = "587"
            SmtpServer.Host = "SMTP.office365.com"
            SmtpServer.EnableSsl = True
            mail.Priority = MailPriority.Normal
            mail = New MailMessage()
            Dim addr() As String = TXTDESTINO.Text.Split(",")
            Try
                mail.From = New MailAddress("debuguser365@outlook.com", "USERDEBUG", System.Text.Encoding.UTF8)
                Dim i As Byte
                For i = 0 To addr.Length - 1
                    mail.To.Add(addr(i))
                Next
                mail.Subject = TXTASSUNTO.Text
                mail.Body = TXTMESSAGE.Text



                mail.IsBodyHtml = True
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                mail.ReplyTo = New MailAddress(TXTDESTINO.Text)
                SmtpServer.Send(mail)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Msg.Label1.Text = ("Agradecemos pela sua ajuda.")
            Msg.PictureBox1.BackgroundImage = My.Resources.Dev_icon
            Msg.Show()
            TXTMESSAGE.Text = ""
            TXTASSUNTO.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Pay_License.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Status_activ.ShowDialog Then
            Status_activ.Focus()
        Else
            Status_activ.Show()
            Status_activ.TblicenseBindingSource.AddNew()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RecoveryAccount.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CadUser.Show()
        CadUser.ComboBox1.Text = ComboBox1.Text
        CadUser.SenhaTextBox.Focus()
    End Sub
End Class