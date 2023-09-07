Imports System.Data.SqlClient
Public Class facultyissue
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        student.Show()
    End Sub


    Private Sub facultyissue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet12.FacIssueTbl' table. You can move, or remove it, as needed.
        Me.FacIssueTblTableAdapter1.Fill(Me.MsdbDataSet12.FacIssueTbl)
        'TODO: This line of code loads data into the 'MsdbDataSet9.FacReturnTbl' table. You can move, or remove it, as needed.
        Me.FacReturnTblTableAdapter1.Fill(Me.MsdbDataSet9.FacReturnTbl)
        'TODO: This line of code loads data into the 'MsdbDataSet7.FacIssueTbl' table. You can move, or remove it, as needed.
        ' Me.FacIssueTblTableAdapter.Fill(Me.MsdbDataSet7.FacIssueTbl)

        'to show registered student id 
        con.Open()
        Dim cmd As New SqlCommand("select Id from FacultyTbl ", con)
        Dim rdr As SqlDataReader
        rdr = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("Id")
        dt.Load(rdr)
        idcb.ValueMember = "Id"
        idcb.DataSource = dt
        con.Close()

        'to display available book for issue
        con.Open()
        Dim cmmd As New SqlCommand("select Bookname from BookTbl where Qty>0", con)
        Dim rdrr As SqlDataReader
        rdrr = cmmd.ExecuteReader()
        Dim dtt As New DataTable()
        dtt.Columns.Add("Bookname")
        dtt.Load(rdrr)
        bookcb.ValueMember = "Bookname"
        bookcb.DataSource = dtt
        con.Close()
    End Sub


    Private Sub idcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles idcb.SelectionChangeCommitted
        con.Open()
        Dim query As String = "select * from FacultyTbl where Id=" + idcb.SelectedValue.ToString() + ""
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        For Each dr As DataRow In dt.Rows

            TextBox1.Text = dr("Name").ToString()
            TextBox2.Text = dr("Contact No.").ToString()
        Next
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("Enter IssueNo")
        Else
            con.Open()
            Dim cmdd As New SqlCommand("insert into FacIssueTbl values(" + TextBox3.Text + ",'" + idcb.SelectedValue.ToString() + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + bookcb.SelectedValue.ToString() + "','" + DateTimePicker1.Value + "') ", con)
            cmdd.ExecuteNonQuery()
            MessageBox.Show("Issued Book successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
        '---------------------------------------------------------------------------------------------'

        'to decrease book quantity

        Dim Qty, newQty As String
        con.Open()
        Dim query As String = "select * from BookTbl where Bookname='" + bookcb.SelectedValue.ToString() + "' "
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        For Each dr As DataRow In dt.Rows
            Qty = Convert.ToInt32(dr("Qty").ToString())
            newQty = Qty - 1
            Dim query1 As String = "update BookTbl set Qty= " + newQty + " where Bookname= '" + bookcb.SelectedValue.ToString() + "' "
            Dim cmd1 As New SqlCommand(query1, con)
            cmd1.ExecuteNonQuery()
        Next
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("Enter ReturnNo")
        Else
            con.Open()
            Dim cmdd As New SqlCommand("insert into FacReturnTbl values(" + TextBox4.Text + ",'" + idcb.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + bookcb.Text + "','" + DateTimePicker1.Value + "','" + DateTimePicker2.Value + "') ", con)
            cmdd.ExecuteNonQuery()
            MessageBox.Show("Return Book successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
        'to restore book quantity

        Dim Qty, newQty As String
        con.Open()
        Dim query As String = "select * from BookTbl where Bookname='" + bookcb.SelectedValue.ToString() + "' "
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        For Each dr As DataRow In dt.Rows
            Qty = Convert.ToInt32(dr("Qty").ToString())
            newQty = Qty + 1
            Dim query1 As String = "update BookTbl set Qty= " + newQty + " where Bookname= '" + bookcb.SelectedValue.ToString() + "' "
            Dim cmd1 As New SqlCommand(query1, con)
            cmd1.ExecuteNonQuery()
        Next
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'to delete data from return table
        For i As Integer = 0 To DataGridView2.SelectedRows.Count - 1
            Dim cmmd As New SqlCommand("delete from FacReturnTbl where  ReturnNo= @ReturnNo", con)
            cmmd.Parameters.AddWithValue("ReturnNo", DataGridView2.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.FacReturnTblTableAdapter1.Fill(Me.MsdbDataSet9.FacReturnTbl)

        'to delete data from issue table

        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim cmmd As New SqlCommand("delete from FacIssueTbl where  IssueNo= @IssueNo", con)
            cmmd.Parameters.AddWithValue("IssueNo", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.FacIssueTblTableAdapter1.Fill(Me.MsdbDataSet12.FacIssueTbl)
        MessageBox.Show(" Data Deleted ")

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        mainform.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        TextBox3.Text = selectedrow.Cells(0).Value.ToString()
        idcb.Text = selectedrow.Cells(1).Value.ToString()
        TextBox1.Text = selectedrow.Cells(2).Value.ToString()
        TextBox2.Text = selectedrow.Cells(3).Value.ToString()
        bookcb.Text = selectedrow.Cells(4).Value.ToString()
        DateTimePicker1.Text = selectedrow.Cells(5).Value.ToString()
    End Sub


End Class