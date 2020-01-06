Module funcionesdb
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=codigoFacilito.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dataReader As OleDb.OleDbDataReader
    Public sql As String

    Public Sub conectarse()
        Try
            conn.Open()
            MsgBox("La conexión ha la base de datos se ha realizado exitosamente!", MsgBoxStyle.Exclamation, "Mensaje")
        Catch ex As Exception
            'MsgBox(ex.ToString)

            If ex.ToString.Contains("No se pudo encontrar el archivo") Then
                MsgBox("La base de datos no existe", MsgBoxStyle.Critical, "Aviso")
            End If
        End Try
    End Sub

    Public Sub consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If identificacion <> "" Then
            cmd.CommandText = "SELECT idPersona, nombres, apellidos, correo, direccion from persona where idPersona=" + identificacion
        Else
            cmd.CommandText = "SELECT idPersona, nombres, apellidos, correo, direccion from persona"
        End If

        Try
            dataReader = cmd.ExecuteReader() 'Ejecutar la consulta

            If dataReader.HasRows Then 'Si el Data Reader trajo registros 
                While dataReader.Read()
                    MsgBox(dataReader(1).ToString + " " + dataReader(2).ToString + " " + dataReader(3).ToString + " " + dataReader(4).ToString, MsgBoxStyle.Information, dataReader(0).ToString)
                End While
            Else
                MsgBox("No existen registros para la consulta!")
            End If

            dataReader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultarPersona(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT idPersona, nombres, apellidos, correo, direccion from persona where idPersona=" + identificacion

        Try
            dataReader = cmd.ExecuteReader() 'Ejecutar la consulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module
