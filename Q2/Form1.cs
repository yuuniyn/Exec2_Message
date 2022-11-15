using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			FormFixedSize();
		}

		private void FormFixedSize()
		{
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void btnDate_Click(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;

			string result = string.Empty;
			result = date.ToString("yyy/MM/dd HH:mm:ss");
			MessageBox.Show(result, "Date", MessageBoxButtons.OK
							, MessageBoxIcon.Information);
		}
	}
}
