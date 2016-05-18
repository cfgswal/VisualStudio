Public Class PedidoAnadir

    Dim n As Int16 = 0
    Dim cantidad As Int16 = 0
    Dim id As Int16 = 0

    Private Sub PedidoAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet5.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.MasterDataSet5.producto)

    End Sub


    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        If n > 1 Then

            cantidad = Convert.ToInt16(InputBox("Introduce la cantidad:", "Cantidad"))
            id = Convert.ToInt16(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)


        Else
            n = n + 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As BaseDatos = New BaseDatos
        bd.restarCantidad(id, cantidad)
    End Sub
End Class