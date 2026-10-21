using AiubBusManagementSystem.Services;
using Microsoft.Data.SqlClient;
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


namespace AiubBusManagementSystem.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly StudentService studentService = new StudentService();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            // Required fields check
            if (string.IsNullOrWhiteSpace(textBoxFullname.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxStudentID.Text) ||
                string.IsNullOrWhiteSpace(comboBoxDepertment.Text) ||
                comboBoxDepertment.Text == "Select Depertment")
            {
                MessageBox.Show("All fields must be filled.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trigger validation once
            textBoxPassword_TextChanged(textBoxPassword, EventArgs.Empty);
            textBoxEmail_TextChanged(textBoxEmail, EventArgs.Empty);

            // Stop if password/email invalid
            if (!string.IsNullOrEmpty(errorProviderPassword.GetError(textBoxPassword)) &&
                !string.IsNullOrEmpty(errorProviderEmail.GetError(textBoxEmail)))
            {
                MessageBox.Show("Fix password and email errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!string.IsNullOrEmpty(errorProviderEmail.GetError(textBoxEmail)))
            {
                MessageBox.Show("Fix email errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!string.IsNullOrEmpty(errorProviderPassword.GetError(textBoxPassword)))
            {
                MessageBox.Show("Fix password errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                studentService.RegisterStudent(
                    textBoxFullname.Text,
                    textBoxUserName.Text,
                    textBoxPassword.Text,
                    textBoxStudentID.Text,
                    comboBoxDepertment.Text,
                    textBoxEmail.Text

                );

                MessageBox.Show("Registration Successful!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxFullname.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxStudentID.Focus();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxStudentID.Focus();
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonRegistration.PerformClick();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                buttonRegistration.Focus();
            }
        }

        private void textBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                comboBoxDepertment.Focus();
            }
        }


        private void textBoxStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                comboBoxDepertment.Focus();
            }
        }

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBoxDepertment.Focus();
            }
        }

        private void textBoxStudentID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxPassword.Focus();
            }
        }

        private void comboBoxDepertment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxEmail.Focus();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 6)
            {
                errorProviderPassword.SetError(textBoxPassword, "Password must be more than 6 characters.");
            }
            else
            {
                errorProviderPassword.SetError(textBoxPassword, ""); // Clear the error
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple Email Regex
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                errorProviderEmail.SetError(textBoxEmail, "Invalid email format.");
            }
            else
            {
                errorProviderEmail.SetError(textBoxEmail, "");
            }
        }

        
    }
}
