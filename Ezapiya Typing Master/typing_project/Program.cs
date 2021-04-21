using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
namespace typing_project
{
    static class Program
    {
      


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(System.IO.Path.GetTempPath() + "Ezapiya"))
                Directory.CreateDirectory(System.IO.Path.GetTempPath() + "Ezapiya");
            if (!File.Exists(System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf"))
                File.Copy("Database1.sdf", System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");

                Globle_data.student_user_name = "DEMO";
                //typing_project.Student_form.frm_student_option sf = new typing_project.Student_form.frm_student_option();
                Application.Run(new typing_project.Student_form.frm_student_option());
           

          



        }
    }
}
