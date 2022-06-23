Public Class LogIn

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        pnlRegOption.Visible = True
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.Image = New Bitmap(My.Resources.btnLoginHover)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.Image = New Bitmap(My.Resources.btnLogin)
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlRegOption.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LogIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        pnlRegOption.Visible = False
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        Dim strUserEmail As String

        strUserEmail = InputBox("Please Enter Your Email Address", "Forgot Password", " ")
        If strUserEmail = "" Then
            Exit Sub
        End If
        MsgBox("A new password has been send to your email! Please use the new password to log in", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Forgot Password")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Register_User.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewUser_MouseEnter(sender As Object, e As EventArgs) Handles btnNewUser.MouseEnter
        btnNewUser.Image = New Bitmap(My.Resources.btnNewUserHover)
    End Sub

    Private Sub btnNewUser_MouseLeave(sender As Object, e As EventArgs) Handles btnNewUser.MouseLeave
        btnNewUser.Image = New Bitmap(My.Resources.btnNewUser)
    End Sub
    Private Sub btnNewComp_Click(sender As Object, e As EventArgs) Handles btnNewComp.Click
        Register_Company.Show()
        Me.Hide()
    End Sub
    Private Sub btnNewComp_MouseEnter(sender As Object, e As EventArgs) Handles btnNewComp.MouseEnter
        btnNewComp.Image = New Bitmap(My.Resources.btnNewCompHover)
    End Sub

    Private Sub btnNewComp_MouseLeave(sender As Object, e As EventArgs) Handles btnNewComp.MouseLeave
        btnNewComp.Image = New Bitmap(My.Resources.btnNewComp)
    End Sub

    Private Sub btnCancelReg_Click(sender As Object, e As EventArgs) Handles btnCancelReg.Click
        pnlRegOption.Visible = False
    End Sub

    Private Sub btnCancelReg_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelReg.MouseEnter
        btnCancelReg.Image = New Bitmap(My.Resources.btnCancelRegHover)
    End Sub

    Private Sub btnCancelReg_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelReg.MouseLeave
        btnCancelReg.Image = New Bitmap(My.Resources.btnCancelReg)
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        WindowState = FormWindowState.Minimized
    End Sub
End Class
