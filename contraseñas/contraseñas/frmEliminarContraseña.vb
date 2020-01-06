Public Class frmEliminarContraseña

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conectarse()

        With cmd
            .Connection = conn
            .CommandType = CommandType.Text

            sql = "SELECT * FROM CONTRASEÑA WHERE(clave='" & txtEliminarContraseña.Text & "')"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            sql = "DELETE FROM CONTRASEÑA WHERE CLAVE='" & txtEliminarContraseña.Text & "'"

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("La contraseña ha sido eliminada satisfactoriamente!", MsgBoxStyle.Information, "Mensaje")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
    End Sub
End Class