using System;
using System.Linq;
using System.Windows.Forms;

namespace KTA22xTester
{
	public partial class FormBaud : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public FormBaud()
		{
			// Initialize the form.
			InitializeComponent();

			// Select the current baud rate.
			foreach (RadioButton r in tableLayoutPanelBaud.Controls.OfType<RadioButton>())
			{
				if (Properties.Settings.Default.Baud == Convert.ToUInt32(r.Text))
				{
					r.Checked = true;
				}
			}
		}

		/// <summary>
		/// If the "OK" button is clicked, set the new baud rate.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOk_Click(object sender, EventArgs e)
		{
			// Save new baud rate setting.
			foreach (RadioButton r in tableLayoutPanelBaud.Controls.OfType<RadioButton>())
			{
				if (r.Checked)
				{
					Properties.Settings.Default.Baud = Convert.ToUInt32(r.Text);
				}
			}

			// Close the form.
			Close();
		}

		/// <summary>
		/// If "Cancel" button is clicked, close the form without doing anything.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			// Close the form.
			Close();
		}
	}
}
