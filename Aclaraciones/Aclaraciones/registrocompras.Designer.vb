<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrocompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrocompras))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fecharecibo = New System.Windows.Forms.DateTimePicker()
        Me.comprador = New System.Windows.Forms.TextBox()
        Me.claveprov = New System.Windows.Forms.TextBox()
        Me.proveedor = New System.Windows.Forms.TextBox()
        Me.dede = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(635, 12)
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
        Me.Button1.Location = New System.Drawing.Point(501, 12)
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
        Me.TabPage1.Controls.Add(Me.comprador)
        Me.TabPage1.Controls.Add(Me.claveprov)
        Me.TabPage1.Controls.Add(Me.proveedor)
        Me.TabPage1.Controls.Add(Me.dede)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos  Registro"
        '
        'fecharecibo
        '
        Me.fecharecibo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibo.Location = New System.Drawing.Point(96, 177)
        Me.fecharecibo.Name = "fecharecibo"
        Me.fecharecibo.Size = New System.Drawing.Size(142, 26)
        Me.fecharecibo.TabIndex = 10
        '
        'comprador
        '
        Me.comprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.comprador.Location = New System.Drawing.Point(101, 128)
        Me.comprador.Name = "comprador"
        Me.comprador.Size = New System.Drawing.Size(556, 26)
        Me.comprador.TabIndex = 19
        '
        'claveprov
        '
        Me.claveprov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.claveprov.Location = New System.Drawing.Point(100, 41)
        Me.claveprov.Name = "claveprov"
        Me.claveprov.Size = New System.Drawing.Size(125, 26)
        Me.claveprov.TabIndex = 8
        '
        'proveedor
        '
        Me.proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.proveedor.Location = New System.Drawing.Point(100, 87)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(556, 26)
        Me.proveedor.TabIndex = 9
        '
        'dede
        '
        Me.dede.AutoSize = True
        Me.dede.Location = New System.Drawing.Point(6, 134)
        Me.dede.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dede.Name = "dede"
        Me.dede.Size = New System.Drawing.Size(88, 20)
        Me.dede.TabIndex = 18
        Me.dede.Text = "Comprador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Clave Prov"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Proveedor"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 334)
        Me.TabControl1.TabIndex = 2
        '
        'registrocompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(774, 417)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registrocompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Compras"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents fecharecibo As System.Windows.Forms.DateTimePicker
    Friend WithEvents comprador As System.Windows.Forms.TextBox
    Friend WithEvents claveprov As System.Windows.Forms.TextBox
    Friend WithEvents proveedor As System.Windows.Forms.TextBox
    Friend WithEvents dede As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
