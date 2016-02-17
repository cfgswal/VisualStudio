Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sms1 = InputBox("Introduce el Nombre:", "Nombre")
        Dim sms2 = InputBox("Introduce el Apellido:", "Apellido")

        Label5.Text = sms1
        Label6.Text = sms2

        Dim n As Int32 = 0
        Do
            Dim sms3 = InputBox("Introduce la Edad:", "Edad", "0")

            Try
                n = Convert.ToInt32(sms3)
                If n < 0 Then
                    MsgBox("Numero erroneo")
                End If
            Catch ex As Exception
                MsgBox("Introduce un numero")
            End Try

        Loop Until (n > 0)
        Label7.Text = n
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
