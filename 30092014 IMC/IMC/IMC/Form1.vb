Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Label9.Text = TextBox1.Text
        Form2.Label10.Text = TextBox2.Text
        Form2.Label11.Text = TextBox3.Text
        Form2.Label13.Text = TextBox4.Text
        Form2.Label14.Text = TextBox5.Text
        Form2.Label12.Text = ComboBox1.Text

        Dim Peso As Single = TextBox4.Text
        Dim Altura As Single = TextBox5.Text
        Dim Cuadrado As Single = Altura * Altura
        Dim IMC As Single

        'Dim Peso = TextBox4.Text
        'Dim Altura = TextBox5.Text
        ' Dim Cuadrado = Altura * Altura
        IMC = Peso / Cuadrado

        ' IMC = Convert.ToSingle(Peso) / Convert.ToSingle(Cuadrado)


        Form2.Label16.Text = IMC

        Me.Hide()
        Form2.Show()


    End Sub
End Class
