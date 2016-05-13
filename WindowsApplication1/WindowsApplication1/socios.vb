Public Class socios

    Dim ds As DataSet = New DataSet


    Dim nregistros As Integer
    Dim foto As String
    Dim seleccion As String


    Private Sub socios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet.socios' table. You can move, or remove it, as needed.

        Button6.Visible = False
        Button7.Visible = False
    End Sub


    Public Sub MostrarSocios(ByRef ds As DataSet)
        Try
            nregistros = ds.Tables("socios").Rows.Count

            ListaSocios()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Show

    End Sub

    Public Sub ListaSocios()

        ds = oc.CargarSocios(ds)

        For item As Integer = 0 To nregistros - 1

            ListBox1.Items.Add(ds.Tables("socios").Rows(item).Item("id_dni").ToString & " - " & ds.Tables("socios").Rows(item).Item("nombre_completo").ToString)
        Next

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Archivo JPG|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
        End If
        foto = openFileDialog1.FileName
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        TextBox1.Text = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("id_dni").ToString
        TextBox2.Text = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("nombre_completo").ToString
        TextBox3.Text = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("email").ToString
        TextBox4.Text = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("Iban").ToString
        foto = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("foto").ToString

        PictureBox1.Image = Image.FromFile(foto)

        TextBox6.Text = ds.Tables("socios").Rows(ListBox1.SelectedIndex).Item("Observaciones").ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Visible = True
        Button7.Visible = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        PictureBox1.Image = Nothing
        TextBox6.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.Visible = False
        Button7.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If nregistros <> -1 Then
                Dim dsNewRow As DataRow

                dsNewRow = ds.Tables("socios").NewRow()

                dsNewRow.Item("id_dni") = TextBox1.Text
                dsNewRow.Item("nombre_completo") = TextBox2.Text
                dsNewRow.Item("email") = TextBox3.Text
                dsNewRow.Item("Iban") = TextBox4.Text
                dsNewRow.Item("foto") = foto
                dsNewRow.Item("Observaciones") = TextBox6.Text

                ds.Tables("socios").Rows.Add(dsNewRow)
                nregistros = nregistros + 1


                ' oc.ejecutarInsert(ds)

            End If
        Catch ex As Exception
            MsgBox("La clave es única. Ya existe uno ..." & ex.Message)

            ds.Tables("socios").Rows(nregistros).Delete() 'borrar la fila falsa añadida en DataSet
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nregistros = nregistros - 1

        'actualiza el dataSet
        ds.Tables("socios").Rows(nregistros).Item("id_socio") = nregistros + 1
        ds.Tables("socios").Rows(nregistros).Item("id_dni") = TextBox1.Text
        ds.Tables("socios").Rows(nregistros).Item("nombre_completo") = TextBox2.Text
        ds.Tables("socios").Rows(nregistros).Item("email") = TextBox3.Text
        ds.Tables("socios").Rows(nregistros).Item("Iban") = TextBox4.Text
        ds.Tables("socios").Rows(nregistros).Item("foto") = foto
        ds.Tables("socios").Rows(nregistros).Item("Observaciones") = TextBox6.Text
        ' oc.ejecutarUpdate(Me, ds)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MessageBox.Show("¿Estás seguro de que quieres eliminar este socio?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
         DialogResult.No) Then
            MsgBox("Operación cancelada")
            Exit Sub
        End If

        ' oc.ejecutarDelete(Me, ds)

        nregistros = nregistros - 1




    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        seleccion = ComboBox1.SelectedItem.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim registro As String = TextBox7.Text
        buscarRegistro(registro, nregistros)


    End Sub



    Public Sub buscarRegistro(r As String, ByRef nregistros As Integer)

        Dim filas() As DataRow = ds.Tables("socios").Select(seleccion & "='" + r + "'")
        If filas.Length > 0 Then
            ListBox1.Items.Add(filas(0).Item(seleccion))
        Else
            MsgBox("Socio no encontrado")
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Clear()
        MostrarSocios(ds)

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'socios
        '
        Me.ClientSize = New System.Drawing.Size(752, 621)
        Me.Name = "socios"
        Me.ResumeLayout(False)

    End Sub
End Class