Module Module1
    Sub Main()
        MsgBox("Este es el primer mensaje")

        MsgBox(suma(5, 6))
    End Sub

    Function suma(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim result As Integer

        result = x + y
        Return result
    End Function
End Module
