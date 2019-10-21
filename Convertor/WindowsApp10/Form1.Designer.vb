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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radbtn5 = New System.Windows.Forms.RadioButton()
        Me.radbtn6 = New System.Windows.Forms.RadioButton()
        Me.radbtn4 = New System.Windows.Forms.RadioButton()
        Me.radbtn3 = New System.Windows.Forms.RadioButton()
        Me.radbtn2 = New System.Windows.Forms.RadioButton()
        Me.radbtn1 = New System.Windows.Forms.RadioButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radbtn11 = New System.Windows.Forms.RadioButton()
        Me.radbtn12 = New System.Windows.Forms.RadioButton()
        Me.radbtn10 = New System.Windows.Forms.RadioButton()
        Me.radbtn9 = New System.Windows.Forms.RadioButton()
        Me.radbtn8 = New System.Windows.Forms.RadioButton()
        Me.radbtn7 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metric Conversion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbtn5)
        Me.GroupBox1.Controls.Add(Me.radbtn6)
        Me.GroupBox1.Controls.Add(Me.radbtn4)
        Me.GroupBox1.Controls.Add(Me.radbtn3)
        Me.GroupBox1.Controls.Add(Me.radbtn2)
        Me.GroupBox1.Controls.Add(Me.radbtn1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 164)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert From"
        '
        'radbtn5
        '
        Me.radbtn5.AutoSize = True
        Me.radbtn5.Location = New System.Drawing.Point(7, 111)
        Me.radbtn5.Name = "radbtn5"
        Me.radbtn5.Size = New System.Drawing.Size(110, 17)
        Me.radbtn5.TabIndex = 5
        Me.radbtn5.TabStop = True
        Me.radbtn5.Text = "Square Kilometers"
        Me.radbtn5.UseVisualStyleBackColor = True
        '
        'radbtn6
        '
        Me.radbtn6.AutoSize = True
        Me.radbtn6.Location = New System.Drawing.Point(7, 134)
        Me.radbtn6.Name = "radbtn6"
        Me.radbtn6.Size = New System.Drawing.Size(87, 17)
        Me.radbtn6.TabIndex = 4
        Me.radbtn6.Text = "Square Rods"
        Me.radbtn6.UseVisualStyleBackColor = True
        '
        'radbtn4
        '
        Me.radbtn4.AutoSize = True
        Me.radbtn4.Location = New System.Drawing.Point(7, 88)
        Me.radbtn4.Name = "radbtn4"
        Me.radbtn4.Size = New System.Drawing.Size(108, 17)
        Me.radbtn4.TabIndex = 3
        Me.radbtn4.Text = "Square Fhathoms"
        Me.radbtn4.UseVisualStyleBackColor = True
        '
        'radbtn3
        '
        Me.radbtn3.AutoSize = True
        Me.radbtn3.Location = New System.Drawing.Point(7, 65)
        Me.radbtn3.Name = "radbtn3"
        Me.radbtn3.Size = New System.Drawing.Size(46, 17)
        Me.radbtn3.TabIndex = 2
        Me.radbtn3.Text = "Ping"
        Me.radbtn3.UseVisualStyleBackColor = True
        '
        'radbtn2
        '
        Me.radbtn2.AutoSize = True
        Me.radbtn2.Location = New System.Drawing.Point(7, 44)
        Me.radbtn2.Name = "radbtn2"
        Me.radbtn2.Size = New System.Drawing.Size(68, 17)
        Me.radbtn2.TabIndex = 1
        Me.radbtn2.Text = "Hectares"
        Me.radbtn2.UseVisualStyleBackColor = True
        '
        'radbtn1
        '
        Me.radbtn1.AutoSize = True
        Me.radbtn1.Checked = True
        Me.radbtn1.Location = New System.Drawing.Point(6, 20)
        Me.radbtn1.Name = "radbtn1"
        Me.radbtn1.Size = New System.Drawing.Size(52, 17)
        Me.radbtn1.TabIndex = 0
        Me.radbtn1.TabStop = True
        Me.radbtn1.Text = "Acres"
        Me.radbtn1.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(116, 75)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(18, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(116, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(116, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "RESET"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter a value: "
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblResult.Location = New System.Drawing.Point(161, 306)
        Me.lblResult.MinimumSize = New System.Drawing.Size(50, 16)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(50, 16)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Result"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(210, 306)
        Me.lblUnit.MinimumSize = New System.Drawing.Size(100, 16)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(100, 16)
        Me.lblUnit.TabIndex = 9
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radbtn11)
        Me.GroupBox2.Controls.Add(Me.radbtn12)
        Me.GroupBox2.Controls.Add(Me.radbtn10)
        Me.GroupBox2.Controls.Add(Me.radbtn9)
        Me.GroupBox2.Controls.Add(Me.radbtn8)
        Me.GroupBox2.Controls.Add(Me.radbtn7)
        Me.GroupBox2.Location = New System.Drawing.Point(164, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 164)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convert To"
        '
        'radbtn11
        '
        Me.radbtn11.AutoSize = True
        Me.radbtn11.Location = New System.Drawing.Point(6, 108)
        Me.radbtn11.Name = "radbtn11"
        Me.radbtn11.Size = New System.Drawing.Size(110, 17)
        Me.radbtn11.TabIndex = 11
        Me.radbtn11.TabStop = True
        Me.radbtn11.Text = "Square Kilometers"
        Me.radbtn11.UseVisualStyleBackColor = True
        '
        'radbtn12
        '
        Me.radbtn12.AutoSize = True
        Me.radbtn12.Location = New System.Drawing.Point(6, 131)
        Me.radbtn12.Name = "radbtn12"
        Me.radbtn12.Size = New System.Drawing.Size(87, 17)
        Me.radbtn12.TabIndex = 10
        Me.radbtn12.Text = "Square Rods"
        Me.radbtn12.UseVisualStyleBackColor = True
        '
        'radbtn10
        '
        Me.radbtn10.AutoSize = True
        Me.radbtn10.Location = New System.Drawing.Point(6, 85)
        Me.radbtn10.Name = "radbtn10"
        Me.radbtn10.Size = New System.Drawing.Size(108, 17)
        Me.radbtn10.TabIndex = 9
        Me.radbtn10.Text = "Square Fhathoms"
        Me.radbtn10.UseVisualStyleBackColor = True
        '
        'radbtn9
        '
        Me.radbtn9.AutoSize = True
        Me.radbtn9.Location = New System.Drawing.Point(6, 62)
        Me.radbtn9.Name = "radbtn9"
        Me.radbtn9.Size = New System.Drawing.Size(46, 17)
        Me.radbtn9.TabIndex = 8
        Me.radbtn9.Text = "Ping"
        Me.radbtn9.UseVisualStyleBackColor = True
        '
        'radbtn8
        '
        Me.radbtn8.AutoSize = True
        Me.radbtn8.Location = New System.Drawing.Point(6, 41)
        Me.radbtn8.Name = "radbtn8"
        Me.radbtn8.Size = New System.Drawing.Size(68, 17)
        Me.radbtn8.TabIndex = 7
        Me.radbtn8.Text = "Hectares"
        Me.radbtn8.UseVisualStyleBackColor = True
        '
        'radbtn7
        '
        Me.radbtn7.AutoSize = True
        Me.radbtn7.Checked = True
        Me.radbtn7.Location = New System.Drawing.Point(5, 17)
        Me.radbtn7.Name = "radbtn7"
        Me.radbtn7.Size = New System.Drawing.Size(52, 17)
        Me.radbtn7.TabIndex = 6
        Me.radbtn7.TabStop = True
        Me.radbtn7.Text = "Acres"
        Me.radbtn7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(322, 401)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radbtn6 As RadioButton
    Friend WithEvents radbtn4 As RadioButton
    Friend WithEvents radbtn3 As RadioButton
    Friend WithEvents radbtn2 As RadioButton
    Friend WithEvents radbtn1 As RadioButton
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radbtn5 As RadioButton
    Friend WithEvents radbtn11 As RadioButton
    Friend WithEvents radbtn12 As RadioButton
    Friend WithEvents radbtn10 As RadioButton
    Friend WithEvents radbtn9 As RadioButton
    Friend WithEvents radbtn8 As RadioButton
    Friend WithEvents radbtn7 As RadioButton
End Class
