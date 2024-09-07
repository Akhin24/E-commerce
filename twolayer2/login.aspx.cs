using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace twolayer2
{
    public partial class login : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcid = "select count(Reg_id) from Login_tab where username='" + TextBox1.Text + "'and paassword='" + TextBox2.Text + "'";
            string cid = objcls.fn_exescalar(strcid);
            int i = Convert.ToInt32(cid);
            if (i == 1)
            {
                string selid = "select Reg_id from Login_tab where username='" + TextBox1.Text + "'and paassword='" + TextBox2.Text + "' ";
               string s= objcls.fn_exescalar(selid);
                //Session["uid"] = s;
                Session["urid"] = s;


                string sellogtype = "select log_type from Login_tab where  Reg_id=" + s+" ";
                string logtype = objcls.fn_exescalar(sellogtype);
                if (logtype=="ADMIN")
                {
                    Response.Redirect("Adminhome.aspx");
                }
                else if (logtype == "USER")
                {
                    //string selid1 = "select reg_id from login_tab where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "' ";
                   // string s1 = objcls.fn_exescalar(selid);
                   // Session["regid"] = s1;
                    Response.Redirect("Userhome.aspx");
                }
                //Label1.Text = "SUCCESS";
            }
            else
            {
                Label1.Text = "INVALID USERNAME AND PASSWORD";
            }
           
        }

        
    }
}