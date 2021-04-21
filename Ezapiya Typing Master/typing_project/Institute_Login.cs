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
    public partial class Institute_Login : Form
    {
        public Institute_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Student_Login stu_login = new frm_Student_Login();
            stu_login.Show();

            //this.Hide();
                       
        }

        private void Institute_Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
