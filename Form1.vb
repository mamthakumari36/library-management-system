Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Admin" Then
            Admin.Show()
            options.Close()
        ElseIf ComboBox1.Text = "Other Users" Then
            options.Show()
            Admin.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Admin.Close()
        options.Close()
    End Sub
End Class
