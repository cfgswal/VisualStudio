Imports System.Data.SqlClient

Public Class BaseDatos


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

    Public Function RecuperarProductos()
        Dim sql As String = "SELECT * FROM productos"
        Dim cmd As New SqlCommand(sql, con)

        Try
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "productos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ds

    End Function

    Public Function RecuperarPedidos()
        Dim sql As String = "SELECT * FROM pedidos"
        Dim cmd As New SqlCommand(sql, con)

        Try
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "pedidos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ds

    End Function


    Public Function insertarSocio(ByRef socios As SocioAnadir) As Boolean
        Try
            Dim cmd As SqlCommand = New SqlCommand("SP_REGISTRAR_SOCIO", con)
            cmd.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = socios.TextBox1.Text
            cmd.Parameters.Add("nombre_completo", SqlDbType.VarChar, 50).Value = socios.TextBox2.Text
            cmd.Parameters.Add("email", SqlDbType.VarChar, 30).Value = socios.TextBox3.Text
            cmd.Parameters.Add("iban", SqlDbType.VarChar, 34).Value = socios.TextBox4.Text
            cmd.Parameters.Add("foto", SqlDbType.Image).Value = socios.ms.GetBuffer()
            cmd.Parameters.Add("observaciones", SqlDbType.VarChar, 300).Value = socios.TextBox5.Text
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
            socios.PictureBox1.Image = Nothing

        Catch ex As SqlException
            MsgBox("El DNI introducido ya existe")
        End Try

        Return True

    End Function


    Public Function modificarSocio(ByRef socios As SocioModif) As Boolean
        Dim cmd As New SqlCommand("SP_MODIFICAR_SOCIO", con)
        cmd.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = socios.TextBox1.Text
        cmd.Parameters.Add("nombre_completo", SqlDbType.VarChar, 50).Value = socios.TextBox2.Text
        cmd.Parameters.Add("email", SqlDbType.VarChar, 30).Value = socios.TextBox3.Text
        cmd.Parameters.Add("iban", SqlDbType.VarChar, 34).Value = socios.TextBox4.Text
        cmd.Parameters.Add("foto", SqlDbType.Image).Value = socios.ms.GetBuffer()
        cmd.Parameters.Add("observaciones", SqlDbType.VarChar, 300).Value = socios.TextBox5.Text

        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        cmd.ExecuteNonQuery()
        MsgBox("Datos actualizados")
        con.Close()

        socios.Dispose()
        Return True

    End Function

    Public Function EliminarSocio(ByRef socios As SocioEliminar) As Boolean

        Dim cmd As New SqlCommand("SP_ELIMINAR_SOCIO", con)


        cmd.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = socios.TextBox1.Text


        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Datos eliminados")
        socios.TextBox1.Clear()
        socios.TextBox2.Clear()
        socios.TextBox3.Clear()
        socios.TextBox4.Clear()
        socios.TextBox5.Clear()
        socios.Dispose()
        Return True

    End Function

    Public Function insertarProducto(ByRef producto As ProductoAnadir) As Boolean

        Dim cmd As SqlCommand = New SqlCommand("SP_REGISTRAR_PRODUCTO", con)
        cmd.Parameters.Add("nombre", SqlDbType.VarChar, 30).Value = producto.TextBox6.Text
        cmd.Parameters.Add("precio", SqlDbType.Float).Value = producto.TextBox2.Text
        cmd.Parameters.Add("stock", SqlDbType.Int).Value = producto.TextBox3.Text
        cmd.Parameters.Add("stock_min", SqlDbType.Int).Value = producto.TextBox4.Text
        cmd.Parameters.Add("descripcion", SqlDbType.VarChar, 100).Value = producto.TextBox5.Text
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Nuevo producto añadido a la base de datos")

        producto.TextBox2.Clear()
        producto.TextBox3.Clear()
        producto.TextBox4.Clear()
        producto.TextBox5.Clear()
        producto.TextBox6.Clear()


        Return True

    End Function

    Public Function modificarProducto(ByRef producto As ProductoModif, ByRef ds As DataSet) As Boolean
        Dim cmd As New SqlCommand("SP_MODIFICAR_PRODUCTO", con)
        cmd.Parameters.Add("cod_producto", SqlDbType.Int).Value = producto.TextBox1.Text
        cmd.Parameters.Add("nombre", SqlDbType.VarChar, 30).Value = producto.TextBox6.Text
        cmd.Parameters.Add("precio", SqlDbType.Float).Value = producto.TextBox2.Text
        cmd.Parameters.Add("stock", SqlDbType.Int).Value = producto.TextBox3.Text
        cmd.Parameters.Add("stock_min", SqlDbType.Int).Value = producto.TextBox4.Text
        cmd.Parameters.Add("descripcion", SqlDbType.VarChar, 100).Value = producto.TextBox5.Text

        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        cmd.ExecuteNonQuery()

        con.Close()
        MsgBox("Producto actualizado")
        con.Close()

        producto.Dispose()
        Return True

    End Function

    Public Function EliminarProducto(ByRef producto As ProductoEliminar) As Boolean

        Dim cmd As New SqlCommand("SP_ELIMINAR_PRODUCTO", con)
        cmd.Parameters.Add("cod_producto", SqlDbType.Int).Value = Convert.ToInt32(producto.TextBox1.Text)
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Producto eliminado")
        producto.TextBox1.Clear()
        producto.TextBox2.Clear()
        producto.TextBox3.Clear()
        producto.TextBox4.Clear()
        producto.TextBox5.Clear()
        producto.TextBox6.Clear()
        producto.TextBox7.Clear()
        Return True

    End Function

    Public Function insertarpedido(ByRef dni As String, ByRef fecha As Date, ByRef total As String) As Boolean
        Dim cmd As New SqlCommand("SP_INSERTAR_PEDIDO", con)
        cmd.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = dni
        cmd.Parameters.Add("fecha_pedido", SqlDbType.Date).Value = fecha
        cmd.Parameters.Add("importe", SqlDbType.Float).Value = total
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("PEDIDO INSERTADO")
        Return True
    End Function


    Public Function restarCantidad(ByRef id As Int16, cantidad As Int16) As Boolean

        ds = RecuperarProductos()
        Dim cmd As SqlCommand = New SqlCommand("SP_ModificarStock", con)
        cmd.Parameters.Add("@stock", SqlDbType.Int).Value = cantidad
        cmd.Parameters.Add("@cod_producto", SqlDbType.Int).Value = id
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        Return True
    End Function
End Class
