Imports System.IO

Public Class Origen_de_Datos

    Private Sub Origen_de_Datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Trim(TextBox1.Text).Length < 1 Or Trim(TextBox2.Text).Length < 1 Or Trim(TextBox3.Text).Length < 1 Or Trim(TextBox4.Text).Length < 1 Then
            MsgBox("Deves Rellenar todos los Campos", MsgBoxStyle.Exclamation, "Alerta")
            Exit Sub
        End If


        If MsgBox(" Estas seguro de cambiar" & Chr(13) & "La Información de Base de Datos" & Chr(13) & "Esto Podria Generar Errores.", vbOKCancel, "Confirmación") = vbOK Then
            Try

                File.WriteAllText("registro.txt", "")
                Dim crear As StreamWriter = File.AppendText("registro.txt")
                crear.WriteLine(TextBox1.Text)
                crear.WriteLine(TextBox2.Text)
                crear.WriteLine(TextBox4.Text)
                crear.WriteLine(TextBox3.Text)
                crear.Close()

                MsgBox("Origen De datos Regitrado", vbOKOnly, "Aclaraciones -- Configuración")
                datosdebase()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al registrar Orgien de datos", vbOKOnly, "Aclaraciones -- Configuración")
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class