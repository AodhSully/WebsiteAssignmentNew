using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Helpers;
using System.Web.Configuration;

namespace WebsiteAssignmentNew.Models
{
    public class DAO
    {
        SqlConnection conn;
        public string message = "";

        public void Connection()
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connString1"].ConnectionString);
        }

        //method for inserting data to database
        public int Insert(UserModel user)
        {
            //count shows number of affected rows
            int count = 0;
            SqlCommand cmd;
            string password;

            Connection();
            cmd = new SqlCommand("uspInsertUserTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@first", user.FirstName);
            cmd.Parameters.AddWithValue("@last", user.LastName);
            cmd.Parameters.AddWithValue("@email", user.Email);

            password = Crypto.HashPassword(user.Password);
            cmd.Parameters.AddWithValue("@user", password);

            try
            {
                conn.Open();
                count = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return count;

        }
    }
}