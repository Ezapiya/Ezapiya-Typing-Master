using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using typing_project.classes;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Data.SqlServerCe;

namespace typing_project
{
    public partial class frm_result_session : Form
    {

        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        public frm_result_session()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            conn.Open();
            cmd = conn.CreateCommand();
            String sql = "insert into Student_login values('" + Globle_data.student_full_name + "','" + Globle_data.chapter + "','" + Globle_data.language + "','" + Globle_data.speed + "','" + Globle_data.error + "','" + Globle_data.error_rate + "','" + Globle_data.date + "','" + Globle_data.duration + "','" + Globle_data.ans_character + "','" + Globle_data.student_user_name + "','"+ txtWPM.Text + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
           // typing_project.Student_form.frm_student_option frm_sess = new typing_project.Student_form.frm_student_option();
            typing_project.Student_form.frm_new_session_from frm_sess = new typing_project.Student_form.frm_new_session_from();
            frm_sess.Show();
            this.Hide();
        }

        private void frm_result_session_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'database1DataSet.student_result' table. You can move, or remove it, as needed.
           // this.student_resultTableAdapter.Fill(this.database1DataSet.student_result);
           // txtusername.Text = Globle_data.student_user_name;
            txtlanguage2.Text = Globle_data.language;
            txtspeed2.Text = Globle_data.speed;
            txterror2.Text = Globle_data.error;
          

            txtlesson.Text = Globle_data.chapter;

            txtdate.Text = Globle_data.date.ToShortDateString(); // Convert.ToString(Globle_data.date);
            txtcharacter.Text=Convert.ToString(Globle_data.ans_character);

            if (Globle_data.ans_character < Globle_data.main_character)
            {
                int ee = Globle_data.main_character - Globle_data.ans_character;
              txterror2.Text=  Convert.ToString(Convert.ToInt16(Globle_data.error) + ee);
            }

            int eee = Convert.ToInt16(txterror2.Text);
            //double er_rate = (eee / Globle_data.main_character) * 100;
           // txterrorrate.Text = Convert.ToString(er_rate);
            Double a=0, b=0;
            a = Convert.ToDouble( eee) / Convert.ToDouble( Globle_data.main_character);
            b = a * 100;





            txtduration.Text = Globle_data.duration;
            
          //  txterrorrate.Text = Convert.ToString(b);
            txterrorrate.Text = b.ToString("##.##");
            string er_rate = txterrorrate.Text;
            Globle_data.error_rate = er_rate;
           // if (Convert.ToInt16(Globle_data.ans_character) > Convert.ToInt16(Globle_data.main_character))
            //{

            //    int all_type_of_entery = Convert.ToInt16(Globle_data.ans_character);
               double time_min = Convert.ToDouble(Globle_data.duration_in_second) / 60;
            //    Double gross_wpm = (all_type_of_entery / 5) / time_min;

            //    Double net_wpn = gross_wpm - (Convert.ToDouble(Globle_data.error) / time_min);
            //    txtWPM.Text = Convert.ToString(net_wpn);
            //MessageBox.Show (txtWPM.Text);


            //net_wpn = (((all_type_of_entery / 5)) - Convert.ToDouble(Globle_data.error)) / time_min;
            //  txtWPM.Text = Convert.ToString(net_wpn);
            ////}
            ////else
            ////{
            //  //  txtWPM.Text = "0";
            ////}
               Double gross_wpm = (Globle_data.currect_char  / 5) / time_min;




               txtWPM.Text = gross_wpm.ToString("#");

           // String path = Application.StartupPath + "\\inst_logo.jpeg";
           // pic_inst_log.Image = Image.FromFile(path);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblinfo_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            Cursor.Current = Cursors.Hand;
        }

        private void lblinfo_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor.Current = Cursors.Arrow;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y); 
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }
    }
}
