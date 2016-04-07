Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.conexion)

        Dim sql As String = "select cod_prod, nombre, existencia from productos"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "productos")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub InventarioDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class
