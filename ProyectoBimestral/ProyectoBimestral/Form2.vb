Public Class Form2
    Dim contador As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim User1 As String = "Alex"
        Dim User2 As String = "Guest"
        Dim Pass1 As String = "z11111"
        Dim Pass2 As String = "a11111"
        If contador <> 3 Then
        End If

        If User1.Equals(TextBox2.Text) And TextBox1.Text = Pass1 Or User2.Equals(TextBox2.Text) And TextBox1.Text = Pass2 Then
            MsgBox("Bienvenido al Sistema " & TextBox2.Text, MsgBoxStyle.Exclamation)
            Me.Hide()
            Form3.Show()
        Else
            contador += 1
            MsgBox("Error de Identificación " & contador, MsgBoxStyle.Critical)
        End If
        If contador = 3 Then
            MsgBox("Intenta más Tarde, Adios ", MsgBoxStyle.Critical)
            Me.Hide()
            Form1.Show()
        End If

    End Sub
End Class