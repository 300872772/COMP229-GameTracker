using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * This is a mini profile extended web application which is all about Md Mamunur Rahman 
 * 
 * @FileName: Projects.aspx.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 30-September-2016
 * @website: http://mamun-portfolio.azurewebsites.net/Default.aspx
 * @description: this file is main cs file for the website
 */
namespace GameTracker.Pages
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("http://www.fifa.com/about-fifa/index.html");
        }
    }
}