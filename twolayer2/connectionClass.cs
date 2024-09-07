using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace twolayer2
{
    public class connectionClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public connectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-IEB5SN8\SQLEXPRESS;database=E-commerceProject;Integrated security=true");
        }
        public int fn_exenonquery(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq,con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_exescalar(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq,con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader fn_exereader(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sq, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public DataSet fn_exeadapter(string sq)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sq, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable fn_datatable(string sq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sq, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public void openconnection()
        //{
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //}




    }

}