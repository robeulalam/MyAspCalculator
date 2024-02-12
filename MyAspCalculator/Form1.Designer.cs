namespace MyAspCalculator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Button btnDivide;
			txtDisplay = new TextBox();
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btn4 = new Button();
			btn5 = new Button();
			btn0 = new Button();
			btn9 = new Button();
			btn8 = new Button();
			btn7 = new Button();
			btn6 = new Button();
			btnEqual = new Button();
			btnMultiply = new Button();
			btnMinus = new Button();
			btnSum = new Button();
			btnClear = new Button();
			btnDivide = new Button();
			SuspendLayout();
			// 
			// btnDivide
			// 
			btnDivide.Location = new Point(142, 445);
			btnDivide.Name = "btnDivide";
			btnDivide.Size = new Size(84, 78);
			btnDivide.TabIndex = 14;
			btnDivide.Text = "/";
			btnDivide.UseVisualStyleBackColor = true;
			btnDivide.Click += btnDivide_Click;
			// 
			// txtDisplay
			// 
			txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtDisplay.Location = new Point(35, 24);
			txtDisplay.Multiline = true;
			txtDisplay.Name = "txtDisplay";
			txtDisplay.Size = new Size(394, 68);
			txtDisplay.TabIndex = 0;
			// 
			// btn1
			// 
			btn1.Location = new Point(42, 345);
			btn1.Name = "btn1";
			btn1.Size = new Size(86, 78);
			btn1.TabIndex = 1;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += btn1_Click;
			// 
			// btn2
			// 
			btn2.Location = new Point(142, 345);
			btn2.Name = "btn2";
			btn2.Size = new Size(84, 78);
			btn2.TabIndex = 2;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += btn2_Click;
			// 
			// btn3
			// 
			btn3.Location = new Point(241, 345);
			btn3.Name = "btn3";
			btn3.Size = new Size(88, 78);
			btn3.TabIndex = 3;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += btn3_Click;
			// 
			// btn4
			// 
			btn4.Location = new Point(40, 246);
			btn4.Name = "btn4";
			btn4.Size = new Size(88, 78);
			btn4.TabIndex = 4;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += btn4_Click;
			// 
			// btn5
			// 
			btn5.Location = new Point(142, 246);
			btn5.Name = "btn5";
			btn5.Size = new Size(84, 78);
			btn5.TabIndex = 5;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += btn5_Click;
			// 
			// btn0
			// 
			btn0.Location = new Point(40, 445);
			btn0.Name = "btn0";
			btn0.Size = new Size(88, 78);
			btn0.TabIndex = 10;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += btn0_Click;
			// 
			// btn9
			// 
			btn9.Location = new Point(241, 152);
			btn9.Name = "btn9";
			btn9.Size = new Size(88, 78);
			btn9.TabIndex = 9;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += btn9_Click;
			// 
			// btn8
			// 
			btn8.Location = new Point(142, 152);
			btn8.Name = "btn8";
			btn8.Size = new Size(84, 78);
			btn8.TabIndex = 8;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += btn8_Click;
			// 
			// btn7
			// 
			btn7.Location = new Point(36, 152);
			btn7.Name = "btn7";
			btn7.Size = new Size(92, 78);
			btn7.TabIndex = 7;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += btn7_Click;
			// 
			// btn6
			// 
			btn6.Location = new Point(241, 246);
			btn6.Name = "btn6";
			btn6.Size = new Size(90, 78);
			btn6.TabIndex = 6;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += btn6_Click;
			// 
			// btnEqual
			// 
			btnEqual.Location = new Point(345, 445);
			btnEqual.Name = "btnEqual";
			btnEqual.Size = new Size(85, 78);
			btnEqual.TabIndex = 15;
			btnEqual.Text = "=";
			btnEqual.UseVisualStyleBackColor = true;
			btnEqual.Click += btnEqual_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.Location = new Point(345, 152);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new Size(84, 78);
			btnMultiply.TabIndex = 13;
			btnMultiply.Text = "*";
			btnMultiply.UseVisualStyleBackColor = true;
			btnMultiply.Click += btnMultiply_Click;
			// 
			// btnMinus
			// 
			btnMinus.Location = new Point(345, 246);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(85, 78);
			btnMinus.TabIndex = 12;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			btnMinus.Click += btnMinus_Click;
			// 
			// btnSum
			// 
			btnSum.Location = new Point(343, 345);
			btnSum.Name = "btnSum";
			btnSum.Size = new Size(86, 78);
			btnSum.TabIndex = 11;
			btnSum.Text = "+";
			btnSum.UseVisualStyleBackColor = true;
			btnSum.Click += btnSum_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(241, 445);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(90, 78);
			btnClear.TabIndex = 16;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(479, 574);
			Controls.Add(btnClear);
			Controls.Add(btnEqual);
			Controls.Add(btnDivide);
			Controls.Add(btnMultiply);
			Controls.Add(btnMinus);
			Controls.Add(btnSum);
			Controls.Add(btn0);
			Controls.Add(btn9);
			Controls.Add(btn8);
			Controls.Add(btn7);
			Controls.Add(btn6);
			Controls.Add(btn5);
			Controls.Add(btn4);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Controls.Add(txtDisplay);
			Name = "Form1";
			Text = "MyCalculator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtDisplay;
		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Button btn4;
		private Button btn5;
		private Button btn0;
		private Button btn9;
		private Button btn8;
		private Button btn7;
		private Button btn6;
		private Button btnEqual;
		private Button btnDivide;
		private Button btnMultiply;
		private Button btnMinus;
		private Button btnSum;
		private Button btnClear;
	}
}
