using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automated_Teller_Machine
{
    public partial class Login : Form
    {
        public Login()//This is constructor
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY\SQLEXPRESS;Initial Catalog=ATM Accounts Database;Integrated Security=True");
        public static String accno;
        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String cmd = "SELECT COUNT(*) FROM ACCOUNT WHERE ACCOUNT = '" + accnum.Text + "' AND ATM_PIN = '"+pin.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd, conn);
                DataTable d = new DataTable();
                sda.Fill(d);
                if (d.Rows[0][0].ToString() == "1")
                {
                    accno = accnum.Text;
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Account Number or ATM Pin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void accnum_Enter(object sender, EventArgs e)
        {
            if(accnum.Text == "Enter 8 - 12 digit account number")
            {
                accnum.Text = "";
                accnum.ForeColor = Color.Black;
            }
        }

        private void accnum_Leave(object sender, EventArgs e)
        {
            if(accnum.Text == "")
            {
                accnum.Text = "Enter 8 - 12 digit account number";
                accnum.ForeColor = Color.Silver;
            }
        }

        private void pin_Enter(object sender, EventArgs e)
        {
            if(pin.Text == "Four Digits")
            {
                pin.Text = "";
                pin.ForeColor = Color.Black;
                pin.PasswordChar = '*';
            }
        }

        private void pin_Leave(object sender, EventArgs e)
        {
            if(pin.Text == "")
            {
                pin.Text = "Four Digits";
                pin.PasswordChar= '\0';
                pin.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void signup_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sp_CheckedChanged(object sender, EventArgs e)
        {
            if(sp.Checked == true)
            {
                pin.PasswordChar = '\0';
            }
            else
            {
                pin.PasswordChar = '*';
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            main_title.Focus();
            this.Opacity = 0.1;
            timer1.Start();
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
