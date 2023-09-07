<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stdid = New System.Windows.Forms.TextBox()
        Me.stdname = New System.Windows.Forms.TextBox()
        Me.stdept = New System.Windows.Forms.TextBox()
        Me.stconta = New System.Windows.Forms.TextBox()
        Me.stsem = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdDepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdSemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet1 = New library_management.msdbDataSet1()
        Me.StudentTblTableAdapter = New library_management.msdbDataSet1TableAdapters.StudentTblTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(366, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact No."
        '
        'stdid
        '
        Me.stdid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdid.Location = New System.Drawing.Point(161, 132)
        Me.stdid.Name = "stdid"
        Me.stdid.Size = New System.Drawing.Size(134, 24)
        Me.stdid.TabIndex = 6
        '
        'stdname
        '
        Me.stdname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdname.Location = New System.Drawing.Point(161, 188)
        Me.stdname.Name = "stdname"
        Me.stdname.Size = New System.Drawing.Size(134, 24)
        Me.stdname.TabIndex = 7
        '
        'stdept
        '
        Me.stdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdept.Location = New System.Drawing.Point(161, 243)
        Me.stdept.Name = "stdept"
        Me.stdept.Size = New System.Drawing.Size(134, 24)
        Me.stdept.TabIndex = 8
        '
        'stconta
        '
        Me.stconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stconta.Location = New System.Drawing.Point(161, 361)
        Me.stconta.Name = "stconta"
        Me.stconta.Size = New System.Drawing.Size(134, 24)
        Me.stconta.TabIndex = 9
        '
        'stsem
        '
        Me.stsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsem.FormattingEnabled = True
        Me.stsem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.stsem.Location = New System.Drawing.Point(161, 301)
        Me.stsem.Name = "stsem"
        Me.stsem.Size = New System.Drawing.Size(134, 26)
        Me.stsem.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(141, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(248, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 37)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StdidDataGridViewTextBoxColumn, Me.StdNameDataGridViewTextBoxColumn, Me.StdDepartmentDataGridViewTextBoxColumn, Me.StdSemDataGridViewTextBoxColumn, Me.StdPhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(373, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 464)
        Me.DataGridView1.TabIndex = 14
        '
        'StdidDataGridViewTextBoxColumn
        '
        Me.StdidDataGridViewTextBoxColumn.DataPropertyName = "Stdid"
        Me.StdidDataGridViewTextBoxColumn.HeaderText = "Stdid"
        Me.StdidDataGridViewTextBoxColumn.Name = "StdidDataGridViewTextBoxColumn"
        Me.StdidDataGridViewTextBoxColumn.Width = 80
        '
        'StdNameDataGridViewTextBoxColumn
        '
        Me.StdNameDataGridViewTextBoxColumn.DataPropertyName = "StdName"
        Me.StdNameDataGridViewTextBoxColumn.HeaderText = "StdName"
        Me.StdNameDataGridViewTextBoxColumn.Name = "StdNameDataGridViewTextBoxColumn"
        Me.StdNameDataGridViewTextBoxColumn.Width = 150
        '
        'StdDepartmentDataGridViewTextBoxColumn
        '
        Me.StdDepartmentDataGridViewTextBoxColumn.DataPropertyName = "StdDepartment"
        Me.StdDepartmentDataGridViewTextBoxColumn.HeaderText = "StdDepartment"
        Me.StdDepartmentDataGridViewTextBoxColumn.Name = "StdDepartmentDataGridViewTextBoxColumn"
        '
        'StdSemDataGridViewTextBoxColumn
        '
        Me.StdSemDataGridViewTextBoxColumn.DataPropertyName = "StdSem"
        Me.StdSemDataGridViewTextBoxColumn.HeaderText = "StdSem"
        Me.StdSemDataGridViewTextBoxColumn.Name = "StdSemDataGridViewTextBoxColumn"
        '
        'StdPhoneDataGridViewTextBoxColumn
        '
        Me.StdPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn.HeaderText = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn.Name = "StdPhoneDataGridViewTextBoxColumn"
        Me.StdPhoneDataGridViewTextBoxColumn.Width = 120
        '
        'StudentTblBindingSource
        '
        Me.StudentTblBindingSource.DataMember = "StudentTbl"
        Me.StudentTblBindingSource.DataSource = Me.MsdbDataSet1
        '
        'MsdbDataSet1
        '
        Me.MsdbDataSet1.DataSetName = "msdbDataSet1"
        Me.MsdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTblTableAdapter
        '
        Me.StudentTblTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(141, 481)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 37)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.library_management.My.Resources.Resources.download
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(856, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.library_management.My.Resources.Resources.images
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(893, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.library_management.My.Resources.Resources._463_4637625_x_button_close_x_button_png_transparent_png
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(930, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'studentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(970, 580)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.stsem)
        Me.Controls.Add(Me.stconta)
        Me.Controls.Add(Me.stdept)
        Me.Controls.Add(Me.stdname)
        Me.Controls.Add(Me.stdid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stdid As TextBox
    Friend WithEvents stdname As TextBox
    Friend WithEvents stdept As TextBox
    Friend WithEvents stconta As TextBox
    Friend WithEvents stsem As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MsdbDataSet1 As msdbDataSet1
    Friend WithEvents StudentTblBindingSource As BindingSource
    Friend WithEvents StudentTblTableAdapter As msdbDataSet1TableAdapters.StudentTblTableAdapter
    Friend WithEvents StdidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdDepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdSemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
