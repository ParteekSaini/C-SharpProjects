
namespace Basic_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.decimalDigit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(48, 24);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.Size = new System.Drawing.Size(367, 30);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clear
            // 
            this.clear.ForeColor = System.Drawing.Color.Red;
            this.clear.Location = new System.Drawing.Point(206, 68);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(209, 41);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // back
            // 
            this.back.ForeColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(48, 68);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // seven
            // 
            this.seven.ForeColor = System.Drawing.Color.Blue;
            this.seven.Location = new System.Drawing.Point(48, 124);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(52, 52);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // eight
            // 
            this.eight.ForeColor = System.Drawing.Color.Blue;
            this.eight.Location = new System.Drawing.Point(127, 124);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(52, 52);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // nine
            // 
            this.nine.ForeColor = System.Drawing.Color.Blue;
            this.nine.Location = new System.Drawing.Point(206, 124);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(52, 52);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // divide
            // 
            this.divide.ForeColor = System.Drawing.Color.Red;
            this.divide.Location = new System.Drawing.Point(285, 124);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(52, 52);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Two_Number_Operators_Entered);
            // 
            // sqrt
            // 
            this.sqrt.ForeColor = System.Drawing.Color.Blue;
            this.sqrt.Location = new System.Drawing.Point(363, 124);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(52, 52);
            this.sqrt.TabIndex = 8;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.One_NumberOperators_Entered);
            // 
            // four
            // 
            this.four.ForeColor = System.Drawing.Color.Blue;
            this.four.Location = new System.Drawing.Point(48, 195);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(52, 52);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // five
            // 
            this.five.ForeColor = System.Drawing.Color.Blue;
            this.five.Location = new System.Drawing.Point(127, 195);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(52, 52);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // six
            // 
            this.six.ForeColor = System.Drawing.Color.Blue;
            this.six.Location = new System.Drawing.Point(206, 195);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(52, 52);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // multiply
            // 
            this.multiply.ForeColor = System.Drawing.Color.Red;
            this.multiply.Location = new System.Drawing.Point(285, 195);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(52, 52);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Two_Number_Operators_Entered);
            // 
            // reciprocal
            // 
            this.reciprocal.ForeColor = System.Drawing.Color.Blue;
            this.reciprocal.Location = new System.Drawing.Point(363, 195);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(52, 52);
            this.reciprocal.TabIndex = 13;
            this.reciprocal.Text = "1/X";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.One_NumberOperators_Entered);
            // 
            // one
            // 
            this.one.ForeColor = System.Drawing.Color.Blue;
            this.one.Location = new System.Drawing.Point(48, 267);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(52, 52);
            this.one.TabIndex = 14;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // two
            // 
            this.two.ForeColor = System.Drawing.Color.Blue;
            this.two.Location = new System.Drawing.Point(127, 267);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(52, 52);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // three
            // 
            this.three.ForeColor = System.Drawing.Color.Blue;
            this.three.Location = new System.Drawing.Point(206, 267);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(52, 52);
            this.three.TabIndex = 16;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // subtract
            // 
            this.subtract.ForeColor = System.Drawing.Color.Red;
            this.subtract.Location = new System.Drawing.Point(285, 267);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(52, 52);
            this.subtract.TabIndex = 17;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.Two_Number_Operators_Entered);
            // 
            // zero
            // 
            this.zero.ForeColor = System.Drawing.Color.Blue;
            this.zero.Location = new System.Drawing.Point(48, 346);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(52, 52);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // changeSign
            // 
            this.changeSign.ForeColor = System.Drawing.Color.Blue;
            this.changeSign.Location = new System.Drawing.Point(127, 346);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(52, 52);
            this.changeSign.TabIndex = 19;
            this.changeSign.Text = "+/-";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.One_NumberOperators_Entered);
            // 
            // decimalDigit
            // 
            this.decimalDigit.ForeColor = System.Drawing.Color.Blue;
            this.decimalDigit.Location = new System.Drawing.Point(206, 346);
            this.decimalDigit.Name = "decimalDigit";
            this.decimalDigit.Size = new System.Drawing.Size(52, 52);
            this.decimalDigit.TabIndex = 20;
            this.decimalDigit.Text = ".";
            this.decimalDigit.UseVisualStyleBackColor = true;
            this.decimalDigit.Click += new System.EventHandler(this.Numbers_Entered);
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Red;
            this.add.Location = new System.Drawing.Point(285, 346);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(52, 52);
            this.add.TabIndex = 21;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Two_Number_Operators_Entered);
            // 
            // equal
            // 
            this.equal.ForeColor = System.Drawing.Color.Red;
            this.equal.Location = new System.Drawing.Point(363, 267);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(52, 131);
            this.equal.TabIndex = 22;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Equal_Buttton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.decimalDigit);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button decimalDigit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
    }
}

