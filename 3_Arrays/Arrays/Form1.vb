Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim array(3) As String
        array(0) = "HOLA"
        array(1) = "CODIGO"
        array(2) = "FACILITO"
        MsgBox(array(0) + " " + array(1) + " " + array(2))
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim array2() As Integer

        array2 = New Integer() {1, 2, 3}

        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)

        ReDim Preserve array2(2)

        MsgBox(array2(0).ToString + " " + array2(1).ToString)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim matriz(,) As Integer '= {{1, 2, 3}, {4, 5, 6}}

        matriz = New Integer(,) {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1))
        '''''''''''''''''''''''''''''''''''''
        Dim matriz2(1, 2) As Integer
        matriz2(0, 0) = 1
        matriz2(0, 1) = 2
        matriz2(0, 2) = 3
        matriz2(1, 0) = 4
        matriz2(1, 1) = 5
        matriz2(1, 2) = 1

        MsgBox(matriz(1, 1))

        Me.Close()
    End Sub
End Class
