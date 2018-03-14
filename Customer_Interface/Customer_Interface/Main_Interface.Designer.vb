<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Interface
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(52, 54)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(191, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Open Customer Home Page"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(52, 141)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(191, 23)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "Open Customer Rep"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(52, 112)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(191, 23)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Open Customer Login"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(52, 83)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(191, 23)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Open Customer Interactions"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(52, 170)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(191, 23)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "Open Customer Signup"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'Main_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 405)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Main_Interface"
        Me.Text = "Main Interface"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn5 As Button
End Class
