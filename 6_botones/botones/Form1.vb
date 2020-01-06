Public Class Form1

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim num1, num2, suma As Integer

        num1 = Val(TxtNum1.Text)
        num2 = TxtNum2.Text

        suma = num1 + num2
        MsgBox(suma)

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class
