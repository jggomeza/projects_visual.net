Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable("tabla")

        dt.Columns.Add("Código")
        dt.Columns.Add("Descripción")

        Dim dr As DataRow

        dr = dt.NewRow()

        dr("Código") = 0
        dr("Descripción") = "Masculino"
        dt.Rows.Add(dr)

        dr = dt.NewRow()

        dr("Código") = 1
        dr("Descripción") = "Femenino"
        dt.Rows.Add(dr)

        cmbGenero.DataSource = dt
        cmbGenero.ValueMember = "Código"
        cmbGenero.DisplayMember = "Descripción"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(cmbGenero.SelectedValue.ToString)
    End Sub
End Class
