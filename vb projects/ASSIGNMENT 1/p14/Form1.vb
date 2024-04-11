Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.CheckOnClick = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Total Students : " & CheckedListBox1.Items.Count() & vbNewLine & "Present Students : " & CheckedListBox1.CheckedItems.Count() & vbNewLine & "Absent Students: " & CheckedListBox1.Items.Count() - CheckedListBox1.CheckedItems.Count()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Label1.Text += vbNewLine & CheckedListBox1.SelectedItem.ToString()
    End Sub
End Class
