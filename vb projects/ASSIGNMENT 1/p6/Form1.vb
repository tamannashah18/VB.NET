Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateAndTime.Day(DateTimePicker1.Value)
        TextBox2.Text = DateAndTime.Month(DateTimePicker1.Value)
        TextBox3.Text = DateAndTime.Year(DateTimePicker1.Value)


    End Sub
End Class
