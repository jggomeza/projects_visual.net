Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub saludar() 'Esto es un procedimiento
        MsgBox("Soy el procedimiento para saludar", MsgBoxStyle.Exclamation, "Mensaje")
    End Sub

    Function retosnaSaludo() 'Esto es una función
        Dim saludo As String

        saludo = "Hola soy una función para saludar!"

        Return (saludo)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hola As String

        hola = retosnaSaludo()

        MsgBox(hola, MsgBoxStyle.Exclamation, "Mensaje")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saludar()
    End Sub
End Class
