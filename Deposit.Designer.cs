namespace Automated_Teller_Machine
{
    partial class Deposit
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
            this.deposittb = new System.Windows.Forms.TextBox();
            this.depositbtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel2.TabIndex = 42;
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
            this.panel1.TabIndex = 41;
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
            this.label1.TabIndex = 49;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(273, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 58);
            this.label10.TabIndex = 3;
            this.label10.Text = "DEPOSIT";
            // 
            // deposittb
            // 
            this.deposittb.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.deposittb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deposittb.Location = new System.Drawing.Point(351, 175);
            this.deposittb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deposittb.Name = "deposittb";
            this.deposittb.Size = new System.Drawing.Size(188, 30);
            this.deposittb.TabIndex = 1;
            this.deposittb.TextChanged += new System.EventHandler(this.deposittb_TextChanged);
            // 
            // depositbtn
            // 
            this.depositbtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.depositbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositbtn.ForeColor = System.Drawing.Color.White;
            this.depositbtn.Location = new System.Drawing.Point(305, 251);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(160, 46);
            this.depositbtn.TabIndex = 2;
            this.depositbtn.Text = "DEPOSIT";
            this.depositbtn.UseVisualStyleBackColor = false;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(347, 311);
            this.back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 23);
            this.back.TabIndex = 3;
            this.back.Text = "BACK";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "AMOUNT";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deposittb);
            this.Controls.Add(this.depositbtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deposit_FormClosing);
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox deposittb;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}