using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			FormFixedSize();
			txtInput.MaxLength = 5;
			lblOutput.Visible = false;
		}

		private void FormFixedSize()
		{
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			lblOutput.Visible = true;

			string result = string.Empty;

			DateTime now = DateTime.Now;
			string date = now.ToString("yyyy/MM/dd HH:mm:ss");

			string greet = $"Hi, {txtInput.Text}";

			result = date + "\r\n" +greet;

			lblOutput.Text = result;
		}

        private void lblTag_Click(object sender, EventArgs e)
        {

        }
    }
}
