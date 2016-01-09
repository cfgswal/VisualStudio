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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecciona un idioma"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(120, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(145, 29)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Castellano"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(120, 238)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 29)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Euskera"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(618, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(347, 265)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SALUDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(618, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(347, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 495)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ventana Saludar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
