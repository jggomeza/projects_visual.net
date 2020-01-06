Public Class FrmVentaAutos

    ' temporizador por código
    Private oTiempo As Timer
    ' esta variable la utilizaremos para intercambiar
    ' los colores de fondo de los TextBox
    Private bIntercambio As Boolean
    '....
    '....
    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        Dim i As Integer
        For i = 1 To 200
            Panel1.Size = New Size(i, Me.Height - 38)
        Next
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Dim i As Integer
        For i = 200 To 1 Step -1
            Panel1.Size = New Size(i, Me.Height - 38)
        Next
    End Sub

    Private Sub btnTraspasar_Click(sender As Object, e As EventArgs) Handles btnTraspasar.Click
        ' iniciar el temporizador
        Me.tmrTemporizador.Start()
    End Sub

    Private Sub tmrTemporizador_Tick(sender As Object, e As EventArgs) Handles tmrTemporizador.Tick
        ' quitamos una letra del TextBox de origen...
        Dim sLetra As String

        sLetra = Me.txtOrigen.Text.Substring(0, 1)
        Me.txtOrigen.Text = Me.txtOrigen.Text.Remove(0, 1)

        ' ...y lo pasamos al TextBox de destino
        Me.txtDestino.Text &= sLetra

        ' cuando se haya traspaso todo el texto
        ' detener el temporizador
        If Me.txtOrigen.Text.Length = 0 Then
            Me.tmrTemporizador.Stop()
            MessageBox.Show("Traspaso finalizado")
        End If
    End Sub

    Private Sub chkActivar_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivar.CheckedChanged
        ' cuando marquemos el CheckBox...
        If Me.chkActivar.Checked Then
            ' creamos el temporizador
            oTiempo = New Timer()
            oTiempo.Interval = 1000 ' se ejecutará cada segundo
            ' le asignamos un manipulador para el evento Tick
            AddHandler oTiempo.Tick, AddressOf CambioDeColor
            oTiempo.Start() ' arrancamos el temporizador
        Else
            ' cuando desmarquemos el CheckBox paramos el temporizador
            oTiempo.Stop()
            oTiempo = Nothing
        End If
    End Sub
    ' método manipulador del evento Tick del temporizador
    ' creado por código
    Private Sub CambioDeColor(ByVal sender As Object, ByVal e As EventArgs)
        ' según el estado de la variable bIntercambio
        ' cada vez que se ejecute este método, se
        ' intercambiarán los colores de fondo de los TextBox
        bIntercambio = Not bIntercambio
        If bIntercambio Then
            Me.txtOrigen.BackColor = Color.Aquamarine
            Me.txtDestino.BackColor = Color.LightSteelBlue
        Else
            Me.txtOrigen.BackColor = Color.LightSteelBlue
            Me.txtDestino.BackColor = Color.Aquamarine
        End If
    End Sub
End Class