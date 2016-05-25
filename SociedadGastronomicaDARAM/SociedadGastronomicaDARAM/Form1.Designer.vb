<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SOCIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AÑADIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AÑADIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEDIDOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AÑADIRToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoTableAdapter1 = New SociedadGastronomicaDARAM.masterDataSet5TableAdapters.productoTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SOCIOSToolStripMenuItem, Me.PRODUCTOSToolStripMenuItem, Me.PEDIDOSToolStripMenuItem, Me.ACERCADEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SOCIOSToolStripMenuItem
        '
        Me.SOCIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRToolStripMenuItem, Me.MODIFICARToolStripMenuItem, Me.ELIMINARToolStripMenuItem})
        Me.SOCIOSToolStripMenuItem.Name = "SOCIOSToolStripMenuItem"
        Me.SOCIOSToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SOCIOSToolStripMenuItem.Text = "SOCIOS"
        '
        'AÑADIRToolStripMenuItem
        '
        Me.AÑADIRToolStripMenuItem.Name = "AÑADIRToolStripMenuItem"
        Me.AÑADIRToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AÑADIRToolStripMenuItem.Text = "AÑADIR"
        '
        'MODIFICARToolStripMenuItem
        '
        Me.MODIFICARToolStripMenuItem.Name = "MODIFICARToolStripMenuItem"
        Me.MODIFICARToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MODIFICARToolStripMenuItem.Text = "MODIFICAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRToolStripMenuItem1, Me.MODIFICARToolStripMenuItem1, Me.ELIMINARToolStripMenuItem1})
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        '
        'AÑADIRToolStripMenuItem1
        '
        Me.AÑADIRToolStripMenuItem1.Name = "AÑADIRToolStripMenuItem1"
        Me.AÑADIRToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.AÑADIRToolStripMenuItem1.Text = "AÑADIR"
        '
        'MODIFICARToolStripMenuItem1
        '
        Me.MODIFICARToolStripMenuItem1.Name = "MODIFICARToolStripMenuItem1"
        Me.MODIFICARToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.MODIFICARToolStripMenuItem1.Text = "MODIFICAR"
        '
        'ELIMINARToolStripMenuItem1
        '
        Me.ELIMINARToolStripMenuItem1.Name = "ELIMINARToolStripMenuItem1"
        Me.ELIMINARToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ELIMINARToolStripMenuItem1.Text = "ELIMINAR"
        '
        'PEDIDOSToolStripMenuItem
        '
        Me.PEDIDOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRToolStripMenuItem2, Me.LISTADOToolStripMenuItem})
        Me.PEDIDOSToolStripMenuItem.Name = "PEDIDOSToolStripMenuItem"
        Me.PEDIDOSToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PEDIDOSToolStripMenuItem.Text = "PEDIDOS"
        '
        'AÑADIRToolStripMenuItem2
        '
        Me.AÑADIRToolStripMenuItem2.Name = "AÑADIRToolStripMenuItem2"
        Me.AÑADIRToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AÑADIRToolStripMenuItem2.Text = "AÑADIR"
        '
        'LISTADOToolStripMenuItem
        '
        Me.LISTADOToolStripMenuItem.Name = "LISTADOToolStripMenuItem"
        Me.LISTADOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LISTADOToolStripMenuItem.Text = "LISTADO"
        '
        'ACERCADEToolStripMenuItem
        '
        Me.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        Me.ACERCADEToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ACERCADEToolStripMenuItem.Text = "ACERCA DE"
        '
        'ProductoTableAdapter1
        '
        Me.ProductoTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SOCIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AÑADIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AÑADIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PEDIDOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AÑADIRToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LISTADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoTableAdapter1 As masterDataSet5TableAdapters.productoTableAdapter
End Class
