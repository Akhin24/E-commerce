using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twolayer2
{
    public partial class lgin : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from Login_tab";
            string adregid = objcls.fn_exescalar(sel);

            int reg_id = 0;
            if (adregid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(adregid);
                reg_id = newregid + 1;
            }

            string strinsad = "insert into Admin_reg_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','active')";
            int i = objcls.fn_exenonquery(strinsad);
            if (i == 1)
            {
                string strinslg = "insert into Login_tab values(" + reg_id+",'"+TextBox5.Text+ "','" + TextBox6.Text + "','ADMIN')";
                int s = objcls.fn_exenonquery(strinslg);
                if (s == 1)
                {
                    Label1.Text = "REGISTERED SUCCESFULLY";
                }
            }
        }
    }
}