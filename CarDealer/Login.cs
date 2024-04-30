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

namespace CarDealer
{
    public partial class Login : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=Car_Dealer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", conn))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                            cmd.Parameters.AddWithValue("@password", passwordBox.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string username = dt.Rows[0]["username"].ToString();

                                MessageBox.Show("Logged in successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard dashboard = new Dashboard(username);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("incorrect username/password.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private bool IsValid()
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please input the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}