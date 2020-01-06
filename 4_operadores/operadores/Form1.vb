Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, resp As Integer
        Dim respd As Double
        num1 = 2
        num2 = 5

        resp = num1 + num2
        MsgBox("La suma de " & num1 & " + " & num2 & " es " & resp)

        resp = num1 - num2
        MsgBox("La resta de " & num1 & " - " & num2 & " es " & resp)

        resp = num1 * num2
        MsgBox("La suma de " & num1 & " * " & num2 & " es " & resp)

        respd = num1 / num2
        MsgBox("La suma de " & num1 & " / " & num2 & " es " & respd)

        resp = num1 Mod num2
        MsgBox("El modulo de " & num1 & " mod " & num2 & " es " & resp)

    End Sub
End Class
