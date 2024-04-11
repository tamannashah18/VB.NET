Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If x_txt.Text = "" Or IsNumeric(x_txt.Text) = False Then
            MessageBox.Show("Enter value for X")
            x_txt.Focus()
        ElseIf y_txt.Text = "" Or IsNumeric(y_txt.Text) = False Then
            MessageBox.Show("Enter value for Y")
            y_txt.Focus()
        Else
            Dim x, y, sum As Integer
            x = x_txt.Text
            y = y_txt.Text
            sum = x + y
            MessageBox.Show("Sum is " & sum)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If x_txt.Text = "" Or IsNumeric(x_txt.Text) = False Then
            MessageBox.Show("Enter value for X")
            x_txt.Focus()
        ElseIf y_txt.Text = "" Or IsNumeric(y_txt.Text) = False Then
            MessageBox.Show("Enter value for Y")
            y_txt.Focus()
        Else
            Dim x, y, div As Integer
            x = x_txt.Text
            y = y_txt.Text

            If y = 0 Then
                MessageBox.Show("Divide by 0 not possible. Re-enter Y")
                y_txt.Focus()
            Else
                div = x / y
                MessageBox.Show("Quotient is " & div)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If x_txt.Text = "" Or IsNumeric(x_txt.Text) = False Then
            MessageBox.Show("Enter value for X")
            x_txt.Focus()
        ElseIf y_txt.Text = "" Or IsNumeric(y_txt.Text) = False Then
            MessageBox.Show("Enter value for Y")
            y_txt.Focus()
        Else
            Dim x, y, mul As Integer
            x = x_txt.Text
            y = y_txt.Text
            mul = x * y
            MessageBox.Show("Product is " & mul)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If x_txt.Text = "" Or IsNumeric(x_txt.Text) = False Then
            MessageBox.Show("Enter value for X")
            x_txt.Focus()
        ElseIf y_txt.Text = "" Or IsNumeric(y_txt.Text) = False Then
            MessageBox.Show("Enter value for Y")
            y_txt.Focus()
        Else
            Dim x, y, diff As Integer
            x = x_txt.Text
            y = y_txt.Text
            diff = x - y
            MessageBox.Show("Difference is " & diff)
        End If

    End Sub
End Class
