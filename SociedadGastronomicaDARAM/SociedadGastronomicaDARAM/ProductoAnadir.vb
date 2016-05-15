Public Class ProductoAnadir

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Close()
    End Sub

    Private Sub ButtonAnadir_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click
        Dim BD As BaseDatos = New BaseDatos
        BD.insertarProducto(Me)
    End Sub
End Class