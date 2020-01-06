Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim array(10) As Integer 'Declaración de arreglo array
        Dim i As Integer 'contador de los ciclos del for

        For i = 0 To 9 'Ciclo 1, proceso de llenado del arreglo
            array(i) = 10 - i
        Next

        For i = 0 To 9 'Ciclo 2, proceso de impresion del arreglo
            MsgBox("array(" & i & ") = " & array(i), MsgBoxStyle.Information, "array(" & i & ") = " & array(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim j As Integer

        For i = 0 To 2
            MsgBox("Ciclo externo i = " + i.ToString, MsgBoxStyle.Information, "Ciclo externo i = " + i.ToString)

            For j = 0 To 3
                MsgBox("Ciclo interno j = " + j.ToString + " con i = " + i.ToString, MsgBoxStyle.Information, "Ciclo interno j = " + j.ToString + " con i = " + i.ToString)
            Next
        Next
    End Sub
End Class
