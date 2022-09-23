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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
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

        private void newpin_Enter(object sender, EventArgs e)
        {
            if (newpin.Text == "Four Digits")
            {
                newpin.Text = "";
                newpin.ForeColor = Color.Black;
                newpin.PasswordChar = '*';
            }
        }

        private void newpin_Leave(object sender, EventArgs e)
        {
            if (newpin.Text == "")
            {
                newpin.Text = "Four Digits";
                newpin.PasswordChar = '\0';
                newpin.ForeColor = Color.Silver;                
            }
        }

        private void confirmpin_Enter(object sender, EventArgs e)
        {
            if (confirmpin.Text == "Four Digits")
            {
                confirmpin.Text = "";                
                confirmpin.ForeColor = Color.Black;
                confirmpin.PasswordChar = '*';
            }
        }

        private void confirmpin_Leave(object sender, EventArgs e)
        {
            if (confirmpin.Text == "")
            {
                confirmpin.Text = "Four Digits";
                confirmpin.PasswordChar = '\0';
                confirmpin.ForeColor = Color.Silver;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY\SQLEXPRESS;Initial Catalog=ATM Accounts Database;Integrated Security=True");
        private void update_Click(object sender, EventArgs e)
        {
            if (newpin.Text == "" || confirmpin.Text == "")
            {
                MessageBox.Show("Enter new ATM Pin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(newpin.Text != confirmpin.Text)
            {
                MessageBox.Show("ATM Pin Mismatch. Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpin.Focus();
            }
            else
            {
                String accno = Login.accno;
                try
                {
                    conn.Open();
                    newpin.Focus();
                    String cmd = "UPDATE ACCOUNT SET ATM_PIN = '" + confirmpin.Text + "' WHERE ACCOUNT = '" + accno + "'";
                    SqlCommand sqlCommand = new SqlCommand(cmd, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("ATM Pin Updated Successful", "PIN UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There seems to be an issue\n ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Login l = new Login();
                    l.Show();
                    this.Hide();
                }
            }
        }

        private void sp_CheckedChanged(object sender, EventArgs e)
        {
            if (sp.Checked == true)
            {
                newpin.PasswordChar = '\0';
                confirmpin.PasswordChar = '\0';
            }
            else
            {
                newpin.PasswordChar = '*';
                confirmpin.PasswordChar = '*';
            }
        }

        private void ChangePin_FormClosing(object sender, FormClosingEventArgs e)
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
