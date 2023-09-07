<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class issuebook
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IssueNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdDeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet3 = New library_management.msdbDataSet3()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stuname = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.stuphone = New System.Windows.Forms.TextBox()
        Me.studept = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bookcb = New System.Windows.Forms.ComboBox()
        Me.issuedate = New System.Windows.Forms.DateTimePicker()
        Me.idcb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.issueno = New System.Windows.Forms.TextBox()
        Me.IssueTblTableAdapter = New library_management.msdbDataSet3TableAdapters.IssueTblTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueNumDataGridViewTextBoxColumn, Me.StdidDataGridViewTextBoxColumn, Me.StdNameDataGridViewTextBoxColumn, Me.StdDeptDataGridViewTextBoxColumn, Me.StdPhoneDataGridViewTextBoxColumn, Me.BookIssuedDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IssueTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(307, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 464)
        Me.DataGridView1.TabIndex = 17
        '
        'IssueNumDataGridViewTextBoxColumn
        '
        Me.IssueNumDataGridViewTextBoxColumn.DataPropertyName = "IssueNum"
        Me.IssueNumDataGridViewTextBoxColumn.HeaderText = "IssueNum"
        Me.IssueNumDataGridViewTextBoxColumn.Name = "IssueNumDataGridViewTextBoxColumn"
        Me.IssueNumDataGridViewTextBoxColumn.Width = 60
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
        Me.StdNameDataGridViewTextBoxColumn.Width = 110
        '
        'StdDeptDataGridViewTextBoxColumn
        '
        Me.StdDeptDataGridViewTextBoxColumn.DataPropertyName = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn.HeaderText = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn.Name = "StdDeptDataGridViewTextBoxColumn"
        Me.StdDeptDataGridViewTextBoxColumn.Width = 80
        '
        'StdPhoneDataGridViewTextBoxColumn
        '
        Me.StdPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn.HeaderText = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn.Name = "StdPhoneDataGridViewTextBoxColumn"
        '
        'BookIssuedDataGridViewTextBoxColumn
        '
        Me.BookIssuedDataGridViewTextBoxColumn.DataPropertyName = "BookIssued"
        Me.BookIssuedDataGridViewTextBoxColumn.HeaderText = "BookIssued"
        Me.BookIssuedDataGridViewTextBoxColumn.Name = "BookIssuedDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        Me.IssueDateDataGridViewTextBoxColumn.Width = 130
        '
        'IssueTblBindingSource
        '
        Me.IssueTblBindingSource.DataMember = "IssueTbl"
        Me.IssueTblBindingSource.DataSource = Me.MsdbDataSet3
        '
        'MsdbDataSet3
        '
        Me.MsdbDataSet3.DataSetName = "msdbDataSet3"
        Me.MsdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 67)
        Me.Panel1.TabIndex = 18
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.library_management.My.Resources.Resources.download
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(899, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.library_management.My.Resources.Resources.images
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(936, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.library_management.My.Resources.Resources._463_4637625_x_button_close_x_button_png_transparent_png
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(973, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(402, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISSUE BOOKS"
        '
        'stuname
        '
        Me.stuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuname.Location = New System.Drawing.Point(154, 196)
        Me.stuname.Name = "stuname"
        Me.stuname.Size = New System.Drawing.Size(134, 24)
        Me.stuname.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(9, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 37)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(81, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Issue Book"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'stuphone
        '
        Me.stuphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuphone.Location = New System.Drawing.Point(154, 289)
        Me.stuphone.Name = "stuphone"
        Me.stuphone.Size = New System.Drawing.Size(134, 24)
        Me.stuphone.TabIndex = 38
        '
        'studept
        '
        Me.studept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studept.Location = New System.Drawing.Point(154, 242)
        Me.studept.Name = "studept"
        Me.studept.Size = New System.Drawing.Size(134, 24)
        Me.studept.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Student ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Book"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 387)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Issue Date"
        '
        'bookcb
        '
        Me.bookcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookcb.FormattingEnabled = True
        Me.bookcb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.bookcb.Location = New System.Drawing.Point(154, 336)
        Me.bookcb.Name = "bookcb"
        Me.bookcb.Size = New System.Drawing.Size(134, 26)
        Me.bookcb.TabIndex = 45
        '
        'issuedate
        '
        Me.issuedate.CustomFormat = ""
        Me.issuedate.Location = New System.Drawing.Point(115, 387)
        Me.issuedate.Name = "issuedate"
        Me.issuedate.Size = New System.Drawing.Size(184, 20)
        Me.issuedate.TabIndex = 46
        '
        'idcb
        '
        Me.idcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idcb.FormattingEnabled = True
        Me.idcb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.idcb.Location = New System.Drawing.Point(154, 142)
        Me.idcb.Name = "idcb"
        Me.idcb.Size = New System.Drawing.Size(134, 26)
        Me.idcb.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 48
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(174, 522)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 37)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Issue No."
        '
        'issueno
        '
        Me.issueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issueno.Location = New System.Drawing.Point(154, 95)
        Me.issueno.Name = "issueno"
        Me.issueno.Size = New System.Drawing.Size(134, 24)
        Me.issueno.TabIndex = 51
        '
        'IssueTblTableAdapter
        '
        Me.IssueTblTableAdapter.ClearBeforeFill = True
        '
        'issuebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1016, 580)
        Me.Controls.Add(Me.issueno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idcb)
        Me.Controls.Add(Me.issuedate)
        Me.Controls.Add(Me.bookcb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.stuname)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.stuphone)
        Me.Controls.Add(Me.studept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "issuebook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "issuebook"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents stuname As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents stuphone As TextBox
    Friend WithEvents studept As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents bookcb As ComboBox
    Friend WithEvents issuedate As DateTimePicker
    Friend WithEvents idcb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents issueno As TextBox
    Friend WithEvents MsdbDataSet3 As msdbDataSet3
    Friend WithEvents IssueTblBindingSource As BindingSource
    Friend WithEvents IssueTblTableAdapter As msdbDataSet3TableAdapters.IssueTblTableAdapter
    Friend WithEvents IssueNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdDeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIssuedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
