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
    public partial class category : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }
            
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/ppp/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));
            string strinsert = "insert into Category_tab values('" + TextBox1.Text + "','" + s + "','" + TextBox2.Text + "','Available')";
            int i = objcls.fn_exenonquery(strinsert);
            if (i == 1)
            {
                Label1.Visible = true;
                Label1.Text = "inserted";
            }
        }

      

        
    }
}