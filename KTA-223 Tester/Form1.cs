using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		public void OpenPort(object sender, EventArgs e)
		{
			try
			{
				if (SerialPort1.IsOpen)
				{
					SerialPort1.Close();
				}
				SerialPort1.PortName = "COM" + TextBoxPort.Text;
				SerialPort1.Open();
				//TODO:  change this button from opening a port to toggling the port open and closed
			}
			catch (Exception)
			{
				MessageBox.Show("Error Opening " + SerialPort1.PortName);
			}
		}
		
		public void GroupBox2_Enter(object sender, EventArgs e)
		{
			
		}
	}
}
