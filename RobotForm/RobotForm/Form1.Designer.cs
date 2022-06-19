
namespace RobotForm
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
            this.nButton = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.Button();
            this.wButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.go10Button = new System.Windows.Forms.Button();
            this.go1Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nButton
            // 
            this.nButton.Location = new System.Drawing.Point(216, 280);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(75, 32);
            this.nButton.TabIndex = 1;
            this.nButton.Text = "N";
            this.nButton.UseVisualStyleBackColor = true;
            this.nButton.Click += new System.EventHandler(this.nButton_Click);
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(216, 328);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(75, 36);
            this.sButton.TabIndex = 2;
            this.sButton.Text = "S";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // wButton
            // 
            this.wButton.Location = new System.Drawing.Point(136, 299);
            this.wButton.Name = "wButton";
            this.wButton.Size = new System.Drawing.Size(74, 42);
            this.wButton.TabIndex = 3;
            this.wButton.Text = "W";
            this.wButton.UseVisualStyleBackColor = true;
            this.wButton.Click += new System.EventHandler(this.wButton_Click);
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(297, 299);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(75, 42);
            this.eButton.TabIndex = 4;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // go10Button
            // 
            this.go10Button.Location = new System.Drawing.Point(378, 299);
            this.go10Button.Name = "go10Button";
            this.go10Button.Size = new System.Drawing.Size(139, 42);
            this.go10Button.TabIndex = 5;
            this.go10Button.Text = "Go To 10";
            this.go10Button.UseVisualStyleBackColor = true;
            this.go10Button.Click += new System.EventHandler(this.go10Button_Click);
            // 
            // go1Button
            // 
            this.go1Button.Location = new System.Drawing.Point(51, 299);
            this.go1Button.Name = "go1Button";
            this.go1Button.Size = new System.Drawing.Size(79, 42);
            this.go1Button.TabIndex = 6;
            this.go1Button.Text = "GO 1";
            this.go1Button.UseVisualStyleBackColor = true;
            this.go1Button.Click += new System.EventHandler(this.go1Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(297, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 28);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(58, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 228);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(123, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.go1Button);
            this.Controls.Add(this.go10Button);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.wButton);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.nButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nButton;
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Button wButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button go10Button;
        private System.Windows.Forms.Button go1Button;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

