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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FuentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeorgiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StencilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAYUSCULASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinusculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(176, 197)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 38)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuentesToolStripMenuItem, Me.MAYUSCULASToolStripMenuItem, Me.MinusculasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 92)
        '
        'FuentesToolStripMenuItem
        '
        Me.FuentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArialToolStripMenuItem, Me.GeorgiaToolStripMenuItem, Me.StencilToolStripMenuItem})
        Me.FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        Me.FuentesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FuentesToolStripMenuItem.Text = "Fuentes"
        '
        'ArialToolStripMenuItem
        '
        Me.ArialToolStripMenuItem.Name = "ArialToolStripMenuItem"
        Me.ArialToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ArialToolStripMenuItem.Text = "Arial"
        '
        'GeorgiaToolStripMenuItem
        '
        Me.GeorgiaToolStripMenuItem.Name = "GeorgiaToolStripMenuItem"
        Me.GeorgiaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.GeorgiaToolStripMenuItem.Text = "Georgia"
        '
        'StencilToolStripMenuItem
        '
        Me.StencilToolStripMenuItem.Name = "StencilToolStripMenuItem"
        Me.StencilToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.StencilToolStripMenuItem.Text = "Stencil"
        '
        'MAYUSCULASToolStripMenuItem
        '
        Me.MAYUSCULASToolStripMenuItem.Name = "MAYUSCULASToolStripMenuItem"
        Me.MAYUSCULASToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MAYUSCULASToolStripMenuItem.Text = "MAYUSCULAS"
        '
        'MinusculasToolStripMenuItem
        '
        Me.MinusculasToolStripMenuItem.Name = "MinusculasToolStripMenuItem"
        Me.MinusculasToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MinusculasToolStripMenuItem.Text = "minusculas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 532)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FuentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeorgiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StencilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAYUSCULASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinusculasToolStripMenuItem As ToolStripMenuItem
End Class
