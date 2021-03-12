using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Education
{
    public class Logic
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Education\Education\App_Data\DBEd.mdf;Integrated Security=True");
        SqlCommand cmd;



        //---------------Function LoginCheck Start ----------------
        public int LoginCheck(string email, string password,string username, string usertype)
        {
            cmd = new SqlCommand("LoginCheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@UserType", usertype);
            con.Open();
            object value = cmd.ExecuteScalar();
            con.Close();
            int output = Convert.ToInt32(value);
            return output;
        }
        //---------------Function LoginCheck End ----------------



        //---------------Function InsertUserInfo Start ----------------
        public int InsertUserInfo(string username, string email, string password, string usertype)
        {
            cmd = new SqlCommand("InsertUserInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserType", usertype);
            con.Open();
            object value = cmd.ExecuteNonQuery();
            con.Close();
            int output = Convert.ToInt32(value);
            return output;
        }
        //---------------Function InsertUserInfo End ----------------




    }
}