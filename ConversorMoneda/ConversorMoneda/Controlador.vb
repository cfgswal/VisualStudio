Public Class Controlador
    Private oF1 As Form1
    Private oF2 As Form2
    Public Sub convertir(ByVal pesetas As Integer)
        Dim oCalculadora = New Calculadora()
        Dim resultado As Double = oCalculadora.convertirEuros(pesetas)
        oF2.asignarResultado(resultado)
        oF1.Hide()
        oF2.Show()
    End Sub
    Public Sub comenzar()
        oF2.Hide()
        oF1.mostrarF1()
            End Sub
    Public Function getF1() As Form1
        Return oF1
    End Function
    Public Function getF2() As Form2
        Return oF2
    End Function
    Public Sub terminar()

        oF2.Dispose()
        oF1.Dispose()
        Application.Exit()
    End Sub
    Public Sub New()
        oF1 = New Form1(Me)
        oF2 = New Form2(Me)
    End Sub

End Class
