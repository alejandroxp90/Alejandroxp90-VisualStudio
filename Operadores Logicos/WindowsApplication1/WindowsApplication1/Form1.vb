Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "V" Or TextBox1.Text = "v") And (TextBox2.Text = "V" Or TextBox2.Text = "v") Then

            Label1.Text = "V AND F =  F"
            Label2.Text = "F AND V =  F"
            Label3.Text = "F AND F =  F"
            Label4.Text = "V AND V =  V"
        Else
            Label1.Text = "V AND F =  F"
            Label2.Text = "F AND V =  F"
            Label3.Text = "F AND F =  F"
            Label4.Text = "V AND V =  F"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label1.Text = "V AND F =  ."
        Label2.Text = "F AND V =  ."
        Label3.Text = "F AND F =  ."
        Label4.Text = "V AND V =  ."
        Label5.Text = "V OR F =  ."
        Label6.Text = "F OR V =  ."
        Label7.Text = "F OR F =  ."
        Label8.Text = "V OR V =  ."
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox3.Text = "F" Or TextBox3.Text = "f") And (TextBox4.Text = "F" Or TextBox4.Text = "f") Then
            Label5.Text = "V OR F =  V"
            Label6.Text = "F OR V =  V"
            Label7.Text = "F OR F =  F"
            Label8.Text = "V OR V =  V"

        Else
            Label5.Text = "V OR F =  F"
            Label6.Text = "F OR V =  F"
            Label7.Text = "F OR F =  F"
            Label8.Text = "V OR V =  F"


        End If
    End Sub
End Class
