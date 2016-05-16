namespace SlotMachine
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
            this.spin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.slotBox1 = new System.Windows.Forms.PictureBox();
            this.slotBox2 = new System.Windows.Forms.PictureBox();
            this.slotBox3 = new System.Windows.Forms.PictureBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.winnings = new System.Windows.Forms.Label();
            this.totalWon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // spin
            // 
            this.spin.Location = new System.Drawing.Point(187, 255);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(75, 23);
            this.spin.TabIndex = 0;
            this.spin.Text = "Spin";
            this.spin.UseVisualStyleBackColor = true;
            this.spin.Click += new System.EventHandler(this.spin_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(325, 255);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // slotBox1
            // 
            this.slotBox1.Image = global::SlotMachine.Properties.Resources.cherry;
            this.slotBox1.Location = new System.Drawing.Point(37, 70);
            this.slotBox1.Name = "slotBox1";
            this.slotBox1.Size = new System.Drawing.Size(169, 125);
            this.slotBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotBox1.TabIndex = 2;
            this.slotBox1.TabStop = false;
            // 
            // slotBox2
            // 
            this.slotBox2.Image = global::SlotMachine.Properties.Resources.orange;
            this.slotBox2.Location = new System.Drawing.Point(212, 70);
            this.slotBox2.Name = "slotBox2";
            this.slotBox2.Size = new System.Drawing.Size(169, 125);
            this.slotBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotBox2.TabIndex = 3;
            this.slotBox2.TabStop = false;
            // 
            // slotBox3
            // 
            this.slotBox3.Image = global::SlotMachine.Properties.Resources.strawberry;
            this.slotBox3.Location = new System.Drawing.Point(388, 70);
            this.slotBox3.Name = "slotBox3";
            this.slotBox3.Size = new System.Drawing.Size(165, 125);
            this.slotBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotBox3.TabIndex = 4;
            this.slotBox3.TabStop = false;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(325, 229);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 5;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(197, 232);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount Bet:";
            // 
            // winnings
            // 
            this.winnings.AutoSize = true;
            this.winnings.Location = new System.Drawing.Point(247, 293);
            this.winnings.Name = "winnings";
            this.winnings.Size = new System.Drawing.Size(102, 13);
            this.winnings.TabIndex = 7;
            this.winnings.Text = "Amount Won: $0.00";
            // 
            // totalWon
            // 
            this.totalWon.AutoSize = true;
            this.totalWon.Location = new System.Drawing.Point(232, 336);
            this.totalWon.Name = "totalWon";
            this.totalWon.Size = new System.Drawing.Size(129, 13);
            this.totalWon.TabIndex = 8;
            this.totalWon.Text = "Total Amount Won: $0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalWon);
            this.Controls.Add(this.winnings);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.slotBox3);
            this.Controls.Add(this.slotBox2);
            this.Controls.Add(this.slotBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.spin);
            this.Name = "Form1";
            this.Text = "Slot Machine v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.slotBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spin;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox slotBox1;
        private System.Windows.Forms.PictureBox slotBox2;
        private System.Windows.Forms.PictureBox slotBox3;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label winnings;
        private System.Windows.Forms.Label totalWon;
        private System.Windows.Forms.Label label1;
    }
}

