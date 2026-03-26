using StockFusion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dashboard
{
    public partial class Admin_report : Form
    {
        public Admin_report()
        {
            InitializeComponent();
        }

        private void DASHBOARD_Click(object sender, EventArgs e)
        {
            Admin_main adminMainForm = new Admin_main();
            adminMainForm.Show();
            this.Hide();

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
            string currentUsername = "e"; 
            Admin_profile adminProfileForm = new Admin_profile();
            adminProfileForm.Show();
            this.Hide();
        }


        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
