Public Class Form1
    Public Function factorial(ByVal X As Integer, ByVal N As Integer)
        If (N > 0) Then
            X = factorial(X, N - 1)
            X = X * N
        Else
            X = 1
        End If
        Return X
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As Integer
        Dim N As Integer
        N = TextBox1.Text
        X = factorial(X, N)
        TextBox2.Text = Trim(X)
    End Sub
End Class
