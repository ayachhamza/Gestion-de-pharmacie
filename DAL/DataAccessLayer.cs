using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PROJECT_FIN_ETUDE.DAL;


namespace PROJECT_FIN_ETUDE.DAL
{
    class DataAccessLayer
    { public static SqlConnection cnx;
        private static string conn = @"Data Source=HAMZA-123\SQLEXPRESS;Initial Catalog=pharmacie_db;Integrated Security=True;";

        //methode connecter
        public static void Open()
        {
            cnx = new SqlConnection(conn);
            if (cnx.State==ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }
        }
        //methode deconnecter
        public static void close()
        {
            cnx = new SqlConnection(conn);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        //return one value
        public static object ExecuteScalar(string query, CommandType type,params SqlParameter[] arr)
        {
            SqlConnection cnx = new SqlConnection(conn);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;
        }
        //return with the number of rows which deleted,inserted,updated
        public static int ExecuteNonQuery(string query, CommandType type,params SqlParameter[] arr)
        {
            SqlConnection cnx = new SqlConnection(conn);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            int n = cmd.ExecuteNonQuery();
            return n;
        }
        //return a table 
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
        {
            SqlConnection cnx = new SqlConnection(conn);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           da.Fill(dt);
            return dt;
        }
        //create parametre
        public static SqlParameter createParameter(string name,SqlDbType type,object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }

    }
}
