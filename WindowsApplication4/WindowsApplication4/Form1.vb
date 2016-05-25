Public Class Form1
    Dim ds As New DataSet
    Dim row As Int16 = 0
    Dim rows As Int16 = 0
    Dim seleccion As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validar()
        Dim DB As New basedatos
        Dim id As Int16 = Convert.ToUInt16(TextBoxID.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        validar()
        Dim DB As New basedatos

        DB.modificar(Me)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim DB As New basedatos
        Try
            DB.eliminar(Me)
        Catch ex As Exception
            MsgBox("NO HAY VALOR")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        row = 0
        mostrarvalores()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        row = row - 1
        mostrarvalores()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        row = row + 1
        mostrarvalores()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        row = rows - 1

        mostrarvalores()
    End Sub

    Private Sub mostrarvalores()
        Dim bd As New basedatos

        If row > rows - 1 Then
            row = rows - 1
        End If

        If row < 0 Then

            row = 0
        End If
        ds = bd.cargarbd()
        rows = ds.Tables("EXAMENPRUEBA").Rows.Count
        TextBoxID.Text = ds.Tables("EXAMENPRUEBA").Rows(row).Item("id")
        TextBoxNOMBRE.Text = ds.Tables("EXAMENPRUEBA").Rows(row).Item("nombre")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bd As New basedatos
        Dim ds As New DataSet
        ds = bd.cargarbd()
        row = 0
        mostrarvalores()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        seleccion = ComboBox1.SelectedItem.ToString
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim registro As Int16 = -1
        buscardatos(seleccion, TextBox1.Text)

    End Sub

    Private Sub buscardatos(seleccion As String, registro As String)
        Try


            Do
                If seleccion IsNot Nothing Then
                    Dim bd As New basedatos
                    ds = New DataSet
                    ds = bd.cargarbd

                    Dim filas() As DataRow = ds.Tables("EXAMENPRUEBA").Select(seleccion & "='" + registro + "'")

                    If filas.Length > 0 Then
                        TextBoxID.Text = filas(0).Item("ID")
                        TextBoxNOMBRE.Text = filas(0).Item("NOMBRE")
                        filas(0).Delete()
                    Else
                        MsgBox("DATO NO ENCONTRADO")
                    End If
                Else
                    MsgBox("INTRODUCE UN VALOR PARA BUSCAR")
                End If
                seleccion = ""
            Loop While seleccion Is Nothing

        Catch ex As Exception
            MsgBox("INTRODUCE UN VALOR VALIDO")
        End Try
    End Sub

    Private Sub validar()
        Do
            If TextBoxID.TextLength = 0 Or TextBoxNOMBRE.TextLength = 0 Or TextBox1.TextLength = 0 Then
                MsgBox("INTRODUCE UN VALOR POR FAVOR")
            End If
        Loop While TextBoxID.TextLength > 0 Or TextBoxNOMBRE.TextLength > 0 Or TextBox1.TextLength > 0
    End Sub
End Class
