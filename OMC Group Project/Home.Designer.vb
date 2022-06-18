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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.picLangkawi = New System.Windows.Forms.PictureBox()
        Me.picPPerhentian = New System.Windows.Forms.PictureBox()
        Me.picCameron = New System.Windows.Forms.PictureBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picLangkawi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPPerhentian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCameron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State"
        '
        'cboState
        '
        Me.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Kuala Lumpur", "Pulau Penang", "Terengganu", "Kelantan", "Selangor", "Negeri Sembilan", "Sabah", "Sarawak", "Pahang", "Johor"})
        Me.cboState.Location = New System.Drawing.Point(230, 42)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(150, 24)
        Me.cboState.TabIndex = 2
        '
        'picLangkawi
        '
        Me.picLangkawi.Image = Global.OMC_Group_Project.My.Resources.Resources.photo_1637115873956_78b504f59de5
        Me.picLangkawi.Location = New System.Drawing.Point(0, 0)
        Me.picLangkawi.Margin = New System.Windows.Forms.Padding(0)
        Me.picLangkawi.Name = "picLangkawi"
        Me.picLangkawi.Size = New System.Drawing.Size(339, 61)
        Me.picLangkawi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLangkawi.TabIndex = 3
        Me.picLangkawi.TabStop = False
        '
        'picPPerhentian
        '
        Me.picPPerhentian.Image = Global.OMC_Group_Project.My.Resources.Resources.photo_1637115873956_78b504f59de5
        Me.picPPerhentian.Location = New System.Drawing.Point(0, 90)
        Me.picPPerhentian.Margin = New System.Windows.Forms.Padding(0)
        Me.picPPerhentian.Name = "picPPerhentian"
        Me.picPPerhentian.Size = New System.Drawing.Size(339, 61)
        Me.picPPerhentian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPPerhentian.TabIndex = 4
        Me.picPPerhentian.TabStop = False
        '
        'picCameron
        '
        Me.picCameron.Image = Global.OMC_Group_Project.My.Resources.Resources.photo_1637115873956_78b504f59de5
        Me.picCameron.Location = New System.Drawing.Point(0, 180)
        Me.picCameron.Margin = New System.Windows.Forms.Padding(0)
        Me.picCameron.Name = "picCameron"
        Me.picCameron.Size = New System.Drawing.Size(339, 61)
        Me.picCameron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCameron.TabIndex = 5
        Me.picCameron.TabStop = False
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(86, 110)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(48, 16)
        Me.lblTest.TabIndex = 6
        Me.lblTest.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_Group_Project.My.Resources.Resources.photo_1637115873956_78b504f59de5
        Me.PictureBox1.Location = New System.Drawing.Point(0, 270)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OMC_Group_Project.My.Resources.Resources.photo_1637115873956_78b504f59de5
        Me.PictureBox2.Location = New System.Drawing.Point(0, 360)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(339, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.picLangkawi)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.picPPerhentian)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.picCameron)
        Me.Panel1.Location = New System.Drawing.Point(418, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 529)
        Me.Panel1.TabIndex = 9
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.picLangkawi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPPerhentian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCameron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents picLangkawi As PictureBox
    Friend WithEvents picPPerhentian As PictureBox
    Friend WithEvents picCameron As PictureBox
    Friend WithEvents lblTest As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
