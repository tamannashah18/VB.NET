Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p, q, r, s, u, v As Integer
        Dim per As Double
        p = TextBox1.Text
        q = TextBox2.Text
        r = TextBox3.Text
        s = TextBox4.Text
        u = TextBox5.Text
        v = p + q + r + s + u
        If (F_name.Text = "") Then
            MsgBox("Enter First Name")
            F_name.Focus()
        ElseIf (L_name.Text = "") Then
            MsgBox("Enter Last Name")
            L_name.Focus()
        ElseIf (ComboBox2.Text = "") Then
            MsgBox("Select Semester")
            ComboBox2.Focus()
        ElseIf (TextBox1.Text = "") Then
            MsgBox("Enter Marks 101")
            TextBox1.Focus()
        ElseIf (TextBox2.Text = "") Then
            MsgBox("Enter Marks 102")
            TextBox2.Focus()
        ElseIf (TextBox3.Text = "") Then
            MsgBox("Enter Marks 103")
            TextBox3.Focus()
        ElseIf (TextBox4.Text = "") Then
            MsgBox("Enter Marks 104")
            TextBox4.Focus()
        ElseIf (TextBox5.Text = "") Then
            MsgBox("Enter Marks 105")
            TextBox5.Focus()
        Else
            If v > 500 Then
                MsgBox("Enter Valid Marks (Out of 100)")
            Else
                per = v / 5
                If per > 80 Then
                    grade.Text = "Grade : A"
                ElseIf per > 70 Then
                    grade.Text = "Grade : B"
                ElseIf per > 60 Then
                    grade.Text = "Grade : C"
                ElseIf per > 50 Then
                    grade.Text = "Grade : D"
                ElseIf per > 33 Then
                    grade.Text = "Grade : E"
                Else
                    grade.Text = "Grade : FAIL"
                End If

            End If
        End If
        name1.Text = F_name.Text + L_name.Text & vbNewLine + "SEMESTER : " + ComboBox2.Text
        Marks.Text = "101 :" & p & vbNewLine + "102 :" & q & vbNewLine + "103 :" & r & vbNewLine + "104 :" & s & vbNewLine + "105 :" & u & vbNewLine
        percentage.Text = "Percentage/Average :" & per
        total.Text = "Total :" & v
    End Sub
End Class
