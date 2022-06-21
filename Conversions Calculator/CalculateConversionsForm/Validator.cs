using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateConversionsForm
{
    public static class Validator
    {
		private static string title = "Entry Error";
		public static string Title
		{
			get => title;
			set => title = value;
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsInt32(TextBox textBox)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be either integer or double.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsDouble(TextBox textBox)
		{
			double number = 0;
			if (Double.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be either integer or double.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsNegative(TextBox textBox)
		{
			double number = 0;
			if (Double.TryParse(textBox.Text, out number) && number>0)
			{
					return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be greater than 0.", Title);
				textBox.Focus();
				return false;
			}
		}


	}
}
