<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Customer_Account
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtPassCheck = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.unlim3 = New System.Windows.Forms.RadioButton()
        Me.unlim2 = New System.Windows.Forms.RadioButton()
        Me.unlim1 = New System.Windows.Forms.RadioButton()
        Me.limited = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.num3 = New System.Windows.Forms.TextBox()
        Me.phoneDrop3 = New System.Windows.Forms.ComboBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.phoneDrop2 = New System.Windows.Forms.ComboBox()
        Me.phoneDrop1 = New System.Windows.Forms.ComboBox()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.cardNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.aptNum = New System.Windows.Forms.TextBox()
        Me.streetNum = New System.Windows.Forms.TextBox()
        Me.zip = New System.Windows.Forms.TextBox()
        Me.street = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.state = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRem2 = New System.Windows.Forms.Button()
        Me.btnRem3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 543)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 23)
        Me.btnExit.TabIndex = 96
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtPassCheck
        '
        Me.txtPassCheck.Location = New System.Drawing.Point(106, 479)
        Me.txtPassCheck.MaxLength = 50
        Me.txtPassCheck.Name = "txtPassCheck"
        Me.txtPassCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassCheck.Size = New System.Drawing.Size(207, 20)
        Me.txtPassCheck.TabIndex = 123
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 482)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "Password again"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(106, 453)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(207, 20)
        Me.txtPass.TabIndex = 122
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 456)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "New Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(106, 427)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(207, 20)
        Me.txtUser.TabIndex = 121
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(19, 430)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(55, 13)
        Me.label16.TabIndex = 137
        Me.label16.Text = "Username"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 327)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "Credit Card"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(438, 255)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Zip"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "State"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Apt Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Street"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Street Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(278, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "First Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(218, 514)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 23)
        Me.btnSave.TabIndex = 124
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'unlim3
        '
        Me.unlim3.AutoSize = True
        Me.unlim3.Location = New System.Drawing.Point(296, 393)
        Me.unlim3.Name = "unlim3"
        Me.unlim3.Size = New System.Drawing.Size(77, 17)
        Me.unlim3.TabIndex = 119
        Me.unlim3.TabStop = True
        Me.unlim3.Text = "Unlimited 3"
        Me.unlim3.UseVisualStyleBackColor = True
        '
        'unlim2
        '
        Me.unlim2.AutoSize = True
        Me.unlim2.Location = New System.Drawing.Point(198, 393)
        Me.unlim2.Name = "unlim2"
        Me.unlim2.Size = New System.Drawing.Size(77, 17)
        Me.unlim2.TabIndex = 118
        Me.unlim2.TabStop = True
        Me.unlim2.Text = "Unlimited 2"
        Me.unlim2.UseVisualStyleBackColor = True
        '
        'unlim1
        '
        Me.unlim1.AutoSize = True
        Me.unlim1.Location = New System.Drawing.Point(102, 393)
        Me.unlim1.Name = "unlim1"
        Me.unlim1.Size = New System.Drawing.Size(77, 17)
        Me.unlim1.TabIndex = 117
        Me.unlim1.TabStop = True
        Me.unlim1.Text = "Unlimited 1"
        Me.unlim1.UseVisualStyleBackColor = True
        '
        'limited
        '
        Me.limited.AutoSize = True
        Me.limited.Location = New System.Drawing.Point(22, 393)
        Me.limited.Name = "limited"
        Me.limited.Size = New System.Drawing.Size(58, 17)
        Me.limited.TabIndex = 116
        Me.limited.TabStop = True
        Me.limited.Text = "Limited"
        Me.limited.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Membership"
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(22, 179)
        Me.num3.MaxLength = 11
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(125, 20)
        Me.num3.TabIndex = 106
        '
        'phoneDrop3
        '
        Me.phoneDrop3.AllowDrop = True
        Me.phoneDrop3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop3.FormattingEnabled = True
        Me.phoneDrop3.Items.AddRange(New Object() {"", "Home", "Work", "Mobile"})
        Me.phoneDrop3.Location = New System.Drawing.Point(152, 178)
        Me.phoneDrop3.MaxDropDownItems = 3
        Me.phoneDrop3.Name = "phoneDrop3"
        Me.phoneDrop3.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop3.TabIndex = 107
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(21, 151)
        Me.num2.MaxLength = 11
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(125, 20)
        Me.num2.TabIndex = 104
        '
        'phoneDrop2
        '
        Me.phoneDrop2.AllowDrop = True
        Me.phoneDrop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop2.FormattingEnabled = True
        Me.phoneDrop2.Items.AddRange(New Object() {"", "Home", "Work", "Mobile"})
        Me.phoneDrop2.Location = New System.Drawing.Point(152, 149)
        Me.phoneDrop2.MaxDropDownItems = 3
        Me.phoneDrop2.Name = "phoneDrop2"
        Me.phoneDrop2.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop2.TabIndex = 105
        '
        'phoneDrop1
        '
        Me.phoneDrop1.AllowDrop = True
        Me.phoneDrop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop1.FormattingEnabled = True
        Me.phoneDrop1.Items.AddRange(New Object() {"Home", "Work", "Mobile"})
        Me.phoneDrop1.Location = New System.Drawing.Point(152, 122)
        Me.phoneDrop1.MaxDropDownItems = 3
        Me.phoneDrop1.Name = "phoneDrop1"
        Me.phoneDrop1.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop1.TabIndex = 102
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(21, 122)
        Me.num1.MaxLength = 11
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(125, 20)
        Me.num1.TabIndex = 101
        '
        'cardNum
        '
        Me.cardNum.Location = New System.Drawing.Point(84, 324)
        Me.cardNum.MaxLength = 16
        Me.cardNum.Name = "cardNum"
        Me.cardNum.Size = New System.Drawing.Size(207, 20)
        Me.cardNum.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Payment Information"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(99, 68)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(436, 20)
        Me.email.TabIndex = 100
        '
        'aptNum
        '
        Me.aptNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.aptNum.Location = New System.Drawing.Point(466, 225)
        Me.aptNum.Name = "aptNum"
        Me.aptNum.Size = New System.Drawing.Size(68, 20)
        Me.aptNum.TabIndex = 111
        '
        'streetNum
        '
        Me.streetNum.Location = New System.Drawing.Point(93, 225)
        Me.streetNum.MaxLength = 9
        Me.streetNum.Name = "streetNum"
        Me.streetNum.Size = New System.Drawing.Size(60, 20)
        Me.streetNum.TabIndex = 108
        '
        'zip
        '
        Me.zip.Location = New System.Drawing.Point(466, 251)
        Me.zip.MaxLength = 6
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(68, 20)
        Me.zip.TabIndex = 114
        '
        'street
        '
        Me.street.Location = New System.Drawing.Point(200, 225)
        Me.street.MaxLength = 50
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(194, 20)
        Me.street.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Address"
        '
        'state
        '
        Me.state.Location = New System.Drawing.Point(274, 251)
        Me.state.MaxLength = 50
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(158, 20)
        Me.state.TabIndex = 113
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(46, 252)
        Me.city.MaxLength = 50
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(184, 20)
        Me.city.TabIndex = 112
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(341, 42)
        Me.lastName.MaxLength = 50
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(194, 20)
        Me.lastName.TabIndex = 99
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(83, 42)
        Me.firstName.MaxLength = 50
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(192, 20)
        Me.firstName.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Personal Information"
        '
        'btnRem2
        '
        Me.btnRem2.Location = New System.Drawing.Point(281, 149)
        Me.btnRem2.Name = "btnRem2"
        Me.btnRem2.Size = New System.Drawing.Size(102, 23)
        Me.btnRem2.TabIndex = 141
        Me.btnRem2.Text = "Remove Number"
        Me.btnRem2.UseVisualStyleBackColor = True
        '
        'btnRem3
        '
        Me.btnRem3.Location = New System.Drawing.Point(281, 178)
        Me.btnRem3.Name = "btnRem3"
        Me.btnRem3.Size = New System.Drawing.Size(102, 23)
        Me.btnRem3.TabIndex = 142
        Me.btnRem3.Text = "Remove Number"
        Me.btnRem3.UseVisualStyleBackColor = True
        '
        'Edit_Customer_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRem3)
        Me.Controls.Add(Me.btnRem2)
        Me.Controls.Add(Me.txtPassCheck)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.unlim3)
        Me.Controls.Add(Me.unlim2)
        Me.Controls.Add(Me.unlim1)
        Me.Controls.Add(Me.limited)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.phoneDrop3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.phoneDrop2)
        Me.Controls.Add(Me.phoneDrop1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.cardNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.aptNum)
        Me.Controls.Add(Me.streetNum)
        Me.Controls.Add(Me.zip)
        Me.Controls.Add(Me.street)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit_Customer_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Customer_Account"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPassCheck As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents unlim3 As RadioButton
    Friend WithEvents unlim2 As RadioButton
    Friend WithEvents unlim1 As RadioButton
    Friend WithEvents limited As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents num3 As TextBox
    Friend WithEvents phoneDrop3 As ComboBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents phoneDrop2 As ComboBox
    Private WithEvents phoneDrop1 As ComboBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents cardNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents aptNum As TextBox
    Friend WithEvents streetNum As TextBox
    Friend WithEvents zip As TextBox
    Friend WithEvents street As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents state As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents firstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRem2 As Button
    Friend WithEvents btnRem3 As Button
End Class
