<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Interface
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
        Me.UserHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Phone1800BLUEBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserHelpToolStripMenuItem, Me.EmployeeHelpToolStripMenuItem, Me.ManagerHelpToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UserHelpToolStripMenuItem
        '
        Me.UserHelpToolStripMenuItem.Name = "UserHelpToolStripMenuItem"
        Me.UserHelpToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UserHelpToolStripMenuItem.Text = "Customer Help"
        '
        'EmployeeHelpToolStripMenuItem
        '
        Me.EmployeeHelpToolStripMenuItem.Name = "EmployeeHelpToolStripMenuItem"
        Me.EmployeeHelpToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EmployeeHelpToolStripMenuItem.Text = "Employee Help"
        '
        'ManagerHelpToolStripMenuItem
        '
        Me.ManagerHelpToolStripMenuItem.Name = "ManagerHelpToolStripMenuItem"
        Me.ManagerHelpToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ManagerHelpToolStripMenuItem.Text = "Manager Help"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Phone1800BLUEBOXToolStripMenuItem, Me.EmailUsToolStripMenuItem})
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'Phone1800BLUEBOXToolStripMenuItem
        '
        Me.Phone1800BLUEBOXToolStripMenuItem.Name = "Phone1800BLUEBOXToolStripMenuItem"
        Me.Phone1800BLUEBOXToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.Phone1800BLUEBOXToolStripMenuItem.Text = "Phone: 1800-BLUEBOX"
        '
        'EmailUsToolStripMenuItem
        '
        Me.EmailUsToolStripMenuItem.Name = "EmailUsToolStripMenuItem"
        Me.EmailUsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EmailUsToolStripMenuItem.Text = "Email Us"
        '
        'pbBlueBox
        '
        Me.pbBlueBox.BackgroundImage = CType(resources.GetObject("pbBlueBox.BackgroundImage"), System.Drawing.Image)
        Me.pbBlueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbBlueBox.Location = New System.Drawing.Point(-1, 27)
        Me.pbBlueBox.Name = "pbBlueBox"
        Me.pbBlueBox.Size = New System.Drawing.Size(1185, 700)
        Me.pbBlueBox.TabIndex = 2
        Me.pbBlueBox.TabStop = False
        '
        'Main_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 724)
        Me.Controls.Add(Me.pbBlueBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Interface"
        Me.Text = "Blue Box Rental Service"
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
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeServicesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagerServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbBlueBox As PictureBox
    Friend WithEvents UserHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagerHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Phone1800BLUEBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailUsToolStripMenuItem As ToolStripMenuItem
End Class
