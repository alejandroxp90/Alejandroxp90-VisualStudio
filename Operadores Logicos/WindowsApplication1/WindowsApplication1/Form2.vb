Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then
            Label5.Text = Single.Parse(TextBox1.Text) + Single.Parse(TextBox2.Text)

        ElseIf CheckBox2.Checked = True Then
            Label5.Text = Single.Parse(TextBox1.Text) - Single.Parse(TextBox2.Text)

        ElseIf CheckBox3.Checked = True Then
            Label5.Text = Single.Parse(TextBox1.Text) * Single.Parse(TextBox2.Text)

        ElseIf CheckBox4.Checked = True Then
            Label5.Text = Single.Parse(TextBox1.Text) / Single.Parse(TextBox2.Text)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub
End Class