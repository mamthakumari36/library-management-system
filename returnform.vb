Imports System.Data.SqlClient
Public Class returnform
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")


    Private Sub returnform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet5.ReturnTbl' table. You can move, or remove it, as needed.
        Me.ReturnTblTableAdapter.Fill(Me.MsdbDataSet5.ReturnTbl)
        'TODO: This line of code loads data into the 'MsdbDataSet4.IssueTbl' table. You can move, or remove it, as needed.
        Me.IssueTblTableAdapter.Fill(Me.MsdbDataSet4.IssueTbl)


        'to display listed book
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
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        'returnno.Text = selectedrow.Cells(0).Value.ToString()
        idcb.Text = selectedrow.Cells(1).Value.ToString()
        stuname.Text = selectedrow.Cells(2).Value.ToString()
        studept.Text = selectedrow.Cells(3).Value.ToString()
        stuphone.Text = selectedrow.Cells(4).Value.ToString()
        bookcb.Text = selectedrow.Cells(5).Value.ToString()
        issuedate.Text = selectedrow.Cells(6).Value.ToString()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        mainform.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If returnno.Text = "" Or stuname.Text = "" Then
            MessageBox.Show("missing inforamtion")
        Else
            con.Open()
            Dim cmdd As New SqlCommand("insert into ReturnTbl values(" + returnno.Text + ",'" + idcb.Text + "','" + stuname.Text + "','" + studept.Text + "','" + stuphone.Text + "','" + bookcb.SelectedValue.ToString() + "','" + issuedate.Value + "','" + returndate.Value + "') ", con)
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
        For i As Integer = 0 To DataGridView2.SelectedRows.Count - 1
            Dim cmmd As New SqlCommand("delete from ReturnTbl where  ReturnNum= @ReturnNum", con)
            cmmd.Parameters.AddWithValue("ReturnNum", DataGridView2.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.ReturnTblTableAdapter.Fill(Me.MsdbDataSet5.ReturnTbl)
        MessageBox.Show(" Data Deleted ")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        mainform.Close()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        mainform.Show()
    End Sub
End Class