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
    public partial class productview : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from product_tab where cat_id=" + Session["cid"] + "";
                DataSet ds = clsobj.fn_exeadapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
           
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int i = Convert.ToInt32(e.CommandArgument);
            Session["pid"] = i;
            Response.Redirect("productdetail.aspx");
        }
    }
}