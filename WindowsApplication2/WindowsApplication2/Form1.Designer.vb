<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.B_insertar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.B_modificar = New System.Windows.Forms.Button()
        Me.B_borrar = New System.Windows.Forms.Button()
        Me.B_listar = New System.Windows.Forms.Button()
        Me.B_buscar = New System.Windows.Forms.Button()
        Me.TextBox_buscar = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PruebaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet1 = New WindowsApplication2.masterDataSet1()
        Me.PruebaTableAdapter1 = New WindowsApplication2.masterDataSet1TableAdapters.pruebaTableAdapter()
        Me.B_drch = New System.Windows.Forms.Button()
        Me.B_izq = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.Location = New System.Drawing.Point(318, 16)
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_nombre.TabIndex = 0
        '
        'B_insertar
        '
        Me.B_insertar.Location = New System.Drawing.Point(18, 69)
        Me.B_insertar.Name = "B_insertar"
        Me.B_insertar.Size = New System.Drawing.Size(75, 23)
        Me.B_insertar.TabIndex = 1
        Me.B_insertar.Text = "insertar"
        Me.B_insertar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "id"
        '
        'TextBox_id
        '
        Me.TextBox_id.Location = New System.Drawing.Point(86, 15)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_id.TabIndex = 4
        '
        'B_modificar
        '
        Me.B_modificar.Location = New System.Drawing.Point(194, 69)
        Me.B_modificar.Name = "B_modificar"
        Me.B_modificar.Size = New System.Drawing.Size(75, 23)
        Me.B_modificar.TabIndex = 5
        Me.B_modificar.Text = "modificar"
        Me.B_modificar.UseVisualStyleBackColor = True
        '
        'B_borrar
        '
        Me.B_borrar.Location = New System.Drawing.Point(365, 69)
        Me.B_borrar.Name = "B_borrar"
        Me.B_borrar.Size = New System.Drawing.Size(75, 23)
        Me.B_borrar.TabIndex = 6
        Me.B_borrar.Text = "borrar"
        Me.B_borrar.UseVisualStyleBackColor = True
        '
        'B_listar
        '
        Me.B_listar.Location = New System.Drawing.Point(194, 108)
        Me.B_listar.Name = "B_listar"
        Me.B_listar.Size = New System.Drawing.Size(75, 23)
        Me.B_listar.TabIndex = 7
        Me.B_listar.Text = "Listar"
        Me.B_listar.UseVisualStyleBackColor = True
        '
        'B_buscar
        '
        Me.B_buscar.Location = New System.Drawing.Point(18, 228)
        Me.B_buscar.Name = "B_buscar"
        Me.B_buscar.Size = New System.Drawing.Size(75, 23)
        Me.B_buscar.TabIndex = 12
        Me.B_buscar.Text = "Buscar"
        Me.B_buscar.UseVisualStyleBackColor = True
        '
        'TextBox_buscar
        '
        Me.TextBox_buscar.Location = New System.Drawing.Point(150, 228)
        Me.TextBox_buscar.Name = "TextBox_buscar"
        Me.TextBox_buscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_buscar.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"id", "nombre"})
        Me.ComboBox1.Location = New System.Drawing.Point(318, 228)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PruebaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(18, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(422, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'PruebaBindingSource1
        '
        Me.PruebaBindingSource1.DataMember = "prueba"
        Me.PruebaBindingSource1.DataSource = Me.MasterDataSet1
        '
        'MasterDataSet1
        '
        Me.MasterDataSet1.DataSetName = "masterDataSet1"
        Me.MasterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PruebaTableAdapter1
        '
        Me.PruebaTableAdapter1.ClearBeforeFill = True
        '
        'B_drch
        '
        Me.B_drch.Location = New System.Drawing.Point(274, 164)
        Me.B_drch.Name = "B_drch"
        Me.B_drch.Size = New System.Drawing.Size(75, 23)
        Me.B_drch.TabIndex = 16
        Me.B_drch.Text = ">"
        Me.B_drch.UseVisualStyleBackColor = True
        '
        'B_izq
        '
        Me.B_izq.Location = New System.Drawing.Point(110, 163)
        Me.B_izq.Name = "B_izq"
        Me.B_izq.Size = New System.Drawing.Size(75, 23)
        Me.B_izq.TabIndex = 17
        Me.B_izq.Text = "<"
        Me.B_izq.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 457)
        Me.Controls.Add(Me.B_izq)
        Me.Controls.Add(Me.B_drch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox_buscar)
        Me.Controls.Add(Me.B_buscar)
        Me.Controls.Add(Me.B_listar)
        Me.Controls.Add(Me.B_borrar)
        Me.Controls.Add(Me.B_modificar)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_insertar)
        Me.Controls.Add(Me.TextBox_nombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents B_insertar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents B_modificar As Button
    Friend WithEvents B_borrar As Button
    Friend WithEvents B_listar As Button
    Friend WithEvents B_buscar As Button
    Friend WithEvents TextBox_buscar As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MasterDataSet1 As masterDataSet1
    Friend WithEvents PruebaBindingSource1 As BindingSource
    Friend WithEvents PruebaTableAdapter1 As masterDataSet1TableAdapters.pruebaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents B_drch As Button
    Friend WithEvents B_izq As Button
End Class
