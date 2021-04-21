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

namespace typing_project
{
    public partial class frm_Session_Form : Form
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        Cls_student_registration my_class_object2 = new Cls_student_registration();
        public frm_Session_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //frm_english_practice eng_prac = new frm_english_practice();
            //eng_prac.Show();
            //frm_marathi_practice mar_prac = new frm_marathi_practice();
            //mar_prac.Show();
            if (lbx_chapter.SelectedIndex == -1)
            {
                my_messagebox m = new my_messagebox("Select Chapter");
                m.ShowDialog();
                
                //MessageBox.Show("Select Chapter");
                lbx_chapter.Focus();
                goto abc;
            
            }
            Globle_data.chapter = lbx_chapter.Text;
            if (optenglish.Checked == true)
            {
                frm_english_practice eng_prac = new frm_english_practice();
                eng_prac.Show();
            }
            if (opthindi.Checked == true)
            {
                frm_hindi_practice hindi_prac = new frm_hindi_practice();
                hindi_prac.Show();
            }
            if (optmarathi.Checked == true)
            {
                frm_marathi_practice mar_prac = new frm_marathi_practice();
                mar_prac.Show();
            }

        abc: ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_Session_Form_Load(object sender, EventArgs e)
        {
            
           // lbldate.Text = DateTime.Now.ToLongDateString();
            //lbllogin_time.Text = Globle_data.logintime;
         //   lbllog_out_time.Text = Globle_data.logouttime;
           // lblusername.Text = Globle_data.student_name;
            
            DataTable dt = new DataTable();
            String sql = "select * from student_registration where  username='" + Globle_data.student_user_name + "'";
            dt = my_class_object2.get_data_table(sql);
            String ee="", m="", h="";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ee = Convert.ToString(dt.Rows[i]["english"]);
                h = Convert.ToString(dt.Rows[i]["hindi"]);
               m = Convert.ToString(dt.Rows[i]["marathi"]);
            }

            if (ee.CompareTo("yes") != 0)
            {
                optenglish.Enabled = false;
                optenglish.Checked = false;
            }
            else {
                optenglish.Enabled = true;
            }

            if (h.CompareTo("yes") != 0)
            {
                opthindi.Enabled = false;
                opthindi.Checked = false;
            }
            else
            {
                opthindi.Enabled = true;
            }


            if (m.CompareTo("yes") != 0)
            {
                optmarathi.Enabled = false;
                optmarathi.Checked = false;
            }
            else
            {
                optmarathi.Enabled = true;
            }
            //
            //String path = @"Data Source=|DataDirectory|\inst_logo.jpeg"; 
            //img_inst_logo.Image = Image.FromFile(path);

            sql = "select * from Student_login where user_name='"+Globle_data.student_user_name +"'";
            dt = get_data_table(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows.Add(1);
                dgv.Rows[i].Cells["sr_no"].Value = Convert.ToString(i + 1);
                dgv.Rows[i].Cells["student_full_name"].Value = Convert.ToString(dt.Rows[i]["student_full_name"]);
                dgv.Rows[i].Cells["chapter"].Value = Convert.ToString(dt.Rows[i]["chapter"]);
                dgv.Rows[i].Cells["language"].Value = Convert.ToString(dt.Rows[i]["language"]);
                dgv.Rows[i].Cells["speed"].Value = Convert.ToString(dt.Rows[i]["speed"]);
                dgv.Rows[i].Cells["error"].Value = Convert.ToString(dt.Rows[i]["error"]);
                dgv.Rows[i].Cells["er_rate"].Value = Convert.ToString(dt.Rows[i]["er_rate"]);
                dgv.Rows[i].Cells["date"].Value = Convert.ToString(dt.Rows[i]["date"]);
                dgv.Rows[i].Cells["duration"].Value = Convert.ToString(dt.Rows[i]["duration"]);
                dgv.Rows[i].Cells["ans_character"].Value = Convert.ToString(dt.Rows[i]["ans_character"]);
                dgv.Rows[i].Cells["wpm"].Value = Convert.ToString(dt.Rows[i]["wpm"]);

                //int d = 0, mm = 0, y = 0;
                //d = Convert.ToInt16(dt.Rows[i][2]);
                //mm = Convert.ToInt16(dt.Rows[i][3]);
                //y = Convert.ToInt16(dt.Rows[i][4]);
                //DateTime dx = new DateTime(y, mm, d);

                //dgv.Rows[i].Cells["Day"].Value = dx.ToShortDateString();
                ////dgv.Rows[i].Cells["Month"].Value = Convert.ToString(dt.Rows[i][3]);
                ////dgv.Rows[i].Cells["Year"].Value = Convert.ToString(dt.Rows[i][4]);
                //dgv.Rows[i].Cells["Login_Time"].Value = Globle_data.logintime;
                //dgv.Rows[i].Cells["Logout_Time"].Value = Globle_data.logouttime;

                ////dgv.Rows[i].Cells["Login_Hour"].Value = Convert.ToString(dt.Rows[i][5]);
                ////dgv.Rows[i].Cells["Login_Minute"].Value = Convert.ToString(dt.Rows[i][6]);
                ////dgv.Rows[i].Cells["Logout_Hour"].Value = Convert.ToString(dt.Rows[i][7]);
                ////dgv.Rows[i].Cells["Logout_Minute"].Value = Convert.ToString(dt.Rows[i][8]);
                //dgv.Rows[i].Cells["Language"].Value = Convert.ToString(dt.Rows[i][9]);

                //dgv.Rows[i].Cells["Speed"].Value = Convert.ToString(dt.Rows[i][10]);
                //dgv.Rows[i].Cells["Error"].Value = Convert.ToString(dt.Rows[i][11]);
            
            }
            String path = Application.StartupPath + "\\inst_logo.jpeg";
            pic_inst_log.Image = Image.FromFile(path);


        }

        private void optenglish_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (optenglish.Checked == true && opt30.Checked == true)
            {
                String sql = "select * from chapter_table where  language='English' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (optenglish.Checked == true && opt40.Checked == true)
                {
                    String sql = "select * from chapter_table where  language='English' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
           
        }


        ////
        public DataTable get_data_table(String sql)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            // open the connection:
            conn.Open();
            // create a new SQL command:
            cmd = conn.CreateCommand();

            DataTable dt = new DataTable();
            if (sql != "")
            {
                try
                {
                    cmd.CommandText = sql;
                    res = cmd.ExecuteReader();
                    dt.Load(res);
                    res.Close();
                }
                catch (SystemException ex)
                {
                    res.Close();
                }
            }
            conn.Close();
            return dt;
        }

        private void optmarathi_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (optmarathi.Checked == true && opt30.Checked == true)
            {
                String sql = "select * from chapter_table where  language='Marathi' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (optmarathi.Checked == true && opt40.Checked == true)
                {
                    String sql = "select * from chapter_table where  language='Marathi' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
            
        }

        private void opthindi_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (opthindi.Checked == true && opt30.Checked == true)
            {
                Globle_data.language = "Hindi";
                String sql = "select * from chapter_table where  language='Hindi' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (opthindi.Checked == true && opt40.Checked == true)
                {
                    String sql = "select * from chapter_table where  language='Hindi' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
     
        }

        private void opt40_CheckedChanged(object sender, EventArgs e)
        {
            optenglish_CheckedChanged(sender, e);
            opthindi_CheckedChanged(sender, e);
            optmarathi_CheckedChanged(sender, e);

        }

        private void btn_start_practice_session_Click(object sender, EventArgs e)
        {
            if (lbx_chapter.SelectedIndex == -1)
            {
                my_messagebox m = new my_messagebox("Select Chapter");
                m.ShowDialog();
                //MessageBox.Show("Select Chapter");
                lbx_chapter.Focus();
                goto abc;

            }
            Globle_data.chapter = lbx_chapter.Text;

            if (opt30.Checked == true)
                Globle_data.speed = "30";
            if (opt40.Checked == true)
                Globle_data.speed = "40";



            if (optenglish.Checked == true)
            {
                Globle_data.language = "English";
                frm_english_practice eng_prac = new frm_english_practice();
                eng_prac.Show();
                this.Hide();
            }
            if (opthindi.Checked == true)
            {
                Globle_data.language = "Hindi";
                frm_hindi_practice hindi_prac = new frm_hindi_practice();
                hindi_prac.Show();
                this.Hide();
            }
            if (optmarathi.Checked == true)
            {
                Globle_data.language = "Marathi";
                frm_marathi_practice mar_prac = new frm_marathi_practice();
                mar_prac.Show();
                this.Hide();
            }

        abc: ;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           

        }

        private void frm_Session_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void tabPage2_Click(object sender, EventArgs e)
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblinfo2.Location = new Point(lblinfo2.Location.X - 5, lblinfo2.Location.Y);
            if (lblinfo2.Location.X + lblinfo2.Width < 0)
            {
                lblinfo2.Location = new Point(this.Width, lblinfo2.Location.Y);
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
