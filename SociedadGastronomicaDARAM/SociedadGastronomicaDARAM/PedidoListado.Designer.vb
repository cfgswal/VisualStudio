<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoListado
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
        Me.DataGridViewResumen = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewResumen
        '
        Me.DataGridViewResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResumen.Location = New System.Drawing.Point(58, 41)
        Me.DataGridViewResumen.Name = "DataGridViewResumen"
        Me.DataGridViewResumen.Size = New System.Drawing.Size(636, 386)
        Me.DataGridViewResumen.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(636, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CONFIRMAR PEDIDO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PedidoListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewResumen)
        Me.Name = "PedidoListado"
        Me.Text = "PedidoListado"
        CType(Me.DataGridViewResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewResumen As DataGridView
    Friend WithEvents Button1 As Button
End Class
