Public Class PedidoAnadir

    Dim seleccion As String
    Private Sub PedidoAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet2.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter1.Fill(Me.MasterDataSet2.producto)
        'TODO: This line of code loads data into the 'MasterDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.MasterDataSet.producto)

    End Sub

    Private Sub ButtonAnadir_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click
        ListBox1.Items.Add(seleccion)
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        seleccion = ComboBox1.Text
        Dim precio As Int16 = ComboBox1.SelectedValue
    End Sub
End Class