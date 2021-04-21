using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using typing_project.classes;
using System.Diagnostics;

namespace typing_project.Student_form
{
    public partial class frm_language_option : Form
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        Cls_student_registration my_class_object2 = new Cls_student_registration();
        public frm_language_option()
        {
            InitializeComponent();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_student_option so = new frm_student_option();
            so.Show();
            this.Hide();
        }

        private void frm_language_option_Load(object sender, EventArgs e)
        {
           

        }






        private void select_language(object sender, EventArgs e)
        {
            try
            {
                PictureBox pb= (PictureBox)sender;
                Globle_data.student_selected_option = "practice";
                Globle_data.student_selected_language = pb.Tag.ToString();

                //typing_project.Numarical.frm_numarical lo = new typing_project.Numarical.frm_numarical();
                //lo.Show();

                //Globle_data.student_selected_language = "number";

                frm_new_session_from nsf = new frm_new_session_from();
                nsf.Show();
                this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void lblinfo2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        

    }
}
