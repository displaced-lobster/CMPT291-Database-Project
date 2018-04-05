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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Interface))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeServicesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbBlueBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbBlueBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Open, Me.Close, Me.TestToolStripMenuItem})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(37, 20)
        Me.File.Text = "File"
        '
        'Open
        '
        Me.Open.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.EmployeeServicesToolStripMenuItem, Me.EmployeeServicesToolStripMenuItem1, Me.ManagerServicesToolStripMenuItem})
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(124, 22)
        Me.Open.Text = "Accounts"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CustomersToolStripMenuItem.Text = "New User Signup"
        '
        'EmployeeServicesToolStripMenuItem
        '
        Me.EmployeeServicesToolStripMenuItem.Name = "EmployeeServicesToolStripMenuItem"
        Me.EmployeeServicesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EmployeeServicesToolStripMenuItem.Text = "Customer Services"
        '
        'EmployeeServicesToolStripMenuItem1
        '
        Me.EmployeeServicesToolStripMenuItem1.Name = "EmployeeServicesToolStripMenuItem1"
        Me.EmployeeServicesToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.EmployeeServicesToolStripMenuItem1.Text = "Employee Services"
        '
        'ManagerServicesToolStripMenuItem
        '
        Me.ManagerServicesToolStripMenuItem.Name = "ManagerServicesToolStripMenuItem"
        Me.ManagerServicesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManagerServicesToolStripMenuItem.Text = "Manager Services"
        '
        'Close
        '
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(124, 22)
        Me.Close.Text = "Close"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.WindowToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'pbBlueBox
        '
        Me.pbBlueBox.BackgroundImage = CType(resources.GetObject("pbBlueBox.BackgroundImage"), System.Drawing.Image)
        Me.pbBlueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbBlueBox.Location = New System.Drawing.Point(0, 27)
        Me.pbBlueBox.Name = "pbBlueBox"
        Me.pbBlueBox.Size = New System.Drawing.Size(1184, 683)
        Me.pbBlueBox.TabIndex = 2
        Me.pbBlueBox.TabStop = False
        '
        'Main_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.pbBlueBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Interface"
        Me.Text = "Main Interface"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbBlueBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents Open As ToolStripMenuItem
    Friend WithEvents Close As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagerServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbBlueBox As PictureBox
End Class
