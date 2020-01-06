Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resul As Boolean

        resul = (1 = 1) And (2 = 2)
        MsgBox(resul & " de and")

        resul = (1 = 1) And (2 = 1)
        MsgBox(resul & " de and")

        resul = (2 = 1) And (2 = 2)
        MsgBox(resul & " de and")

        resul = (1 = 2) And (3 = 2)
        MsgBox(resul & " de and")
        '----------------------------------------------------

        resul = (1 = 1) Or (2 = 2)
        MsgBox(resul & " de or")

        resul = (1 = 1) Or (2 = 1)
        MsgBox(resul & " de or")

        resul = (2 = 1) Or (2 = 2)
        MsgBox(resul & " de or")

        resul = (1 = 2) or (3 = 2)
        MsgBox(resul & " de or")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        resul = Not ((1 = 1) Or (2 = 2))
        MsgBox(resul & " de not")

        resul = Not ((1 = 1) Or (2 = 1))
        MsgBox(resul & " de not")

        resul = Not ((2 = 1) Or (2 = 2))
        MsgBox(resul & " de not")

        resul = Not ((1 = 2) Or (3 = 2))
        MsgBox(resul & " de not")

        Me.Close()
    End Sub
End Class
