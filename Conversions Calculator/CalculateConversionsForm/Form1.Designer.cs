
namespace CalculateConversionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.valueToConvertTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conversionsListBox = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.manageConversionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value To Convert";
            // 
            // valueToConvertTextBox
            // 
            this.valueToConvertTextBox.Location = new System.Drawing.Point(42, 63);
            this.valueToConvertTextBox.Name = "valueToConvertTextBox";
            this.valueToConvertTextBox.Size = new System.Drawing.Size(100, 26);
            this.valueToConvertTextBox.TabIndex = 1;
            this.valueToConvertTextBox.Tag = "Value To Convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversions";
            // 
            // conversionsListBox
            // 
            this.conversionsListBox.FormattingEnabled = true;
            this.conversionsListBox.ItemHeight = 20;
            this.conversionsListBox.Location = new System.Drawing.Point(42, 136);
            this.conversionsListBox.Name = "conversionsListBox";
            this.conversionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.conversionsListBox.Size = new System.Drawing.Size(268, 244);
            this.conversionsListBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(42, 397);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(127, 32);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(200, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 32);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // manageConversionsButton
            // 
            this.manageConversionsButton.Location = new System.Drawing.Point(367, 397);
            this.manageConversionsButton.Name = "manageConversionsButton";
            this.manageConversionsButton.Size = new System.Drawing.Size(243, 32);
            this.manageConversionsButton.TabIndex = 6;
            this.manageConversionsButton.Text = "Manage Conversions";
            this.manageConversionsButton.UseVisualStyleBackColor = true;
            this.manageConversionsButton.Click += new System.EventHandler(this.manageConversionsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(629, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 32);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(367, 40);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(351, 344);
            this.outputListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.manageConversionsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.conversionsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueToConvertTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueToConvertTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox conversionsListBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button manageConversionsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

