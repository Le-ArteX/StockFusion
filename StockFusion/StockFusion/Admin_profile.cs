using StockFusion;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dashboard
{
    public partial class Admin_profile : Form
    {
        private string currentUsername;

        public Admin_profile()
        {
            InitializeComponent();
            currentUsername = SessionManager.Username; // Get logged-in username
            LoadAdminProfile();
            SetTextBoxesReadOnly(true);
        }

        private void LoadAdminProfile()
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FullName, Email, Phonenumber, Username,Password FROM SignUp WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", currentUsername);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["FullName"].ToString();
                            textBox2.Text = reader["Email"].ToString();
                            textBox3.Text = reader["Phonenumber"].ToString();
                            textBox4.Text = reader["Username"].ToString();
                            textBox5.Text = reader["Password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the current user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            textBox1.ReadOnly = isReadOnly;
            textBox2.ReadOnly = isReadOnly;
            textBox3.ReadOnly = isReadOnly;
            textBox4.ReadOnly = true; // Username should always be read-only
            textBox5.ReadOnly = isReadOnly;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SignUp SET FullName = @FullName, Email = @Email, Phonenumber = @Phonenumber , Password= @Password WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Phonenumber", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Username", currentUsername);
                    cmd.Parameters.AddWithValue("@Password", textBox5.Text);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetTextBoxesReadOnly(true);
                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Admin_profile_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //FullName
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //email
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Phonenumber
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Username
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Password
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //edit button
            buttonEdit_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // update button
            buttonUpdate_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_user adminUserForm = new Admin_user();
            adminUserForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin_report adminReportForm = new Admin_report();
            adminReportForm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Admin_profile adminProfileForm = new Admin_profile();
            adminProfileForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_main adminMainForm = new Admin_main();
            adminMainForm.Show();
            this.Hide();
        }
    }
}
