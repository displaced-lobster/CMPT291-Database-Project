<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test_Query_Page
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Answer1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Query"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Answer1
        '
        Me.Answer1.AutoSize = True
        Me.Answer1.Location = New System.Drawing.Point(221, 85)
        Me.Answer1.Name = "Answer1"
        Me.Answer1.Size = New System.Drawing.Size(37, 13)
        Me.Answer1.TabIndex = 1
        Me.Answer1.Text = "Result"
        '
        'Test_Query_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 388)
        Me.Controls.Add(Me.Answer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Test_Query_Page"
        Me.Text = "Test Query"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Answer1 As Label
End Class
