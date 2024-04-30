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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarDealer
{
    public partial class Types : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=Car_Dealer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private int key;
        private string loggedUsername;

        public Types(string username)
        {
            InitializeComponent();

            usernameLabel.Text = username;
            loggedUsername = username;
        }

        private void Types_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM type", conn);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(sdr);

                    typeDataGridView.DataSource = dt;
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

        private bool IsValid()
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please fill the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void typeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nameBox.Text = typeDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            if (nameBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(typeDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                idBox.Text = key.ToString();
            }
        }

        private void ClearFields()
        {
            idBox.Clear();
            nameBox.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO type (name) VALUES (@name)", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    ClearFields();
                    LoadDataGrid();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.No)
                {
                    MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE type SET name = @name WHERE id = @ID", conn);
                        cmd.Parameters.AddWithValue("@name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@ID", key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ClearFields();
                        LoadDataGrid();
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.No)
                {
                    MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("s FROM type WHERE id = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ClearFields();
                        LoadDataGrid();
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUsername);
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars(loggedUsername);
            cars.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Company company = new Company(loggedUsername);
            company.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(loggedUsername);
            categories.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel(loggedUsername);
            fuel.Show();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM type WHERE name LIKE @searchText", conn);
                cmd.Parameters.AddWithValue("@searchText", '%' + searchBox.Text + '%');

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                typeDataGridView.DataSource = dt;
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