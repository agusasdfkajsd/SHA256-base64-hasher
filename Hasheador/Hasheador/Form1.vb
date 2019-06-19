Imports System.Text
Imports System.Security.Cryptography
Public Class Form1
    Private textEncode As New UnicodeEncoding()
    Private bytes() As Byte
    Private algoritmo As New SHA256Managed()
    Private hash() As Byte
    Private Sub Encript_Action(sender As Object, e As EventArgs) Handles encript.Click
        bytes = textEncode.GetBytes(input.Text)
        hash = algoritmo.ComputeHash(bytes)
        output.Text = Convert.ToBase64String(hash)
    End Sub
End Class
