<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_Confirmation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnMaximise = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.txtTravelPlan = New System.Windows.Forms.TextBox()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtOnlineBanking = New System.Windows.Forms.RadioButton()
        Me.rbtEWallet = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlControl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnlControl.Controls.Add(Me.btnMinimise)
        Me.pnlControl.Controls.Add(Me.btnMaximise)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Controls.Add(Me.PictureBox2)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(879, 25)
        Me.pnlControl.TabIndex = 3
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderSize = 0
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Image = Global.OMC_Group_Project.My.Resources.Resources.Minimise
        Me.btnMinimise.Location = New System.Drawing.Point(800, 0)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(27, 24)
        Me.btnMinimise.TabIndex = 25
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'btnMaximise
        '
        Me.btnMaximise.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximise.Enabled = False
        Me.btnMaximise.FlatAppearance.BorderSize = 0
        Me.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximise.Image = Global.OMC_Group_Project.My.Resources.Resources.Maximize
        Me.btnMaximise.Location = New System.Drawing.Point(824, 0)
        Me.btnMaximise.Name = "btnMaximise"
        Me.btnMaximise.Size = New System.Drawing.Size(27, 24)
        Me.btnMaximise.TabIndex = 24
        Me.btnMaximise.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.OMC_Group_Project.My.Resources.Resources.Close
        Me.btnClose.Location = New System.Drawing.Point(849, 0)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Travel Plan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Person :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date Start :"
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(161, 149)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(246, 22)
        Me.dateStart.TabIndex = 7
        Me.dateStart.Value = New Date(2022, 6, 23, 12, 0, 0, 0)
        '
        'txtTravelPlan
        '
        Me.txtTravelPlan.Location = New System.Drawing.Point(161, 109)
        Me.txtTravelPlan.Name = "txtTravelPlan"
        Me.txtTravelPlan.ReadOnly = True
        Me.txtTravelPlan.Size = New System.Drawing.Size(246, 22)
        Me.txtTravelPlan.TabIndex = 8
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(161, 189)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(74, 22)
        Me.txtPerson.TabIndex = 9
        Me.txtPerson.Text = "1"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(161, 282)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalPrice.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Price :"
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(597, 149)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(246, 22)
        Me.dateEnd.TabIndex = 13
        Me.dateEnd.Value = New Date(2022, 6, 23, 12, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date End :"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(161, 243)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.ReadOnly = True
        Me.txtDays.Size = New System.Drawing.Size(51, 22)
        Me.txtDays.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Days :"
        '
        'rbtOnlineBanking
        '
        Me.rbtOnlineBanking.AutoSize = True
        Me.rbtOnlineBanking.Location = New System.Drawing.Point(19, 30)
        Me.rbtOnlineBanking.Name = "rbtOnlineBanking"
        Me.rbtOnlineBanking.Size = New System.Drawing.Size(118, 20)
        Me.rbtOnlineBanking.TabIndex = 16
        Me.rbtOnlineBanking.TabStop = True
        Me.rbtOnlineBanking.Text = "Online Banking"
        Me.rbtOnlineBanking.UseVisualStyleBackColor = True
        '
        'rbtEWallet
        '
        Me.rbtEWallet.AutoSize = True
        Me.rbtEWallet.Location = New System.Drawing.Point(19, 56)
        Me.rbtEWallet.Name = "rbtEWallet"
        Me.rbtEWallet.Size = New System.Drawing.Size(79, 20)
        Me.rbtEWallet.TabIndex = 17
        Me.rbtEWallet.TabStop = True
        Me.rbtEWallet.Text = "E-Wallet"
        Me.rbtEWallet.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Image = Global.OMC_Group_Project.My.Resources.Resources.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(295, 365)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(263, 70)
        Me.btnConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnConfirm.TabIndex = 18
        Me.btnConfirm.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtOnlineBanking)
        Me.GroupBox1.Controls.Add(Me.rbtEWallet)
        Me.GroupBox1.Location = New System.Drawing.Point(495, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Method"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(327, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 35)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Confirm Booking"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Booking_Confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 474)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dateEnd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPerson)
        Me.Controls.Add(Me.txtTravelPlan)
        Me.Controls.Add(Me.dateStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking_Confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking_Confirmation"
        Me.pnlControl.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimise As Button
    Friend WithEvents btnMaximise As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateStart As DateTimePicker
    Friend WithEvents txtTravelPlan As TextBox
    Friend WithEvents txtPerson As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dateEnd As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbtOnlineBanking As RadioButton
    Friend WithEvents rbtEWallet As RadioButton
    Friend WithEvents btnConfirm As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
