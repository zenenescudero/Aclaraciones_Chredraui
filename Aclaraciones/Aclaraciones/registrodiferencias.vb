Imports MySql.Data.MySqlClient

Public Class registrodiferencias
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combostatus.SelectedIndexChanged

        Comboclave.Text = ""

        If Combostatus.Text = "Selecciona" Then
            MsgBox("Deves Rellenar el campo Status", MsgBoxStyle.Information, "campo vacio")
            Exit Sub
        End If
        opcionescombo(Comboclave, "select clave,concat(clave,' - ',concepto) from clavesaclaracion where tipo='" & Combostatus.Text & "'")
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            fecharespuesta.Enabled = True
        Else
            fecharespuesta.Enabled = False
        End If
    End Sub

    Public Sub registrar()

        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "call insertardiferencia(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@v20,@v21,@v22)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", folio.Text)
            comando.Parameters.AddWithValue("@v2", Trim(ortex.Text))
            comando.Parameters.AddWithValue("@v3", Trim(cia.Text))
            comando.Parameters.AddWithValue("@v4", Trim(origen.Text))
            comando.Parameters.AddWithValue("@v5", Trim(claveprov.Text))
            comando.Parameters.AddWithValue("@v6", Trim(proveedor.Text))
            comando.Parameters.AddWithValue("@v7", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v8", Trim(factura.Text))
            comando.Parameters.AddWithValue("@v9", fecharecifac.Value)
            comando.Parameters.AddWithValue("@v10", Trim(sucursal.Text))
            comando.Parameters.AddWithValue("@v11", Convert.ToDouble(diferencia.Text))

            If CheckBox2.Checked Then
                comando.Parameters.AddWithValue("@v12", fechaasig.Value)
            Else
                comando.Parameters.AddWithValue("@v12", 0)
            End If

            comando.Parameters.AddWithValue("@v13", Trim(reviso.Text))

            If CheckBox1.Checked Then
                comando.Parameters.AddWithValue("@v14", fecharespuesta.Value)
            Else
                comando.Parameters.AddWithValue("@v14", 0)
            End If

            comando.Parameters.AddWithValue("@v15", Combostatus.Text)
            comando.Parameters.AddWithValue("@v16", Comboclave.SelectedValue)
            comando.Parameters.AddWithValue("@v17", Trim(area.Text))
            comando.Parameters.AddWithValue("@v18", Trim(vistobueno.Text))
            comando.Parameters.AddWithValue("@v19", Trim(movimiento.Text))
            comando.Parameters.AddWithValue("@v20", Trim(concepto.Text))
            comando.Parameters.AddWithValue("@v21", Trim(autorizo.Text))
            comando.Parameters.AddWithValue("@v22", Trim(diasresp.Text))

            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Registrado Correctamente", MsgBoxStyle.Information, "Registro")
        Catch ex As Exception
            MsgBox("No se registro :( asegurate de que los datos sean validos, informa al administrador", MsgBoxStyle.Exclamation, "Informe de error")
            conexion.Close()
        End Try

    End Sub

    Public Sub editar()

        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "call editardiferencia(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@v20,@v21,@v22,@v23)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", Trim(folio.Text))
            comando.Parameters.AddWithValue("@v2", Trim(ortex.Text))
            comando.Parameters.AddWithValue("@v3", Trim(cia.Text))
            comando.Parameters.AddWithValue("@v4", Trim(origen.Text))
            comando.Parameters.AddWithValue("@v5", Trim(claveprov.Text))
            comando.Parameters.AddWithValue("@v6", Trim(proveedor.Text))
            comando.Parameters.AddWithValue("@v7", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v8", Trim(factura.Text))
            comando.Parameters.AddWithValue("@v9", fecharecifac.Value)
            comando.Parameters.AddWithValue("@v10", Trim(sucursal.Text))
            comando.Parameters.AddWithValue("@v11", Convert.ToDouble(diferencia.Text))
            If CheckBox2.Checked Then
                comando.Parameters.AddWithValue("@v12", fechaasig.Value)
            Else
                comando.Parameters.AddWithValue("@v12", 0)
            End If
            comando.Parameters.AddWithValue("@v13", Trim(reviso.Text))

            If CheckBox1.Checked Then
                comando.Parameters.AddWithValue("@v14", fecharespuesta.Value)
            Else
                comando.Parameters.AddWithValue("@v14", 0)
            End If
            comando.Parameters.AddWithValue("@v15", Combostatus.Text)
            comando.Parameters.AddWithValue("@v16", Comboclave.SelectedValue)
            comando.Parameters.AddWithValue("@v17", Trim(area.Text))
            comando.Parameters.AddWithValue("@v18", Trim(vistobueno.Text))
            comando.Parameters.AddWithValue("@v19", Trim(movimiento.Text))
            comando.Parameters.AddWithValue("@v20", Trim(concepto.Text))
            comando.Parameters.AddWithValue("@v21", vec(21))
            comando.Parameters.AddWithValue("@v22", Trim(autorizo.Text))
            comando.Parameters.AddWithValue("@v23", diasresp.Text)

            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Edicion Correcta :)", MsgBoxStyle.Information, "Editando Registro")
        Catch ex As Exception
            conexion.Close()
            MsgBox("No se edito :( consulta al administrador", MsgBoxStyle.Information, "Informe de Error")
        End Try

    End Sub

    Function validar() As Integer
        If Trim(folio.Text).Length < 1 Then
            MsgBox("El folio no puede ser vacio.", MsgBoxStyle.Information, "Validando Datos")
            Return 0
            Exit Function
        End If

        If Trim(Combostatus.Text).Length < 1 Or Combostatus.Text = "Selecciona" Then
            MsgBox("Deves elegir algun Status", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End If

        If Trim(claveprov.Text).Length < 1 Then
            MsgBox("La clave de proveedor no puede ser vacio", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End If

        If Trim(factura.Text).Length < 1 Then
            MsgBox("El campo Factura no puede ser vacio", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End If
        Try
            If Trim(diferencia.Text).Length < 1 Or Convert.ToDouble(diferencia.Text) < 0.1 Then
                MsgBox("El valor de importe no puede ser cero", MsgBoxStyle.Information, "Validando datos")
                Return 0
                Exit Function
            End If
        Catch ex As Exception
            diferencia.Text = "0"
            MsgBox("El valor de importe no puede ser cero", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End Try

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
        tabladiferencias.consultaformada()
        tabladiferencias.Gridfactura.Columns("ID").Visible = False
        Me.Close()

    End Sub

    Private Sub facturasregistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Top = 150
        Left = 200
        Principal.Enabled = False
        If accion = "nuevo" Then
            Combostatus.Text = "PENDIENTE"
        End If
        If accion = "editar" Then
            diasresp.Text = vec(22)
            folio.Text = vec(0)
            ortex.Text = vec(1)
            cia.Text = vec(2)
            origen.Text = vec(3)
            claveprov.Text = vec(4)
            proveedor.Text = vec(5)
            fecharecibo.Value = vec(6)
            factura.Text = vec(7)
            fecharecifac.Value = vec(8)
            sucursal.Text = vec(9)
            diferencia.Text = Format(Convert.ToDouble(vec(10)), "###,###,###.#0")
            If vec(11).Length < 1 Then
                CheckBox2.Checked = False
            Else
                CheckBox2.Checked = True
                fechaasig.Enabled = True
                fechaasig.Value = vec(11)
            End If
            reviso.Text = vec(12)
            If vec(13).Length < 1 Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
                fecharespuesta.Enabled = True
                fecharespuesta.Value = vec(13)
            End If
            Combostatus.Text = vec(14)
            Comboclave.SelectedValue = vec(15)
            area.Text = vec(16)
            vistobueno.Text = vec(17)
            movimiento.Text = vec(18)
            concepto.Text = vec(19)
            autorizo.Text = vec(20)


        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            fechaasig.Enabled = True
        Else
            fechaasig.Enabled = False
        End If
    End Sub

    Private Sub importe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles diferencia.KeyPress, claveprov.KeyPress, folio.KeyPress, cia.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub facturasregistro_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub

    Private Sub fecharespuesta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecharespuesta.ValueChanged
        Try
            diasresp.Text = DateDiff("D", fecharecibo.Value, fecharespuesta.Value)
        Catch ex As Exception

        End Try
    End Sub
End Class