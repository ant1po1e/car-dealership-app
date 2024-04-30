using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace CarDealer
{
    public partial class Register : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=Car_Dealer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(emailBox.Text) && IsValid())
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand getUser = new SqlCommand("SELECT * FROM users WHERE username = @username", conn))
                        {
                            getUser.Parameters.AddWithValue("@username", usernameBox.Text.Trim());

                            SqlDataAdapter sda = new SqlDataAdapter(getUser);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Username already exist.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (username, email, password) VALUES (@username, @email, @password)", conn))
                                {
                                    insertUser.Parameters.AddWithValue("@username", usernameBox.Text);
                                    insertUser.Parameters.AddWithValue("@email", emailBox.Text);
                                    insertUser.Parameters.AddWithValue("@password", passwordBox.Text);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("User registered successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();
                                }
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

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                MessageBox.Show("Please input valid email addres.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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

        private void label6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private bool IsValid()
        {
            if (usernameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please input the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}