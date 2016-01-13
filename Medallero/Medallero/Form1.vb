Public Class Form1
    Dim cont = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CAMPEON.Enabled = False
        SALIR.Enabled = False
        TextBox5.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.Enabled = False
    End Sub
    Sub contador()
        cont = cont + 1
        If cont = 4 Then
            CAMPEON.Enabled = True

        End If
    End Sub


    Private Sub CAMPEON_Click(sender As Object, e As EventArgs) Handles CAMPEON.Click
        TextBox5.Text = "USA"
        SALIR.Enabled = True
        TextBox5.Enabled = True

    End Sub

    Private Sub ALEMANIA_Click(sender As Object, e As EventArgs) Handles ALEMANIA.Click
        TextBox1.Text = 20
        contador()
        RemoveHandler ALEMANIA.Click, AddressOf ALEMANIA_Click
    End Sub

    Private Sub ESPAÑA_Click(sender As Object, e As EventArgs) Handles ESPAÑA.Click
        TextBox2.Text = 25
        contador()
        RemoveHandler ESPAÑA.Click, AddressOf ESPAÑA_Click
    End Sub

    Private Sub USA_Click(sender As Object, e As EventArgs) Handles USA.Click
        TextBox3.Text = 45
        contador()
        RemoveHandler USA.Click, AddressOf USA_Click
    End Sub

    Private Sub ITALIA_Click(sender As Object, e As EventArgs) Handles ITALIA.Click
        TextBox4.Text = 12
        contador()
        RemoveHandler ITALIA.Click, AddressOf ITALIA_Click
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Environment.Exit(0)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.MouseEnter

        CAMPEON.Enabled = False
        SALIR.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        AddHandler ALEMANIA.Click, AddressOf ALEMANIA_Click
        AddHandler ESPAÑA.Click, AddressOf ESPAÑA_Click
        AddHandler ITALIA.Click, AddressOf ITALIA_Click
        AddHandler USA.Click, AddressOf USA_Click
        cont = 0
    End Sub


End Class
