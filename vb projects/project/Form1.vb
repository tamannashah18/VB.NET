Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Input


Public Class Form1


    Dim con As New OleDb.OleDbConnection("Data Source=localhost; Password=it4; User Id=it4; " &
                                         "Provider=OraOLEDB.ORACLE")
    Dim dr As OleDb.OleDbDataReader

    Dim com As OleDb.OleDbCommand
    Function add_del(ByVal a)

        con.Open()
        Dim com As New OleDbCommand("Select stock from toys where toy_id=?", con)
        com.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
        Dim res As Integer = com.ExecuteScalar()
        res = res + a
        Dim com1 As New OleDbCommand("UPDATE toys SET stock=? where toy_id=?", con)
        com1.Parameters.AddWithValue("?", res)
        com1.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
        com1.ExecuteNonQuery()
        con.Close()
        filltoy()
        clr_flds()
    End Function
    Function fillcombo()
        con.Open()
        Dim adp As New OleDbDataAdapter("Select * from toys", con)
        Dim ds As New DataSet
        adp.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "toy_name"
        ComboBox1.ValueMember = "toy_id"
        con.Close()
    End Function
    Function clr_flds()
        TextBox1.Text = ""
        TextBox2.Text = ""
        id.Text = ""
        nm.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox5.Text = ""
        desc.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
    End Function
    Function fillage()
        Dim ds As New DataSet
        ds.Clear()
        con.Open()
        Dim adp As New OleDbDataAdapter("Select * from age_category", con)
        adp.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)
        con.Close()
        clr_flds()
    End Function
    Function fillbill()
        Dim ds As New DataSet
        Dim adp As New OleDbDataAdapter("Select * from bills", con)
        ds.Clear()
        con.Open()
        adp.Fill(ds)
        DataGridView6.DataSource = ds.Tables(0)
        con.Close()
        clr_flds()
    End Function
    Function filltoy()
        fillcombo()
        Dim ds As New DataSet
        Try
            ds.Clear()
            con.Open()
            Dim adp As New OleDbDataAdapter("Select * from toys", con)
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            clr_flds()
        Catch ee As Exception
            MsgBox(ee.Message.ToString)
        End Try
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filltoy()
        fillage()
        fillbill()
        fillcombo()
        TextBox4.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim insertQry = "INSERT INTO toys VALUES(?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(insertQry, con)
            cmd.Parameters.AddWithValue("?", id.Text)
            cmd.Parameters.AddWithValue("?", nm.Text)
            cmd.Parameters.AddWithValue("?", desc.Text)
            cmd.Parameters.AddWithValue("?", CInt(TextBox8.Text))
            cmd.Parameters.AddWithValue("?", TextBox5.Text)
            cmd.Parameters.AddWithValue("?", NumericUpDown1.Value)
            cmd.Parameters.AddWithValue("?", NumericUpDown2.Value)
            Dim res = cmd.ExecuteNonQuery()
            con.Close()

            If (res >= 1) Then
                MsgBox("Data Inserted")
                filltoy()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim updateQry = "UPDATE toys SET toy_id = ?,toy_name = ?,description = ?,age_code = ?,image_path = ?,stock = ?,price_per_item = ? WHERE toy_id=?"
            Dim cmd As New OleDbCommand(updateQry, con)
            cmd.Parameters.AddWithValue("?", id.Text)
            cmd.Parameters.AddWithValue("?", nm.Text)
            cmd.Parameters.AddWithValue("?", desc.Text)
            cmd.Parameters.AddWithValue("?", CInt(TextBox8.Text))
            cmd.Parameters.AddWithValue("?", TextBox5.Text)
            cmd.Parameters.AddWithValue("?", NumericUpDown1.Value)
            cmd.Parameters.AddWithValue("?", NumericUpDown2.Value)
            cmd.Parameters.AddWithValue("?", id.Text)
            Dim res = cmd.ExecuteNonQuery()
            con.Close()

            If (res >= 1) Then
                MsgBox("Data Updated")
                filltoy()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = MessageBox.Show("Are you sure you want to Delete?",
                                     "Heads Up!", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try
                con.Open()
                Dim delQry = "DELETE FROM TOYS WHERE TOY_ID=?"
                Dim cmd As New OleDbCommand(delQry, con)
                cmd.Parameters.AddWithValue("?", id.Text)
                Dim res = cmd.ExecuteNonQuery()
                con.Close()

                If (res >= 1) Then
                    MsgBox("Data Deleted")
                    filltoy()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            con.Open()
            Dim insertqry As String = "INSERT INTO AGE_CATEGORY VALUES(?,?)"
            Dim cmd As New OleDbCommand(insertqry, con)
            cmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            cmd.Parameters.AddWithValue("?", TextBox2.Text)
            Dim res = cmd.ExecuteNonQuery()
            con.Close()

            If (res >= 1) Then
                MsgBox("Data inserted")
                fillage()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            con.Open()
            Dim insertqry As String = "UPDATE AGE_CATEGORY SET age_code = ?,years = ? WHERE age_code=?"
            Dim cmd As New OleDbCommand(insertqry, con)
            cmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            cmd.Parameters.AddWithValue("?", TextBox2.Text)
            cmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            Dim res = cmd.ExecuteNonQuery()
            con.Close()

            If (res >= 1) Then
                MsgBox("Data updated")
                fillage()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result = MessageBox.Show("Are you sure you want to Delete?",
                                     "Heads Up!", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try
                con.Open()
                Dim insertqry As String = "DELETE FROM AGE_CATEGORY WHERE age_code=?"
                Dim cmd As New OleDbCommand(insertqry, con)
                cmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
                Dim res = cmd.ExecuteNonQuery()
                con.Close()

                If (res >= 1) Then
                    MsgBox("Data deleted")
                    fillage()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT price_per_item from toys where toy_id=?", con)
            cmd.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
            Dim result As Integer = cmd.ExecuteScalar()
            TextBox4.Text = result
            TextBox4.Text = (TextBox4.Text * NumericUpDown4.Value) - (TextBox3.Text * TextBox4.Text / 100)
            Dim insertqry As String = "INSERT INTO BILLS VALUES (?,?,?,?,?,?,TO_DATE(?,'DD-MM-YYYY'))"
            Dim cmd1 As New OleDbCommand(insertqry, con)
            cmd1.Parameters.AddWithValue("?", CInt(TextBox7.Text))
            cmd1.Parameters.AddWithValue("?", TextBox6.Text)
            cmd1.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
            cmd1.Parameters.AddWithValue("?", NumericUpDown4.Value)
            cmd1.Parameters.AddWithValue("?", CInt(TextBox3.Text))
            cmd1.Parameters.AddWithValue("?", CInt(TextBox4.Text))
            cmd1.Parameters.AddWithValue("?", DateTimePicker1.Value.ToString("dd-MM-yyyy"))
            Dim res = cmd1.ExecuteNonQuery()
            con.Close()

            If (res >= 1) Then
                MsgBox("Data inserted")
                add_del(NumericUpDown4.Value * -1)
                fillbill()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            con.Open()

            Dim cmd2 As New OleDbCommand("SELECT quantity from bills where bill_id=?", con)
            cmd2.Parameters.AddWithValue("?", CInt(TextBox7.Text))
            Dim q As Integer = CInt(cmd2.ExecuteScalar())

            Dim cmd As New OleDbCommand("SELECT price_per_item from toys where toy_id=?", con)
            cmd.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
            Dim pricePerItem As Integer = CInt(cmd.ExecuteScalar())

            Dim totalPrice As Double = pricePerItem * NumericUpDown4.Value
            Dim discountAmount As Double = totalPrice * (CInt(TextBox3.Text) / 100)
            Dim totalAmount As Double = totalPrice - discountAmount

            Dim updateQuery As String = "UPDATE BILLS SET customer=?,toy_id=?,quantity=?,discount=?,total_amount=?,dt=TO_DATE(?,'DD-MM-YYYY') WHERE bill_id=?"
            Dim cmd1 As New OleDbCommand(updateQuery, con)
            cmd1.Parameters.AddWithValue("?", TextBox6.Text)
            cmd1.Parameters.AddWithValue("?", ComboBox1.SelectedValue)
            cmd1.Parameters.AddWithValue("?", NumericUpDown4.Value)
            cmd1.Parameters.AddWithValue("?", CInt(TextBox3.Text))
            cmd1.Parameters.AddWithValue("?", totalAmount)
            cmd1.Parameters.AddWithValue("?", DateTimePicker1.Value.ToString("dd-MM-yyyy"))
            cmd1.Parameters.AddWithValue("?", CInt(TextBox7.Text))

            Dim r As Integer = cmd1.ExecuteNonQuery()

            con.Close()

            If (r >= 1) Then
                MsgBox("Data updated")
                add_del(q - NumericUpDown4.Value)
                fillbill()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result = MessageBox.Show("Are you sure you want to Delete?",
                                     "Heads Up!", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try
                con.Open()
                Dim insertqry As String = "DELETE from BILLS where bill_id=?"
                Dim cmd1 As New OleDbCommand(insertqry, con)
                cmd1.Parameters.AddWithValue("?", CInt(TextBox7.Text))

                Dim cmd2 As New OleDbCommand("SELECT quantity from bills where bill_id=?", con)
                cmd2.Parameters.AddWithValue("?", CInt(TextBox7.Text))
                Dim r = cmd2.ExecuteScalar()
                Dim res = cmd1.ExecuteNonQuery()
                con.Close()

                If (res >= 1) Then
                    MsgBox("Data deleted")
                    add_del(r)
                    fillbill()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub generate_Click(sender As Object, e As EventArgs)
        con.Open()

        Dim ds As New DataSet

        Dim ADP As New OleDbDataAdapter("Select * from bills where dt>TO_DATE('01-03-2024','DD-MM-YYYY')", con)
        ADP.Fill(ds, "q1")
        DataGridView3.DataSource = ds.Tables("q1")

        ADP = New OleDbDataAdapter("Select toy_id,toy_name,stock from toys where stock<10 ", con)
        ADP.Fill(ds, "q2")
        DataGridView4.DataSource = ds.Tables("q2")

        ADP = New OleDbDataAdapter("Select count(b.toy_id) as no_of_products_sold,b.toy_id  from toys t,bills b group by b.toy_id, t.toy_id having b.toy_id=t.toy_id ", con)
        ADP.Fill(ds, "q3")
        DataGridView5.DataSource = ds.Tables("q3")

        con.Close()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Title = "Open an image file"
            OpenFileDialog1.Filter = "Image|*.jpg"
            TextBox5.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub DataGridView6_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView6.SelectionChanged
        If DataGridView6.Focused Then
            Try
                TextBox7.Text = DataGridView6.SelectedRows(0).Cells(0).Value.ToString
                TextBox6.Text = DataGridView6.SelectedRows(0).Cells(1).Value.ToString
                ComboBox1.SelectedValue = DataGridView6.SelectedRows(0).Cells(2).Value.ToString
                NumericUpDown4.Value = DataGridView6.SelectedRows(0).Cells(3).Value.ToString
                TextBox3.Text = DataGridView6.SelectedRows(0).Cells(4).Value.ToString
                TextBox4.Text = DataGridView6.SelectedRows(0).Cells(5).Value.ToString
                DateTimePicker1.Value = DataGridView6.SelectedRows(0).Cells(6).Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.Focused Then
            Try
                id.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                nm.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
                desc.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
                TextBox8.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
                TextBox5.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
                NumericUpDown1.Value = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
                NumericUpDown2.Value = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        If DataGridView2.Focused Then
            Try
                TextBox1.Text = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
                TextBox2.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            ' Show the print preview dialog
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox("Error previewing document: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set up the print formatting (e.g., font, brush, etc.)
        Dim printFont As New Font("Arial", 20)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim lineHeight As Integer = 20

        ' Define the bill content with labels and data
        Dim billContent As New StringBuilder()
        billContent.AppendLine("Bill Information:")
        billContent.AppendLine("Bill ID: " & TextBox7.Text)
        billContent.AppendLine("Customer: " & TextBox6.Text)
        billContent.AppendLine("Toy ID: " & ComboBox1.SelectedValue)
        billContent.AppendLine("Quantity: " & NumericUpDown4.Value)
        billContent.AppendLine("Discount: " & TextBox3.Text & "%")
        billContent.AppendLine("Total Amount: " & TextBox4.Text)
        billContent.AppendLine("Date: " & DateTimePicker1.Value.ToString("dd-MM-yyyy"))

        ' Draw the bill content onto the PrintDocument
        e.Graphics.DrawString(billContent.ToString(), printFont, brush, startX, startY)
    End Sub
End Class