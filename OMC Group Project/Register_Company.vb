Public Class Register_Company
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Register_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReg_MouseEnter(sender As Object, e As EventArgs) Handles btnReg.MouseEnter
        btnReg.Image = New Bitmap(My.Resources.btnRegHover)
    End Sub

    Private Sub btnReg_MouseLeave(sender As Object, e As EventArgs) Handles btnReg.MouseLeave
        btnReg.Image = New Bitmap(My.Resources.btnReg)
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Company.Show()
        Me.Hide()
    End Sub
End Class