Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rt, g, h, da, hra, pf As Double
        rt = TextBox1.Text
        h = TextBox2.Text
        g = h * rt
        da = g * 0.1
        hra = g * 0.2
        pf = g * 0.1
        MsgBox("Rate:" & rt & vbCrLf + "Hours: " & h & vbCrLf + "Gross Salary: " & g & vbCrLf + "DA(10%): " & da & vbCrLf + "HRA(20%): " & hra & vbCrLf + "PF(10%): " & pf & vbCrLf + "NET SALARY: " & g + da + hra - pf & vbCrLf)
    End Sub
End Class
