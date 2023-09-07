Imports System.Data.SqlClient

Public Class studentForm

    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")


    Private Sub studentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet1.StudentTbl' table. You can move, or remove it, as needed.
        Me.StudentTblTableAdapter.Fill(Me.MsdbDataSet1.StudentTbl)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stdid.Text = "" Or stdname.Text = "" Or stsem.Text = "" Or stdept.Text = "" Or stconta.Text = "" Then
            MessageBox.Show("missing inforamtion")
        Else
            con.Open()
            Dim cmd As New SqlCommand("insert into StudentTbl values(" + stdid.Text + ",'" + stdname.Text + "','" + stdept.Text + "','" + stsem.SelectedItem.ToString() + "','" + stconta.Text + "') ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully")
            con.Close()
            DataGridView1.MultiSelect = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim cmd As New SqlCommand("delete from StudentTbl where stdid = @stdid", con)
            cmd.Parameters.AddWithValue("stdid", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        Me.StudentTblTableAdapter.Fill(Me.MsdbDataSet1.StudentTbl)
        MessageBox.Show("Student Data Deleted ")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        stdid.Text = selectedrow.Cells(0).Value.ToString()
        stdname.Text = selectedrow.Cells(1).Value.ToString()
        stdept.Text = selectedrow.Cells(2).Value.ToString()
        stsem.Text = selectedrow.Cells(3).Value.ToString()
        stconta.Text = selectedrow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If stdid.Text = "" Or stdname.Text = "" Or stdept.Text = "" Or stsem.Text = "" Or stconta.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
          con.Open()
            Dim query As New String("update StudentTbl set StdName='" + stdname.Text + "',StdDepartment='" + stdept.Text + "',StdSem='" + stsem.Text + "',StdPhone='" + stconta.Text + "' where Stdid=" + stdid.Text + "")
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