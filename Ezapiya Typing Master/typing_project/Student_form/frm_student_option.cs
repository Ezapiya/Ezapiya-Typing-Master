using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.SqlServerCe;
using System.Diagnostics;

namespace typing_project.Student_form
{
    public partial class frm_student_option : Form
    {
        public frm_student_option()
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

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                Globle_data.student_selected_option = "practice";
                frm_language_option lo = new frm_language_option();
                lo.Show();
               
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Globle_data.student_selected_option = "test";
                frm_language_option lo = new frm_language_option();
                lo.Show();
               
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Globle_data.student_selected_option = "practice";
                Globle_data.student_selected_language = "number";
                
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Globle_data.student_selected_option = "test";
                Globle_data.student_selected_language = "number";
                //typing_project.Numarical.frm_numarical lo = new typing_project.Numarical.frm_numarical();
                //lo.Show();
                frm_new_session_from nsf = new frm_new_session_from();
                nsf.Show();
                this.Hide();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Globle_data.student_selected_option = "final_test";
                frm_language_option lo = new frm_language_option();
                lo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Globle_data.student_selected_option = "about_us";
                typing_project.frm_about_us lo = new typing_project.frm_about_us();
                lo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Globle_data.student_selected_option = "Kid's Section";
                typing_project.kids_section.frm_kids_section lo = new typing_project.kids_section.frm_kids_section();
                lo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frm_student_option_Load(object sender, EventArgs e)
        {
            String res_="";
            try
            {
                String temp = "http://www.matrix-stc.com/etm.php";
                WebRequest request = WebRequest.Create(temp);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                //MessageBox.Show(responseFromServer);
                res_=responseFromServer;
                if (res_.CompareTo("Yes") != 0)
                {
                    //Application.Exit();
                }
                else
                {

                    SqlCeConnection conn;
                    SqlCeCommand cmd;
                    SqlCeDataReader res;
                    //conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
                    conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
                    conn.Open();
                    cmd = conn.CreateCommand();

                    int cd = 0, cm = 0, cy = 0, td = 0;
                    cd = DateTime.Now.Day;
                    cm = DateTime.Now.Day;
                    cy = DateTime.Now.Day;

                    cmd.CommandText = "update setting_table set total_day=" + Convert.ToString(td) + ",day=" + Convert.ToString(cd) + ",month=" + Convert.ToString(cm) + ",year=" + Convert.ToString(cy);
                    cmd.ExecuteNonQuery();
                }

            }
            catch(Exception ex){
                SqlCeConnection conn;
                SqlCeCommand cmd;
                SqlCeDataReader res;
                conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandText = " select * from setting_table";
                res = cmd.ExecuteReader();

                int total_Day=0,day_=0,month_=0,year_=0;

                while (res.Read())
                {
                    total_Day = Convert.ToInt16(res["total_day"]);
                    day_ = Convert.ToInt16(res["day"]);
                    month_ = Convert.ToInt16(res["month"]);
                    year_ = Convert.ToInt16(res["year"]);

                }
                res.Close();
                int cd=0, cm=0, cy=0,td=0;
                cd = DateTime.Now.Day;
                cm = DateTime.Now.Day;
                cy = DateTime.Now.Day;

                if (day_ != cd || month_ != cm || year_ != cy)
                { td = total_Day + 1; }

                cmd.CommandText = "update setting_table set total_day=" + Convert.ToString(td) + ",day=" + Convert.ToString(cd) + ",month=" + Convert.ToString(cm) + ",year=" + Convert.ToString(cy) ;
                cmd.ExecuteNonQuery();
                if (td > 30)
                { //Application.Exit();
                }
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
