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

    Private Sub AÑADIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AÑADIRToolStripMenuItem1.Click
        Dim ap As ProductoAnadir = New ProductoAnadir
        ap.Show()
    End Sub

    Private Sub MODIFICARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem1.Click
        Dim mp As ProductoModif = New ProductoModif
        mp.Show()
    End Sub

    Private Sub ELIMINARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem1.Click
        Dim pe As ProductoEliminar = New ProductoEliminar
        pe.Show()
    End Sub
End Class
