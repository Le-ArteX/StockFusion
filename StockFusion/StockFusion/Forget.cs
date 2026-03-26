using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StockFusion
{
    public partial class Forget : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";

        public Forget()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string username = roundedTextBox1.Text.Trim();
            string answer = roundedTextBox2.Text.Trim();
            string newPassword = roundedTextBox3.Text.Trim();
            string confirmPassword = roundedTextBox4.Text.Trim();

            // Check if any field is empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(answer) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                errorProvider1.SetError(roundedTextBox4, "Passwords do not match.");
                return;
            }

            if (!IsPasswordValid(newPassword))
            {
                errorProvider1.SetError(roundedTextBox3, "Password must be 6 to 20 characters long and contain at least two of the following: letters, numbers, or symbols.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if username and answer match
                    string query = "SELECT COUNT(*) FROM dbo.[SignUp] WHERE Username = @Username AND Answer = @Answer";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Answer", answer);

                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            errorProvider1.SetError(roundedTextBox1, "Incorrect username or security answer.");
                            errorProvider1.SetError(roundedTextBox2, "Incorrect username or security answer.");
                            return;
                        }
                    }

                    // Update the password
                    string updateQuery = "UPDATE dbo.[SignUp] SET Password = @NewPassword WHERE Username = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 6 || password.Length > 20)
            {
                return false;
            }

            // Check for at least two of the following: letters, numbers, or symbols
            int criteriaMet = 0;
            if (Regex.IsMatch(password, @"[a-zA-Z]")) criteriaMet++;
            if (Regex.IsMatch(password, @"[0-9]")) criteriaMet++;
            if (Regex.IsMatch(password, @"[^a-zA-Z0-9]")) criteriaMet++;

            return criteriaMet >= 2;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void roundedTextBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void roundedTextBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void roundedTextBox4_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}