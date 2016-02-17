Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ListBox1.SelectionMode = SelectionMode.One
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ListBox1.SelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ListBox1.MultiColumn = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If ListBox1.Sorted = False Then
            ListBox1.Sorted = True
        Else
            ListBox1.Sorted = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iposicion As Integer = ListBox1.FindString(TextBox1.Text)
        If iposicion <> -1 Then
            ListBox1.SetSelected(iposicion, True)
        Else
            MessageBox.Show("No encuentro el valor")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.SelectedItem.
    End Sub
End Class
