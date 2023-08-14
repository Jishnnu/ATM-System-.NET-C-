using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form1()//Constructor
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick_1(sender, e);
            this.Opacity = 0.1;
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

        private void timer1_Tick_1(object sender, EventArgs e)
        {            
            this.timer1.Start();
            this.progressBar1.Increment(1);
            status.Text = "LOADING ... " + this.progressBar1.Value + " %";
            if(this.progressBar1.Value == 100)
            {
                this.progressBar1.Value = 0;
                this.timer1.Stop();                
                Login l = new Login();
                this.Hide(); 
                l.Show();                                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            timer1.Stop();
            res = MessageBox.Show("Are you sure you want to exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
                timer1.Start();
            }            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Opacity <= 1)
            {
                Opacity += .2;                 
            }
            else
            {
                timer2.Stop();
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Stop();
            }
            Opacity -= .2;
        }
    }
}
