Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        If RichTextBox1.SelectedText.Count > 0 Then
            Clipboard.SetText(RichTextBox1.SelectedText)
            RichTextBox1.SelectedText = ""
        End If
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub CourierNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourierNewToolStripMenuItem.Click
        CourierNewToolStripMenuItem.Checked = True
        ArielToolStripMenuItem.Checked = False
        SymbolToolStripMenuItem.Checked = False

        RichTextBox1.Font = New Font("CourierNew", RichTextBox1.Font.Size)

    End Sub

    Private Sub ArielToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArielToolStripMenuItem.Click
        CourierNewToolStripMenuItem.Checked = False
        ArielToolStripMenuItem.Checked = True
        SymbolToolStripMenuItem.Checked = False
        RichTextBox1.Font = New Font("Arial", RichTextBox1.Font.Size)
    End Sub

    Private Sub SymbolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymbolToolStripMenuItem.Click
        SymbolToolStripMenuItem.Checked = True
        ArielToolStripMenuItem.Checked = False
        CourierNewToolStripMenuItem.Checked = False
        RichTextBox1.Font = New Font("Symbol", RichTextBox1.Font.Size)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ToolStripMenuItem2.Checked = True
        ToolStripMenuItem3.Checked = False
        ToolStripMenuItem4.Checked = False
        RichTextBox1.Font = New Font(RichTextBox1.Font.Name, 10)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ToolStripMenuItem2.Checked = False
        ToolStripMenuItem3.Checked = True
        ToolStripMenuItem4.Checked = False
        RichTextBox1.Font = New Font(RichTextBox1.Font.Name, 12)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ToolStripMenuItem2.Checked = False
        ToolStripMenuItem3.Checked = False
        ToolStripMenuItem4.Checked = True
        RichTextBox1.Font = New Font(RichTextBox1.Font.Name, 24)
    End Sub

    Private Sub BlancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlancoToolStripMenuItem.Click
        BlancoToolStripMenuItem.Checked = True
        VerdeToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        RichTextBox1.BackColor = Color.White
    End Sub

    Private Sub VerdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerdeToolStripMenuItem.Click
        BlancoToolStripMenuItem.Checked = False
        VerdeToolStripMenuItem.Checked = True
        AzulToolStripMenuItem.Checked = False
        RichTextBox1.BackColor = Color.Green
    End Sub

    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click
        BlancoToolStripMenuItem.Checked = False
        VerdeToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = True
        RichTextBox1.BackColor = Color.Blue
    End Sub

    Private Sub NegroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegroToolStripMenuItem.Click
        NegroToolStripMenuItem.Checked = True
        VerdeToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub VerdeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerdeToolStripMenuItem1.Click
        NegroToolStripMenuItem.Checked = False
        VerdeToolStripMenuItem.Checked = True
        AzulToolStripMenuItem.Checked = False
        RichTextBox1.ForeColor = Color.Green
    End Sub

    Private Sub AzulToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem1.Click
        NegroToolStripMenuItem.Checked = False
        VerdeToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = True
        RichTextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub ACercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACercaDeToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub TextoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem1.Click
        Dim color = New ColorDialog()
        color.AllowFullOpen = True
        If (color.ShowDialog() = Me.DialogResult.OK) Then

            RichTextBox1.ForeColor = color.Color
        End If
    End Sub

    Private Sub FondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondoToolStripMenuItem.Click
        Dim color = New ColorDialog()
        color.AllowFullOpen = True
        If (color.ShowDialog() = Me.DialogResult.OK) Then

            RichTextBox1.BackColor = color.Color
        End If
    End Sub
End Class
