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
        Me.data_grid_rentals = New System.Windows.Forms.DataGridView()
        CType(Me.data_grid_rentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'current_rentals_close_btn
        '
        Me.current_rentals_close_btn.Location = New System.Drawing.Point(12, 12)
        Me.current_rentals_close_btn.Name = "current_rentals_close_btn"
        Me.current_rentals_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.current_rentals_close_btn.TabIndex = 5
        Me.current_rentals_close_btn.Text = "Close"
        Me.current_rentals_close_btn.UseVisualStyleBackColor = True
        '
        'data_grid_rentals
        '
        Me.data_grid_rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_rentals.Location = New System.Drawing.Point(-5, 56)
        Me.data_grid_rentals.Name = "data_grid_rentals"
        Me.data_grid_rentals.Size = New System.Drawing.Size(776, 308)
        Me.data_grid_rentals.TabIndex = 4
        '
        'Check_Most_Active
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 362)
        Me.Controls.Add(Me.current_rentals_close_btn)
        Me.Controls.Add(Me.data_grid_rentals)
        Me.Name = "Check_Most_Active"
        Me.Text = "Check_Most_Active"
        CType(Me.data_grid_rentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents current_rentals_close_btn As Button
    Friend WithEvents data_grid_rentals As DataGridView
End Class
