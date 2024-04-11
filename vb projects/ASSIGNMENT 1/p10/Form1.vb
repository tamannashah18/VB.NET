Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Double
        If RadioButton1.Checked Then
            temp = (TextBox1.Text * 9 / 5) + 32
            Label2.Text = TextBox1.Text & " Degree C = " & temp & " Degree F"
        ElseIf RadioButton2.Checked Then
            temp = (TextBox1.Text - 32) * 5 / 9
            Label2.Text = TextBox1.Text & " Degree F = " & temp & " Degree C"
        Else
            MsgBox("CHOOSE RADIO BUTTON")
        End If
    End Sub
End Class
