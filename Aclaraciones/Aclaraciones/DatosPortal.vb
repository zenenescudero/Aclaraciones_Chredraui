Imports DocumentFormat.OpenXml
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class DatosPortal


    Public Sub formarconsulta()

        Dim antes As Integer = 0
        Dim consulta As String = "select * from portal "

        If Trim(proveedor.Text).Length > 0 Then
            consulta = consulta & " where proveedor='" & Trim(proveedor.Text) & "'  "
            antes = 1
        End If

        If Trim(reclamo.Text).Length > 0 Then

            If antes = 1 Then
                consulta = consulta & " and reclamo='" & Trim(reclamo.Text) & "' "
            Else
                consulta = consulta & " where reclamo='" & Trim(reclamo.Text) & "' "
            End If
            antes = 1
        End If

        If Trim(estado.Text).Length > 0 Then

            If antes = 1 Then
                    consulta = consulta & " and estado='" & Trim(estado.Text) & "' "

            Else
                consulta = consulta & "  where estado='" & Trim(estado.Text) & "' "
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


        If ingreso.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and ingreso BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " where ingreso BETWEEN " & cadena & cadena2
            End If
            antes = 1
        End If

        If resolucion.Checked = True Then
            If antes = 1 Then
                consulta = consulta & " and resolucion  BETWEEN " & cadena & cadena2

            Else
                consulta = consulta & " where resolucion BETWEEN " & cadena & cadena2
            End If
            antes = 1
        End If

        Try
            consultar(consulta)

        Catch ex As Exception
            MsgBox("INTENTA DE NUEVO LA CONSULTA OCURRIO UN ERROR", MsgBoxStyle.Exclamation, "CONSULTA " & consulta)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName.Length > 0 Then

            Try
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 2
                Dim texto As String = worksheet.Cell(x, 1).Value
                While (texto.Length > 0)
                    gridtabla.Rows.Add(worksheet.Cell(x, 1).Value, _
                                       worksheet.Cell(x, 2).Value, _
                                       worksheet.Cell(x, 3).Value, _
                                       worksheet.Cell(x, 4).Value, _
                                       worksheet.Cell(x, 5).Value, _
                                       worksheet.Cell(x, 6).Value, _
                                       worksheet.Cell(x, 7).Value, _
                                       worksheet.Cell(x, 8).Value, _
                                       worksheet.Cell(x, 9).Value, _
                                       worksheet.Cell(x, 10).Value, _
                                       worksheet.Cell(x, 11).Value, _
                                       worksheet.Cell(x, 12).Value, _
                                       worksheet.Cell(x, 13).Value, _
                                       worksheet.Cell(x, 14).Value, _
                                       worksheet.Cell(x, 15).Value, _
                                       worksheet.Cell(x, 16).Value, _
                                       worksheet.Cell(x, 17).Value, _
                                       worksheet.Cell(x, 18).Value)
                    x = x + 1
                    texto = worksheet.Cell(x, 1).Value
                End While

                MsgBox("Termino la Importación de datos", MsgBoxStyle.Information, "Datos de Excel")

                Label3.Text = "No Registros: " & gridtabla.RowCount

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("Al realizar esta accion remplazaras todos los registros existentes" & Chr(13) & " ¿Estas seguro de continuar? :)", MsgBoxStyle.OkCancel, "Remplazar Datos") = vbOK Then
        Else
            Exit Sub
        End If


        Principal.Enabled = False
        varconexion()
        If gridtabla.RowCount < 1 Then
            MsgBox("no hay datos")
            Principal.Enabled = True

            Exit Sub
        End If

        Try
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MsgBox("El servidor dejo de funcionar :( ", MsgBoxStyle.Critical, "Coneccion")
            conexion.Close()
            Principal.Enabled = True
            Exit Sub
        End Try

        Try
            conexion.Open()
            Dim eliminar As String = "delete from portal"
            Dim comando As New MySqlCommand(eliminar, conexion)
            comando.CommandType = CommandType.Text
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex1 As Exception
            conexion.Close()
        End Try

        proceso.Value = 0
        proceso.Maximum = gridtabla.RowCount


        conexion.Open()
        For x = 0 To gridtabla.RowCount - 1

            Try
                Dim agrega As String = "call insertarportal(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18)"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@v1", gridtabla.Item(0, x).Value)
                comando.Parameters.AddWithValue("@v2", gridtabla.Item(1, x).Value)
                comando.Parameters.AddWithValue("@v3", gridtabla.Item(2, x).Value)
                comando.Parameters.AddWithValue("@v4", gridtabla.Item(3, x).Value)
                comando.Parameters.AddWithValue("@v5", gridtabla.Item(4, x).Value)
                comando.Parameters.AddWithValue("@v6", gridtabla.Item(5, x).Value)
                comando.Parameters.AddWithValue("@v7", gridtabla.Item(6, x).Value)
                comando.Parameters.AddWithValue("@v8", gridtabla.Item(7, x).Value)
                comando.Parameters.AddWithValue("@v9", gridtabla.Item(8, x).Value)
                comando.Parameters.AddWithValue("@v10", gridtabla.Item(9, x).Value)

                If IsDate(gridtabla.Item(10, x).Value) Then
                    comando.Parameters.AddWithValue("@v11", gridtabla.Item(10, x).Value)
                Else
                    comando.Parameters.AddWithValue("@v11", 0)
                End If

                comando.Parameters.AddWithValue("@v12", gridtabla.Item(11, x).Value)
                comando.Parameters.AddWithValue("@v13", gridtabla.Item(12, x).Value)
                comando.Parameters.AddWithValue("@v14", gridtabla.Item(13, x).Value)
                comando.Parameters.AddWithValue("@v15", gridtabla.Item(14, x).Value)
                comando.Parameters.AddWithValue("@v16", gridtabla.Item(15, x).Value)
                comando.Parameters.AddWithValue("@v17", gridtabla.Item(16, x).Value)
                comando.Parameters.AddWithValue("@v18", gridtabla.Item(17, x).Value)

                comando.ExecuteNonQuery()

            Catch ex As Exception
                Principal.Enabled = True
                conexion.Close()
                proceso.Value = 1
                MsgBox("Error en los datos :(   fila: " & x & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en los datos")
                'en caso de error se elimina lo insetado para evitar duplicidad
                Try
                    conexion.Open()
                    Dim eliminar As String = "delete from portal"
                    Dim comando As New MySqlCommand(eliminar, conexion)
                    comando.CommandType = CommandType.Text
                    comando.ExecuteNonQuery()
                    conexion.Close()
                Catch ex1 As Exception
                    conexion.Close()
                End Try

                Exit Sub
            End Try
            proceso.Value = x
        Next
        conexion.Close()
        MsgBox("Se agregaron Correctamente los datos :) ", MsgBoxStyle.Information, "Importacion Exitosa :)")
        proceso.Value = 0

        Principal.Enabled = True

    End Sub

    Public Sub consultar(ByVal consulta As String)
        Dim x As Integer = 0

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
              For x = 0 To dtable.Rows.Count - 1
                gridtabla.Rows.Add(dset.Tables(0).Rows(x)(0), _
                                   dset.Tables(0).Rows(x)(1), _
                                   dset.Tables(0).Rows(x)(2), _
                                   dset.Tables(0).Rows(x)(3), _
                                   dset.Tables(0).Rows(x)(4), _
                                   dset.Tables(0).Rows(x)(5), _
                                   dset.Tables(0).Rows(x)(6), _
                                   dset.Tables(0).Rows(x)(7), _
                                   dset.Tables(0).Rows(x)(8), _
                                   dset.Tables(0).Rows(x)(9), _
                                   dset.Tables(0).Rows(x)(10), _
                                   dset.Tables(0).Rows(x)(11), _
                                   dset.Tables(0).Rows(x)(12), _
                                   dset.Tables(0).Rows(x)(13), _
                                   dset.Tables(0).Rows(x)(14), _
                                   dset.Tables(0).Rows(x)(15), _
                                   dset.Tables(0).Rows(x)(16), _
                                   dset.Tables(0).Rows(x)(17))
            Next

        Catch ex As Exception
            MsgBox(ex.Message & " " & x)
            conexion.Close()
        End Try

    End Sub

    Private Sub DatosPortal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            gridtabla.Rows.Clear()
            consultar("Select * from portal")
        Else
            gridtabla.Rows.Clear()

        End If
    End Sub

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        Label3.Text = "No Registros: " & Format(gridtabla.RowCount, "###,###,###")
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        Label3.Text = "No Registros: " & Format(gridtabla.RowCount, "###,###,###")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            Button1.Visible = True
            Button2.Visible = True
            proceso.Visible = True
        Else
            Button1.Visible = False
            Button2.Visible = False
            proceso.Visible = False
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        formarconsulta()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        guardar.FileName = ""
        guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        guardar.Title = "Exportar a Excel"
        guardar.ShowDialog()

        If guardar.FileName.Length > 0 Then
            exportaraexcelfacturas(gridtabla, guardar.FileName, "Portal")
        Else
            MsgBox("Selecciona Donde Guardar", MsgBoxStyle.Critical, "Exportación a Excel")
        End If
    End Sub

   
End Class