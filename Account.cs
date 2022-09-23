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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY\SQLEXPRESS;Initial Catalog=ATM Accounts Database;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void education_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if(accnum.Text == "" || name.Text == "" || pin.Text == "" || address.Text == "" || education.Text == "" || occupation.Text == "" || phone.Text == "" || govtid.Text == "" || dob.Text == "")
            {
                MessageBox.Show("Information Missing or Incomplete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    String s = "INSERT INTO ACCOUNT VALUES('"+name.Text+ "', '" + accnum.Text + "', '" + phone.Text + "', '" + address.Text + "','" + pin.Text + "', '" + govtid.Text + "', '" + education.SelectedItem.ToString() + "', '" + occupation.Text + "','" + dob.Value.Date + "', '" + bal + "')";
                    
                    SqlCommand cmd = new SqlCommand(s, conn);  
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Account Created Successfully", "WELCOME TO CORVICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There seems to be an issue\n ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void accnum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void accnum_Enter(object sender, EventArgs e)
        {
            if(accnum.Text == "8 - 12 digit account number")
            {
                accnum.Text = "";
                accnum.ForeColor = Color.Black;
            }
        }

        private void accnum_Leave(object sender, EventArgs e)
        {
            if(accnum.Text == "")
            {
                accnum.Text = "8 - 12 digit account number";
                accnum.ForeColor = Color.Silver;
            }
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if(phone.Text == "Ten digits")
            {
                phone.Text = "";
                phone.ForeColor = Color.Black; 
            }
        }
        private void phone_Leave(object sender, EventArgs e)
        {
            if(phone.Text == "")
            {
                phone.Text = "Ten digits";
                phone.ForeColor = Color.Silver;
            }
        }

        private void govtid_Enter(object sender, EventArgs e)
        {
            if(govtid.Text == "Ten digits")
            {
                govtid.Text = "";
                govtid.ForeColor = Color.Black;
            }
        }

        private void govtid_Leave(object sender, EventArgs e)
        {
            if(govtid.Text == "")
            {
                govtid.Text = "Ten digits";
                govtid.ForeColor = Color.Silver;
            }
        }

        private void pin_Enter(object sender, EventArgs e)
        {
            if(pin.Text == "Four digits")
            {
                pin.Text = "";
                pin.ForeColor = Color.Black;
            }
        }

        private void pin_Leave(object sender, EventArgs e)
        {
            if(pin.Text == "")
            {
                pin.Text = "Four digits";
                pin.ForeColor = Color.Silver;
            }
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
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
