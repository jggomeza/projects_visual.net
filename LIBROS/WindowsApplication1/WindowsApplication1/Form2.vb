Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sNombre As String
        sNombre = "coche"
        MessageBox.Show(CStr(sNombre.Length), Application.ProductName()) ' devuelve 5
        MessageBox.Show(sNombre.ToUpper(), Application.ProductName()) ' devuelve COCHE

    End Sub
End Class