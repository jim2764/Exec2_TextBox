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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int input;
			try
			{
				input = IsTrueValue(txtInput.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show($"{input} is correct!!", "Correct",
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private int IsTrueValue(string value)
		{
			bool isTrue = int.TryParse(value, out int result);
			if (!isTrue) throw new Exception("非數值");
			else if (result < 1 || result > 100) throw new Exception("超出[1, 99]");

			return result;
		}
	}
}
