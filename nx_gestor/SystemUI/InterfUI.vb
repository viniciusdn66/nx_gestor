Imports System.Reflection.Emit
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class InterfUI
    Private Sub InterfUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblicenseTableAdapter.Fill(Me.LicenseDataSet.tblicense)
        Me.TbusrdtTableAdapter.Fill(Me.UsrdtDataSet.tbusrdt)
        InfSys.Text = "NX - Gestor Versão: " + Me.ProductVersion
        If ChaveTextBox.Text = "" Then
            Button3.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lgn = TbusrdtTableAdapter.UserPassString(USERTextBox.Text, PASSWORDTextBox.Text)
        If lgn Is Nothing Then
            InfLogin.Text = "Usuário e/ou senha incorretos!"
        Else
            UsrStrip.Text = "Usuário logado: " & NomeTextBox.Text
            DateStrip.Text = "Data: " & Date.Today
            InfLogin.Text = "Usuário: " & USERTextBox.Text
            Button1.Visible = False
            Button2.Visible = False
            USERTextBox.Visible = False
            PASSWORDTextBox.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            InfLogin.Visible = False
            PictureBox1.Visible = True
            Label3.Visible = True
            ComboBox1.Text = USERTextBox.Text
            Timer1.Enabled = True
        End If
        If AtivoTextBox.Text = "Escuro" Then
            PnIntiUI.BackgroundImage = My.Resources.Wallpaper2
        Else
            PnIntiUI.BackgroundImage = My.Resources.Wallpaper1
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment("1")
        If ProgressBar1.Value = 1 Then
            Label3.Text = "Carregando informações do sistema."
        End If
        If ProgressBar1.Value = 5 Then
            Label3.Text = "Carregando informações do sistema.."
        End If
        If ProgressBar1.Value = 10 Then
            Label3.Text = "Carregando informações do sistema..."
        End If
        If ProgressBar1.Value = 15 Then
            Label3.Text = "Carregando informações do sistema."
        End If
        If ProgressBar1.Value = 20 Then
            Label3.Text = "Carregando informações do sistema.."
        End If
        If ProgressBar1.Value = 30 Then
            Label3.Text = "Carregando informações do sistema..."
        End If

        If ProgressBar1.Value = 35 Then
            Label3.Text = "Carregando informações do sistema."
        End If
        If ProgressBar1.Value = 40 Then
            Label3.Text = "Carregando informações do sistema.."
        End If
        If ProgressBar1.Value = 45 Then
            Label3.Text = "Carregando informações do sistema..."
        End If
        If ProgressBar1.Value = 50 Then
            Label3.Text = "Carregando informações do sistema."
        End If
        If ProgressBar1.Value = 55 Then
            Label3.Text = "verificando banco de dados, reunindo informações"
        End If
        If ProgressBar1.Value = 60 Then
            Label3.Text = "Iniciando o sistema."
        End If
        If ProgressBar1.Value = 65 Then
            Label3.Text = "Iniciando o sistema.."
        End If
        If ProgressBar1.Value = 70 Then
            Label3.Text = "Iniciando o sistema..."
        End If
        If ProgressBar1.Value = 75 Then
            Label3.Text = "Iniciando o sistema."
        End If
        If ProgressBar1.Value = 80 Then
            Label3.Text = "Iniciando o sistema.."
        End If
        If ProgressBar1.Value = 85 Then
            Label3.Text = "Iniciando o sistema..."
        End If
        If ProgressBar1.Value = 90 Then
            PnLogin.Visible = False
        End If
        If ProgressBar1.Value = 99 Then
            Timer1.Enabled = False
            If ChaveTextBox.Text = "" Then
                Pay_License.Show()
            End If
        End If
    End Sub
    Private Sub USERTextBox_TextChanged(sender As Object, e As EventArgs) Handles USERTextBox.TextChanged
        InfLogin.Text = ""
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Funcoes.Show()
    End Sub

    Private Sub btnProdutos_Click(sender As Object, e As EventArgs) Handles btnProdutos.Click
        Produtos.Show()
    End Sub

    Private Sub btnFornecedores_Click(sender As Object, e As EventArgs) Handles btnFornecedores.Click
        If ChaveTextBox.Text = "" Then
            Pay_License.Show()
            Msg.Label1.Text = "Ative para a versão PRO e tenha acesso a esta função!"
            Msg.Show()
        Else
            Fornecedores.Show()
        End If
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        If ChaveTextBox.Text = "" Then
            Pay_License.Show()
            Msg.Label1.Text = "Ative para a versão PRO e tenha acesso a esta função!"
            Msg.Show()
        Else
            Compras.Show()
        End If
    End Sub

    Private Sub btnVendas_Click(sender As Object, e As EventArgs) Handles btnVendas.Click
        If ChaveTextBox.Text = "" Then
            Pay_License.Show()
            Msg.Label1.Text = "Ative para a versão PRO e tenha acesso a esta função!"
            Msg.Show()
        Else
            Vendas.Show()
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If ChaveTextBox.Text = "" Then
            Pay_License.Show()
            Msg.Label1.Text = "Ative para a versão PRO e tenha acesso a esta função!"
            Msg.Show()
        Else
            Clientes.Show()
        End If
    End Sub

    Private Sub btnRelatar_erro_Click(sender As Object, e As EventArgs) Handles btnRelatar_erro.Click
        UserSetings.Show()
        UserSetings.TabControl1.SelectTab(UserSetings.TabPage3)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        UserSetings.Show()
        UserSetings.TabControl1.SelectTab(UserSetings.TabPage4)
    End Sub

    Private Sub btnUserSec_Click(sender As Object, e As EventArgs) Handles btnUserSec.Click
        UserSetings.Show()
        UserSetings.TabControl1.SelectTab(UserSetings.TabPage2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pay_License.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RecoveryAccount.Show()
    End Sub
    Private Sub USERTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles USERTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            PASSWORDTextBox.Focus()
        End If
    End Sub
    Private Sub PASSWORDTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PASSWORDTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            Button1.PerformClick
        End If
    End Sub
End Class