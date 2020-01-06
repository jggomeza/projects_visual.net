Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("insertar_usuario", conex)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = TextBox2.Text

            conex.Open()
            cmd.ExecuteNonQuery()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
