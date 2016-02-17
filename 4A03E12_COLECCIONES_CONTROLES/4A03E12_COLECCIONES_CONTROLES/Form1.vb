Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is TextBox) Then
                Controls(x).Enabled = False
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nueva As Label = New Label()
        nueva.Location = New Point(452, 645)
        nueva.Text = "nueva"
        Controls.Add(nueva)

        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is Label) Then
                Controls(x).ForeColor = Color.DarkRed
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controls.Remove(TextBox1)

        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is TextBox) Then
                Controls(x).BackColor = Color.DarkGreen
            End If

        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is Button) Then
                Controls(x).BackColor = Color.Blue
            End If
        Next
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Environment.Exit(0)
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub BOTONESAZULESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOTONESAZULESToolStripMenuItem.Click
        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is Button) Then
                Controls(x).BackColor = Color.Blue
            End If
        Next
    End Sub

    Private Sub ETIQUETASROJASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ETIQUETASROJASToolStripMenuItem.Click
        Dim nueva As Label = New Label()
        nueva.Location = New Point(452, 645)
        nueva.Text = "nueva"
        Controls.Add(nueva)

        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is Label) Then
                Controls(x).ForeColor = Color.DarkRed
            End If
        Next
    End Sub

    Private Sub CAJASVERDESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAJASVERDESToolStripMenuItem.Click
        Controls.Remove(TextBox1)

        For x = 0 To Controls.Count - 1
            If (TypeOf Controls(x) Is TextBox) Then
                Controls(x).BackColor = Color.DarkGreen
            End If

        Next
    End Sub
End Class
