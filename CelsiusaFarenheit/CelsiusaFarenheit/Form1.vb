Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As Int32 = 0


        Try
                c = Convert.ToInt32(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Introduce un numero")
                TextBox1.Text = ""
            End Try
        If c <> 0 Or c = 0 Then

            TextBox2.Text = ((c * 9) / 5) + 32
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As Int32 = 0


        Try
            c = Convert.ToInt32(TextBox2.Text)
        Catch ex As Exception
            MsgBox("Introduce un numero")
            TextBox2.Text = ""
        End Try
        If c <> 0 Or c = 0 Then

            TextBox1.Text = ((c - 32) * 5) / 9
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        TextBox1.Focus()
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter
        TextBox2.Focus()
        TextBox2.SelectAll()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
