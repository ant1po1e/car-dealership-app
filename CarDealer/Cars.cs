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
    public partial class Cars : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=Car_Dealer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private int key;
        private string loggedUsername;

        private string query = "SELECT car.id, car.name AS Name, company.name AS Company, type.name AS Type, category.name AS Category, fuel.name AS FuelType FROM car INNER JOIN company ON car.idCompany = company.id INNER JOIN type ON car.idType = type.id INNER JOIN category ON car.idCategory = category.id INNER JOIN fuel ON car.idFuel = fuel.id";

        public Cars(string username)
        {
            InitializeComponent();

            usernameLabel.Text = username;
            loggedUsername = username;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadComboBoxes();
        }

        private void LoadDataGrid()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(sdr);

                    carsDataGridView.DataSource = dt;
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

        private void LoadComboBoxes()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    using (SqlCommand loadCompany = new SqlCommand("SELECT id, name FROM company", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(loadCompany);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        DataRow row = dt.NewRow();
                        row[1] = "--SELECT COMPANY--";
                        dt.Rows.InsertAt(row, 0);

                        companyBox.DataSource = dt;
                        companyBox.DisplayMember = "name";
                        companyBox.ValueMember = "id";
                    }

                    using (SqlCommand loadType = new SqlCommand("SELECT id, name FROM type", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(loadType);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        DataRow row = dt.NewRow();
                        row[1] = "--SELECT TYPE--";
                        dt.Rows.InsertAt(row, 0);

                        typeBox.DataSource = dt;
                        typeBox.DisplayMember = "name";
                        typeBox.ValueMember = "id";
                    }

                    using (SqlCommand loadCategory = new SqlCommand("SELECT id, name FROM category", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(loadCategory);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        DataRow row = dt.NewRow();
                        row[1] = "--SELECT CATEGORY--";
                        dt.Rows.InsertAt(row, 0);

                        categoryBox.DataSource = dt;
                        categoryBox.DisplayMember = "name";
                        categoryBox.ValueMember = "id";
                    }

                    using (SqlCommand loadFuel = new SqlCommand("SELECT id, name FROM fuel", conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(loadFuel);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        DataRow row = dt.NewRow();
                        row[1] = "--SELECT FUEL--";
                        dt.Rows.InsertAt(row, 0);

                        fuelBox.DataSource = dt;
                        fuelBox.DisplayMember = "name";
                        fuelBox.ValueMember = "id";
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

        private void ClearFields()
        {
            idBox.Clear();
            nameBox.Clear();
            companyBox.ResetText();
            typeBox.ResetText();
            categoryBox.ResetText();
            fuelBox.ResetText();
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

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nameBox.Text = carsDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            string companyName = carsDataGridView.SelectedRows[0].Cells["Company"].Value.ToString();
            companyBox.SelectedItem = companyBox.Items.Cast<DataRowView>().FirstOrDefault(item => item["name"].ToString() == companyName);

            string typeName = carsDataGridView.SelectedRows[0].Cells["Type"].Value.ToString();
            typeBox.SelectedItem = typeBox.Items.Cast<DataRowView>().FirstOrDefault(item => item["name"].ToString() == typeName);

            string categoryName = carsDataGridView.SelectedRows[0].Cells["Category"].Value.ToString();
            categoryBox.SelectedItem = categoryBox.Items.Cast<DataRowView>().FirstOrDefault(item => item["name"].ToString() == categoryName);

            string fuelName = carsDataGridView.SelectedRows[0].Cells["FuelType"].Value.ToString();
            fuelBox.SelectedItem = fuelBox.Items.Cast<DataRowView>().FirstOrDefault(item => item["name"].ToString() == fuelName);

            if (nameBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(carsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                idBox.Text = key.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO car (name, idCompany, idType, idCategory, idFuel) VALUES (@name, @company, @type, @category, @fuel)", conn);

                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@company", companyBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@type", typeBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@category", categoryBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@fuel", fuelBox.SelectedValue);

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
                        SqlCommand cmd = new SqlCommand("UPDATE car SET name = @name, idCompany = @company, idType = @type, idCategory = @category, idFuel = @fuel WHERE id = @ID", conn);

                        cmd.Parameters.AddWithValue("@name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@company", companyBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@type", typeBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@category", categoryBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@fuel", fuelBox.SelectedValue);
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
                        SqlCommand cmd = new SqlCommand("DELETE FROM car WHERE id = @ID", conn);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUsername);
            dashboard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Company company = new Company(loggedUsername);
            company.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Types types = new Types(loggedUsername);
            types.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string searchQuery = query + " WHERE car.name LIKE @searchText OR company.name LIKE @searchText OR type.name LIKE @searchText OR category.name LIKE @searchText OR fuel.name LIKE @searchText";
                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", '%' + searchBox.Text + '%');

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                carsDataGridView.DataSource = dt;
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