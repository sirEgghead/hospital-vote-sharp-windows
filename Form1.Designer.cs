namespace hospital_vote_sharp_windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            udTabs = new NumericUpDown();
            udTimeout = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVote = new Button();
            lblFirstName = new Label();
            lblSecondName = new Label();
            lblThirdName = new Label();
            lblFirstVotes = new Label();
            lblSecondVotes = new Label();
            lblThirdVotes = new Label();
            lblMargin12 = new Label();
            lblMargin23 = new Label();
            ((System.ComponentModel.ISupportInitialize)udTabs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udTimeout).BeginInit();
            SuspendLayout();
            // 
            // udTabs
            // 
            udTabs.Location = new Point(110, 146);
            udTabs.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            udTabs.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            udTabs.Name = "udTabs";
            udTabs.Size = new Size(38, 23);
            udTabs.TabIndex = 0;
            udTabs.Value = new decimal(new int[] { 3, 0, 0, 0 });
            udTabs.ValueChanged += udTabs_ValueChanged;
            // 
            // udTimeout
            // 
            udTimeout.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            udTimeout.Location = new Point(225, 146);
            udTimeout.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            udTimeout.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            udTimeout.Name = "udTimeout";
            udTimeout.Size = new Size(70, 23);
            udTimeout.TabIndex = 1;
            udTimeout.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            udTimeout.ValueChanged += udTimeout_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 148);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Tabs";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 148);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Timeout";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 40);
            label3.Name = "label3";
            label3.Size = new Size(295, 75);
            label3.TabIndex = 4;
            label3.Text = "Tabs - Number of tabs to run\r\nTimeout - Reconnect timeout that fools Cloudflare\r\n\r\nSettings can be adjusted without stopping the process.\r\nStatistics continue to update without voting.";
            // 
            // btnVote
            // 
            btnVote.Location = new Point(155, 203);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(75, 23);
            btnVote.TabIndex = 5;
            btnVote.Text = "Start";
            btnVote.UseVisualStyleBackColor = true;
            btnVote.Click += btnVote_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(44, 321);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(136, 23);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Place";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSecondName
            // 
            lblSecondName.Location = new Point(44, 366);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(136, 23);
            lblSecondName.TabIndex = 7;
            lblSecondName.Text = "Second Place";
            lblSecondName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblThirdName
            // 
            lblThirdName.Location = new Point(44, 413);
            lblThirdName.Name = "lblThirdName";
            lblThirdName.Size = new Size(136, 23);
            lblThirdName.TabIndex = 8;
            lblThirdName.Text = "Third Place";
            lblThirdName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFirstVotes
            // 
            lblFirstVotes.AutoSize = true;
            lblFirstVotes.Location = new Point(192, 325);
            lblFirstVotes.Name = "lblFirstVotes";
            lblFirstVotes.Size = new Size(60, 15);
            lblFirstVotes.TabIndex = 9;
            lblFirstVotes.Text = "First Votes";
            // 
            // lblSecondVotes
            // 
            lblSecondVotes.AutoSize = true;
            lblSecondVotes.Location = new Point(192, 370);
            lblSecondVotes.Name = "lblSecondVotes";
            lblSecondVotes.Size = new Size(77, 15);
            lblSecondVotes.TabIndex = 10;
            lblSecondVotes.Text = "Second Votes";
            // 
            // lblThirdVotes
            // 
            lblThirdVotes.AutoSize = true;
            lblThirdVotes.Location = new Point(192, 417);
            lblThirdVotes.Name = "lblThirdVotes";
            lblThirdVotes.Size = new Size(65, 15);
            lblThirdVotes.TabIndex = 11;
            lblThirdVotes.Text = "Third Votes";
            // 
            // lblMargin12
            // 
            lblMargin12.AutoSize = true;
            lblMargin12.Location = new Point(257, 347);
            lblMargin12.Name = "lblMargin12";
            lblMargin12.Size = new Size(54, 15);
            lblMargin12.TabIndex = 12;
            lblMargin12.Text = "Margin 1";
            // 
            // lblMargin23
            // 
            lblMargin23.AutoSize = true;
            lblMargin23.Location = new Point(257, 396);
            lblMargin23.Name = "lblMargin23";
            lblMargin23.Size = new Size(54, 15);
            lblMargin23.TabIndex = 13;
            lblMargin23.Text = "Margin 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(lblMargin23);
            Controls.Add(lblMargin12);
            Controls.Add(lblThirdVotes);
            Controls.Add(lblSecondVotes);
            Controls.Add(lblFirstVotes);
            Controls.Add(lblThirdName);
            Controls.Add(lblSecondName);
            Controls.Add(lblFirstName);
            Controls.Add(btnVote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(udTimeout);
            Controls.Add(udTabs);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Hospital Vote";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)udTabs).EndInit();
            ((System.ComponentModel.ISupportInitialize)udTimeout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown udTabs;
        private NumericUpDown udTimeout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVote;
        private Label lblFirstName;
        private Label lblSecondName;
        private Label lblThirdName;
        private Label lblFirstVotes;
        private Label lblSecondVotes;
        private Label lblThirdVotes;
        private Label lblMargin12;
        private Label lblMargin23;
    }
}
