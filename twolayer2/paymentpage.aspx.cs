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
    public partial class accountpage : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//check balance
        {
           
            
            int ttl = Convert.ToInt32(Session["totel"]);
            Balance_check.ServiceClient obj = new Balance_check.ServiceClient();
            string bal = obj.check_balance(TextBox1.Text);
            int balalace = Convert.ToInt32(bal);
            int upbamt =  balalace-ttl;
            if (ttl < balalace)
            {
                //balaceupdate
                update_accounttable_userid.ServiceClient upobj = new update_accounttable_userid.ServiceClient();
                string acbalup = upobj.update_balace_amount(upbamt.ToString(), Session["urid"].ToString());

                



                //product table stock update
                
                 int proid = 0;
                 string quandity = "";            
                


                string selmax = "select product_id,quandity from Order_tab where user_id=" + Session["urid"] + "";
                SqlDataReader dr = clsobj.fn_exereader(selmax);
               List<int> prolistid = new List<int>();
                while (dr.Read())
                {
                    proid = Convert.ToInt32( dr["product_id"].ToString());
                    quandity = dr["quandity"].ToString();
                    prolistid.Add(proid);
                    
                }
                
                 foreach (var pid in prolistid)
                {
                    string sel = "select stock from product_tab where pid=" + pid + "";
                    string z = clsobj.fn_exescalar(sel);

                    string qunty = "select quandity from Order_tab where  product_id=" + pid + "and orderstatus='Ordered'";
                    string q = clsobj.fn_exescalar(qunty);

                    int updtedstock = Convert.ToInt32(z) -Convert.ToInt32(q);
                    string upordrtab = "update Order_tab set orderstatus='payed'where user_id="+ Session["urid"] + "and product_id="+pid+"";
                    int i = clsobj.fn_exenonquery(upordrtab);
                    if (updtedstock > 0)
                    {
                       // updatedstock = Convert.ToInt32(stk) - Convert.ToInt32(quandity);
                        string updatestk = "update product_tab set stock=" + updtedstock + "where pid=" + pid + "";
                        int zz = clsobj.fn_exenonquery(updatestk);
                        if (zz == 1)
                        {
                            
                            Panel1.Visible = true;
                        }
                    }
                    else
                    {
                        Label1.Text = "order not placed";
                    }
                    //order table status update
                   
                }
                //string selectstock = "select stock from product_tab where pid=" + proid + "";
                //string s = clsobj.fn_exescalar(selectstock);
                //stk = Convert.ToInt32(s);
                //if (stk > 0)
                //{
                //    updatedstock = Convert.ToInt32(stk) - Convert.ToInt32(quandity);
                //    string updatestk = "update product_tab set stock=" + updatedstock + "where pid=" + proid + "";
                //    int z = clsobj.fn_exenonquery(updatestk);
                //    if (z == 1)
                //    {
                //        Panel1.Visible = true;
                //    }
                //}
                //else
                //{
                //    Label1.Text = "order not placed";
                //}
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Insufficent Bank Balance";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string feedins = "insert into feedback_tab values("+ Session["urid"] + ",'"+TextBox2.Text+"','notReplayed','notviewed')";
            int z = clsobj.fn_exenonquery(feedins);
            if (z == 1)
            {
                Label4.Visible = true;
                Label4.Text = "Thank you for sending feedback";
            }
        }
    }
}