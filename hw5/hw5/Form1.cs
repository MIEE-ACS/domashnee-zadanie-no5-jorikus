using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5
{
	
	public partial class Form1 : Form
	{
		class Complex_number
		{
			public string actual;
			public string imaginaryt;
			public Complex_number(string a, string b)
			{
				actual = a;
				imaginaryt = b;
			}

			public string print()
			{
				return String.Format($"{actual} + {imaginaryt}i");
			}

			public Complex_number sum(Complex_number z)
			{
				string a2 = z.actual;
				string b2 = z.imaginaryt;

				string res_a = Convert.ToString(Convert.ToDouble(actual) + Convert.ToDouble(a2));
				string res_b = Convert.ToString(Convert.ToDouble(imaginaryt) + Convert.ToDouble(b2));

				return new Complex_number(res_a, res_b);
			}

			public Complex_number raz(Complex_number z)
			{
				string a2 = z.actual;
				string b2 = z.imaginaryt;

				string res_a = Convert.ToString(Convert.ToDouble(actual) - Convert.ToDouble(a2));
				string res_b = Convert.ToString(Convert.ToDouble(imaginaryt) - Convert.ToDouble(b2));

				return new Complex_number(res_a, res_b);
			}
			public Complex_number pr(Complex_number z)
			{
				double a1 = Convert.ToDouble(actual);
				double b1 = Convert.ToDouble(imaginaryt);
				double a2 = Convert.ToDouble(z.actual);
				double b2 = Convert.ToDouble(z.imaginaryt);

				double temp1 = a1 * a2;
				double temp2 = (a1 * b2) + (b1 * a2);
				double temp3 = -(b1 * b2);
				temp1 += temp3;

				string res_a = Convert.ToString(temp1);
				string res_b = Convert.ToString(temp2);

				return new Complex_number(res_a, res_b);
			}
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Complex_number z1 = new Complex_number(textBox1.Text, textBox2.Text);
			Complex_number z2 = new Complex_number(textBox3.Text, textBox4.Text);
			Complex_number z3 = new Complex_number("0","0");


			int indx = comboBox1.SelectedIndex;

			if (indx == 0)
            {
				z3 = z1.sum(z2);
			}
			else if (indx == 1)
            {
				z3 = z1.raz(z2);
			}
			else if (indx == 2)
			{
				z3 = z1.pr(z2);
			}

			textBox6.Text = z3.actual;
			textBox5.Text = z3.imaginaryt;
		}
	}
}
