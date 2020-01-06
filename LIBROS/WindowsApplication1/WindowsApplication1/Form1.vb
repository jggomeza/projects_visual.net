Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Delete Then
            'Borrar las palabras seleccionadas del listbox
            Dim i As Integer
            '
            With ListBox1
                For i = .SelectedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.SelectedItems.Item(i))
                Next
            End With
        End If

        'If e.KeyCode = Keys.Delete Then ' Esto borra un solo items
        '    With ListBox1
        '        .Items.Remove(.SelectedItem)
        '    End With
        'End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Cuando pulsamos en un elemento de la lista...
        With ListBox1
            TextBox1.Text = .GetItemText(.SelectedItem)
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To 10 Step 1
            ListBox1.Items.Add(i.ToString)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
