Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0

        'Ciclo Do Loop While----------------------------------------------------
        Do
            MsgBox("Ciclo Do = " + i.ToString)
            i += 1
        Loop While (i < 3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = 0

        'Ciclo Do While Loop---------------------------------------------------
        Do While (i < 3)
            MsgBox("Ciclo Do While = " + i.ToString)
            i += 1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = 0

        'Ciclo While only-------------------------------------------------------
        While (i < 3)
            MsgBox("Ciclo While = " + i.ToString)
            i += 1
        End While
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim array(5) As Integer
        Dim i As Integer = 0

        Do While (i < 5)
            array(i) = i
            i += 1
        Loop

        i = 0
        While (i < 5)
            MsgBox("Array(" + i.ToString + " ) = " + array(i).ToString)
            i += 1
        End While
    End Sub
End Class
