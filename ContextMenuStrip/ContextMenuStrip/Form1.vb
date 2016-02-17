Public Class Form1

    Private Sub ArialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialToolStripMenuItem.Click
        TextBox1.Font = New Font("Arial", 20)
    End Sub

    Private Sub GeorgiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeorgiaToolStripMenuItem.Click
        TextBox1.Font = New Font("Georgia", 20)
    End Sub

    Private Sub StencilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StencilToolStripMenuItem.Click
        TextBox1.Font = New Font("Stencil", 20)
    End Sub

    Private Sub MAYUSCULASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAYUSCULASToolStripMenuItem.Click
        If TextBox1.Text = TextBox1.Text.ToUpper Then
            MsgBox("Ya esta en MAYUSCULAS")
        Else
            TextBox1.Text = TextBox1.Text.ToUpper
        End If
    End Sub

    Private Sub MinusculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinusculasToolStripMenuItem.Click
        If TextBox1.Text = TextBox1.Text.ToLower Then
            MsgBox("Ya esta en minusculas")
        Else
            TextBox1.Text = TextBox1.Text.ToLower
        End If
    End Sub
End Class
