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
    
    public partial class viewcart : System.Web.UI.Page
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
            string sel = "select * from cart_tab";
            DataSet ds = clsobj.fn_exeadapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int cartid = Convert.ToInt32(e.CommandArgument);
            string delete = "delete from cart_tab where cart_id=" + cartid + "";
            int i = clsobj.fn_exenonquery(delete);
            gridview_fn();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridview_fn();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridview_fn();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getcartid = Convert.ToInt32(GridView1.DataKeys[i].Value);

            string getpid = "select product_id from Cart_tab where cart_id=" + getcartid + "";
            string productid = clsobj.fn_exescalar(getpid);
            
            string getprdprice = "select pprize from product_tab where pid=" + productid + "";
            string pprize = clsobj.fn_exescalar(getprdprice);
            int pp = Convert.ToInt32(pprize);

            TextBox txtquandity = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];

            int qn = Convert.ToInt32(txtquandity.Text);
            int subttl = pp * qn;

            string update = "update Cart_tab set quandity=" + txtquandity.Text + ",subtotal=" + subttl+ " where cart_id=" + getcartid + "";
            int s = clsobj.fn_exenonquery(update);


            GridView1.EditIndex = -1;
            gridview_fn();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selmacid = "select max(cart_id) from Cart_tab";
            string m = clsobj.fn_exescalar(selmacid);
            int ma = Convert.ToInt32(m);
            string  quandity="";
            string subtotal = "";
           //string cartid = "";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
           
            for (int i = 1; i <= ma; i++)
            {
                string sel = "select * from Cart_tab where cart_id=" + i + "";
                SqlDataReader dr = clsobj.fn_exereader(sel);
                while (dr.Read())
                {
                    
                    quandity = dr["quandity"].ToString();
                    subtotal= dr["subtotal"].ToString();
                    Session["cartid"] = dr["cart_id"].ToString();
                    Session["uregid"] = dr["user_reg_id"].ToString();
                    Session["proid"] = dr["product_id"].ToString();
                }
                //ordertable insertion
                string ordtabinsert = "insert into Order_tab values(" + Session["urid"] + "," + Session["proid"] + "," + quandity + "," + subtotal + ",'Ordered','" + date + "')";
                int ins = clsobj.fn_exenonquery(ordtabinsert);

                //delete query
                string delcart = "delete  from Cart_tab where cart_id=" + Session["cartid"] + "";
                int del = clsobj.fn_exenonquery(delcart);
                Session["quandity"] = quandity;
            }
            //totelamount
            string totalamount = "select sum(subtotal) from Order_tab";
            string ttlamt = clsobj.fn_exescalar(totalamount);

            //bill table insertion
            string billtabinsert = "insert into bill_tab values(" + Session["urid"] + ","+ttlamt+",'"+date+"')";
            int billins = clsobj.fn_exenonquery(billtabinsert);
            if (billins == 1)
            {
                Response.Redirect("billpage.aspx");
            }
           
           
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string delcart = "delete  from Cart_tab where cart_id=" + Session["cartid"] + "";
            int del = clsobj.fn_exenonquery(delcart);
            Response.Redirect("Userhome.aspx");

        }
    }
}