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
using System.Runtime.InteropServices;

using System.Data.SqlServerCe;

namespace typing_project.Numarical
{
    public partial class frm_numarical : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);
        string student_full_name = "";
        string chapter = "";
        string language = "";
        string speed = "";
        string error = "";
        string er_rate = "";
        string date = "";
        string duration = "";
        string ans_character = "";
        int currect_char = 0;



        int err = 0;
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        String main_data;
        int c = 0;
        long ts = 0;

        DateTime StartTime;// = DateTime.Now.ToLocalTime();
        DateTime EndTime;// = DateTime.Now.ToLocalTime(); 

        public frm_numarical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            timer1.Enabled = false;
            my_messagebox msg = new my_messagebox("Session Completed! Click ok to see result");
            msg.ShowDialog();
            timer1.Enabled = false;

            this.Hide();
            typing_project.Student_form.frm_student_option so = new Student_form.frm_student_option();
            so.Show();
           // code_on_close();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = ts - 1;
            lblmin.Text = Convert.ToString(ts / 60);
            lblsec.Text = Convert.ToString(ts % 60);
            if (ts == 0)
            {
                timer1.Enabled = false;
                rt2.Enabled = false;
                my_messagebox m = new my_messagebox("Time Up!");
                m.ShowDialog();

                //MessageBox.Show("Time Up!");

                this.Hide();
            }
        }
        private void rt1_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{tab}");
        }

        private void frm_numarical_Load(object sender, EventArgs e)
        {
           

            if (Globle_data.student_selected_option.CompareTo("practice") == 0)
            {
                panel4.Hide();
            }
            if (Globle_data.student_selected_option.CompareTo("test") == 0)
            {
                panel4.Show();
            }

            StartTime = DateTime.Now.ToLocalTime();
            //have to set focus first on the rich text box for scrolling to work
            this.rt1.Focus();

            //move the caret to the correct place <IMPO>This is a character position not
            //line position</IMPO>
           // this.rt1.SelectionStart = 50;

           // this.rt1.ScrollToCaret();
            ////////////////////////////////////
            this.rt1.Enabled = true;
            this.rt1.ReadOnly = true;
            this.rt1.GotFocus += new System.EventHandler(this.rt1_Enter);

            student_full_name = Globle_data.student_user_name;

     

            String language = "number";
            String speed = Globle_data.speed;

            DataTable dt = new DataTable();
            String sql = "select * from number where   tital='" + Globle_data.chapter + "'";
            dt = get_data_table(sql);
            rt1.Text = Convert.ToString(dt.Rows[0]["passage"]);
            ts = Convert.ToInt16(dt.Rows[0]["time"]) * 60;
            
            ts = 60 * 20;

            main_data = rt1.Text;
            
          //  rt2.Text = "sdfdsf";
         
             foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;
                    String btntext = btn.Tag.ToString();
                    if (btntext.Contains(Convert.ToString(rt1.Text[c])) == true)
                    {
                        btn.BackColor = Color.LightBlue;
                    }

                    if (btntext.Contains(Convert.ToString(rt1.Text[c])) == true)
                    {
                       
                        rt1.SelectionStart = 0;
                        rt1.SelectionLength = 1;
                        rt1.SelectionColor = Color.Red;
                        rt1.SelectionBackColor = Color.Yellow;
                    }
                }
            }
            
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();
                    if (t.CompareTo("main") != 0)
                    {
                        pic.Visible = false;
                    }
                }
            }
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();

                    if (t.Contains(Convert.ToString(rt1.Text[c + 1])) == true  && t.CompareTo("main") != 0)
                    {
                        pic.Visible = true;
                    }
                }
            }
            
           // String path = Application.StartupPath + "\\inst_logo.jpeg";
           // pic_inst_log.Image = Image.FromFile(path);

            rt2.Focus();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            lblinfo.Location = new Point(lblinfo.Location.X - 5, lblinfo.Location.Y);
            if (lblinfo.Location.X + lblinfo.Width < 0)
            {
                lblinfo.Location = new Point(this.Width, lblinfo.Location.Y);
            }
        }

        private void rt1_SelectionChanged(object sender, EventArgs e)
        {
            rt1.ScrollToCaret();
        }

        private void rt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                try
                {
                    do_work(sender, e);
                }
                catch (Exception ex)
                {
                    timer1.Enabled = false;
                    rt2.Enabled = false;
                    EndTime = DateTime.Now.ToLocalTime();
                    my_messagebox msg = new my_messagebox("Session Completed! Click Logout to see result");
                    msg.ShowDialog();
                    timer1.Enabled = false;

                    // this.Hide();
                    //code_on_close();
                    // this.Dispose();
                    //MessageBox.Show("Completed!");
                }
            }
        }
        private void do_work(object sender, KeyPressEventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;

                    btn.BackColor = Color.White;

                }
            }

            ////

            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();
                    if (t.CompareTo("main") != 0)
                    {
                        pic.Visible = false;
                    }
                }
            }
            ///


            ///

            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;
                    String btntext = btn.Tag.ToString();
                    if (btntext.Contains(Convert.ToString(rt1.Text[c + 1])) == true )
                    {
                        if (rt1.Text[c + 1].CompareTo(' ') != 0)
                        {
                            btn.BackColor = Color.LightBlue;
                        } 
                    }
                    if (Convert.ToString(rt1.Text[c + 1]).CompareTo("\n") == 0)
                    {
                        button11.BackColor = Color.LightBlue;
                    }
                }
            }

            ////

            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();

                    if (t.Contains(Convert.ToString(rt1.Text[c + 1])) == true && t.CompareTo("main") != 0)
                    {
                        pic.Visible = true;
                    }
                    if (Convert.ToString(rt1.Text[c + 1]).CompareTo("\n") == 0)
                    {
                        pictureBox12.Visible = true;
                    }
                }
            }


            if (c > 1)
            {
                rt1.SelectionStart = 0;
                rt1.SelectionLength = c + 1;
                rt1.SelectionColor = Color.Blue;
                rt1.SelectionBackColor = Color.LightGreen;
            }


            rt1.SelectionStart = c + 1;
            rt1.SelectionLength = 1;
            rt1.SelectionColor = Color.Red;
            rt1.SelectionBackColor = Color.Yellow;



            if (rt1.Text[c] == e.KeyChar)
            {
                rt2.SelectionStart = c;
                rt2.SelectionLength = 1;
                rt2.SelectionColor = Color.Green;
                currect_char++;
            }
            else
            {
                rt2.SelectionStart = c;
                rt2.SelectionLength = 1;
                rt2.SelectionColor = Color.Red;
                rt1.SelectionBackColor = Color.Yellow;

                err++;

                ///
                foreach (Control ctr in groupBox1.Controls)
                {
                    if (ctr is System.Windows.Forms.Button)
                    {
                        Button btn = (Button)ctr;
                        String btntext = btn.Tag.ToString();
                        if (btntext.Contains(Convert.ToString(rt1.Text[c+1])) == true )
                        {
                            if (rt1.Text[c].CompareTo(' ') != 0)
                            {
                               // btn.BackColor = Color.LightGreen;
                                btn.BackColor = Color.LightBlue;
                            }
                        }
                    }
                }
                foreach (Control ctr in groupBox1.Controls)
                {
                    if (ctr is System.Windows.Forms.Button)
                    {
                        Button btn = (Button)ctr;
                        String btntext = btn.Tag.ToString();
                        if (btntext.Contains(Convert.ToString(rt1.Text[c])) == true)
                        {
                            if (rt1.Text[c].CompareTo(' ') != 0)
                            {
                                 btn.BackColor = Color.LightGreen;
                               // btn.BackColor = Color.LightBlue;
                            }
                        }
                    }
                }

                Char kp = Convert.ToChar(e.KeyChar);

                foreach (Control ctr in groupBox1.Controls)
                {
                    if (ctr is System.Windows.Forms.Button)
                    {
                        Button btn = (Button)ctr;
                        String btntext = btn.Tag.ToString();
                        if (btntext.Contains(Convert.ToString(kp)) == true )
                        {
                            if (Convert.ToString(rt1.Text[c]).CompareTo(" ") != 0 && e.KeyChar != 32)
                            {
                                btn.BackColor = Color.Red;
                            }
                           
                        }
                    }
                }
                //

            }


            c++;
        }

        private void rt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != System.Windows.Forms.Keys.Back)
            {

                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    const int KEYEVENTF_EXTENDEDKEY = 0x1;
                    const int KEYEVENTF_KEYUP = 0x2;
                    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
                }
            }
            else
            {
                e.Handled = true;
            }
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

        private void lblinfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }
        ///
    }
}
