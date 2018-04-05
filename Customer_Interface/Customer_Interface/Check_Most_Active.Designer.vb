<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_Most_Active
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
        Me.current_rentals_close_btn = New System.Windows.Forms.Button()
        Me.data_grid_most_active = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.most_rented_movies_rbutton = New System.Windows.Forms.RadioButton()
        Me.most_actively_label = New System.Windows.Forms.Label()
        Me.customers_rbutton = New System.Windows.Forms.RadioButton()
        Me.sale_rep_rbutton = New System.Windows.Forms.RadioButton()
        Me.most_active_exebtn = New System.Windows.Forms.Button()
        Me.top_x_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.data_grid_most_active, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'current_rentals_close_btn
        '
        Me.current_rentals_close_btn.Location = New System.Drawing.Point(12, 12)
        Me.current_rentals_close_btn.Name = "current_rentals_close_btn"
        Me.current_rentals_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.current_rentals_close_btn.TabIndex = 3
        Me.current_rentals_close_btn.Text = "Close"
        Me.current_rentals_close_btn.UseVisualStyleBackColor = True
        '
        'data_grid_most_active
        '
        Me.data_grid_most_active.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_most_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_most_active.Location = New System.Drawing.Point(167, 0)
        Me.data_grid_most_active.Name = "data_grid_most_active"
        Me.data_grid_most_active.Size = New System.Drawing.Size(419, 364)
        Me.data_grid_most_active.TabIndex = 2
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1187, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'most_rented_movies_rbutton
        '
        Me.most_rented_movies_rbutton.AutoSize = True
        Me.most_rented_movies_rbutton.Checked = True
        Me.most_rented_movies_rbutton.Location = New System.Drawing.Point(38, 85)
        Me.most_rented_movies_rbutton.Name = "most_rented_movies_rbutton"
        Me.most_rented_movies_rbutton.Size = New System.Drawing.Size(93, 17)
        Me.most_rented_movies_rbutton.TabIndex = 6
        Me.most_rented_movies_rbutton.TabStop = True
        Me.most_rented_movies_rbutton.Text = "Movie Rentals"
        Me.most_rented_movies_rbutton.UseVisualStyleBackColor = True
        '
        'most_actively_label
        '
        Me.most_actively_label.AutoSize = True
        Me.most_actively_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.most_actively_label.Location = New System.Drawing.Point(12, 48)
        Me.most_actively_label.Name = "most_actively_label"
        Me.most_actively_label.Size = New System.Drawing.Size(103, 20)
        Me.most_actively_label.TabIndex = 7
        Me.most_actively_label.Text = "Most Active..."
        '
        'customers_rbutton
        '
        Me.customers_rbutton.AutoSize = True
        Me.customers_rbutton.Location = New System.Drawing.Point(38, 117)
        Me.customers_rbutton.Name = "customers_rbutton"
        Me.customers_rbutton.Size = New System.Drawing.Size(74, 17)
        Me.customers_rbutton.TabIndex = 8
        Me.customers_rbutton.Text = "Customers"
        Me.customers_rbutton.UseVisualStyleBackColor = True
        '
        'sale_rep_rbutton
        '
        Me.sale_rep_rbutton.AutoSize = True
        Me.sale_rep_rbutton.Location = New System.Drawing.Point(38, 149)
        Me.sale_rep_rbutton.Name = "sale_rep_rbutton"
        Me.sale_rep_rbutton.Size = New System.Drawing.Size(74, 17)
        Me.sale_rep_rbutton.TabIndex = 9
        Me.sale_rep_rbutton.Text = "Sales Rep"
        Me.sale_rep_rbutton.UseVisualStyleBackColor = True
        '
        'most_active_exebtn
        '
        Me.most_active_exebtn.Location = New System.Drawing.Point(12, 213)
        Me.most_active_exebtn.Name = "most_active_exebtn"
        Me.most_active_exebtn.Size = New System.Drawing.Size(75, 23)
        Me.most_active_exebtn.TabIndex = 10
        Me.most_active_exebtn.Text = "Execute"
        Me.most_active_exebtn.UseVisualStyleBackColor = True
        '
        'top_x_tb
        '
        Me.top_x_tb.Location = New System.Drawing.Point(111, 181)
        Me.top_x_tb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.top_x_tb.Name = "top_x_tb"
        Me.top_x_tb.Size = New System.Drawing.Size(27, 20)
        Me.top_x_tb.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Enter Top X Rows:"
        '
        'Check_Most_Active
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.top_x_tb)
        Me.Controls.Add(Me.most_active_exebtn)
        Me.Controls.Add(Me.sale_rep_rbutton)
        Me.Controls.Add(Me.customers_rbutton)
        Me.Controls.Add(Me.most_actively_label)
        Me.Controls.Add(Me.most_rented_movies_rbutton)
        Me.Controls.Add(Me.current_rentals_close_btn)
        Me.Controls.Add(Me.data_grid_most_active)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Check_Most_Active"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Check Most Active"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data_grid_most_active, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents current_rentals_close_btn As Button
    Friend WithEvents data_grid_most_active As DataGridView
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents most_rented_movies_rbutton As RadioButton
    Friend WithEvents most_actively_label As Label
    Friend WithEvents customers_rbutton As RadioButton
    Friend WithEvents sale_rep_rbutton As RadioButton
    Friend WithEvents most_active_exebtn As Button
    Friend WithEvents top_x_tb As TextBox
    Friend WithEvents Label1 As Label
End Class
