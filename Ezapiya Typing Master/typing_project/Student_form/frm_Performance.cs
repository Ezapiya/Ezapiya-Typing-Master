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

namespace typing_project
{
    public partial class frm_Performance : Form
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;

        public frm_Performance()
        {
            InitializeComponent();
        }

        private void frm_Performance_Load(object sender, EventArgs e)
        {

            String  sql = "select * from Student_login where user_name='" + Globle_data.student_user_name + "'";
            DataTable dt = new DataTable();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
