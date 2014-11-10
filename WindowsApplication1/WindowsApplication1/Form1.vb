Public Class Form1

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = Val(TextBox1.Text)
        b = 1
        For c = 1 To a
            b = b * c
            TextBox2.Text = (b)
        Next
    End Sub
End Class