namespace Automated_Teller_Machine
{
    partial class FastCash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.main_title = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.tenthousand = new System.Windows.Forms.Button();
            this.fivethousand = new System.Windows.Forms.Button();
            this.twothousand = new System.Windows.Forms.Button();
            this.thousand = new System.Windows.Forms.Button();
            this.hundred = new System.Windows.Forms.Button();
            this.fivehundred = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.main_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 100);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(788, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.main_title.ForeColor = System.Drawing.Color.White;
            this.main_title.Location = new System.Drawing.Point(295, 31);
            this.main_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(201, 43);
            this.main_title.TabIndex = 2;
            this.main_title.Text = "FAST CASH";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(367, 440);
            this.back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 23);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tenthousand
            // 
            this.tenthousand.BackColor = System.Drawing.SystemColors.MenuText;
            this.tenthousand.ForeColor = System.Drawing.Color.White;
            this.tenthousand.Location = new System.Drawing.Point(459, 360);
            this.tenthousand.Name = "tenthousand";
            this.tenthousand.Size = new System.Drawing.Size(246, 46);
            this.tenthousand.TabIndex = 7;
            this.tenthousand.Text = "RS 10000";
            this.tenthousand.UseVisualStyleBackColor = false;
            this.tenthousand.Click += new System.EventHandler(this.tenthousand_Click);
            // 
            // fivethousand
            // 
            this.fivethousand.BackColor = System.Drawing.SystemColors.MenuText;
            this.fivethousand.ForeColor = System.Drawing.Color.White;
            this.fivethousand.Location = new System.Drawing.Point(112, 360);
            this.fivethousand.Name = "fivethousand";
            this.fivethousand.Size = new System.Drawing.Size(246, 46);
            this.fivethousand.TabIndex = 6;
            this.fivethousand.Text = "RS 5000";
            this.fivethousand.UseVisualStyleBackColor = false;
            this.fivethousand.Click += new System.EventHandler(this.fivethousand_Click);
            // 
            // twothousand
            // 
            this.twothousand.BackColor = System.Drawing.SystemColors.MenuText;
            this.twothousand.ForeColor = System.Drawing.Color.White;
            this.twothousand.Location = new System.Drawing.Point(459, 277);
            this.twothousand.Name = "twothousand";
            this.twothousand.Size = new System.Drawing.Size(246, 46);
            this.twothousand.TabIndex = 5;
            this.twothousand.Text = "RS 2000";
            this.twothousand.UseVisualStyleBackColor = false;
            this.twothousand.Click += new System.EventHandler(this.twothousand_Click);
            // 
            // thousand
            // 
            this.thousand.BackColor = System.Drawing.SystemColors.MenuText;
            this.thousand.ForeColor = System.Drawing.Color.White;
            this.thousand.Location = new System.Drawing.Point(112, 277);
            this.thousand.Name = "thousand";
            this.thousand.Size = new System.Drawing.Size(246, 46);
            this.thousand.TabIndex = 4;
            this.thousand.Text = "RS 1000";
            this.thousand.UseVisualStyleBackColor = false;
            this.thousand.Click += new System.EventHandler(this.thousand_Click);
            // 
            // hundred
            // 
            this.hundred.BackColor = System.Drawing.SystemColors.MenuText;
            this.hundred.ForeColor = System.Drawing.Color.White;
            this.hundred.Location = new System.Drawing.Point(112, 189);
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(246, 46);
            this.hundred.TabIndex = 2;
            this.hundred.Text = "RS 100";
            this.hundred.UseVisualStyleBackColor = false;
            this.hundred.Click += new System.EventHandler(this.hundred_Click);
            // 
            // fivehundred
            // 
            this.fivehundred.BackColor = System.Drawing.SystemColors.MenuText;
            this.fivehundred.ForeColor = System.Drawing.Color.White;
            this.fivehundred.Location = new System.Drawing.Point(459, 189);
            this.fivehundred.Name = "fivehundred";
            this.fivehundred.Size = new System.Drawing.Size(246, 46);
            this.fivehundred.TabIndex = 3;
            this.fivehundred.Text = "RS 500";
            this.fivehundred.UseVisualStyleBackColor = false;
            this.fivehundred.Click += new System.EventHandler(this.fivehundred_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 482);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(829, 16);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // bal
            // 
            this.bal.AutoSize = true;
            this.bal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal.Location = new System.Drawing.Point(245, 124);
            this.bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(213, 23);
            this.bal.TabIndex = 1;
            this.bal.Text = "AVAILABLE BALANCE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FastCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tenthousand);
            this.Controls.Add(this.fivethousand);
            this.Controls.Add(this.twothousand);
            this.Controls.Add(this.thousand);
            this.Controls.Add(this.hundred);
            this.Controls.Add(this.fivehundred);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastCash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FastCash_FormClosing);
            this.Load += new System.EventHandler(this.FastCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button tenthousand;
        private System.Windows.Forms.Button fivethousand;
        private System.Windows.Forms.Button twothousand;
        private System.Windows.Forms.Button thousand;
        private System.Windows.Forms.Button hundred;
        private System.Windows.Forms.Button fivehundred;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label bal;
        private System.Windows.Forms.Timer timer1;
    }
}