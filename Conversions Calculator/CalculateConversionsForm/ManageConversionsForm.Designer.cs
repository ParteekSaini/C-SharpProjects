
namespace CalculateConversionsForm
{
    partial class ManageConversionsForm
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
            this.conversionsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.restoreDetailsButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversionsListBox
            // 
            this.conversionsListBox.FormattingEnabled = true;
            this.conversionsListBox.ItemHeight = 20;
            this.conversionsListBox.Location = new System.Drawing.Point(44, 42);
            this.conversionsListBox.Name = "conversionsListBox";
            this.conversionsListBox.Size = new System.Drawing.Size(486, 284);
            this.conversionsListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conversions";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(44, 347);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(92, 38);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(157, 347);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 38);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // restoreDetailsButton
            // 
            this.restoreDetailsButton.Location = new System.Drawing.Point(282, 347);
            this.restoreDetailsButton.Name = "restoreDetailsButton";
            this.restoreDetailsButton.Size = new System.Drawing.Size(248, 38);
            this.restoreDetailsButton.TabIndex = 6;
            this.restoreDetailsButton.Text = "Restore Details";
            this.restoreDetailsButton.UseVisualStyleBackColor = true;
            this.restoreDetailsButton.Click += new System.EventHandler(this.restoreDetailsButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(213, 399);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(135, 39);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(371, 399);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(159, 39);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ManageConversionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.restoreDetailsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conversionsListBox);
            this.Name = "ManageConversionsForm";
            this.Text = "ManageConversionsForm";
            this.Load += new System.EventHandler(this.ManageConversionsLoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox conversionsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button restoreDetailsButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
    }
}