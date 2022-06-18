
namespace The_Tickets_Form
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allowedGuestsLabel = new System.Windows.Forms.Label();
            this.guestTicketsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nextAvailableEntrylabel = new System.Windows.Forms.Label();
            this.totalTicketsOutstandinglabel = new System.Windows.Forms.Label();
            this.issueTicketButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketsListBox = new System.Windows.Forms.ListBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allowedGuestsLabel);
            this.groupBox1.Controls.Add(this.guestTicketsLabel);
            this.groupBox1.Location = new System.Drawing.Point(96, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may enter now: ";
            // 
            // allowedGuestsLabel
            // 
            this.allowedGuestsLabel.AutoSize = true;
            this.allowedGuestsLabel.Location = new System.Drawing.Point(3, 22);
            this.allowedGuestsLabel.Name = "allowedGuestsLabel";
            this.allowedGuestsLabel.Size = new System.Drawing.Size(51, 20);
            this.allowedGuestsLabel.TabIndex = 1;
            this.allowedGuestsLabel.Text = "label1";
            // 
            // guestTicketsLabel
            // 
            this.guestTicketsLabel.AutoSize = true;
            this.guestTicketsLabel.Location = new System.Drawing.Point(64, 35);
            this.guestTicketsLabel.Name = "guestTicketsLabel";
            this.guestTicketsLabel.Size = new System.Drawing.Size(0, 20);
            this.guestTicketsLabel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextAvailableEntrylabel);
            this.groupBox2.Controls.Add(this.totalTicketsOutstandinglabel);
            this.groupBox2.Controls.Add(this.issueTicketButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(96, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tickets Availability";
            // 
            // nextAvailableEntrylabel
            // 
            this.nextAvailableEntrylabel.AutoSize = true;
            this.nextAvailableEntrylabel.Location = new System.Drawing.Point(230, 67);
            this.nextAvailableEntrylabel.Name = "nextAvailableEntrylabel";
            this.nextAvailableEntrylabel.Size = new System.Drawing.Size(45, 20);
            this.nextAvailableEntrylabel.TabIndex = 6;
            this.nextAvailableEntrylabel.Text = "Hello";
            // 
            // totalTicketsOutstandinglabel
            // 
            this.totalTicketsOutstandinglabel.AutoSize = true;
            this.totalTicketsOutstandinglabel.Location = new System.Drawing.Point(230, 38);
            this.totalTicketsOutstandinglabel.Name = "totalTicketsOutstandinglabel";
            this.totalTicketsOutstandinglabel.Size = new System.Drawing.Size(45, 20);
            this.totalTicketsOutstandinglabel.TabIndex = 5;
            this.totalTicketsOutstandinglabel.Text = "Hello";
            // 
            // issueTicketButton
            // 
            this.issueTicketButton.Location = new System.Drawing.Point(31, 101);
            this.issueTicketButton.Name = "issueTicketButton";
            this.issueTicketButton.Size = new System.Drawing.Size(149, 31);
            this.issueTicketButton.TabIndex = 4;
            this.issueTicketButton.Text = "Issue Ticket";
            this.issueTicketButton.UseVisualStyleBackColor = true;
            this.issueTicketButton.Click += new System.EventHandler(this.issueTicketButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Next Available Entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Tickets Outstanding: ";
            // 
            // ticketsListBox
            // 
            this.ticketsListBox.FormattingEnabled = true;
            this.ticketsListBox.ItemHeight = 20;
            this.ticketsListBox.Location = new System.Drawing.Point(96, 297);
            this.ticketsListBox.Name = "ticketsListBox";
            this.ticketsListBox.Size = new System.Drawing.Size(405, 244);
            this.ticketsListBox.TabIndex = 5;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(96, 554);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(149, 31);
            this.optionsButton.TabIndex = 5;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(352, 554);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 31);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 597);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.ticketsListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label allowedGuestsLabel;
        private System.Windows.Forms.Label guestTicketsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button issueTicketButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ticketsListBox;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label nextAvailableEntrylabel;
        private System.Windows.Forms.Label totalTicketsOutstandinglabel;
    }
}

