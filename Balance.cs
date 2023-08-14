using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class Balance : Form
    {
        public Balance()//This is constructor
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY\SQLEXPRESS;Initial Catalog=ATM Accounts Database;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void getBalance()
        {
            try
            {
                conn.Open();
                String cmd = "SELECT BALANCE FROM ACCOUNT WHERE ACCOUNT = '" + accnum.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(cmd, conn);
                DataTable d = new DataTable();
                sda.Fill(d);
                bal.Text = "RS " + d.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There seems to be an issue\n ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
            accnum.Text = Home.accno;
            getBalance();
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

        private void back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void bal_Click(object sender, EventArgs e)
        {            
        }

        private void Balance_FormClosing(object sender, FormClosingEventArgs e)
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
