Public Class SocioEliminar
    Dim ds As DataSet = New DataSet
    Dim BD As BaseDatos = New BaseDatos
    Dim seleccion As String
    Dim n As Int16
    Private Sub SocioEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = BD.RecuperarSocios()
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        ds.Tables("socios").Rows(0).Item("id_dni") = TextBox1.Text
        ds.Tables("socios").Rows(0).Item("nombre_completo") = TextBox2.Text
        ds.Tables("socios").Rows(0).Item("email") = TextBox3.Text
        ds.Tables("socios").Rows(0).Item("Iban") = TextBox4.Text
        ' ds.Tables("socios").Rows.Item("foto") = foto
        ds.Tables("socios").Rows(0).Item("Observaciones") = TextBox5.Text
        BD.EliminarSocio(Me)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim registro As String = TextBox7.Text
        buscarRegistro(seleccion, registro)
    End Sub

    Public Sub buscarRegistro(seleccion As String, registro As String)

        Do
            If seleccion IsNot Nothing Then

                Dim filas() As DataRow = ds.Tables("socios").Select(seleccion & "='" + registro + "'")
                If filas.Length > 0 Then

                    n = filas(0).Item("id_socio")
                    TextBox1.Text = filas(0).Item("id_dni")
                    TextBox2.Text = filas(0).Item("nombre_completo")
                    TextBox3.Text = filas(0).Item("email")
                    TextBox4.Text = filas(0).Item("Iban")
                    TextBox5.Text = filas(0).Item("Observaciones")
                    filas(0).Delete()
                Else
                    MsgBox("Socio no encontrado")
                End If
            Else
                MsgBox("Introduce un valor para buscar")
            End If
            seleccion = ""
        Loop While seleccion Is Nothing


    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        seleccion = ComboBox1.SelectedItem.ToString
    End Sub
End Class