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
    /**  
 * <summary>  
 * This is the Products class for Products page.  
 * </summary>  
 *   
 * @class Products  
 */
    public partial class Products : System.Web.UI.Page
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
            String projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl;
            String projectDetail, programingLanguage, framework, database;

            projectName = "ONLINE SHOPPING";
            projectImage = "myrasona.jpg";
            projectUrl = "http://mywebshopping.azurewebsites.net";
            gitHubUrl = "http://github.com/300872772/MyShop_Template";
            webSiteUrl = "http://mywebshopping.azurewebsites.net";
            projectDetail = "This is an Online shopping solution, particularly for grocery shop." +
                "There is an addcart option where customer can select prodect and add into the cart finally can submit for purchase. " +
                "There is a customer registration and login system to ensure protected online sales. For uploading product and product catagory" +
                " there is product uploading option restricted to admin login ctagory only." +
                "Any business can use this solution for online shopping with minimum code modification.";
            programingLanguage = "C#, CSS, HTML";
            framework = "ASP.NET MVC 4.5, Bootstrap";
            database = "SQL SERVER";

            addProject(1, projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);



            projectName = "MOVIE BONANZA";
            projectImage = "moviebonanza.jpg";
            projectUrl = "https://github.com/300872772/COMP123-S2016-Assignment7";
            gitHubUrl = "https://github.com/300872772/COMP123-S2016-Assignment7";
            webSiteUrl = "https://github.com/300872772/COMP123-S2016-Assignment7";
            projectDetail = "This is an online movie streaming selling solution desktop version," +
                " has been developed using C#.";
            programingLanguage = "C#";
            framework = "";
            database = "Text coma delaminated data";
            addProject(2, projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);


            projectName = "PORTFOLIO";
            projectImage = "personalsite.jpg";
            projectUrl = "http://mamun-portfolio-banner-ad.azurewebsites.net";
            gitHubUrl = "https://github.com/300872772/COMP125-Assignment4";
            webSiteUrl = "http://mamun-portfolio-banner-ad.azurewebsites.net";
            projectDetail = "This website is an example of dynamic responsive website developed based on Javascript & JQuery" +
                "For making it responsive Bootstrap has been used. For animation CreatJS package has been used and" +
                " CSS has ensured basic colorful decoration";
            programingLanguage = "Java Script, Type Script, Jquery, CreateJS, CSS, HTML";
            framework = "Bootstrap, Font-awesome";
            database = "Text API";
            addProject(3, projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);


            projectName = "PHOTOGRAPHY";
            projectImage = "photographer.jpg";
            projectUrl = "http://photographers.azurewebsites.net";
            gitHubUrl = "https://github.com/300872772/photographers";
            webSiteUrl = "http://photographers.azurewebsites.net";
            projectDetail = "This website is just for displaying my own photography. All site " +
                "decoration is based on CSS. There is no database for photo repository handling." +
                " This is just a raw HTML website with CSS properties.";
            programingLanguage = "CSS, HTML";
            framework = "";
            database = "";
            addProject(4, projectName, projectImage, projectUrl, gitHubUrl, webSiteUrl, projectDetail, programingLanguage, framework, database);




        }
        /**
 * <summary>
 * This is the privte method for add project page components in page
 * </summary>
 * 
 * @method addProject
 * @returns {void} 
 * @param {int} index
 * @param {string} projectName
 * @param {string} projectImage
 * @param {string} projectUrl
 * @param {string} gitHubUrl
 * @param {string} webSiteUrl
 * @param {string} programingLanguage
 * @param {string} framework
 * @param {string} database

 */
        private void addProject(int index, String projectName, String projectImage, String projectUrl, String gitHubUrl, String webSiteUrl,
            String projectDetail, String programingLanguage, String framework, String database)
        {

            //Creae the image button
            ImageButton btnImage = new ImageButton
            {

                ImageUrl = string.Format("~/Assets/{0}", projectImage),
                // PostBackUrl = string.Format("{0}", projectUrl),
                CssClass = "img-responsive",
                OnClientClick = "window.open('" + projectUrl + "')",
                Width = 400
            };

            //Create the gitHub link

            LinkButton lnkGithub = new LinkButton
            {

                OnClientClick = "window.open('" + gitHubUrl + "')",
                Text = "  GitHub  Link  ",
                ID = "gitHubLink" + index,
                CssClass = "btn btn-primary btn-lg btn-block responsive-width",
                BorderWidth = 1,
                BorderStyle = BorderStyle.None

            };

            //Create the website link

            LinkButton lnkWebSite = new LinkButton
            {

                OnClientClick = "window.open('" + webSiteUrl + "')",
                Text = "Website Link",
                ID = "webSiteLink" + index,
                CssClass = "btn btn-primary btn-lg btn-block responsive-width"
            };

            //Add an onClick event
            //  lnkDelete.Click += Delete_Items;


            //Create HTML table with tow rows
            Table table = new Table
            {
                CssClass = "table table-bordered ",
                BorderWidth = 4,
                BorderStyle = BorderStyle.Solid,
                BorderColor = System.Drawing.Color.FromArgb(121, 142, 163),
                BackColor = System.Drawing.Color.WhiteSmoke
            };

            TableRow row1 = new TableRow { BackColor = System.Drawing.Color.FromArgb(170, 181, 191) };
            TableRow row2 = new TableRow();

            //Create 6 cells for Row row1
            TableCell row1_c1 = new TableCell
            {
                Text = "<b>" + projectName + "</b>",
                HorizontalAlign = HorizontalAlign.Center,
                ForeColor = System.Drawing.Color.DarkRed
            };
            TableCell row1_c2 = new TableCell
            {

                Text = "<b>Project Detail </b>",
                HorizontalAlign = HorizontalAlign.Center,
                Width = 400
            };
            TableCell row1_c3 = new TableCell
            {
                Text = "<b>Languages</b> ",
                HorizontalAlign = HorizontalAlign.Center,
                Width = 150
            };
            /* TableCell row1_c4 = new TableCell { Text = "<b>Framework </b>",
                 HorizontalAlign = HorizontalAlign.Center
             };
             TableCell row1_c5 = new TableCell { Text = "<b>Database</b> ",
                 HorizontalAlign = HorizontalAlign.Center
             };*/
            TableCell row1_c6 = new TableCell
            {
                Text = "<b>Links </b>",
                HorizontalAlign = HorizontalAlign.Center,
                Width = 150
            };


            //Create 6 cells for Row row2
            TableCell row2_c1 = new TableCell { Width = 400 };
            TableCell row2_c2 = new TableCell
            {
                Text = projectDetail,
                HorizontalAlign = HorizontalAlign.Justify,
                Width = 400
            };
            TableCell row2_c3 = new TableCell
            {
                Text = programingLanguage + ", " + framework + ", " + database,
                HorizontalAlign = HorizontalAlign.Center,
                Width = 150
            };
            /* TableCell row2_c4 = new TableCell
             {
                 Text = framework ,
                 HorizontalAlign = HorizontalAlign.Center
             };
             TableCell row2_c5 = new TableCell
             {
                 Text = database ,
                 HorizontalAlign = HorizontalAlign.Center
             };*/
            TableCell row2_c6 = new TableCell
            {
                HorizontalAlign = HorizontalAlign.Justify,
                Width = 150
            };

            //Set special controls
            Label gap = new Label();
            gap.Text = "..................................";

            row2_c1.Controls.Add(btnImage);
            row2_c6.Controls.Add(gap);
            row2_c6.Controls.Add(lnkGithub);
            row2_c6.Controls.Add(gap);
            row2_c6.Controls.Add(lnkWebSite);

            //Add cells to row

            row1.Cells.Add(row1_c1);
            row1.Cells.Add(row1_c2);
            row1.Cells.Add(row1_c3);
            //  row1.Cells.Add(row1_c4);
            //  row1.Cells.Add(row1_c5);
            row1.Cells.Add(row1_c6);

            row2.Cells.Add(row2_c1);
            row2.Cells.Add(row2_c2);
            row2.Cells.Add(row2_c3);
            //  row2.Cells.Add(row2_c4);
            //  row2.Cells.Add(row2_c5);
            row2.Cells.Add(row2_c6);

            //Add rows to table

            table.Rows.Add(row1);
            table.Rows.Add(row2);

            //Add table to pnlShoppingCart
            pnlProject.Controls.Add(table);

            if (Request.UserAgent.Contains("Mobi") == true || Request.UserAgent.Contains("Android") == true)
            {
                Table tableAlt = new Table
                {
                    CssClass = "table table-bordered ",
                    BorderWidth = 4,
                    BorderStyle = BorderStyle.Solid,
                    BorderColor = System.Drawing.Color.FromArgb(121, 142, 163)
                };
                TableRow row1rowAlt1 = new TableRow(); row1rowAlt1.Cells.Add(row1_c1);
                TableRow row1rowAlt2 = new TableRow(); row1rowAlt2.Cells.Add(row2_c1);
                TableRow row1rowAlt3 = new TableRow(); row1rowAlt3.Cells.Add(row1_c2);
                TableRow row1rowAlt4 = new TableRow(); row1rowAlt4.Cells.Add(row2_c2);
                TableRow row1rowAlt5 = new TableRow(); row1rowAlt5.Cells.Add(row1_c3);
                TableRow row1rowAlt6 = new TableRow(); row1rowAlt6.Cells.Add(row2_c3);
                TableRow row1rowAlt7 = new TableRow(); row1rowAlt7.Cells.Add(row1_c6);
                TableRow row1rowAlt8 = new TableRow(); row1rowAlt8.Cells.Add(row2_c6);
                tableAlt.Rows.Add(row1rowAlt1);
                tableAlt.Rows.Add(row1rowAlt2);
                tableAlt.Rows.Add(row1rowAlt3);
                tableAlt.Rows.Add(row1rowAlt4);
                tableAlt.Rows.Add(row1rowAlt5);
                tableAlt.Rows.Add(row1rowAlt6);
                tableAlt.Rows.Add(row1rowAlt7);
                tableAlt.Rows.Add(row1rowAlt8);
                pnlProjectAlt.Controls.Add(tableAlt);

            }
            else
            {
                pnlProjectAlt.Visible.Equals(false);
            }

        }
    }
}