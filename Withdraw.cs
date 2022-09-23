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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY\SQLEXPRESS;Initial Catalog=ATM Accounts Database;Integrated Security=True");
        String accno = Login.accno;
        int oldbal, newbal;
        private void getBalance()
        {
            try
            {
                conn.Open();
                String cmd = "SELECT BALANCE FROM ACCOUNT WHERE ACCOUNT = '" + accno + "'";

                SqlDataAdapter sda = new SqlDataAdapter(cmd, conn);
                DataTable d = new DataTable();
                sda.Fill(d);
                balance.Text = "AVAILABLE BALANCE : RS " + d.Rows[0][0].ToString();
                oldbal = Convert.ToInt32(d.Rows[0][0].ToString());
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
        private void Withdraw_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start(); 
            getBalance();
        }

        private void login_title_Click(object sender, EventArgs e)
        {

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

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            if (withdrawtb.Text == "")
            {
                MessageBox.Show("Amount missing. Enter the amount to withdraw", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(withdrawtb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount to withdraw", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(withdrawtb.Text) > oldbal)
            {
                MessageBox.Show("Enter a valid amount to withdraw", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - Convert.ToInt32(withdrawtb.Text);
                try
                {
                    conn.Open();
                    String cmd = "UPDATE ACCOUNT SET BALANCE = '" + newbal + "' WHERE ACCOUNT = '" + accno + "'";
                    SqlCommand sqlCommand = new SqlCommand(cmd, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful", "DEPOSIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There seems to be an issue\n ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();                    
                    Home h = new Home();
                    this.Hide();
                    h.Show();
                }
            }
        }

        private void Withdraw_FormClosing(object sender, FormClosingEventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
