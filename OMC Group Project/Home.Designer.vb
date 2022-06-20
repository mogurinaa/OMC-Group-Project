<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnTravelPlan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlTravelPlan = New System.Windows.Forms.Panel()
        Me.lblCost2 = New System.Windows.Forms.Label()
        Me.lblLocation2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblCompany2 = New System.Windows.Forms.Label()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.lblTravel2 = New System.Windows.Forms.Label()
        Me.lblCost1 = New System.Windows.Forms.Label()
        Me.lblLocation1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblCompany1 = New System.Windows.Forms.Label()
        Me.lblDesc1 = New System.Windows.Forms.Label()
        Me.lblTravel1 = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.PictureBox()
        Me.btnUp = New System.Windows.Forms.PictureBox()
        Me.picTravel2 = New System.Windows.Forms.PictureBox()
        Me.pictRect2 = New System.Windows.Forms.PictureBox()
        Me.picTravel1 = New System.Windows.Forms.PictureBox()
        Me.pictRect = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.PictureBox()
        Me.pnlPlan2 = New OMC_Group_Project.Panel_VB(Me.components)
        Me.pnlPlan1 = New OMC_Group_Project.Panel_VB(Me.components)
        Me.panelMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTravelPlan.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTravel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictRect2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTravel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictRect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.panelMain.Controls.Add(Me.panelNav)
        Me.panelMain.Controls.Add(Me.btnLogOut)
        Me.panelMain.Controls.Add(Me.btnCSV)
        Me.panelMain.Controls.Add(Me.btnSettings)
        Me.panelMain.Controls.Add(Me.btnTravelPlan)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(200, 600)
        Me.panelMain.TabIndex = 9
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.Color.White
        Me.panelNav.Location = New System.Drawing.Point(0, 200)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(3, 100)
        Me.panelNav.TabIndex = 7
        '
        'btnLogOut
        '
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Image = Global.OMC_Group_Project.My.Resources.Resources.btnLogout
        Me.btnLogOut.Location = New System.Drawing.Point(0, 542)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 58)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCSV.FlatAppearance.BorderSize = 0
        Me.btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSV.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnCSV.ForeColor = System.Drawing.Color.White
        Me.btnCSV.Image = Global.OMC_Group_Project.My.Resources.Resources.btnCSV
        Me.btnCSV.Location = New System.Drawing.Point(0, 316)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(200, 58)
        Me.btnCSV.TabIndex = 5
        Me.btnCSV.Text = "Customer Service"
        Me.btnCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.OMC_Group_Project.My.Resources.Resources.btnSettings
        Me.btnSettings.Location = New System.Drawing.Point(0, 258)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(200, 58)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnTravelPlan
        '
        Me.btnTravelPlan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTravelPlan.FlatAppearance.BorderSize = 0
        Me.btnTravelPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTravelPlan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTravelPlan.ForeColor = System.Drawing.Color.White
        Me.btnTravelPlan.Image = Global.OMC_Group_Project.My.Resources.Resources.btnTravel
        Me.btnTravelPlan.Location = New System.Drawing.Point(0, 200)
        Me.btnTravelPlan.Name = "btnTravelPlan"
        Me.btnTravelPlan.Size = New System.Drawing.Size(200, 58)
        Me.btnTravelPlan.TabIndex = 3
        Me.btnTravelPlan.Text = "Travel Plan"
        Me.btnTravelPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTravelPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTravelPlan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 200)
        Me.Panel1.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(35, 158)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(126, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "<USERNAME>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.OMC_Group_Project.My.Resources.Resources.userIcon
        Me.PictureBox3.Location = New System.Drawing.Point(30, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(137, 101)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnMinimise)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 25)
        Me.Panel2.TabIndex = 1
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderSize = 0
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Image = Global.OMC_Group_Project.My.Resources.Resources.Minimise
        Me.btnMinimise.Location = New System.Drawing.Point(946, 0)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(27, 24)
        Me.btnMinimise.TabIndex = 24
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.OMC_Group_Project.My.Resources.Resources.Close
        Me.btnClose.Location = New System.Drawing.Point(970, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 24)
        Me.btnClose.TabIndex = 23
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.OMC_Group_Project.My.Resources.Resources.MAME_Logo_no_text
        Me.PictureBox2.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'pnlTravelPlan
        '
        Me.pnlTravelPlan.Controls.Add(Me.pnlPlan2)
        Me.pnlTravelPlan.Controls.Add(Me.pnlPlan1)
        Me.pnlTravelPlan.Controls.Add(Me.lblCost2)
        Me.pnlTravelPlan.Controls.Add(Me.lblLocation2)
        Me.pnlTravelPlan.Controls.Add(Me.PictureBox6)
        Me.pnlTravelPlan.Controls.Add(Me.lblCompany2)
        Me.pnlTravelPlan.Controls.Add(Me.lblDesc2)
        Me.pnlTravelPlan.Controls.Add(Me.lblTravel2)
        Me.pnlTravelPlan.Controls.Add(Me.lblCost1)
        Me.pnlTravelPlan.Controls.Add(Me.lblLocation1)
        Me.pnlTravelPlan.Controls.Add(Me.PictureBox5)
        Me.pnlTravelPlan.Controls.Add(Me.lblCompany1)
        Me.pnlTravelPlan.Controls.Add(Me.lblDesc1)
        Me.pnlTravelPlan.Controls.Add(Me.lblTravel1)
        Me.pnlTravelPlan.Controls.Add(Me.btnDown)
        Me.pnlTravelPlan.Controls.Add(Me.btnUp)
        Me.pnlTravelPlan.Controls.Add(Me.picTravel2)
        Me.pnlTravelPlan.Controls.Add(Me.pictRect2)
        Me.pnlTravelPlan.Controls.Add(Me.picTravel1)
        Me.pnlTravelPlan.Controls.Add(Me.pictRect)
        Me.pnlTravelPlan.Controls.Add(Me.PictureBox1)
        Me.pnlTravelPlan.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlTravelPlan.Location = New System.Drawing.Point(200, 135)
        Me.pnlTravelPlan.Name = "pnlTravelPlan"
        Me.pnlTravelPlan.Size = New System.Drawing.Size(800, 465)
        Me.pnlTravelPlan.TabIndex = 7
        '
        'lblCost2
        '
        Me.lblCost2.BackColor = System.Drawing.Color.White
        Me.lblCost2.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lblCost2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.lblCost2.Location = New System.Drawing.Point(472, 386)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Size = New System.Drawing.Size(232, 52)
        Me.lblCost2.TabIndex = 20
        Me.lblCost2.Text = "RM 0.00 per pax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for 1 day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCost2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocation2
        '
        Me.lblLocation2.BackColor = System.Drawing.Color.White
        Me.lblLocation2.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lblLocation2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.lblLocation2.Location = New System.Drawing.Point(245, 401)
        Me.lblLocation2.Name = "lblLocation2"
        Me.lblLocation2.Size = New System.Drawing.Size(232, 23)
        Me.lblLocation2.TabIndex = 19
        Me.lblLocation2.Text = "<Location 1>"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.OMC_Group_Project.My.Resources.Resources.locationIcon
        Me.PictureBox6.Location = New System.Drawing.Point(200, 388)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'lblCompany2
        '
        Me.lblCompany2.BackColor = System.Drawing.Color.White
        Me.lblCompany2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblCompany2.Location = New System.Drawing.Point(471, 258)
        Me.lblCompany2.Name = "lblCompany2"
        Me.lblCompany2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany2.Size = New System.Drawing.Size(241, 28)
        Me.lblCompany2.TabIndex = 17
        Me.lblCompany2.Text = "<Company Name 1>"
        Me.lblCompany2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesc2
        '
        Me.lblDesc2.BackColor = System.Drawing.Color.White
        Me.lblDesc2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblDesc2.Location = New System.Drawing.Point(213, 295)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(499, 95)
        Me.lblDesc2.TabIndex = 16
        Me.lblDesc2.Text = "<Travel Plan Description 1>"
        '
        'lblTravel2
        '
        Me.lblTravel2.BackColor = System.Drawing.Color.White
        Me.lblTravel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblTravel2.Location = New System.Drawing.Point(210, 258)
        Me.lblTravel2.Name = "lblTravel2"
        Me.lblTravel2.Size = New System.Drawing.Size(255, 30)
        Me.lblTravel2.TabIndex = 15
        Me.lblTravel2.Text = "<Travel Plan Name 2>"
        '
        'lblCost1
        '
        Me.lblCost1.BackColor = System.Drawing.Color.White
        Me.lblCost1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lblCost1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.lblCost1.Location = New System.Drawing.Point(474, 165)
        Me.lblCost1.Name = "lblCost1"
        Me.lblCost1.Size = New System.Drawing.Size(232, 52)
        Me.lblCost1.TabIndex = 14
        Me.lblCost1.Text = "RM 0.00 per pax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for 1 day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCost1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocation1
        '
        Me.lblLocation1.BackColor = System.Drawing.Color.White
        Me.lblLocation1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lblLocation1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.lblLocation1.Location = New System.Drawing.Point(247, 180)
        Me.lblLocation1.Name = "lblLocation1"
        Me.lblLocation1.Size = New System.Drawing.Size(232, 23)
        Me.lblLocation1.TabIndex = 13
        Me.lblLocation1.Text = "<Location 1>"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.OMC_Group_Project.My.Resources.Resources.locationIcon
        Me.PictureBox5.Location = New System.Drawing.Point(202, 165)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'lblCompany1
        '
        Me.lblCompany1.BackColor = System.Drawing.Color.White
        Me.lblCompany1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblCompany1.Location = New System.Drawing.Point(473, 37)
        Me.lblCompany1.Name = "lblCompany1"
        Me.lblCompany1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany1.Size = New System.Drawing.Size(241, 28)
        Me.lblCompany1.TabIndex = 11
        Me.lblCompany1.Text = "<Company Name 1>"
        Me.lblCompany1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesc1
        '
        Me.lblDesc1.BackColor = System.Drawing.Color.White
        Me.lblDesc1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblDesc1.Location = New System.Drawing.Point(215, 74)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(499, 95)
        Me.lblDesc1.TabIndex = 10
        Me.lblDesc1.Text = "<Travel Plan Description 1>"
        '
        'lblTravel1
        '
        Me.lblTravel1.BackColor = System.Drawing.Color.White
        Me.lblTravel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblTravel1.Location = New System.Drawing.Point(212, 37)
        Me.lblTravel1.Name = "lblTravel1"
        Me.lblTravel1.Size = New System.Drawing.Size(255, 30)
        Me.lblTravel1.TabIndex = 9
        Me.lblTravel1.Text = "<Travel Plan Name 1>"
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.Image = Global.OMC_Group_Project.My.Resources.Resources.btnDown
        Me.btnDown.Location = New System.Drawing.Point(734, 396)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(54, 48)
        Me.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDown.TabIndex = 8
        Me.btnDown.TabStop = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.Image = Global.OMC_Group_Project.My.Resources.Resources.btnUp
        Me.btnUp.Location = New System.Drawing.Point(734, 27)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(54, 48)
        Me.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUp.TabIndex = 7
        Me.btnUp.TabStop = False
        '
        'picTravel2
        '
        Me.picTravel2.Enabled = False
        Me.picTravel2.Image = Global.OMC_Group_Project.My.Resources.Resources.langkawi_hd
        Me.picTravel2.Location = New System.Drawing.Point(44, 253)
        Me.picTravel2.Name = "picTravel2"
        Me.picTravel2.Size = New System.Drawing.Size(152, 186)
        Me.picTravel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picTravel2.TabIndex = 5
        Me.picTravel2.TabStop = False
        '
        'pictRect2
        '
        Me.pictRect2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pictRect2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictRect2.Image = Global.OMC_Group_Project.My.Resources.Resources.Travel_Rectangle_BG
        Me.pictRect2.Location = New System.Drawing.Point(40, 249)
        Me.pictRect2.Name = "pictRect2"
        Me.pictRect2.Size = New System.Drawing.Size(688, 195)
        Me.pictRect2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictRect2.TabIndex = 6
        Me.pictRect2.TabStop = False
        '
        'picTravel1
        '
        Me.picTravel1.Enabled = False
        Me.picTravel1.Image = Global.OMC_Group_Project.My.Resources.Resources.langkawi_hd
        Me.picTravel1.Location = New System.Drawing.Point(44, 31)
        Me.picTravel1.Name = "picTravel1"
        Me.picTravel1.Size = New System.Drawing.Size(152, 186)
        Me.picTravel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picTravel1.TabIndex = 3
        Me.picTravel1.TabStop = False
        '
        'pictRect
        '
        Me.pictRect.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pictRect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictRect.Image = Global.OMC_Group_Project.My.Resources.Resources.Travel_Rectangle_BG
        Me.pictRect.Location = New System.Drawing.Point(40, 27)
        Me.pictRect.Name = "pictRect"
        Me.pictRect.Size = New System.Drawing.Size(688, 195)
        Me.pictRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictRect.TabIndex = 4
        Me.pictRect.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.OMC_Group_Project.My.Resources.Resources.HOME_Rectangle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Select your travel plan"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.OMC_Group_Project.My.Resources.Resources.travelLogo
        Me.PictureBox4.Location = New System.Drawing.Point(206, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(143, 89)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Image = Global.OMC_Group_Project.My.Resources.Resources.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(710, 49)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(263, 70)
        Me.btnConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.TabStop = False
        '
        'pnlPlan2
        '
        Me.pnlPlan2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPlan2.Location = New System.Drawing.Point(40, 249)
        Me.pnlPlan2.Name = "pnlPlan2"
        Me.pnlPlan2.Opacity = 0
        Me.pnlPlan2.Size = New System.Drawing.Size(688, 195)
        Me.pnlPlan2.TabIndex = 13
        '
        'pnlPlan1
        '
        Me.pnlPlan1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPlan1.Location = New System.Drawing.Point(40, 27)
        Me.pnlPlan1.Name = "pnlPlan1"
        Me.pnlPlan1.Opacity = 0
        Me.pnlPlan1.Size = New System.Drawing.Size(688, 195)
        Me.pnlPlan1.TabIndex = 12
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pnlTravelPlan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.panelMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTravelPlan.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTravel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictRect2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTravel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictRect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnCSV As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnTravelPlan As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTravelPlan As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picTravel1 As PictureBox
    Friend WithEvents picTravel2 As PictureBox
    Friend WithEvents pictRect2 As PictureBox
    Friend WithEvents pictRect As PictureBox
    Friend WithEvents panelNav As Panel
    Friend WithEvents btnMinimise As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUp As PictureBox
    Friend WithEvents btnDown As PictureBox
    Friend WithEvents lblCompany1 As Label
    Friend WithEvents lblDesc1 As Label
    Friend WithEvents lblTravel1 As Label
    Friend WithEvents lblCost1 As Label
    Friend WithEvents lblLocation1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblCost2 As Label
    Friend WithEvents lblLocation2 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblCompany2 As Label
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents lblTravel2 As Label
    Friend WithEvents pnlPlan1 As Panel_VB
    Friend WithEvents pnlPlan2 As Panel_VB
    Friend WithEvents btnConfirm As PictureBox
End Class
