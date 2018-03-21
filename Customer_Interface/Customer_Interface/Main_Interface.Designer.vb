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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeServicesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1059, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Open, Me.Close})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(37, 20)
        Me.File.Text = "File"
        '
        'Open
        '
        Me.Open.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.EmployeeServicesToolStripMenuItem, Me.EmployeeServicesToolStripMenuItem1})
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(180, 22)
        Me.Open.Text = "Open"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomersToolStripMenuItem.Text = "New User Signup"
        '
        'EmployeeServicesToolStripMenuItem
        '
        Me.EmployeeServicesToolStripMenuItem.Name = "EmployeeServicesToolStripMenuItem"
        Me.EmployeeServicesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeServicesToolStripMenuItem.Text = "Customer Services"
        '
        'EmployeeServicesToolStripMenuItem1
        '
        Me.EmployeeServicesToolStripMenuItem1.Name = "EmployeeServicesToolStripMenuItem1"
        Me.EmployeeServicesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeServicesToolStripMenuItem1.Text = "Employee Services"
        '
        'Close
        '
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(180, 22)
        Me.Close.Text = "Close"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.WindowToolStripMenuItem.Text = "Edit"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(107, 22)
        Me.About.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Main_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 602)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Interface"
        Me.Text = "Main Interface"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents Open As ToolStripMenuItem
    Friend WithEvents Close As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem1 As ToolStripMenuItem
End Class
