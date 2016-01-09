Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Red
        Button1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Green
        Button1.Enabled = False
        Label1.Text = "MI FORMULARIO"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.BackColor = Color.Blue
        Button1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Environment.Exit(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "HOLA MUNDO!!!"
        Button1.Enabled = False
    End Sub
End Class
