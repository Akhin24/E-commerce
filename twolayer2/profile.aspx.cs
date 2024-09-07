using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace twolayer2
{
    public partial class profile : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sid = "select name,age,address,photo from TWOLAYER2 where id=" + Session["uid"] + "";

         SqlDataReader dr = clsobj.fn_exereader(sid);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }

            string sq = "select * from TWOLAYER2";
            DataSet ds = clsobj.fn_exeadapter(sq);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            string sq1 = "select * from TWOLAYER2";
            DataSet ds2 = clsobj.fn_exeadapter(sq1);
            DataList1.DataSource = ds2;
            DataList1.DataBind();
        }
    }
}