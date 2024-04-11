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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.X_lbl = New System.Windows.Forms.Label()
        Me.lbl_Y = New System.Windows.Forms.Label()
        Me.x_txt = New System.Windows.Forms.TextBox()
        Me.y_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(281, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Product"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Division"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(499, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Subtraction"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'X_lbl
        '
        Me.X_lbl.AutoSize = True
        Me.X_lbl.Location = New System.Drawing.Point(93, 63)
        Me.X_lbl.Name = "X_lbl"
        Me.X_lbl.Size = New System.Drawing.Size(20, 13)
        Me.X_lbl.TabIndex = 4
        Me.X_lbl.Text = "X :"
        '
        'lbl_Y
        '
        Me.lbl_Y.AutoSize = True
        Me.lbl_Y.Location = New System.Drawing.Point(93, 108)
        Me.lbl_Y.Name = "lbl_Y"
        Me.lbl_Y.Size = New System.Drawing.Size(20, 13)
        Me.lbl_Y.TabIndex = 5
        Me.lbl_Y.Text = "Y :"
        '
        'x_txt
        '
        Me.x_txt.Location = New System.Drawing.Point(155, 63)
        Me.x_txt.Name = "x_txt"
        Me.x_txt.Size = New System.Drawing.Size(100, 20)
        Me.x_txt.TabIndex = 6
        '
        'y_txt
        '
        Me.y_txt.Location = New System.Drawing.Point(155, 105)
        Me.y_txt.Name = "y_txt"
        Me.y_txt.Size = New System.Drawing.Size(100, 20)
        Me.y_txt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.y_txt)
        Me.Controls.Add(Me.x_txt)
        Me.Controls.Add(Me.lbl_Y)
        Me.Controls.Add(Me.X_lbl)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents X_lbl As Label
    Friend WithEvents lbl_Y As Label
    Friend WithEvents x_txt As TextBox
    Friend WithEvents y_txt As TextBox
End Class
