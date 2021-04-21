using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace typing_project
{
    public partial class frm_marathi_proctic : Form
    {
        int c = 0;
        public frm_marathi_proctic()
        {
            InitializeComponent();
        }

        private void frm_marathi_proctic_Load(object sender, EventArgs e)
        {

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


            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is System.Windows.Forms.Button)
                {
                    Button btn = (Button)ctr;

                    if (btn.Text.Contains(Convert.ToString(rt1.Text[c + 1])) == true && btn.Text.Length == 9)
                    {
                        if (rt1.Text[c + 1].CompareTo(' ') != 0)
                        {
                            btn.BackColor = Color.Red;
                        }
                        else
                        {
                            button59.BackColor = Color.Red;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                        }
                    }
                }
            }
            ///

            ////

            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is System.Windows.Forms.PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    String t = pic.Tag.ToString();

                    if (t.Contains(Convert.ToString(rt1.Text[c + 1])) == true && t.CompareTo("space") != 0 && t.CompareTo("main") != 0)
                    {
                        pic.Visible = true;
                    }
                }
            }
            ///

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

            }
            else
            {
                rt2.SelectionStart = c;
                rt2.SelectionLength = 1;
                rt2.SelectionColor = Color.Red;
                rt1.SelectionBackColor = Color.Yellow;
            }


            c++;
        }

        private void rt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            do_work(sender, e);
        }
    }
}
