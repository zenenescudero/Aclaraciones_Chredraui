Imports MySql.Data.MySqlClient

Public Class registrootros

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub registrar()

        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "insert into otrosconceptos values(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,default)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", Trim(folio.Text))
            comando.Parameters.AddWithValue("@v2", Trim(origen.Text))
            comando.Parameters.AddWithValue("@v3", Trim(cia.Text))
            comando.Parameters.AddWithValue("@v4", Trim(claveprov.Text))
            comando.Parameters.AddWithValue("@v5", Trim(proveedor.Text))
            comando.Parameters.AddWithValue("@v6", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v7", Trim(asunto.Text))
            comando.Parameters.AddWithValue("@v8", Trim(reviso.Text))
            comando.Parameters.AddWithValue("@v9", Trim(Respuesta.Text))
            comando.ExecuteNonQuery()
            conexion.Close()
            Me.Close()
        Catch ex As Exception
            conexion.Close()
        End Try

    End Sub

    Public Sub editar()

        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "update otrosconceptos set folio=@v1,origen=@v2,cia=@v3,clave_prov=@v4,proveedor=@v5,fecha=@v6,asunto=@v7,reviso=@v8,respuesta=@v9 where id=@id"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", folio.Text)
            comando.Parameters.AddWithValue("@v2", origen.Text)
            comando.Parameters.AddWithValue("@v3", cia.Text)
            comando.Parameters.AddWithValue("@v4", claveprov.Text)
            comando.Parameters.AddWithValue("@v5", proveedor.Text)
            comando.Parameters.AddWithValue("@v6", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v7", asunto.Text)
            comando.Parameters.AddWithValue("@v8", reviso.Text)
            comando.Parameters.AddWithValue("@v9", Respuesta.Text)
            comando.Parameters.AddWithValue("@id", vec(9))

            comando.ExecuteNonQuery()
            conexion.Close()
            Me.Close()
        Catch ex As Exception
            conexion.Close()
        End Try

    End Sub

    Function validar() As Integer
        If Trim(folio.Text).Length < 1 Then
            MsgBox("El folio no puede ser vacio.", MsgBoxStyle.Information, "Validando Datos")
            Return 0
            Exit Function
        End If

        If Trim(claveprov.Text).Length < 1 Then
            MsgBox("La clave de proveedor no puede ser vacio", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
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
        tablaotros.consultar("select * from otrosconceptos order by id")
        tablaotros.Gridfactura.Columns("ID").Visible = False
    End Sub

    Private Sub facturasregistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Top = 150
        Left = 200
        Principal.Enabled = False
        If accion = "editar" Then
            folio.Text = vec(0)
            cia.Text = vec(2)
            origen.Text = vec(1)
            claveprov.Text = vec(3)
            proveedor.Text = vec(4)
            fecharecibo.Value = vec(5)
            asunto.Text = vec(6)
            reviso.Text = vec(7)
            Respuesta.Text = vec(8)
        End If

    End Sub

    Private Sub importe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles claveprov.KeyPress, folio.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub facturasregistro_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub


End Class