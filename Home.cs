using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class Home : Form
    {
        public Home()//This is constructor
        {
            InitializeComponent();  
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public static String accno;
        private void signup_Click(object sender, EventArgs e)
        {
         
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();            
            b.Show();            
            this.Hide(); 
        }

        private void changepin_Click(object sender, EventArgs e)
        {
            ChangePin c = new ChangePin();            
            c.Show();
            this.Hide();
        }   

        private void fastcash_Click(object sender, EventArgs e)
        {
            FastCash f = new FastCash();            
            f.Show();
            this.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();            
            w.Show();
            this.Hide();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();            
            d.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start(); 
            accnum.Text = "ACCOUNT NUMBER : " + Login.accno;
            accno = Login.accno;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1)
            {
                Opacity += .2;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
