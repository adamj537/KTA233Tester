using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
	public partial class FormBaud : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public FormBaud()
		{
			InitializeComponent();
		}

		/// <summary>
		/// If the "OK" button is clicked, set the new baud rate.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOk_Click(object sender, EventArgs e)
		{
			int mybaud = 0;
			try
			{
				if (RadioButton1.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton1.Text);
				}
				if (RadioButton2.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton2.Text);
				}
				if (RadioButton3.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton3.Text);
				}
				if (RadioButton4.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton4.Text);
				}
				if (RadioButton5.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton5.Text);
				}
				if (RadioButton6.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton6.Text);
				}
				if (RadioButton7.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton7.Text);
				}
				if (RadioButton8.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton8.Text);
				}
				if (RadioButton9.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton9.Text);
				}
				if (RadioButton10.Checked)
				{
					mybaud = Convert.ToInt32(RadioButton10.Text);
				}

				// If the serial port is open...
				if (FormMain.Default.SerialPort1.IsOpen)
				{
					// Close it.
					FormMain.Default.SerialPort1.Close();
				}

				// Set the new baud rate.
				FormMain.Default.SerialPort1.BaudRate = mybaud;

				// Open the serial port again.
				FormMain.Default.SerialPort1.Open();

				// Close the form.
				Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Error Opening " + FormMain.Default.SerialPort1.PortName);
			}
		}

		/// <summary>
		/// If "Cancel" button is clicked, close the form without doing anything.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
