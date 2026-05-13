namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceiverKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.MiningPreferenceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(14, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1570, 806);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 831);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 836);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 31);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 890);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add block";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1383, 940);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generate Wallet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1383, 1010);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "Validate Keys";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 839);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Location = new System.Drawing.Point(900, 835);
            this.PublicKeyTextBox.Multiline = true;
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PublicKeyTextBox.Size = new System.Drawing.Size(684, 29);
            this.PublicKeyTextBox.TabIndex = 7;
            this.PublicKeyTextBox.TextChanged += new System.EventHandler(this.PublicKeyTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 883);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(900, 880);
            this.PrivateKeyTextBox.Multiline = true;
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(684, 31);
            this.PrivateKeyTextBox.TabIndex = 9;
            this.PrivateKeyTextBox.TextChanged += new System.EventHandler(this.PrivateKeyTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 1115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Receiver Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ReceiverKeyTextBox
            // 
            this.ReceiverKeyTextBox.Location = new System.Drawing.Point(900, 1112);
            this.ReceiverKeyTextBox.Multiline = true;
            this.ReceiverKeyTextBox.Name = "ReceiverKeyTextBox";
            this.ReceiverKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceiverKeyTextBox.Size = new System.Drawing.Size(684, 28);
            this.ReceiverKeyTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 1060);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(288, 1057);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 31);
            this.AmountTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 1115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fee";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Location = new System.Drawing.Point(288, 1112);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(100, 31);
            this.FeeTextBox.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 1053);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 87);
            this.button5.TabIndex = 16;
            this.button5.Text = "Create Transaction";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 890);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 58);
            this.button6.TabIndex = 17;
            this.button6.Text = "Read All";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(31, 954);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(207, 93);
            this.button7.TabIndex = 18;
            this.button7.Text = "Read Pending Transactions";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1144, 940);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(233, 55);
            this.button8.TabIndex = 19;
            this.button8.Text = "Validate Blockchain";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1144, 1010);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(233, 55);
            this.button9.TabIndex = 20;
            this.button9.Text = "Check Balance";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(905, 940);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 55);
            this.button10.TabIndex = 21;
            this.button10.Text = "Tamper Block";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MiningPreferenceComboBox
            // 
            this.MiningPreferenceComboBox.FormattingEnabled = true;
            this.MiningPreferenceComboBox.Items.AddRange(new object[] {
            "Altruistic",
            "Greedy",
            "Random",
            "Address Preference"});
            this.MiningPreferenceComboBox.Location = new System.Drawing.Point(1275, 1169);
            this.MiningPreferenceComboBox.Name = "MiningPreferenceComboBox";
            this.MiningPreferenceComboBox.Size = new System.Drawing.Size(309, 33);
            this.MiningPreferenceComboBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1082, 1172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mining Preference";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(905, 1010);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 55);
            this.button11.TabIndex = 24;
            this.button11.Text = "Export Blockchain";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1614, 1205);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MiningPreferenceComboBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.FeeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReceiverKeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrivateKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PublicKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReceiverKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FeeTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox MiningPreferenceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
    }
}

