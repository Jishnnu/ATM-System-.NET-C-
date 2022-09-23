namespace Automated_Teller_Machine
{
    partial class Account
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.main_title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.education = new System.Windows.Forms.ComboBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.govtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.main_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 100);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1043, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(315, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(456, 58);
            this.label10.TabIndex = 2;
            this.label10.Text = "CREATE ACCOUNT";
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.White;
            this.main_title.Location = new System.Drawing.Point(337, 21);
            this.main_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(360, 58);
            this.main_title.TabIndex = 2;
            this.main_title.Text = "CORVICE ATM";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.name.Location = new System.Drawing.Point(218, 196);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(270, 30);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // accnum
            // 
            this.accnum.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.accnum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.accnum.Location = new System.Drawing.Point(218, 249);
            this.accnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(270, 30);
            this.accnum.TabIndex = 2;
            this.accnum.Text = "8 - 12 digit account number";
            this.accnum.TextChanged += new System.EventHandler(this.accnum_TextChanged);
            this.accnum.Enter += new System.EventHandler(this.accnum_Enter);
            this.accnum.Leave += new System.EventHandler(this.accnum_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ACCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "PHONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "ATM PIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.phone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phone.Location = new System.Drawing.Point(218, 307);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(270, 30);
            this.phone.TabIndex = 3;
            this.phone.Text = "Ten digits";
            this.phone.Enter += new System.EventHandler(this.phone_Enter);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // pin
            // 
            this.pin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.pin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pin.Location = new System.Drawing.Point(734, 196);
            this.pin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(270, 30);
            this.pin.TabIndex = 5;
            this.pin.Text = "Four digits";
            this.pin.TextChanged += new System.EventHandler(this.pin_TextChanged);
            this.pin.Enter += new System.EventHandler(this.pin_Enter);
            this.pin.Leave += new System.EventHandler(this.pin_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "EDUCATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "OCCUPATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(554, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "DOB";
            // 
            // education
            // 
            this.education.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.education.FormattingEnabled = true;
            this.education.Items.AddRange(new object[] {
            "None",
            "Undergraduate",
            "Postgraduate",
            "PhD"});
            this.education.Location = new System.Drawing.Point(734, 308);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(270, 29);
            this.education.TabIndex = 7;
            this.education.SelectedIndexChanged += new System.EventHandler(this.education_SelectedIndexChanged);
            // 
            // dob
            // 
            this.dob.CalendarFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dob.Location = new System.Drawing.Point(734, 420);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(270, 30);
            this.dob.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(0, 626);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 21);
            this.panel3.TabIndex = 25;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.MenuText;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(457, 511);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(160, 46);
            this.submit.TabIndex = 10;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // govtid
            // 
            this.govtid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.govtid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.govtid.Location = new System.Drawing.Point(734, 249);
            this.govtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.govtid.Name = "govtid";
            this.govtid.Size = new System.Drawing.Size(270, 30);
            this.govtid.TabIndex = 6;
            this.govtid.Text = "Ten digits";
            this.govtid.Enter += new System.EventHandler(this.govtid_Enter);
            this.govtid.Leave += new System.EventHandler(this.govtid_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(551, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "GOVT ID";
            // 
            // occupation
            // 
            this.occupation.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.occupation.Location = new System.Drawing.Point(734, 365);
            this.occupation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(270, 30);
            this.occupation.TabIndex = 8;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.address.Location = new System.Drawing.Point(218, 365);
            this.address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(270, 83);
            this.address.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "ADDRESS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 54;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1084, 647);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.occupation);
            this.Controls.Add(this.govtid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.education);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Account_FormClosing);
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox education;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox govtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox occupation;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}