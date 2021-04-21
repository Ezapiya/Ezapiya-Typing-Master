using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Diagnostics;
namespace typing_project.Student_form
{
    public partial class frm_new_session_from : Form
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
       // Cls_student_registration my_class_object2 = new Cls_student_registration();

        public frm_new_session_from()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Globle_data.student_selected_language.CompareTo("number") == 0)
            {
                frm_student_option lo = new frm_student_option();
                lo.Show();
                this.Hide();
            }
            else
            {
                frm_language_option lo = new frm_language_option();
                lo.Show();
                this.Hide();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_new_session_from_Load(object sender, EventArgs e)
        {
            if (Globle_data.student_selected_option.CompareTo("practice") == 0)
            {
                btn_start_practice_session.Visible = true;
                btn_start_test_session.Visible = false;
            }
            if (Globle_data.student_selected_option.CompareTo("test") == 0)
            {
                btn_start_practice_session.Visible = false;
                btn_start_test_session.Visible = true;
               
            }
            if (Globle_data.student_selected_option.CompareTo("final_test") == 0)
            {
                btn_start_practice_session.Visible = false;
                btn_start_test_session.Visible = true;

            }

            if (Globle_data.student_selected_language.CompareTo("English") == 0)
            {
                btn_english.Visible = true;
                btn_marathi.Visible = false;
                btn_hindi.Visible = false;
                btn_punjabi.Visible = false;
            }

            if (Globle_data.student_selected_language.CompareTo("Hindi") == 0)
            {
                btn_english.Visible = false;
                btn_marathi.Visible = false;
                btn_hindi.Visible = true;
                btn_punjabi.Visible = false;

            }
            if (Globle_data.student_selected_language.CompareTo("Marathi") == 0)
            {
                btn_english.Visible = false;
                btn_marathi.Visible = true ;
                btn_hindi.Visible = false;
                btn_punjabi.Visible = false;

            }
            if (Globle_data.student_selected_language.CompareTo("Panjabi") == 0)
            {
                btn_english.Visible = false ;
                btn_marathi.Visible = false;
                btn_hindi.Visible = false;
                btn_punjabi.Visible = true;

            }

           // String path = Application.StartupPath + "\\inst_logo.jpeg";
           // pic_inst_log.Image = Image.FromFile(path);

            speedChanged(sender, e);
        }


        private void speedChanged(object sender, EventArgs e)
        { 
                /// from english //
                /// 

            DataTable dt = new DataTable();
            if (Globle_data.student_selected_language.CompareTo("English") == 0 && opt30.Checked == true)
            {
                String sql = "select * from english where  speed='30 WPM' and type='" + Globle_data.student_selected_option + "' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("English") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from english where  type='"+Globle_data.student_selected_option +"' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
            /// english close 
            /// 

            /// marathi //
            /// 
         //   DataTable dt = new DataTable();
            if (Globle_data.student_selected_language.CompareTo("Marathi") == 0 && opt30.Checked == true)
            {
                String sql = "select * from marathi where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("Marathi") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from marathi where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }

            // marathi close 
        


            // hindi 
            if (Globle_data.student_selected_language.CompareTo("Hindi") == 0 && opt30.Checked == true)
            {
               // Globle_data.language = "Hindi";
                String sql = "select * from hindi where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("Hindi") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from hindi where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
            // hinid close

            //panjabi

            if (Globle_data.student_selected_language.CompareTo("Panjabi") == 0 && opt30.Checked == true)
            {
               // Globle_data.language = "Hindi";
                String sql = "select * from panjabi where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("Panjabi") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from panjabi where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }

            // gujrati
            if (Globle_data.student_selected_language.CompareTo("Gujrati") == 0 && opt30.Checked == true)
            {
                // Globle_data.language = "Hindi";
                String sql = "select * from gujrati where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("Gujrati") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from gujrati where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }


            // urdu
            if (Globle_data.student_selected_language.CompareTo("Urdu") == 0 && opt30.Checked == true)
            {
                // Globle_data.language = "Hindi";
                String sql = "select * from urdu where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("Urdu") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from urdu where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }

            // number
            if (Globle_data.student_selected_language.CompareTo("number") == 0 && opt30.Checked == true)
            {
                // Globle_data.language = "Hindi";
                String sql = "select * from number where  type='" + Globle_data.student_selected_option + "' and speed='30 WPM' order by id";
                dt = get_data_table(sql);
                lbx_chapter.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                }
            }
            else
            {
                if (Globle_data.student_selected_language.CompareTo("number") == 0 && opt40.Checked == true)
                {
                    String sql = "select * from number where  type='" + Globle_data.student_selected_option + "' and speed='40 WPM' order by id";
                    dt = get_data_table(sql);
                    lbx_chapter.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbx_chapter.Items.Add(Convert.ToString(dt.Rows[i]["tital"]));
                    }
                }
            }
            // number close
        }

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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



            if (Globle_data.student_selected_language.CompareTo("English") == 0)
            {
                Globle_data.language = "English";
                frm_english_practice eng_prac = new frm_english_practice();
                eng_prac.Show();
                this.Hide();
            }
            if (Globle_data.student_selected_language.CompareTo("Hindi") == 0)
            {
                Globle_data.language = "Hindi";
                frm_hindi_practice hindi_prac = new frm_hindi_practice();
                hindi_prac.Show();
                this.Hide();
            }
            if (Globle_data.student_selected_language.CompareTo("Marathi") == 0)
            {
                Globle_data.language = "Marathi";
                frm_marathi_practice mar_prac = new frm_marathi_practice();
                mar_prac.Show();
                this.Hide();
            }
            if (Globle_data.student_selected_language.CompareTo("number") == 0)
            {
                Globle_data.language = "number";
                typing_project.Numarical.frm_numarical mar_prac = new typing_project.Numarical.frm_numarical();
                mar_prac.Show();
                this.Hide();
            }


           
           

           

        abc: ;
        }

        private void lblinfo2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }
        ///
    }
}
