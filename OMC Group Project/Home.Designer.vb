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
        Me.panelNavigation = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnTravelPlan = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.pnlTravelPlan = New System.Windows.Forms.Panel()
        Me.panelNavigation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelNavigation
        '
        Me.panelNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.panelNavigation.Controls.Add(Me.btnLogOut)
        Me.panelNavigation.Controls.Add(Me.btnCSV)
        Me.panelNavigation.Controls.Add(Me.btnSettings)
        Me.panelNavigation.Controls.Add(Me.btnTravelPlan)
        Me.panelNavigation.Controls.Add(Me.Panel1)
        Me.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelNavigation.Location = New System.Drawing.Point(0, 0)
        Me.panelNavigation.Name = "panelNavigation"
        Me.panelNavigation.Size = New System.Drawing.Size(200, 600)
        Me.panelNavigation.TabIndex = 9
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
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.OMC_Group_Project.My.Resources.Resources.Sample_User_Icon
        Me.PictureBox3.Location = New System.Drawing.Point(30, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(137, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnlTravelPlan)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 25)
        Me.Panel2.TabIndex = 1
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
        'btnTravelPlan
        '
        Me.btnTravelPlan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTravelPlan.FlatAppearance.BorderSize = 0
        Me.btnTravelPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTravelPlan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTravelPlan.ForeColor = System.Drawing.Color.White
        Me.btnTravelPlan.Location = New System.Drawing.Point(0, 200)
        Me.btnTravelPlan.Name = "btnTravelPlan"
        Me.btnTravelPlan.Size = New System.Drawing.Size(200, 58)
        Me.btnTravelPlan.TabIndex = 3
        Me.btnTravelPlan.Text = "Travel Plan"
        Me.btnTravelPlan.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(0, 258)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(200, 58)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCSV.FlatAppearance.BorderSize = 0
        Me.btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSV.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnCSV.ForeColor = System.Drawing.Color.White
        Me.btnCSV.Location = New System.Drawing.Point(0, 316)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(200, 58)
        Me.btnCSV.TabIndex = 5
        Me.btnCSV.Text = "Customer Service"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(0, 542)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 58)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'pnlTravelPlan
        '
        Me.pnlTravelPlan.Location = New System.Drawing.Point(202, 23)
        Me.pnlTravelPlan.Name = "pnlTravelPlan"
        Me.pnlTravelPlan.Size = New System.Drawing.Size(798, 577)
        Me.pnlTravelPlan.TabIndex = 7
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelNavigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.panelNavigation.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelNavigation As Panel
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
End Class
