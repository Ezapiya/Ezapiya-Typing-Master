using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace typing_project
{
    public partial class frm_about_us : Form
    {
        public frm_about_us()
        {
            InitializeComponent();
        }

        private void frm_about_us_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Globle_data.student_selected_option.CompareTo("about_us") == 0)
            {
                typing_project.Student_form.frm_student_option lo = new typing_project.Student_form.frm_student_option();
                lo.Show();
                this.Hide();
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }
    }
}
