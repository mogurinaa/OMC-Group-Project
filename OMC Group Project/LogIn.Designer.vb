<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Me.pnlWinControl = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.pnlRegOption = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelReg = New System.Windows.Forms.PictureBox()
        Me.btnNewComp = New System.Windows.Forms.PictureBox()
        Me.btnNewUser = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnlWinControl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegOption.SuspendLayout()
        CType(Me.btnCancelReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlWinControl
        '
        Me.pnlWinControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnlWinControl.Controls.Add(Me.btnMinimise)
        Me.pnlWinControl.Controls.Add(Me.btnMaximize)
        Me.pnlWinControl.Controls.Add(Me.btnClose)
        Me.pnlWinControl.Controls.Add(Me.PictureBox2)
        Me.pnlWinControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlWinControl.Name = "pnlWinControl"
        Me.pnlWinControl.Size = New System.Drawing.Size(450, 25)
        Me.pnlWinControl.TabIndex = 8
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderSize = 0
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Image = Global.OMC_Group_Project.My.Resources.Resources.Minimise
        Me.btnMinimise.Location = New System.Drawing.Point(376, 0)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(27, 24)
        Me.btnMinimise.TabIndex = 22
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Enabled = False
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.OMC_Group_Project.My.Resources.Resources.Maximize
        Me.btnMaximize.Location = New System.Drawing.Point(400, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(27, 24)
        Me.btnMaximize.TabIndex = 21
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.OMC_Group_Project.My.Resources.Resources.Close
        Me.btnClose.Location = New System.Drawing.Point(424, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 24)
        Me.btnClose.TabIndex = 20
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
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(48, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Welcome to MAME Travel!"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(94, 215)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(260, 27)
        Me.txtUsername.TabIndex = 11
        Me.txtUsername.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(94, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 3)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(94, 306)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 3)
        Me.Panel2.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(94, 273)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(260, 27)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(99, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 28)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Don't have an account yet?"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(119, 497)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(207, 28)
        Me.lblRegister.TabIndex = 18
        Me.lblRegister.Text = "Click here to register!"
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgot.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgot.Location = New System.Drawing.Point(135, 426)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(178, 28)
        Me.lblForgot.TabIndex = 21
        Me.lblForgot.Text = "Forgot Password?"
        '
        'pnlRegOption
        '
        Me.pnlRegOption.Controls.Add(Me.Label3)
        Me.pnlRegOption.Controls.Add(Me.btnCancelReg)
        Me.pnlRegOption.Controls.Add(Me.btnNewComp)
        Me.pnlRegOption.Controls.Add(Me.btnNewUser)
        Me.pnlRegOption.Location = New System.Drawing.Point(0, 24)
        Me.pnlRegOption.Name = "pnlRegOption"
        Me.pnlRegOption.Size = New System.Drawing.Size(451, 541)
        Me.pnlRegOption.TabIndex = 22
        Me.pnlRegOption.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(100, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Register New Account"
        '
        'btnCancelReg
        '
        Me.btnCancelReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelReg.Image = Global.OMC_Group_Project.My.Resources.Resources.btnCancelReg
        Me.btnCancelReg.Location = New System.Drawing.Point(124, 420)
        Me.btnCancelReg.Name = "btnCancelReg"
        Me.btnCancelReg.Size = New System.Drawing.Size(190, 50)
        Me.btnCancelReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelReg.TabIndex = 2
        Me.btnCancelReg.TabStop = False
        '
        'btnNewComp
        '
        Me.btnNewComp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewComp.Image = Global.OMC_Group_Project.My.Resources.Resources.btnNewComp
        Me.btnNewComp.Location = New System.Drawing.Point(124, 245)
        Me.btnNewComp.Name = "btnNewComp"
        Me.btnNewComp.Size = New System.Drawing.Size(190, 50)
        Me.btnNewComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNewComp.TabIndex = 1
        Me.btnNewComp.TabStop = False
        '
        'btnNewUser
        '
        Me.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewUser.Image = Global.OMC_Group_Project.My.Resources.Resources.btnNewUser
        Me.btnNewUser.Location = New System.Drawing.Point(124, 189)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(190, 50)
        Me.btnNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNewUser.TabIndex = 0
        Me.btnNewUser.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Image = Global.OMC_Group_Project.My.Resources.Resources.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(162, 352)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(120, 50)
        Me.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OMC_Group_Project.My.Resources.Resources.MAME_Logo_no_text
        Me.PictureBox1.Location = New System.Drawing.Point(152, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.OMC_Group_Project.My.Resources.Resources.tree_svg
        Me.PictureBox3.Location = New System.Drawing.Point(55, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(592, 608)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 565)
        Me.Controls.Add(Me.pnlWinControl)
        Me.Controls.Add(Me.pnlRegOption)
        Me.Controls.Add(Me.lblForgot)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAME Travel"
        Me.pnlWinControl.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegOption.ResumeLayout(False)
        Me.pnlRegOption.PerformLayout()
        CType(Me.btnCancelReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents pnlWinControl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents btnLogin As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnMinimise As Button
    Friend WithEvents lblForgot As Label
    Friend WithEvents pnlRegOption As Panel
    Friend WithEvents btnNewComp As PictureBox
    Friend WithEvents btnNewUser As PictureBox
    Friend WithEvents btnCancelReg As PictureBox
    Friend WithEvents Label3 As Label
End Class
