Public Class Form1
    Dim cnt1, cnt2 As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Add(ListBox1.SelectedItem)
        selcted_lbl.Text = ListBox1.SelectedItem

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox2.Items.Remove(ListBox2.SelectedItem)
        selcted_lbl.Text = ListBox2.SelectedItem

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cnt1 = ListBox1.Items.Count()
        cnt2 = ListBox2.Items.Count()
        Dim sum As Integer
        sum = cnt1 + cnt2
        selcted_lbl.Text = "Counted Items = " & sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.AddRange(ListBox1.Items)
    End Sub
End Class
