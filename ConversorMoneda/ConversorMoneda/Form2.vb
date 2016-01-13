Public Class Form2

    Private oc As Controlador
    Public Sub asignarResultado(ByVal valor As Double)
        resultado.Text = Convert.ToString(valor)
    End Sub
    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        oc.terminar()
    End Sub
    Private Sub Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Volver.Click
        oc.comenzar()
    End Sub
    Public Sub New(ByRef oc As Controlador)

        InitializeComponent()

        Me.oc = oc
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class