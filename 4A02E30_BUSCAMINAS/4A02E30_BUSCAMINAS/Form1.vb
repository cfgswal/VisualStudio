Public Class Form1
    Dim cont = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button37.Enabled = False
    End Sub
    Sub contador()

        If cont = 29 Then
            Label1.Text = "TXAPELDUN!!!"
            MessageBox.Show("HAS GANADO EL JUEGO")
            Dim boton As Control
            For Each boton In Me.Controls
                If TypeOf boton Is Button Then
                    boton.Enabled = False
                End If
            Next
            Button37.Enabled = True
        Else
            cont = cont + 1

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

        Environment.Exit(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "1"
        contador()
        RemoveHandler Button1.Click, AddressOf Button1_Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "1"
        contador()
        RemoveHandler Button2.Click, AddressOf Button2_Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = "1"
        contador()
        RemoveHandler Button3.Click, AddressOf Button3_Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Text = "1"
        contador()
        RemoveHandler Button4.Click, AddressOf Button4_Click
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Text = "1"
        contador()
        RemoveHandler Button5.Click, AddressOf Button5_Click
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = "1"
        contador()
        RemoveHandler Button6.Click, AddressOf Button6_Click
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Text = "1"
        contador()
        RemoveHandler Button7.Click, AddressOf Button7_Click
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.BackColor = Color.Red
        Button8.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Text = "2"
        contador()
        RemoveHandler Button9.Click, AddressOf Button9_Click
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button10.Text = "2"
        contador()
        RemoveHandler Button10.Click, AddressOf Button10_Click
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.BackColor = Color.Red
        Button11.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button12.Text = "1"
        contador()
        RemoveHandler Button12.Click, AddressOf Button12_Click
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Button13.Text = "2"
        contador()
        RemoveHandler Button13.Click, AddressOf Button13_Click
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Text = "2"
        contador()
        RemoveHandler Button14.Click, AddressOf Button14_Click
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.Text = "3"
        contador()
        RemoveHandler Button15.Click, AddressOf Button15_Click
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Button16.BackColor = Color.Red
        Button16.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.Text = "2"
        contador()
        RemoveHandler Button17.Click, AddressOf Button17_Click
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button18.Text = "2"
        contador()
        RemoveHandler Button18.Click, AddressOf Button18_Click
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Button36.Text = "1"
        contador()
        RemoveHandler Button36.Click, AddressOf Button36_Click
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Button35.BackColor = Color.Red
        Button35.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Button34.Text = "3"
        contador()
        RemoveHandler Button34.Click, AddressOf Button34_Click
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Button33.Text = "2"
        contador()
        RemoveHandler Button33.Click, AddressOf Button33_Click
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Button32.Text = "2"
        contador()
        RemoveHandler Button32.Click, AddressOf Button32_Click
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Button31.BackColor = Color.Red
        Button31.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Button30.Text = "1"
        contador()
        RemoveHandler Button30.Click, AddressOf Button30_Click
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Button29.Text = "2"
        contador()
        RemoveHandler Button29.Click, AddressOf Button29_Click
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Button28.Text = "3"
        contador()
        RemoveHandler Button28.Click, AddressOf Button28_Click
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Button27.BackColor = Color.Red
        Button27.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Button26.Text = "1"
        contador()
        RemoveHandler Button26.Click, AddressOf Button26_Click
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Button25.Text = "1"
        contador()
        RemoveHandler Button25.Click, AddressOf Button25_Click
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.Text = "0"
        contador()
        RemoveHandler Button24.Click, AddressOf Button24_Click
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button23.Text = "1"
        contador()
        RemoveHandler Button23.Click, AddressOf Button23_Click
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button22.BackColor = Color.Red
        Button22.Text = "@"
        Label2.Text = "GAME OVER"
        Dim boton As Control
        For Each boton In Me.Controls
            If TypeOf boton Is Button Then
                boton.Enabled = False
            End If
        Next
        Button37.Enabled = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button21.Text = "2"
        contador()
        RemoveHandler Button21.Click, AddressOf Button21_Click
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button20.Text = "1"
        contador()
        RemoveHandler Button20.Click, AddressOf Button20_Click
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button19.Text = "0"
        contador()
        RemoveHandler Button19.Click, AddressOf Button19_Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
