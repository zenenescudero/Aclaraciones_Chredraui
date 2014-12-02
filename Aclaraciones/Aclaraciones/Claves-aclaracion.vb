Imports MySql.Data.MySqlClient

Public Class Claves_aclaracion

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length > 0 Then

            Try
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 2
                Dim texto As String = worksheet.Cell(x, 1).Value
                While (texto.Length > 0)

                    gridtabla.Rows.Add(Trim(worksheet.Cell(x, 1).Value), Trim(worksheet.Cell(x, 2).Value), Trim(worksheet.Cell(x, 3).Value), Trim(worksheet.Cell(x, 4).Value), Trim(worksheet.Cell(x, 5).Value), Trim(worksheet.Cell(x, 6).Value))
                    x = x + 1
                    texto = Trim(worksheet.Cell(x, 1).Value)
                End While

                MsgBox("Termino la Importación de datos", MsgBoxStyle.Information, "Datos de Excel")

            Catch ex As Exception
                MsgBox("Error al abrir el archivo", MsgBoxStyle.Critical, "Error al Importar")
            End Try

        Else
            MsgBox("Eligue el Origen de datos", MsgBoxStyle.Critical, "Error al Importar")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        varconexion()
        If gridtabla.RowCount < 1 Then
            MsgBox("no hay datos", MsgBoxStyle.Exclamation, "Alerta")
            Exit Sub
        End If
        Try
            conexion.Open()
            Dim agrega As String = "delete from clavesaclaracion"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            MsgBox("No se Modificaron los datos...", MsgBoxStyle.Exclamation, "Alerta")
            Exit Sub
        End Try

        For x As Integer = 0 To gridtabla.RowCount - 1
            Try
                conexion.Open()
                Dim agrega As String = "insert into clavesaclaracion values(@v1,@v2,@v3,@v4,@v5,@v6)"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@v1", gridtabla.Item(0, x).Value)
                comando.Parameters.AddWithValue("@v2", gridtabla.Item(1, x).Value)
                comando.Parameters.AddWithValue("@v3", gridtabla.Item(2, x).Value)
                comando.Parameters.AddWithValue("@v4", gridtabla.Item(3, x).Value)
                comando.Parameters.AddWithValue("@v5", gridtabla.Item(4, x).Value)
                comando.Parameters.AddWithValue("@v6", gridtabla.Item(5, x).Value)
                comando.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        Next

        gridtabla.Rows.Clear()
        MsgBox("Se guardaron los nuevos datos", MsgBoxStyle.Information, "Datos Guardados")
        consultar("select * from clavesaclaracion order by tipo")
        CheckBox1.Checked = False

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
            '  gridtabla.DataSource = dtable
            gridtabla.Rows.Clear()
            For x As Integer = 0 To dtable.Rows.Count - 1
                gridtabla.Rows.Add(dset.Tables(0).Rows(x)(0), dset.Tables(0).Rows(x)(1), dset.Tables(0).Rows(x)(2), dset.Tables(0).Rows(x)(3), dset.Tables(0).Rows(x)(4), dset.Tables(0).Rows(x)(5))
            Next
        Catch ex As Exception
            conexion.Close()
        End Try

    End Sub

    Private Sub Claves_aclaracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultar("select * from clavesaclaracion order by tipo")
    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click

        accion = "nuevo"
        Principal.Enabled = False
        claveaclaracionnuevo.Show()

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        accion = "editar"
        Try
            vec(0) = Convert.ToString(gridtabla.Item(0, gridtabla.CurrentRow.Index).Value)
            vec(1) = Convert.ToString(gridtabla.Item(1, gridtabla.CurrentRow.Index).Value)
            vec(2) = Convert.ToString(gridtabla.Item(2, gridtabla.CurrentRow.Index).Value)
            vec(3) = Convert.ToString(gridtabla.Item(3, gridtabla.CurrentRow.Index).Value)
            vec(4) = Convert.ToString(gridtabla.Item(4, gridtabla.CurrentRow.Index).Value)
            vec(5) = Convert.ToString(gridtabla.Item(5, gridtabla.CurrentRow.Index).Value)
            Principal.Enabled = False
            claveaclaracionnuevo.Show()
        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Dim texto As String = "Al realizar la carga de un excel se ELIMINAN LOS DATOS ACTUALES " & Chr(13) & " y son REMPLAZADOS POR LOS DATOS DEL EXCEL cargado," & Chr(13) & " los datos del Excel se visualizaran en la grilla " & Chr(13) & "y podran ser editados antes de ser guardados" & Chr(13) & "ESTAS SEGURO DE QUERER REMPLAZAR LOS DATOS"
        If CheckBox1.Checked = True Then
            Panel1.Visible = True
            If MsgBox(texto, MsgBoxStyle.YesNo, "DATOS DE EXCEL ") = MsgBoxResult.Yes Then
                gridtabla.Rows.Clear()
                nuevo.Enabled = False
                eliminar.Enabled = False
                editar.Enabled = False
            Else
                Panel1.Visible = False
                CheckBox1.Checked = False
            End If
        Else
            Panel1.Visible = False
        End If

        If CheckBox1.Checked = False Then
            gridtabla.Rows.Clear()
            consultar("select * from clavesaclaracion order by tipo")
            nuevo.Enabled = True
            eliminar.Enabled = True
            editar.Enabled = True
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click

        If MsgBox("Estas Seguro de eliminar esta Clave", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Try
                conexion.Open()
                Dim agrega As String = "delete from clavesaclaracion where clave=@clave"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@clave", gridtabla.Item(gridtabla.Columns("CLAVE").Index, gridtabla.CurrentRow.Index).Value)
                comando.ExecuteNonQuery()
                conexion.Close()
                gridtabla.Rows.Clear()
                consultar("select * from clavesaclaracion order by tipo")
            Catch ex As Exception
                conexion.Close()
                MsgBox("No se Modificaron los datos...intente de nuevo", MsgBoxStyle.Exclamation, "Alerta")
                Exit Sub
            End Try
        Else

        End If
        
    End Sub

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        Label2.Text = "Registros: " & Format(gridtabla.Rows.Count, "###,###,###")
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        Label2.Text = "Registros: " & Format(gridtabla.Rows.Count, "###,###,###")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Todos" Then
            consultar("select * from clavesaclaracion order by tipo")
        Else
            consultar("select * from clavesaclaracion where tipo='" & ComboBox1.Text & "'")
        End If
    
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        guardar.FileName = ""
        guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        guardar.Title = "Exportar a Excel"
        guardar.ShowDialog()

        If guardar.FileName.Length > 0 Then
            exportaraexcelfacturas(gridtabla, guardar.FileName, "Claves Aclaracion")
        Else
            MsgBox("Selecciona Donde Guardar", MsgBoxStyle.Critical, "Exportación a Excel")
        End If

    End Sub
End Class