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
    public partial class PRODUCT : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string selregid = "select cname, cat_id from Category_tab";
                DataSet ds = objcls.fn_exeadapter(selregid);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "cname";
                DropDownList1.DataValueField = "cat_id";
                DropDownList1.DataBind();
            

            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/ppp/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string strup = "insert into product_tab values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "',"+TextBox2.Text+",'" + p + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'AVAILABLE')";
            int i = objcls.fn_exenonquery(strup);
            if (i == 1)
            {
                Label1.Visible = true;
                Label1.Text = "INSERTED";
            }



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string s = "select * from Category1_tab where ctg_id =" + DropDownList1.SelectedItem.Value + "";
           // DataSet ds = objcls.fn_exeadapter(s);
        }
    }
}