Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comparacion As Integer

        comparacion = StrComp("Texto 1", "Texto 2")
        MsgBox(comparacion.ToString)

        comparacion = StrComp("Texto 1", "Texto 1")
        MsgBox(comparacion.ToString)

        comparacion = StrComp("Texto 3", "Texto 2")
        MsgBox(comparacion.ToString)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String
        Dim verifica As Boolean

        cadena = "Código facilito"

        verifica = cadena.Contains("facilito")

        If verifica = True Then
            MsgBox("La cadena contiene la palabra facilito")
        Else
            MsgBox("La cadena no contiene la palabra facilito")
        End If
    End Sub
End Class
