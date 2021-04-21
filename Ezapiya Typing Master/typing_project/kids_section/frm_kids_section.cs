using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace typing_project.kids_section
{
    public partial class frm_kids_section : Form
    {
        String typeing_data = "abcdefghijklmnopqrustuvwxyzABCDEFGHIJKLMNOPQRUSTUVWXYZ1234567890";
        Random ren = new Random();
        public frm_kids_section()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {

                typing_project.Student_form.frm_student_option lo = new typing_project.Student_form.frm_student_option();
                lo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frm_kids_section_Load(object sender, EventArgs e)
        {
            int char_no = ren.Next(0, typeing_data.Length);
            lab_show_char.Text = Convert.ToString( typeing_data[char_no] );
          //  txttype_text.Focus();
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;
                    String btntext = btn.Tag.ToString();
                    if (btntext.Contains(lab_show_char.Text) == true)
                    {
                        if (lab_show_char.Text[0].CompareTo(' ') != 0)
                        {
                            if (char.IsUpper(lab_show_char.Text[0]))   ////// code to impliment in hinid 
                            {
                                button55.BackColor = Color.LightBlue;
                                button43.BackColor = Color.LightBlue;
                            }  //// code to impliment in hinid 

                            btn.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            button59.BackColor = Color.LightBlue;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                        }
                    }
                }
            }
        }

        private void txttype_text_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           
        }

        private void txttype_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void do_work()
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;

                    btn.BackColor = Color.White;

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

            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;
                    String btntext = btn.Tag.ToString();
                    if (btntext.Contains(lab_show_char.Text ) == true )
                    {
                        if (lab_show_char.Text [0].CompareTo(' ') != 0)
                        {
                            if (char.IsUpper(lab_show_char.Text[0]))   ////// code to impliment in hinid 
                            {
                                button55.BackColor = Color.LightBlue;
                                button43.BackColor = Color.LightBlue;
                            }  //// code to impliment in hinid 
                            
                            btn.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            button59.BackColor = Color.LightBlue;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                        }
                    }
                }
            }



            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();

                    if (t.Contains(Convert.ToString(lab_show_char.Text[0])) == true && t.CompareTo("space") != 0 && t.CompareTo("main") != 0)
                    {
                        pic.Visible = true;
                    }
                }
            }
            ////
        }

        private void frm_kids_section_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (lab_show_char.Text.CompareTo(Convert.ToString(e.KeyChar)) == 0)
            {
                piccurrect.Visible = true;
                picwrong.Visible = false;
                e.Handled = false;
            }
            else
            {
                piccurrect.Visible = false ;
                picwrong.Visible = true ;
                e.Handled = false;
            }

           
          
            // Thread.Sleep(1000);
            int char_no = ren.Next(0, typeing_data.Length);
            lab_show_char.Text = Convert.ToString(typeing_data[char_no]);
           

            do_work();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ezapiya.com/");
        }
    }
}
