Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim disc, tot As Double
        disc = 0.1
        tot = TextBox1.Text + TextBox1.Text * disc
        MsgBox("AMOUNT = " + TextBox1.Text.ToString() & vbNewLine + "DISCOUNT= 10%" & vbNewLine + "TOTAL = " & tot)
    End Sub
End Class
