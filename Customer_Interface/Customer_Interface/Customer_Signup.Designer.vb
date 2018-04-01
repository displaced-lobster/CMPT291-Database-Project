<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_SignUp
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
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.street = New System.Windows.Forms.TextBox()
        Me.zip = New System.Windows.Forms.TextBox()
        Me.streetNum = New System.Windows.Forms.TextBox()
        Me.aptNum = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cardNum = New System.Windows.Forms.TextBox()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.phoneDrop1 = New System.Windows.Forms.ComboBox()
        Me.phoneDrop2 = New System.Windows.Forms.ComboBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.num3 = New System.Windows.Forms.TextBox()
        Me.phoneDrop3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.limited = New System.Windows.Forms.RadioButton()
        Me.unlim1 = New System.Windows.Forms.RadioButton()
        Me.unlim2 = New System.Windows.Forms.RadioButton()
        Me.unlim3 = New System.Windows.Forms.RadioButton()
        Me.createAccount = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPassCheck = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personal Information"
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(82, 52)
        Me.firstName.MaxLength = 50
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(192, 20)
        Me.firstName.TabIndex = 1
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(340, 52)
        Me.lastName.MaxLength = 50
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(194, 20)
        Me.lastName.TabIndex = 2
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(45, 262)
        Me.city.MaxLength = 50
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(184, 20)
        Me.city.TabIndex = 13
        '
        'state
        '
        Me.state.Location = New System.Drawing.Point(273, 261)
        Me.state.MaxLength = 50
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(158, 20)
        Me.state.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address"
        '
        'street
        '
        Me.street.Location = New System.Drawing.Point(199, 235)
        Me.street.MaxLength = 50
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(194, 20)
        Me.street.TabIndex = 11
        '
        'zip
        '
        Me.zip.Location = New System.Drawing.Point(465, 261)
        Me.zip.MaxLength = 6
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(68, 20)
        Me.zip.TabIndex = 15
        '
        'streetNum
        '
        Me.streetNum.Location = New System.Drawing.Point(92, 235)
        Me.streetNum.MaxLength = 9
        Me.streetNum.Name = "streetNum"
        Me.streetNum.Size = New System.Drawing.Size(60, 20)
        Me.streetNum.TabIndex = 10
        '
        'aptNum
        '
        Me.aptNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.aptNum.Location = New System.Drawing.Point(465, 235)
        Me.aptNum.Name = "aptNum"
        Me.aptNum.Size = New System.Drawing.Size(68, 20)
        Me.aptNum.TabIndex = 12
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(98, 78)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(436, 20)
        Me.email.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Payment Information"
        '
        'cardNum
        '
        Me.cardNum.Location = New System.Drawing.Point(83, 334)
        Me.cardNum.MaxLength = 16
        Me.cardNum.Name = "cardNum"
        Me.cardNum.Size = New System.Drawing.Size(207, 20)
        Me.cardNum.TabIndex = 16
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(20, 132)
        Me.num1.MaxLength = 11
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(125, 20)
        Me.num1.TabIndex = 4
        '
        'phoneDrop1
        '
        Me.phoneDrop1.AllowDrop = True
        Me.phoneDrop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop1.FormattingEnabled = True
        Me.phoneDrop1.Items.AddRange(New Object() {"Home", "Work", "Cell"})
        Me.phoneDrop1.Location = New System.Drawing.Point(151, 132)
        Me.phoneDrop1.MaxDropDownItems = 3
        Me.phoneDrop1.Name = "phoneDrop1"
        Me.phoneDrop1.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop1.TabIndex = 5
        '
        'phoneDrop2
        '
        Me.phoneDrop2.AllowDrop = True
        Me.phoneDrop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop2.FormattingEnabled = True
        Me.phoneDrop2.Items.AddRange(New Object() {"Home", "Work", "Cell"})
        Me.phoneDrop2.Location = New System.Drawing.Point(151, 157)
        Me.phoneDrop2.MaxDropDownItems = 3
        Me.phoneDrop2.Name = "phoneDrop2"
        Me.phoneDrop2.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop2.TabIndex = 7
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(20, 158)
        Me.num2.MaxLength = 11
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(125, 20)
        Me.num2.TabIndex = 6
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(20, 185)
        Me.num3.MaxLength = 11
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(125, 20)
        Me.num3.TabIndex = 8
        '
        'phoneDrop3
        '
        Me.phoneDrop3.AllowDrop = True
        Me.phoneDrop3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.phoneDrop3.FormattingEnabled = True
        Me.phoneDrop3.Items.AddRange(New Object() {"Home", "Work", "Cell"})
        Me.phoneDrop3.Location = New System.Drawing.Point(151, 186)
        Me.phoneDrop3.MaxDropDownItems = 3
        Me.phoneDrop3.Name = "phoneDrop3"
        Me.phoneDrop3.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Membership"
        '
        'limited
        '
        Me.limited.AutoSize = True
        Me.limited.Location = New System.Drawing.Point(21, 403)
        Me.limited.Name = "limited"
        Me.limited.Size = New System.Drawing.Size(58, 17)
        Me.limited.TabIndex = 17
        Me.limited.TabStop = True
        Me.limited.Text = "Limited"
        Me.limited.UseVisualStyleBackColor = True
        '
        'unlim1
        '
        Me.unlim1.AutoSize = True
        Me.unlim1.Location = New System.Drawing.Point(101, 403)
        Me.unlim1.Name = "unlim1"
        Me.unlim1.Size = New System.Drawing.Size(77, 17)
        Me.unlim1.TabIndex = 18
        Me.unlim1.TabStop = True
        Me.unlim1.Text = "Unlimited 1"
        Me.unlim1.UseVisualStyleBackColor = True
        '
        'unlim2
        '
        Me.unlim2.AutoSize = True
        Me.unlim2.Location = New System.Drawing.Point(197, 403)
        Me.unlim2.Name = "unlim2"
        Me.unlim2.Size = New System.Drawing.Size(77, 17)
        Me.unlim2.TabIndex = 19
        Me.unlim2.TabStop = True
        Me.unlim2.Text = "Unlimited 2"
        Me.unlim2.UseVisualStyleBackColor = True
        '
        'unlim3
        '
        Me.unlim3.AutoSize = True
        Me.unlim3.Location = New System.Drawing.Point(295, 403)
        Me.unlim3.Name = "unlim3"
        Me.unlim3.Size = New System.Drawing.Size(77, 17)
        Me.unlim3.TabIndex = 20
        Me.unlim3.TabStop = True
        Me.unlim3.Text = "Unlimited 3"
        Me.unlim3.UseVisualStyleBackColor = True
        '
        'createAccount
        '
        Me.createAccount.Enabled = False
        Me.createAccount.Location = New System.Drawing.Point(217, 524)
        Me.createAccount.Name = "createAccount"
        Me.createAccount.Size = New System.Drawing.Size(118, 23)
        Me.createAccount.TabIndex = 24
        Me.createAccount.Text = "Create Account"
        Me.createAccount.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(148, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Street Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Street"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(396, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Apt Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(235, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "State"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(437, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Zip"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 337)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Credit Card"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(18, 440)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(55, 13)
        Me.label16.TabIndex = 40
        Me.label16.Text = "Username"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(105, 437)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(207, 20)
        Me.txtUser.TabIndex = 21
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(105, 463)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(207, 20)
        Me.txtPass.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 466)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Password"
        '
        'txtPassCheck
        '
        Me.txtPassCheck.Location = New System.Drawing.Point(105, 489)
        Me.txtPassCheck.MaxLength = 50
        Me.txtPassCheck.Name = "txtPassCheck"
        Me.txtPassCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassCheck.Size = New System.Drawing.Size(207, 20)
        Me.txtPassCheck.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 492)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Password again"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(217, 553)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(118, 23)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Customer_SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
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
        Me.Controls.Add(Me.createAccount)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer_SignUp"
        Me.Text = "New Customer Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents state As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents street As TextBox
    Friend WithEvents zip As TextBox
    Friend WithEvents streetNum As TextBox
    Friend WithEvents aptNum As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cardNum As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents phoneDrop2 As ComboBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents num3 As TextBox
    Friend WithEvents phoneDrop3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents limited As RadioButton
    Friend WithEvents unlim1 As RadioButton
    Friend WithEvents unlim2 As RadioButton
    Friend WithEvents unlim3 As RadioButton
    Friend WithEvents createAccount As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents label16 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label18 As Label
    Private WithEvents phoneDrop1 As ComboBox
    Friend WithEvents txtPassCheck As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnCancel As Button
End Class
