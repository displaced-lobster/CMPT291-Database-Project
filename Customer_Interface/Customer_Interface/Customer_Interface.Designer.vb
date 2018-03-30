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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbRateRes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rbRateActor = New System.Windows.Forms.RadioButton()
        Me.btnRatingSearch = New System.Windows.Forms.Button()
        Me.rbRateMovie = New System.Windows.Forms.RadioButton()
        Me.txtRatingSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbCategory = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnEditQueue = New System.Windows.Forms.Button()
        Me.rbActor = New System.Windows.Forms.RadioButton()
        Me.cbEditQueue = New System.Windows.Forms.ComboBox()
        Me.rbTitle = New System.Windows.Forms.RadioButton()
        Me.btnReturnMovie = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.btnAddQueue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.movieSelect = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.rentMovie = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(844, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Movies"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.rbRateActor)
        Me.GroupBox5.Controls.Add(Me.btnRatingSearch)
        Me.GroupBox5.Controls.Add(Me.rbRateMovie)
        Me.GroupBox5.Controls.Add(Me.txtRatingSearch)
        Me.GroupBox5.Location = New System.Drawing.Point(474, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(364, 408)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ratings"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cbRateRes)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.btnRate)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(352, 273)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Results"
        '
        'cbRateRes
        '
        Me.cbRateRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRateRes.FormattingEnabled = True
        Me.cbRateRes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbRateRes.Location = New System.Drawing.Point(6, 79)
        Me.cbRateRes.MaxDropDownItems = 50
        Me.cbRateRes.Name = "cbRateRes"
        Me.cbRateRes.Size = New System.Drawing.Size(186, 21)
        Me.cbRateRes.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Choose a rating"
        '
        'btnRate
        '
        Me.btnRate.Location = New System.Drawing.Point(199, 77)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(89, 23)
        Me.btnRate.TabIndex = 17
        Me.btnRate.Text = "Rate"
        Me.btnRate.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rb5)
        Me.GroupBox6.Controls.Add(Me.rb4)
        Me.GroupBox6.Controls.Add(Me.rb2)
        Me.GroupBox6.Controls.Add(Me.rb3)
        Me.GroupBox6.Controls.Add(Me.rb1)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 39)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(185, 32)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Location = New System.Drawing.Point(154, 11)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(31, 17)
        Me.rb5.TabIndex = 21
        Me.rb5.TabStop = True
        Me.rb5.Text = "5"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Location = New System.Drawing.Point(117, 11)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(31, 17)
        Me.rb4.TabIndex = 20
        Me.rb4.TabStop = True
        Me.rb4.Text = "4"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(43, 11)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(31, 17)
        Me.rb2.TabIndex = 17
        Me.rb2.TabStop = True
        Me.rb2.Text = "2"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(80, 11)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(31, 17)
        Me.rb3.TabIndex = 19
        Me.rb3.TabStop = True
        Me.rb3.Text = "3"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 11)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(31, 17)
        Me.rb1.TabIndex = 16
        Me.rb1.TabStop = True
        Me.rb1.Text = "1"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rbRateActor
        '
        Me.rbRateActor.AutoSize = True
        Me.rbRateActor.Location = New System.Drawing.Point(6, 42)
        Me.rbRateActor.Name = "rbRateActor"
        Me.rbRateActor.Size = New System.Drawing.Size(106, 17)
        Me.rbRateActor.TabIndex = 15
        Me.rbRateActor.TabStop = True
        Me.rbRateActor.Text = "Search by Actors"
        Me.rbRateActor.UseVisualStyleBackColor = True
        '
        'btnRatingSearch
        '
        Me.btnRatingSearch.Location = New System.Drawing.Point(199, 60)
        Me.btnRatingSearch.Name = "btnRatingSearch"
        Me.btnRatingSearch.Size = New System.Drawing.Size(89, 23)
        Me.btnRatingSearch.TabIndex = 10
        Me.btnRatingSearch.Text = "Search"
        Me.btnRatingSearch.UseVisualStyleBackColor = True
        '
        'rbRateMovie
        '
        Me.rbRateMovie.AutoSize = True
        Me.rbRateMovie.Location = New System.Drawing.Point(6, 19)
        Me.rbRateMovie.Name = "rbRateMovie"
        Me.rbRateMovie.Size = New System.Drawing.Size(96, 17)
        Me.rbRateMovie.TabIndex = 14
        Me.rbRateMovie.TabStop = True
        Me.rbRateMovie.Text = "Search by Title"
        Me.rbRateMovie.UseVisualStyleBackColor = True
        '
        'txtRatingSearch
        '
        Me.txtRatingSearch.Location = New System.Drawing.Point(6, 62)
        Me.txtRatingSearch.Name = "txtRatingSearch"
        Me.txtRatingSearch.Size = New System.Drawing.Size(186, 20)
        Me.txtRatingSearch.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rentMovie)
        Me.GroupBox3.Controls.Add(Me.rbCategory)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.btnEditQueue)
        Me.GroupBox3.Controls.Add(Me.rbActor)
        Me.GroupBox3.Controls.Add(Me.cbEditQueue)
        Me.GroupBox3.Controls.Add(Me.rbTitle)
        Me.GroupBox3.Controls.Add(Me.btnReturnMovie)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
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
        'rbCategory
        '
        Me.rbCategory.AutoSize = True
        Me.rbCategory.Location = New System.Drawing.Point(317, 53)
        Me.rbCategory.Name = "rbCategory"
        Me.rbCategory.Size = New System.Drawing.Size(118, 17)
        Me.rbCategory.TabIndex = 11
        Me.rbCategory.TabStop = True
        Me.rbCategory.Text = "Search by Category"
        Me.rbCategory.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox1.Location = New System.Drawing.Point(75, 322)
        Me.ComboBox1.MaxDropDownItems = 50
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'btnEditQueue
        '
        Me.btnEditQueue.Location = New System.Drawing.Point(267, 347)
        Me.btnEditQueue.Name = "btnEditQueue"
        Me.btnEditQueue.Size = New System.Drawing.Size(116, 23)
        Me.btnEditQueue.TabIndex = 11
        Me.btnEditQueue.Text = "Edit Movie Queue"
        Me.btnEditQueue.UseVisualStyleBackColor = True
        '
        'rbActor
        '
        Me.rbActor.AutoSize = True
        Me.rbActor.Location = New System.Drawing.Point(317, 99)
        Me.rbActor.Name = "rbActor"
        Me.rbActor.Size = New System.Drawing.Size(106, 17)
        Me.rbActor.TabIndex = 10
        Me.rbActor.TabStop = True
        Me.rbActor.Text = "Search by Actors"
        Me.rbActor.UseVisualStyleBackColor = True
        '
        'cbEditQueue
        '
        Me.cbEditQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEditQueue.FormattingEnabled = True
        Me.cbEditQueue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbEditQueue.Location = New System.Drawing.Point(75, 349)
        Me.cbEditQueue.MaxDropDownItems = 50
        Me.cbEditQueue.Name = "cbEditQueue"
        Me.cbEditQueue.Size = New System.Drawing.Size(186, 21)
        Me.cbEditQueue.TabIndex = 10
        '
        'rbTitle
        '
        Me.rbTitle.AutoSize = True
        Me.rbTitle.Location = New System.Drawing.Point(317, 76)
        Me.rbTitle.Name = "rbTitle"
        Me.rbTitle.Size = New System.Drawing.Size(96, 17)
        Me.rbTitle.TabIndex = 9
        Me.rbTitle.TabStop = True
        Me.rbTitle.Text = "Search by Title"
        Me.rbTitle.UseVisualStyleBackColor = True
        '
        'btnReturnMovie
        '
        Me.btnReturnMovie.Location = New System.Drawing.Point(267, 320)
        Me.btnReturnMovie.Name = "btnReturnMovie"
        Me.btnReturnMovie.Size = New System.Drawing.Size(116, 23)
        Me.btnReturnMovie.TabIndex = 9
        Me.btnReturnMovie.Text = "Return A Movie"
        Me.btnReturnMovie.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(199, 99)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.txtRes)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(447, 161)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(302, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(139, 134)
        Me.DataGridView1.TabIndex = 6
        '
        'txtRes
        '
        Me.txtRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtRes.Location = New System.Drawing.Point(7, 20)
        Me.txtRes.Multiline = True
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(434, 134)
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
        Me.btnAddQueue.Location = New System.Drawing.Point(267, 293)
        Me.btnAddQueue.Name = "btnAddQueue"
        Me.btnAddQueue.Size = New System.Drawing.Size(116, 23)
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
        Me.movieSelect.Location = New System.Drawing.Point(74, 295)
        Me.movieSelect.MaxDropDownItems = 50
        Me.movieSelect.Name = "movieSelect"
        Me.movieSelect.Size = New System.Drawing.Size(186, 21)
        Me.movieSelect.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 101)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(186, 20)
        Me.txtSearch.TabIndex = 0
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
        'rentMovie
        '
        Me.rentMovie.Location = New System.Drawing.Point(267, 376)
        Me.rentMovie.Name = "rentMovie"
        Me.rentMovie.Size = New System.Drawing.Size(116, 23)
        Me.rentMovie.TabIndex = 14
        Me.rentMovie.Text = "Rent a Movie"
        Me.rentMovie.UseVisualStyleBackColor = True
        '
        'Customer_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer_Interface"
        Me.Text = "Customer Interface"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAddQueue As Button
    Friend WithEvents movieSelect As ComboBox
    Friend WithEvents btnReturnMovie As Button
    Friend WithEvents cbxPrev As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnBest As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rbActor As RadioButton
    Friend WithEvents rbTitle As RadioButton
    Friend WithEvents rbCategory As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEditQueue As Button
    Friend WithEvents cbEditQueue As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbRateActor As RadioButton
    Friend WithEvents btnRatingSearch As Button
    Friend WithEvents rbRateMovie As RadioButton
    Friend WithEvents txtRatingSearch As TextBox
    Friend WithEvents btnRate As Button
    Friend WithEvents cbRateRes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents rentMovie As Button
End Class
