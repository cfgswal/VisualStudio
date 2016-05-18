<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoAnadir
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet5 = New SociedadGastronomicaDARAM.masterDataSet5()
        Me.ProductoTableAdapter = New SociedadGastronomicaDARAM.masterDataSet5TableAdapters.productoTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "DNI SOCIO"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(460, 641)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(179, 32)
        Me.ButtonCancelar.TabIndex = 143
        Me.ButtonCancelar.Text = "CANCELAR"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(268, 25)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "CREAR NUEVO PEDIDO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 139
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 32)
        Me.Button1.TabIndex = 149
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "LISTA DE PRODUCTOS"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(337, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 20)
        Me.DateTimePicker1.TabIndex = 151
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "FECHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(568, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "IMPORTE TOTAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.CodigoproductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.StockminDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 437)
        Me.DataGridView1.TabIndex = 155
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoproductoDataGridViewTextBoxColumn
        '
        Me.CodigoproductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_producto"
        Me.CodigoproductoDataGridViewTextBoxColumn.HeaderText = "Codigo_producto"
        Me.CodigoproductoDataGridViewTextBoxColumn.Name = "CodigoproductoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'StockminDataGridViewTextBoxColumn
        '
        Me.StockminDataGridViewTextBoxColumn.DataPropertyName = "stock_min"
        Me.StockminDataGridViewTextBoxColumn.HeaderText = "stock_min"
        Me.StockminDataGridViewTextBoxColumn.Name = "StockminDataGridViewTextBoxColumn"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.MasterDataSet5
        '
        'MasterDataSet5
        '
        Me.MasterDataSet5.DataSetName = "masterDataSet5"
        Me.MasterDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(668, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 156
        '
        'PedidoAnadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 685)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "PedidoAnadir"
        Me.Text = "PedidoAnadir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MasterDataSet5 As masterDataSet5
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As masterDataSet5TableAdapters.productoTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
