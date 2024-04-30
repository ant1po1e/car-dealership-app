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
    public partial class Dashboard : Form
    {
        private string loggedUsername;

        public Dashboard(string username)
        {
            InitializeComponent();

            usernameLabel.Text = username;
            loggedUsername = username;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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
    }
}