<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class librarianform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LibidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibrarianTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet = New library_management.msdbDataSet()
        Me.libpass = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.libphone = New System.Windows.Forms.TextBox()
        Me.libname = New System.Windows.Forms.TextBox()
        Me.libid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LibrarianTblTableAdapter = New library_management.msdbDataSetTableAdapters.LibrarianTblTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MsdbDataSet14 = New library_management.msdbDataSet14()
        Me.LibrarianTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarianTblTableAdapter1 = New library_management.msdbDataSet14TableAdapters.LibrarianTblTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarianTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarianTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(975, 67)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.library_management.My.Resources.Resources.download
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(858, 3)
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
        Me.PictureBox2.Location = New System.Drawing.Point(895, 3)
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
        Me.PictureBox1.Location = New System.Drawing.Point(932, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(402, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIBRARIANS"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LibidDataGridViewTextBoxColumn, Me.LibNameDataGridViewTextBoxColumn, Me.LibPasswordDataGridViewTextBoxColumn, Me.LibPhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibrarianTblBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(376, 83)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(586, 464)
        Me.DataGridView1.TabIndex = 16
        '
        'LibidDataGridViewTextBoxColumn
        '
        Me.LibidDataGridViewTextBoxColumn.DataPropertyName = "Libid"
        Me.LibidDataGridViewTextBoxColumn.HeaderText = "Libid"
        Me.LibidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LibidDataGridViewTextBoxColumn.Name = "LibidDataGridViewTextBoxColumn"
        Me.LibidDataGridViewTextBoxColumn.Width = 110
        '
        'LibNameDataGridViewTextBoxColumn
        '
        Me.LibNameDataGridViewTextBoxColumn.DataPropertyName = "LibName"
        Me.LibNameDataGridViewTextBoxColumn.HeaderText = "LibName"
        Me.LibNameDataGridViewTextBoxColumn.Name = "LibNameDataGridViewTextBoxColumn"
        Me.LibNameDataGridViewTextBoxColumn.Width = 150
        '
        'LibPasswordDataGridViewTextBoxColumn
        '
        Me.LibPasswordDataGridViewTextBoxColumn.DataPropertyName = "LibPassword"
        Me.LibPasswordDataGridViewTextBoxColumn.HeaderText = "LibPassword"
        Me.LibPasswordDataGridViewTextBoxColumn.Name = "LibPasswordDataGridViewTextBoxColumn"
        Me.LibPasswordDataGridViewTextBoxColumn.Width = 140
        '
        'LibPhoneDataGridViewTextBoxColumn
        '
        Me.LibPhoneDataGridViewTextBoxColumn.DataPropertyName = "LibPhone"
        Me.LibPhoneDataGridViewTextBoxColumn.HeaderText = "LibPhone"
        Me.LibPhoneDataGridViewTextBoxColumn.Name = "LibPhoneDataGridViewTextBoxColumn"
        Me.LibPhoneDataGridViewTextBoxColumn.Width = 140
        '
        'LibrarianTblBindingSource
        '
        Me.LibrarianTblBindingSource.DataMember = "LibrarianTbl"
        Me.LibrarianTblBindingSource.DataSource = Me.MsdbDataSet
        '
        'MsdbDataSet
        '
        Me.MsdbDataSet.DataSetName = "msdbDataSet"
        Me.MsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'libpass
        '
        Me.libpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libpass.Location = New System.Drawing.Point(163, 237)
        Me.libpass.Name = "libpass"
        Me.libpass.Size = New System.Drawing.Size(134, 24)
        Me.libpass.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(244, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 37)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(129, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'libphone
        '
        Me.libphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libphone.Location = New System.Drawing.Point(163, 293)
        Me.libphone.Name = "libphone"
        Me.libphone.Size = New System.Drawing.Size(134, 24)
        Me.libphone.TabIndex = 37
        '
        'libname
        '
        Me.libname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libname.Location = New System.Drawing.Point(163, 183)
        Me.libname.Name = "libname"
        Me.libname.Size = New System.Drawing.Size(134, 24)
        Me.libname.TabIndex = 36
        '
        'libid
        '
        Me.libid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libid.Location = New System.Drawing.Point(163, 126)
        Me.libid.Name = "libid"
        Me.libid.Size = New System.Drawing.Size(134, 24)
        Me.libid.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Phone No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ID"
        '
        'LibrarianTblTableAdapter
        '
        Me.LibrarianTblTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(129, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 37)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MsdbDataSet14
        '
        Me.MsdbDataSet14.DataSetName = "msdbDataSet14"
        Me.MsdbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrarianTblBindingSource1
        '
        Me.LibrarianTblBindingSource1.DataMember = "LibrarianTbl"
        Me.LibrarianTblBindingSource1.DataSource = Me.MsdbDataSet14
        '
        'LibrarianTblTableAdapter1
        '
        Me.LibrarianTblTableAdapter1.ClearBeforeFill = True
        '
        'librarianform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(975, 580)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.libpass)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.libphone)
        Me.Controls.Add(Me.libname)
        Me.Controls.Add(Me.libid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "librarianform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "librarianform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarianTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarianTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents libpass As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents libphone As TextBox
    Friend WithEvents libname As TextBox
    Friend WithEvents libid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MsdbDataSet As msdbDataSet
    Friend WithEvents LibrarianTblBindingSource As BindingSource
    Friend WithEvents LibrarianTblTableAdapter As msdbDataSetTableAdapters.LibrarianTblTableAdapter
    Friend WithEvents LibidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MsdbDataSet14 As msdbDataSet14
    Friend WithEvents LibrarianTblBindingSource1 As BindingSource
    Friend WithEvents LibrarianTblTableAdapter1 As msdbDataSet14TableAdapters.LibrarianTblTableAdapter
End Class
