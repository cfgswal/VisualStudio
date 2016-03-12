Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim con As New SqlConnection(My.Settings.conexion)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "INSERT productos(cod_prod,nombre,existencia) VALUES (25,'juan',25)"


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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "DELETE productos WHERE nombre='juan'"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection(My.Settings.conexion)

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
