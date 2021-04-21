using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
namespace typing_project.classes
{
    class Cls_institute_registration
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;

        public bool insert_data(String institute_code, String institute_name, String owner_name, String email, String mobile, String address, String postal_code, String username, String password_)
        {
            conn = new SqlCeConnection("Data Source="+ System.IO.Path.GetTempPath() + "Ezapiya\\Database1.sdf");
            // open the connection:
            conn.Open();
            // create a new SQL command:
            cmd = conn.CreateCommand();

            cmd.CommandText = "insert into institute_registration values  ('" + institute_code + "','" + institute_name + "','" + owner_name + "','" + email + "','" + mobile + "','" + address + "','" + postal_code + "','" + username + "','" + password_ + "')";
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
