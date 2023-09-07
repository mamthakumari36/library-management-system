Imports System.Data.SqlClient
Public Class student

    Dim con As New SqlConnection("Data Source=DESKTOP-D58BFB7;Initial Catalog=msdb;Integrated Security=True ")


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        faculty.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        facultyissue.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class