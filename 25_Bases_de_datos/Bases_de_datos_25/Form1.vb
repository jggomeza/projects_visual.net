Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        'llenaGrid()
    End Sub

    'Private Sub llenaGrid()
    '    Dim ds As New DataSet
    '    Dim dt As New DataTable
    '    Dim strSql As String = "SELECT idPersona, nombres, apellidos, correo, direccion from persona"
    '    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

    '    ds.Tables.Add("tabla") 'Añadiendo nueva tabla
    '    adp.Fill(ds.Tables("tabla")) 'Llenar la tabla con los datos

    '    Me.DataGridView1.DataSource = ds.Tables("tabla")
    '    Me.DataGridView1.Columns(0).HeaderText = "Identificación"
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    conn.Close()
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    MsgBox(conn.State.ToString)
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    conectarse()
    '    'If conn.State.ToString = "Open" Then
    '    'conn.Close()
    '    ''End If
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    Dim id As String

    '    id = TextBox1.Text

    '    consultar(id)
    'End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If (Me.txtIdentificacion.Text = "") Then
            MsgBox("Debe llanar el campo identificación", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion.Select()
            Exit Sub
        Else
            Dim identificacion As Integer = CInt(Me.txtIdentificacion.Text)
            Dim nombres As String = Me.txtNombres.Text
            Dim apellidos As String = Me.txtApellidos.Text
            Dim correo As String = Me.txtCorreo.Text
            Dim direccion As String = Me.txtDireccion.Text

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO PERSONA VALUES(" & identificacion & ""
            sql += ",'" & nombres & "','" & apellidos & "','" & correo & "','" & direccion & "')"

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("El registro ha sido almacenado correctamente!", MsgBoxStyle.Information, "Mensaje")
            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("El registro no ha sido realizado ya que el mismo ya existe en la base de datos", MsgBoxStyle.Critical, "Aviso")
                Else
                    MsgBox(ex.ToString)
                End If
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (Me.txtIdentificacion2.Text = "") Then
            MsgBox("Debe llanar el campo identificación", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion2.Select()
            Exit Sub
        Else
            Dim identificacion As Integer = CInt(Me.txtIdentificacion2.Text)
            Dim nombres As String = Me.txtNombres2.Text
            Dim apellidos As String = Me.txtApellidos2.Text
            Dim correo As String = Me.txtCorreo2.Text
            Dim direccion As String = Me.txtDireccion2.Text

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE PERSONA SET"
            sql += " NOMBRES='" & nombres & "',"
            sql += " APELLIDOS='" & apellidos & "',"
            sql += " CORREO='" & correo & "',"
            sql += " DIRECCION='" & direccion & "'"
            sql += " WHERE IDPERSONA=" & identificacion & ""

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()

                Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtDireccion2.Text = ""
                Me.btnActualizar.Enabled = False
                MsgBox("El registro ha sido actualizado correctamente!", MsgBoxStyle.Information, "Mensaje")
            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("El registro no ha sido actualizado ya que el mismo ya existe en la base de datos", MsgBoxStyle.Critical, "Aviso")
                Else
                    MsgBox(ex.ToString)
                End If
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.txtIdentificacion3.Text = "") Then
            MsgBox("Debe llanar el campo identificación", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion3.Select()
            Exit Sub
        Else
            Dim identificacion As Integer = CInt(Me.txtIdentificacion3.Text)

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM PERSONA WHERE IDPERSONA=" & identificacion & ""

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()

                Me.txtIdentificacion3.Text = ""
                Me.txtNombres3.Text = ""
                Me.txtApellidos3.Text = ""
                Me.txtCorreo3.Text = ""
                Me.txtDireccion3.Text = ""
                MsgBox("El registro ha sido eliminado correctamente!", MsgBoxStyle.Information, "Mensaje")
            Catch ex As Exception
                'If ex.ToString.Contains("valores duplicados") Then
                '    MsgBox("El registro no ha sido actualizado ya que el mismo ya existe en la base de datos", MsgBoxStyle.Critical, "Aviso")
                'Else
                '    MsgBox(ex.ToString)
                'End If
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtIdentificacion2_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion2.Leave

        If Me.txtIdentificacion2.Text <> "" Then
            consultarPersona(Me.txtIdentificacion2.Text)

            If dataReader.Read Then 'Tiene registros
                Me.txtNombres2.Text = dataReader(1).ToString
                Me.txtApellidos2.Text = dataReader(2).ToString
                Me.txtCorreo2.Text = dataReader(3).ToString
                Me.txtDireccion2.Text = dataReader(4).ToString

                Me.btnActualizar.Enabled = True
                dataReader.Close()
            Else
                Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtDireccion2.Text = ""

                MsgBox("No se encontró el registro en la base de datos")
                Me.btnActualizar.Enabled = False
                dataReader.Close()
            End If
        End If
    End Sub

    Private Sub txtIdentificacion3_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion3.Leave
        If Me.txtIdentificacion3.Text <> "" Then
            consultarPersona(Me.txtIdentificacion3.Text)

            If dataReader.Read Then 'Tiene registros
                Me.txtNombres3.Text = dataReader(1).ToString
                Me.txtApellidos3.Text = dataReader(2).ToString
                Me.txtCorreo3.Text = dataReader(3).ToString
                Me.txtDireccion3.Text = dataReader(4).ToString

                Me.btnEliminar.Enabled = True
                dataReader.Close()
            Else
                Me.txtIdentificacion3.Text = ""
                Me.txtNombres3.Text = ""
                Me.txtApellidos3.Text = ""
                Me.txtCorreo3.Text = ""
                Me.txtDireccion3.Text = ""

                MsgBox("No se encontró el registro en la base de datos")
                Me.btnEliminar.Enabled = False
                dataReader.Close()
            End If
        End If
    End Sub
End Class
