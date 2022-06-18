
namespace The_Tickets_Form
{
    partial class Options
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minutesPerWindow = new System.Windows.Forms.TextBox();
            this.guestsPerWindow = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.firstTicketNumber = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes Per Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests Per Window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Ticket Number";
            // 
            // minutesPerWindow
            // 
            this.minutesPerWindow.Location = new System.Drawing.Point(276, 52);
            this.minutesPerWindow.Name = "minutesPerWindow";
            this.minutesPerWindow.Size = new System.Drawing.Size(100, 26);
            this.minutesPerWindow.TabIndex = 5;
            // 
            // guestsPerWindow
            // 
            this.guestsPerWindow.Location = new System.Drawing.Point(276, 101);
            this.guestsPerWindow.Name = "guestsPerWindow";
            this.guestsPerWindow.Size = new System.Drawing.Size(100, 26);
            this.guestsPerWindow.TabIndex = 6;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(276, 146);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(100, 26);
            this.startTime.TabIndex = 7;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(276, 196);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(100, 26);
            this.endTime.TabIndex = 8;
            // 
            // firstTicketNumber
            // 
            this.firstTicketNumber.Location = new System.Drawing.Point(276, 239);
            this.firstTicketNumber.Name = "firstTicketNumber";
            this.firstTicketNumber.Size = new System.Drawing.Size(100, 26);
            this.firstTicketNumber.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(276, 315);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(153, 30);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.firstTicketNumber);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.guestsPerWindow);
            this.Controls.Add(this.minutesPerWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minutesPerWindow;
        private System.Windows.Forms.TextBox guestsPerWindow;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.TextBox firstTicketNumber;
        private System.Windows.Forms.Button buttonOK;
    }
}