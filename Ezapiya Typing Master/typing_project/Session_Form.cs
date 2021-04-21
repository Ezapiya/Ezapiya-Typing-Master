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
    public partial class frm_Session_Form : Form
    {
        public frm_Session_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_english_practice eng_prac = new frm_english_practice();
            //eng_prac.Show();
            frm_marathi_practice mar_prac = new frm_marathi_practice();
            mar_prac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_english_exam eng_exam = new frm_english_exam();
            eng_exam.Show();

        }
    }
}
