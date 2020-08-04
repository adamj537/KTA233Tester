using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)  {
			try
			{
				if (disposing && components != null)  {
						components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()  {
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Form1_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
			this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
			this.ButtonAllOff = new System.Windows.Forms.Button();
			this.ButtonAllOff.Click += new System.EventHandler(this.Button10_Click);
			this.ButtonAllOn = new System.Windows.Forms.Button();
			this.ButtonAllOn.Click += new System.EventHandler(this.Button9_Click);
			this.ButtonToggle8 = new System.Windows.Forms.Button();
			this.ButtonToggle8.Click += new System.EventHandler(this.Button8_Click);
			this.ButtonToggle7 = new System.Windows.Forms.Button();
			this.ButtonToggle7.Click += new System.EventHandler(this.Button7_Click);
			this.ButtonToggle6 = new System.Windows.Forms.Button();
			this.ButtonToggle6.Click += new System.EventHandler(this.Button6_Click);
			this.ButtonToggle5 = new System.Windows.Forms.Button();
			this.ButtonToggle5.Click += new System.EventHandler(this.Button5_Click);
			this.ButtonToggle3 = new System.Windows.Forms.Button();
			this.ButtonToggle3.Click += new System.EventHandler(this.Button3_Click);
			this.ButtonToggle4 = new System.Windows.Forms.Button();
			this.ButtonToggle4.Click += new System.EventHandler(this.Button4_Click);
			this.ButtonToggle2 = new System.Windows.Forms.Button();
			this.ButtonToggle2.Click += new System.EventHandler(this.Button2_Click);
			this.ButtonToggle1 = new System.Windows.Forms.Button();
			this.ButtonToggle1.Click += new System.EventHandler(this.Toggle1_Click);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.ButtonChangeAddr = new System.Windows.Forms.Button();
			this.ButtonChangeAddr.Click += new System.EventHandler(this.Button11_Click);
			this.txtNewAddr = new System.Windows.Forms.TextBox();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.GroupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
			this.ButtonOpenPort = new System.Windows.Forms.Button();
			this.ButtonOpenPort.Click += new System.EventHandler(this.OpenPort);
			this.ButtonBaud = new System.Windows.Forms.Button();
			this.ButtonBaud.Click += new System.EventHandler(this.Button12_Click);
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtRX = new System.Windows.Forms.TextBox();
			this.txtTX = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.TextBoxAddr = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBoxPort = new System.Windows.Forms.TextBox();
			this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			this.Timer3 = new System.Windows.Forms.Timer(this.components);
			this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(70, 19);
			this.ProgressBar1.Maximum = 1023;
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(178, 13);
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar1.TabIndex = 0;
			this.ProgressBar1.Value = 512;
			//
			//ProgressBar2
			//
			this.ProgressBar2.Location = new System.Drawing.Point(70, 38);
			this.ProgressBar2.Maximum = 1023;
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new System.Drawing.Size(178, 13);
			this.ProgressBar2.Step = 1;
			this.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar2.TabIndex = 1;
			this.ProgressBar2.Value = 512;
			//
			//ProgressBar3
			//
			this.ProgressBar3.Location = new System.Drawing.Point(70, 56);
			this.ProgressBar3.Maximum = 1023;
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new System.Drawing.Size(178, 13);
			this.ProgressBar3.Step = 1;
			this.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar3.TabIndex = 2;
			this.ProgressBar3.Value = 512;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.ProgressBar3);
			this.GroupBox1.Controls.Add(this.ProgressBar1);
			this.GroupBox1.Controls.Add(this.ProgressBar2);
			this.GroupBox1.Location = new System.Drawing.Point(12, 259);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(254, 78);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Analog Inputs";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(28, 56);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(31, 13);
			this.Label6.TabIndex = 8;
			this.Label6.Text = "1023";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(28, 38);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(31, 13);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "1023";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(28, 19);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(31, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "1023";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 56);
			this.Label3.Name = "label3";
			this.Label3.Size = new System.Drawing.Size(16, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "3:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 38);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(16, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "2:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(16, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "1:";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.ButtonAllOff);
			this.GroupBox2.Controls.Add(this.ButtonAllOn);
			this.GroupBox2.Controls.Add(this.ButtonToggle8);
			this.GroupBox2.Controls.Add(this.ButtonToggle7);
			this.GroupBox2.Controls.Add(this.ButtonToggle6);
			this.GroupBox2.Controls.Add(this.ButtonToggle5);
			this.GroupBox2.Controls.Add(this.ButtonToggle3);
			this.GroupBox2.Controls.Add(this.ButtonToggle4);
			this.GroupBox2.Controls.Add(this.ButtonToggle2);
			this.GroupBox2.Controls.Add(this.ButtonToggle1);
			this.GroupBox2.Location = new System.Drawing.Point(122, 90);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(144, 163);
			this.GroupBox2.TabIndex = 5;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Relays";
			//
			//ButtonAllOff
			//
			this.ButtonAllOff.BackColor = System.Drawing.SystemColors.Control;
			this.ButtonAllOff.Location = new System.Drawing.Point(74, 131);
			this.ButtonAllOff.Name = "ButtonAllOff";
			this.ButtonAllOff.Size = new System.Drawing.Size(62, 22);
			this.ButtonAllOff.TabIndex = 1;
			this.ButtonAllOff.Text = "ALL OFF";
			this.ButtonAllOff.UseVisualStyleBackColor = false;
			//
			//ButtonAllOn
			//
			this.ButtonAllOn.BackColor = System.Drawing.SystemColors.Control;
			this.ButtonAllOn.Location = new System.Drawing.Point(6, 131);
			this.ButtonAllOn.Name = "ButtonAllOn";
			this.ButtonAllOn.Size = new System.Drawing.Size(62, 22);
			this.ButtonAllOn.TabIndex = 1;
			this.ButtonAllOn.Text = "ALL ON";
			this.ButtonAllOn.UseVisualStyleBackColor = false;
			//
			//ButtonToggle8
			//
			this.ButtonToggle8.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle8.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle8.Location = new System.Drawing.Point(74, 103);
			this.ButtonToggle8.Name = "ButtonToggle8";
			this.ButtonToggle8.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle8.TabIndex = 1;
			this.ButtonToggle8.Text = "Toggle 8";
			this.ButtonToggle8.UseVisualStyleBackColor = false;
			//
			//ButtonToggle7
			//
			this.ButtonToggle7.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle7.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle7.Location = new System.Drawing.Point(74, 75);
			this.ButtonToggle7.Name = "ButtonToggle7";
			this.ButtonToggle7.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle7.TabIndex = 1;
			this.ButtonToggle7.Text = "Toggle 7";
			this.ButtonToggle7.UseVisualStyleBackColor = false;
			//
			//ButtonToggle6
			//
			this.ButtonToggle6.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle6.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle6.Location = new System.Drawing.Point(74, 47);
			this.ButtonToggle6.Name = "ButtonToggle6";
			this.ButtonToggle6.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle6.TabIndex = 1;
			this.ButtonToggle6.Text = "Toggle 6";
			this.ButtonToggle6.UseVisualStyleBackColor = false;
			//
			//ButtonToggle5
			//
			this.ButtonToggle5.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle5.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle5.Location = new System.Drawing.Point(74, 19);
			this.ButtonToggle5.Name = "ButtonToggle5";
			this.ButtonToggle5.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle5.TabIndex = 1;
			this.ButtonToggle5.Text = "Toggle 5";
			this.ButtonToggle5.UseVisualStyleBackColor = false;
			//
			//ButtonToggle3
			//
			this.ButtonToggle3.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle3.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle3.Location = new System.Drawing.Point(6, 75);
			this.ButtonToggle3.Name = "ButtonToggle3";
			this.ButtonToggle3.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle3.TabIndex = 1;
			this.ButtonToggle3.Text = "Toggle 3";
			this.ButtonToggle3.UseVisualStyleBackColor = false;
			//
			//ButtonToggle4
			//
			this.ButtonToggle4.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle4.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle4.Location = new System.Drawing.Point(6, 103);
			this.ButtonToggle4.Name = "ButtonToggle4";
			this.ButtonToggle4.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle4.TabIndex = 1;
			this.ButtonToggle4.Text = "Toggle 4";
			this.ButtonToggle4.UseVisualStyleBackColor = false;
			//
			//ButtonToggle2
			//
			this.ButtonToggle2.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle2.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle2.Location = new System.Drawing.Point(6, 47);
			this.ButtonToggle2.Name = "ButtonToggle2";
			this.ButtonToggle2.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle2.TabIndex = 1;
			this.ButtonToggle2.Text = "Toggle 2";
			this.ButtonToggle2.UseVisualStyleBackColor = false;
			//
			//ButtonToggle1
			//
			this.ButtonToggle1.BackColor = System.Drawing.Color.Red;
			this.ButtonToggle1.ForeColor = System.Drawing.Color.White;
			this.ButtonToggle1.Location = new System.Drawing.Point(6, 19);
			this.ButtonToggle1.Name = "ButtonToggle1";
			this.ButtonToggle1.Size = new System.Drawing.Size(62, 22);
			this.ButtonToggle1.TabIndex = 0;
			this.ButtonToggle1.Text = "Toggle 1";
			this.ButtonToggle1.UseVisualStyleBackColor = false;
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.Red;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Location = new System.Drawing.Point(50, 28);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(25, 15);
			this.Panel1.TabIndex = 6;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Panel4);
			this.GroupBox3.Controls.Add(this.Panel3);
			this.GroupBox3.Controls.Add(this.Panel2);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.Label7);
			this.GroupBox3.Controls.Add(this.Label8);
			this.GroupBox3.Controls.Add(this.Label9);
			this.GroupBox3.Controls.Add(this.Panel1);
			this.GroupBox3.Location = new System.Drawing.Point(12, 137);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(104, 116);
			this.GroupBox3.TabIndex = 7;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Digital Inputs";
			//
			//Panel4
			//
			this.Panel4.BackColor = System.Drawing.Color.Red;
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Location = new System.Drawing.Point(50, 84);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(25, 15);
			this.Panel4.TabIndex = 7;
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.Color.Red;
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel3.Location = new System.Drawing.Point(50, 65);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(25, 15);
			this.Panel3.TabIndex = 7;
			//
			//Panel2
			//
			this.Panel2.BackColor = System.Drawing.Color.Red;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Location = new System.Drawing.Point(50, 47);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(25, 15);
			this.Panel2.TabIndex = 7;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(28, 84);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(16, 13);
			this.Label10.TabIndex = 10;
			this.Label10.Text = "4:";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(28, 65);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(16, 13);
			this.Label7.TabIndex = 9;
			this.Label7.Text = "3:";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(28, 47);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(16, 13);
			this.Label8.TabIndex = 8;
			this.Label8.Text = "2:";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(28, 28);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(16, 13);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "1:";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.ButtonChangeAddr);
			this.GroupBox4.Controls.Add(this.txtNewAddr);
			this.GroupBox4.Location = new System.Drawing.Point(12, 90);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(103, 40);
			this.GroupBox4.TabIndex = 8;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Address";
			//
			//ButtonChangeAddr
			//
			this.ButtonChangeAddr.Location = new System.Drawing.Point(39, 14);
			this.ButtonChangeAddr.Name = "ButtonChangeAddr";
			this.ButtonChangeAddr.Size = new System.Drawing.Size(58, 20);
			this.ButtonChangeAddr.TabIndex = 1;
			this.ButtonChangeAddr.Text = "Change";
			this.ButtonChangeAddr.UseVisualStyleBackColor = true;
			//
			//txtNewAddr
			//
			this.txtNewAddr.Location = new System.Drawing.Point(6, 14);
			this.txtNewAddr.MaxLength = 2;
			this.txtNewAddr.Name = "txtNewAddr";
			this.txtNewAddr.Size = new System.Drawing.Size(27, 20);
			this.txtNewAddr.TabIndex = 0;
			this.txtNewAddr.Text = "1";
			this.txtNewAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//GroupBox5
			//
			this.GroupBox5.Controls.Add(this.ButtonOpenPort);
			this.GroupBox5.Controls.Add(this.ButtonBaud);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.Controls.Add(this.txtRX);
			this.GroupBox5.Controls.Add(this.txtTX);
			this.GroupBox5.Controls.Add(this.Label12);
			this.GroupBox5.Controls.Add(this.TextBoxAddr);
			this.GroupBox5.Controls.Add(this.Label11);
			this.GroupBox5.Controls.Add(this.TextBoxPort);
			this.GroupBox5.Location = new System.Drawing.Point(12, 12);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(254, 72);
			this.GroupBox5.TabIndex = 9;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Comms";
			//
			//ButtonOpenPort
			//
			this.ButtonOpenPort.Location = new System.Drawing.Point(66, 18);
			this.ButtonOpenPort.Name = "ButtonOpenPort";
			this.ButtonOpenPort.Size = new System.Drawing.Size(45, 20);
			this.ButtonOpenPort.TabIndex = 16;
			this.ButtonOpenPort.Text = "Open";
			this.ButtonOpenPort.UseVisualStyleBackColor = true;
			//
			//ButtonBaud
			//
			this.ButtonBaud.Location = new System.Drawing.Point(117, 18);
			this.ButtonBaud.Name = "ButtonBaud";
			this.ButtonBaud.Size = new System.Drawing.Size(43, 20);
			this.ButtonBaud.TabIndex = 15;
			this.ButtonBaud.Text = "Baud";
			this.ButtonBaud.UseVisualStyleBackColor = true;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(129, 48);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(25, 13);
			this.Label14.TabIndex = 14;
			this.Label14.Text = "RX:";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(9, 48);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(24, 13);
			this.Label13.TabIndex = 13;
			this.Label13.Text = "TX:";
			//
			//txtRX
			//
			this.txtRX.Enabled = false;
			this.txtRX.Location = new System.Drawing.Point(160, 45);
			this.txtRX.Name = "txtRX";
			this.txtRX.Size = new System.Drawing.Size(86, 20);
			this.txtRX.TabIndex = 12;
			//
			//txtTX
			//
			this.txtTX.Enabled = false;
			this.txtTX.Location = new System.Drawing.Point(39, 44);
			this.txtTX.Name = "txtTX";
			this.txtTX.Size = new System.Drawing.Size(86, 20);
			this.txtTX.TabIndex = 11;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(166, 21);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(48, 13);
			this.Label12.TabIndex = 10;
			this.Label12.Text = "Address:";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBoxAddr
			//
			this.TextBoxAddr.Location = new System.Drawing.Point(218, 18);
			this.TextBoxAddr.MaxLength = 2;
			this.TextBoxAddr.Name = "TextBoxAddr";
			this.TextBoxAddr.Size = new System.Drawing.Size(28, 20);
			this.TextBoxAddr.TabIndex = 9;
			this.TextBoxAddr.Text = "0";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(6, 21);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(29, 13);
			this.Label11.TabIndex = 8;
			this.Label11.Text = "Port:";
			//
			//TextBoxPort
			//
			this.TextBoxPort.Location = new System.Drawing.Point(38, 18);
			this.TextBoxPort.MaxLength = 2;
			this.TextBoxPort.Name = "TextBoxPort";
			this.TextBoxPort.Size = new System.Drawing.Size(21, 20);
			this.TextBoxPort.TabIndex = 0;
			this.TextBoxPort.Text = "1";
			//
			//Timer2
			//
			this.Timer2.Enabled = true;
			this.Timer2.Interval = 250;
			//
			//Timer3
			//
			this.Timer3.Enabled = true;
			this.Timer3.Interval = 500;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(280, 347);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relay Tester";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.IO.Ports.SerialPort SerialPort1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.ProgressBar ProgressBar2;
		internal System.Windows.Forms.ProgressBar ProgressBar3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button ButtonToggle1;
		internal System.Windows.Forms.Button ButtonToggle8;
		internal System.Windows.Forms.Button ButtonToggle7;
		internal System.Windows.Forms.Button ButtonToggle6;
		internal System.Windows.Forms.Button ButtonToggle5;
		internal System.Windows.Forms.Button ButtonToggle3;
		internal System.Windows.Forms.Button ButtonToggle4;
		internal System.Windows.Forms.Button ButtonToggle2;
		internal System.Windows.Forms.Button ButtonAllOff;
		internal System.Windows.Forms.Button ButtonAllOn;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button ButtonChangeAddr;
		internal System.Windows.Forms.TextBox txtNewAddr;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox TextBoxPort;
		
		private void GroupBox5_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox TextBoxAddr;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtRX;
		internal System.Windows.Forms.TextBox txtTX;
		internal System.Windows.Forms.Button ButtonBaud;
		
		private void Button12_Click(System.Object sender, System.EventArgs e)
		{
			FormBaud formBaud = new FormBaud();
			formBaud.Show();
		}
		
		private void TextBox2_TextChanged(System.Object sender, System.EventArgs e)
		{
			//My.Settings.Default.Port = TextBoxPort.Text;
		}
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			//TextBoxPort.Text = System.Convert.ToString(My.Settings.Default.Port);
			//Try
			//    SerialPort1.PortName = "COM" & TextBox2.Text
			//    SerialPort1.BaudRate = 9600
			//    SerialPort1.Open()
			//Catch ex As Exception
			//    MsgBox("Error Opening " & SerialPort1.PortName)
			//End Try
			
		}
		
		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			string mychar = "";
			try
			{
				if (SerialPort1.IsOpen)
				{
					while (SerialPort1.BytesToRead > 0)
					{
						mychar = System.Convert.ToString(Strings.Chr(SerialPort1.ReadByte()));
						if (mychar == "#")
						{
							txtRX.Text = "";
						}
						else
						{
							if (char.Parse(mychar) == '\r' || char.Parse(mychar) == '\n')
							{
								Module1.Monitor(txtRX.Text);
								//rxOn = False
								Module1.txNext = true;
							}
							else
							{
								txtRX.Text = txtRX.Text + mychar;
							}
						}
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		
		private void Toggle1_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle1.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 1";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 1";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle2.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 2";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 2";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle3.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 3";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 3";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle4.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 4";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 4";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle5.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 5";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 5";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle6.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 6";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 6";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle7.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 7";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 7";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button8_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					if (ButtonToggle8.BackColor == Color.Red)
					{
						outstr = "@" + addr + " ON 8";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
					else
					{
						outstr = "@" + addr + " OF 8";
						txtTX.Text = outstr;
						outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
						SerialPort1.Write(outstr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button9_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					outstr = "@" + addr + " ON 0";
					txtTX.Text = outstr;
					outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
					SerialPort1.Write(outstr);
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button10_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					outstr = "@" + addr + " OF 0";
					txtTX.Text = outstr;
					outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
					SerialPort1.Write(outstr);
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		private void Button11_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(TextBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr = addr + TextBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					outstr = "@" + addr + " SA ";
					if (double.Parse(txtNewAddr.Text) < 10)
					{
						outstr = outstr + "0";
					}
					outstr = outstr + txtNewAddr.Text;
					txtTX.Text = outstr;
					outstr = outstr + System.Convert.ToString("\r"); //vbNewLine
					SerialPort1.Write(outstr);
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
				
			}
		}
		internal System.Windows.Forms.Timer Timer2;
		
		private void Timer2_Tick(System.Object sender, System.EventArgs e)
		{
			string mystr = "";
			//Static SorI As Byte
			try
			{
				if (Module1.txNext == true)
				{
					Module1.SorI++;
					if (Module1.SorI == 3)
					{
						Module1.SorI = (byte) 0;
					}
					mystr = "";
					//If Option1(2).Value = True Then
					if (double.Parse(TextBoxAddr.Text) < 10)
					{
						mystr = "@0" + TextBoxAddr.Text + " ";
					}
					else
					{
						mystr = "@" + TextBoxAddr.Text + " ";
					}
					//End If
					if (Module1.SorI == ((byte) 0))
					{
						mystr = mystr + "RS 0";
						Module1.txNext = false;
					}
					else if (Module1.SorI == ((byte) 1))
					{
						mystr = mystr + "IS 0";
						Module1.txNext = false;
					}
					else if (Module1.SorI == ((byte) 2))
					{
						mystr = mystr + "AI 0";
						Module1.txNext = false;
					}
					txtTX.Text = mystr;
					mystr = mystr + System.Convert.ToString("\r"); //vbNewLine
					if (SerialPort1.IsOpen)
					{
						SerialPort1.Write(mystr);
					}
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error Writing to Port " + SerialPort1.PortName);
				
			}
		}
		internal System.Windows.Forms.Timer Timer3;
		
		private void Timer3_Tick(System.Object sender, System.EventArgs e)
		{
			if (Module1.txNext != true)
			{
				Module1.txNext = true;
			}
		}
		
		internal System.Windows.Forms.Button ButtonOpenPort;
	}
	
}
