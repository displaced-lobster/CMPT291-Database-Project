<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Current_Rentals
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
        Me.rentals_cn_rbutton = New System.Windows.Forms.RadioButton()
        Me.rentals_mt_rbutton = New System.Windows.Forms.RadioButton()
        Me.check_by_label = New System.Windows.Forms.Label()
        Me.rentals_mn_rbutton = New System.Windows.Forms.RadioButton()
        Me.close_btn_rentals = New System.Windows.Forms.Button()
        Me.data_grid_rentals = New System.Windows.Forms.DataGridView()
        Me.textbox_input = New System.Windows.Forms.TextBox()
        Me.execute_button = New System.Windows.Forms.Button()
        CType(Me.data_grid_rentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rentals_cn_rbutton
        '
        Me.rentals_cn_rbutton.AutoSize = True
        Me.rentals_cn_rbutton.Location = New System.Drawing.Point(43, 146)
        Me.rentals_cn_rbutton.Name = "rentals_cn_rbutton"
        Me.rentals_cn_rbutton.Size = New System.Drawing.Size(100, 17)
        Me.rentals_cn_rbutton.TabIndex = 15
        Me.rentals_cn_rbutton.Text = "Customer Name"
        Me.rentals_cn_rbutton.UseVisualStyleBackColor = True
        '
        'rentals_mt_rbutton
        '
        Me.rentals_mt_rbutton.AutoSize = True
        Me.rentals_mt_rbutton.Location = New System.Drawing.Point(43, 114)
        Me.rentals_mt_rbutton.Name = "rentals_mt_rbutton"
        Me.rentals_mt_rbutton.Size = New System.Drawing.Size(81, 17)
        Me.rentals_mt_rbutton.TabIndex = 14
        Me.rentals_mt_rbutton.Text = "Movie Type"
        Me.rentals_mt_rbutton.UseVisualStyleBackColor = True
        '
        'check_by_label
        '
        Me.check_by_label.AutoSize = True
        Me.check_by_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_by_label.Location = New System.Drawing.Point(17, 45)
        Me.check_by_label.Name = "check_by_label"
        Me.check_by_label.Size = New System.Drawing.Size(88, 20)
        Me.check_by_label.TabIndex = 13
        Me.check_by_label.Text = "Check By..."
        '
        'rentals_mn_rbutton
        '
        Me.rentals_mn_rbutton.AutoSize = True
        Me.rentals_mn_rbutton.Checked = True
        Me.rentals_mn_rbutton.Location = New System.Drawing.Point(43, 83)
        Me.rentals_mn_rbutton.Name = "rentals_mn_rbutton"
        Me.rentals_mn_rbutton.Size = New System.Drawing.Size(85, 17)
        Me.rentals_mn_rbutton.TabIndex = 12
        Me.rentals_mn_rbutton.TabStop = True
        Me.rentals_mn_rbutton.Text = "Movie Name"
        Me.rentals_mn_rbutton.UseVisualStyleBackColor = True
        '
        'close_btn_rentals
        '
        Me.close_btn_rentals.Location = New System.Drawing.Point(17, 9)
        Me.close_btn_rentals.Name = "close_btn_rentals"
        Me.close_btn_rentals.Size = New System.Drawing.Size(75, 23)
        Me.close_btn_rentals.TabIndex = 11
        Me.close_btn_rentals.Text = "Close"
        Me.close_btn_rentals.UseVisualStyleBackColor = True
        '
        'data_grid_rentals
        '
        Me.data_grid_rentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_rentals.Location = New System.Drawing.Point(172, -3)
        Me.data_grid_rentals.Name = "data_grid_rentals"
        Me.data_grid_rentals.Size = New System.Drawing.Size(413, 364)
        Me.data_grid_rentals.TabIndex = 10
        '
        'textbox_input
        '
        Me.textbox_input.Location = New System.Drawing.Point(21, 190)
        Me.textbox_input.Margin = New System.Windows.Forms.Padding(2)
        Me.textbox_input.Name = "textbox_input"
        Me.textbox_input.Size = New System.Drawing.Size(123, 20)
        Me.textbox_input.TabIndex = 16
        Me.textbox_input.Text = "Input Here..."
        '
        'execute_button
        '
        Me.execute_button.Location = New System.Drawing.Point(43, 224)
        Me.execute_button.Name = "execute_button"
        Me.execute_button.Size = New System.Drawing.Size(75, 23)
        Me.execute_button.TabIndex = 17
        Me.execute_button.Text = "Execute"
        Me.execute_button.UseVisualStyleBackColor = True
        '
        'Current_Rentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.execute_button)
        Me.Controls.Add(Me.textbox_input)
        Me.Controls.Add(Me.rentals_cn_rbutton)
        Me.Controls.Add(Me.rentals_mt_rbutton)
        Me.Controls.Add(Me.check_by_label)
        Me.Controls.Add(Me.rentals_mn_rbutton)
        Me.Controls.Add(Me.close_btn_rentals)
        Me.Controls.Add(Me.data_grid_rentals)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Current_Rentals"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Current Rentals"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data_grid_rentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rentals_cn_rbutton As RadioButton
    Friend WithEvents rentals_mt_rbutton As RadioButton
    Friend WithEvents check_by_label As Label
    Friend WithEvents rentals_mn_rbutton As RadioButton
    Friend WithEvents close_btn_rentals As Button
    Friend WithEvents data_grid_rentals As DataGridView
    Friend WithEvents textbox_input As TextBox
    Friend WithEvents execute_button As Button
End Class
