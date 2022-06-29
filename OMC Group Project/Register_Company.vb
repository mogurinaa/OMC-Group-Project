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

    Private Sub btn3m_Click(sender As Object, e As EventArgs) Handles btn3m.Click
        btn3m.Image = New Bitmap(My.Resources._3month_selected)
        btn6m.Image = New Bitmap(My.Resources._6_month)
        btn9m.Image = New Bitmap(My.Resources._9_month)
    End Sub

    Private Sub btn6m_Click(sender As Object, e As EventArgs) Handles btn6m.Click
        btn6m.Image = New Bitmap(My.Resources._6month_selected)
        btn3m.Image = New Bitmap(My.Resources._3_month)
        btn9m.Image = New Bitmap(My.Resources._9_month)
    End Sub

    Private Sub btn9m_Click(sender As Object, e As EventArgs) Handles btn9m.Click
        btn9m.Image = New Bitmap(My.Resources._9month_selected)
        btn3m.Image = New Bitmap(My.Resources._3_month)
        btn6m.Image = New Bitmap(My.Resources._6_month)
    End Sub

    Private Sub btnSub_MouseEnter(sender As Object, e As EventArgs) Handles btnSub.MouseEnter
        btnSub.Image = New Bitmap(My.Resources.btnSubHover)
    End Sub

    Private Sub btnSub_MouseLeave(sender As Object, e As EventArgs) Handles btnSub.MouseLeave
        btnSub.Image = New Bitmap(My.Resources.btnSub)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        pnlPayment.Visible = True
    End Sub
End Class