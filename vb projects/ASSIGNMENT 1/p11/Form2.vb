Public Class Form2
    Dim turn As Integer
    Dim p1, p2 As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Text = ""
        TextBox2.Enabled = True
        TextBox3.Text = ""
        TextBox3.Enabled = True
        TextBox4.Text = ""
        TextBox4.Enabled = True
        TextBox5.Text = ""
        TextBox5.Enabled = True
        TextBox6.Text = ""
        TextBox6.Enabled = True
        TextBox7.Text = ""
        TextBox7.Enabled = True
        TextBox8.Text = ""
        TextBox8.Enabled = True
        TextBox9.Text = ""
        TextBox9.Enabled = True

        turn = 1
        p1 = "X"
        p2 = "O"
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
        End If



    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox1.Text = p1
            TextBox1.Enabled = False

            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox1.Text = TextBox4.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If


        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox1.Text = p2
            TextBox1.Enabled = False

            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox1.Text = TextBox4.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox2.Text = p1
            TextBox2.Enabled = False
            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox2.Text = TextBox8.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox2.Text = p2
            TextBox2.Enabled = False
            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox2.Text = TextBox8.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox3.Text = p1
            TextBox3.Enabled = False

            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox6.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox7.Text And TextBox3.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox3.Text = p2
            TextBox3.Enabled = False
            If TextBox1.Text = TextBox2.Text And TextBox1.Text = TextBox3.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox6.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox7.Text And TextBox3.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox4.Text = p1
            TextBox4.Enabled = False
            If TextBox4.Text = TextBox1.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox4.Text = TextBox6.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox4.Text = p2
            TextBox4.Enabled = False

            If TextBox4.Text = TextBox1.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox4.Text = TextBox6.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox5.Text = p1
            TextBox5.Enabled = False

            If TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox5.Text And TextBox3.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox6.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox8.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox5.Text = p2
            TextBox5.Enabled = False
            If TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox5.Text And TextBox3.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox6.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox8.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox6.Text = p1
            TextBox6.Enabled = False
            If TextBox6.Text = TextBox3.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox4.Text = TextBox6.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox6.Text = p2
            TextBox6.Enabled = False
            If TextBox6.Text = TextBox3.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox4.Text = TextBox5.Text And TextBox4.Text = TextBox6.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox7.Text = p1
            TextBox7.Enabled = False
            If TextBox1.Text = TextBox4.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox7.Text = TextBox8.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox7.Text And TextBox3.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox7.Text = p2
            TextBox7.Enabled = False
            If TextBox1.Text = TextBox4.Text And TextBox1.Text = TextBox7.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox7.Text = TextBox8.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox7.Text And TextBox3.Text = TextBox5.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox8.Text = p1
            TextBox8.Enabled = False
            If TextBox8.Text = TextBox7.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox2.Text = TextBox8.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox8.Text = p2
            TextBox8.Enabled = False
            If TextBox8.Text = TextBox7.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox2.Text = TextBox5.Text And TextBox2.Text = TextBox8.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub
    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        If turn Mod 2 <> 0 Then
            Label1.Text = Form1.TextBox1.Text
            Label1.Text = Label1.Text + "'s Turn:" & p1
            TextBox9.Text = p1
            TextBox9.Enabled = False
            If TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox7.Text = TextBox8.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox6.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox1.Text)
                Form1.Close()

            End If
        Else
            Label1.Text = Form1.TextBox2.Text
            Label1.Text = Label1.Text + "'s Turn:" & p2
            TextBox9.Text = p2
            TextBox9.Enabled = False
            If TextBox1.Text = TextBox5.Text And TextBox1.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox7.Text = TextBox8.Text And TextBox7.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            ElseIf TextBox3.Text = TextBox6.Text And TextBox3.Text = TextBox9.Text Then
                MsgBox("Winner is:" & Form1.TextBox2.Text)
                Form1.Close()

            End If
        End If
        turn = turn + 1
        If turn > 9 Then
            MsgBox("It Is a Tie")
            Form1.Close()
        End If
    End Sub

End Class