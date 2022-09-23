namespace Automated_Teller_Machine
{
    partial class Home
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.fastcash = new System.Windows.Forms.Button();
            this.changepin = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 0;
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
            this.main_title.Location = new System.Drawing.Point(275, 31);
            this.main_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(281, 43);
            this.main_title.TabIndex = 2;
            this.main_title.Text = "TRANSACTIONS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 482);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(829, 16);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.SystemColors.MenuText;
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(459, 189);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(246, 46);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "WITHDRAW";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.SystemColors.MenuText;
            this.deposit.ForeColor = System.Drawing.Color.White;
            this.deposit.Location = new System.Drawing.Point(112, 189);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(246, 46);
            this.deposit.TabIndex = 2;
            this.deposit.Text = "DEPOSIT";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // fastcash
            // 
            this.fastcash.BackColor = System.Drawing.SystemColors.MenuText;
            this.fastcash.ForeColor = System.Drawing.Color.White;
            this.fastcash.Location = new System.Drawing.Point(112, 277);
            this.fastcash.Name = "fastcash";
            this.fastcash.Size = new System.Drawing.Size(246, 46);
            this.fastcash.TabIndex = 4;
            this.fastcash.Text = "FAST CASH";
            this.fastcash.UseVisualStyleBackColor = false;
            this.fastcash.Click += new System.EventHandler(this.fastcash_Click);
            // 
            // changepin
            // 
            this.changepin.BackColor = System.Drawing.SystemColors.MenuText;
            this.changepin.ForeColor = System.Drawing.Color.White;
            this.changepin.Location = new System.Drawing.Point(459, 277);
            this.changepin.Name = "changepin";
            this.changepin.Size = new System.Drawing.Size(246, 46);
            this.changepin.TabIndex = 5;
            this.changepin.Text = "CHANGE PIN";
            this.changepin.UseVisualStyleBackColor = false;
            this.changepin.Click += new System.EventHandler(this.changepin_Click);
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.SystemColors.MenuText;
            this.balance.ForeColor = System.Drawing.Color.White;
            this.balance.Location = new System.Drawing.Point(283, 358);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(246, 46);
            this.balance.TabIndex = 6;
            this.balance.Text = "BALANCE";
            this.balance.UseVisualStyleBackColor = false;
            this.balance.Click += new System.EventHandler(this.button6_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(362, 429);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(91, 23);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.signup_Click);
            // 
            // accnum
            // 
            this.accnum.AutoSize = true;
            this.accnum.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnum.Location = new System.Drawing.Point(228, 130);
            this.accnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(196, 23);
            this.accnum.TabIndex = 1;
            this.accnum.Text = "ACCOUNT NUMBER";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.changepin);
            this.Controls.Add(this.fastcash);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button fastcash;
        private System.Windows.Forms.Button changepin;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label accnum;
        private System.Windows.Forms.Timer timer1;
    }
}