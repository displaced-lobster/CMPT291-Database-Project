<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Login
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.accessAccount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.forgotPwd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(78, 47)
        Me.username.MaxLength = 31
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(135, 20)
        Me.username.TabIndex = 0
        Me.username.WordWrap = False
        '
        'passwd
        '
        Me.passwd.Location = New System.Drawing.Point(78, 86)
        Me.passwd.Name = "passwd"
        Me.passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwd.Size = New System.Drawing.Size(135, 20)
        Me.passwd.TabIndex = 1
        '
        'accessAccount
        '
        Me.accessAccount.Location = New System.Drawing.Point(78, 127)
        Me.accessAccount.Name = "accessAccount"
        Me.accessAccount.Size = New System.Drawing.Size(123, 23)
        Me.accessAccount.TabIndex = 2
        Me.accessAccount.Text = "Login"
        Me.accessAccount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'forgotPwd
        '
        Me.forgotPwd.Location = New System.Drawing.Point(78, 157)
        Me.forgotPwd.Name = "forgotPwd"
        Me.forgotPwd.Size = New System.Drawing.Size(123, 23)
        Me.forgotPwd.TabIndex = 5
        Me.forgotPwd.Text = "Forgot my password"
        Me.forgotPwd.UseVisualStyleBackColor = True
        '
        'Customer_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 241)
        Me.Controls.Add(Me.forgotPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.accessAccount)
        Me.Controls.Add(Me.passwd)
        Me.Controls.Add(Me.username)
        Me.Name = "Customer_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As TextBox
    Friend WithEvents passwd As TextBox
    Friend WithEvents accessAccount As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents forgotPwd As Button
End Class
