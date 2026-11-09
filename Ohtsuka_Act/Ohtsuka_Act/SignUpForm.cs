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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get textbox values
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check empty fields
            if (fullName == "" || username == "" ||
                email == "" || password == "" ||
                confirmPassword == "")
            {
                MessageBox.Show(
                    "Please complete all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check password length
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must contain at least 6 characters.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Registration Failed",
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

                    // Check existing username or email
                    string checkQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username = ? OR Email = ?";

                    using (OleDbCommand checkCommand =
                        new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        checkCommand.Parameters.AddWithValue("@Email", email);

                        int existingAccount =
                            Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingAccount > 0)
                        {
                            MessageBox.Show(
                                "Username or email is already registered.",
                                "Registration Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    // Check if an administrator already exists
                    string adminQuery =
                        "SELECT COUNT(*) FROM Users WHERE AdminSlot = 1";

                    using (OleDbCommand adminCommand =
                        new OleDbCommand(adminQuery, connection))
                    {
                        int adminCount =
                            Convert.ToInt32(adminCommand.ExecuteScalar());

                        if (adminCount > 0)
                        {
                            MessageBox.Show(
                                "An administrator account already exists.",
                                "Registration Closed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            return;
                        }
                    }

                    // Insert new administrator account
                    string insertQuery =
                        "INSERT INTO Users " +
                        "(FullName, Username, Email, [Password], AdminSlot) " +
                        "VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand insertCommand =
                        new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@FullName", fullName);
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@AdminSlot", 1);

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Administrator account created successfully!",
                        "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !showPassword;
            txtConfirmPassword.UseSystemPasswordChar = !showPassword;
        }



        private void lnkLogin_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (LoginForm login = new LoginForm())
            {
                login.ShowDialog();
            }

            this.Show();
        }
    }
}
