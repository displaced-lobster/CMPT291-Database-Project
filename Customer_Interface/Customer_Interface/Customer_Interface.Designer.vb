<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Interface
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxPrev = New System.Windows.Forms.ComboBox()
        Me.cbxQueue = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangeInfo = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.btnAddQueue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.movieSelect = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(786, 7)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Logout"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(852, 447)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(844, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Account Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxPrev)
        Me.GroupBox2.Controls.Add(Me.cbxQueue)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbxCur)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 408)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rental History"
        '
        'cbxPrev
        '
        Me.cbxPrev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPrev.FormattingEnabled = True
        Me.cbxPrev.Location = New System.Drawing.Point(92, 117)
        Me.cbxPrev.Name = "cbxPrev"
        Me.cbxPrev.Size = New System.Drawing.Size(269, 21)
        Me.cbxPrev.TabIndex = 8
        '
        'cbxQueue
        '
        Me.cbxQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQueue.FormattingEnabled = True
        Me.cbxQueue.Location = New System.Drawing.Point(92, 51)
        Me.cbxQueue.Name = "cbxQueue"
        Me.cbxQueue.Size = New System.Drawing.Size(269, 21)
        Me.cbxQueue.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Movie Queue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Past Orders"
        '
        'cbxCur
        '
        Me.cbxCur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCur.FormattingEnabled = True
        Me.cbxCur.Location = New System.Drawing.Point(92, 20)
        Me.cbxCur.Name = "cbxCur"
        Me.cbxCur.Size = New System.Drawing.Size(269, 21)
        Me.cbxCur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Rentals"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangeInfo)
        Me.GroupBox1.Controls.Add(Me.txtInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
        '
        'btnChangeInfo
        '
        Me.btnChangeInfo.Location = New System.Drawing.Point(179, 366)
        Me.btnChangeInfo.Name = "btnChangeInfo"
        Me.btnChangeInfo.Size = New System.Drawing.Size(107, 23)
        Me.btnChangeInfo.TabIndex = 1
        Me.btnChangeInfo.Text = "Edit Account"
        Me.btnChangeInfo.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtInfo.Location = New System.Drawing.Point(7, 20)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(444, 340)
        Me.txtInfo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(844, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Movies"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(606, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Edit Movie Queue ?"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Return Movie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btnPersonal)
        Me.GroupBox3.Controls.Add(Me.btnBest)
        Me.GroupBox3.Controls.Add(Me.btnAddQueue)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.movieSelect)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 408)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movie Search"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRes)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(447, 245)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'txtRes
        '
        Me.txtRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtRes.Location = New System.Drawing.Point(7, 20)
        Me.txtRes.Multiline = True
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(434, 219)
        Me.txtRes.TabIndex = 0
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(103, 59)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(89, 23)
        Me.btnPersonal.TabIndex = 6
        Me.btnPersonal.Text = "Recommended"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnBest
        '
        Me.btnBest.Location = New System.Drawing.Point(6, 59)
        Me.btnBest.Name = "btnBest"
        Me.btnBest.Size = New System.Drawing.Size(89, 23)
        Me.btnBest.TabIndex = 5
        Me.btnBest.Text = "Best Sellers"
        Me.btnBest.UseVisualStyleBackColor = True
        '
        'btnAddQueue
        '
        Me.btnAddQueue.Location = New System.Drawing.Point(199, 379)
        Me.btnAddQueue.Name = "btnAddQueue"
        Me.btnAddQueue.Size = New System.Drawing.Size(88, 23)
        Me.btnAddQueue.TabIndex = 3
        Me.btnAddQueue.Text = "Add To Queue"
        Me.btnAddQueue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Movie Categories: Comedy, Drama, Action, Foreign"
        '
        'movieSelect
        '
        Me.movieSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.movieSelect.FormattingEnabled = True
        Me.movieSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.movieSelect.Location = New System.Drawing.Point(6, 381)
        Me.movieSelect.MaxDropDownItems = 50
        Me.movieSelect.Name = "movieSelect"
        Me.movieSelect.Size = New System.Drawing.Size(186, 21)
        Me.movieSelect.Sorted = True
        Me.movieSelect.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 101)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(186, 20)
        Me.txtSearch.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(606, 150)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Rate A Movie"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.AutoSize = True
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtUserName.Location = New System.Drawing.Point(13, 7)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(0, 24)
        Me.txtUserName.TabIndex = 5
        '
        'Customer_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 495)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Customer_Interface"
        Me.Text = "Customer Interface"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtUserName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnChangeInfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxCur As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxQueue As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAddQueue As Button
    Friend WithEvents movieSelect As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbxPrev As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnBest As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtRes As TextBox
End Class
