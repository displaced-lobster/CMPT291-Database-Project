﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_All_Movies
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
        Me.data_grid_movies = New System.Windows.Forms.DataGridView()
        Me.movie_list_close_btn = New System.Windows.Forms.Button()
        CType(Me.data_grid_movies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid_movies
        '
        Me.data_grid_movies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_movies.Location = New System.Drawing.Point(-8, 86)
        Me.data_grid_movies.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.data_grid_movies.Name = "data_grid_movies"
        Me.data_grid_movies.ReadOnly = True
        Me.data_grid_movies.Size = New System.Drawing.Size(1000, 850)
        Me.data_grid_movies.TabIndex = 0
        Me.data_grid_movies.VirtualMode = True
        '
        'movie_list_close_btn
        '
        Me.movie_list_close_btn.Location = New System.Drawing.Point(18, 18)
        Me.movie_list_close_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.movie_list_close_btn.Name = "movie_list_close_btn"
        Me.movie_list_close_btn.Size = New System.Drawing.Size(112, 35)
        Me.movie_list_close_btn.TabIndex = 1
        Me.movie_list_close_btn.Text = "Close"
        Me.movie_list_close_btn.UseVisualStyleBackColor = True
        '
        'List_All_Movies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 937)
        Me.Controls.Add(Me.movie_list_close_btn)
        Me.Controls.Add(Me.data_grid_movies)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "List_All_Movies"
        Me.Text = "Comprehensive Movie List"
        CType(Me.data_grid_movies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_grid_movies As DataGridView
    Friend WithEvents movie_list_close_btn As Button
End Class