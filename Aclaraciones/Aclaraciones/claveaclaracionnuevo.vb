Imports MySql.Data.MySqlClient
Public Class claveaclaracionnuevo

    Private Sub claveaclaracionnuevo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub claveaclaracionnuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        varconexion()
        If accion = "nuevo" Then
            Combostatus.Text = "PROCEDENTE"
            TextBox3.Enabled = True
        Else
            Combostatus.Text = vec(0)
            TextBox2.Text = vec(1)
            TextBox3.Text = vec(2)
            TextBox3.Enabled = False
            TextBox4.Text = vec(3)
            TextBox5.Text = vec(4)
            TextBox6.Text = vec(5)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox3.Text).Length < 1 Then
            MsgBox("El campo Clave es Un dato Indispensable no puede ser Vacio", MsgBoxStyle.Exclamation, "Validando")
            Exit Sub
        End If


        If accion = "nuevo" Then
            Try
                conexion.Open()
                Dim agrega As String = "insert into clavesaclaracion values(@v1,@v2,@v3,@v4,@v5,@v6)"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@v1", Combostatus.Text)
                comando.Parameters.AddWithValue("@v2", Trim(TextBox2.Text))
                comando.Parameters.AddWithValue("@v3", Trim(TextBox3.Text))
                comando.Parameters.AddWithValue("@v4", Trim(TextBox4.Text))
                comando.Parameters.AddWithValue("@v5", Trim(TextBox5.Text))
                comando.Parameters.AddWithValue("@v6", Trim(TextBox6.Text))
                comando.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Registrado con Exito :)", MsgBoxStyle.Information, "Registro Guardado")
            Catch ex As Exception
                conexion.Close()
                MsgBox("La clave de Aclaración  " & TextBox3.Text & " ya Esta Registrada", MsgBoxStyle.Information, "No se Agrego :(")
                Exit Sub
            End Try

        Else
            'SE ESTA EDITANDO EL VALOR
            Try
                conexion.Open()
                Dim agrega As String = "UPDATE clavesaclaracion SET tipo=@v1,area=@v2,concepto=@v4,descripcion=@v5,datoscancelacion=@v6 where clave=@v3"
                Dim comando As New MySqlCommand(agrega, conexion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@v1", Combostatus.Text)
                comando.Parameters.AddWithValue("@v2", Trim(TextBox2.Text))
                comando.Parameters.AddWithValue("@v3", Trim(TextBox3.Text))
                comando.Parameters.AddWithValue("@v4", Trim(TextBox4.Text))
                comando.Parameters.AddWithValue("@v5", Trim(TextBox5.Text))
                comando.Parameters.AddWithValue("@v6", Trim(TextBox6.Text))
                comando.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Editado con Exito", MsgBoxStyle.Information, "Edicion Correcta :)")
            Catch ex As Exception
                conexion.Close()
                MsgBox("La clave de Aclaración  " & TextBox3.Text & " ya Esta Registrada", MsgBoxStyle.Information, "No se Agrego :(")
                Exit Sub
            End Try

        End If
        Claves_aclaracion.gridtabla.Rows.Clear()
        Claves_aclaracion.consultar("Select * from clavesaclaracion where tipo='" & Claves_aclaracion.ComboBox1.Text & "' order by tipo")
        Me.Close()
    End Sub
End Class