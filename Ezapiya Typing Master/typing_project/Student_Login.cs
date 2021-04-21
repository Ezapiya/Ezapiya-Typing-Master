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
    public partial class frm_Student_Login : Form
    {
        public frm_Student_Login()
        {
            InitializeComponent();
        }

        private void frm_Student_Login_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Session_Form session = new frm_Session_Form();
            session.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
