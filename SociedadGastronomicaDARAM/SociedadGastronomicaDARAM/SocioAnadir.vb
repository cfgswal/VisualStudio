
Public Class SocioAnadir

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Close()
    End Sub

    Private Sub ButtonAnadir_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click
        Dim BD As BaseDatos = New BaseDatos
        BD.insertarSocio(Me)

    End Sub

End Class