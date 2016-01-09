Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(600, 500)
        Me.BackColor = Color.Green
        Me.Text = "HOLA"
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Label1.Visible = True

    End Sub
End Class
