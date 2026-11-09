
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ohtsuka_Act
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // LOGIN FUNCTIONALITY
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Check empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (OleDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    string query =
                        "SELECT COUNT(*) FROM Users " +
                        "WHERE Username = ? AND [Password] = ?";

                    using (OleDbCommand command =
                        new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int result =
                            Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Login successful! Welcome, Administrator.",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.Hide();

                            using (DashboardForm dashboard =
                                new DashboardForm())
                            {
                                dashboard.ShowDialog();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Incorrect username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // SHOW PASSWORD
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        // OPEN SIGN UP FORM
        private void lnkSignUp_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (SignUpForm signUp = new SignUpForm())
            {
                signUp.ShowDialog();
            }

            this.Show();
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        }
    }

