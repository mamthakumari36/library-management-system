Imports System.Data.SqlClient
Public Class faculty
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")

    Private Sub faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet6.FacultyTbl' table. You can move, or remove it, as needed.
        Me.FacultyTblTableAdapter.Fill(Me.MsdbDataSet6.FacultyTbl)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If facid.Text = "" Or facname.Text = "" Or facno.Text = "" Then
            MessageBox.Show("missing inforamtion")
        Else
            con.Open()
            Dim cmd As New SqlCommand("insert into FacultyTbl values(" + facid.Text + ",'" + facname.Text + "','" + facno.Text + "') ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Details added successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        student.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim cmd As New SqlCommand("delete from FacultyTbl where Id= @Id", con)
            cmd.Parameters.AddWithValue("Id", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.FacultyTblTableAdapter.Fill(Me.MsdbDataSet6.FacultyTbl)
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
End Class