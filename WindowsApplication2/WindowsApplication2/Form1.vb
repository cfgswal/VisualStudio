Public Class Form1
    Dim bd As New basedatos
    Dim row As Int16 = 0
    Dim rows As Int16 = 0
    Dim seleccion As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rellena el datagridview para mostrarlo en pantalla
        Me.PruebaTableAdapter1.Fill(Me.MasterDataSet1.prueba)
        'Crea un nuevo dataset para  llamar al metodo y cargar los valores de la tabla
        Dim ds As New DataSet
        ds = bd.RecuperarDatos()

    End Sub

    Private Sub B_insertar_Click(sender As Object, e As EventArgs) Handles B_insertar.Click

        'Llama al metodo insertar de la clase basedatos y le pasa el id y el nombre
        bd.insertar(TextBox_nombre.Text, TextBox_id.Text)
        'Actualiza el datagridview
        Me.PruebaTableAdapter1.Fill(Me.MasterDataSet1.prueba)
    End Sub

    Private Sub B_modificar_Click(sender As Object, e As EventArgs) Handles B_modificar.Click

        'Llama al metodo modificar de la clase basedatos y le pasa el id y el nombre
        bd.modificar(TextBox_nombre.Text, TextBox_id.Text)
        'Actualiza el datagridview
        Me.PruebaTableAdapter1.Fill(Me.MasterDataSet1.prueba)

    End Sub

    Private Sub B_borrar_Click(sender As Object, e As EventArgs) Handles B_borrar.Click

        'Llama al metodo borrar de la clase basedatos y le pasa el id
        bd.eliminar(TextBox_id.Text)
        'Actualiza el datagridview
        Me.PruebaTableAdapter1.Fill(Me.MasterDataSet1.prueba)
    End Sub

    Private Sub B_buscar_Click(sender As Object, e As EventArgs) Handles B_buscar.Click
        'recoge el valor en registro a buscar
        Dim registro As String = TextBox_buscar.Text
        buscarRegistro(seleccion, registro)
    End Sub

    Private Sub B_listar_Click(sender As Object, e As EventArgs) Handles B_listar.Click
        'Coloco la row a 0 para que muestre el primer valor siempre
        row = 0
        'Llama al metodo para que muestre en pantalla los valores del id y del nombre
        mostrar_registros()
    End Sub

    Private Sub B_drcha_Click(sender As Object, e As EventArgs) Handles B_drch.Click
        'Sumamos 1 y mostramos los valores al llamar a mostrar_registros
        row = row + 1
        mostrar_registros()
    End Sub

    Private Sub B_izq_Click(sender As Object, e As EventArgs) Handles B_izq.Click
        'Restamos 1 y mostramos los valores al llamar a mostrar_registros
        row = row - 1
        mostrar_registros()
    End Sub

    Private Sub mostrar_registros()
        Dim ds As New DataSet
        Dim bd As New basedatos
        'Llama al metodo de la clase de datos para recoger los valores de la tabla y los guarda en el dataset
        ds = bd.RecuperarDatos()
        'Recoge los rows que hay en la tabla
        rows = ds.Tables("prueba").Rows.Count

        If row > rows - 1 Then
            row = rows - 1
        End If

        If row < 0 Then
            row = 0
        End If
        'Recoge los valores id y nombre del dataset para mostrarlo en pantalla
        TextBox_id.Text = ds.Tables("prueba").Rows(row).Item("id").ToString
        TextBox_nombre.Text = ds.Tables("prueba").Rows(row).Item("nombre").ToString

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Recoge el valor del combobox, id o nombre
        seleccion = ComboBox1.SelectedItem.ToString
    End Sub

    Private Sub buscarRegistro(seleccion As String, registro As String)

        Do
            If seleccion IsNot Nothing Then
                'Crea un nuevo dataset para  llamar al metodo y cargar los valores de la tabla
                Dim ds As New DataSet
                ds = bd.RecuperarDatos()
                'Guardamos en filas el valor la select de busqueda, en seleccion pasamos el nombre o id del combobox y en registro el valor 
                Dim filas() As DataRow = ds.Tables("prueba").Select(seleccion & "='" + registro + "'")

                If filas.Length > 0 Then
                    TextBox_id.Text = filas(0).Item("id")
                    TextBox_nombre.Text = filas(0).Item("nombre")
                    'Lo borramos para que no queden datos para otra vez
                    filas(0).Delete()
                Else
                    MsgBox("Dato no encontrado")
                End If
            Else
                MsgBox("Introduce un valor para buscar")
            End If
            seleccion = ""
        Loop While seleccion Is Nothing
    End Sub

End Class
