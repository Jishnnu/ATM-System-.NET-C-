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
    public partial class FastCash : Form
    {
        public FastCash()
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
                bal.Text = "AVAILABLE BALANCE : RS " + d.Rows[0][0].ToString();
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

        private void FastCash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start(); 
            getBalance();
        }

        private void hundred_Click(object sender, EventArgs e)
        {
            if(oldbal <= 100)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 100;
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

        private void fivehundred_Click(object sender, EventArgs e)
        {
            if (oldbal <= 500)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 500;
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

        private void thousand_Click(object sender, EventArgs e)
        {
            if (oldbal <= 1000)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 1000;
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

        private void twothousand_Click(object sender, EventArgs e)
        {
            if (oldbal <= 2000)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 2000;
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

        private void fivethousand_Click(object sender, EventArgs e)
        {
            if (oldbal <= 5000)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 5000;
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

        private void tenthousand_Click(object sender, EventArgs e)
        {
            if(oldbal <= 10000)
            {
                MessageBox.Show("Withdrawal would leave the account with insufficient balance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbal = oldbal - 10000;
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

        private void FastCash_FormClosing(object sender, FormClosingEventArgs e)
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
