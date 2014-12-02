<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CargarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSPORTALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESUMENRESUELTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESUMENPERSONASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosConceptosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClavesDeAclaracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiferenciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDiferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrigenDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarOrigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contenedor = New System.Windows.Forms.Panel()
        Me.guardar = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarDatosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.OrigenDeDatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CargarDatosToolStripMenuItem
        '
        Me.CargarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdddToolStripMenuItem, Me.RegistroManualToolStripMenuItem, Me.ClavesDeAclaracionToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.CargarDatosToolStripMenuItem.Name = "CargarDatosToolStripMenuItem"
        Me.CargarDatosToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.CargarDatosToolStripMenuItem.Text = "Opciones"
        '
        'DdddToolStripMenuItem
        '
        Me.DdddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATOSPORTALToolStripMenuItem, Me.RESUMENRESUELTOSToolStripMenuItem, Me.RESUMENPERSONASToolStripMenuItem})
        Me.DdddToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.Download
        Me.DdddToolStripMenuItem.Name = "DdddToolStripMenuItem"
        Me.DdddToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.DdddToolStripMenuItem.Text = "Del Portal"
        '
        'DATOSPORTALToolStripMenuItem
        '
        Me.DATOSPORTALToolStripMenuItem.Name = "DATOSPORTALToolStripMenuItem"
        Me.DATOSPORTALToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.DATOSPORTALToolStripMenuItem.Text = "Datos Portal"
        '
        'RESUMENRESUELTOSToolStripMenuItem
        '
        Me.RESUMENRESUELTOSToolStripMenuItem.Name = "RESUMENRESUELTOSToolStripMenuItem"
        Me.RESUMENRESUELTOSToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RESUMENRESUELTOSToolStripMenuItem.Text = "Rresumen De Reclamos"
        '
        'RESUMENPERSONASToolStripMenuItem
        '
        Me.RESUMENPERSONASToolStripMenuItem.Name = "RESUMENPERSONASToolStripMenuItem"
        Me.RESUMENPERSONASToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RESUMENPERSONASToolStripMenuItem.Text = "Resumen Persona"
        '
        'RegistroManualToolStripMenuItem
        '
        Me.RegistroManualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasToolStripMenuItem, Me.DiferenciasToolStripMenuItem, Me.OtrosConceptosToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.RegistroManualToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.Edit_Yes
        Me.RegistroManualToolStripMenuItem.Name = "RegistroManualToolStripMenuItem"
        Me.RegistroManualToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.RegistroManualToolStripMenuItem.Text = "Registro Manual"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.app_48
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'DiferenciasToolStripMenuItem
        '
        Me.DiferenciasToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.delicious_48
        Me.DiferenciasToolStripMenuItem.Name = "DiferenciasToolStripMenuItem"
        Me.DiferenciasToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.DiferenciasToolStripMenuItem.Text = "Diferencias"
        '
        'OtrosConceptosToolStripMenuItem
        '
        Me.OtrosConceptosToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.box_download_48
        Me.OtrosConceptosToolStripMenuItem.Name = "OtrosConceptosToolStripMenuItem"
        Me.OtrosConceptosToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.OtrosConceptosToolStripMenuItem.Text = "Otros Conceptos"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ClavesDeAclaracionToolStripMenuItem
        '
        Me.ClavesDeAclaracionToolStripMenuItem.Image = Global.Aclaraciones.My.Resources.Resources.Favorite
        Me.ClavesDeAclaracionToolStripMenuItem.Name = "ClavesDeAclaracionToolStripMenuItem"
        Me.ClavesDeAclaracionToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.ClavesDeAclaracionToolStripMenuItem.Text = "Claves de Aclaracion"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenFacturasToolStripMenuItem, Me.ResumenPersonaToolStripMenuItem, Me.ResumenDiferenciasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ResumenFacturasToolStripMenuItem
        '
        Me.ResumenFacturasToolStripMenuItem.Name = "ResumenFacturasToolStripMenuItem"
        Me.ResumenFacturasToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ResumenFacturasToolStripMenuItem.Text = "Resumen Facturas"
        '
        'ResumenPersonaToolStripMenuItem
        '
        Me.ResumenPersonaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasToolStripMenuItem1, Me.DiferenciasToolStripMenuItem1})
        Me.ResumenPersonaToolStripMenuItem.Name = "ResumenPersonaToolStripMenuItem"
        Me.ResumenPersonaToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ResumenPersonaToolStripMenuItem.Text = "Resumen Persona"
        '
        'FacturasToolStripMenuItem1
        '
        Me.FacturasToolStripMenuItem1.Name = "FacturasToolStripMenuItem1"
        Me.FacturasToolStripMenuItem1.Size = New System.Drawing.Size(157, 26)
        Me.FacturasToolStripMenuItem1.Text = "Facturas"
        '
        'DiferenciasToolStripMenuItem1
        '
        Me.DiferenciasToolStripMenuItem1.Name = "DiferenciasToolStripMenuItem1"
        Me.DiferenciasToolStripMenuItem1.Size = New System.Drawing.Size(157, 26)
        Me.DiferenciasToolStripMenuItem1.Text = "Diferencias"
        '
        'ResumenDiferenciasToolStripMenuItem
        '
        Me.ResumenDiferenciasToolStripMenuItem.Name = "ResumenDiferenciasToolStripMenuItem"
        Me.ResumenDiferenciasToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ResumenDiferenciasToolStripMenuItem.Text = "Resumen Diferencias"
        '
        'OrigenDeDatosToolStripMenuItem
        '
        Me.OrigenDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarOrigenToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.OrigenDeDatosToolStripMenuItem.Name = "OrigenDeDatosToolStripMenuItem"
        Me.OrigenDeDatosToolStripMenuItem.Size = New System.Drawing.Size(133, 25)
        Me.OrigenDeDatosToolStripMenuItem.Text = "Origen de datos"
        '
        'RegistrarOrigenToolStripMenuItem
        '
        Me.RegistrarOrigenToolStripMenuItem.Name = "RegistrarOrigenToolStripMenuItem"
        Me.RegistrarOrigenToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.RegistrarOrigenToolStripMenuItem.Text = "Registrar Servidor BD"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'contenedor
        '
        Me.contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contenedor.Location = New System.Drawing.Point(12, 43)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(1027, 474)
        Me.contenedor.TabIndex = 1
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1067, 570)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CargarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DdddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contenedor As System.Windows.Forms.Panel
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosConceptosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClavesDeAclaracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ResumenPersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrigenDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarOrigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiferenciasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDiferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATOSPORTALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESUMENRESUELTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESUMENPERSONASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
