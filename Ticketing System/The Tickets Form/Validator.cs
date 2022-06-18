using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Tickets_Form
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

		public static bool IsDecimal(TextBox textBox)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
				textBox.Focus();
				return false;
			}
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
				MessageBox.Show(textBox.Tag + " must be an integer.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsDateTime(TextBox textBox)
        {
			DateTime time;
			if(DateTime.TryParse(textBox.Text , out time)){
				return true;
            }
            else
            {
				MessageBox.Show(title);
				return false;
            }
        }

		public static bool IsDateTimeEqualsTwoTimeSlots(TextBox textBoxStartTime , TextBox textBoxEndTime, TextBox minPerWindow)
        {
			DateTime startTime, endTime;
			int minPerWin;
			DateTime.TryParse(textBoxStartTime.Text, out startTime);
			DateTime.TryParse(textBoxEndTime.Text, out endTime);
			Int32.TryParse(minPerWindow.Text, out minPerWin);
			if((endTime-startTime).TotalMinutes >= 2 * minPerWin)
            {
				return true;
            }else
            {
				MessageBox.Show("Start Time and End Time should have the Difference of  atleast two timees the Time Slot");
				return false;
            }
		}
	}
}
