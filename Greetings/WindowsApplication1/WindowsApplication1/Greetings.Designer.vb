<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greetings
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Tomato
        Me.btnClick.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClick.Location = New System.Drawing.Point(195, 211)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(162, 50)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click Me "
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Tomato
        Me.txtName.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtName.Location = New System.Drawing.Point(195, 149)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(162, 26)
        Me.txtName.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.White
        Me.lbl1.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl1.Location = New System.Drawing.Point(180, 37)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(196, 19)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Greetings Program"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblName.Location = New System.Drawing.Point(191, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(185, 19)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Enter Your Name "
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.Tomato
        Me.txtOut.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtOut.Location = New System.Drawing.Point(195, 294)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(238, 56)
        Me.txtOut.TabIndex = 4
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(615, 411)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Greetings"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtOut As TextBox
End Class
