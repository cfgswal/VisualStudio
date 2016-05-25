Public Class PedidoAnadir

    Dim dni As String
    Dim fecha As Date
    Dim stock As Int16 = 0
    Dim total As Double = 0
    Dim id As Int16 = 0
    Dim cantidad = 0
    Dim precio As Double = 0


    Private Sub PedidoAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SociedadGastronomicaDARAMDataSet2.socios' table. You can move, or remove it, as needed.
        Me.SociosTableAdapter.Fill(Me.SociedadGastronomicaDARAMDataSet2.socios)
        'TODO: This line of code loads data into the 'SociedadGastronomicaDARAMDataSet1.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter1.Fill(Me.SociedadGastronomicaDARAMDataSet1.productos)
        'TODO: This line of code loads data into the 'SociedadGastronomicaDARAMDataSet.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.SociedadGastronomicaDARAMDataSet.productos)
        Dim bd As New BaseDatos
        Dim ds As New DataSet
        ds = bd.RecuperarPedidos()
        TextBox3.Text = ds.Tables("pedidos").Rows(0).Item("num_pedido") + 1
    End Sub


    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        Dim stockmin As Int16

        Try
            precio = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            stockmin = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
            cantidad = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
            fecha = DateTimePicker1.Value

            If stockmin < cantidad Then
                MsgBox("NO HAY SUFICIENTES")
                DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = 0
            Else
                total = total + (precio * cantidad)
            End If



            TextBox2.Text = Format(total, "0.00")






            dni = ComboBox1.SelectedValue.ToString

        Catch ex As Exception
            MsgBox("DATO ERRONEO")
            DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = 0
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As New BaseDatos
        bd.insertarpedido(dni, fecha, total)
    End Sub


End Class