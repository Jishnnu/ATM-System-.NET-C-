namespace Automated_Teller_Machine
{
    partial class Withdraw
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.withdrawtb = new System.Windows.Forms.TextBox();
            this.withdrawbtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 18);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(759, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(262, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 58);
            this.label10.TabIndex = 3;
            this.label10.Text = "WITHDRAW";
            // 
            // withdrawtb
            // 
            this.withdrawtb.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.withdrawtb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.withdrawtb.Location = new System.Drawing.Point(357, 216);
            this.withdrawtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.withdrawtb.Name = "withdrawtb";
            this.withdrawtb.Size = new System.Drawing.Size(188, 30);
            this.withdrawtb.TabIndex = 1;
            // 
            // withdrawbtn
            // 
            this.withdrawbtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.withdrawbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawbtn.ForeColor = System.Drawing.Color.White;
            this.withdrawbtn.Location = new System.Drawing.Point(306, 296);
            this.withdrawbtn.Name = "withdrawbtn";
            this.withdrawbtn.Size = new System.Drawing.Size(160, 46);
            this.withdrawbtn.TabIndex = 2;
            this.withdrawbtn.Text = "WITHDRAW";
            this.withdrawbtn.UseVisualStyleBackColor = false;
            this.withdrawbtn.Click += new System.EventHandler(this.withdrawbtn_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(348, 354);
            this.back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 23);
            this.back.TabIndex = 53;
            this.back.Text = "BACK";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "AMOUNT";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(236, 152);
            this.balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(213, 23);
            this.balance.TabIndex = 57;
            this.balance.Text = "AVAILABLE BALANCE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawtb);
            this.Controls.Add(this.withdrawbtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WITHDRAW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Withdraw_FormClosing);
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox withdrawtb;
        private System.Windows.Forms.Button withdrawbtn;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}