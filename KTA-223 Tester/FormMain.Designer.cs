namespace WindowsFormsApp1
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.buttonOpenPort = new System.Windows.Forms.Button();
			this.buttonBaud = new System.Windows.Forms.Button();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.textBoxRX = new System.Windows.Forms.TextBox();
			this.textBoxTX = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.textBoxAddr = new System.Windows.Forms.TextBox();
			this.labelPort = new System.Windows.Forms.Label();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.buttonChangeAddr = new System.Windows.Forms.Button();
			this.textBoxNewAddr = new System.Windows.Forms.TextBox();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Timer3 = new System.Windows.Forms.Timer(this.components);
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonAllOff = new System.Windows.Forms.Button();
			this.buttonAllOn = new System.Windows.Forms.Button();
			this.buttonToggle8 = new System.Windows.Forms.Button();
			this.buttonToggle7 = new System.Windows.Forms.Button();
			this.buttonToggle6 = new System.Windows.Forms.Button();
			this.buttonToggle5 = new System.Windows.Forms.Button();
			this.buttonToggle3 = new System.Windows.Forms.Button();
			this.buttonToggle4 = new System.Windows.Forms.Button();
			this.buttonToggle2 = new System.Windows.Forms.Button();
			this.buttonToggle1 = new System.Windows.Forms.Button();
			this.GroupBox5.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox5
			// 
			this.GroupBox5.Controls.Add(this.buttonOpenPort);
			this.GroupBox5.Controls.Add(this.buttonBaud);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.Controls.Add(this.textBoxRX);
			this.GroupBox5.Controls.Add(this.textBoxTX);
			this.GroupBox5.Controls.Add(this.Label12);
			this.GroupBox5.Controls.Add(this.textBoxAddr);
			this.GroupBox5.Controls.Add(this.labelPort);
			this.GroupBox5.Controls.Add(this.textBoxPort);
			this.GroupBox5.Location = new System.Drawing.Point(12, 12);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(254, 72);
			this.GroupBox5.TabIndex = 14;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Comms";
			// 
			// buttonOpenPort
			// 
			this.buttonOpenPort.Location = new System.Drawing.Point(66, 18);
			this.buttonOpenPort.Name = "buttonOpenPort";
			this.buttonOpenPort.Size = new System.Drawing.Size(45, 20);
			this.buttonOpenPort.TabIndex = 16;
			this.buttonOpenPort.Text = "Open";
			this.buttonOpenPort.UseVisualStyleBackColor = true;
			this.buttonOpenPort.Click += new System.EventHandler(this.ButtonOpenPort_Click);
			// 
			// buttonBaud
			// 
			this.buttonBaud.Location = new System.Drawing.Point(117, 18);
			this.buttonBaud.Name = "buttonBaud";
			this.buttonBaud.Size = new System.Drawing.Size(43, 20);
			this.buttonBaud.TabIndex = 15;
			this.buttonBaud.Text = "Baud";
			this.buttonBaud.UseVisualStyleBackColor = true;
			this.buttonBaud.Click += new System.EventHandler(this.ButtonBaud_Click);
			// 
			// Label14
			// 
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(129, 48);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(25, 13);
			this.Label14.TabIndex = 14;
			this.Label14.Text = "RX:";
			// 
			// Label13
			// 
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(9, 48);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(24, 13);
			this.Label13.TabIndex = 13;
			this.Label13.Text = "TX:";
			// 
			// textBoxRX
			// 
			this.textBoxRX.Enabled = false;
			this.textBoxRX.Location = new System.Drawing.Point(160, 45);
			this.textBoxRX.Name = "textBoxRX";
			this.textBoxRX.Size = new System.Drawing.Size(86, 20);
			this.textBoxRX.TabIndex = 12;
			// 
			// textBoxTX
			// 
			this.textBoxTX.Enabled = false;
			this.textBoxTX.Location = new System.Drawing.Point(39, 44);
			this.textBoxTX.Name = "textBoxTX";
			this.textBoxTX.Size = new System.Drawing.Size(86, 20);
			this.textBoxTX.TabIndex = 11;
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(166, 21);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(48, 13);
			this.Label12.TabIndex = 10;
			this.Label12.Text = "Address:";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxAddr
			// 
			this.textBoxAddr.Location = new System.Drawing.Point(218, 18);
			this.textBoxAddr.MaxLength = 2;
			this.textBoxAddr.Name = "textBoxAddr";
			this.textBoxAddr.Size = new System.Drawing.Size(28, 20);
			this.textBoxAddr.TabIndex = 9;
			this.textBoxAddr.Text = "0";
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(6, 21);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(29, 13);
			this.labelPort.TabIndex = 8;
			this.labelPort.Text = "Port:";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(38, 18);
			this.textBoxPort.MaxLength = 2;
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(21, 20);
			this.textBoxPort.TabIndex = 0;
			this.textBoxPort.Text = "1";
			this.textBoxPort.TextChanged += new System.EventHandler(this.TextBoxPort_TextChanged);
			// 
			// Panel3
			// 
			this.Panel3.BackColor = System.Drawing.Color.Red;
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel3.Location = new System.Drawing.Point(50, 65);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(25, 15);
			this.Panel3.TabIndex = 7;
			// 
			// Panel2
			// 
			this.Panel2.BackColor = System.Drawing.Color.Red;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Location = new System.Drawing.Point(50, 47);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(25, 15);
			this.Panel2.TabIndex = 7;
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(28, 84);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(16, 13);
			this.Label10.TabIndex = 10;
			this.Label10.Text = "4:";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(28, 65);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(16, 13);
			this.Label7.TabIndex = 9;
			this.Label7.Text = "3:";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(28, 47);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(16, 13);
			this.Label8.TabIndex = 8;
			this.Label8.Text = "2:";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(28, 28);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(16, 13);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "1:";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.buttonChangeAddr);
			this.GroupBox4.Controls.Add(this.textBoxNewAddr);
			this.GroupBox4.Location = new System.Drawing.Point(12, 90);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(103, 40);
			this.GroupBox4.TabIndex = 13;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Address";
			// 
			// buttonChangeAddr
			// 
			this.buttonChangeAddr.Location = new System.Drawing.Point(39, 14);
			this.buttonChangeAddr.Name = "buttonChangeAddr";
			this.buttonChangeAddr.Size = new System.Drawing.Size(58, 20);
			this.buttonChangeAddr.TabIndex = 1;
			this.buttonChangeAddr.Text = "Change";
			this.buttonChangeAddr.UseVisualStyleBackColor = true;
			this.buttonChangeAddr.Click += new System.EventHandler(this.ButtonChangeAddr_Click);
			// 
			// textBoxNewAddr
			// 
			this.textBoxNewAddr.Location = new System.Drawing.Point(6, 14);
			this.textBoxNewAddr.MaxLength = 2;
			this.textBoxNewAddr.Name = "textBoxNewAddr";
			this.textBoxNewAddr.Size = new System.Drawing.Size(27, 20);
			this.textBoxNewAddr.TabIndex = 0;
			this.textBoxNewAddr.Text = "1";
			this.textBoxNewAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Panel4
			// 
			this.Panel4.BackColor = System.Drawing.Color.Red;
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Location = new System.Drawing.Point(50, 84);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(25, 15);
			this.Panel4.TabIndex = 7;
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.Panel4);
			this.GroupBox3.Controls.Add(this.Panel3);
			this.GroupBox3.Controls.Add(this.Panel2);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.Label7);
			this.GroupBox3.Controls.Add(this.Label8);
			this.GroupBox3.Controls.Add(this.Label9);
			this.GroupBox3.Controls.Add(this.panel1);
			this.GroupBox3.Location = new System.Drawing.Point(12, 137);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(104, 116);
			this.GroupBox3.TabIndex = 12;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Digital Inputs";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(50, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(25, 15);
			this.panel1.TabIndex = 6;
			// 
			// Timer3
			// 
			this.Timer3.Enabled = true;
			this.Timer3.Interval = 500;
			this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
			// 
			// Timer1
			// 
			this.Timer1.Enabled = true;
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.label6);
			this.GroupBox1.Controls.Add(this.label5);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.progressBar3);
			this.GroupBox1.Controls.Add(this.progressBar1);
			this.GroupBox1.Controls.Add(this.progressBar2);
			this.GroupBox1.Location = new System.Drawing.Point(12, 259);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(254, 78);
			this.GroupBox1.TabIndex = 10;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Analog Inputs";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "1023";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "1023";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "1023";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(16, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "3:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 38);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(16, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "2:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(16, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "1:";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(70, 56);
			this.progressBar3.Maximum = 1023;
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(178, 13);
			this.progressBar3.Step = 1;
			this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar3.TabIndex = 2;
			this.progressBar3.Value = 512;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(70, 19);
			this.progressBar1.Maximum = 1023;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(178, 13);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Value = 512;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(70, 38);
			this.progressBar2.Maximum = 1023;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(178, 13);
			this.progressBar2.Step = 1;
			this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar2.TabIndex = 1;
			this.progressBar2.Value = 512;
			// 
			// Timer2
			// 
			this.Timer2.Enabled = true;
			this.Timer2.Interval = 250;
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.buttonAllOff);
			this.GroupBox2.Controls.Add(this.buttonAllOn);
			this.GroupBox2.Controls.Add(this.buttonToggle8);
			this.GroupBox2.Controls.Add(this.buttonToggle7);
			this.GroupBox2.Controls.Add(this.buttonToggle6);
			this.GroupBox2.Controls.Add(this.buttonToggle5);
			this.GroupBox2.Controls.Add(this.buttonToggle3);
			this.GroupBox2.Controls.Add(this.buttonToggle4);
			this.GroupBox2.Controls.Add(this.buttonToggle2);
			this.GroupBox2.Controls.Add(this.buttonToggle1);
			this.GroupBox2.Location = new System.Drawing.Point(122, 90);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(144, 163);
			this.GroupBox2.TabIndex = 11;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Relays";
			// 
			// buttonAllOff
			// 
			this.buttonAllOff.BackColor = System.Drawing.SystemColors.Control;
			this.buttonAllOff.Location = new System.Drawing.Point(74, 131);
			this.buttonAllOff.Name = "buttonAllOff";
			this.buttonAllOff.Size = new System.Drawing.Size(62, 22);
			this.buttonAllOff.TabIndex = 1;
			this.buttonAllOff.Text = "ALL OFF";
			this.buttonAllOff.UseVisualStyleBackColor = false;
			this.buttonAllOff.Click += new System.EventHandler(this.ButtonAllOff_Click);
			// 
			// buttonAllOn
			// 
			this.buttonAllOn.BackColor = System.Drawing.SystemColors.Control;
			this.buttonAllOn.Location = new System.Drawing.Point(6, 131);
			this.buttonAllOn.Name = "buttonAllOn";
			this.buttonAllOn.Size = new System.Drawing.Size(62, 22);
			this.buttonAllOn.TabIndex = 1;
			this.buttonAllOn.Text = "ALL ON";
			this.buttonAllOn.UseVisualStyleBackColor = false;
			this.buttonAllOn.Click += new System.EventHandler(this.ButtonAllOn_Click);
			// 
			// buttonToggle8
			// 
			this.buttonToggle8.BackColor = System.Drawing.Color.Red;
			this.buttonToggle8.ForeColor = System.Drawing.Color.White;
			this.buttonToggle8.Location = new System.Drawing.Point(74, 103);
			this.buttonToggle8.Name = "buttonToggle8";
			this.buttonToggle8.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle8.TabIndex = 1;
			this.buttonToggle8.Text = "Toggle 8";
			this.buttonToggle8.UseVisualStyleBackColor = false;
			this.buttonToggle8.Click += new System.EventHandler(this.ButtonToggle8_Click);
			// 
			// buttonToggle7
			// 
			this.buttonToggle7.BackColor = System.Drawing.Color.Red;
			this.buttonToggle7.ForeColor = System.Drawing.Color.White;
			this.buttonToggle7.Location = new System.Drawing.Point(74, 75);
			this.buttonToggle7.Name = "buttonToggle7";
			this.buttonToggle7.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle7.TabIndex = 1;
			this.buttonToggle7.Text = "Toggle 7";
			this.buttonToggle7.UseVisualStyleBackColor = false;
			this.buttonToggle7.Click += new System.EventHandler(this.ButtonToggle7_Click);
			// 
			// buttonToggle6
			// 
			this.buttonToggle6.BackColor = System.Drawing.Color.Red;
			this.buttonToggle6.ForeColor = System.Drawing.Color.White;
			this.buttonToggle6.Location = new System.Drawing.Point(74, 47);
			this.buttonToggle6.Name = "buttonToggle6";
			this.buttonToggle6.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle6.TabIndex = 1;
			this.buttonToggle6.Text = "Toggle 6";
			this.buttonToggle6.UseVisualStyleBackColor = false;
			this.buttonToggle6.Click += new System.EventHandler(this.ButtonToggle6_Click);
			// 
			// buttonToggle5
			// 
			this.buttonToggle5.BackColor = System.Drawing.Color.Red;
			this.buttonToggle5.ForeColor = System.Drawing.Color.White;
			this.buttonToggle5.Location = new System.Drawing.Point(74, 19);
			this.buttonToggle5.Name = "buttonToggle5";
			this.buttonToggle5.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle5.TabIndex = 1;
			this.buttonToggle5.Text = "Toggle 5";
			this.buttonToggle5.UseVisualStyleBackColor = false;
			this.buttonToggle5.Click += new System.EventHandler(this.ButtonToggle5_Click);
			// 
			// buttonToggle3
			// 
			this.buttonToggle3.BackColor = System.Drawing.Color.Red;
			this.buttonToggle3.ForeColor = System.Drawing.Color.White;
			this.buttonToggle3.Location = new System.Drawing.Point(6, 75);
			this.buttonToggle3.Name = "buttonToggle3";
			this.buttonToggle3.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle3.TabIndex = 1;
			this.buttonToggle3.Text = "Toggle 3";
			this.buttonToggle3.UseVisualStyleBackColor = false;
			this.buttonToggle3.Click += new System.EventHandler(this.ButtonToggle3_Click);
			// 
			// buttonToggle4
			// 
			this.buttonToggle4.BackColor = System.Drawing.Color.Red;
			this.buttonToggle4.ForeColor = System.Drawing.Color.White;
			this.buttonToggle4.Location = new System.Drawing.Point(6, 103);
			this.buttonToggle4.Name = "buttonToggle4";
			this.buttonToggle4.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle4.TabIndex = 1;
			this.buttonToggle4.Text = "Toggle 4";
			this.buttonToggle4.UseVisualStyleBackColor = false;
			this.buttonToggle4.Click += new System.EventHandler(this.ButtonToggle4_Click);
			// 
			// buttonToggle2
			// 
			this.buttonToggle2.BackColor = System.Drawing.Color.Red;
			this.buttonToggle2.ForeColor = System.Drawing.Color.White;
			this.buttonToggle2.Location = new System.Drawing.Point(6, 47);
			this.buttonToggle2.Name = "buttonToggle2";
			this.buttonToggle2.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle2.TabIndex = 1;
			this.buttonToggle2.Text = "Toggle 2";
			this.buttonToggle2.UseVisualStyleBackColor = false;
			this.buttonToggle2.Click += new System.EventHandler(this.ButtonToggle2_Click);
			// 
			// buttonToggle1
			// 
			this.buttonToggle1.BackColor = System.Drawing.Color.Red;
			this.buttonToggle1.ForeColor = System.Drawing.Color.White;
			this.buttonToggle1.Location = new System.Drawing.Point(6, 19);
			this.buttonToggle1.Name = "buttonToggle1";
			this.buttonToggle1.Size = new System.Drawing.Size(62, 22);
			this.buttonToggle1.TabIndex = 0;
			this.buttonToggle1.Text = "Toggle 1";
			this.buttonToggle1.UseVisualStyleBackColor = false;
			this.buttonToggle1.Click += new System.EventHandler(this.ButtonToggle1_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 347);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GroupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Relay Tester";
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.Button buttonOpenPort;
		internal System.Windows.Forms.Button buttonBaud;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox textBoxRX;
		internal System.Windows.Forms.TextBox textBoxTX;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox textBoxAddr;
		internal System.Windows.Forms.Label labelPort;
		internal System.Windows.Forms.TextBox textBoxPort;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button buttonChangeAddr;
		internal System.Windows.Forms.TextBox textBoxNewAddr;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Panel panel1;
		internal System.Windows.Forms.Timer Timer3;
		internal System.IO.Ports.SerialPort SerialPort1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ProgressBar progressBar3;
		internal System.Windows.Forms.ProgressBar progressBar1;
		internal System.Windows.Forms.ProgressBar progressBar2;
		internal System.Windows.Forms.Timer Timer2;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button buttonAllOff;
		internal System.Windows.Forms.Button buttonAllOn;
		internal System.Windows.Forms.Button buttonToggle8;
		internal System.Windows.Forms.Button buttonToggle7;
		internal System.Windows.Forms.Button buttonToggle6;
		internal System.Windows.Forms.Button buttonToggle5;
		internal System.Windows.Forms.Button buttonToggle3;
		internal System.Windows.Forms.Button buttonToggle4;
		internal System.Windows.Forms.Button buttonToggle2;
		internal System.Windows.Forms.Button buttonToggle1;
	}
}