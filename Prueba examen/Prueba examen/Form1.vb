Public Class Form1
    Private Sub salirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles salirToolStripMenuItem.Click
        End
    End Sub

    Private Sub copiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles copiarToolStripMenuItem.Click

        If textBox6.SelectionLength <> 0 Then
            Clipboard.SetText(textBox6.SelectedText)
        End If
    End Sub

    Private Sub cortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cortarToolStripMenuItem.Click
        If textBox6.SelectionLength <> 0 Then
            Clipboard.SetText(textBox6.SelectedText)
            textBox6.Clear()

        End If
    End Sub

    Private Sub pegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pegarToolStripMenuItem.Click
        richTextBox1.Text = richTextBox1.Text & " " & Clipboard.GetText
        Clipboard.Clear()

    End Sub

    Private Sub courierNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles courierNewToolStripMenuItem.Click
        richTextBox1.Font = New Font("Courier new", richTextBox1.Font.Size)
    End Sub

    Private Sub arialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles arialToolStripMenuItem.Click
        richTextBox1.Font = New Font("Arial", richTextBox1.Font.Size)
    End Sub

    Private Sub symbolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles symbolToolStripMenuItem.Click
        richTextBox1.Font = New Font("Symbol", richTextBox1.Font.Size)
    End Sub

    Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem2.Click
        richTextBox1.Font = New Font(richTextBox1.Font.Name, "10")
    End Sub

    Private Sub toolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem3.Click
        richTextBox1.Font = New Font(richTextBox1.Font.Name, "14")
    End Sub

    Private Sub toolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem4.Click
        richTextBox1.Font = New Font(richTextBox1.Font.Name, "20")
    End Sub

    Private Sub negroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles negroToolStripMenuItem.Click
        richTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub azulToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles azulToolStripMenuItem1.Click
        richTextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub verdeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles verdeToolStripMenuItem1.Click
        richTextBox1.ForeColor = Color.DarkGreen
    End Sub

    Private Sub aMedidaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles aMedidaToolStripMenuItem1.Click
        Dim co = New ColorDialog()

        co.AllowFullOpen = True
        If co.ShowDialog() = Me.DialogResult.OK Then
            richTextBox1.ForeColor = co.Color
        End If

    End Sub

    Private Sub blancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles blancoToolStripMenuItem.Click
        richTextBox1.BackColor = Color.White
    End Sub

    Private Sub azulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles azulToolStripMenuItem.Click
        richTextBox1.BackColor = Color.Blue
    End Sub

    Private Sub verdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles verdeToolStripMenuItem.Click
        richTextBox1.BackColor = Color.Green
    End Sub

    Private Sub aMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aMedidaToolStripMenuItem.Click

        Dim co = New ColorDialog()
        co.AllowFullOpen = True
        If co.ShowDialog = Me.DialogResult.OK Then
            richTextBox1.BackColor = co.Color
        End If

    End Sub

    Private Sub acercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles acercaDeToolStripMenuItem.Click
        Form2.Show()
        Form2.TopMost = True

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim n As Integer
        If textBox1.TextLength = 0 Then
            MsgBox("Mete valor")
        Else
            Try
                n = Convert.ToInt16(textBox1.Text)
            Catch ex As Exception
                MsgBox("Mete un numero")
                textBox1.Text = ""
            End Try
        End If
        If n <> 0 Then
            textBox2.Text = textBox1.Text * 1.1143
        End If


    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim n As Integer
        If textBox2.TextLength = 0 Then
            MsgBox("Mete valor")
        Else
            Try
                n = Convert.ToInt16(textBox2.Text)
            Catch ex As Exception
                MsgBox("Mete un numero")
                textBox2.Text = ""
            End Try
        End If
        If n <> 0 Then
            textBox1.Text = textBox2.Text * 0.8974
            textBox1.ReadOnly = True
            RemoveHandler button1.Click, AddressOf button1_Click
        End If
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.MouseEnter

        textBox1.Focus()
        textBox1.ReadOnly = False
        textBox1.Text = ""
        AddHandler button1.Click, AddressOf button1_Click

    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.MouseEnter

        textBox2.Focus()
        textBox2.ReadOnly = False
        textBox2.Text = ""
        AddHandler button2.Click, AddressOf button2_Click
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        Dim n As Integer

        Do While textBox3.TextLength = 0
            textBox3.Text = InputBox("Introduce el nombre", "NOMBRE")
        Loop
        Do While textBox4.TextLength = 0
            textBox4.Text = InputBox("Introduce el Apellido", "APELLIDO")
        Loop

        Do While textBox5.TextLength = 0

            Try
                n = Convert.ToInt16(InputBox("Introduce la edad", "EDAD"))
            Catch ex As Exception
                MsgBox("INTRODUCE UN NUMERO")
            End Try
            If n <> 0 And n > 0 Then
                textBox5.Text = n
            End If
        Loop





    End Sub

    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged
        textBox14.Font = New Font("Tahoma", textBox14.Font.Size)
    End Sub

    Private Sub radioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton2.CheckedChanged
        textBox14.Font = New Font("Arial", textBox14.Font.Size)
    End Sub

    Private Sub radioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton3.CheckedChanged
        textBox14.Font = New Font("Georgia", textBox14.Font.Size)
    End Sub

    Private Sub radioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton4.CheckedChanged
        textBox14.BackColor = Color.Yellow
    End Sub

    Private Sub radioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton5.CheckedChanged
        textBox14.BackColor = Color.Green
    End Sub

    Private Sub radioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton6.CheckedChanged
        textBox14.BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBox14.ReadOnly = True
    End Sub

    Private Sub textBox14_TextChanged(sender As Object, e As EventArgs) Handles textBox14.MouseEnter
        textBox14.Font = New Font("Arial", textBox14.Font.Size)
        textBox14.BackColor = Color.White
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        comboBox1.Items.Add("UNO")
        comboBox1.Items.Add("DOS")
        comboBox1.Items.Add("TRES")
        comboBox1.Items.Add("CUATRO")
        comboBox1.Items.Add("CINCO")

    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        If textBox15.TextLength <> 0 Then
            If comboBox1.Items.Contains(textBox15.Text) Then
                MsgBox("Ya contiene este valor")
            Else
                comboBox1.Items.Add(textBox15.Text)
            End If
        Else MsgBox("Introduce un valor")
        End If
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        If textBox15.TextLength <> 0 Then
            If comboBox1.Items.Contains(textBox15.Text) Then
                comboBox1.Items.Remove(textBox15.Text)

            Else
                MsgBox("No contiene este valor")
            End If
        Else
            MsgBox("Mete un valor")
        End If
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        If textBox15.TextLength <> 0 Then
            If comboBox1.Items.Contains(textBox15.Text) Then
                comboBox1.Text = comboBox1.SelectedItem
            Else
                MsgBox("No contiene este valor")

            End If
        Else
            MsgBox("Mete un valor")
        End If
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged

    End Sub

    Private Sub textBox15_TextChanged(sender As Object, e As EventArgs) Handles textBox15.TextChanged

    End Sub
End Class
