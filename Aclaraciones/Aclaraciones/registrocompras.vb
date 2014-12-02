Imports MySql.Data.MySqlClient

Public Class registrocompras

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub registrar()
        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "insert into compras values(@v1,@v2,@v3,@v4,default)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", Trim(claveprov.Text))
            comando.Parameters.AddWithValue("@v2", Trim(proveedor.Text))
            comando.Parameters.AddWithValue("@v3", Trim(comprador.Text))
            comando.Parameters.AddWithValue("@v4", fecharecibo.Value)
            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Registro Correcto :)", MsgBoxStyle.Information, "Registro Compras")
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error :( ", MsgBoxStyle.Exclamation, "Registro compras")
            conexion.Close()
        End Try
    End Sub

    Public Sub editar()
        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "update compras set clave_prov=@v1,proveedor=@v2,comprador=@v3,fecha_recibo=@v4 where id=@id"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", Trim(claveprov.Text))
            comando.Parameters.AddWithValue("@v2", Trim(proveedor.Text))
            comando.Parameters.AddWithValue("@v3", Trim(comprador.Text))
            comando.Parameters.AddWithValue("@v4", fecharecibo.Value)
            comando.Parameters.AddWithValue("@id", vec(4))
            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Edicion Correcta :)", MsgBoxStyle.Information, "Edición Compras")
            Me.Close()
        Catch ex As Exception
            conexion.Close()
            MsgBox("Ocurrio un Error :(", MsgBoxStyle.Exclamation, "Edicion Compras")
        End Try

    End Sub

    Function validar() As Integer

        If Trim(claveprov.Text).Length < 1 Then
            MsgBox("La clave de proveedor no puede ser vacio", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End If
        If Trim(proveedor.Text).Length < 1 Then
            MsgBox("Proveedor no puede ser Vacio", MsgBoxStyle.Information, "Validando Datos")
            Return 0
            Exit Function
        End If

        If Trim(comprador.Text).Length < 1 Then
            If MsgBox("No has Asignado Comprador" & "¿Deseas guardar como vacio?", MsgBoxStyle.OkCancel, "Comprador") = vbOK Then
            Else
                Return 0
                Exit Function
            End If
        End If
       

        Return 1

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If validar() = 0 Then
            Exit Sub
        End If
        If accion = "nuevo" Then
            registrar()
        Else
            editar()
        End If
        tablacompras.consultaformada()
        tablacompras.Gridfactura.Columns("ID").Visible = False
    End Sub

    Private Sub facturasregistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Top = 150
        Left = 200
        Principal.Enabled = False
        If accion = "editar" Then
            claveprov.Text = vec(0)
            proveedor.Text = vec(1)
            comprador.Text = vec(2)
            fecharecibo.Value = vec(4)
        End If

    End Sub

    Private Sub importe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles claveprov.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub facturasregistro_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub
End Class