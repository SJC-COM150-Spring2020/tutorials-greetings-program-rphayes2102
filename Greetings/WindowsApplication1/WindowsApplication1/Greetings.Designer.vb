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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Greetings))
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picGreeting = New System.Windows.Forms.PictureBox()
        CType(Me.picGreeting, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.Tomato
        Me.lstOut.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.ForeColor = System.Drawing.Color.DarkGreen
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 19
        Me.lstOut.Location = New System.Drawing.Point(195, 281)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(253, 80)
        Me.lstOut.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Tomato
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("MS Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.Location = New System.Drawing.Point(195, 401)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 45)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tomato
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("MS Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit.Location = New System.Drawing.Point(345, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 45)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picGreeting
        '
        Me.picGreeting.Image = CType(resources.GetObject("picGreeting.Image"), System.Drawing.Image)
        Me.picGreeting.Location = New System.Drawing.Point(575, 160)
        Me.picGreeting.Name = "picGreeting"
        Me.picGreeting.Size = New System.Drawing.Size(566, 429)
        Me.picGreeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreeting.TabIndex = 7
        Me.picGreeting.TabStop = False
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1166, 832)
        Me.Controls.Add(Me.picGreeting)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Greetings"
        Me.Text = "Greetings"
        CType(Me.picGreeting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picGreeting As PictureBox
End Class
