Public Class frmCrearContraseña

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, btnCancelar.Click
        End
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If (txtNuevaContraseña.Text = txtConfirmarContraseña.Text) Then
            conectarse()
            With cmd
                .Connection = conn
                .CommandType = CommandType.Text

                sql = "INSERT INTO CONTRASEÑA(CLAVE) VALUES('" & txtNuevaContraseña.Text & "')"
                .CommandText = sql
                Try
                    .ExecuteNonQuery()
                    MsgBox("La contraseña ha sido creada satisfactoriamente!", MsgBoxStyle.Information, "Mensaje")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End With
        Else
            MsgBox("Las contraseñas escritas no coinciden. Vuelva a escribir la nueva contraseña en los dos campos", MsgBoxStyle.Critical, "Panel de control de cuentas de usuarios")
            txtNuevaContraseña.Text = ""
            txtConfirmarContraseña.Text = ""
            txtNuevaContraseña.Focus()
        End If
    End Sub
End Class
