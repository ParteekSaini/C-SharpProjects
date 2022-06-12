using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calculator = new Calculator();
        Boolean equalsRepeated = false;
        

        private void Numbers_Entered(object sender , EventArgs e)
        {
            if(txtOutput.Text=="+" || txtOutput.Text=="-" || txtOutput.Text=="/" || txtOutput.Text == "*")
            {
                txtOutput.Text = "";
            }
            
            Button button = (Button)sender;
            txtOutput.Text += button.Text;
            equalsRepeated = false;
        }

        private void Two_Number_Operators_Entered(object sender , EventArgs e)
        {
            Button button = (Button)sender;
            calculator.Number1 = Double.Parse(txtOutput.Text);
            txtOutput.Text = button.Text;
            calculator.OperatorKey = txtOutput.Text;
            equalsRepeated = false;
        }

        private void Equal_Buttton_Click(object sender , EventArgs e)
        {
            if (equalsRepeated == false)
            {
                calculator.Number2 = Double.Parse(txtOutput.Text);
                calculator.Operation();
                txtOutput.Text = calculator.Result;
                equalsRepeated = true;
            }else if(equalsRepeated==true)
            {
                calculator.Number1 = Double.Parse(txtOutput.Text);
                calculator.Operation();
                txtOutput.Text = calculator.Result;
            }
            
        }

        private void One_NumberOperators_Entered(object sender , EventArgs e)
        {
            Button button = (Button)sender;
            calculator.Number1 = Double.Parse(txtOutput.Text);
            txtOutput.Text = "";
            
            calculator.OperatorKey = button.Text;
            calculator.Operation();
            txtOutput.Text = calculator.Result;
            equalsRepeated = false;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            String number = txtOutput.Text;
            number = number.Remove(number.Length - 1);
            txtOutput.Text = number;
            equalsRepeated = false;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            calculator.Number1 = 0;
            calculator.Number2 = 0;
            calculator.OperatorKey = "";
            txtOutput.Text = "";
            equalsRepeated = false;
        }
    }
}
