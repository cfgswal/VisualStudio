Imports System.Data.SqlClient
Public Class SocioAnadir


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Close()
    End Sub

    Private Sub ButtonAnadir_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click

        Try
            Dim BD As BaseDatos = New BaseDatos
            BD.insertarSocio(Me)

        Catch ex As SqlException
            MsgBox("El DNI introducido ya existe")
        End Try

    End Sub
End Class