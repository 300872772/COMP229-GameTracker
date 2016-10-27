using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * This is a Game tracker web application  
 * 
 * @FileName: About.aspx.cs
 * @Author Md Mamunur Rahman and Aayushi
 * @student ID: 300872772 and 
 * @Last Update 07-October-2016
 * @website: http://mamun-aayushi-gametracker.azurewebsites.net/
 * @description: this file is About cs file for the website
 */
namespace GameTracker.Pages
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Response.Redirect("http://www.fifa.com/about-fifa/news/index.html");
        }
    }
}