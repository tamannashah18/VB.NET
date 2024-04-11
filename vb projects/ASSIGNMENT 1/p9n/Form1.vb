Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim a, dec As Integer
    Dim res As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Binary" Then
            a = TextBox1.Text
            dec = Convert.ToInt32(a, 2)
            Label1.Text = "Decimal : " & dec & vbNewLine
            res = Convert.ToString(dec, 8)
            Label1.Text += "Octal : " & res & vbNewLine
            res = Convert.ToString(dec, 16)
            Label1.Text += "Hexadecimal : " & res & vbNewLine
        ElseIf ComboBox1.Text = "Octal" Then
            a = TextBox1.Text
            dec = Convert.ToInt32(a, 8)
            Label1.Text += "Decimal : " & dec & vbNewLine
            res = Convert.ToString(dec, 2)
            Label1.Text += "Binary : " & res & vbNewLine
            res = Convert.ToString(dec, 16)
            Label1.Text += "Hexadecimal : " & res & vbNewLine
        ElseIf ComboBox1.Text = "Decimal" Then
            a = TextBox1.Text
            dec = Convert.ToString(a, 2)
            Label1.Text = "Bimary : " & dec & vbNewLine
            res = Convert.ToString(a, 8)
            Label1.Text += "Octal : " & res & vbNewLine
            res = Convert.ToString(a, 16)
            Label1.Text = "Hexadecimal : " & res & vbNewLine
        ElseIf ComboBox1.Text = "Hexadecimal" Then
            a = TextBox1.Text
            dec = Convert.ToInt32(a, 16)
            Label1.Text = "Decimal : " & dec & vbNewLine
            res = Convert.ToString(dec, 8)
            Label1.Text += "Octal : " & res & vbNewLine
            res = Convert.ToString(dec, 10)
            Label1.Text += "Decimal : " & res & vbNewLine
        End If
    End Sub
End Class
