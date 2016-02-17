Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True


        RichTextBox1.Text = "Texto de prueba"

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TextoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem1.Click
        Dim micolor As New ColorDialog
        micolor.AllowFullOpen = True
    End Sub
End Class