namespace Automated_Teller_Machine
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.main_title = new System.Windows.Forms.Label();
            this.login_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.main_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 125);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(789, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.White;
            this.main_title.Location = new System.Drawing.Point(235, 42);
            this.main_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(355, 58);
            this.main_title.TabIndex = 1;
            this.main_title.Text = "HORIZON ATM";
            // 
            // login_title
            // 
            this.login_title.AutoSize = true;
            this.login_title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_title.Location = new System.Drawing.Point(375, 160);
            this.login_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(135, 43);
            this.login_title.TabIndex = 1;
            this.login_title.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(133, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(133, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ACC NUMBER";
            // 
            // accnum
            // 
            this.accnum.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.accnum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.accnum.Location = new System.Drawing.Point(306, 255);
            this.accnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(313, 30);
            this.accnum.TabIndex = 4;
            this.accnum.Text = "Enter 8 - 12 digit account number";
            this.accnum.Enter += new System.EventHandler(this.accnum_Enter);
            this.accnum.Leave += new System.EventHandler(this.accnum_Leave);
            // 
            // pin
            // 
            this.pin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.pin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pin.Location = new System.Drawing.Point(306, 296);
            this.pin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(313, 30);
            this.pin.TabIndex = 5;
            this.pin.Text = "Four Digits";
            this.pin.TextChanged += new System.EventHandler(this.pin_TextChanged);
            this.pin.Enter += new System.EventHandler(this.pin_Enter);
            this.pin.Leave += new System.EventHandler(this.pin_Leave);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.MenuText;
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(326, 380);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(160, 46);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.signup.Location = new System.Drawing.Point(493, 392);
            this.signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(82, 23);
            this.signup.TabIndex = 7;
            this.signup.Text = "SIGNUP";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 13);
            this.panel2.TabIndex = 8;
            // 
            // sp
            // 
            this.sp.AutoSize = true;
            this.sp.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.sp.Location = new System.Drawing.Point(306, 341);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(139, 23);
            this.sp.TabIndex = 9;
            this.sp.Text = "Show Password";
            this.sp.UseVisualStyleBackColor = true;
            this.sp.CheckedChanged += new System.EventHandler(this.sp_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(821, 456);
            this.Controls.Add(this.sp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accnum;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox sp;
        private System.Windows.Forms.Timer timer1;
    }
}