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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociedadGastronomicaDARAMDataSet = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New SociedadGastronomicaDARAM.masterDataSet5TableAdapters.productoTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ProductosTableAdapter = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSetTableAdapters.productosTableAdapter()
        Me.SociedadGastronomicaDARAMDataSet1 = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSet1()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter1 = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSet1TableAdapters.productosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_consumida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociedadGastronomicaDARAMDataSet2 = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSet2()
        Me.SociosTableAdapter = New SociedadGastronomicaDARAM.SociedadGastronomicaDARAMDataSet2TableAdapters.sociosTableAdapter()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadGastronomicaDARAMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadGastronomicaDARAMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociedadGastronomicaDARAMDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.SociedadGastronomicaDARAMDataSet
        '
        'SociedadGastronomicaDARAMDataSet
        '
        Me.SociedadGastronomicaDARAMDataSet.DataSetName = "SociedadGastronomicaDARAMDataSet"
        Me.SociedadGastronomicaDARAMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(668, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(610, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "PEDIDO Nº"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(717, 157)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(43, 20)
        Me.TextBox3.TabIndex = 158
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'SociedadGastronomicaDARAMDataSet1
        '
        Me.SociedadGastronomicaDARAMDataSet1.DataSetName = "SociedadGastronomicaDARAMDataSet1"
        Me.SociedadGastronomicaDARAMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "productos"
        Me.ProductosBindingSource1.DataSource = Me.SociedadGastronomicaDARAMDataSet1
        '
        'ProductosTableAdapter1
        '
        Me.ProductosTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.StockminDataGridViewTextBoxColumn, Me.cantidad_consumida})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(17, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 415)
        Me.DataGridView1.TabIndex = 159
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
        Me.StockDataGridViewTextBoxColumn.Visible = False
        '
        'StockminDataGridViewTextBoxColumn
        '
        Me.StockminDataGridViewTextBoxColumn.DataPropertyName = "stock_min"
        Me.StockminDataGridViewTextBoxColumn.HeaderText = "stock_min"
        Me.StockminDataGridViewTextBoxColumn.Name = "StockminDataGridViewTextBoxColumn"
        Me.StockminDataGridViewTextBoxColumn.Visible = False
        '
        'cantidad_consumida
        '
        Me.cantidad_consumida.HeaderText = "Cantidad Consumida"
        Me.cantidad_consumida.Name = "cantidad_consumida"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SociosBindingSource
        Me.ComboBox1.DisplayMember = "dni"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 160
        Me.ComboBox1.ValueMember = "dni"
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "socios"
        Me.SociosBindingSource.DataSource = Me.SociedadGastronomicaDARAMDataSet2
        '
        'SociedadGastronomicaDARAMDataSet2
        '
        Me.SociedadGastronomicaDARAMDataSet2.DataSetName = "SociedadGastronomicaDARAMDataSet2"
        Me.SociedadGastronomicaDARAMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'PedidoAnadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 685)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label9)
        Me.Name = "PedidoAnadir"
        Me.Text = "PedidoAnadir"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadGastronomicaDARAMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadGastronomicaDARAMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociedadGastronomicaDARAMDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As masterDataSet5TableAdapters.productoTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SociedadGastronomicaDARAMDataSet As SociedadGastronomicaDARAMDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As SociedadGastronomicaDARAMDataSetTableAdapters.productosTableAdapter
    Friend WithEvents SociedadGastronomicaDARAMDataSet1 As SociedadGastronomicaDARAMDataSet1
    Friend WithEvents ProductosBindingSource1 As BindingSource
    Friend WithEvents ProductosTableAdapter1 As SociedadGastronomicaDARAMDataSet1TableAdapters.productosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_consumida As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SociedadGastronomicaDARAMDataSet2 As SociedadGastronomicaDARAMDataSet2
    Friend WithEvents SociosBindingSource As BindingSource
    Friend WithEvents SociosTableAdapter As SociedadGastronomicaDARAMDataSet2TableAdapters.sociosTableAdapter
End Class
