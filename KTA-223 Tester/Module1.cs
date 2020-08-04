using System.Drawing;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
	sealed class Module1
	{
		public static bool txNext;
		
		public static byte SorI;
		//Declare Sub monitor(ByVal rxstr As String)
		public static void Monitor(string rxstr)
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
				if (SorI == 0) //Relay Status
				{
					result = System.Convert.ToInt32(Conversion.Val(val1));
					j = 1;
					for (i = 1; i <= 8; i++)
					{
						if ((result & j) == j)
						{
							if (i == 1)
							{
								Form1.Default.ButtonToggle1.BackColor = Color.LawnGreen;
							}
							if (i == 2)
							{
								Form1.Default.ButtonToggle2.BackColor = Color.LawnGreen;
							}
							if (i == 3)
							{
								Form1.Default.ButtonToggle3.BackColor = Color.LawnGreen;
							}
							if (i == 4)
							{
								Form1.Default.ButtonToggle4.BackColor = Color.LawnGreen;
							}
							if (i == 5)
							{
								Form1.Default.ButtonToggle5.BackColor = Color.LawnGreen;
							}
							if (i == 6)
							{
								Form1.Default.ButtonToggle6.BackColor = Color.LawnGreen;
							}
							if (i == 7)
							{
								Form1.Default.ButtonToggle7.BackColor = Color.LawnGreen;
							}
							if (i == 8)
							{
								Form1.Default.ButtonToggle8.BackColor = Color.LawnGreen;
							}
							if (i == 1)
							{
								Form1.Default.ButtonToggle1.ForeColor = Color.Black;
							}
							if (i == 2)
							{
								Form1.Default.ButtonToggle2.ForeColor = Color.Black;
							}
							if (i == 3)
							{
								Form1.Default.ButtonToggle3.ForeColor = Color.Black;
							}
							if (i == 4)
							{
								Form1.Default.ButtonToggle4.ForeColor = Color.Black;
							}
							if (i == 5)
							{
								Form1.Default.ButtonToggle5.ForeColor = Color.Black;
							}
							if (i == 6)
							{
								Form1.Default.ButtonToggle6.ForeColor = Color.Black;
							}
							if (i == 7)
							{
								Form1.Default.ButtonToggle7.ForeColor = Color.Black;
							}
							if (i == 8)
							{
								Form1.Default.ButtonToggle8.ForeColor = Color.Black;
							}
						}
						else
						{
							if (i == 1)
							{
								Form1.Default.ButtonToggle1.BackColor = Color.Red;
							}
							if (i == 2)
							{
								Form1.Default.ButtonToggle2.BackColor = Color.Red;
							}
							if (i == 3)
							{
								Form1.Default.ButtonToggle3.BackColor = Color.Red;
							}
							if (i == 4)
							{
								Form1.Default.ButtonToggle4.BackColor = Color.Red;
							}
							if (i == 5)
							{
								Form1.Default.ButtonToggle5.BackColor = Color.Red;
							}
							if (i == 6)
							{
								Form1.Default.ButtonToggle6.BackColor = Color.Red;
							}
							if (i == 7)
							{
								Form1.Default.ButtonToggle7.BackColor = Color.Red;
							}
							if (i == 8)
							{
								Form1.Default.ButtonToggle8.BackColor = Color.Red;
							}
							if (i == 1)
							{
								Form1.Default.ButtonToggle1.ForeColor = Color.White;
							}
							if (i == 2)
							{
								Form1.Default.ButtonToggle2.ForeColor = Color.White;
							}
							if (i == 3)
							{
								Form1.Default.ButtonToggle3.ForeColor = Color.White;
							}
							if (i == 4)
							{
								Form1.Default.ButtonToggle4.ForeColor = Color.White;
							}
							if (i == 5)
							{
								Form1.Default.ButtonToggle5.ForeColor = Color.White;
							}
							if (i == 6)
							{
								Form1.Default.ButtonToggle6.ForeColor = Color.White;
							}
							if (i == 7)
							{
								Form1.Default.ButtonToggle7.ForeColor = Color.White;
							}
							if (i == 8)
							{
								Form1.Default.ButtonToggle8.ForeColor = Color.White;
							}
						}
						j *= 2;
					}
					if (result == 255)
					{
						Form1.Default.ButtonAllOn.BackColor = Color.LawnGreen;
						Form1.Default.ButtonAllOn.ForeColor = Color.Black;
					}
					else
					{
						Form1.Default.ButtonAllOn.BackColor = Color.Red;
						Form1.Default.ButtonAllOn.ForeColor = Color.White;
					}
					if (result == 0)
					{
						Form1.Default.ButtonAllOff.BackColor = Color.LawnGreen;
						Form1.Default.ButtonAllOff.ForeColor = Color.Black;
					}
					else
					{
						Form1.Default.ButtonAllOff.BackColor = Color.Red;
						Form1.Default.ButtonAllOff.ForeColor = Color.White;
					}
				} //Input Status
				else if (SorI == 1)
				{
					result = System.Convert.ToInt32(Conversion.Val(val1));
					j = 1;
					for (i = 1; i <= 4; i++)
					{
						if ((result & j) == j)
						{
							if (i == 1)
							{
								Form1.Default.Panel1.BackColor = Color.LawnGreen;
							}
							if (i == 2)
							{
								Form1.Default.Panel2.BackColor = Color.LawnGreen;
							}
							if (i == 3)
							{
								Form1.Default.Panel3.BackColor = Color.LawnGreen;
							}
							if (i == 4)
							{
								Form1.Default.Panel4.BackColor = Color.LawnGreen;
							}
						}
						else
						{
							if (i == 1)
							{
								Form1.Default.Panel1.BackColor = Color.Red;
							}
							if (i == 2)
							{
								Form1.Default.Panel2.BackColor = Color.Red;
							}
							if (i == 3)
							{
								Form1.Default.Panel3.BackColor = Color.Red;
							}
							if (i == 4)
							{
								Form1.Default.Panel4.BackColor = Color.Red;
							}
						}
						j *= 2;
					}
				} //Analog Input
				else if (SorI == ((byte)2))
				{
					res[0] = (float)(Conversion.Val(val1));
					res[1] = (float)(Conversion.Val(val2));
					res[2] = (float)(Conversion.Val(val3));
					Form1.Default.Label4.Text = System.Convert.ToString(Conversion.Val(val1));
					Form1.Default.Label5.Text = System.Convert.ToString(Conversion.Val(val2));
					Form1.Default.Label6.Text = System.Convert.ToString(Conversion.Val(val3));
					Form1.Default.ProgressBar1.Value = System.Convert.ToInt32(Conversion.Val(val1));
					Form1.Default.ProgressBar2.Value = System.Convert.ToInt32(Conversion.Val(val2));
					Form1.Default.ProgressBar3.Value = System.Convert.ToInt32(Conversion.Val(val3));

					//For i = 0 To 2
					//Shape4(i).FillColor = vbGreen
					//Shape4(i).Width = res(i) / 1023 * Shape3(i).Width
					//Next i
				}


			}
			
		}
		
	}
	
}
