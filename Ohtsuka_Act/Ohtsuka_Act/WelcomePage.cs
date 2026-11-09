using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ohtsuka_Act
{
    public partial class WelcomePage : Form
    {
        private void TestDatabaseConnection()
        {
            try
            {
                using (OleDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database connected successfully!",
                        "Connection Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed!\n\n" + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        public WelcomePage()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (LoginForm login = new LoginForm())
            {
                login.ShowDialog();
            }

            this.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (SignUpForm signup = new SignUpForm())
            {
                signup.ShowDialog();
            }
            this.Show();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
