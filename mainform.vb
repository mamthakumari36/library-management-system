Public Class mainform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentForm.Show()
        bookform.Close()
        issuebook.Close()
        returnform.Close()
        librarianform.Close()
        student.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bookform.Show()
        studentForm.Close()
        issuebook.Close()
        returnform.Close()
        librarianform.Close()
        student.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        librarianform.Show()
        bookform.Close()
        studentForm.Close()
        issuebook.Close()
        returnform.Close()
        student.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        issuebook.Show()
        student.Close()
        bookform.Close()
        studentForm.Close()
        returnform.Close()
        librarianform.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        returnform.Show()
        issuebook.Close()
        student.Close()
        bookform.Close()
        studentForm.Close()
        librarianform.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        student.Show()
        returnform.Close()
        issuebook.Close()
        bookform.Close()
        studentForm.Close()
        librarianform.Close()
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
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

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class