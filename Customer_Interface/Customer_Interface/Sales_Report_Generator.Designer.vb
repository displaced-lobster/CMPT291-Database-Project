<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Report_Generator
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
        Me.month_label = New System.Windows.Forms.Label()
        Me.year_label = New System.Windows.Forms.Label()
        Me.month_textbox = New System.Windows.Forms.TextBox()
        Me.year_textbox = New System.Windows.Forms.TextBox()
        Me.month_format = New System.Windows.Forms.Label()
        Me.year_format = New System.Windows.Forms.Label()
        Me.total_income_label = New System.Windows.Forms.Label()
        Me.income_label = New System.Windows.Forms.Label()
        Me.close_button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'month_label
        '
        Me.month_label.AutoSize = True
        Me.month_label.Location = New System.Drawing.Point(14, 48)
        Me.month_label.Name = "month_label"
        Me.month_label.Size = New System.Drawing.Size(40, 13)
        Me.month_label.TabIndex = 0
        Me.month_label.Text = "Month:"
        '
        'year_label
        '
        Me.year_label.AutoSize = True
        Me.year_label.Location = New System.Drawing.Point(15, 82)
        Me.year_label.Name = "year_label"
        Me.year_label.Size = New System.Drawing.Size(32, 13)
        Me.year_label.TabIndex = 1
        Me.year_label.Text = "Year:"
        '
        'month_textbox
        '
        Me.month_textbox.Location = New System.Drawing.Point(62, 45)
        Me.month_textbox.Name = "month_textbox"
        Me.month_textbox.Size = New System.Drawing.Size(31, 20)
        Me.month_textbox.TabIndex = 2
        '
        'year_textbox
        '
        Me.year_textbox.Location = New System.Drawing.Point(62, 79)
        Me.year_textbox.Name = "year_textbox"
        Me.year_textbox.Size = New System.Drawing.Size(43, 20)
        Me.year_textbox.TabIndex = 3
        '
        'month_format
        '
        Me.month_format.AutoSize = True
        Me.month_format.Location = New System.Drawing.Point(111, 45)
        Me.month_format.Name = "month_format"
        Me.month_format.Size = New System.Drawing.Size(69, 13)
        Me.month_format.TabIndex = 4
        Me.month_format.Text = "(Format: MM)"
        '
        'year_format
        '
        Me.year_format.AutoSize = True
        Me.year_format.Location = New System.Drawing.Point(111, 82)
        Me.year_format.Name = "year_format"
        Me.year_format.Size = New System.Drawing.Size(79, 13)
        Me.year_format.TabIndex = 5
        Me.year_format.Text = "(Format: YYYY)"
        '
        'total_income_label
        '
        Me.total_income_label.AutoSize = True
        Me.total_income_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_income_label.Location = New System.Drawing.Point(15, 113)
        Me.total_income_label.Name = "total_income_label"
        Me.total_income_label.Size = New System.Drawing.Size(118, 20)
        Me.total_income_label.TabIndex = 6
        Me.total_income_label.Text = "Total Income: $"
        '
        'income_label
        '
        Me.income_label.AutoSize = True
        Me.income_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.income_label.Location = New System.Drawing.Point(139, 113)
        Me.income_label.Name = "income_label"
        Me.income_label.Size = New System.Drawing.Size(18, 20)
        Me.income_label.TabIndex = 7
        Me.income_label.Text = "0"
        '
        'close_button
        '
        Me.close_button.Location = New System.Drawing.Point(18, 13)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(75, 23)
        Me.close_button.TabIndex = 8
        Me.close_button.Text = "Close"
        Me.close_button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Execute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sales_Report_Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 688)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.close_button)
        Me.Controls.Add(Me.income_label)
        Me.Controls.Add(Me.total_income_label)
        Me.Controls.Add(Me.year_format)
        Me.Controls.Add(Me.month_format)
        Me.Controls.Add(Me.year_textbox)
        Me.Controls.Add(Me.month_textbox)
        Me.Controls.Add(Me.year_label)
        Me.Controls.Add(Me.month_label)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sales_Report_Generator"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sales Report Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents month_label As Label
    Friend WithEvents year_label As Label
    Friend WithEvents month_textbox As TextBox
    Friend WithEvents year_textbox As TextBox
    Friend WithEvents month_format As Label
    Friend WithEvents year_format As Label
    Friend WithEvents total_income_label As Label
    Friend WithEvents income_label As Label
    Friend WithEvents close_button As Button
    Friend WithEvents Button1 As Button
End Class
