Imports MySql.Data.MySqlClient


Public Class tabladiferencias

    Private Sub tablafacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultar("select * from diferencias where id=0 order by id")
        Gridfactura.Columns("ID").Visible = False
    End Sub

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

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        accion = "nuevo"
        registrodiferencias.Show()

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        accion = "editar"
        Try
            vec(0) = Convert.ToString(Gridfactura.Item(0, Gridfactura.CurrentRow.Index).Value)
            vec(1) = Convert.ToString(Gridfactura.Item(1, Gridfactura.CurrentRow.Index).Value)
            vec(2) = Convert.ToString(Gridfactura.Item(2, Gridfactura.CurrentRow.Index).Value)
            vec(3) = Convert.ToString(Gridfactura.Item(3, Gridfactura.CurrentRow.Index).Value)
            vec(4) = Convert.ToString(Gridfactura.Item(4, Gridfactura.CurrentRow.Index).Value)
            vec(5) = Convert.ToString(Gridfactura.Item(5, Gridfactura.CurrentRow.Index).Value)
            vec(6) = Convert.ToString(Gridfactura.Item(6, Gridfactura.CurrentRow.Index).Value)
            vec(7) = Convert.ToString(Gridfactura.Item(7, Gridfactura.CurrentRow.Index).Value)
            vec(8) = Convert.ToString(Gridfactura.Item(8, Gridfactura.CurrentRow.Index).Value)
            vec(9) = Convert.ToString(Gridfactura.Item(9, Gridfactura.CurrentRow.Index).Value)
            vec(10) = Convert.ToString(Gridfactura.Item(10, Gridfactura.CurrentRow.Index).Value)
            vec(11) = Convert.ToString(Gridfactura.Item(11, Gridfactura.CurrentRow.Index).Value)
            vec(12) = Convert.ToString(Gridfactura.Item(12, Gridfactura.CurrentRow.Index).Value)
            vec(13) = Convert.ToString(Gridfactura.Item(13, Gridfactura.CurrentRow.Index).Value)
            vec(14) = Convert.ToString(Gridfactura.Item(14, Gridfactura.CurrentRow.Index).Value)
            vec(15) = Convert.ToString(Gridfactura.Item(15, Gridfactura.CurrentRow.Index).Value)
            vec(16) = Convert.ToString(Gridfactura.Item(16, Gridfactura.CurrentRow.Index).Value)
            vec(17) = Convert.ToString(Gridfactura.Item(17, Gridfactura.CurrentRow.Index).Value)
            vec(18) = Convert.ToString(Gridfactura.Item(18, Gridfactura.CurrentRow.Index).Value)
            vec(19) = Convert.ToString(Gridfactura.Item(19, Gridfactura.CurrentRow.Index).Value)
            vec(20) = Convert.ToString(Gridfactura.Item(20, Gridfactura.CurrentRow.Index).Value)
            vec(21) = Convert.ToString(Gridfactura.Item(21, Gridfactura.CurrentRow.Index).Value)
            vec(22) = Convert.ToString(Gridfactura.Item(22, Gridfactura.CurrentRow.Index).Value)

            registrodiferencias.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click
        varconexion()
        If MsgBox("Estas seguro de eliminar este registro", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then
            Try
                conexion.Open()
                'nueva forma de agregar
                Dim agrega As String = "delete from diferencias where ID=@id"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@id", Gridfactura.Item(Gridfactura.Columns("ID").Index, Gridfactura.CurrentRow.Index).Value)
                comando.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Eliminado Corectamente", vbInformation, "Operacion Correcta")
                consultaformada()

                'limpiar campos
            Catch ex As Exception
                conexion.Close()
            End Try
        Else

        End If
    End Sub

    Private Sub Gridfactura_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Gridfactura.RowsAdded
        Label2.Text = "Registros: " & Format(Gridfactura.Rows.Count, "###,###,###")
    End Sub

    Private Sub Gridfactura_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Gridfactura.RowsRemoved
        Label2.Text = "Registros: " & Format(Gridfactura.Rows.Count, "###,###,###")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        guardar.FileName = ""
        guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        guardar.Title = "Exportar a Excel"
        guardar.ShowDialog()

        If guardar.FileName.Length > 0 Then
            exportaraexcelfacturas(Gridfactura, guardar.FileName, "Diferencias")
        Else
            MsgBox("Selecciona Donde Guardar", MsgBoxStyle.Critical, "Exportación a Excel")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        consultaformada()

    End Sub

    Public Sub consultaformada()

        Dim antes As Integer = 0
        Dim consulta As String = "select * from diferencias where "

        If Trim(Provedor.Text).Length > 0 Then
            consulta = consulta & " clave_prov='" & Trim(Provedor.Text) & "'  "
            antes = 1
        End If

        If Trim(Folio.Text).Length > 0 Then

            If antes = 1 Then
                consulta = consulta & " and folio='" & Trim(Folio.Text) & "' "
            Else
                consulta = consulta & " folio='" & Trim(Folio.Text) & "' "
            End If
            antes = 1
        End If

        If Trim(status.Text).Length > 0 Then

            If antes = 1 Then
                If status.Text = "TODOS" Then
                    consulta = consulta & " and STATUS<>'' "
                Else
                    consulta = consulta & " and STATUS='" & Trim(status.Text) & "' "
                End If
            Else
                If status.Text = "TODOS" Then
                    consulta = consulta & " STATUS<>'' "
                Else
                    consulta = consulta & "  STATUS='" & Trim(status.Text) & "' "
                End If
            End If
            antes = 1
        End If




        Dim partir As String()
        Dim cadena As String = desde.Text
        partir = cadena.Split("/")
        cadena = "'" + partir(2) + "/" + partir(1) + "/" + partir(0) + "'  AND '"

        Dim partir2 As String()
        Dim cadena2 As String = hasta.Text
        partir2 = cadena2.Split("/")
        cadena2 = partir2(2) + "/" + partir2(1) + "/" + partir2(0) + "'"


        If recibo.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and FECHA_RECIBO BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " FECHA_RECIBO BETWEEN " & cadena & cadena2
            End If
            antes = 1
        End If

        If recibofactura.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and FECHA_RECIBO_FACTURA BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " FECHA_RECIBO_FACTURA BETWEEN " & cadena & cadena2
            End If
            antes = 1
        End If

        If asignado.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and FECHA_ASIGNADO BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " FECHA_ASIGNADO BETWEEN " & cadena & cadena2
            End If
            antes = 1
        End If

        If respuesta.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and FECHA_RESPUESTA BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " FECHA_RESPUESTA BETWEEN " & cadena & cadena2
            End If
        End If
        Try
            consultar(consulta)

        Catch ex As Exception
            MsgBox("INTENTA DE NUEVO LA CONSULTA OCURRIO UN ERROR", MsgBoxStyle.Exclamation, "CONSULTA " & consulta)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        diferenciasmasivo.Show()
    End Sub
End Class