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
    public partial class Admin_user : Form
    {
        public Admin_user()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_customer2 obj = new Admin_customer2();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Stuff obj = new Admin_Stuff();
            obj.Show();
            this.Hide();
        }

        private void DASHBOARD_Click(object sender, EventArgs e)
        {
            Admin_main obj = new Admin_main();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin_report admin_Report = new Admin_report();
            admin_Report.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Admin_profile admin_Profile = new Admin_profile();
            admin_Profile.Show();
            this.Hide();
        }


        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
