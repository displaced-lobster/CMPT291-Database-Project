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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccessAccount = New System.Windows.Forms.Button()
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(341, 285)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(123, 23)
        Me.BtnCancel.TabIndex = 18
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'AccessAccount
        '
        Me.AccessAccount.Location = New System.Drawing.Point(341, 227)
        Me.AccessAccount.Name = "AccessAccount"
        Me.AccessAccount.Size = New System.Drawing.Size(123, 23)
        Me.AccessAccount.TabIndex = 15
        Me.AccessAccount.Text = "Login"
        Me.AccessAccount.UseVisualStyleBackColor = True
        '
        'passwd
        '
        Me.passwd.Location = New System.Drawing.Point(341, 186)
        Me.passwd.Name = "passwd"
        Me.passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwd.Size = New System.Drawing.Size(135, 20)
        Me.passwd.TabIndex = 14
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(341, 147)
        Me.username.MaxLength = 31
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(135, 20)
        Me.username.TabIndex = 13
        Me.username.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(363, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "LOGIN"
        '
        'Customer_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccessAccount)
        Me.Controls.Add(Me.passwd)
        Me.Controls.Add(Me.username)
        Me.Name = "Customer_Login"
        Me.Text = "Customer Home Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AccessAccount As Button
    Friend WithEvents passwd As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label3 As Label
End Class
