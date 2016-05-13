Public Class SocioAnadir

    Dim ds As DataSet = New DataSet
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Close()
    End Sub

    Private Sub ButtonAnadir_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click
        Dim BD As BaseDatos = New BaseDatos
        BD.insertarSocio(Me, ds)
    End Sub
End Class