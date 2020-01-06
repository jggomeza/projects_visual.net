Public Class Form1

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim rock, pop, clasica, reggaeton, otros As Boolean

        If Me.checkRock.Checked = True Then
            rock = True
        Else
            rock = False
        End If
        '''''''''''''''''''''''''''''''''''''''''''''
        If Me.checkPop.Checked = True Then
            pop = True
        Else
            pop = False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''
        If Me.checkClasica.Checked = True Then
            clasica = True
        Else
            clasica = False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''
        If Me.checkReggaeton.Checked = True Then
            reggaeton = True
        Else
            reggaeton = False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''
        If Me.checkOtros.Checked = True Then
            otros = True
        Else
            otros = False
        End If

        If (rock = True) Then
            MsgBox("ROCK", MsgBoxStyle.Information, "Género de musica que te gusta")
        End If

        If (pop = True) Then
            MsgBox("POP", MsgBoxStyle.Information, "Género de musica que te gusta")
        End If

        If (clasica = True) Then
            MsgBox("CLASICA", MsgBoxStyle.Information, "Género de musica que te gusta")
        End If

        If (reggaeton = True) Then
            MsgBox("REGGAETON", MsgBoxStyle.Information, "Género de musica que te gusta")
        End If

        If (otros = True) Then
            MsgBox("OTROS", MsgBoxStyle.Information, "Género de musica que te gusta")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
