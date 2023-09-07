<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnform
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IssueNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdDeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet4 = New library_management.msdbDataSet4()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.studept = New System.Windows.Forms.TextBox()
        Me.stuphone = New System.Windows.Forms.TextBox()
        Me.stuname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.returndate = New System.Windows.Forms.DateTimePicker()
        Me.bookcb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IssueTblTableAdapter = New library_management.msdbDataSet4TableAdapters.IssueTblTableAdapter()
        Me.returnno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ReturnNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdDeptDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdPhoneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet5 = New library_management.msdbDataSet5()
        Me.issuedate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReturnTblTableAdapter = New library_management.msdbDataSet5TableAdapters.ReturnTblTableAdapter()
        Me.idcb = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(999, 67)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.library_management.My.Resources.Resources.download
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(882, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.library_management.My.Resources.Resources.images
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(919, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.library_management.My.Resources.Resources._463_4637625_x_button_close_x_button_png_transparent_png
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(956, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(352, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RETURNED BOOKS "
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
        Me.DataGridView1.Location = New System.Drawing.Point(292, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(700, 244)
        Me.DataGridView1.TabIndex = 20
        '
        'IssueNumDataGridViewTextBoxColumn
        '
        Me.IssueNumDataGridViewTextBoxColumn.DataPropertyName = "IssueNum"
        Me.IssueNumDataGridViewTextBoxColumn.HeaderText = "IssueNum"
        Me.IssueNumDataGridViewTextBoxColumn.Name = "IssueNumDataGridViewTextBoxColumn"
        Me.IssueNumDataGridViewTextBoxColumn.Width = 80
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
        Me.StdNameDataGridViewTextBoxColumn.Width = 140
        '
        'StdDeptDataGridViewTextBoxColumn
        '
        Me.StdDeptDataGridViewTextBoxColumn.DataPropertyName = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn.HeaderText = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn.Name = "StdDeptDataGridViewTextBoxColumn"
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
        '
        'IssueTblBindingSource
        '
        Me.IssueTblBindingSource.DataMember = "IssueTbl"
        Me.IssueTblBindingSource.DataSource = Me.MsdbDataSet4
        '
        'MsdbDataSet4
        '
        Me.MsdbDataSet4.DataSetName = "msdbDataSet4"
        Me.MsdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Return Date"
        '
        'studept
        '
        Me.studept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studept.Location = New System.Drawing.Point(152, 238)
        Me.studept.Name = "studept"
        Me.studept.Size = New System.Drawing.Size(134, 24)
        Me.studept.TabIndex = 56
        '
        'stuphone
        '
        Me.stuphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuphone.Location = New System.Drawing.Point(152, 295)
        Me.stuphone.Name = "stuphone"
        Me.stuphone.Size = New System.Drawing.Size(134, 24)
        Me.stuphone.TabIndex = 54
        '
        'stuname
        '
        Me.stuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuname.Location = New System.Drawing.Point(152, 184)
        Me.stuname.Name = "stuname"
        Me.stuname.Size = New System.Drawing.Size(134, 24)
        Me.stuname.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "BooksReturned"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Phone No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Student ID"
        '
        'returndate
        '
        Me.returndate.Location = New System.Drawing.Point(152, 457)
        Me.returndate.Name = "returndate"
        Me.returndate.Size = New System.Drawing.Size(134, 20)
        Me.returndate.TabIndex = 64
        '
        'bookcb
        '
        Me.bookcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookcb.FormattingEnabled = True
        Me.bookcb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.bookcb.Location = New System.Drawing.Point(152, 347)
        Me.bookcb.Name = "bookcb"
        Me.bookcb.Size = New System.Drawing.Size(134, 26)
        Me.bookcb.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(578, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Books Issued"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(578, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 20)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Books Returned"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 37)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Return Book"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(166, 559)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 37)
        Me.Button5.TabIndex = 72
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'IssueTblTableAdapter
        '
        Me.IssueTblTableAdapter.ClearBeforeFill = True
        '
        'returnno
        '
        Me.returnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnno.Location = New System.Drawing.Point(152, 82)
        Me.returnno.Name = "returnno"
        Me.returnno.Size = New System.Drawing.Size(134, 24)
        Me.returnno.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "return No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 20)
        Me.Label12.TabIndex = 73
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReturnNumDataGridViewTextBoxColumn, Me.StdidDataGridViewTextBoxColumn1, Me.StdNameDataGridViewTextBoxColumn1, Me.StdDeptDataGridViewTextBoxColumn1, Me.StdPhoneDataGridViewTextBoxColumn1, Me.BookReturnedDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn1, Me.ReturnDateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ReturnTblBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(292, 370)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(700, 244)
        Me.DataGridView2.TabIndex = 78
        '
        'ReturnNumDataGridViewTextBoxColumn
        '
        Me.ReturnNumDataGridViewTextBoxColumn.DataPropertyName = "ReturnNum"
        Me.ReturnNumDataGridViewTextBoxColumn.HeaderText = "ReturnNum"
        Me.ReturnNumDataGridViewTextBoxColumn.Name = "ReturnNumDataGridViewTextBoxColumn"
        Me.ReturnNumDataGridViewTextBoxColumn.Width = 80
        '
        'StdidDataGridViewTextBoxColumn1
        '
        Me.StdidDataGridViewTextBoxColumn1.DataPropertyName = "Stdid"
        Me.StdidDataGridViewTextBoxColumn1.HeaderText = "Stdid"
        Me.StdidDataGridViewTextBoxColumn1.Name = "StdidDataGridViewTextBoxColumn1"
        Me.StdidDataGridViewTextBoxColumn1.Width = 80
        '
        'StdNameDataGridViewTextBoxColumn1
        '
        Me.StdNameDataGridViewTextBoxColumn1.DataPropertyName = "StdName"
        Me.StdNameDataGridViewTextBoxColumn1.HeaderText = "StdName"
        Me.StdNameDataGridViewTextBoxColumn1.Name = "StdNameDataGridViewTextBoxColumn1"
        '
        'StdDeptDataGridViewTextBoxColumn1
        '
        Me.StdDeptDataGridViewTextBoxColumn1.DataPropertyName = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn1.HeaderText = "StdDept"
        Me.StdDeptDataGridViewTextBoxColumn1.Name = "StdDeptDataGridViewTextBoxColumn1"
        '
        'StdPhoneDataGridViewTextBoxColumn1
        '
        Me.StdPhoneDataGridViewTextBoxColumn1.DataPropertyName = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn1.HeaderText = "StdPhone"
        Me.StdPhoneDataGridViewTextBoxColumn1.Name = "StdPhoneDataGridViewTextBoxColumn1"
        '
        'BookReturnedDataGridViewTextBoxColumn
        '
        Me.BookReturnedDataGridViewTextBoxColumn.DataPropertyName = "BookReturned"
        Me.BookReturnedDataGridViewTextBoxColumn.HeaderText = "BookReturned"
        Me.BookReturnedDataGridViewTextBoxColumn.Name = "BookReturnedDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn1
        '
        Me.IssueDateDataGridViewTextBoxColumn1.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn1.HeaderText = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn1.Name = "IssueDateDataGridViewTextBoxColumn1"
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        '
        'ReturnTblBindingSource
        '
        Me.ReturnTblBindingSource.DataMember = "ReturnTbl"
        Me.ReturnTblBindingSource.DataSource = Me.MsdbDataSet5
        '
        'MsdbDataSet5
        '
        Me.MsdbDataSet5.DataSetName = "msdbDataSet5"
        Me.MsdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'issuedate
        '
        Me.issuedate.Location = New System.Drawing.Point(152, 399)
        Me.issuedate.Name = "issuedate"
        Me.issuedate.Size = New System.Drawing.Size(134, 20)
        Me.issuedate.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Issue Date"
        '
        'ReturnTblTableAdapter
        '
        Me.ReturnTblTableAdapter.ClearBeforeFill = True
        '
        'idcb
        '
        Me.idcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idcb.FormattingEnabled = True
        Me.idcb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.idcb.Location = New System.Drawing.Point(152, 131)
        Me.idcb.Name = "idcb"
        Me.idcb.Size = New System.Drawing.Size(134, 26)
        Me.idcb.TabIndex = 81
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(26, 559)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 37)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'returnform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(999, 626)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.idcb)
        Me.Controls.Add(Me.issuedate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.returnno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bookcb)
        Me.Controls.Add(Me.returndate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.studept)
        Me.Controls.Add(Me.stuphone)
        Me.Controls.Add(Me.stuname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "returnform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "returnform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents studept As TextBox
    Friend WithEvents stuphone As TextBox
    Friend WithEvents stuname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents returndate As DateTimePicker
    Friend WithEvents bookcb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MsdbDataSet4 As msdbDataSet4
    Friend WithEvents IssueTblBindingSource As BindingSource
    Friend WithEvents IssueTblTableAdapter As msdbDataSet4TableAdapters.IssueTblTableAdapter
    Friend WithEvents returnno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents issuedate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents MsdbDataSet5 As msdbDataSet5
    Friend WithEvents ReturnTblBindingSource As BindingSource
    Friend WithEvents ReturnTblTableAdapter As msdbDataSet5TableAdapters.ReturnTblTableAdapter
    Friend WithEvents IssueNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdDeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIssuedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StdNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StdDeptDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StdPhoneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BookReturnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idcb As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
