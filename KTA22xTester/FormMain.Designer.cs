namespace KTA22xTester
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			GroupBox5 = new GroupBox();
			buttonOpenPort = new Button();
			buttonBaud = new Button();
			Label14 = new Label();
			Label13 = new Label();
			textBoxRX = new TextBox();
			textBoxTX = new TextBox();
			Label12 = new Label();
			textBoxAddr = new TextBox();
			labelPort = new Label();
			textBoxPort = new TextBox();
			Panel3 = new Panel();
			Panel2 = new Panel();
			Label10 = new Label();
			Label7 = new Label();
			Label8 = new Label();
			Label9 = new Label();
			GroupBox4 = new GroupBox();
			buttonChangeAddr = new Button();
			textBoxNewAddr = new TextBox();
			Panel4 = new Panel();
			GroupBox3 = new GroupBox();
			panel1 = new Panel();
			Timer3 = new System.Windows.Forms.Timer(components);
			Timer1 = new System.Windows.Forms.Timer(components);
			GroupBox1 = new GroupBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			progressBar3 = new ProgressBar();
			progressBar1 = new ProgressBar();
			progressBar2 = new ProgressBar();
			Timer2 = new System.Windows.Forms.Timer(components);
			GroupBox2 = new GroupBox();
			buttonAllOff = new Button();
			buttonAllOn = new Button();
			buttonToggle8 = new Button();
			buttonToggle7 = new Button();
			buttonToggle6 = new Button();
			buttonToggle5 = new Button();
			buttonToggle3 = new Button();
			buttonToggle4 = new Button();
			buttonToggle2 = new Button();
			buttonToggle1 = new Button();
			GroupBox5.SuspendLayout();
			GroupBox4.SuspendLayout();
			GroupBox3.SuspendLayout();
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// GroupBox5
			// 
			GroupBox5.Controls.Add(buttonOpenPort);
			GroupBox5.Controls.Add(buttonBaud);
			GroupBox5.Controls.Add(Label14);
			GroupBox5.Controls.Add(Label13);
			GroupBox5.Controls.Add(textBoxRX);
			GroupBox5.Controls.Add(textBoxTX);
			GroupBox5.Controls.Add(Label12);
			GroupBox5.Controls.Add(textBoxAddr);
			GroupBox5.Controls.Add(labelPort);
			GroupBox5.Controls.Add(textBoxPort);
			GroupBox5.Location = new Point(14, 14);
			GroupBox5.Margin = new Padding(4, 3, 4, 3);
			GroupBox5.Name = "GroupBox5";
			GroupBox5.Padding = new Padding(4, 3, 4, 3);
			GroupBox5.Size = new Size(296, 83);
			GroupBox5.TabIndex = 14;
			GroupBox5.TabStop = false;
			GroupBox5.Text = "Comms";
			// 
			// buttonOpenPort
			// 
			buttonOpenPort.Location = new Point(77, 21);
			buttonOpenPort.Margin = new Padding(4, 3, 4, 3);
			buttonOpenPort.Name = "buttonOpenPort";
			buttonOpenPort.Size = new Size(52, 23);
			buttonOpenPort.TabIndex = 16;
			buttonOpenPort.Text = "Open";
			buttonOpenPort.UseVisualStyleBackColor = true;
			buttonOpenPort.Click += ButtonOpenPort_Click;
			// 
			// buttonBaud
			// 
			buttonBaud.Location = new Point(136, 21);
			buttonBaud.Margin = new Padding(4, 3, 4, 3);
			buttonBaud.Name = "buttonBaud";
			buttonBaud.Size = new Size(50, 23);
			buttonBaud.TabIndex = 15;
			buttonBaud.Text = "Baud";
			buttonBaud.UseVisualStyleBackColor = true;
			buttonBaud.Click += ButtonBaud_Click;
			// 
			// Label14
			// 
			Label14.AutoSize = true;
			Label14.Location = new Point(150, 55);
			Label14.Margin = new Padding(4, 0, 4, 0);
			Label14.Name = "Label14";
			Label14.Size = new Size(24, 15);
			Label14.TabIndex = 14;
			Label14.Text = "RX:";
			// 
			// Label13
			// 
			Label13.AutoSize = true;
			Label13.Location = new Point(10, 55);
			Label13.Margin = new Padding(4, 0, 4, 0);
			Label13.Name = "Label13";
			Label13.Size = new Size(23, 15);
			Label13.TabIndex = 13;
			Label13.Text = "TX:";
			// 
			// textBoxRX
			// 
			textBoxRX.Enabled = false;
			textBoxRX.Location = new Point(187, 52);
			textBoxRX.Margin = new Padding(4, 3, 4, 3);
			textBoxRX.Name = "textBoxRX";
			textBoxRX.Size = new Size(100, 23);
			textBoxRX.TabIndex = 12;
			// 
			// textBoxTX
			// 
			textBoxTX.Enabled = false;
			textBoxTX.Location = new Point(46, 51);
			textBoxTX.Margin = new Padding(4, 3, 4, 3);
			textBoxTX.Name = "textBoxTX";
			textBoxTX.Size = new Size(100, 23);
			textBoxTX.TabIndex = 11;
			// 
			// Label12
			// 
			Label12.AutoSize = true;
			Label12.Location = new Point(194, 24);
			Label12.Margin = new Padding(4, 0, 4, 0);
			Label12.Name = "Label12";
			Label12.Size = new Size(52, 15);
			Label12.TabIndex = 10;
			Label12.Text = "Address:";
			Label12.TextAlign = ContentAlignment.MiddleRight;
			// 
			// textBoxAddr
			// 
			textBoxAddr.Location = new Point(254, 21);
			textBoxAddr.Margin = new Padding(4, 3, 4, 3);
			textBoxAddr.MaxLength = 2;
			textBoxAddr.Name = "textBoxAddr";
			textBoxAddr.Size = new Size(32, 23);
			textBoxAddr.TabIndex = 9;
			textBoxAddr.Text = "0";
			// 
			// labelPort
			// 
			labelPort.AutoSize = true;
			labelPort.Location = new Point(7, 24);
			labelPort.Margin = new Padding(4, 0, 4, 0);
			labelPort.Name = "labelPort";
			labelPort.Size = new Size(32, 15);
			labelPort.TabIndex = 8;
			labelPort.Text = "Port:";
			// 
			// textBoxPort
			// 
			textBoxPort.Location = new Point(44, 21);
			textBoxPort.Margin = new Padding(4, 3, 4, 3);
			textBoxPort.MaxLength = 2;
			textBoxPort.Name = "textBoxPort";
			textBoxPort.Size = new Size(24, 23);
			textBoxPort.TabIndex = 0;
			textBoxPort.Text = "1";
			textBoxPort.TextChanged += TextBoxPort_TextChanged;
			// 
			// Panel3
			// 
			Panel3.BackColor = Color.Red;
			Panel3.BorderStyle = BorderStyle.Fixed3D;
			Panel3.Location = new Point(58, 75);
			Panel3.Margin = new Padding(4, 3, 4, 3);
			Panel3.Name = "Panel3";
			Panel3.Size = new Size(28, 17);
			Panel3.TabIndex = 7;
			// 
			// Panel2
			// 
			Panel2.BackColor = Color.Red;
			Panel2.BorderStyle = BorderStyle.Fixed3D;
			Panel2.Location = new Point(58, 54);
			Panel2.Margin = new Padding(4, 3, 4, 3);
			Panel2.Name = "Panel2";
			Panel2.Size = new Size(28, 17);
			Panel2.TabIndex = 7;
			// 
			// Label10
			// 
			Label10.AutoSize = true;
			Label10.Location = new Point(33, 97);
			Label10.Margin = new Padding(4, 0, 4, 0);
			Label10.Name = "Label10";
			Label10.Size = new Size(16, 15);
			Label10.TabIndex = 10;
			Label10.Text = "4:";
			Label10.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Label7
			// 
			Label7.AutoSize = true;
			Label7.Location = new Point(33, 75);
			Label7.Margin = new Padding(4, 0, 4, 0);
			Label7.Name = "Label7";
			Label7.Size = new Size(16, 15);
			Label7.TabIndex = 9;
			Label7.Text = "3:";
			Label7.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Label8
			// 
			Label8.AutoSize = true;
			Label8.Location = new Point(33, 54);
			Label8.Margin = new Padding(4, 0, 4, 0);
			Label8.Name = "Label8";
			Label8.Size = new Size(16, 15);
			Label8.TabIndex = 8;
			Label8.Text = "2:";
			Label8.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Label9
			// 
			Label9.AutoSize = true;
			Label9.Location = new Point(33, 32);
			Label9.Margin = new Padding(4, 0, 4, 0);
			Label9.Name = "Label9";
			Label9.Size = new Size(16, 15);
			Label9.TabIndex = 7;
			Label9.Text = "1:";
			Label9.TextAlign = ContentAlignment.MiddleRight;
			// 
			// GroupBox4
			// 
			GroupBox4.Controls.Add(buttonChangeAddr);
			GroupBox4.Controls.Add(textBoxNewAddr);
			GroupBox4.Location = new Point(14, 104);
			GroupBox4.Margin = new Padding(4, 3, 4, 3);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Padding = new Padding(4, 3, 4, 3);
			GroupBox4.Size = new Size(120, 46);
			GroupBox4.TabIndex = 13;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Address";
			// 
			// buttonChangeAddr
			// 
			buttonChangeAddr.Location = new Point(46, 16);
			buttonChangeAddr.Margin = new Padding(4, 3, 4, 3);
			buttonChangeAddr.Name = "buttonChangeAddr";
			buttonChangeAddr.Size = new Size(68, 23);
			buttonChangeAddr.TabIndex = 1;
			buttonChangeAddr.Text = "Change";
			buttonChangeAddr.UseVisualStyleBackColor = true;
			buttonChangeAddr.Click += ButtonChangeAddr_Click;
			// 
			// textBoxNewAddr
			// 
			textBoxNewAddr.Location = new Point(7, 16);
			textBoxNewAddr.Margin = new Padding(4, 3, 4, 3);
			textBoxNewAddr.MaxLength = 2;
			textBoxNewAddr.Name = "textBoxNewAddr";
			textBoxNewAddr.Size = new Size(31, 23);
			textBoxNewAddr.TabIndex = 0;
			textBoxNewAddr.Text = "1";
			textBoxNewAddr.TextAlign = HorizontalAlignment.Right;
			// 
			// Panel4
			// 
			Panel4.BackColor = Color.Red;
			Panel4.BorderStyle = BorderStyle.Fixed3D;
			Panel4.Location = new Point(58, 97);
			Panel4.Margin = new Padding(4, 3, 4, 3);
			Panel4.Name = "Panel4";
			Panel4.Size = new Size(28, 17);
			Panel4.TabIndex = 7;
			// 
			// GroupBox3
			// 
			GroupBox3.Controls.Add(Panel4);
			GroupBox3.Controls.Add(Panel3);
			GroupBox3.Controls.Add(Panel2);
			GroupBox3.Controls.Add(Label10);
			GroupBox3.Controls.Add(Label7);
			GroupBox3.Controls.Add(Label8);
			GroupBox3.Controls.Add(Label9);
			GroupBox3.Controls.Add(panel1);
			GroupBox3.Location = new Point(14, 158);
			GroupBox3.Margin = new Padding(4, 3, 4, 3);
			GroupBox3.Name = "GroupBox3";
			GroupBox3.Padding = new Padding(4, 3, 4, 3);
			GroupBox3.Size = new Size(121, 134);
			GroupBox3.TabIndex = 12;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Digital Inputs";
			// 
			// panel1
			// 
			panel1.BackColor = Color.Red;
			panel1.BorderStyle = BorderStyle.Fixed3D;
			panel1.Location = new Point(58, 32);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(28, 17);
			panel1.TabIndex = 6;
			// 
			// Timer3
			// 
			Timer3.Enabled = true;
			Timer3.Interval = 500;
			Timer3.Tick += Timer3_Tick;
			// 
			// Timer1
			// 
			Timer1.Enabled = true;
			Timer1.Tick += Timer1_Tick;
			// 
			// GroupBox1
			// 
			GroupBox1.Controls.Add(label6);
			GroupBox1.Controls.Add(label5);
			GroupBox1.Controls.Add(label4);
			GroupBox1.Controls.Add(Label3);
			GroupBox1.Controls.Add(Label2);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(progressBar3);
			GroupBox1.Controls.Add(progressBar1);
			GroupBox1.Controls.Add(progressBar2);
			GroupBox1.Location = new Point(14, 299);
			GroupBox1.Margin = new Padding(4, 3, 4, 3);
			GroupBox1.Name = "GroupBox1";
			GroupBox1.Padding = new Padding(4, 3, 4, 3);
			GroupBox1.Size = new Size(296, 90);
			GroupBox1.TabIndex = 10;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Analog Inputs";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(33, 65);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(31, 15);
			label6.TabIndex = 8;
			label6.Text = "1023";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(33, 44);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(31, 15);
			label5.TabIndex = 7;
			label5.Text = "1023";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(33, 22);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(31, 15);
			label4.TabIndex = 6;
			label4.Text = "1023";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Label3
			// 
			Label3.AutoSize = true;
			Label3.Location = new Point(7, 65);
			Label3.Margin = new Padding(4, 0, 4, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(16, 15);
			Label3.TabIndex = 5;
			Label3.Text = "3:";
			Label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Label2
			// 
			Label2.AutoSize = true;
			Label2.Location = new Point(7, 44);
			Label2.Margin = new Padding(4, 0, 4, 0);
			Label2.Name = "Label2";
			Label2.Size = new Size(16, 15);
			Label2.TabIndex = 4;
			Label2.Text = "2:";
			Label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Label1
			// 
			Label1.AutoSize = true;
			Label1.Location = new Point(7, 22);
			Label1.Margin = new Padding(4, 0, 4, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(16, 15);
			Label1.TabIndex = 3;
			Label1.Text = "1:";
			Label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// progressBar3
			// 
			progressBar3.Location = new Point(82, 65);
			progressBar3.Margin = new Padding(4, 3, 4, 3);
			progressBar3.Maximum = 1023;
			progressBar3.Name = "progressBar3";
			progressBar3.Size = new Size(208, 15);
			progressBar3.Step = 1;
			progressBar3.Style = ProgressBarStyle.Continuous;
			progressBar3.TabIndex = 2;
			progressBar3.Value = 512;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(82, 22);
			progressBar1.Margin = new Padding(4, 3, 4, 3);
			progressBar1.Maximum = 1023;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(208, 15);
			progressBar1.Step = 1;
			progressBar1.Style = ProgressBarStyle.Continuous;
			progressBar1.TabIndex = 0;
			progressBar1.Value = 512;
			// 
			// progressBar2
			// 
			progressBar2.Location = new Point(82, 44);
			progressBar2.Margin = new Padding(4, 3, 4, 3);
			progressBar2.Maximum = 1023;
			progressBar2.Name = "progressBar2";
			progressBar2.Size = new Size(208, 15);
			progressBar2.Step = 1;
			progressBar2.Style = ProgressBarStyle.Continuous;
			progressBar2.TabIndex = 1;
			progressBar2.Value = 512;
			// 
			// Timer2
			// 
			Timer2.Enabled = true;
			Timer2.Interval = 250;
			Timer2.Tick += Timer2_Tick;
			// 
			// GroupBox2
			// 
			GroupBox2.Controls.Add(buttonAllOff);
			GroupBox2.Controls.Add(buttonAllOn);
			GroupBox2.Controls.Add(buttonToggle8);
			GroupBox2.Controls.Add(buttonToggle7);
			GroupBox2.Controls.Add(buttonToggle6);
			GroupBox2.Controls.Add(buttonToggle5);
			GroupBox2.Controls.Add(buttonToggle3);
			GroupBox2.Controls.Add(buttonToggle4);
			GroupBox2.Controls.Add(buttonToggle2);
			GroupBox2.Controls.Add(buttonToggle1);
			GroupBox2.Location = new Point(142, 104);
			GroupBox2.Margin = new Padding(4, 3, 4, 3);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Padding = new Padding(4, 3, 4, 3);
			GroupBox2.Size = new Size(168, 188);
			GroupBox2.TabIndex = 11;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Relays";
			// 
			// buttonAllOff
			// 
			buttonAllOff.BackColor = SystemColors.Control;
			buttonAllOff.Location = new Point(86, 151);
			buttonAllOff.Margin = new Padding(4, 3, 4, 3);
			buttonAllOff.Name = "buttonAllOff";
			buttonAllOff.Size = new Size(72, 25);
			buttonAllOff.TabIndex = 1;
			buttonAllOff.Text = "ALL OFF";
			buttonAllOff.UseVisualStyleBackColor = false;
			buttonAllOff.Click += ButtonAllOff_Click;
			// 
			// buttonAllOn
			// 
			buttonAllOn.BackColor = SystemColors.Control;
			buttonAllOn.Location = new Point(7, 151);
			buttonAllOn.Margin = new Padding(4, 3, 4, 3);
			buttonAllOn.Name = "buttonAllOn";
			buttonAllOn.Size = new Size(72, 25);
			buttonAllOn.TabIndex = 1;
			buttonAllOn.Text = "ALL ON";
			buttonAllOn.UseVisualStyleBackColor = false;
			buttonAllOn.Click += ButtonAllOn_Click;
			// 
			// buttonToggle8
			// 
			buttonToggle8.BackColor = Color.Red;
			buttonToggle8.ForeColor = Color.White;
			buttonToggle8.Location = new Point(86, 119);
			buttonToggle8.Margin = new Padding(4, 3, 4, 3);
			buttonToggle8.Name = "buttonToggle8";
			buttonToggle8.Size = new Size(72, 25);
			buttonToggle8.TabIndex = 1;
			buttonToggle8.Text = "Toggle 8";
			buttonToggle8.UseVisualStyleBackColor = false;
			buttonToggle8.Click += ButtonToggle8_Click;
			// 
			// buttonToggle7
			// 
			buttonToggle7.BackColor = Color.Red;
			buttonToggle7.ForeColor = Color.White;
			buttonToggle7.Location = new Point(86, 87);
			buttonToggle7.Margin = new Padding(4, 3, 4, 3);
			buttonToggle7.Name = "buttonToggle7";
			buttonToggle7.Size = new Size(72, 25);
			buttonToggle7.TabIndex = 1;
			buttonToggle7.Text = "Toggle 7";
			buttonToggle7.UseVisualStyleBackColor = false;
			buttonToggle7.Click += ButtonToggle7_Click;
			// 
			// buttonToggle6
			// 
			buttonToggle6.BackColor = Color.Red;
			buttonToggle6.ForeColor = Color.White;
			buttonToggle6.Location = new Point(86, 54);
			buttonToggle6.Margin = new Padding(4, 3, 4, 3);
			buttonToggle6.Name = "buttonToggle6";
			buttonToggle6.Size = new Size(72, 25);
			buttonToggle6.TabIndex = 1;
			buttonToggle6.Text = "Toggle 6";
			buttonToggle6.UseVisualStyleBackColor = false;
			buttonToggle6.Click += ButtonToggle6_Click;
			// 
			// buttonToggle5
			// 
			buttonToggle5.BackColor = Color.Red;
			buttonToggle5.ForeColor = Color.White;
			buttonToggle5.Location = new Point(86, 22);
			buttonToggle5.Margin = new Padding(4, 3, 4, 3);
			buttonToggle5.Name = "buttonToggle5";
			buttonToggle5.Size = new Size(72, 25);
			buttonToggle5.TabIndex = 1;
			buttonToggle5.Text = "Toggle 5";
			buttonToggle5.UseVisualStyleBackColor = false;
			buttonToggle5.Click += ButtonToggle5_Click;
			// 
			// buttonToggle3
			// 
			buttonToggle3.BackColor = Color.Red;
			buttonToggle3.ForeColor = Color.White;
			buttonToggle3.Location = new Point(7, 87);
			buttonToggle3.Margin = new Padding(4, 3, 4, 3);
			buttonToggle3.Name = "buttonToggle3";
			buttonToggle3.Size = new Size(72, 25);
			buttonToggle3.TabIndex = 1;
			buttonToggle3.Text = "Toggle 3";
			buttonToggle3.UseVisualStyleBackColor = false;
			buttonToggle3.Click += ButtonToggle3_Click;
			// 
			// buttonToggle4
			// 
			buttonToggle4.BackColor = Color.Red;
			buttonToggle4.ForeColor = Color.White;
			buttonToggle4.Location = new Point(7, 119);
			buttonToggle4.Margin = new Padding(4, 3, 4, 3);
			buttonToggle4.Name = "buttonToggle4";
			buttonToggle4.Size = new Size(72, 25);
			buttonToggle4.TabIndex = 1;
			buttonToggle4.Text = "Toggle 4";
			buttonToggle4.UseVisualStyleBackColor = false;
			buttonToggle4.Click += ButtonToggle4_Click;
			// 
			// buttonToggle2
			// 
			buttonToggle2.BackColor = Color.Red;
			buttonToggle2.ForeColor = Color.White;
			buttonToggle2.Location = new Point(7, 54);
			buttonToggle2.Margin = new Padding(4, 3, 4, 3);
			buttonToggle2.Name = "buttonToggle2";
			buttonToggle2.Size = new Size(72, 25);
			buttonToggle2.TabIndex = 1;
			buttonToggle2.Text = "Toggle 2";
			buttonToggle2.UseVisualStyleBackColor = false;
			buttonToggle2.Click += ButtonToggle2_Click;
			// 
			// buttonToggle1
			// 
			buttonToggle1.BackColor = Color.Red;
			buttonToggle1.ForeColor = Color.White;
			buttonToggle1.Location = new Point(7, 22);
			buttonToggle1.Margin = new Padding(4, 3, 4, 3);
			buttonToggle1.Name = "buttonToggle1";
			buttonToggle1.Size = new Size(72, 25);
			buttonToggle1.TabIndex = 0;
			buttonToggle1.Text = "Toggle 1";
			buttonToggle1.UseVisualStyleBackColor = false;
			buttonToggle1.Click += ButtonToggle1_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(327, 400);
			Controls.Add(GroupBox5);
			Controls.Add(GroupBox4);
			Controls.Add(GroupBox3);
			Controls.Add(GroupBox1);
			Controls.Add(GroupBox2);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormMain";
			Text = "Relay Tester";
			GroupBox5.ResumeLayout(false);
			GroupBox5.PerformLayout();
			GroupBox4.ResumeLayout(false);
			GroupBox4.PerformLayout();
			GroupBox3.ResumeLayout(false);
			GroupBox3.PerformLayout();
			GroupBox1.ResumeLayout(false);
			GroupBox1.PerformLayout();
			GroupBox2.ResumeLayout(false);
			ResumeLayout(false);
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
