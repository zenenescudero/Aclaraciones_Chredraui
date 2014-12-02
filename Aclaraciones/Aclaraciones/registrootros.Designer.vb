<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrootros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrootros))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fecharecibo = New System.Windows.Forms.DateTimePicker()
        Me.Respuesta = New System.Windows.Forms.TextBox()
        Me.reviso = New System.Windows.Forms.TextBox()
        Me.asunto = New System.Windows.Forms.TextBox()
        Me.claveprov = New System.Windows.Forms.TextBox()
        Me.proveedor = New System.Windows.Forms.TextBox()
        Me.origen = New System.Windows.Forms.TextBox()
        Me.cia = New System.Windows.Forms.TextBox()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.f = New System.Windows.Forms.Label()
        Me.dede = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(783, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(649, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.fecharecibo)
        Me.TabPage1.Controls.Add(Me.Respuesta)
        Me.TabPage1.Controls.Add(Me.reviso)
        Me.TabPage1.Controls.Add(Me.asunto)
        Me.TabPage1.Controls.Add(Me.claveprov)
        Me.TabPage1.Controls.Add(Me.proveedor)
        Me.TabPage1.Controls.Add(Me.origen)
        Me.TabPage1.Controls.Add(Me.cia)
        Me.TabPage1.Controls.Add(Me.folio)
        Me.TabPage1.Controls.Add(Me.f)
        Me.TabPage1.Controls.Add(Me.dede)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(883, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos  Registro"
        '
        'fecharecibo
        '
        Me.fecharecibo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibo.Location = New System.Drawing.Point(69, 118)
        Me.fecharecibo.Name = "fecharecibo"
        Me.fecharecibo.Size = New System.Drawing.Size(142, 26)
        Me.fecharecibo.TabIndex = 10
        '
        'Respuesta
        '
        Me.Respuesta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Respuesta.Location = New System.Drawing.Point(113, 258)
        Me.Respuesta.MaxLength = 200
        Me.Respuesta.Multiline = True
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Size = New System.Drawing.Size(600, 91)
        Me.Respuesta.TabIndex = 23
        '
        'reviso
        '
        Me.reviso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.reviso.Location = New System.Drawing.Point(113, 215)
        Me.reviso.Name = "reviso"
        Me.reviso.Size = New System.Drawing.Size(254, 26)
        Me.reviso.TabIndex = 19
        '
        'asunto
        '
        Me.asunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.asunto.Location = New System.Drawing.Point(113, 173)
        Me.asunto.Name = "asunto"
        Me.asunto.Size = New System.Drawing.Size(254, 26)
        Me.asunto.TabIndex = 15
        '
        'claveprov
        '
        Me.claveprov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.claveprov.Location = New System.Drawing.Point(397, 76)
        Me.claveprov.Name = "claveprov"
        Me.claveprov.Size = New System.Drawing.Size(125, 26)
        Me.claveprov.TabIndex = 8
        '
        'proveedor
        '
        Me.proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.proveedor.Location = New System.Drawing.Point(315, 117)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(556, 26)
        Me.proveedor.TabIndex = 9
        '
        'origen
        '
        Me.origen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.origen.Location = New System.Drawing.Point(72, 78)
        Me.origen.Name = "origen"
        Me.origen.Size = New System.Drawing.Size(200, 26)
        Me.origen.TabIndex = 7
        '
        'cia
        '
        Me.cia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cia.Location = New System.Drawing.Point(398, 36)
        Me.cia.Name = "cia"
        Me.cia.Size = New System.Drawing.Size(262, 26)
        Me.cia.TabIndex = 5
        '
        'folio
        '
        Me.folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.folio.Location = New System.Drawing.Point(71, 36)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(205, 26)
        Me.folio.TabIndex = 1
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Location = New System.Drawing.Point(17, 264)
        Me.f.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(87, 20)
        Me.f.TabIndex = 20
        Me.f.Text = "Respuesta"
        '
        'dede
        '
        Me.dede.AutoSize = True
        Me.dede.Location = New System.Drawing.Point(17, 215)
        Me.dede.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dede.Name = "dede"
        Me.dede.Size = New System.Drawing.Size(57, 20)
        Me.dede.TabIndex = 18
        Me.dede.Text = "Reviso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 179)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Asunto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Clave Prov"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(891, 405)
        Me.TabControl1.TabIndex = 2
        '
        'registrootros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(917, 480)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registrootros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Otros Conceptos"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents fecharecibo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents reviso As System.Windows.Forms.TextBox
    Friend WithEvents asunto As System.Windows.Forms.TextBox
    Friend WithEvents claveprov As System.Windows.Forms.TextBox
    Friend WithEvents proveedor As System.Windows.Forms.TextBox
    Friend WithEvents origen As System.Windows.Forms.TextBox
    Friend WithEvents cia As System.Windows.Forms.TextBox
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents f As System.Windows.Forms.Label
    Friend WithEvents dede As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    '  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    '  Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    ' Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
