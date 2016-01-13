<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(685, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad en euros"
        '
        'Volver
        '
        Me.Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Location = New System.Drawing.Point(61, 493)
        Me.Volver.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(210, 86)
        Me.Volver.TabIndex = 1
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(840, 493)
        Me.Salir.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(166, 86)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(245, 276)
        Me.resultado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(648, 63)
        Me.resultado.TabIndex = 3
        Me.resultado.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 627)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "Resultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Volver As Button
    Friend WithEvents Salir As Button
    Friend WithEvents resultado As Label
End Class
