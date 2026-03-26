using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Dashboard;

namespace StockFusion
{
    public partial class SignIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True");

        public SignIn()
        {
            InitializeComponent();
            this.Click += new EventHandler(Form_Click);
            roundedTextBox1.TextChanged += new EventHandler(roundedTextBox1_TextChanged);
            roundedTextBox2.TextChanged += new EventHandler(roundedTextBox2_TextChanged);
        }

        private void Form_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void ValidateUsername()
        {
            labelInvalidUserNamePrompt.Visible = string.IsNullOrWhiteSpace(roundedTextBox1.Texts);
            labelInvalidUserNamePrompt.Text = "Enter username";
            labelInvalidUserNamePrompt.Location = new Point(286, 107);
        }

        private void roundedTextBox2_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void ValidatePassword()
        {
            labelInvalidPasswordPrompt.Visible = string.IsNullOrWhiteSpace(roundedTextBox2.Texts);
            labelInvalidPasswordPrompt.Text = "Enter password";
            labelInvalidPasswordPrompt.Location = new Point(249, 200);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roundedTextBox1.Texts) || string.IsNullOrWhiteSpace(roundedTextBox2.Texts))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader reader = null;
            try
            {
                string query = "SELECT Username, UserType, Status, Answer FROM Signup WHERE Username=@Username AND Password=@Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", roundedTextBox1.Texts);
                    cmd.Parameters.AddWithValue("@Password", roundedTextBox2.Texts);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string userType = reader["UserType"].ToString();
                        string status = reader["Status"].ToString();
                        string answer = reader["Answer"] != DBNull.Value ? reader["Answer"].ToString() : string.Empty; // Retrieve the security answer

                        if ((userType == "Manager" || userType == "FinancialManager") && status != "Active")
                        {
                            MessageBox.Show("Your account is inactive. Please contact support.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Store user details in session manager
                        SessionManager.Username = username;
                        SessionManager.UserType = userType;
                        SessionManager.Answer = answer; // Store security answer

                        reader.Close(); // Ensure reader is closed before executing another SQL command

                        switch (userType)
                        {
                            case "Admin":
                                new Admin_main().Show();
                                break;
                            case "Customer":
                                MessageBox.Show("Login successful for Customer");
                                break;
                            case "Manager":
                                MessageBox.Show("Login successful for Manager");
                                break;
                            case "FinancialManager":
                                MessageBox.Show("Login successful for Financial Manager");
                                break;
                            default:
                                MessageBox.Show("Invalid user type. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        InsertLogin(SessionManager.Username, "Active");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                con.Close();
            }
        }

        private void InsertLogin(string userName, string status)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Error: Username cannot be null or empty.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Login SET Status=@Status WHERE Username=@Username";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", userName);
                cmd.Parameters.AddWithValue("@Status", status);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(Show.Checked);
        }

        private void TogglePasswordVisibility(bool showPassword)
        {
            roundedTextBox2.PasswordChar = !showPassword;
        }
    }
}
