Imports System.Data.SqlClient
Public Class bookform
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")

    Private Sub bookform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet2.BookTbl' table. You can move, or remove it, as needed.
        Me.BookTblTableAdapter.Fill(Me.MsdbDataSet2.BookTbl)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bookname.Text = "" Or bookauth.Text = "" Or bookpub.Text = "" Or bookpri.Text = "" Or bookqua.Text = "" Then
            MessageBox.Show("missing inforamtion")
        Else
            con.Open()
            Dim cmd As New SqlCommand("insert into BookTbl values('" + bookname.Text + "','" + bookauth.Text + "','" + bookpub.Text + "'," + bookpri.Text + "," + bookqua.Text + ") ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book added successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim cmd As New SqlCommand("delete from BookTbl where Bookname = @Bookname", con)
            cmd.Parameters.AddWithValue("bookname", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.BookTblTableAdapter.Fill(Me.MsdbDataSet2.BookTbl)
        MessageBox.Show("Book Data Deleted ")
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'to display the contents in textboxes
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        bookname.Text = selectedrow.Cells(0).Value.ToString()
        bookauth.Text = selectedrow.Cells(1).Value.ToString()
        bookpub.Text = selectedrow.Cells(2).Value.ToString()
        bookpri.Text = selectedrow.Cells(3).Value.ToString()
        bookqua.Text = selectedrow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bookname.Text = "" Or bookauth.Text = "" Or bookpub.Text = "" Or bookpri.Text = "" Or bookqua.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            con.Open()
            Dim query As New String("update BookTbl set Author='" + bookauth.Text + "',Publisher='" + bookpub.Text + "',Price=" + bookpri.Text + ",Qty='" + bookqua.Text + "' where Bookname='" + bookname.Text + "'")
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("updated successfully")
            con.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        mainform.Show()
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
End Class