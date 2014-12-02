Imports MySql.Data.MySqlClient
Imports System.IO

Module modulo
    Public formactivo As Form
    Public formlocal As Form
    Public conexion As New MySqlConnection
    Dim servidor As String
    Dim usuario As String
    Dim contra As String
    Dim basedatos As String
    Public accion As String = "nuevo"
    Public vec(22) As String

    Public Function obteneruncampo(ByVal consulta As String) As String
        Dim respuesta As String = ""
        Try
            varconexion()
            conexion.Open()
            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, conexion)
            dadaptador.Fill(dset)
            conexion.Close()
            Try
                respuesta = dset.Tables(0).Rows(0)(0)
            Catch ex As Exception
                respuesta = ""
            End Try
        Catch ex As Exception
            conexion.Close()
        End Try
        Return respuesta
    End Function

    Public Sub datosdebase()
        Dim leer As StreamReader = File.OpenText("registro.txt")
        Try
            servidor = leer.ReadLine()
            basedatos = leer.ReadLine()
            usuario = leer.ReadLine
            contra = leer.ReadLine
            leer.Close()
        Catch ex As Exception
            leer.Close()
            MsgBox("Error al conectar Origen de Datos", MsgBoxStyle.Critical, "Coneccion a Datos")
        End Try
    End Sub

    Public Sub varconexion()
        conexion.ConnectionString = "server=" & servidor & ";userid=" & usuario & ";password=" & contra & ";database=" & basedatos & ";port=3306"
    End Sub

    Public Sub exportaraexcelfacturas(ByVal grid As DataGridView, ByVal ruta As String, ByVal proviene As String)

        Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
        Dim worksheet = workbook1.Worksheets.Add(proviene)
        'Dim status As String = ""
        '  Dim concepto As String = ""
        For x1 As Integer = 0 To grid.ColumnCount - 1
            worksheet.Cell(1, x1 + 1).Value = grid.Columns(x1).HeaderText
        Next

        For X As Integer = 0 To grid.RowCount - 1

            For y As Integer = 0 To grid.ColumnCount - 1
                worksheet.Cell(X + 2, y + 1).Value = grid.Item(y, X).Value
            Next
        Next

        ruta = ruta
        workbook1.SaveAs(ruta)

        If MsgBox("¿Deseas Abrir el Archivo?" & Chr(13) & ruta & "", MsgBoxStyle.YesNo, "Exportación Finalizada :) ") = MsgBoxResult.Yes Then
            Diagnostics.Process.Start(ruta)
        Else

        End If
    End Sub

    Public Sub exportaraexcel(ByVal grid As DataGridView, ByVal ruta As String, ByVal proviene As String)
        Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
        Dim worksheet = workbook1.Worksheets.Add("Datos")
        For x1 As Integer = 0 To grid.ColumnCount - 1
            worksheet.Cell(1, x1 + 1).Value = grid.Columns(x1).HeaderText
        Next
        For X As Integer = 0 To grid.RowCount - 1

            For y As Integer = 0 To grid.ColumnCount - 1
                worksheet.Cell(X + 2, y + 1).Value = grid.Item(y, X).Value
            Next
        Next
        ruta = ruta
        workbook1.SaveAs(ruta)
        If MsgBox("Deseas Abrir el Archivo?" & Chr(13) & ruta & "", MsgBoxStyle.YesNo, "Exportación Finalizada") = MsgBoxResult.Yes Then
            Diagnostics.Process.Start(ruta)
        Else

        End If
    End Sub

    Public Sub mostrarform(ByVal formlocal)
        If formactivo Is Nothing Then
        Else
            If formlocal.Equals(formactivo) Then
            Else
                formactivo.Close()
                formactivo.Dispose()
            End If
        End If
        formactivo = formlocal
        formactivo.TopLevel = False
        formactivo.Parent = Principal.contenedor()
        formactivo.Show()
    End Sub

    Public Sub opcionescombo( _
        ByVal ComboBox As ComboBox, _
        ByVal sql As String)
        'se rellena el combo el primer valor sera el identificador el segundo sera la descripcion.
        varconexion()

        Try

            ' Abrir la conexión a Sql  
            conexion.Open()

            ' Pasar la consulta sql y la conexión al Sql Command   
            Dim cmd As New MySqlCommand(sql, conexion)

            ' Inicializar un nuevo SqlDataAdapter   
            Dim da As New MySqlDataAdapter(cmd)

            'Crear y Llenar un Dataset  
            Dim ds As New DataSet
            da.Fill(ds)

            ' asignar el DataSource al combobox  
            ComboBox.DataSource = ds.Tables(0)

            ' Asignar el campo a la propiedad DisplayMember del combo   
            ComboBox.DisplayMember = ds.Tables(0).Columns(1).Caption.ToString
            ComboBox.ValueMember = ds.Tables(0).Columns(0).Caption.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, _
                            "error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            conexion.Close()
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

End Module
