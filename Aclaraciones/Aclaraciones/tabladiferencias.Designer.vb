<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabladiferencias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tabladiferencias))
        Me.Gridfactura = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.activar = New System.Windows.Forms.Button()
        Me.editar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.SaveFileDialog()
        Me.respuesta = New System.Windows.Forms.CheckBox()
        Me.asignado = New System.Windows.Forms.CheckBox()
        Me.recibofactura = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Folio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Provedor = New System.Windows.Forms.TextBox()
        Me.recibo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hasta = New System.Windows.Forms.DateTimePicker()
        Me.desde = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Gridfactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gridfactura
        '
        Me.Gridfactura.AllowUserToAddRows = False
        Me.Gridfactura.AllowUserToResizeRows = False
        Me.Gridfactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gridfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gridfactura.GridColor = System.Drawing.SystemColors.Control
        Me.Gridfactura.Location = New System.Drawing.Point(12, 105)
        Me.Gridfactura.MultiSelect = False
        Me.Gridfactura.Name = "Gridfactura"
        Me.Gridfactura.ReadOnly = True
        Me.Gridfactura.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Gridfactura.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gridfactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gridfactura.Size = New System.Drawing.Size(971, 450)
        Me.Gridfactura.TabIndex = 48
        Me.Gridfactura.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Diferencias"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 51)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'activar
        '
        Me.activar.AccessibleDescription = ""
        Me.activar.BackgroundImage = CType(resources.GetObject("activar.BackgroundImage"), System.Drawing.Image)
        Me.activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.activar.Location = New System.Drawing.Point(67, 44)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(49, 51)
        Me.activar.TabIndex = 51
        Me.activar.TabStop = False
        Me.activar.Tag = ""
        Me.ToolTip1.SetToolTip(Me.activar, "Eliminar Registro Seleccionado")
        Me.activar.UseVisualStyleBackColor = True
        '
        'editar
        '
        Me.editar.BackgroundImage = CType(resources.GetObject("editar.BackgroundImage"), System.Drawing.Image)
        Me.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editar.Location = New System.Drawing.Point(122, 45)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(49, 51)
        Me.editar.TabIndex = 50
        Me.editar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.editar, "Editar Registro")
        Me.editar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.BackgroundImage = CType(resources.GetObject("nuevo.BackgroundImage"), System.Drawing.Image)
        Me.nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(12, 44)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(49, 51)
        Me.nuevo.TabIndex = 49
        Me.nuevo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.nuevo, "Nuevo Registro")
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Registros"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(177, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 51)
        Me.Button2.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.Button2, "Exportar a Excel")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SkyBlue
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(928, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 51)
        Me.Button3.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.Button3, "Consultar")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(232, 45)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 51)
        Me.Button4.TabIndex = 109
        Me.Button4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button4, "Cargar Masivo")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'respuesta
        '
        Me.respuesta.AutoSize = True
        Me.respuesta.BackColor = System.Drawing.Color.SkyBlue
        Me.respuesta.Location = New System.Drawing.Point(819, 74)
        Me.respuesta.Name = "respuesta"
        Me.respuesta.Size = New System.Drawing.Size(103, 17)
        Me.respuesta.TabIndex = 87
        Me.respuesta.Text = "F. RESPUESTA"
        Me.respuesta.UseVisualStyleBackColor = False
        '
        'asignado
        '
        Me.asignado.AutoSize = True
        Me.asignado.BackColor = System.Drawing.Color.SkyBlue
        Me.asignado.Location = New System.Drawing.Point(819, 54)
        Me.asignado.Name = "asignado"
        Me.asignado.Size = New System.Drawing.Size(94, 17)
        Me.asignado.TabIndex = 86
        Me.asignado.Text = "F. ASIGNADO"
        Me.asignado.UseVisualStyleBackColor = False
        '
        'recibofactura
        '
        Me.recibofactura.AutoSize = True
        Me.recibofactura.BackColor = System.Drawing.Color.SkyBlue
        Me.recibofactura.Location = New System.Drawing.Point(819, 34)
        Me.recibofactura.Name = "recibofactura"
        Me.recibofactura.Size = New System.Drawing.Size(90, 17)
        Me.recibofactura.TabIndex = 85
        Me.recibofactura.Text = "F. REC-FACT"
        Me.recibofactura.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SkyBlue
        Me.Label7.Location = New System.Drawing.Point(494, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "STATUS"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"TODOS", "PROCEDENTE", "IMPROCEDENTE", "PENDIENTE"})
        Me.status.Location = New System.Drawing.Point(547, 64)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(121, 21)
        Me.status.TabIndex = 83
        Me.status.Text = "TODOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.Location = New System.Drawing.Point(494, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "FOLIO"
        '
        'Folio
        '
        Me.Folio.Location = New System.Drawing.Point(547, 40)
        Me.Folio.Name = "Folio"
        Me.Folio.Size = New System.Drawing.Size(100, 20)
        Me.Folio.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Location = New System.Drawing.Point(494, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "PROV"
        '
        'Provedor
        '
        Me.Provedor.Location = New System.Drawing.Point(547, 14)
        Me.Provedor.Name = "Provedor"
        Me.Provedor.Size = New System.Drawing.Size(100, 20)
        Me.Provedor.TabIndex = 79
        '
        'recibo
        '
        Me.recibo.AutoSize = True
        Me.recibo.BackColor = System.Drawing.Color.SkyBlue
        Me.recibo.Location = New System.Drawing.Point(819, 15)
        Me.recibo.Name = "recibo"
        Me.recibo.Size = New System.Drawing.Size(72, 17)
        Me.recibo.TabIndex = 78
        Me.recibo.Text = "F. Recibo"
        Me.recibo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.Location = New System.Drawing.Point(675, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.Location = New System.Drawing.Point(674, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Desde"
        '
        'hasta
        '
        Me.hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hasta.Location = New System.Drawing.Point(718, 43)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(93, 20)
        Me.hasta.TabIndex = 74
        '
        'desde
        '
        Me.desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desde.Location = New System.Drawing.Point(718, 18)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(93, 20)
        Me.desde.TabIndex = 73
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Location = New System.Drawing.Point(480, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 87)
        Me.Panel1.TabIndex = 107
        '
        'tabladiferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.respuesta)
        Me.Controls.Add(Me.asignado)
        Me.Controls.Add(Me.recibofactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Folio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Provedor)
        Me.Controls.Add(Me.recibo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.Gridfactura)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tabladiferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Gridfactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gridfactura As System.Windows.Forms.DataGridView
    Friend WithEvents activar As System.Windows.Forms.Button
    Friend WithEvents editar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents respuesta As System.Windows.Forms.CheckBox
    Friend WithEvents asignado As System.Windows.Forms.CheckBox
    Friend WithEvents recibofactura As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Folio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Provedor As System.Windows.Forms.TextBox
    Friend WithEvents recibo As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
