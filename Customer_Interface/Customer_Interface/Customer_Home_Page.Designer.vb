<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Home_Page
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
        Me.create = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.query = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'create
        '
        Me.create.Location = New System.Drawing.Point(582, 12)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(100, 23)
        Me.create.TabIndex = 0
        Me.create.Text = "Create Account"
        Me.create.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(688, 12)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(100, 23)
        Me.login.TabIndex = 1
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'query
        '
        Me.query.Location = New System.Drawing.Point(16, 46)
        Me.query.Name = "query"
        Me.query.Size = New System.Drawing.Size(100, 20)
        Me.query.TabIndex = 2
        Me.query.Text = "Keywords"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Movies"
        '
        'Customer_Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.query)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.create)
        Me.Name = "Customer_Home_Page"
        Me.Text = "Customer Home Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents create As Button
    Friend WithEvents login As Button
    Friend WithEvents query As TextBox
    Friend WithEvents Label1 As Label
End Class
