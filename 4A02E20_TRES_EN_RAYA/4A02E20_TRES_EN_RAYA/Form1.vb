Public Class Form1
    Dim value As Integer = 0
    Dim contador As Integer = 0
    Dim contadorojo As Integer = 0
    Dim contadorazul As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "BIENVENIDO AL TRES EN RAYA"


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Environment.Exit(0)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Sub accion()
        If (Button2.BackColor = Color.Red And Button6.BackColor = Color.Red And Button9.BackColor = Color.Red Or
           Button2.BackColor = Color.Red And Button1.BackColor = Color.Red And Button3.BackColor = Color.Red Or
           Button1.BackColor = Color.Red And Button5.BackColor = Color.Red And Button8.BackColor = Color.Red Or
           Button3.BackColor = Color.Red And Button4.BackColor = Color.Red And Button7.BackColor = Color.Red Or
           Button4.BackColor = Color.Red And Button5.BackColor = Color.Red And Button6.BackColor = Color.Red Or
           Button7.BackColor = Color.Red And Button8.BackColor = Color.Red And Button9.BackColor = Color.Red Or
           Button2.BackColor = Color.Red And Button5.BackColor = Color.Red And Button7.BackColor = Color.Red Or
           Button3.BackColor = Color.Red And Button5.BackColor = Color.Red And Button9.BackColor = Color.Red) Then

            Label1.Text = "ROJO HAS GANADO"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Label3.Visible = False
            contadorojo = contadorojo + 1
            Label4.Text = contadorojo
            contador = 0

        ElseIf (Button2.BackColor = Color.Blue And Button6.BackColor = Color.Blue And Button9.BackColor = Color.Blue Or
            Button2.BackColor = Color.Blue And Button1.BackColor = Color.Blue And Button3.BackColor = Color.Blue Or
            Button1.BackColor = Color.Blue And Button5.BackColor = Color.Blue And Button8.BackColor = Color.Blue Or
            Button3.BackColor = Color.Blue And Button4.BackColor = Color.Blue And Button7.BackColor = Color.Blue Or
            Button4.BackColor = Color.Blue And Button5.BackColor = Color.Blue And Button6.BackColor = Color.Blue Or
            Button7.BackColor = Color.Blue And Button8.BackColor = Color.Blue And Button9.BackColor = Color.Blue Or
            Button2.BackColor = Color.Blue And Button5.BackColor = Color.Blue And Button7.BackColor = Color.Blue Or
            Button3.BackColor = Color.Blue And Button5.BackColor = Color.Blue And Button9.BackColor = Color.Blue) Then

            Label1.Text = "AZUL HAS GANADO"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            contadorazul = contadorazul + 1
            Label5.Text = contadorazul
            contador = 0
        Else
            contador = contador + 1
            If contador = 9 Then
                Label1.Text = "EMPATE"
                contador = 0
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button1.BackColor = Color.Red
                Button1.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button1.BackColor = Color.Blue
                Button1.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If

            accion()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If value = 1 Or value = 2 Then


            If (Label3.Visible = False) Then
                Button2.BackColor = Color.Red
                Button2.Enabled = False
                Label2.Visible = False
                Label3.Visible = True

            Else Button2.BackColor = Color.Blue
                Button2.Enabled = True
                Label2.Visible = True
                Label3.Visible = False
            End If

            accion()
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button3.BackColor = Color.Red
                Button3.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button3.BackColor = Color.Blue
                Button3.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If
            accion()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button4.BackColor = Color.Red
                Button4.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button4.BackColor = Color.Blue
                Button4.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If
            accion()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button5.BackColor = Color.Red
                Button5.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button5.BackColor = Color.Blue
                Button5.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If
            accion()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button6.BackColor = Color.Red
                Button6.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button6.BackColor = Color.Blue
                Button6.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If
            accion()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button8.BackColor = Color.Red
                Button8.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button8.BackColor = Color.Blue
                Button8.Enabled = False
                Label2.Visible = True
                Label3.Visible = False

            End If
            accion()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button7.BackColor = Color.Red
                Button7.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button7.BackColor = Color.Blue
                Button7.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If
            accion()
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If value = 1 Or value = 2 Then
            If (Label3.Visible = False) Then
                Button9.BackColor = Color.Red
                Button9.Enabled = False
                Label2.Visible = False
                Label3.Visible = True
            Else Button9.BackColor = Color.Blue
                Button9.Enabled = False
                Label2.Visible = True
                Label3.Visible = False
            End If

            accion()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If Label3.Visible = False Or Label2.Visible = False Then
            Randomize()

            Label3.Visible = True
            Label2.Visible = True

            value = CInt(Int((2 * Rnd()) + 1))

            If value = 1 Then
                Label3.Visible = False
            Else
                Label2.Visible = False
            End If
            Button1.BackColor = Color.Gainsboro
            Button1.Enabled = True
            Button2.BackColor = Color.Gainsboro
            Button2.Enabled = True
            Button3.BackColor = Color.Gainsboro
            Button3.Enabled = True
            Button4.BackColor = Color.Gainsboro
            Button4.Enabled = True
            Button5.BackColor = Color.Gainsboro
            Button5.Enabled = True
            Button6.BackColor = Color.Gainsboro
            Button6.Enabled = True
            Button7.BackColor = Color.Gainsboro
            Button7.Enabled = True
            Button8.BackColor = Color.Gainsboro
            Button8.Enabled = True
            Button9.BackColor = Color.Gainsboro
            Button9.Enabled = True
            Label1.Text = "TRES EN RAYA"
        End If
        Randomize()

        Label3.Visible = True
        Label2.Visible = True

        value = CInt(Int((2 * Rnd()) + 1))

        If value = 1 Then
            Label3.Visible = False
        Else
            Label2.Visible = False
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
