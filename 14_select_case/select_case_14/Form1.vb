Public Class Form1
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim opc As String = ""

        validar_entradas()
        If (erroneos = True) Then
            erroneos = False
            Exit Sub
        End If

        If (radioSumar.Checked = True) Then
            opc = "Sumar"
        End If

        If (radioRestar.Checked = True) Then
            opc = "Restar"
        End If

        If (radioMultiplicar.Checked = True) Then
            opc = "Multiplicar"
        End If

        If (radioDividir.Checked = True) Then
            opc = "Dividir"
        End If

        Select Case opc
            Case "Sumar"
                txtResul.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
            Case "Restar"
                txtResul.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
            Case "Multiplicar"
                txtResul.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
            Case "Dividir"
                txtResul.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
            Case Else
                MsgBox("No ha seleccionado ninguna operación, por favor seleccione una opcción!", MsgBoxStyle.Critical, "Aviso")
        End Select
    End Sub

    Function validar_entradas() 'Función para validar valores numéricos
        If Not (IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text)) Then
            MsgBox("Debe introducir valores númericos", MsgBoxStyle.Critical, "Aviso")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtNum1.Focus()
            erroneos = True
        End If
    End Function
End Class
