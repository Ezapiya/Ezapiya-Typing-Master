using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace typing_project.classes
{
    class Cls_student_registration
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        public bool insert_data2(String student_code, String student_name, String student_mobile, String email, string gender, String address, String postal_code, String username, String password_, String english, String hindi, String marathi, String panjabi, String gujrati, String urdu)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            
            // open the connection:
            conn.Open();
            
            // create a new SQL command:
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into student_registration values  ('" + student_code + "','" + student_name + "','" + student_mobile + "','" + email + "','" + gender + "','" + address + "','" + postal_code + "','" + username + "','" + password_ + "','" + english + "','" + hindi + "','" + marathi + "','" + panjabi + "','" + gujrati + "','" + urdu + "')";
            cmd.ExecuteNonQuery();
            return true;
        }
        public bool update(String student_code, String student_name, String student_mobile, String email, string gender, String address, String postal_code, String username, String password_, String english, String hindi, String marathi, String panjabi, String gujrati, String urdu)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            
            // open the connection:
            conn.Open();
            
            // create a new SQL command:
            cmd = conn.CreateCommand();

            cmd.CommandText = "update  student_registration  set  student_name='" + student_name + "', student_mobile='" + student_mobile + "',email='" + email + "',gender='" + gender + "',address='" + address + "',postal_code='" + postal_code + "',username='" + username + "',password_='" + password_ + "', english='" + english + "',hindi='" + hindi + "',marathi='" + marathi + "', panjabi='" + panjabi + "',gujrati='" + gujrati + "',urdu='" + urdu + "'  where student_code= '" + student_code + "'";
            cmd.ExecuteNonQuery();
            
            return true;
       
        }
        public bool delete (String student_code)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            // open the connection:
            conn.Open();
            // create a new SQL command:
            cmd = conn.CreateCommand();

           // cmd.CommandText = "insert into student_registration values  ('" + student_code + "','" + student_name + "','" + student_mobile + "','" + email + "','" + gender + "','" + address + "','" + postal_code + "','" + username + "','" + password_ + "')";
            cmd.CommandText = "delete from  student_registration where student_code= '" + student_code + "'";
            cmd.ExecuteNonQuery();
            return true;
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
            return dt;
        }

    }
}
