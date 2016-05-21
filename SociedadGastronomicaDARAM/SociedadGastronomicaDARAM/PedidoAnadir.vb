Public Class PedidoAnadir


    Dim stock As Int16 = 0
    Dim total As Double = 0
    Dim id As Int16 = 0
    Dim cantidad = 0
    Dim precio As Double = 0
    Dim pr As PedidoResumen = New PedidoResumen

    Private Sub PedidoAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SociedadGastronomicaDARAMDataSet.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.SociedadGastronomicaDARAMDataSet.productos)




    End Sub


    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        precio = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        cantidad = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value

        total = total + (precio * cantidad)
        TextBox2.Text = Format(total, "0.00")

        Dim nombre, descripcion As String

        nombre = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

        descripcion = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value

        pr.DataGridViewResumen.Rows.Add(nombre, descripcion, precio, cantidad)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        pr.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class