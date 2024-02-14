Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized
        ' Change background color to red
        Me.BackColor = Color.Red



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the application
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class





