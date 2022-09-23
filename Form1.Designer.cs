namespace Automated_Teller_Machine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_title = new System.Windows.Forms.Label();
            this.main_logo = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title.ForeColor = System.Drawing.Color.White;
            this.main_title.Location = new System.Drawing.Point(243, 58);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(355, 58);
            this.main_title.TabIndex = 0;
            this.main_title.Text = "HORIZON ATM";
            this.main_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_logo
            // 
            this.main_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_logo.Image = ((System.Drawing.Image)(resources.GetObject("main_logo.Image")));
            this.main_logo.Location = new System.Drawing.Point(145, 148);
            this.main_logo.Name = "main_logo";
            this.main_logo.Size = new System.Drawing.Size(159, 165);
            this.main_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_logo.TabIndex = 1;
            this.main_logo.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(339, 393);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 20);
            this.status.TabIndex = 2;
            this.status.Text = "%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 443);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(830, 12);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(789, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(321, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(344, 119);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "Horizon bank is happy to extend our e-atm services to all our customers. kindly a" +
    "dhere to all the rules and regulations as directed by the legal bodies of the na" +
    "tion. Happy Banking!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 45;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(830, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.main_logo);
            this.Controls.Add(this.main_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMATED TELLER MACHINE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.PictureBox main_logo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

