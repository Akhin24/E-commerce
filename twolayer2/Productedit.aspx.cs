using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace twolayer2
{
    public partial class Productedit : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            gridbind_fns();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
        public void gridbind_fns()
        {
            string selgd = "select * from product_tab";
            DataSet ds = objcls.fn_exeadapter(selgd);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow gr = GridView1.Rows[e.NewSelectedIndex];
            Session["pid"] = gr.Cells[1].Text;
            TextBox2.Text = gr.Cells[3].Text;
            TextBox3.Text = gr.Cells[4].Text;
            TextBox4.Text = gr.Cells[6].Text;
            TextBox5.Text = gr.Cells[7].Text;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/ppp/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));
            string srtpup = "update product_tab set pname='" + TextBox2.Text + "',pprize=" + TextBox3.Text + ",pimage='" + s + "',pdescription='" + TextBox4.Text + "',stock=" + TextBox5.Text + " where pid=" + Session["pid"] + "";
            int u = objcls.fn_exenonquery(srtpup);
            if (u == 1)
            {
                Label1.Visible = true;
                Label1.Text = "UPDATED";
            }
        }
    }
}