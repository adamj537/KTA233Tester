// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using WindowsApplication1;

namespace WindowsApplication1
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class FormBaud : System.Windows.Forms.Form
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.RadioButton6 = new System.Windows.Forms.RadioButton();
			this.RadioButton7 = new System.Windows.Forms.RadioButton();
			this.RadioButton8 = new System.Windows.Forms.RadioButton();
			this.RadioButton9 = new System.Windows.Forms.RadioButton();
			this.RadioButton10 = new System.Windows.Forms.RadioButton();
			this.RadioButton5 = new System.Windows.Forms.RadioButton();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.RadioButton6);
			this.GroupBox1.Controls.Add(this.RadioButton7);
			this.GroupBox1.Controls.Add(this.RadioButton8);
			this.GroupBox1.Controls.Add(this.RadioButton9);
			this.GroupBox1.Controls.Add(this.RadioButton10);
			this.GroupBox1.Controls.Add(this.RadioButton5);
			this.GroupBox1.Controls.Add(this.RadioButton4);
			this.GroupBox1.Controls.Add(this.RadioButton3);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(156, 184);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "GroupBox1";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(88, 145);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(50, 24);
			this.Button2.TabIndex = 11;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(21, 145);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(50, 24);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//RadioButton6
			//
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new System.Drawing.Point(83, 122);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new System.Drawing.Size(61, 17);
			this.RadioButton6.TabIndex = 9;
			this.RadioButton6.Text = "115200";
			this.RadioButton6.UseVisualStyleBackColor = true;
			//
			//RadioButton7
			//
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new System.Drawing.Point(83, 99);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new System.Drawing.Size(55, 17);
			this.RadioButton7.TabIndex = 8;
			this.RadioButton7.Text = "57600";
			this.RadioButton7.UseVisualStyleBackColor = true;
			//
			//RadioButton8
			//
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new System.Drawing.Point(83, 76);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new System.Drawing.Size(55, 17);
			this.RadioButton8.TabIndex = 7;
			this.RadioButton8.Text = "38400";
			this.RadioButton8.UseVisualStyleBackColor = true;
			//
			//RadioButton9
			//
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new System.Drawing.Point(83, 53);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new System.Drawing.Size(55, 17);
			this.RadioButton9.TabIndex = 6;
			this.RadioButton9.Text = "28800";
			this.RadioButton9.UseVisualStyleBackColor = true;
			//
			//RadioButton10
			//
			this.RadioButton10.AutoSize = true;
			this.RadioButton10.Location = new System.Drawing.Point(83, 30);
			this.RadioButton10.Name = "RadioButton10";
			this.RadioButton10.Size = new System.Drawing.Size(55, 17);
			this.RadioButton10.TabIndex = 5;
			this.RadioButton10.Text = "19200";
			this.RadioButton10.UseVisualStyleBackColor = true;
			//
			//RadioButton5
			//
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new System.Drawing.Point(16, 122);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new System.Drawing.Size(55, 17);
			this.RadioButton5.TabIndex = 4;
			this.RadioButton5.Text = "14400";
			this.RadioButton5.UseVisualStyleBackColor = true;
			//
			//RadioButton4
			//
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new System.Drawing.Point(16, 99);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(49, 17);
			this.RadioButton4.TabIndex = 3;
			this.RadioButton4.Text = "9600";
			this.RadioButton4.UseVisualStyleBackColor = true;
			//
			//RadioButton3
			//
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new System.Drawing.Point(16, 76);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(49, 17);
			this.RadioButton3.TabIndex = 2;
			this.RadioButton3.Text = "4800";
			this.RadioButton3.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(16, 53);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(49, 17);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "2400";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new System.Drawing.Point(16, 30);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(49, 17);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.Text = "1200";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//Form2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(181, 209);
			this.Controls.Add(this.GroupBox1);
			this.Name = "Form2";
			this.Text = "Baud";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton6;
		internal System.Windows.Forms.RadioButton RadioButton7;
		internal System.Windows.Forms.RadioButton RadioButton8;
		internal System.Windows.Forms.RadioButton RadioButton9;
		internal System.Windows.Forms.RadioButton RadioButton10;
		internal System.Windows.Forms.RadioButton RadioButton5;
		internal System.Windows.Forms.RadioButton RadioButton4;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			int mybaud = 0;
			try
			{
				if (RadioButton1.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton1.Text));
				}
				if (RadioButton2.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton2.Text));
				}
				if (RadioButton3.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton3.Text));
				}
				if (RadioButton4.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton4.Text));
				}
				if (RadioButton5.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton5.Text));
				}
				if (RadioButton6.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton6.Text));
				}
				if (RadioButton7.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton7.Text));
				}
				if (RadioButton8.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton8.Text));
				}
				if (RadioButton9.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton9.Text));
				}
				if (RadioButton10.Checked)
				{
					mybaud = System.Convert.ToInt32(Conversion.Val(RadioButton10.Text));
				}
				if (Form1.Default.SerialPort1.IsOpen)
				{
					Form1.Default.SerialPort1.Close();
				}
				Form1.Default.SerialPort1.BaudRate = mybaud;
				Form1.Default.SerialPort1.Open();
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Error Opening " + Form1.Default.SerialPort1.PortName);
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
			
		}
	}
	
}
