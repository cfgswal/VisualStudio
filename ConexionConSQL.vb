Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarioDataSet.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.InventarioDataSet.productos)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.InventarioDataSet.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ProductosTableAdapter.Fill(Me.InventarioDataSet.productos)



    End Sub
    Private Sub FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        If InventarioDataSet.HasChanges() Then

            ProductosTableAdapter.Update(InventarioDataSet)
            MessageBox.Show("Datos actualizando")
        End If

    End Sub
End Class
