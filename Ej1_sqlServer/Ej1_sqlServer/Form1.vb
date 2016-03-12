Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarioDataSet.productos' table. You can move, or remove it, as needed.

        Dim con As New SqlConnection(My.Settings.Conexion)

        Dim sql As String = "select cod_prod, nombre, existencia from productos"




        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "productos")
            Me.DataGridView1.DataSource = ds.Tables("productos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
