<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoResumen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_gastada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewResumen
        '
        Me.DataGridViewResumen.AllowUserToAddRows = False
        Me.DataGridViewResumen.AllowUserToDeleteRows = False
        Me.DataGridViewResumen.AllowUserToOrderColumns = True
        Me.DataGridViewResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.descripcion, Me.precio, Me.cantidad_gastada})
        Me.DataGridViewResumen.Location = New System.Drawing.Point(32, 83)
        Me.DataGridViewResumen.Name = "DataGridViewResumen"
        Me.DataGridViewResumen.Size = New System.Drawing.Size(624, 352)
        Me.DataGridViewResumen.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RESUMEN DE PEDIDO"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CONFIRMAR PEDIDO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'cantidad_gastada
        '
        Me.cantidad_gastada.HeaderText = "Cantidad Gastada"
        Me.cantidad_gastada.Name = "cantidad_gastada"
        Me.cantidad_gastada.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "AÑADIR MAS PRODUCTOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PedidoResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 525)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewResumen)
        Me.Name = "PedidoResumen"
        Me.Text = "PedidoResumen"
        CType(Me.DataGridViewResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewResumen As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_gastada As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
