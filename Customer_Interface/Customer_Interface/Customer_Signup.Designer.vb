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
        Me.City = New System.Windows.Forms.TextBox()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.street = New System.Windows.Forms.TextBox()
        Me.zip = New System.Windows.Forms.TextBox()
        Me.streetNum = New System.Windows.Forms.TextBox()
        Me.aptNum = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cardType = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personal Information"
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(19, 31)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(252, 20)
        Me.firstName.TabIndex = 2
        Me.firstName.Text = "First Name"
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(277, 31)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(257, 20)
        Me.lastName.TabIndex = 3
        Me.lastName.Text = "Last Name"
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(19, 224)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(173, 20)
        Me.City.TabIndex = 4
        Me.City.Text = "City"
        '
        'state
        '
        Me.state.Location = New System.Drawing.Point(198, 223)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(196, 20)
        Me.state.TabIndex = 5
        Me.state.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address"
        '
        'street
        '
        Me.street.Location = New System.Drawing.Point(126, 197)
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(302, 20)
        Me.street.TabIndex = 7
        Me.street.Text = "Street"
        '
        'zip
        '
        Me.zip.Location = New System.Drawing.Point(400, 223)
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(134, 20)
        Me.zip.TabIndex = 8
        Me.zip.Text = "ZIP code"
        '
        'streetNum
        '
        Me.streetNum.Location = New System.Drawing.Point(19, 197)
        Me.streetNum.Name = "streetNum"
        Me.streetNum.Size = New System.Drawing.Size(100, 20)
        Me.streetNum.TabIndex = 9
        Me.streetNum.Text = "Street Number"
        '
        'aptNum
        '
        Me.aptNum.Location = New System.Drawing.Point(434, 197)
        Me.aptNum.Name = "aptNum"
        Me.aptNum.Size = New System.Drawing.Size(100, 20)
        Me.aptNum.TabIndex = 10
        Me.aptNum.Text = "Apartment Number"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(19, 58)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(515, 20)
        Me.email.TabIndex = 11
        Me.email.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Payment Information"
        '
        'cardType
        '
        Me.cardType.Location = New System.Drawing.Point(19, 294)
        Me.cardType.Name = "cardType"
        Me.cardType.Size = New System.Drawing.Size(121, 20)
        Me.cardType.TabIndex = 13
        Me.cardType.Text = "Card Type"
        '
        'cardNum
        '
        Me.cardNum.Location = New System.Drawing.Point(146, 294)
        Me.cardNum.Name = "cardNum"
        Me.cardNum.Size = New System.Drawing.Size(207, 20)
        Me.cardNum.TabIndex = 14
        Me.cardNum.Text = "Credit Card Number"
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(146, 84)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(125, 20)
        Me.num1.TabIndex = 15
        Me.num1.Text = "Phone Number"
        '
        'phoneDrop1
        '
        Me.phoneDrop1.AllowDrop = True
        Me.phoneDrop1.FormattingEnabled = True
        Me.phoneDrop1.Items.AddRange(New Object() {"Home", "Work", "Mobile"})
        Me.phoneDrop1.Location = New System.Drawing.Point(19, 84)
        Me.phoneDrop1.Name = "phoneDrop1"
        Me.phoneDrop1.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop1.TabIndex = 16
        Me.phoneDrop1.Text = "Type"
        '
        'phoneDrop2
        '
        Me.phoneDrop2.AllowDrop = True
        Me.phoneDrop2.FormattingEnabled = True
        Me.phoneDrop2.Items.AddRange(New Object() {"Home", "Work", "Mobile"})
        Me.phoneDrop2.Location = New System.Drawing.Point(19, 111)
        Me.phoneDrop2.Name = "phoneDrop2"
        Me.phoneDrop2.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop2.TabIndex = 17
        Me.phoneDrop2.Text = "Type"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(146, 112)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(125, 20)
        Me.num2.TabIndex = 18
        Me.num2.Text = "Phone Number"
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(146, 139)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(125, 20)
        Me.num3.TabIndex = 20
        Me.num3.Text = "Phone Number"
        '
        'phoneDrop3
        '
        Me.phoneDrop3.AllowDrop = True
        Me.phoneDrop3.FormattingEnabled = True
        Me.phoneDrop3.Items.AddRange(New Object() {"Home", "Work", "Mobile"})
        Me.phoneDrop3.Location = New System.Drawing.Point(19, 138)
        Me.phoneDrop3.Name = "phoneDrop3"
        Me.phoneDrop3.Size = New System.Drawing.Size(121, 21)
        Me.phoneDrop3.TabIndex = 19
        Me.phoneDrop3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Membership"
        '
        'limited
        '
        Me.limited.AutoSize = True
        Me.limited.Location = New System.Drawing.Point(22, 365)
        Me.limited.Name = "limited"
        Me.limited.Size = New System.Drawing.Size(58, 17)
        Me.limited.TabIndex = 22
        Me.limited.TabStop = True
        Me.limited.Text = "Limited"
        Me.limited.UseVisualStyleBackColor = True
        '
        'unlim1
        '
        Me.unlim1.AutoSize = True
        Me.unlim1.Location = New System.Drawing.Point(102, 365)
        Me.unlim1.Name = "unlim1"
        Me.unlim1.Size = New System.Drawing.Size(77, 17)
        Me.unlim1.TabIndex = 23
        Me.unlim1.TabStop = True
        Me.unlim1.Text = "Unlimited 1"
        Me.unlim1.UseVisualStyleBackColor = True
        '
        'unlim2
        '
        Me.unlim2.AutoSize = True
        Me.unlim2.Location = New System.Drawing.Point(198, 365)
        Me.unlim2.Name = "unlim2"
        Me.unlim2.Size = New System.Drawing.Size(77, 17)
        Me.unlim2.TabIndex = 24
        Me.unlim2.TabStop = True
        Me.unlim2.Text = "Unlimited 2"
        Me.unlim2.UseVisualStyleBackColor = True
        '
        'unlim3
        '
        Me.unlim3.AutoSize = True
        Me.unlim3.Location = New System.Drawing.Point(296, 365)
        Me.unlim3.Name = "unlim3"
        Me.unlim3.Size = New System.Drawing.Size(77, 17)
        Me.unlim3.TabIndex = 25
        Me.unlim3.TabStop = True
        Me.unlim3.Text = "Unlimited 3"
        Me.unlim3.UseVisualStyleBackColor = True
        '
        'Customer_SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 407)
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
        Me.Controls.Add(Me.cardType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.aptNum)
        Me.Controls.Add(Me.streetNum)
        Me.Controls.Add(Me.zip)
        Me.Controls.Add(Me.street)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Customer_SignUp"
        Me.Text = "New Customer Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents state As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents street As TextBox
    Friend WithEvents zip As TextBox
    Friend WithEvents streetNum As TextBox
    Friend WithEvents aptNum As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cardType As TextBox
    Friend WithEvents cardNum As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents phoneDrop1 As ComboBox
    Friend WithEvents phoneDrop2 As ComboBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents num3 As TextBox
    Friend WithEvents phoneDrop3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents limited As RadioButton
    Friend WithEvents unlim1 As RadioButton
    Friend WithEvents unlim2 As RadioButton
    Friend WithEvents unlim3 As RadioButton
End Class
