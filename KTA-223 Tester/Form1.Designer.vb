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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.txtNewAddr = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRX = New System.Windows.Forms.TextBox
        Me.txtTX = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(70, 19)
        Me.ProgressBar1.Maximum = 1023
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(178, 13)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 512
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(70, 38)
        Me.ProgressBar2.Maximum = 1023
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(178, 13)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 1
        Me.ProgressBar2.Value = 512
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(70, 56)
        Me.ProgressBar3.Maximum = 1023
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(178, 13)
        Me.ProgressBar3.Step = 1
        Me.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar3.TabIndex = 2
        Me.ProgressBar3.Value = 512
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Analog Inputs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "1023"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "1023"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "1023"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(122, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 163)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Relays"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Location = New System.Drawing.Point(74, 131)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(62, 22)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "ALL OFF"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.Location = New System.Drawing.Point(6, 131)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(62, 22)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "ALL ON"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Red
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(74, 103)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(62, 22)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Toggle 8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(74, 75)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(62, 22)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Toggle 7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(74, 47)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(62, 22)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Toggle 6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(74, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 22)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Toggle 5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(6, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 22)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Toggle 3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(6, 103)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 22)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Toggle 4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(6, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Toggle 2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Toggle 1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(50, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(25, 15)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 116)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Digital Inputs"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(50, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(25, 15)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(50, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 15)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(50, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(25, 15)
        Me.Panel2.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "4:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "3:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "2:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "1:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.txtNewAddr)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 40)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Address"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(39, 14)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(58, 20)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Change"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtNewAddr
        '
        Me.txtNewAddr.Location = New System.Drawing.Point(6, 14)
        Me.txtNewAddr.MaxLength = 2
        Me.txtNewAddr.Name = "txtNewAddr"
        Me.txtNewAddr.Size = New System.Drawing.Size(27, 20)
        Me.txtNewAddr.TabIndex = 0
        Me.txtNewAddr.Text = "1"
        Me.txtNewAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button13)
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtRX)
        Me.GroupBox5.Controls.Add(Me.txtTX)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(254, 72)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Comms"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(66, 18)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(45, 20)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "Open"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(117, 18)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(43, 20)
        Me.Button12.TabIndex = 15
        Me.Button12.Text = "Baud"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(129, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "RX:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "TX:"
        '
        'txtRX
        '
        Me.txtRX.Enabled = False
        Me.txtRX.Location = New System.Drawing.Point(160, 45)
        Me.txtRX.Name = "txtRX"
        Me.txtRX.Size = New System.Drawing.Size(86, 20)
        Me.txtRX.TabIndex = 12
        '
        'txtTX
        '
        Me.txtTX.Enabled = False
        Me.txtTX.Location = New System.Drawing.Point(39, 44)
        Me.txtTX.Name = "txtTX"
        Me.txtTX.Size = New System.Drawing.Size(86, 20)
        Me.txtTX.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Address:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 18)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(28, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Port:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(38, 18)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(21, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 250
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 500
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(68, 342)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.oceancontrols.com.au"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(280, 364)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KTA-223 Relayduino Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents txtNewAddr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRX As System.Windows.Forms.TextBox
    Friend WithEvents txtTX As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form2.Show()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    SerialPort1.PortName = "COM" & TextBox2.Text
        '    SerialPort1.BaudRate = 9600
        '    SerialPort1.Open()
        'Catch ex As Exception
        '    MsgBox("Error Opening " & SerialPort1.PortName)
        'End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim mychar As String
        Try
            If SerialPort1.IsOpen Then
                While SerialPort1.BytesToRead > 0
                    mychar = Chr(SerialPort1.ReadByte)
                    If mychar = "#" Then
                        txtRX.Text = ""
                    Else
                        If mychar = Chr(13) Or mychar = Chr(10) Then
                            monitor(txtRX.Text)
                            'rxOn = False
                            txNext = True
                        Else
                            txtRX.Text = txtRX.Text & mychar
                        End If
                    End If
                End While
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button1.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 1"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 1"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button2.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 2"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 2"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button3.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 3"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 3"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button4.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 4"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 4"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button5.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 5"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 5"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button6.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 6"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 6"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button7.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 7"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 7"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                If Button8.BackColor = Color.Red Then
                    outstr = "@" & addr & " ON 8"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                Else
                    outstr = "@" & addr & " OF 8"
                    txtTX.Text = outstr
                    outstr = outstr & Chr(13) 'vbNewLine
                    SerialPort1.Write(outstr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                outstr = "@" & addr & " ON 0"
                txtTX.Text = outstr
                outstr = outstr & Chr(13) 'vbNewLine
                SerialPort1.Write(outstr)
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                outstr = "@" & addr & " OF 0"
                txtTX.Text = outstr
                outstr = outstr & Chr(13) 'vbNewLine
                SerialPort1.Write(outstr)
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim addr As String, outstr As String
            addr = ""
            If TextBox3.Text < 10 Then
                addr = "0"
            End If
            addr = addr & TextBox3.Text
            If SerialPort1.IsOpen Then
                outstr = "@" & addr & " SA "
                If txtNewAddr.Text < 10 Then
                    outstr = outstr & "0"
                End If
                outstr = outstr & txtNewAddr.Text
                txtTX.Text = outstr
                outstr = outstr & Chr(13) 'vbNewLine
                SerialPort1.Write(outstr)
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error with Port " & SerialPort1.PortName)

        End Try
    End Sub
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim mystr As String
        'Static SorI As Byte
        Try
            If txNext = True Then
                SorI = SorI + 1
                If SorI = 3 Then SorI = 0
                mystr = ""
                'If Option1(2).Value = True Then
                If TextBox3.Text < 10 Then
                    mystr = "@0" & TextBox3.Text & " "
                Else
                    mystr = "@" & TextBox3.Text & " "
                End If
                'End If
                Select Case SorI
                    Case 0
                        mystr = mystr & "RS 0"
                        txNext = False

                    Case 1
                        mystr = mystr & "IS 0"
                        txNext = False

                    Case 2
                        mystr = mystr & "AI 0"
                        txNext = False

                End Select
                txtTX.Text = mystr
                mystr = mystr & Chr(13) 'vbNewLine
                If SerialPort1.IsOpen Then
                    SerialPort1.Write(mystr)
                End If
            End If
        Catch ex As Exception
            SerialPort1.Close()
            MsgBox("Error Writing to Port " & SerialPort1.PortName)

        End Try
    End Sub
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If txNext <> True Then
            txNext = True
        End If
    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(LinkLabel1.Text)
    End Sub
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
