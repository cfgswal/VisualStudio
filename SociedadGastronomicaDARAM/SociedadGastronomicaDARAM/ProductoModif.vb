Public Class ProductoModif
    Dim ds As DataSet = New DataSet
    Dim BD As BaseDatos = New BaseDatos
    Dim seleccion As String
    Dim n As Int16
    Private Sub ProductoModif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = BD.RecuperarProductos()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        ds.Tables("producto").Rows(0).Item("Codigo_producto") = TextBox1.Text
        ds.Tables("producto").Rows(0).Item("nombre") = TextBox6.Text
        ds.Tables("producto").Rows(0).Item("precio") = TextBox2.Text
        ds.Tables("producto").Rows(0).Item("stock") = TextBox3.Text
        ds.Tables("producto").Rows(0).Item("stock_min") = TextBox4.Text
        ds.Tables("producto").Rows(0).Item("descripcion") = TextBox5.Text
        BD.modificarProducto(Me, ds, n)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim registro As String = TextBox7.Text
        buscarRegistro(seleccion, registro)
    End Sub

    Public Sub buscarRegistro(seleccion As String, registro As String)

        Do
            If seleccion IsNot Nothing Then

                Dim filas() As DataRow = ds.Tables("producto").Select(seleccion & "='" + registro + "'")
                If filas.Length > 0 Then
                    TextBox1.Enabled = True
                    TextBox2.Enabled = True
                    TextBox3.Enabled = True
                    TextBox4.Enabled = True
                    TextBox5.Enabled = True
                    TextBox6.Enabled = True
                    n = filas(0).Item("id_producto")
                    TextBox1.Text = filas(0).Item("Codigo_producto")
                    TextBox6.Text = filas(0).Item("nombre")
                    TextBox2.Text = filas(0).Item("precio")
                    TextBox3.Text = filas(0).Item("stock")
                    TextBox4.Text = filas(0).Item("stock_min")
                    TextBox5.Text = filas(0).Item("descripcion")
                    filas(0).Delete()
                Else
                    MsgBox("Producto no encontrado")
                End If
            Else
                MsgBox("Introduce un valor para buscar")
            End If
            seleccion = ""
        Loop While seleccion Is Nothing


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        seleccion = ComboBox1.SelectedItem.ToString
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub
End Class