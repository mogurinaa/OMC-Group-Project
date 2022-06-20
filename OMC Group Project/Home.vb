
Public Class Home
    Private Sub RoundPicBox(pic As PictureBox)
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, pic.Width - 20, 0)
        rad.AddArc(New Rectangle(pic.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(pic.Width, 20, pic.Width, pic.Height - 10)
        rad.AddArc(New Rectangle(pic.Width - 25, pic.Height - 25, 25, 25), 0, 90)
        rad.AddLine(pic.Width, pic.Width + 50, pic.Height, pic.Height)
        rad.AddArc(New Rectangle(0, pic.Height - 20, 20, 20), 90, 90)
        pic.Region = New Region(rad)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPicBox(picTravel1)
        RoundPicBox(picTravel2)

        btnTravelPlan.PerformClick()
    End Sub


    Private Sub btnTravelPlan_Click(sender As Object, e As EventArgs) Handles btnTravelPlan.Click
        btnSettings.BackColor = Color.FromArgb(64, 141, 179)
        btnCSV.BackColor = Color.FromArgb(64, 141, 179)
        panelNav.Height = btnTravelPlan.Height
        panelNav.Top = btnTravelPlan.Top
        panelNav.Left = btnTravelPlan.Left
        btnTravelPlan.BackColor = Color.FromArgb(111, 192, 232)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        btnTravelPlan.BackColor = Color.FromArgb(64, 141, 179)
        btnCSV.BackColor = Color.FromArgb(64, 141, 179)
        panelNav.Height = btnSettings.Height
        panelNav.Top = btnSettings.Top
        panelNav.Left = btnSettings.Left
        btnSettings.BackColor = Color.FromArgb(111, 192, 232)
    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        btnTravelPlan.BackColor = Color.FromArgb(64, 141, 179)
        btnSettings.BackColor = Color.FromArgb(64, 141, 179)
        panelNav.Height = btnCSV.Height
        panelNav.Top = btnCSV.Top
        panelNav.Left = btnCSV.Left
        btnCSV.BackColor = Color.FromArgb(111, 192, 232)
    End Sub

    'Private Sub btnTravelPlan_Leave(sender As Object, e As EventArgs) Handles btnTravelPlan.Leave
    '    btnTravelPlan.BackColor = Color.FromArgb(64, 141, 179)
    'End Sub

    'Private Sub btnSettings_Leave(sender As Object, e As EventArgs) Handles btnSettings.Leave
    '    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
    'End Sub

    'Private Sub btnCSV_Leave(sender As Object, e As EventArgs) Handles btnCSV.Leave
    '    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
    'End Sub

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


    Private Sub btnUp_MouseEnter(sender As Object, e As EventArgs) Handles btnUp.MouseEnter
        btnUp.Image = New Bitmap(My.Resources.btnUpHover)
    End Sub
    Private Sub btnUp_MouseLeave(sender As Object, e As EventArgs) Handles btnUp.MouseLeave
        btnUp.Image = New Bitmap(My.Resources.btnUp)
    End Sub
    Private Sub btnDown_MouseEnter(sender As Object, e As EventArgs) Handles btnDown.MouseEnter
        btnDown.Image = New Bitmap(My.Resources.btnDownHover)
    End Sub

    Private Sub btnDown_MouseLeave(sender As Object, e As EventArgs) Handles btnDown.MouseLeave
        btnDown.Image = New Bitmap(My.Resources.btnDown)
    End Sub

    Private Sub pnlPlan1_Click(sender As Object, e As EventArgs) Handles pnlPlan1.Click
        pictRect.Image = New Bitmap(My.Resources.Travel_Rect_BG3)
        pictRect2.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
    End Sub

    Private Sub pnlPlan2_Click(sender As Object, e As EventArgs) Handles pnlPlan2.Click
        pictRect.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
        pictRect2.Image = New Bitmap(My.Resources.Travel_Rect_BG3)
    End Sub

    Private Sub pnlPlan2_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlPlan1_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        btnConfirm.Image = New Bitmap(My.Resources.btnConfirmHover)
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        btnConfirm.Image = New Bitmap(My.Resources.btnConfirm)
    End Sub
End Class