Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT idPersona, nombres, apellidos, correo, direccion from persona"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

        ds.Tables.Add("tabla") 'Añadiendo nueva tabla
        adp.Fill(ds.Tables("tabla")) 'Llenar la tabla con los datos

        Me.DataGridView1.DataSource = ds.Tables("tabla")
        Me.DataGridView1.Columns(0).HeaderText = "Identificación"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(conn.State.ToString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conectarse()
        'If conn.State.ToString = "Open" Then
        'conn.Close()
        ''End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As String

        id = TextBox1.Text

        consultar(id)
    End Sub
End Class
