using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTA233Tester
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void TextBoxPort_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Port = Convert.ToUInt32(textBoxPort.Text);
		}

		private void ButtonOpenPort_Click(object sender, EventArgs e)
		{
			try
			{
				if (SerialPort1.IsOpen)
				{
					SerialPort1.Close();
				}
				SerialPort1.PortName = "COM" + textBoxPort.Text;
				SerialPort1.Open();
				//TODO:  change this button from opening a port to toggling the port open and closed
			}
			catch (Exception)
			{
				MessageBox.Show("Error Opening " + SerialPort1.PortName);
			}
		}

		private void ButtonBaud_Click(object sender, EventArgs e)
		{
			FormBaud formBaud = new FormBaud();
			formBaud.Show();
			formBaud.Dispose();
		}

		private void ButtonChangeAddr_Click(object sender, EventArgs e)
		{
			try
			{
				string addr = "";
				string outstr = "";
				addr = "";
				if (double.Parse(textBoxAddr.Text) < 10)
				{
					addr = "0";
				}
				addr += textBoxAddr.Text;
				if (SerialPort1.IsOpen)
				{
					outstr = "@" + addr + " SA ";
					if (double.Parse(textBoxNewAddr.Text) < 10)
					{
						outstr += "0";
					}
					outstr += textBoxNewAddr.Text;
					textBoxTX.Text = outstr;
					outstr += Convert.ToString("\r"); //vbNewLine
					SerialPort1.Write(outstr);
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);

			}
		}

		private void RelayToggle(Button buttonToggle, uint relayNumber)
		{
			// If relay is off (red)...
			if (buttonToggle.BackColor == Color.Red)
			{
				// Turn it on.
				RelaySet(relayNumber, true);
			}
			// If relay is on (green)...
			else
			{
				// Turn it off.
				RelaySet(relayNumber, false);
			}
		}

		private void RelaySet(uint relayNumber, bool status)
		{
			try
			{
				if (SerialPort1.IsOpen)
				{
					// Fetch the address.
					// If address is less than 10, add a leading zero.
					string addr = "";
					if (double.Parse(textBoxAddr.Text) < 10)
					{
						addr = "0";
					}
					addr += textBoxAddr.Text;

					string command;
					if (status == true)
					{
						command = " ON ";
					}
					else
					{
						command = " OF ";
					}

					string outstr = "@" + addr + command + relayNumber;
					textBoxTX.Text = outstr;
					outstr += Convert.ToString("\r");
					SerialPort1.Write(outstr);
				}
			}
			catch (Exception)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName);
			}
		}

		private void ButtonToggle1_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 1);
		}

		private void ButtonToggle2_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 2);
		}

		private void ButtonToggle3_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 3);
		}

		private void ButtonToggle4_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 4);
		}

		private void ButtonToggle5_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 5);
		}

		private void ButtonToggle6_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 6);
		}

		private void ButtonToggle7_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 7);
		}

		private void ButtonToggle8_Click(object sender, EventArgs e)
		{
			RelayToggle(sender as Button, 8);
		}

		private void ButtonAllOn_Click(object sender, EventArgs e)
		{
			RelaySet(0, true);
		}

		private void ButtonAllOff_Click(object sender, EventArgs e)
		{
			RelaySet(0, false);
		}

		/// <summary>
		/// Every 100 ms, read from the serial port.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer1_Tick(object sender, EventArgs e)
		{
			string mychar = "";
			try
			{
				if (SerialPort1.IsOpen)
				{
					while (SerialPort1.BytesToRead > 0)
					{
						mychar = Convert.ToString((char)SerialPort1.ReadByte());
						if (mychar == "#")
						{
							textBoxRX.Text = "";
						}
						else
						{
							if (char.Parse(mychar) == '\r' || char.Parse(mychar) == '\n')
							{
								Monitor(textBoxRX.Text);
								//rxOn = False
								txNext = true;
							}
							else
							{
								textBoxRX.Text += mychar;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				SerialPort1.Close();
				MessageBox.Show("Error with Port " + SerialPort1.PortName + Environment.NewLine
					+ ex.Message);
			}
		}

		private bool txNext;

		private byte SorI;

		private void Monitor(string rxstr)
		{
			float[] res = new float[3];
			bool parse = false;

			string val1;
			//Text1.Text = rxstr
			if (rxstr.IndexOf(" ") + 1 != 0)
			{
				val1 = rxstr.Substring(rxstr.Length - (rxstr.Length - (rxstr.IndexOf(" ") + 1)), rxstr.Length - (rxstr.IndexOf(" ") + 1));
				//Text2.Text = val1
				parse = true;
			}
			else
			{
				val1 = "";
				//Text2.Text = "none"
			}
			string val2;
			if (val1.IndexOf(" ") + 1 != 0)
			{
				val2 = val1.Substring(val1.Length - (val1.Length - (val1.IndexOf(" ") + 1)), val1.Length - (val1.IndexOf(" ") + 1));
				val1 = val1.Substring(0, val1.IndexOf(" ") + 1);
				//Text2.Text = val1
				//Text3.Text = val2
			}
			else
			{
				val2 = "";
				//Text3.Text = "none"
			}
			string val3;
			if (val2.IndexOf(" ") + 1 != 0)
			{
				val3 = val2.Substring(val2.Length - (val2.Length - (val2.IndexOf(" ") + 1)), val2.Length - (val2.IndexOf(" ") + 1)) + " ";
				val2 = val2.Substring(0, val2.IndexOf(" ") + 1);
				//Text2.Text = val1
				//Text3.Text = val2
			}
			else
			{
				val3 = "";
				//Text3.Text = "none"
			}
			if (parse == true)
			{
				int i;
				int j;
				int result;

				// Relay Status
				if (SorI == 0)
				{
					result = Convert.ToInt32(val1);
					j = 1;
					for (i = 1; i <= 8; i++)
					{
						if ((result & j) == j)
						{
							if (i == 1)
							{
								buttonToggle1.BackColor = Color.LawnGreen;
							}
							if (i == 2)
							{
								buttonToggle2.BackColor = Color.LawnGreen;
							}
							if (i == 3)
							{
								buttonToggle3.BackColor = Color.LawnGreen;
							}
							if (i == 4)
							{
								buttonToggle4.BackColor = Color.LawnGreen;
							}
							if (i == 5)
							{
								buttonToggle5.BackColor = Color.LawnGreen;
							}
							if (i == 6)
							{
								buttonToggle6.BackColor = Color.LawnGreen;
							}
							if (i == 7)
							{
								buttonToggle7.BackColor = Color.LawnGreen;
							}
							if (i == 8)
							{
								buttonToggle8.BackColor = Color.LawnGreen;
							}
							if (i == 1)
							{
								buttonToggle1.ForeColor = Color.Black;
							}
							if (i == 2)
							{
								buttonToggle2.ForeColor = Color.Black;
							}
							if (i == 3)
							{
								buttonToggle3.ForeColor = Color.Black;
							}
							if (i == 4)
							{
								buttonToggle4.ForeColor = Color.Black;
							}
							if (i == 5)
							{
								buttonToggle5.ForeColor = Color.Black;
							}
							if (i == 6)
							{
								buttonToggle6.ForeColor = Color.Black;
							}
							if (i == 7)
							{
								buttonToggle7.ForeColor = Color.Black;
							}
							if (i == 8)
							{
								buttonToggle8.ForeColor = Color.Black;
							}
						}
						else
						{
							if (i == 1)
							{
								buttonToggle1.BackColor = Color.Red;
							}
							if (i == 2)
							{
								buttonToggle2.BackColor = Color.Red;
							}
							if (i == 3)
							{
								buttonToggle3.BackColor = Color.Red;
							}
							if (i == 4)
							{
								buttonToggle4.BackColor = Color.Red;
							}
							if (i == 5)
							{
								buttonToggle5.BackColor = Color.Red;
							}
							if (i == 6)
							{
								buttonToggle6.BackColor = Color.Red;
							}
							if (i == 7)
							{
								buttonToggle7.BackColor = Color.Red;
							}
							if (i == 8)
							{
								buttonToggle8.BackColor = Color.Red;
							}
							if (i == 1)
							{
								buttonToggle1.ForeColor = Color.White;
							}
							if (i == 2)
							{
								buttonToggle2.ForeColor = Color.White;
							}
							if (i == 3)
							{
								buttonToggle3.ForeColor = Color.White;
							}
							if (i == 4)
							{
								buttonToggle4.ForeColor = Color.White;
							}
							if (i == 5)
							{
								buttonToggle5.ForeColor = Color.White;
							}
							if (i == 6)
							{
								buttonToggle6.ForeColor = Color.White;
							}
							if (i == 7)
							{
								buttonToggle7.ForeColor = Color.White;
							}
							if (i == 8)
							{
								buttonToggle8.ForeColor = Color.White;
							}
						}
						j *= 2;
					}
					if (result == 255)
					{
						buttonAllOn.BackColor = Color.LawnGreen;
						buttonAllOn.ForeColor = Color.Black;
					}
					else
					{
						buttonAllOn.BackColor = Color.Red;
						buttonAllOn.ForeColor = Color.White;
					}
					if (result == 0)
					{
						buttonAllOff.BackColor = Color.LawnGreen;
						buttonAllOff.ForeColor = Color.Black;
					}
					else
					{
						buttonAllOff.BackColor = Color.Red;
						buttonAllOff.ForeColor = Color.White;
					}
				}
				// Input Status
				else if (SorI == 1)
				{
					result = Convert.ToInt32(val1);
					j = 1;
					for (i = 1; i <= 4; i++)
					{
						if ((result & j) == j)
						{
							if (i == 1)
							{
								panel1.BackColor = Color.LawnGreen;
							}
							if (i == 2)
							{
								Panel2.BackColor = Color.LawnGreen;
							}
							if (i == 3)
							{
								Panel3.BackColor = Color.LawnGreen;
							}
							if (i == 4)
							{
								Panel4.BackColor = Color.LawnGreen;
							}
						}
						else
						{
							if (i == 1)
							{
								panel1.BackColor = Color.Red;
							}
							if (i == 2)
							{
								Panel2.BackColor = Color.Red;
							}
							if (i == 3)
							{
								Panel3.BackColor = Color.Red;
							}
							if (i == 4)
							{
								Panel4.BackColor = Color.Red;
							}
						}
						j *= 2;
					}
				}
				// Analog Input
				else if (SorI == 2)
				{
					res[0] = Convert.ToSingle(val1);
					res[1] = Convert.ToSingle(val2);
					res[2] = Convert.ToSingle(val3);
					label4.Text = val1;
					label5.Text = val2;
					label6.Text = val3;
					progressBar1.Value = Convert.ToInt32(val1);
					progressBar2.Value = Convert.ToInt32(val2);
					progressBar3.Value = Convert.ToInt32(val3);

					//For i = 0 To 2
					//Shape4(i).FillColor = vbGreen
					//Shape4(i).Width = res(i) / 1023 * Shape3(i).Width
					//Next i
				}


			}

		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			//Static SorI As Byte
			try
			{
				if (txNext == true)
				{
					SorI++;
					if (SorI == 3)
					{
						SorI = 0;
					}
					string mystr = "";
					//If Option1(2).Value = True Then
					if (double.Parse(textBoxAddr.Text) < 10)
					{
						mystr = "@0" + textBoxAddr.Text + " ";
					}
					else
					{
						mystr = "@" + textBoxAddr.Text + " ";
					}
					//End If
					if (SorI == 0)
					{
						mystr += "RS 0";
						txNext = false;
					}
					else if (SorI == 1)
					{
						mystr += "IS 0";
						txNext = false;
					}
					else if (SorI == 2)
					{
						mystr += "AI 0";
						txNext = false;
					}
					textBoxTX.Text = mystr;
					mystr += Convert.ToString("\r"); //vbNewLine
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

		private void Timer3_Tick(object sender, EventArgs e)
		{
			if (txNext != true)
			{
				txNext = true;
			}
		}
	}
}
