using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Configuration;
/**
* This is a mini profile extended web application which is all about Md Mamunur Rahman 
* 
* @FileName: Contact.aspx.cs
* @Author Md Mamunur Rahman
* @student ID: 300872772
* @Last Update 30-September-2016
* @website: http://mamun-portfolio.azurewebsites.net/Default.aspx
* @description: this file is main cs file for the website
*/
namespace GameTracker.Pages
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {



            try
            {
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("mamun131@gmail.com", "rahman123");
                    smtp.Timeout = 20000;
                }
                // Passing values to smtp object
                smtp.Send("mamun131@gmail.com", email.Text, "Confirmation Email", "Thanks for submitting your contact detail");
                //emailConfirmation.Text = "A confirmation email has been sent to your email address";
                Page.ClientScript.RegisterStartupScript(
              Page.GetType(),
             "MessageBox",
             "<script language='javascript'>alert('" + "A confirmation email has been sent to your email address" + "');</script>"
);
            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);
            }


            //  Response.Redirect("default.aspx");
        }
    }
}