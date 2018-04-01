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
        Me.month_label.Location = New System.Drawing.Point(21, 74)
        Me.month_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.month_label.Name = "month_label"
        Me.month_label.Size = New System.Drawing.Size(58, 20)
        Me.month_label.TabIndex = 0
        Me.month_label.Text = "Month:"
        '
        'year_label
        '
        Me.year_label.AutoSize = True
        Me.year_label.Location = New System.Drawing.Point(22, 126)
        Me.year_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.year_label.Name = "year_label"
        Me.year_label.Size = New System.Drawing.Size(47, 20)
        Me.year_label.TabIndex = 1
        Me.year_label.Text = "Year:"
        '
        'month_textbox
        '
        Me.month_textbox.Location = New System.Drawing.Point(93, 69)
        Me.month_textbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.month_textbox.Name = "month_textbox"
        Me.month_textbox.Size = New System.Drawing.Size(44, 26)
        Me.month_textbox.TabIndex = 2
        '
        'year_textbox
        '
        Me.year_textbox.Location = New System.Drawing.Point(93, 122)
        Me.year_textbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.year_textbox.Name = "year_textbox"
        Me.year_textbox.Size = New System.Drawing.Size(62, 26)
        Me.year_textbox.TabIndex = 3
        '
        'month_format
        '
        Me.month_format.AutoSize = True
        Me.month_format.Location = New System.Drawing.Point(166, 69)
        Me.month_format.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.month_format.Name = "month_format"
        Me.month_format.Size = New System.Drawing.Size(104, 20)
        Me.month_format.TabIndex = 4
        Me.month_format.Text = "(Format: MM)"
        '
        'year_format
        '
        Me.year_format.AutoSize = True
        Me.year_format.Location = New System.Drawing.Point(166, 126)
        Me.year_format.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.year_format.Name = "year_format"
        Me.year_format.Size = New System.Drawing.Size(122, 20)
        Me.year_format.TabIndex = 5
        Me.year_format.Text = "(Format: YYYY)"
        '
        'total_income_label
        '
        Me.total_income_label.AutoSize = True
        Me.total_income_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_income_label.Location = New System.Drawing.Point(22, 174)
        Me.total_income_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.total_income_label.Name = "total_income_label"
        Me.total_income_label.Size = New System.Drawing.Size(178, 29)
        Me.total_income_label.TabIndex = 6
        Me.total_income_label.Text = "Total Income: $"
        '
        'income_label
        '
        Me.income_label.AutoSize = True
        Me.income_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.income_label.Location = New System.Drawing.Point(208, 174)
        Me.income_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.income_label.Name = "income_label"
        Me.income_label.Size = New System.Drawing.Size(26, 29)
        Me.income_label.TabIndex = 7
        Me.income_label.Text = "0"
        '
        'close_button
        '
        Me.close_button.Location = New System.Drawing.Point(27, 20)
        Me.close_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(112, 35)
        Me.close_button.TabIndex = 8
        Me.close_button.Text = "Close"
        Me.close_button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Execute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sales_Report_Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 225)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Sales_Report_Generator"
        Me.Text = "Sales_Report_Generator"
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
