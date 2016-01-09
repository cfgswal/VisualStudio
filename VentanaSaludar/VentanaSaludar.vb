Public Class Form1
    Public Sub saludocast(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TextBox1.Text = "HOLA"
    End Sub
    Public Sub saludoeusk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = "KAIXO"
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        TextBox1.Text = ""
        AddHandler Button1.Click, AddressOf saludocast
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Text = ""
        AddHandler Button1.Click, AddressOf saludoeusk
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub VentanaSaludar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
