
Public Class Company
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
        RoundPicBox(picExample)

        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        btnDashboard.PerformClick()
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnAddNew.Click, btnPlanList.Click, btnFeedback.Click, btnSettings.Click, btnCSV.Click
        Try

            Dim Mybutton = DirectCast(sender, Button)

            Select Case Mybutton.Name
                Case "btnDashboard"
                    TabControl1.SelectedTab = TabPage5
                    btnAddNew.BackColor = Color.FromArgb(64, 141, 179)
                    btnPlanList.BackColor = Color.FromArgb(64, 141, 179)
                    btnFeedback.BackColor = Color.FromArgb(64, 141, 179)
                    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
                    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnDashboard.Height
                    panelNav.Top = btnDashboard.Top
                    panelNav.Left = btnDashboard.Left
                    btnDashboard.BackColor = Color.FromArgb(111, 192, 232)
                Case "btnPlanList"
                    TabControl1.SelectedTab = TabPage2
                    btnDashboard.BackColor = Color.FromArgb(64, 141, 179)
                    btnAddNew.BackColor = Color.FromArgb(64, 141, 179)
                    btnFeedback.BackColor = Color.FromArgb(64, 141, 179)
                    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
                    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnPlanList.Height
                    panelNav.Top = btnPlanList.Top
                    panelNav.Left = btnPlanList.Left
                    btnPlanList.BackColor = Color.FromArgb(111, 192, 232)

                    pictRect.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
                    pictRect2.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
                Case "btnAddNew"
                    TabControl1.SelectedTab = TabPage1
                    btnDashboard.BackColor = Color.FromArgb(64, 141, 179)
                    btnPlanList.BackColor = Color.FromArgb(64, 141, 179)
                    btnFeedback.BackColor = Color.FromArgb(64, 141, 179)
                    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
                    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnAddNew.Height
                    panelNav.Top = btnAddNew.Top
                    panelNav.Left = btnAddNew.Left
                    btnAddNew.BackColor = Color.FromArgb(111, 192, 232)

                    pictRect.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
                    pictRect2.Image = New Bitmap(My.Resources.Travel_Rectangle_BG)
                Case "btnFeedback"
                    TabControl1.SelectedTab = TabPage6
                    btnDashboard.BackColor = Color.FromArgb(64, 141, 179)
                    btnAddNew.BackColor = Color.FromArgb(64, 141, 179)
                    btnPlanList.BackColor = Color.FromArgb(64, 141, 179)
                    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
                    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnAddNew.Height
                    panelNav.Top = btnAddNew.Top
                    panelNav.Left = btnAddNew.Left
                    btnFeedback.BackColor = Color.FromArgb(111, 192, 232)
                Case "btnSettings"
                    TabControl1.SelectedTab = TabPage3
                    btnDashboard.BackColor = Color.FromArgb(64, 141, 179)
                    btnAddNew.BackColor = Color.FromArgb(64, 141, 179)
                    btnFeedback.BackColor = Color.FromArgb(64, 141, 179)
                    btnPlanList.BackColor = Color.FromArgb(64, 141, 179)
                    btnCSV.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnSettings.Height
                    panelNav.Top = btnSettings.Top
                    panelNav.Left = btnSettings.Left
                    btnSettings.BackColor = Color.FromArgb(111, 192, 232)
                Case "btnCSV"
                    TabControl1.SelectedTab = TabPage4
                    btnDashboard.BackColor = Color.FromArgb(64, 141, 179)
                    btnAddNew.BackColor = Color.FromArgb(64, 141, 179)
                    btnFeedback.BackColor = Color.FromArgb(64, 141, 179)
                    btnPlanList.BackColor = Color.FromArgb(64, 141, 179)
                    btnSettings.BackColor = Color.FromArgb(64, 141, 179)
                    panelNav.Height = btnCSV.Height
                    panelNav.Top = btnCSV.Top
                    panelNav.Left = btnCSV.Left
                    btnCSV.BackColor = Color.FromArgb(111, 192, 232)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximise_Click(sender As Object, e As EventArgs) Handles btnMaximise.Click
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

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.Image = New Bitmap(My.Resources.btnSaveHover)
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.Image = New Bitmap(My.Resources.btnSave)
    End Sub

    Private Sub btnEdit_MouseEnter(sender As Object, e As EventArgs) Handles btnEdit.MouseEnter
        btnEdit.Image = New Bitmap(My.Resources.btnEditHover)
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.Image = New Bitmap(My.Resources.btnEdit)
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.Image = New Bitmap(My.Resources.btnCancelHover)
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.Image = New Bitmap(My.Resources.btnCancel)
    End Sub

    Private Sub btnSend_MouseEnter(sender As Object, e As EventArgs) Handles btnSend.MouseEnter
        btnSend.Image = New Bitmap(My.Resources.btnSendHover)
    End Sub

    Private Sub btnSend_MouseLeave(sender As Object, e As EventArgs) Handles btnSend.MouseLeave
        btnSend.Image = New Bitmap(My.Resources.btnSend)
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs)
        btnAddNew.PerformClick()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.Image = New Bitmap(My.Resources.btnAddHover)
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.Image = New Bitmap(My.Resources.btnAdd)
    End Sub

    Private Sub btnUpload_MouseEnter(sender As Object, e As EventArgs) Handles btnUpload.MouseEnter
        btnUpload.Image = New Bitmap(My.Resources.btnUploadHover)
    End Sub

    Private Sub btnUpload_MouseLeave(sender As Object, e As EventArgs) Handles btnUpload.MouseLeave
        btnUpload.Image = New Bitmap(My.Resources.btnUpload)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openphoto As New OpenFileDialog

        openphoto.Filter = ("Picture File (*.jpg)|*.jpg, *.png, *.jpeg, *.bmp")

        openphoto.ShowDialog()

        picExample.ImageLocation = openphoto.FileName
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtName.Enabled = True
        txtPassword.Enabled = True
        txtEmail.Enabled = True
        txtCPassword.Enabled = True
        txtPhone.Enabled = True
        txtAddress1.Enabled = True

        btnEdit.Visible = False
        btnCancel.Visible = True
        btnSave.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Enabled = False
        txtPassword.Enabled = False
        txtEmail.Enabled = False
        txtCPassword.Enabled = False
        txtPhone.Enabled = False
        txtAddress1.Enabled = False
    End Sub
End Class