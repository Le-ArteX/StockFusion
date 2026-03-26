using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace WindowsFormsApp1.Dashboard
{
    public partial class Admin_Stuff : Form
    {
        public Admin_Stuff()
        {
            InitializeComponent();
            LoadPendingUsers();
             LoadRegisteredUsers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void DASHBOARD_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin_user adminUserForm = new Admin_user();
            adminUserForm.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Admin_report admin_Report = new Admin_report();
            admin_Report.Show();
            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Admin_profile adminProfileForm = new Admin_profile();
            adminProfileForm.Show();
            this.Hide();
        }


        private void DASHBOARD_Click_1(object sender, EventArgs e)
        {
            Admin_main admin_Main = new Admin_main();
            admin_Main.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string userName = row.Cells["UserName"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Example: Show a message box with the selected user's details
                MessageBox.Show($"UserName: {userName}\nStatus: {status}", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadPendingUsers()
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PendingUsers";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    row["Password"] = HashPassword(row["Password"].ToString());
                }

                dataGridView2.DataSource = dt;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string userName = dataGridView2.SelectedRows[0].Cells["UserName"].Value.ToString();
                AddUserToSignUp(userName);
            }
        }
        private void AddUserToSignUp(string userName)
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SignUp (FullName, Email, Phonenumber, UserName, Password, UserType, Status) " +
                               "SELECT FullName, Email, Phonenumber, UserName, Password, UserType, 'Active' FROM PendingUsers WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                }

                query = "DELETE FROM PendingUsers WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadPendingUsers();
            LoadRegisteredUsers();
        }
        private void LoadRegisteredUsers()
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserName, FullName, Email, Phonenumber, UserType, Status, Password FROM SignUp";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    row["Password"] = HashPassword(row["Password"].ToString());
                }
                dataGridView1.DataSource = dt;
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string userName = dataGridView2.SelectedRows[0].Cells["UserName"].Value.ToString();
                DeleteUserFromPending(userName);
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                string userName = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                DeleteUserFromSignUp(userName);
            }
        }
        private void DeleteUserFromPending(string userName)
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM PendingUsers WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadPendingUsers();
        }

        private void DeleteUserFromSignUp(string userName)
        {
            string connectionString = @"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SignUp WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadRegisteredUsers();
        }
    }
}
