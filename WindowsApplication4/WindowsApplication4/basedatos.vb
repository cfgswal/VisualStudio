Imports System.Data.SqlClient

Public Class basedatos
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim fo1 As New Form1
    Public Function cargarbd()
        Dim con As New SqlConnection(My.Settings.conexion)

        Try
            Dim sql As String = "SELECT * FROM EXAMENPRUEBA"
            Dim cmd As New SqlCommand(sql, con)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "EXAMENPRUEBA")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ds
    End Function

    Public Function insertar(ByRef fo1 As Form1) As Boolean
        Try
            Dim con As New SqlConnection(My.Settings.conexion)
            Dim cmd As New SqlCommand("INSERTAR", con)
            cmd.Parameters.Add("NOMBRE", SqlDbType.NVarChar, 10).Value = fo1.TextBoxNOMBRE.Text
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            fo1.TextBoxID.Clear()
            fo1.TextBoxNOMBRE.Clear()
            MsgBox("INSERTADO")
        Catch ex As SqlException
            MsgBox("El id insertado ya existe")
        Catch ex As Exception
            MsgBox("NO HAY VALOR")
        End Try
        Return True
    End Function

    Public Function modificar(ByRef fo1 As Form1) As Boolean
        Try


            Dim con As New SqlConnection(My.Settings.conexion)
            Dim cmd As New SqlCommand("modificar", con)
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = fo1.TextBoxID.Text
            cmd.Parameters.Add("NOMBRE", SqlDbType.NVarChar, 10).Value = fo1.TextBoxNOMBRE.Text
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            fo1.TextBoxID.Clear()
            fo1.TextBoxNOMBRE.Clear()
            MsgBox("MODIFICADO")
        Catch ex As Exception
            MsgBox("NO HAY VALOR")
        End Try
        Return True
    End Function

    Public Function eliminar(ByRef fo As Form1) As Boolean

        Dim con As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("eliminar", con)
        cmd.Parameters.Add("ID", SqlDbType.Int).Value = fo1.TextBoxID.Text
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        fo1.TextBoxID.Clear()
        fo1.TextBoxNOMBRE.Clear()
        MsgBox("ELIMINADO")
        Return True
    End Function










































End Class
