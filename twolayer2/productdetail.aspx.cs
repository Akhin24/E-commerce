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
    public partial class productdetail : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = " select * from product_tab where pid=" + Session["pid"] + "";
            SqlDataReader dr = objcls.fn_exereader(s);
            while (dr.Read())
            {
                Image1.ImageUrl = dr["pimage"].ToString();
                Label1.Text = dr["pname"].ToString();
                Label2.Text = dr["pprize"].ToString();
                Label3.Text = dr["pdescription"].ToString();
                Label4.Text = dr["stock"].ToString();
               // Session["ptusid"]=dr[""]
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userhome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(cart_id) from Cart_tab";
            string cartid = objcls.fn_exescalar(sel);

            int cart_id = 0;
            if (cartid == "")
            {
                cart_id = 1;
            }
            else
            {
                int newcartid = Convert.ToInt32(cartid);
                cart_id = newcartid + 1;
            }
            
            string pp = "select  pprize from product_tab where pid=" + Session["pid"] + "";
            string s = objcls.fn_exescalar(pp);
            int st = Convert.ToInt32(s);

            int total = Convert.ToInt32(TextBox1.Text) * st;

            string strcrtin = "insert into Cart_tab values(" + cart_id + "," + Session["urid"] + "," + Session["pid"] + "," + TextBox1.Text + "," + total + ")";
            int i = objcls.fn_exenonquery(strcrtin);

            if (i == 1)
            {
                Label6.Visible = true;
                Response.Redirect("viewcart.aspx");
                //Label6.Text = "ADDED";
            }
        }
    }
}