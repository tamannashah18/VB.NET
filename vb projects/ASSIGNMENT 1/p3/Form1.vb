Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = TextBox1.Text
        If s = "a" Or s = "e" Or s = "i" Or s = "o" Or s = "u" Or s = "A" Or s = "I" Or s = "E" Or s = "O" Or s = "U" Then
            MsgBox("Vowel")
        Else
            MsgBox("Consonant")
        End If

    End Sub
End Class
