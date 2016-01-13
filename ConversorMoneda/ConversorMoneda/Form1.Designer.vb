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
        Me.convertir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'convertir
        '
        Me.convertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertir.Location = New System.Drawing.Point(481, 444)
        Me.convertir.Name = "convertir"
        Me.convertir.Size = New System.Drawing.Size(588, 132)
        Me.convertir.TabIndex = 0
        Me.convertir.Text = "Convertir"
        Me.convertir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad en Pesetas"
        '
        'cantidad
        '
        Me.cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(481, 252)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(588, 53)
        Me.cantidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(945, 115)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Conversor de euros"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 627)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.convertir)
        Me.Name = "Form1"
        Me.Text = "Aplicacion convertir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents convertir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label2 As Label
End Class
