Public Class PedidoResumen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As BaseDatos = New BaseDatos
        'bd.insertarPedido(Me)
        'bd.restarCantidad(id, stock)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class