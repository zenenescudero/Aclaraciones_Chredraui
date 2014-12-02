<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrodiferencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrodiferencias))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fecharecifac = New System.Windows.Forms.DateTimePicker()
        Me.fecharecibo = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.diferencia = New System.Windows.Forms.TextBox()
        Me.sucursal = New System.Windows.Forms.TextBox()
        Me.factura = New System.Windows.Forms.TextBox()
        Me.claveprov = New System.Windows.Forms.TextBox()
        Me.proveedor = New System.Windows.Forms.TextBox()
        Me.origen = New System.Windows.Forms.TextBox()
        Me.cia = New System.Windows.Forms.TextBox()
        Me.ortex = New System.Windows.Forms.TextBox()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.diasresp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.autorizo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Comboclave = New System.Windows.Forms.ComboBox()
        Me.Combostatus = New System.Windows.Forms.ComboBox()
        Me.fecharespuesta = New System.Windows.Forms.DateTimePicker()
        Me.fechaasig = New System.Windows.Forms.DateTimePicker()
        Me.concepto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.movimiento = New System.Windows.Forms.TextBox()
        Me.vistobueno = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.area = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.reviso = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(764, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(682, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.fecharecifac)
        Me.TabPage1.Controls.Add(Me.fecharecibo)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.diferencia)
        Me.TabPage1.Controls.Add(Me.sucursal)
        Me.TabPage1.Controls.Add(Me.factura)
        Me.TabPage1.Controls.Add(Me.claveprov)
        Me.TabPage1.Controls.Add(Me.proveedor)
        Me.TabPage1.Controls.Add(Me.origen)
        Me.TabPage1.Controls.Add(Me.cia)
        Me.TabPage1.Controls.Add(Me.ortex)
        Me.TabPage1.Controls.Add(Me.folio)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 469)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos  Registro"
        '
        'fecharecifac
        '
        Me.fecharecifac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecifac.Location = New System.Drawing.Point(421, 193)
        Me.fecharecifac.Name = "fecharecifac"
        Me.fecharecifac.Size = New System.Drawing.Size(142, 26)
        Me.fecharecifac.TabIndex = 17
        '
        'fecharecibo
        '
        Me.fecharecibo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibo.Location = New System.Drawing.Point(20, 122)
        Me.fecharecibo.Name = "fecharecibo"
        Me.fecharecibo.Size = New System.Drawing.Size(142, 26)
        Me.fecharecibo.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 257)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Diferencia"
        '
        'diferencia
        '
        Me.diferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.diferencia.Location = New System.Drawing.Point(105, 254)
        Me.diferencia.Name = "diferencia"
        Me.diferencia.Size = New System.Drawing.Size(254, 26)
        Me.diferencia.TabIndex = 21
        '
        'sucursal
        '
        Me.sucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sucursal.Location = New System.Drawing.Point(104, 214)
        Me.sucursal.Name = "sucursal"
        Me.sucursal.Size = New System.Drawing.Size(129, 26)
        Me.sucursal.TabIndex = 23
        '
        'factura
        '
        Me.factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.factura.Location = New System.Drawing.Point(105, 178)
        Me.factura.Name = "factura"
        Me.factura.Size = New System.Drawing.Size(254, 26)
        Me.factura.TabIndex = 15
        '
        'claveprov
        '
        Me.claveprov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.claveprov.Location = New System.Drawing.Point(371, 60)
        Me.claveprov.Name = "claveprov"
        Me.claveprov.Size = New System.Drawing.Size(145, 26)
        Me.claveprov.TabIndex = 8
        '
        'proveedor
        '
        Me.proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.proveedor.Location = New System.Drawing.Point(305, 111)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(540, 26)
        Me.proveedor.TabIndex = 9
        '
        'origen
        '
        Me.origen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.origen.Location = New System.Drawing.Point(74, 60)
        Me.origen.Name = "origen"
        Me.origen.Size = New System.Drawing.Size(193, 26)
        Me.origen.TabIndex = 7
        '
        'cia
        '
        Me.cia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cia.Location = New System.Drawing.Point(584, 21)
        Me.cia.MaxLength = 11
        Me.cia.Name = "cia"
        Me.cia.Size = New System.Drawing.Size(149, 26)
        Me.cia.TabIndex = 5
        '
        'ortex
        '
        Me.ortex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ortex.Location = New System.Drawing.Point(372, 21)
        Me.ortex.MaxLength = 20
        Me.ortex.Name = "ortex"
        Me.ortex.Size = New System.Drawing.Size(144, 26)
        Me.ortex.TabIndex = 3
        '
        'folio
        '
        Me.folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.folio.Location = New System.Drawing.Point(73, 21)
        Me.folio.MaxLength = 11
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(194, 26)
        Me.folio.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 220)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Suc"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(417, 166)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha Recibo Factura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Clave Prov"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha Recibo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(535, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 502)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(856, 469)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tratamiento"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.diasresp)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.autorizo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Comboclave)
        Me.Panel2.Controls.Add(Me.Combostatus)
        Me.Panel2.Controls.Add(Me.fecharespuesta)
        Me.Panel2.Controls.Add(Me.fechaasig)
        Me.Panel2.Controls.Add(Me.concepto)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.movimiento)
        Me.Panel2.Controls.Add(Me.vistobueno)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.area)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.reviso)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(819, 449)
        Me.Panel2.TabIndex = 1
        '
        'diasresp
        '
        Me.diasresp.BackColor = System.Drawing.Color.White
        Me.diasresp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.diasresp.Location = New System.Drawing.Point(628, 264)
        Me.diasresp.MaxLength = 20
        Me.diasresp.Name = "diasresp"
        Me.diasresp.ReadOnly = True
        Me.diasresp.Size = New System.Drawing.Size(138, 26)
        Me.diasresp.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(535, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Dias Resp."
        '
        'autorizo
        '
        Me.autorizo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.autorizo.Location = New System.Drawing.Point(93, 377)
        Me.autorizo.MaxLength = 100
        Me.autorizo.Multiline = True
        Me.autorizo.Name = "autorizo"
        Me.autorizo.Size = New System.Drawing.Size(675, 55)
        Me.autorizo.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Autorizo"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(22, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 24)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "Asignado"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(605, 71)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 24)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Resuelto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Comboclave
        '
        Me.Comboclave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Comboclave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Comboclave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Comboclave.FormattingEnabled = True
        Me.Comboclave.Location = New System.Drawing.Point(97, 137)
        Me.Comboclave.Name = "Comboclave"
        Me.Comboclave.Size = New System.Drawing.Size(671, 28)
        Me.Comboclave.TabIndex = 9
        '
        'Combostatus
        '
        Me.Combostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combostatus.FormattingEnabled = True
        Me.Combostatus.Items.AddRange(New Object() {"Selecciona", "PROCEDENTE", "IMPROCEDENTE", "PENDIENTE"})
        Me.Combostatus.Location = New System.Drawing.Point(97, 99)
        Me.Combostatus.Name = "Combostatus"
        Me.Combostatus.Size = New System.Drawing.Size(187, 28)
        Me.Combostatus.TabIndex = 16
        '
        'fecharespuesta
        '
        Me.fecharespuesta.Enabled = False
        Me.fecharespuesta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharespuesta.Location = New System.Drawing.Point(605, 30)
        Me.fecharespuesta.Name = "fecharespuesta"
        Me.fecharespuesta.Size = New System.Drawing.Size(132, 26)
        Me.fecharespuesta.TabIndex = 5
        '
        'fechaasig
        '
        Me.fechaasig.Enabled = False
        Me.fechaasig.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaasig.Location = New System.Drawing.Point(22, 30)
        Me.fechaasig.Name = "fechaasig"
        Me.fechaasig.Size = New System.Drawing.Size(132, 26)
        Me.fechaasig.TabIndex = 1
        '
        'concepto
        '
        Me.concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.concepto.Location = New System.Drawing.Point(97, 313)
        Me.concepto.MaxLength = 100
        Me.concepto.Multiline = True
        Me.concepto.Name = "concepto"
        Me.concepto.Size = New System.Drawing.Size(671, 55)
        Me.concepto.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 316)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 20)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Concepto"
        '
        'movimiento
        '
        Me.movimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.movimiento.Location = New System.Drawing.Point(98, 267)
        Me.movimiento.MaxLength = 20
        Me.movimiento.Name = "movimiento"
        Me.movimiento.Size = New System.Drawing.Size(344, 26)
        Me.movimiento.TabIndex = 13
        '
        'vistobueno
        '
        Me.vistobueno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vistobueno.Location = New System.Drawing.Point(97, 229)
        Me.vistobueno.MaxLength = 100
        Me.vistobueno.Name = "vistobueno"
        Me.vistobueno.Size = New System.Drawing.Size(345, 26)
        Me.vistobueno.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 270)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 20)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Movimiento"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 232)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 20)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "VO.BO"
        '
        'area
        '
        Me.area.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.area.Location = New System.Drawing.Point(96, 183)
        Me.area.MaxLength = 20
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(346, 26)
        Me.area.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 186)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 20)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Area"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 145)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 20)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Clave"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 107)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 20)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Status"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(463, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 20)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Fecha Respuesta"
        '
        'reviso
        '
        Me.reviso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.reviso.Location = New System.Drawing.Point(252, 27)
        Me.reviso.MaxLength = 20
        Me.reviso.Name = "reviso"
        Me.reviso.Size = New System.Drawing.Size(190, 26)
        Me.reviso.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(180, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 20)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Reviso"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(18, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 20)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Fecha Asignado"
        '
        'registrodiferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(886, 570)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registrodiferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diferencias"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents fecharecifac As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecharecibo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents diferencia As System.Windows.Forms.TextBox
    Friend WithEvents sucursal As System.Windows.Forms.TextBox
    Friend WithEvents factura As System.Windows.Forms.TextBox
    Friend WithEvents claveprov As System.Windows.Forms.TextBox
    Friend WithEvents proveedor As System.Windows.Forms.TextBox
    Friend WithEvents origen As System.Windows.Forms.TextBox
    Friend WithEvents cia As System.Windows.Forms.TextBox
    Friend WithEvents ortex As System.Windows.Forms.TextBox
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    ' Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    ' Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    '  Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Comboclave As System.Windows.Forms.ComboBox
    Friend WithEvents Combostatus As System.Windows.Forms.ComboBox
    Friend WithEvents fecharespuesta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaasig As System.Windows.Forms.DateTimePicker
    Friend WithEvents concepto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents movimiento As System.Windows.Forms.TextBox
    Friend WithEvents vistobueno As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents area As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents reviso As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents autorizo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents diasresp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
