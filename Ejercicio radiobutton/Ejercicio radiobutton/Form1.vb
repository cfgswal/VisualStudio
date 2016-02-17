Public Class Form1



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        If RadioButton4.Checked = True Then
            TextBox1.BackColor = Color.Green
        ElseIf RadioButton5.Checked = True Then
            TextBox1.BackColor = Color.Blue
        ElseIf RadioButton6.Checked = True Then
            TextBox1.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        If RadioButton1.Checked = True Then
            TextBox1.Font = New Font("Tahoma", 15)
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Font = New Font("Garamond", 15)
        ElseIf RadioButton3.Checked = True Then
            TextBox1.Font = New Font("Comic Sans MS", 15)
        End If
    End Sub
End Class
