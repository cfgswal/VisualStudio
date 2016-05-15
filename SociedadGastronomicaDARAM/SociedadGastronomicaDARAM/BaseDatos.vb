Imports System.Data.SqlClient

Public Class BaseDatos

    Dim SA As SocioAnadir
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter()
    Dim ds As DataSet = New DataSet

    Public Sub New()
        con = New SqlConnection(My.Settings.Conexion)
    End Sub

    Public Function RecuperarSocios()
        Dim sql As String = "SELECT * FROM socios"
        Dim cmd As New SqlCommand(sql, con)

        Try
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "socios")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ds

    End Function

    Public Function insertarSocio(ByRef socios As SocioAnadir) As Boolean
        Try
            Dim cmd As SqlCommand = New SqlCommand("SP_REGISTRAR_SOCIO", con)
            cmd.Parameters.Add("id_dni", SqlDbType.VarChar, 10).Value = socios.TextBox1.Text
            cmd.Parameters.Add("nombre_completo", SqlDbType.VarChar, 20).Value = socios.TextBox2.Text
            cmd.Parameters.Add("email", SqlDbType.VarChar, 20).Value = socios.TextBox3.Text
            cmd.Parameters.Add("Iban", SqlDbType.VarChar, 20).Value = socios.TextBox4.Text
            cmd.Parameters.Add("foto", SqlDbType.VarChar, 99).Value = "dfgdf"
            cmd.Parameters.Add("Observaciones", SqlDbType.VarChar, 99).Value = socios.TextBox5.Text
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Nuevo registro añadido a la base de datos")
            socios.TextBox1.Clear()
            socios.TextBox2.Clear()
            socios.TextBox3.Clear()
            socios.TextBox4.Clear()
            socios.TextBox5.Clear()
        Catch ex As SqlException
            MsgBox("El DNI introducido ya existe")
        End Try

        Return True

    End Function


    Public Function modificarSocio(ByRef socios As SocioModif, ByRef ds As DataSet, ByRef n As Int16) As Boolean
        Dim cmd As New SqlCommand("SP_MODIFICAR_SOCIO", con)
        cmd.Parameters.Add("id_socio", SqlDbType.Int).Value = n
        cmd.Parameters.Add("id_dni", SqlDbType.VarChar, 10).Value = socios.TextBox1.Text
        cmd.Parameters.Add("nombre_completo", SqlDbType.VarChar, 20).Value = socios.TextBox2.Text
        cmd.Parameters.Add("email", SqlDbType.VarChar, 20).Value = socios.TextBox3.Text
        cmd.Parameters.Add("Iban", SqlDbType.VarChar, 20).Value = socios.TextBox4.Text
        cmd.Parameters.Add("foto", SqlDbType.VarChar, 99).Value = ds.Tables("socios").Rows(0).Item("foto")
        cmd.Parameters.Add("Observaciones", SqlDbType.VarChar, 99).Value = socios.TextBox5.Text

        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        cmd.ExecuteNonQuery()

        con.Close()
        MsgBox("Datos actualizados")
        con.Close()

        socios.Dispose()
        Return True

    End Function

    Public Function EliminarSocio(ByRef socios As SocioEliminar) As Boolean

        Dim cmd As New SqlCommand("SP_ELIMINAR_SOCIO", con)


        cmd.Parameters.Add("id_dni", SqlDbType.VarChar, 10).Value = socios.TextBox1.Text


        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        cmd.ExecuteNonQuery()

        con.Close()

        con.Close()
        MsgBox("Datos eliminados")
        socios.TextBox1.Clear()
        socios.TextBox2.Clear()
        socios.TextBox3.Clear()
        socios.TextBox4.Clear()
        socios.TextBox4.Clear()
        socios.Dispose()
        Return True

    End Function
End Class
