Public Class Form1

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        RichTextBox1.AppendText(TextPalabra.Text & " ")

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Environment.Exit(0)
    End Sub

    Private Sub TextPalabra_TextChanged(sender As Object, e As EventArgs) Handles TextPalabra.MouseEnter

        TextBox2.Text = TextPalabra.SelectionLength
    End Sub
    Private Sub ButtonLimpiar1_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar1.Click
        TextPalabra.Clear()
    End Sub

    Private Sub ButtonLimpiar2_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar2.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub TextPalabra_TextChanged_1(sender As Object, e As EventArgs) Handles TextPalabra.TextChanged
        TextBox1.Text = TextPalabra.TextLength

    End Sub

    Private Sub TextPalabra_MouseLeave(sender As Object, e As EventArgs) Handles TextPalabra.MouseLeave
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub


End Class
