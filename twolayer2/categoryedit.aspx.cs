using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace twolayer2
{
    public partial class categoryedit : System.Web.UI.Page
    {
        connectionClass objcls = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select * from Category_tab  ";
            DataSet ds = objcls.fn_exeadapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gridview_fn();
        }
        public void gridview_fn()
        {
            string sel = "select * from  Category_tab  ";
            DataSet ds = objcls.fn_exeadapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            TextBox1.Text = rw.Cells[2].Text;
            TextBox2.Text = rw.Cells[4].Text;

            Session["cic"] = rw.Cells[1].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/ppp/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string strup = "update  Category_tab set cname='" + TextBox1.Text + "',cimage='" + p + "',cdescription='" + TextBox2.Text + "'where cat_id=" + Session["cic"]+"";
            int up = objcls.fn_exenonquery(strup);
            if (up == 1)
            {
                Label1.Visible = true;
                Label1.Text="UPDATED";
            }
        }
    }

}