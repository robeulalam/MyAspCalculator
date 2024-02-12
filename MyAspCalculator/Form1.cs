namespace MyAspCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		double num1;
		double num2;
		double result;
		string action;

		private void btn1_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "2";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "3";
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "4";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "6";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "8";
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "9";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + "0";
		}

		private void btnSum_Click(object sender, EventArgs e)
		{
			action = "+";
			num1 = Convert.ToInt32(txtDisplay.Text);
			txtDisplay.Clear();
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			num2 = Convert.ToInt32(txtDisplay.Text);
			if (action == "+")
			{

				result = num1 + num2;
			}
			else if (action == "-")
			{
				result = num1 - num2;
			}
			else if (action == "*")
			{
				result = num1 * num2;
			}
			else if (action == "/")
			{
				result = num1 / num2;
			}

			txtDisplay.Text = result.ToString();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			action = "-";
			num1 = Convert.ToInt32(txtDisplay.Text);
			txtDisplay.Clear();
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			action = "*";
			num1 = Convert.ToInt32(txtDisplay.Text);
			txtDisplay.Clear();
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			action = "/";
			num1 = Convert.ToInt32(txtDisplay.Text);
			txtDisplay.Clear();
		}
	}
}
