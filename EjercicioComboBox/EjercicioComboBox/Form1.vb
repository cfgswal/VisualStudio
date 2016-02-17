Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add("azul")
        ComboBox1.Items.Add("rojo")
        ComboBox1.Items.Add("verde")
        ComboBox1.Items.Add("amarillo")
        ComboBox1.Items.Add("blanco")
        ComboBox1.Items.Add("negro")
        ComboBox1.Items.Add("morado")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Add(TextBox2.Text)
        TextBox2.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = ComboBox1.SelectedItem

    End Sub
End Class
