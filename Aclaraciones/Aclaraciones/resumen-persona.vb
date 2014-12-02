Imports MySql.Data.MySqlClient


Public Class resumenpersona

    Public Sub consultar(ByVal consulta As String)
        Try
            varconexion()
            conexion.Open()
            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, conexion)
            dadaptador.Fill(dset)
            conexion.Close()
            Dim dtable As DataTable = dset.Tables(0)
            Gridfactura.DataSource = dtable
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Public Sub excelfacturas()
        guardar.FileName = ""
        guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        guardar.Title = "Exportar a Excel"
        guardar.ShowDialog()
        If guardar.FileName.Length > 0 Then
            exportaraexcelfacturas(Gridfactura, guardar.FileName, "ResumenFacturas")
        Else
            MsgBox("Selecciona Donde Guardar", MsgBoxStyle.Critical, "Exportación a Excel")
        End If
    End Sub

    Private Sub Rango_de_Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 150
        Me.Left = 150


        Label2.Text = "Resumen de casos Resueltos y pendientes" & Chr(13) & "Por persona Durante el periodo consultado"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        formarconsulta()
    End Sub

    Public Sub formarconsulta()

        Dim partir As String()
        Dim cadena As String = DESDE.Text
        partir = cadena.Split("/")
        cadena = "'" + partir(2) + "/" + partir(1) + "/" + partir(0) + "'  AND '"
        Dim partir2 As String()
        Dim cadena2 As String = HASTA.Text
        partir2 = cadena2.Split("/")
        cadena2 = partir2(2) + "/" + partir2(1) + "/" + partir2(0) + "'"
        Dim consulta As String = "select REVISO,STATUS,COUNT(STATUS) AS CANTIDAD FROM diferencias F where F.REVISO<>'' AND "
        consulta = consulta & " FECHA_RESPUESTA BETWEEN " & cadena & cadena2 & " OR STATUS='PENDIENTE' GROUP BY REVISO,STATUS ORDER BY REVISO"
        ' MsgBox(consulta)
        consultar(consulta)
    End Sub

    Private Sub Rango_de_Consulta_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Gridfactura.RowCount > 0 Then
            excelfacturas()
        Else
            MsgBox("la consulta no encontro datos", MsgBoxStyle.Information, "Facturas")
        End If
    End Sub

    Private Sub Gridfactura_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Gridfactura.RowsAdded

        Label1.Text = "Resultados: " & Format(Gridfactura.RowCount, "###,###,###")

    End Sub

    Private Sub Gridfactura_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Gridfactura.RowsRemoved

        Label1.Text = "Resultados: " & Format(Gridfactura.RowCount, "###,###,###")

    End Sub
End Class