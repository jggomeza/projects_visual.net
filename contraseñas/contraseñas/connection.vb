Module connection
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=contraseña.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public sql As String
    Public dataReader As OleDb.OleDbDataReader
    Public errorDB As String


    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("Conexión exitosa", MsgBoxStyle.Exclamation, "Mensaje")
        Catch ex As Exception
            'MsgBox(ex.ToString)
            errorDB = ex.ToString

            If errorDB.Contains("0x80004005") Then
                MsgBox("La base de datos no existe", MsgBoxStyle.Critical, "Aviso")
            End If

        End Try
    End Sub
End Module
