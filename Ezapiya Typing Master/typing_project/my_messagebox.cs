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
    public partial class my_messagebox : Form
    {
        public my_messagebox(String message)
        {
            InitializeComponent();

            lab_message.Text = message;
        }

        private void my_messagebox_Load(object sender, EventArgs e)
        {
            btn_exit.Focus();
        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void my_messagebox_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
