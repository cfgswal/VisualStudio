Public Class Form1
    Private oc As Controlador
    Private Sub convertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertir.Click

        oc.convertir(Integer.Parse(cantidad.Text))
    End Sub
    Public Sub mostrarF1()
        Me.Show()
        Me.cantidad.Clear()
        Me.cantidad.Focus()
    End Sub
    Public Sub New(ByRef oc As Controlador)

        InitializeComponent()

        Me.oc = oc
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cantidad_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged

    End Sub
End Class
