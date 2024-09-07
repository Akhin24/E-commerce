using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace twolayer2
{
    public partial class Adminhome : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
          if (!IsPostBack)
            {
                gridview_fn();
            }
        }
        public void gridview_fn()
        {
            GridView1.Visible = true;
            string selfbtb = "select * from feedback_tab";
            DataSet ds = clsobj.fn_exeadapter(selfbtb);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

           
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Panel1.Visible = true;
            GridViewRow gvr = GridView1.Rows[e.NewSelectedIndex];
            Session["fuid"] = gvr.Cells[2].Text;
            string sel = "select * from feedback_tab where user_reg_id=" + Session["fuid"] + "";
            SqlDataReader dr = clsobj.fn_exereader(sel);
            while (dr.Read())
            {
                Label1.Text = dr["feedback"].ToString();
            }
            string selud= "select * from [dbo].[User_reg_tab] where user_reg_id=" + Session["fuid"] + "";
            SqlDataReader udr = clsobj.fn_exereader(selud);
            while (udr.Read())
            {
                Label2.Text = udr["name"].ToString();
                Label3.Text = udr["address"].ToString();
                Session["gmail"] = udr["email"].ToString();
            }
            string strup = "update feedback_tab set feedback_status='viewed'where user_reg_id=" + Session["fuid"] + "";
            int u = clsobj.fn_exenonquery(strup);
            //responsewritecheck
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("replay.aspx");
        }
    }
}