﻿Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dato As Integer
        Dim resultado As Integer
        dato = TextBox1.Text
        For i = 1 To 10
            resultado = dato * i

        Next
    End Sub
End Class