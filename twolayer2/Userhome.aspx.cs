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
    public partial class Userhome : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strup = "select * from Category_tab ";
                DataSet ds = objcls.fn_exeadapter(strup);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
           
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
            int i = Convert.ToInt32(e.CommandArgument);
            Session["cid"] = i;
            Response.Redirect("productview.aspx");

        }
    }
}