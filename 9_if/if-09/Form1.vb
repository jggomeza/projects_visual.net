Public Class Form1

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim num1, num2 As Integer

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If (num1 < num2) Then
            MsgBox(num1 & " < " & num2, MsgBoxStyle.Information, "Resultado")
        ElseIf (num1 = num2) Then
            MsgBox(num1 & " = " & num2, MsgBoxStyle.Information, "Resultado")
        Else
            MsgBox(num1 & " > " & num2, MsgBoxStyle.Information, "Resultado")
        End If

        If (txtfrase.Text.Contains("facilito")) Then
            MsgBox("Si la contiene!")
        End If


    End Sub
End Class
