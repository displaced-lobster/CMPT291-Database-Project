<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Manager_Interface
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
        Me.ManagerLabel = New System.Windows.Forms.Label()
        Me.ManagerTab1 = New System.Windows.Forms.TabControl()
        Me.MI_MoiveTab = New System.Windows.Forms.TabPage()
        Me.MI_movie_note1 = New System.Windows.Forms.Label()
        Me.MI_rem_movie_btn = New System.Windows.Forms.Button()
        Me.MI_edit_movie_btn = New System.Windows.Forms.Button()
        Me.MI_inventory_tb = New System.Windows.Forms.TextBox()
        Me.MI_inventory = New System.Windows.Forms.Label()
        Me.MI_dist_fee_tb = New System.Windows.Forms.TextBox()
        Me.MI_dist_fee = New System.Windows.Forms.Label()
        Me.MI_movie_type_tb = New System.Windows.Forms.TextBox()
        Me.MI_movie_title = New System.Windows.Forms.Label()
        Me.MI_movie_title_tb = New System.Windows.Forms.TextBox()
        Me.MI_movie_type = New System.Windows.Forms.Label()
        Me.MI_movie_id = New System.Windows.Forms.Label()
        Me.MI_movie_id_tb = New System.Windows.Forms.TextBox()
        Me.MI_add_movie_btn = New System.Windows.Forms.Button()
        Me.MI_EmpTab = New System.Windows.Forms.TabPage()
        Me.MI_emp_ap_num_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_ap_num = New System.Windows.Forms.Label()
        Me.MI_emp_street_num_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_street_num = New System.Windows.Forms.Label()
        Me.MI_emp_street_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_street = New System.Windows.Forms.Label()
        Me.MI_emp_zip_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_state = New System.Windows.Forms.Label()
        Me.MI_emp_state_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_zip = New System.Windows.Forms.Label()
        Me.MI_emp_city = New System.Windows.Forms.Label()
        Me.MI_emp_city_tb = New System.Windows.Forms.TextBox()
        Me.MI_rem_emp_btn = New System.Windows.Forms.Button()
        Me.MI_edit_emp_btn = New System.Windows.Forms.Button()
        Me.MI_emp_hr_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_hr = New System.Windows.Forms.Label()
        Me.MI_emp_start_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_start = New System.Windows.Forms.Label()
        Me.MI_emp_ln_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_fn = New System.Windows.Forms.Label()
        Me.MI_emp_fn_tb = New System.Windows.Forms.TextBox()
        Me.MI_emp_ln = New System.Windows.Forms.Label()
        Me.MI_emp_sin = New System.Windows.Forms.Label()
        Me.MI_emp_sin_tb = New System.Windows.Forms.TextBox()
        Me.MI_add_emp_btn = New System.Windows.Forms.Button()
        Me.MI_DataTab = New System.Windows.Forms.TabPage()
        Me.MI_most_active = New System.Windows.Forms.Label()
        Me.MI_sr = New System.Windows.Forms.Label()
        Me.MI_list_options = New System.Windows.Forms.Label()
        Me.MI_active_custs_btn = New System.Windows.Forms.Button()
        Me.MI_list_rentals_btn = New System.Windows.Forms.Button()
        Me.MI_list_movies_btn = New System.Windows.Forms.Button()
        Me.MI_sr_btn = New System.Windows.Forms.Button()
        Me.ManagerTab1.SuspendLayout()
        Me.MI_MoiveTab.SuspendLayout()
        Me.MI_EmpTab.SuspendLayout()
        Me.MI_DataTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ManagerLabel
        '
        Me.ManagerLabel.AutoSize = True
        Me.ManagerLabel.Location = New System.Drawing.Point(13, 13)
        Me.ManagerLabel.Name = "ManagerLabel"
        Me.ManagerLabel.Size = New System.Drawing.Size(49, 13)
        Me.ManagerLabel.TabIndex = 0
        Me.ManagerLabel.Text = "Manager"
        '
        'ManagerTab1
        '
        Me.ManagerTab1.Controls.Add(Me.MI_MoiveTab)
        Me.ManagerTab1.Controls.Add(Me.MI_EmpTab)
        Me.ManagerTab1.Controls.Add(Me.MI_DataTab)
        Me.ManagerTab1.Location = New System.Drawing.Point(10, 41)
        Me.ManagerTab1.Margin = New System.Windows.Forms.Padding(1)
        Me.ManagerTab1.Name = "ManagerTab1"
        Me.ManagerTab1.SelectedIndex = 0
        Me.ManagerTab1.Size = New System.Drawing.Size(704, 292)
        Me.ManagerTab1.TabIndex = 4
        '
        'MI_MoiveTab
        '
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_note1)
        Me.MI_MoiveTab.Controls.Add(Me.MI_rem_movie_btn)
        Me.MI_MoiveTab.Controls.Add(Me.MI_edit_movie_btn)
        Me.MI_MoiveTab.Controls.Add(Me.MI_inventory_tb)
        Me.MI_MoiveTab.Controls.Add(Me.MI_inventory)
        Me.MI_MoiveTab.Controls.Add(Me.MI_dist_fee_tb)
        Me.MI_MoiveTab.Controls.Add(Me.MI_dist_fee)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_type_tb)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_title)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_title_tb)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_type)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_id)
        Me.MI_MoiveTab.Controls.Add(Me.MI_movie_id_tb)
        Me.MI_MoiveTab.Controls.Add(Me.MI_add_movie_btn)
        Me.MI_MoiveTab.Location = New System.Drawing.Point(4, 22)
        Me.MI_MoiveTab.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_MoiveTab.Name = "MI_MoiveTab"
        Me.MI_MoiveTab.Padding = New System.Windows.Forms.Padding(1)
        Me.MI_MoiveTab.Size = New System.Drawing.Size(696, 266)
        Me.MI_MoiveTab.TabIndex = 0
        Me.MI_MoiveTab.Text = "Movie Database"
        Me.MI_MoiveTab.UseVisualStyleBackColor = True
        '
        'MI_movie_note1
        '
        Me.MI_movie_note1.AutoSize = True
        Me.MI_movie_note1.Location = New System.Drawing.Point(373, 225)
        Me.MI_movie_note1.Name = "MI_movie_note1"
        Me.MI_movie_note1.Size = New System.Drawing.Size(261, 13)
        Me.MI_movie_note1.TabIndex = 13
        Me.MI_movie_note1.Text = "For removing a movie, only the movie ID is neccesary."
        '
        'MI_rem_movie_btn
        '
        Me.MI_rem_movie_btn.Location = New System.Drawing.Point(221, 188)
        Me.MI_rem_movie_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_rem_movie_btn.Name = "MI_rem_movie_btn"
        Me.MI_rem_movie_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_rem_movie_btn.TabIndex = 12
        Me.MI_rem_movie_btn.Text = "Remove Movie"
        Me.MI_rem_movie_btn.UseVisualStyleBackColor = True
        '
        'MI_edit_movie_btn
        '
        Me.MI_edit_movie_btn.Location = New System.Drawing.Point(123, 188)
        Me.MI_edit_movie_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_edit_movie_btn.Name = "MI_edit_movie_btn"
        Me.MI_edit_movie_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_edit_movie_btn.TabIndex = 11
        Me.MI_edit_movie_btn.Text = "Edit Movie"
        Me.MI_edit_movie_btn.UseVisualStyleBackColor = True
        '
        'MI_inventory_tb
        '
        Me.MI_inventory_tb.Location = New System.Drawing.Point(177, 147)
        Me.MI_inventory_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_inventory_tb.Name = "MI_inventory_tb"
        Me.MI_inventory_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_inventory_tb.TabIndex = 10
        '
        'MI_inventory
        '
        Me.MI_inventory.AutoSize = True
        Me.MI_inventory.Location = New System.Drawing.Point(18, 147)
        Me.MI_inventory.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_inventory.Name = "MI_inventory"
        Me.MI_inventory.Size = New System.Drawing.Size(51, 13)
        Me.MI_inventory.TabIndex = 9
        Me.MI_inventory.Text = "Inventory"
        '
        'MI_dist_fee_tb
        '
        Me.MI_dist_fee_tb.Location = New System.Drawing.Point(177, 117)
        Me.MI_dist_fee_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_dist_fee_tb.Name = "MI_dist_fee_tb"
        Me.MI_dist_fee_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_dist_fee_tb.TabIndex = 8
        '
        'MI_dist_fee
        '
        Me.MI_dist_fee.AutoSize = True
        Me.MI_dist_fee.Location = New System.Drawing.Point(18, 117)
        Me.MI_dist_fee.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_dist_fee.Name = "MI_dist_fee"
        Me.MI_dist_fee.Size = New System.Drawing.Size(80, 13)
        Me.MI_dist_fee.TabIndex = 7
        Me.MI_dist_fee.Text = "Distribution Fee"
        '
        'MI_movie_type_tb
        '
        Me.MI_movie_type_tb.Location = New System.Drawing.Point(177, 89)
        Me.MI_movie_type_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_movie_type_tb.Name = "MI_movie_type_tb"
        Me.MI_movie_type_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_movie_type_tb.TabIndex = 6
        '
        'MI_movie_title
        '
        Me.MI_movie_title.AutoSize = True
        Me.MI_movie_title.Location = New System.Drawing.Point(18, 60)
        Me.MI_movie_title.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_movie_title.Name = "MI_movie_title"
        Me.MI_movie_title.Size = New System.Drawing.Size(59, 13)
        Me.MI_movie_title.TabIndex = 5
        Me.MI_movie_title.Text = "Movie Title"
        '
        'MI_movie_title_tb
        '
        Me.MI_movie_title_tb.Location = New System.Drawing.Point(177, 60)
        Me.MI_movie_title_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_movie_title_tb.Name = "MI_movie_title_tb"
        Me.MI_movie_title_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_movie_title_tb.TabIndex = 4
        '
        'MI_movie_type
        '
        Me.MI_movie_type.AutoSize = True
        Me.MI_movie_type.Location = New System.Drawing.Point(18, 89)
        Me.MI_movie_type.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_movie_type.Name = "MI_movie_type"
        Me.MI_movie_type.Size = New System.Drawing.Size(63, 13)
        Me.MI_movie_type.TabIndex = 3
        Me.MI_movie_type.Text = "Moive Type"
        '
        'MI_movie_id
        '
        Me.MI_movie_id.AutoSize = True
        Me.MI_movie_id.Location = New System.Drawing.Point(18, 34)
        Me.MI_movie_id.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_movie_id.Name = "MI_movie_id"
        Me.MI_movie_id.Size = New System.Drawing.Size(50, 13)
        Me.MI_movie_id.TabIndex = 2
        Me.MI_movie_id.Text = "Movie ID"
        '
        'MI_movie_id_tb
        '
        Me.MI_movie_id_tb.Location = New System.Drawing.Point(177, 34)
        Me.MI_movie_id_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_movie_id_tb.Name = "MI_movie_id_tb"
        Me.MI_movie_id_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_movie_id_tb.TabIndex = 1
        '
        'MI_add_movie_btn
        '
        Me.MI_add_movie_btn.Location = New System.Drawing.Point(21, 188)
        Me.MI_add_movie_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_add_movie_btn.Name = "MI_add_movie_btn"
        Me.MI_add_movie_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_add_movie_btn.TabIndex = 0
        Me.MI_add_movie_btn.Text = "Add Movie"
        Me.MI_add_movie_btn.UseVisualStyleBackColor = True
        '
        'MI_EmpTab
        '
        Me.MI_EmpTab.AllowDrop = True
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_ap_num_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_ap_num)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_street_num_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_street_num)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_street_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_street)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_zip_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_state)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_state_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_zip)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_city)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_city_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_rem_emp_btn)
        Me.MI_EmpTab.Controls.Add(Me.MI_edit_emp_btn)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_hr_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_hr)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_start_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_start)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_ln_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_fn)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_fn_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_ln)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_sin)
        Me.MI_EmpTab.Controls.Add(Me.MI_emp_sin_tb)
        Me.MI_EmpTab.Controls.Add(Me.MI_add_emp_btn)
        Me.MI_EmpTab.Location = New System.Drawing.Point(4, 22)
        Me.MI_EmpTab.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_EmpTab.Name = "MI_EmpTab"
        Me.MI_EmpTab.Padding = New System.Windows.Forms.Padding(1)
        Me.MI_EmpTab.Size = New System.Drawing.Size(696, 266)
        Me.MI_EmpTab.TabIndex = 1
        Me.MI_EmpTab.Text = "Employee Database"
        Me.MI_EmpTab.UseVisualStyleBackColor = True
        '
        'MI_emp_ap_num_tb
        '
        Me.MI_emp_ap_num_tb.Location = New System.Drawing.Point(520, 177)
        Me.MI_emp_ap_num_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_ap_num_tb.Name = "MI_emp_ap_num_tb"
        Me.MI_emp_ap_num_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_ap_num_tb.TabIndex = 39
        '
        'MI_emp_ap_num
        '
        Me.MI_emp_ap_num.AutoSize = True
        Me.MI_emp_ap_num.Location = New System.Drawing.Point(361, 177)
        Me.MI_emp_ap_num.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_ap_num.Name = "MI_emp_ap_num"
        Me.MI_emp_ap_num.Size = New System.Drawing.Size(95, 13)
        Me.MI_emp_ap_num.TabIndex = 38
        Me.MI_emp_ap_num.Text = "Apartment Number"
        '
        'MI_emp_street_num_tb
        '
        Me.MI_emp_street_num_tb.Location = New System.Drawing.Point(520, 147)
        Me.MI_emp_street_num_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_street_num_tb.Name = "MI_emp_street_num_tb"
        Me.MI_emp_street_num_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_street_num_tb.TabIndex = 37
        '
        'MI_emp_street_num
        '
        Me.MI_emp_street_num.AutoSize = True
        Me.MI_emp_street_num.Location = New System.Drawing.Point(361, 147)
        Me.MI_emp_street_num.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_street_num.Name = "MI_emp_street_num"
        Me.MI_emp_street_num.Size = New System.Drawing.Size(75, 13)
        Me.MI_emp_street_num.TabIndex = 36
        Me.MI_emp_street_num.Text = "Street Number"
        '
        'MI_emp_street_tb
        '
        Me.MI_emp_street_tb.Location = New System.Drawing.Point(520, 117)
        Me.MI_emp_street_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_street_tb.Name = "MI_emp_street_tb"
        Me.MI_emp_street_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_street_tb.TabIndex = 35
        '
        'MI_emp_street
        '
        Me.MI_emp_street.AutoSize = True
        Me.MI_emp_street.Location = New System.Drawing.Point(361, 117)
        Me.MI_emp_street.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_street.Name = "MI_emp_street"
        Me.MI_emp_street.Size = New System.Drawing.Size(35, 13)
        Me.MI_emp_street.TabIndex = 34
        Me.MI_emp_street.Text = "Street"
        '
        'MI_emp_zip_tb
        '
        Me.MI_emp_zip_tb.Location = New System.Drawing.Point(520, 89)
        Me.MI_emp_zip_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_zip_tb.Name = "MI_emp_zip_tb"
        Me.MI_emp_zip_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_zip_tb.TabIndex = 33
        '
        'MI_emp_state
        '
        Me.MI_emp_state.AutoSize = True
        Me.MI_emp_state.Location = New System.Drawing.Point(361, 60)
        Me.MI_emp_state.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_state.Name = "MI_emp_state"
        Me.MI_emp_state.Size = New System.Drawing.Size(32, 13)
        Me.MI_emp_state.TabIndex = 32
        Me.MI_emp_state.Text = "State"
        '
        'MI_emp_state_tb
        '
        Me.MI_emp_state_tb.Location = New System.Drawing.Point(520, 60)
        Me.MI_emp_state_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_state_tb.Name = "MI_emp_state_tb"
        Me.MI_emp_state_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_state_tb.TabIndex = 31
        '
        'MI_emp_zip
        '
        Me.MI_emp_zip.AutoSize = True
        Me.MI_emp_zip.Location = New System.Drawing.Point(361, 89)
        Me.MI_emp_zip.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_zip.Name = "MI_emp_zip"
        Me.MI_emp_zip.Size = New System.Drawing.Size(50, 13)
        Me.MI_emp_zip.TabIndex = 30
        Me.MI_emp_zip.Text = "Zip Code"
        '
        'MI_emp_city
        '
        Me.MI_emp_city.AutoSize = True
        Me.MI_emp_city.Location = New System.Drawing.Point(361, 34)
        Me.MI_emp_city.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_city.Name = "MI_emp_city"
        Me.MI_emp_city.Size = New System.Drawing.Size(24, 13)
        Me.MI_emp_city.TabIndex = 29
        Me.MI_emp_city.Text = "City"
        '
        'MI_emp_city_tb
        '
        Me.MI_emp_city_tb.Location = New System.Drawing.Point(520, 34)
        Me.MI_emp_city_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_city_tb.Name = "MI_emp_city_tb"
        Me.MI_emp_city_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_city_tb.TabIndex = 28
        '
        'MI_rem_emp_btn
        '
        Me.MI_rem_emp_btn.Location = New System.Drawing.Point(222, 188)
        Me.MI_rem_emp_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_rem_emp_btn.Name = "MI_rem_emp_btn"
        Me.MI_rem_emp_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_rem_emp_btn.TabIndex = 26
        Me.MI_rem_emp_btn.Text = "Remove Employee"
        Me.MI_rem_emp_btn.UseVisualStyleBackColor = True
        '
        'MI_edit_emp_btn
        '
        Me.MI_edit_emp_btn.Location = New System.Drawing.Point(124, 188)
        Me.MI_edit_emp_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_edit_emp_btn.Name = "MI_edit_emp_btn"
        Me.MI_edit_emp_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_edit_emp_btn.TabIndex = 25
        Me.MI_edit_emp_btn.Text = "Edit Employee"
        Me.MI_edit_emp_btn.UseVisualStyleBackColor = True
        '
        'MI_emp_hr_tb
        '
        Me.MI_emp_hr_tb.Location = New System.Drawing.Point(178, 147)
        Me.MI_emp_hr_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_hr_tb.Name = "MI_emp_hr_tb"
        Me.MI_emp_hr_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_hr_tb.TabIndex = 24
        '
        'MI_emp_hr
        '
        Me.MI_emp_hr.AutoSize = True
        Me.MI_emp_hr.Location = New System.Drawing.Point(19, 147)
        Me.MI_emp_hr.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_hr.Name = "MI_emp_hr"
        Me.MI_emp_hr.Size = New System.Drawing.Size(63, 13)
        Me.MI_emp_hr.TabIndex = 23
        Me.MI_emp_hr.Text = "Hourly Rate"
        '
        'MI_emp_start_tb
        '
        Me.MI_emp_start_tb.Location = New System.Drawing.Point(178, 117)
        Me.MI_emp_start_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_start_tb.Name = "MI_emp_start_tb"
        Me.MI_emp_start_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_start_tb.TabIndex = 22
        '
        'MI_emp_start
        '
        Me.MI_emp_start.AutoSize = True
        Me.MI_emp_start.Location = New System.Drawing.Point(19, 117)
        Me.MI_emp_start.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_start.Name = "MI_emp_start"
        Me.MI_emp_start.Size = New System.Drawing.Size(55, 13)
        Me.MI_emp_start.TabIndex = 21
        Me.MI_emp_start.Text = "Start Date"
        '
        'MI_emp_ln_tb
        '
        Me.MI_emp_ln_tb.Location = New System.Drawing.Point(178, 89)
        Me.MI_emp_ln_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_ln_tb.Name = "MI_emp_ln_tb"
        Me.MI_emp_ln_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_ln_tb.TabIndex = 20
        '
        'MI_emp_fn
        '
        Me.MI_emp_fn.AutoSize = True
        Me.MI_emp_fn.Location = New System.Drawing.Point(19, 60)
        Me.MI_emp_fn.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_fn.Name = "MI_emp_fn"
        Me.MI_emp_fn.Size = New System.Drawing.Size(57, 13)
        Me.MI_emp_fn.TabIndex = 19
        Me.MI_emp_fn.Text = "First Name"
        '
        'MI_emp_fn_tb
        '
        Me.MI_emp_fn_tb.Location = New System.Drawing.Point(178, 60)
        Me.MI_emp_fn_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_fn_tb.Name = "MI_emp_fn_tb"
        Me.MI_emp_fn_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_fn_tb.TabIndex = 18
        '
        'MI_emp_ln
        '
        Me.MI_emp_ln.AutoSize = True
        Me.MI_emp_ln.Location = New System.Drawing.Point(19, 89)
        Me.MI_emp_ln.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_ln.Name = "MI_emp_ln"
        Me.MI_emp_ln.Size = New System.Drawing.Size(58, 13)
        Me.MI_emp_ln.TabIndex = 17
        Me.MI_emp_ln.Text = "Last Name"
        '
        'MI_emp_sin
        '
        Me.MI_emp_sin.AutoSize = True
        Me.MI_emp_sin.Location = New System.Drawing.Point(19, 34)
        Me.MI_emp_sin.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MI_emp_sin.Name = "MI_emp_sin"
        Me.MI_emp_sin.Size = New System.Drawing.Size(74, 13)
        Me.MI_emp_sin.TabIndex = 16
        Me.MI_emp_sin.Text = "Employee SIN"
        '
        'MI_emp_sin_tb
        '
        Me.MI_emp_sin_tb.Location = New System.Drawing.Point(178, 34)
        Me.MI_emp_sin_tb.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_emp_sin_tb.Name = "MI_emp_sin_tb"
        Me.MI_emp_sin_tb.Size = New System.Drawing.Size(121, 20)
        Me.MI_emp_sin_tb.TabIndex = 15
        '
        'MI_add_emp_btn
        '
        Me.MI_add_emp_btn.Location = New System.Drawing.Point(22, 188)
        Me.MI_add_emp_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_add_emp_btn.Name = "MI_add_emp_btn"
        Me.MI_add_emp_btn.Size = New System.Drawing.Size(77, 50)
        Me.MI_add_emp_btn.TabIndex = 14
        Me.MI_add_emp_btn.Text = "Add Employee"
        Me.MI_add_emp_btn.UseVisualStyleBackColor = True
        '
        'MI_DataTab
        '
        Me.MI_DataTab.Controls.Add(Me.MI_most_active)
        Me.MI_DataTab.Controls.Add(Me.MI_sr)
        Me.MI_DataTab.Controls.Add(Me.MI_list_options)
        Me.MI_DataTab.Controls.Add(Me.MI_active_custs_btn)
        Me.MI_DataTab.Controls.Add(Me.MI_list_rentals_btn)
        Me.MI_DataTab.Controls.Add(Me.MI_list_movies_btn)
        Me.MI_DataTab.Controls.Add(Me.MI_sr_btn)
        Me.MI_DataTab.Location = New System.Drawing.Point(4, 22)
        Me.MI_DataTab.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_DataTab.Name = "MI_DataTab"
        Me.MI_DataTab.Padding = New System.Windows.Forms.Padding(1)
        Me.MI_DataTab.Size = New System.Drawing.Size(696, 266)
        Me.MI_DataTab.TabIndex = 2
        Me.MI_DataTab.Text = "Data"
        Me.MI_DataTab.UseVisualStyleBackColor = True
        '
        'MI_most_active
        '
        Me.MI_most_active.AutoSize = True
        Me.MI_most_active.Location = New System.Drawing.Point(485, 47)
        Me.MI_most_active.Name = "MI_most_active"
        Me.MI_most_active.Size = New System.Drawing.Size(97, 13)
        Me.MI_most_active.TabIndex = 8
        Me.MI_most_active.Text = "Check Most Active"
        '
        'MI_sr
        '
        Me.MI_sr.AutoSize = True
        Me.MI_sr.Location = New System.Drawing.Point(256, 47)
        Me.MI_sr.Name = "MI_sr"
        Me.MI_sr.Size = New System.Drawing.Size(68, 13)
        Me.MI_sr.TabIndex = 7
        Me.MI_sr.Text = "Sales Report"
        '
        'MI_list_options
        '
        Me.MI_list_options.AutoSize = True
        Me.MI_list_options.Location = New System.Drawing.Point(29, 47)
        Me.MI_list_options.Name = "MI_list_options"
        Me.MI_list_options.Size = New System.Drawing.Size(62, 13)
        Me.MI_list_options.TabIndex = 6
        Me.MI_list_options.Text = "List Options"
        '
        'MI_active_custs_btn
        '
        Me.MI_active_custs_btn.Location = New System.Drawing.Point(488, 82)
        Me.MI_active_custs_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_active_custs_btn.Name = "MI_active_custs_btn"
        Me.MI_active_custs_btn.Size = New System.Drawing.Size(178, 34)
        Me.MI_active_custs_btn.TabIndex = 4
        Me.MI_active_custs_btn.Text = "Most Active"
        Me.MI_active_custs_btn.UseVisualStyleBackColor = True
        '
        'MI_list_rentals_btn
        '
        Me.MI_list_rentals_btn.Location = New System.Drawing.Point(29, 146)
        Me.MI_list_rentals_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_list_rentals_btn.Name = "MI_list_rentals_btn"
        Me.MI_list_rentals_btn.Size = New System.Drawing.Size(178, 34)
        Me.MI_list_rentals_btn.TabIndex = 2
        Me.MI_list_rentals_btn.Text = "List Current Rentals"
        Me.MI_list_rentals_btn.UseVisualStyleBackColor = True
        '
        'MI_list_movies_btn
        '
        Me.MI_list_movies_btn.Location = New System.Drawing.Point(29, 82)
        Me.MI_list_movies_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_list_movies_btn.Name = "MI_list_movies_btn"
        Me.MI_list_movies_btn.Size = New System.Drawing.Size(178, 34)
        Me.MI_list_movies_btn.TabIndex = 1
        Me.MI_list_movies_btn.Text = "List All Movies"
        Me.MI_list_movies_btn.UseVisualStyleBackColor = True
        '
        'MI_sr_btn
        '
        Me.MI_sr_btn.Location = New System.Drawing.Point(259, 82)
        Me.MI_sr_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.MI_sr_btn.Name = "MI_sr_btn"
        Me.MI_sr_btn.Size = New System.Drawing.Size(178, 34)
        Me.MI_sr_btn.TabIndex = 0
        Me.MI_sr_btn.Text = "Produce Sales Report"
        Me.MI_sr_btn.UseVisualStyleBackColor = True
        '
        'Main_Manager_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 343)
        Me.Controls.Add(Me.ManagerTab1)
        Me.Controls.Add(Me.ManagerLabel)
        Me.Name = "Main_Manager_Interface"
        Me.Text = "Form1"
        Me.ManagerTab1.ResumeLayout(False)
        Me.MI_MoiveTab.ResumeLayout(False)
        Me.MI_MoiveTab.PerformLayout()
        Me.MI_EmpTab.ResumeLayout(False)
        Me.MI_EmpTab.PerformLayout()
        Me.MI_DataTab.ResumeLayout(False)
        Me.MI_DataTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ManagerLabel As Label
    Friend WithEvents ManagerTab1 As TabControl
    Friend WithEvents MI_MoiveTab As TabPage
    Friend WithEvents MI_dist_fee_tb As TextBox
    Friend WithEvents MI_dist_fee As Label
    Friend WithEvents MI_movie_type_tb As TextBox
    Friend WithEvents MI_movie_title As Label
    Friend WithEvents MI_movie_title_tb As TextBox
    Friend WithEvents MI_movie_type As Label
    Friend WithEvents MI_movie_id As Label
    Friend WithEvents MI_movie_id_tb As TextBox
    Friend WithEvents MI_add_movie_btn As Button
    Friend WithEvents MI_EmpTab As TabPage
    Friend WithEvents MI_DataTab As TabPage
    Friend WithEvents MI_sr_btn As Button
    Friend WithEvents MI_inventory_tb As TextBox
    Friend WithEvents MI_inventory As Label
    Friend WithEvents MI_edit_movie_btn As Button
    Friend WithEvents MI_rem_movie_btn As Button
    Friend WithEvents MI_movie_note1 As Label
    Friend WithEvents MI_rem_emp_btn As Button
    Friend WithEvents MI_edit_emp_btn As Button
    Friend WithEvents MI_emp_hr_tb As TextBox
    Friend WithEvents MI_emp_hr As Label
    Friend WithEvents MI_emp_start_tb As TextBox
    Friend WithEvents MI_emp_start As Label
    Friend WithEvents MI_emp_ln_tb As TextBox
    Friend WithEvents MI_emp_fn As Label
    Friend WithEvents MI_emp_fn_tb As TextBox
    Friend WithEvents MI_emp_ln As Label
    Friend WithEvents MI_emp_sin As Label
    Friend WithEvents MI_emp_sin_tb As TextBox
    Friend WithEvents MI_add_emp_btn As Button
    Friend WithEvents MI_emp_street_num_tb As TextBox
    Friend WithEvents MI_emp_street_num As Label
    Friend WithEvents MI_emp_street_tb As TextBox
    Friend WithEvents MI_emp_street As Label
    Friend WithEvents MI_emp_zip_tb As TextBox
    Friend WithEvents MI_emp_state As Label
    Friend WithEvents MI_emp_state_tb As TextBox
    Friend WithEvents MI_emp_zip As Label
    Friend WithEvents MI_emp_city As Label
    Friend WithEvents MI_emp_city_tb As TextBox
    Friend WithEvents MI_emp_ap_num_tb As TextBox
    Friend WithEvents MI_emp_ap_num As Label
    Friend WithEvents MI_active_custs_btn As Button
    Friend WithEvents MI_list_rentals_btn As Button
    Friend WithEvents MI_list_movies_btn As Button
    Friend WithEvents MI_most_active As Label
    Friend WithEvents MI_sr As Label
    Friend WithEvents MI_list_options As Label
End Class
