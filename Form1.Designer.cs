namespace Bitcoin_Miner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bullButton3 = new BullButton();
            this.bullSeperator1 = new BullSeperator();
            this.bullButton2 = new BullButton();
            this.bullButton1 = new BullButton();
            this.bullTheme1 = new BullTheme();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wallet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // bullButton3
            // 
            this.bullButton3.Font = new System.Drawing.Font("Verdana", 8F);
            this.bullButton3.Image = null;
            this.bullButton3.Location = new System.Drawing.Point(43, 255);
            this.bullButton3.Name = "bullButton3";
            this.bullButton3.Size = new System.Drawing.Size(183, 30);
            this.bullButton3.TabIndex = 8;
            this.bullButton3.Text = "About";
            this.bullButton3.Click += new System.EventHandler(this.bullButton3_Click);
            // 
            // bullSeperator1
            // 
            this.bullSeperator1.Location = new System.Drawing.Point(0, 144);
            this.bullSeperator1.Name = "bullSeperator1";
            this.bullSeperator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bullSeperator1.Size = new System.Drawing.Size(284, 23);
            this.bullSeperator1.TabIndex = 3;
            this.bullSeperator1.Text = "bullSeperator1";
            // 
            // bullButton2
            // 
            this.bullButton2.Font = new System.Drawing.Font("Verdana", 8F);
            this.bullButton2.Image = null;
            this.bullButton2.Location = new System.Drawing.Point(43, 219);
            this.bullButton2.Name = "bullButton2";
            this.bullButton2.Size = new System.Drawing.Size(183, 30);
            this.bullButton2.TabIndex = 2;
            this.bullButton2.Text = "Get A Wallet";
            this.bullButton2.Click += new System.EventHandler(this.bullButton2_Click);
            // 
            // bullButton1
            // 
            this.bullButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.bullButton1.Image = null;
            this.bullButton1.Location = new System.Drawing.Point(43, 173);
            this.bullButton1.Name = "bullButton1";
            this.bullButton1.Size = new System.Drawing.Size(183, 38);
            this.bullButton1.TabIndex = 1;
            this.bullButton1.Text = "Start";
            this.bullButton1.Click += new System.EventHandler(this.bullButton1_Click);
            // 
            // bullTheme1
            // 
            this.bullTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bullTheme1.Font = new System.Drawing.Font("Verdana", 7F);
            this.bullTheme1.Location = new System.Drawing.Point(0, 0);
            this.bullTheme1.Name = "bullTheme1";
            this.bullTheme1.Size = new System.Drawing.Size(284, 299);
            this.bullTheme1.TabIndex = 0;
            this.bullTheme1.Text = "Crypto-Pump Miner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.bullButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bullSeperator1);
            this.Controls.Add(this.bullButton2);
            this.Controls.Add(this.bullButton1);
            this.Controls.Add(this.bullTheme1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BullTheme bullTheme1;
        private BullButton bullButton1;
        private BullButton bullButton2;
        private BullSeperator bullSeperator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BullButton bullButton3;
    }
}

