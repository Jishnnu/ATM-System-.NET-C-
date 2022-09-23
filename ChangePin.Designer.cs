namespace Automated_Teller_Machine
{
    partial class ChangePin
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
            this.back = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.confirmpin = new System.Windows.Forms.TextBox();
            this.newpin = new System.Windows.Forms.TextBox();
            this.sp = new System.Windows.Forms.CheckBox();
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
            this.panel2.TabIndex = 32;
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
            this.panel1.TabIndex = 31;
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
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(225, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 58);
            this.label10.TabIndex = 3;
            this.label10.Text = "CHANGE PIN";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(342, 388);
            this.back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 23);
            this.back.TabIndex = 5;
            this.back.Text = "BACK";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "CONFIRM PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "NEW PIN";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.MenuText;
            this.update.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(303, 325);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(160, 46);
            this.update.TabIndex = 3;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // confirmpin
            // 
            this.confirmpin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.confirmpin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirmpin.Location = new System.Drawing.Point(374, 221);
            this.confirmpin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmpin.Name = "confirmpin";
            this.confirmpin.Size = new System.Drawing.Size(188, 30);
            this.confirmpin.TabIndex = 2;
            this.confirmpin.Text = "Four Digits";
            this.confirmpin.Enter += new System.EventHandler(this.confirmpin_Enter);
            this.confirmpin.Leave += new System.EventHandler(this.confirmpin_Leave);
            // 
            // newpin
            // 
            this.newpin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.newpin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newpin.Location = new System.Drawing.Point(374, 168);
            this.newpin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newpin.Name = "newpin";
            this.newpin.Size = new System.Drawing.Size(188, 30);
            this.newpin.TabIndex = 1;
            this.newpin.Text = "Four Digits";
            this.newpin.Enter += new System.EventHandler(this.newpin_Enter);
            this.newpin.Leave += new System.EventHandler(this.newpin_Leave);
            // 
            // sp
            // 
            this.sp.AutoSize = true;
            this.sp.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.sp.Location = new System.Drawing.Point(374, 271);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(154, 25);
            this.sp.TabIndex = 4;
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
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sp);
            this.Controls.Add(this.newpin);
            this.Controls.Add(this.update);
            this.Controls.Add(this.confirmpin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePin_FormClosing);
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox confirmpin;
        private System.Windows.Forms.TextBox newpin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sp;
        private System.Windows.Forms.Timer timer1;
    }
}