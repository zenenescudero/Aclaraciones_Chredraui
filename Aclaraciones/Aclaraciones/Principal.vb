Imports MySql.Data.MySqlClient

Public Class Principal

    Private Sub DdddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DdddToolStripMenuItem.Click
       
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        formlocal = tablafacturas
        mostrarform(formlocal)
    End Sub

    Private Sub ClavesDeAclaracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClavesDeAclaracionToolStripMenuItem.Click
        formlocal = Claves_aclaracion
        mostrarform(formlocal)
    End Sub

    Private Sub DiferenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiferenciasToolStripMenuItem.Click
        formlocal = tabladiferencias
        mostrarform(formlocal)
    End Sub

    Private Sub OtrosConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrosConceptosToolStripMenuItem.Click
        formlocal = tablaotros
        mostrarform(formlocal)
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosdebase()

    End Sub

    Private Sub ResumenFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenFacturasToolStripMenuItem.Click

        Me.Enabled = False

        Rango_de_Consulta.Show()

    End Sub

    Private Sub ResumenPersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenPersonaToolStripMenuItem.Click
      

    End Sub

    Private Sub RegistrarOrigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarOrigenToolStripMenuItem.Click
        Origen_de_Datos.Show()

    End Sub

    Private Sub ResumenDiferenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDiferenciasToolStripMenuItem.Click
        resumendiferencias.Show()

    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem1.Click

        resumenpersona.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        formlocal = tablacompras
        mostrarform(formlocal)

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Informacion.Show()

    End Sub

    Private Sub DiferenciasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiferenciasToolStripMenuItem1.Click
        resumenpersonadiferencias.Show()

    End Sub

    Private Sub DATOSPORTALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATOSPORTALToolStripMenuItem.Click
        formlocal = DatosPortal
        mostrarform(formlocal)
    End Sub
End Class
