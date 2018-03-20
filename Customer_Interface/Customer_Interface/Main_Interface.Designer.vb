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
        Me.C_Home_Page = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_Interactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_Rep = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_Signup = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test_Q = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.EditToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 24)
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
        Me.Open.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C_Home_Page, Me.C_Interactions, Me.C_Login, Me.C_Rep, Me.C_Signup, Me.Test_Q})
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(180, 22)
        Me.Open.Text = "Open"
        '
        'C_Home_Page
        '
        Me.C_Home_Page.Name = "C_Home_Page"
        Me.C_Home_Page.Size = New System.Drawing.Size(206, 22)
        Me.C_Home_Page.Text = "Customer Home Page"
        '
        'C_Interactions
        '
        Me.C_Interactions.Name = "C_Interactions"
        Me.C_Interactions.Size = New System.Drawing.Size(206, 22)
        Me.C_Interactions.Text = "Customer Interactions"
        '
        'C_Login
        '
        Me.C_Login.Name = "C_Login"
        Me.C_Login.Size = New System.Drawing.Size(206, 22)
        Me.C_Login.Text = "Customer Login"
        '
        'C_Rep
        '
        Me.C_Rep.Name = "C_Rep"
        Me.C_Rep.Size = New System.Drawing.Size(206, 22)
        Me.C_Rep.Text = "Customer Representative"
        '
        'C_Signup
        '
        Me.C_Signup.Name = "C_Signup"
        Me.C_Signup.Size = New System.Drawing.Size(206, 22)
        Me.C_Signup.Text = "Customer Signup"
        '
        'Test_Q
        '
        Me.Test_Q.Name = "Test_Q"
        Me.Test_Q.Size = New System.Drawing.Size(206, 22)
        Me.Test_Q.Text = "Test Query Page"
        '
        'Close
        '
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(180, 22)
        Me.Close.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.WindowToolStripMenuItem.Text = "Help"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(180, 22)
        Me.About.Text = "About"
        '
        'Main_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 444)
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
    Friend WithEvents C_Home_Page As ToolStripMenuItem
    Friend WithEvents C_Interactions As ToolStripMenuItem
    Friend WithEvents C_Login As ToolStripMenuItem
    Friend WithEvents C_Rep As ToolStripMenuItem
    Friend WithEvents C_Signup As ToolStripMenuItem
    Friend WithEvents Test_Q As ToolStripMenuItem
    Friend WithEvents Close As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
End Class
