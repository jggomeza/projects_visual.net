Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub porValor(ByVal variable As String) 'Procedimiento que recibe parametros por valor
        MsgBox(variable)

        variable = "Variable cambiada"

        MsgBox(variable)

    End Sub

    Private Sub porReferencia(ByRef variable As String) 'Procedimiento que recibe parametros por valor
        MsgBox(variable)

        variable = "Variable cambiada"

        MsgBox(variable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var As String

        var = "Variable sin cambiar"

        porValor(var)

        MsgBox(var)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim var As String

        var = "Variable sin cambiar"

        porReferencia(var)

        MsgBox(var)
    End Sub
End Class
