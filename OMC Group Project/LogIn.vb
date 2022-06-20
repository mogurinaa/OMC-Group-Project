Public Class LogIn

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.Image = New Bitmap(My.Resources.btnLoginHover)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.Image = New Bitmap(My.Resources.btnLogin)
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LogIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
End Class
