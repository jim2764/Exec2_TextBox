using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblOutput.Visible = false;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPeople.Text) && string.IsNullOrEmpty(txtCar.Text))
			{
				MessageBox.Show("車和人數未輸入", "Error", 
								MessageBoxButtons.OK, 
								MessageBoxIcon.Error);
				return;
			}
				
			int carNumber;
			try
			{
				carNumber = IsTrueValue(txtCar.Text, lblCar);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", 
								MessageBoxButtons.OK, 
								MessageBoxIcon.Error);
				return ;
			}

			int peopleNumber;
			try
			{
				peopleNumber = IsTrueValue(txtPeople.Text, lblPeople);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				return;
			}


			string output = ShowLabel(carNumber, peopleNumber);
			lblOutput.Text = output;

			lblOutput.Visible = true;
		}

		private int IsTrueValue(string value, Control label)
		{
			bool isTrue = int.TryParse(value, out int result);

			if (!isTrue) throw new Exception($"{label.Text} 非數值");
			else if (result < 0) throw new Exception("請輸入正數");

			return result;
		}

		private string ShowLabel(int carNumber, int peopleNumber)
		{
			string output = string.Empty;
			output += $"人:${peopleNumber * 60}";
			output += $"  車:${carNumber * 200}";
			output += $"  共:${peopleNumber * 60 + carNumber * 200}";
			return output;
		}
	}
}
