Imports System.Data.SqlClient
Public Class details
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If idcb.Text = "" Then
            MessageBox.Show("Enter ID")
            Exit Sub
        End If
        con.Open()
        Dim cmd As New SqlCommand("select * from IssueTbl where stdid=@stdid", con)
        cmd.Parameters.Add("@stdid", SqlDbType.Int).Value = idcb.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()
        adapter.Fill(tb)
        bookcb.DataSource = tb
        issuedate.DataSource = tb
        bookcb.DisplayMember = "BookIssued"
        issuedate.DisplayMember = "IssueDate"
        con.Close()

        stuname.Text = ""
        studept.Text = ""
        stuphone.Text = ""
        bookcb.Text = ""
        issuedate.Text = ""


        If tb.Rows.Count() > 0 Then
            idcb.Text = tb.Rows(0)(1).ToString()
            stuname.Text = tb.Rows(0)(2).ToString()
            studept.Text = tb.Rows(0)(3).ToString()
            stuphone.Text = tb.Rows(0)(4).ToString()
            bookcb.Text = tb.Rows(0)(5).ToString()
            issuedate.Text = tb.Rows(0)(6).ToString()

        Else
            MessageBox.Show("No Data Found")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        options.Show()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        idcb.Text = ""
        stuname.Text = ""
        studept.Text = ""
        stuphone.Text = ""
        bookcb.Text = ""
        issuedate.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()
        options.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If idcb.Text = "" Then
            MessageBox.Show("Enter ID")
            Exit Sub
        End If
        con.Open()
        Dim cmmd As New SqlCommand("select * from FacIssueTbl where ID=@ID", con)
        cmmd.Parameters.Add("@ID", SqlDbType.Int).Value = idcb.Text
        Dim adapt As New SqlDataAdapter(cmmd)
        Dim dt As New DataTable()
        adapt.Fill(dt)
        bookcb.DataSource = dt
        issuedate.DataSource = dt
        bookcb.DisplayMember = "Books"
        issuedate.DisplayMember = "Issue Date"
        con.Close()

        stuname.Text = ""
        'studept.Text = ""
        stuphone.Text = ""
        bookcb.Text = ""
        issuedate.Text = ""

        If dt.Rows.Count() > 0 Then
            idcb.Text = dt.Rows(0)(1).ToString()
            stuname.Text = dt.Rows(0)(2).ToString()
            'studept.Text = dt.Rows(0)(3).ToString()
            stuphone.Text = dt.Rows(0)(3).ToString()
            bookcb.Text = dt.Rows(0)(4).ToString()
            issuedate.Text = dt.Rows(0)(5).ToString()

        Else
            MessageBox.Show("No Data Found")
        End If

    End Sub

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class