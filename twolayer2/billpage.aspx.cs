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
    public partial class billpage : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string bill = "select  Order_tab.Order_id,product_tab.pname,product_tab.pimage,product_tab.pprize,Order_tab.quandity, Order_tab.subtotal from product_tab inner join Order_tab on product_tab.pid=Order_tab.product_id and Order_tab.user_id=" + Session["uregid"] + " ";
            DataSet ds = clsobj.fn_exeadapter(bill);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            string sel = "select name,address,pincode,phone from User_reg_tab where user_reg_id=" + Session["urid"] + "";
            SqlDataReader dr = clsobj.fn_exereader(sel);
            while (dr.Read())
            {
                Label2.Text = dr["address"].ToString();
                Label4.Text = dr["name"].ToString();
                Label5.Text = dr["phone"].ToString();
                
            }
            string grandtotel = "select sum(subtotal) from Order_tab where user_id=" + Session["uregid"] + "";
            string totalamount = clsobj.fn_exescalar(grandtotel);
            Label3.Text = totalamount;
            Session["totel"] = totalamount;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string delete = "delete from bill_tab where user_id="+ Session["uregid"] + "";
            int i = clsobj.fn_exenonquery(delete);
            Response.Redirect("Userhome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            
                 
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("paymentpage.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("paymentpage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string accinsr = "insert into account_tab values(" + Session["uregid"] + "," + TextBox1.Text + ",'" + DropDownList1.SelectedItem + "','" + TextBox2.Text + "')";
            int ins = clsobj.fn_exenonquery(accinsr);
            if (ins == 1)
            {
                Label6.Visible = true;
                Label6.Text = "Account Details Added";
            }
        }
    }
}