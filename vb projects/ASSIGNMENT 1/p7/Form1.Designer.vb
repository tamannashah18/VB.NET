<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Personal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.L_name = New System.Windows.Forms.TextBox()
        Me.F_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grade = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.percentage = New System.Windows.Forms.Label()
        Me.Marks = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.Label()
        Me.Personal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(275, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Generate Result"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Personal
        '
        Me.Personal.Controls.Add(Me.TabPage1)
        Me.Personal.Controls.Add(Me.TabPage2)
        Me.Personal.Controls.Add(Me.TabPage3)
        Me.Personal.Location = New System.Drawing.Point(39, 45)
        Me.Personal.Name = "Personal"
        Me.Personal.SelectedIndex = 0
        Me.Personal.Size = New System.Drawing.Size(736, 326)
        Me.Personal.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.L_name)
        Me.TabPage1.Controls.Add(Me.F_name)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(356, 167)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 41
        '
        'L_name
        '
        Me.L_name.Location = New System.Drawing.Point(356, 125)
        Me.L_name.Name = "L_name"
        Me.L_name.Size = New System.Drawing.Size(198, 20)
        Me.L_name.TabIndex = 40
        '
        'F_name
        '
        Me.F_name.Location = New System.Drawing.Point(356, 83)
        Me.F_name.Name = "F_name"
        Me.F_name.Size = New System.Drawing.Size(198, 20)
        Me.F_name.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 33)
        Me.Label4.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 33)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Semester: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 33)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Last Name: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 33)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "First Name: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Marks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(139, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Marks"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Subject Codes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "105"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "104"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "103"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "102"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "101"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(142, 156)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(142, 130)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(142, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grade)
        Me.TabPage3.Controls.Add(Me.total)
        Me.TabPage3.Controls.Add(Me.percentage)
        Me.TabPage3.Controls.Add(Me.Marks)
        Me.TabPage3.Controls.Add(Me.name1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(728, 300)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Result"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grade
        '
        Me.grade.AutoSize = True
        Me.grade.Location = New System.Drawing.Point(50, 183)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(36, 13)
        Me.grade.TabIndex = 4
        Me.grade.Text = "Grade"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(50, 110)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(31, 13)
        Me.total.TabIndex = 3
        Me.total.Text = "Total"
        '
        'percentage
        '
        Me.percentage.AutoSize = True
        Me.percentage.Location = New System.Drawing.Point(50, 144)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(62, 13)
        Me.percentage.TabIndex = 2
        Me.percentage.Text = "Percentage"
        '
        'Marks
        '
        Me.Marks.AutoSize = True
        Me.Marks.Location = New System.Drawing.Point(50, 56)
        Me.Marks.Name = "Marks"
        Me.Marks.Size = New System.Drawing.Size(39, 13)
        Me.Marks.TabIndex = 1
        Me.Marks.Text = "Marks:"
        '
        'name1
        '
        Me.name1.AutoSize = True
        Me.name1.Location = New System.Drawing.Point(50, 25)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(41, 13)
        Me.name1.TabIndex = 0
        Me.name1.Text = "Name: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Personal)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Personal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Personal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents L_name As TextBox
    Friend WithEvents F_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents name1 As Label
    Friend WithEvents grade As Label
    Friend WithEvents total As Label
    Friend WithEvents percentage As Label
    Friend WithEvents Marks As Label
End Class
