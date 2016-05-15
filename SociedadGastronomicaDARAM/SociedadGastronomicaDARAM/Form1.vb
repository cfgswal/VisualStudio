Public Class Form1

    Private Sub AÑADIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRToolStripMenuItem.Click
        Dim sa As SocioAnadir = New SocioAnadir
        sa.Show()
    End Sub

    Private Sub MODIFICARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem.Click
        Dim sm As SocioModif = New SocioModif
        sm.Show()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim se As SocioEliminar = New SocioEliminar
        se.Show()
    End Sub
End Class
