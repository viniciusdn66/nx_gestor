Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Status_activ
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
    Private Sub Status_activ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblicenseTableAdapter.Fill(Me.LicenseDataSet.tblicense)
        If InterfUI.ChaveTextBox.Text = "" Then
            Button1.Enabled = True
            Button1.Text = "Ativar versão Pro"
        Else
            Button1.Enabled = False
            Button1.Text = "Versão Ativa"
            Nome_CompletoTextBox.ReadOnly = True
            ChaveTextBox.ReadOnly = True
            Nome_CompletoTextBox.Text = InterfUI.Nome_CompletoTextBox.Text
            ChaveTextBox.Text = InterfUI.ChaveTextBox.Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ChaveTextBox.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ" Then
            Me.Validate()
            Me.TblicenseBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LicenseDataSet)
            InterfUI.ChaveTextBox.Text = ChaveTextBox.Text
            InterfUI.Nome_CompletoTextBox.Text = Nome_CompletoTextBox.Text
            InterfUI.Button3.Visible = False
            Msg.Label1.Text = ("Versão PRO Ativada com sucesso, muito obrigado!")
            Msg.Show()
            Pay_License.Close()
            Close()
        ElseIf ChaveTextBox.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWG" Then
            Me.Validate()
            Me.TblicenseBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LicenseDataSet)
            InterfUI.ChaveTextBox.Text = ChaveTextBox.Text
            InterfUI.Nome_CompletoTextBox.Text = Nome_CompletoTextBox.Text
            InterfUI.Button3.Visible = False
            InterfUI.Button3.Visible = False
            Msg.Label1.Text = ("Versão PRO Ativada com sucesso, muito obrigado!")
            Msg.Show()
            Pay_License.Close()
            Close()
        ElseIf ChaveTextBox.Text = "4WH4N-8QGBV-H23JP-CT43Q-MDWWG" Then
            Me.Validate()
            Me.TblicenseBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LicenseDataSet)
            InterfUI.ChaveTextBox.Text = ChaveTextBox.Text
            InterfUI.Nome_CompletoTextBox.Text = Nome_CompletoTextBox.Text
            InterfUI.Button3.Visible = False
            Msg.Label1.Text = ("Versão PRO Ativada com sucesso, muito obrigado!")
            Msg.Show()
            Pay_License.Close()
            Close()
        Else
            Msg.Label1.Text = ("Chave invalida,tente novamente ou entre em contato com a equipe de desenvolvimento.")
            Msg.Show()
        End If

    End Sub
End Class