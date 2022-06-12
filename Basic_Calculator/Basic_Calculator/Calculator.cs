using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_Calculator
{
    class Calculator
    {
        private double number1;
        private double number2;
        private String operatorKey;
        private String result;

        public double Number1 { get => number1; set => number1 = value; }
        public double Number2 { get => number2; set => number2 = value; }
        public string OperatorKey { get => operatorKey; set => operatorKey = value; }
        public string Result { get => result; set => result = value; }

        public void Operation()
        {
            if (this.operatorKey == "+")
            {
                this.result = (this.number1 + this.number2).ToString();
            }else if (this.operatorKey == "-")
            {
                this.result = (this.number1 - this.number2).ToString();
            }else if (this.operatorKey == "/")
            {
                double divide=0;
                   divide = (this.number1 / this.number2);
                if (double.IsInfinity(divide))
                {
                    this.result = "Can not divide by Zero";
                }else
                {
                    this.result = divide.ToString();
                }
                // Here Divide by Zero Exception can not be applied beacuse this exception only work for 
                // intergers and decimal numbers and here I am using double, therefore, I used IsInfinity()
                // function for divide by zero case.
                
            }else if (this.operatorKey == "*")
            {
                this.result = (this.number1 * this.number2).ToString();
            }else if (this.operatorKey == "sqrt")
            {
                this.result = Math.Sqrt(this.number1).ToString();
            }else if(this.operatorKey == "1/X")
            {
                this.result = (1 / this.number1).ToString();
            }else if (this.operatorKey == "+/-")
            {
                this.result = (-(this.number1)).ToString();
            }
        }

       
    }
}
