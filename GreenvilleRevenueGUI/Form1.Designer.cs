namespace GreenvilleRevenueGUI
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
            this.prompt1Label = new System.Windows.Forms.Label();
            this.prompt2Label = new System.Windows.Forms.Label();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.revenueButton = new System.Windows.Forms.Button();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.revenueOutputLabel = new System.Windows.Forms.Label();
            this.contestantsLabel = new System.Windows.Forms.Label();
            this.contestantsOutputLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prompt1Label
            // 
            this.prompt1Label.AutoSize = true;
            this.prompt1Label.Location = new System.Drawing.Point(44, 30);
            this.prompt1Label.Name = "prompt1Label";
            this.prompt1Label.Size = new System.Drawing.Size(278, 13);
            this.prompt1Label.TabIndex = 0;
            this.prompt1Label.Text = "Enter the number of contestants in last year\'s competition:";
            // 
            // prompt2Label
            // 
            this.prompt2Label.AutoSize = true;
            this.prompt2Label.Location = new System.Drawing.Point(47, 71);
            this.prompt2Label.Name = "prompt2Label";
            this.prompt2Label.Size = new System.Drawing.Size(278, 13);
            this.prompt2Label.TabIndex = 2;
            this.prompt2Label.Text = "Enter the number of contestants in this year\'s competition:";
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.Location = new System.Drawing.Point(353, 30);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(171, 20);
            this.lastYearTextBox.TabIndex = 3;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.Location = new System.Drawing.Point(353, 71);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(171, 20);
            this.thisYearTextBox.TabIndex = 4;
            // 
            // revenueButton
            // 
            this.revenueButton.Location = new System.Drawing.Point(210, 153);
            this.revenueButton.Name = "revenueButton";
            this.revenueButton.Size = new System.Drawing.Size(135, 37);
            this.revenueButton.TabIndex = 5;
            this.revenueButton.Text = "Calculate Revenue";
            this.revenueButton.UseVisualStyleBackColor = true;
            this.revenueButton.Click += new System.EventHandler(this.revenueButton_Click);
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Location = new System.Drawing.Point(268, 251);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(99, 13);
            this.revenueLabel.TabIndex = 6;
            this.revenueLabel.Text = "Expected Revenue";
            // 
            // revenueOutputLabel
            // 
            this.revenueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueOutputLabel.Location = new System.Drawing.Point(398, 251);
            this.revenueOutputLabel.Name = "revenueOutputLabel";
            this.revenueOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.revenueOutputLabel.TabIndex = 7;
            // 
            // contestantsLabel
            // 
            this.contestantsLabel.AutoSize = true;
            this.contestantsLabel.Location = new System.Drawing.Point(47, 284);
            this.contestantsLabel.Name = "contestantsLabel";
            this.contestantsLabel.Size = new System.Drawing.Size(320, 13);
            this.contestantsLabel.TabIndex = 8;
            this.contestantsLabel.Text = "Will this year\'s competition have more contestants than last year\'s?";
            // 
            // contestantsOutputLabel
            // 
            this.contestantsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contestantsOutputLabel.Location = new System.Drawing.Point(398, 283);
            this.contestantsOutputLabel.Name = "contestantsOutputLabel";
            this.contestantsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.contestantsOutputLabel.TabIndex = 9;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(423, 115);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(101, 13);
            this.feeLabel.TabIndex = 10;
            this.feeLabel.Text = "Entrance Fee = $25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 327);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.contestantsOutputLabel);
            this.Controls.Add(this.contestantsLabel);
            this.Controls.Add(this.revenueOutputLabel);
            this.Controls.Add(this.revenueLabel);
            this.Controls.Add(this.revenueButton);
            this.Controls.Add(this.thisYearTextBox);
            this.Controls.Add(this.lastYearTextBox);
            this.Controls.Add(this.prompt2Label);
            this.Controls.Add(this.prompt1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt1Label;
        private System.Windows.Forms.Label prompt2Label;
        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.Button revenueButton;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.Label revenueOutputLabel;
        private System.Windows.Forms.Label contestantsLabel;
        private System.Windows.Forms.Label contestantsOutputLabel;
        private System.Windows.Forms.Label feeLabel;
    }
}

