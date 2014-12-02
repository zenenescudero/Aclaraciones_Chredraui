Imports MySql.Data.MySqlClient

Public Class facturasregistro
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
            Dim agrega As String = "call insertarfactura(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@V20)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", folio.Text)
            comando.Parameters.AddWithValue("@v2", ortex.Text)
            comando.Parameters.AddWithValue("@v3", cia.Text)
            comando.Parameters.AddWithValue("@v4", origen.Text)
            comando.Parameters.AddWithValue("@v5", claveprov.Text)
            comando.Parameters.AddWithValue("@v6", proveedor.Text)
            comando.Parameters.AddWithValue("@v7", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v8", factura.Text)
            comando.Parameters.AddWithValue("@v9", refactura.Text)
            comando.Parameters.AddWithValue("@v10", fecharecifac.Value)
            comando.Parameters.AddWithValue("@v11", sucursal.Text)
            comando.Parameters.AddWithValue("@v12", importe.Text)
            If CheckBox2.Checked Then
                comando.Parameters.AddWithValue("@v13", fechaasig.Value)
            Else
                comando.Parameters.AddWithValue("@v13", 0)
            End If
            comando.Parameters.AddWithValue("@v14", reviso.Text)

            If CheckBox1.Checked Then
                comando.Parameters.AddWithValue("@v15", fecharespuesta.Value)
            Else
                comando.Parameters.AddWithValue("@v15", 0)
            End If
            comando.Parameters.AddWithValue("@v16", Combostatus.Text)
            If Combostatus.Text = "Pendiente" Then
                comando.Parameters.AddWithValue("@v17", "")
            Else
                comando.Parameters.AddWithValue("@v17", Comboclave.SelectedValue)

            End If
             comando.Parameters.AddWithValue("@v18", area.Text)
            comando.Parameters.AddWithValue("@v19", vistobueno.Text)
            comando.Parameters.AddWithValue("@v20", diasresp.Text)

            comando.ExecuteNonQuery()
            ' proceso.Value = proceso.Value + 1
            conexion.Close()
            Me.Close()
            'Label1.Text = Convert.ToString((x + 1 / gridtabla.RowCount) * 100)
        Catch ex As Exception
            conexion.Close()
        End Try

    End Sub

    Public Sub editar()

        Try
            varconexion()
            conexion.Open()
            Dim agrega As String = "call editarfactura(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@v20,@v21)"
            Dim comando As New MySqlCommand(agrega, conexion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@v1", folio.Text)
            comando.Parameters.AddWithValue("@v2", ortex.Text)
            comando.Parameters.AddWithValue("@v3", cia.Text)
            comando.Parameters.AddWithValue("@v4", origen.Text)
            comando.Parameters.AddWithValue("@v5", claveprov.Text)
            comando.Parameters.AddWithValue("@v6", proveedor.Text)
            comando.Parameters.AddWithValue("@v7", fecharecibo.Value)
            comando.Parameters.AddWithValue("@v8", factura.Text)
            comando.Parameters.AddWithValue("@v9", refactura.Text)
            comando.Parameters.AddWithValue("@v10", fecharecifac.Value)
            comando.Parameters.AddWithValue("@v11", sucursal.Text)
            comando.Parameters.AddWithValue("@v12", Convert.ToDouble(importe.Text))
            If CheckBox2.Checked Then
                comando.Parameters.AddWithValue("@v13", fechaasig.Value)
               
            Else
                comando.Parameters.AddWithValue("@v13", 0)
            End If
            comando.Parameters.AddWithValue("@v14", reviso.Text)

            If CheckBox1.Checked Then
                comando.Parameters.AddWithValue("@v15", fecharespuesta.Value)
            Else
                comando.Parameters.AddWithValue("@v15", 0)
            End If
            comando.Parameters.AddWithValue("@v16", Combostatus.Text)
            If Combostatus.Text = "PENDIENTE" Then
                comando.Parameters.AddWithValue("@v17", "")
            Else
                comando.Parameters.AddWithValue("@v17", Comboclave.SelectedValue)
            End If
            comando.Parameters.AddWithValue("@v18", area.Text)
            comando.Parameters.AddWithValue("@v19", vistobueno.Text)
            comando.Parameters.AddWithValue("@v20", vec(19))
            comando.Parameters.AddWithValue("@v21", diasresp.Text)

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

        If CheckBox1.Checked Then
            If Trim(Combostatus.Text).Length < 1 Or Combostatus.Text = "Selecciona" Or Combostatus.Text = "PENDIENTE" Then
                MsgBox("Deves elegir algun Status Diferente a PENDIENTE", MsgBoxStyle.Information, "Validando datos")
                Return 0
                Exit Function
            End If
            If CheckBox2.Checked Then

            Else
                MsgBox("No tienes Fecha de Asignacion", MsgBoxStyle.Information, "Validando Datos")
                Return 0
                Exit Function
            End If
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
            If Trim(importe.Text).Length < 1 Or Convert.ToDouble(importe.Text) < 0.1 Then
                MsgBox("El valor de importe no puede ser cero", MsgBoxStyle.Information, "Validando datos")
                Return 0
                Exit Function
            End If
        Catch ex As Exception
            importe.Text = "0"
            MsgBox("El valor de importe no puede ser cero", MsgBoxStyle.Information, "Validando datos")
            Return 0
            Exit Function
        End Try

        Try
            If CheckBox2.Checked Then
                If Trim(reviso.Text).Length < 1 Then
                    MsgBox("No estas asignando quien revisara ", MsgBoxStyle.Information, "Validando Datos")
                    Return 0
                    Exit Function
                End If

                If fechaasig.Value > fecharespuesta.Value Then
                    MsgBox("la fecha de asignacion no puede ser mayor ala fecha respuesta :(", MsgBoxStyle.Exclamation, "Validando Datos")
                    Return 0
                    Exit Function
                End If


            End If

        Catch ex As Exception
            MsgBox("Verifica el valor de las fechas", MsgBoxStyle.Information, "Validando Datos")
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
        tablafacturas.consultaformada()
        tablafacturas.Gridfactura.Columns("ID").Visible = False

    End Sub

    Private Sub facturasregistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Top = 150
        Left = 200


          tablafacturas.Enabled = False
        If accion = "nuevo" Then
            Combostatus.Text = "PENDIENTE"
        End If
        If accion = "editar" Then
            folio.Text = vec(0)
            ortex.Text = vec(1)
            cia.Text = vec(2)
            origen.Text = vec(3)
            claveprov.Text = vec(4)
            proveedor.Text = vec(5)
            fecharecibo.Value = vec(6)
            factura.Text = vec(7)
            refactura.Text = vec(8)
            fecharecifac.Value = vec(9)
            sucursal.Text = vec(10)
            importe.Text = Format(Convert.ToDouble(vec(11)), "###,###,###.#0")
            If vec(12).Length < 1 Then
                CheckBox2.Checked = False
            Else
                CheckBox2.Checked = True
                fechaasig.Enabled = True
                fechaasig.Value = vec(12)
            End If

            reviso.Text = vec(13)

            If vec(14).Length < 1 Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
                fecharespuesta.Enabled = True
                fecharespuesta.Value = vec(14)
            End If
            Combostatus.Text = vec(15)
            Comboclave.SelectedValue = vec(16)
            area.Text = vec(17)
            vistobueno.Text = vec(18)

        End If
      
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            fechaasig.Enabled = True
        Else
            fechaasig.Enabled = False
        End If
    End Sub

    Private Sub importe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles importe.KeyPress, claveprov.KeyPress, folio.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub fecharespuesta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecharespuesta.ValueChanged

        ' diasresp.Text = Convert.ToString(fecharespuesta.Text - fecharecibo.Text)
        Try
            diasresp.Text = DateDiff("D", fecharecibo.Value, fecharespuesta.Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub facturasregistro_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        tablafacturas.Enabled = True
    End Sub

    Private Sub factura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles factura.TextChanged
        union.Text = factura.Text & refactura.Text
    End Sub

    Private Sub refactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refactura.TextChanged
        union.Text = factura.Text & refactura.Text
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class