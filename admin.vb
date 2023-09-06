Imports System.Data.SqlClient
Public Class Admin
    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Enter username or password")
            Exit Sub
        End If
        con.Open()
            Dim sda As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM LibrarianTbl where LibName ='" + TextBox1.Text + "' and LibPassword=" + TextBox2.Text + "", con)

            Dim dt As New DataTable()
            sda.Fill(dt)

            If dt.Rows.Count > 0 Then
                mainform.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class