Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Alex" And TextBox2.Text = "11111" Then
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
        Else
            MsgBox("Usuario y/o contraseña incorrecta")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox3.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox4.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox5.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox3.Text = TextBox6.Text Then
            GroupBox6.Enabled = True
            GroupBox3.Enabled = False
            Label16.Text = TextBox3.Text
            Label17.Text = ComboBox1.Text
        Else
            MsgBox("no concuerdan los numeros telefonicos")
            TextBox3.Text = ""
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox4.Text = TextBox7.Text Then
            GroupBox6.Enabled = True
            GroupBox4.Enabled = False
            Label16.Text = TextBox4.Text
            Label17.Text = ComboBox2.Text
        Else
            MsgBox("no concuerdan los numeros telefonicos")
            TextBox4.Text = ""
            TextBox7.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox5.Text = TextBox8.Text Then
            GroupBox6.Enabled = True
            GroupBox5.Enabled = False
            Label16.Text = TextBox5.Text
            Label17.Text = ComboBox3.Text
        Else
            MsgBox("Numeros telefonicos Incorrectos")
            TextBox5.Text = ""
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ComboBox4.Text = "Tarjeta de Credito" Then
            GroupBox7.Enabled = True
            GroupBox6.Enabled = False
        ElseIf ComboBox4.SelectedItem = "Efectivo" Then
            GroupBox8.Enabled = True
            GroupBox6.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.Label2.Text = ComboBox5.Text
        Form2.Label4.Text = TextBox9.Text
        Form2.Label9.Text = TextBox13.Text
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("Recarga exitosa")
        Me.Update()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.MaxLength = 10
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox6.MaxLength = 10
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter
        Form2.Label2.Text = TextBox5.Text
        Form2.Label4.Text = TextBox9.Text
        Form2.Label9.Text = TextBox13.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.MaxLength = 10
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.MaxLength = 10
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.MaxLength = 10
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox7.MaxLength = 10
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox10.MaxLength = 4
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TextBox11.MaxLength = 4
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        TextBox12.MaxLength = 4
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        TextBox13.MaxLength = 4
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        TextBox14.MaxLength = 3
    End Sub
End Class