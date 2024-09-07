using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;

namespace twolayer2
{
    public partial class replay : System.Web.UI.Page
    {
        connectionClass clsobj = new connectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
             TextBox2.Text = Session["gmail"].ToString();
           
            TextBox1.Text = "nandhuakhin2707@gmail.com";
           
          
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            emailsend("projectjuly", TextBox1.Text, "ljuc tdpk sarn dzgr", "username", TextBox2.Text, TextBox3.Text, TextBox4.Text);

        }

        public static void emailsend(string yourname, string yourgmailusername, string yourgmailpassword, string toname, string toemail, string body, string subject)
        {
            string to = toemail; //To address    
            string from = yourgmailusername; //From address
                                             
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourgmailusername, yourgmailpassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}