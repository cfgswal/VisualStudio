Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As basedatos = New basedatos

        bd.insertar(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bd As basedatos = New basedatos

        bd.modificar(TextBox1.Text, TextBox2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bd As basedatos = New basedatos

        bd.eliminar(TextBox2.Text)
    End Sub
End Class
