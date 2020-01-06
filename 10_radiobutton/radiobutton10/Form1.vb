Public Class Form1

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim num1, num2 As Integer
        Dim result As Double

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        If (radioSumar.Checked = True) Then
            result = num1 + num2
        ElseIf (radioRestar.Checked = True) Then
            result = num1 - num2
        ElseIf (radioMultiplicar.Checked = True) Then
            result = num1 * num2
        Else
            result = num1 / num2
        End If

        MsgBox("La operacion tiene como resultado " + result.ToString)


        

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioDividir.Checked = True
    End Sub
End Class
