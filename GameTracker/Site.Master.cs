using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * This is a Game tracker web application  
 * 
 * @FileName: Site.Master.aspx.cs
 * @Author Md Mamunur Rahman and Aayushi
 * @student ID: 300872772 and 
 * @Last Update 07-October-2016
 * @website: http://mamun-aayushi-gametracker.azurewebsites.net/
 * @description: this file is main cs file for the website
 */

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace GameTracker
{
    /**  
* <summary>  
* This is the Site class for Site.Master page.  
* </summary>  
*   
* @class Site  
*/
    public partial class Site : System.Web.UI.MasterPage
    {

        //PROTECTED METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the protected method for for loading Contact page code
        * </summary>
        * 
        * @method Page_Load
        * @returns {void} 
        * @param {object} sender
        * @param {EventArgs} e
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            Mainmenue.Visible = false;
            logout.Visible = false;
            try
            {
                if (!String.IsNullOrEmpty(Session["UserName"].ToString()))
                {

                    //Read values from session
                    string username = Session["UserName"].ToString();
                    Login.InnerText = "Logged In: " + username.ToString();
                    Mainmenue.Visible = true;
                    logout.Visible = true;
                }
            }
            catch { }

            switch (Page.Title)
            {

                case "Home":
                    Home.Attributes.Add("class", "active");
                    navtab.Visible = false;

                    break;
                case "News":
                    News.Attributes.Add("class", "active");
                    navtab.Visible = false;
                    break;
                case "Games":
                    Games.Attributes.Add("class", "active");
                    Match.Attributes.Add("class", "active");
                    navtab.Visible = true;
                    break;
                case "MatchStatistics":
                    Games.Attributes.Add("class", "active");
                    Statistics.Attributes.Add("class", "active");

                    navtab.Visible = true;
                    break;
                case "PointTable":
                    Games.Attributes.Add("class", "active");
                    Point.Attributes.Add("class", "active");

                    navtab.Visible = true;
                    break;
                case "Team":
                    Games.Attributes.Add("class", "active");
                    Team.Attributes.Add("class", "active");
                    navtab.Visible = true;
                    break;
                case "About":
                    About.Attributes.Add("class", "active");
                    navtab.Visible = false;
                    break;
                case "Contacts":
                    Contacts.Attributes.Add("class", "active");
                    navtab.Visible = false;
                    break;

                case "Logout":
                    logout.Visible = false;
                    navtab.Visible = false;
                    
                    Login.InnerText = "Log In";
                    break;
                case "Login":
                  //  logout.Visible = true;
                    navtab.Visible = false;
                    break;

            }

        }
    }
}