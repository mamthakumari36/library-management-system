Imports System.Data.SqlClient
Public Class librarianform

    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")
    Private Sub librarianform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet14.LibrarianTbl' table. You can move, or remove it, as needed.
        Me.LibrarianTblTableAdapter1.Fill(Me.MsdbDataSet14.LibrarianTbl)
        'TODO: This line of code loads data into the 'MsdbDataSet.LibrarianTbl' table. You can move, or remove it, as needed.
        'Me.LibrarianTblTableAdapter.Fill(Me.MsdbDataSet.LibrarianTbl)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If libid.Text = "" Or libname.Text = "" Or libpass.Text = "" Or libphone.Text = "" Then
            MessageBox.Show("missing inforamtion")
        Else
            con.Open()
            Dim cmd As New SqlCommand("insert into LibrarianTbl values(" + libid.Text + ",'" + libname.Text + "','" + libpass.Text + "','" + libphone.Text + "') ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("librarian added successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim cmd As New SqlCommand("delete from LibrarianTbl where libid = @libid", con)
            cmd.Parameters.AddWithValue("libid", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.LibrarianTblTableAdapter1.Fill(Me.MsdbDataSet14.LibrarianTbl)
        MessageBox.Show("Librarian Data Deleted ")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        mainform.Close()
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        libid.Text = selectedrow.Cells(0).Value.ToString()
        libname.Text = selectedrow.Cells(1).Value.ToString()
        libpass.Text = selectedrow.Cells(2).Value.ToString()
        libphone.Text = selectedrow.Cells(3).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If libid.Text = "" Or libname.Text = "" Or libpass.Text = "" Or libphone.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            con.Open()
            Dim query As New String("update LibrarianTbl set LibName='" + libname.Text + "',LibPassword='" + libpass.Text + "',LibPhone='" + libphone.Text + "' where Libid=" + libid.Text + "")
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("updated successfully")
            con.Close()
        End If
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