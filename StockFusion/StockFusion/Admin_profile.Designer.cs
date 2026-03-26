namespace WindowsFormsApp1.Dashboard
{
    partial class Admin_profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            button14 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button13 = new Button();
            button11 = new Button();
            button9 = new Button();
            DASHBOARD = new Button();
            button12 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(button14);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 79);
            panel2.TabIndex = 50;
            // 
            // button14
            // 
            button14.BackgroundImageLayout = ImageLayout.None;
            button14.Enabled = false;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.Black;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(0, 7);
            button14.Name = "button14";
            button14.Size = new Size(161, 49);
            button14.TabIndex = 14;
            button14.Text = "Admin";
            button14.TextAlign = ContentAlignment.MiddleRight;
            button14.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(209, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 593);
            panel1.TabIndex = 49;
            panel1.Paint += panel1_Paint_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(407, 489);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 57;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(242, 489);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 56;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(251, 394);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 31);
            textBox5.TabIndex = 55;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(251, 321);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(256, 31);
            textBox4.TabIndex = 54;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 254);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(256, 31);
            textBox3.TabIndex = 53;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 187);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(256, 31);
            textBox2.TabIndex = 52;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(79, 405);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 51;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(75, 332);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 50;
            label5.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(75, 265);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 49;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(75, 198);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 48;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(75, 128);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 47;
            label2.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 117);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(256, 31);
            textBox1.TabIndex = 46;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 45;
            label1.Text = "My Profile";
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 128, 128);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(1, 614);
            button13.Name = "button13";
            button13.Size = new Size(203, 54);
            button13.TabIndex = 48;
            button13.Text = "Logout";
            button13.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.Enabled = false;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(10, 397);
            button11.Name = "button11";
            button11.Size = new Size(120, 81);
            button11.TabIndex = 46;
            button11.Text = "Profile";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(10, 292);
            button9.Name = "button9";
            button9.Size = new Size(120, 68);
            button9.TabIndex = 45;
            button9.Text = "      Reports";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // DASHBOARD
            // 
            DASHBOARD.BackColor = Color.Transparent;
            DASHBOARD.Enabled = false;
            DASHBOARD.FlatAppearance.BorderSize = 0;
            DASHBOARD.FlatStyle = FlatStyle.Flat;
            DASHBOARD.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DASHBOARD.ForeColor = Color.White;
            DASHBOARD.ImageAlign = ContentAlignment.MiddleLeft;
            DASHBOARD.Location = new Point(0, 35);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(194, 54);
            DASHBOARD.TabIndex = 43;
            DASHBOARD.Text = "      Dashboard";
            DASHBOARD.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(10, 502);
            button12.Name = "button12";
            button12.Size = new Size(136, 82);
            button12.TabIndex = 47;
            button12.Text = "   Setting";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 177);
            button1.Name = "button1";
            button1.Size = new Size(128, 77);
            button1.TabIndex = 44;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 105);
            button2.Name = "button2";
            button2.Size = new Size(195, 52);
            button2.TabIndex = 51;
            button2.Text = "      Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // Admin_profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 76);
            ClientSize = new Size(880, 668);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(DASHBOARD);
            Controls.Add(button12);
            Controls.Add(button1);
            Name = "Admin_profile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form4";
            Load += Admin_profile_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button DASHBOARD;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}