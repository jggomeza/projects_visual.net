﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resul As Boolean
        resul = TxtNum1.Text = TxtNum2.Text
        MsgBox(resul)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resul As Boolean
        resul = TxtNum1.Text > TxtNum2.Text
        MsgBox(resul)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resul As Boolean
        resul = TxtNum1.Text < TxtNum2.Text
        MsgBox(resul)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resul As Boolean
        resul = TxtNum1.Text >= TxtNum2.Text
        MsgBox(resul)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resul As Boolean
        resul = TxtNum1.Text <= TxtNum2.Text
        MsgBox(resul)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resul As Boolean
        resul = TxtNum1.Text <> TxtNum2.Text
        MsgBox(resul)
    End Sub
End Class
