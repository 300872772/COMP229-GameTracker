using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameTracker.Models;
using System.Web.ModelBinding;
using System.Data.SqlClient;
using System.Linq.Dynamic;
using System.Data.Entity.SqlServer;
using System.Globalization;
/**
* This is a Game tracker web application  
* 
* @FileName: Games.aspx.cs
* @Author Md Mamunur Rahman and Aayushi
* @student ID: 300872772 and 
* @Last Update 07-October-2016
* @website: http://mamun-aayushi-gametracker.azurewebsites.net/
* @description: this file is main cs file for the website
*/
namespace GameTracker.Pages
{
    /**  
 * <summary>  
 * This is the Games class for Games page.  
 * </summary>  
 *   
 * @class Games  
 */
    public partial class Games : System.Web.UI.Page
    {

        //PROTECTED METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the protected method for for loading Games page code
        * </summary>
        * 
        * @method Page_Load
        * @returns {void} 
        * @param {object} sender
        * @param {EventArgs} e
        */
        protected void Page_Load(object sender, EventArgs e)
        {

            GamepageHeading(0);

            int WeekNumber = Convert.ToInt32(Request.QueryString["WeekNum"]);

            if (WeekNumber != 0)
            {
                displayMatchesInGrid(WeekNumber);
                GamepageHeading(WeekNumber);
            }
            else { displayMatchesInGrid(40); }



        }

        public void GamepageHeading (int week){

            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum;
            if (week == 0) { 
             weekNum = ciCurr.Calendar.GetWeekOfYear(Convert.ToDateTime("2016/10/12"), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            }else {
                weekNum = week;
            }
            matchDate.InnerHtml = " Today <br>" + DateTime.Now.ToString("dd/MMM/yyyy") + " <br><a href = 'Games.aspx?WeekNum=" + (weekNum - 1) + "'>   <  </a>";

            tournament.InnerHtml = "Tournament <br> Lalega";
            matchWeek.InnerHtml = "Week <br> " + weekNum.ToString() + "<br>" + " <a href='Games.aspx?WeekNum=" + (weekNum + 1) + "'>   > </a>";
        }
        public void displayMatchesInGrid(int week)
        {

            
            // connect to EF DB
            using (gametracker db = new gametracker())
            {

                // query the Matches Table using EF and LINQ
                var matches = (from allMatches in db.Matches
                               join teams1 in db.Teams on allMatches.Team1ID equals teams1.TeamID
                               join teams2 in db.Teams on allMatches.Team2ID equals teams2.TeamID
                               join matchStatistic in db.MatchStatistics on allMatches.MatchID equals matchStatistic.MatchID
                               where allMatches.Week == week
                                 select  new
                                 {
                                     MatchID = allMatches.MatchID,
                                     MatchDate = SqlFunctions.DateName("month", allMatches.MatchDate) + " " +SqlFunctions.DateName("day", allMatches.MatchDate) + ", "  + SqlFunctions.DateName("year", allMatches.MatchDate),
                                     TeamName1 = teams1.TeamName,
                                     Flag1 = "~/Assets/Flags/" +  teams1.Flag + ".gif",
                                     Result =  matchStatistic.T1Goal + " - " + matchStatistic.T2Goal,
                                     TeamName2 = teams2.TeamName,
                                     Flag2 = "~/Assets/Flags/" + teams2.Flag + ".gif",
                                 }).ToList();
              


                // bind the result to the MatchGridView 
                MatchGridView.DataSource = matches.AsQueryable().OrderBy("MatchDate desc").ToList();
                MatchGridView.DataBind();
                MatchGridView.Columns[0].Visible = false;
                // MatchGridView.HeaderRow.Cells[0].HorizontalAlign = HorizontalAlign.Right;


            }

        }



       

        protected void GridView_OnSelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void MatchGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#ceedfc'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=''");
                e.Row.Attributes.Add("style", "cursor:pointer;");
                 e.Row.Attributes.Add("onclick", "location='Statistics.aspx?MatchID=" + e.Row.Cells[0].Text + "'");


            }
        }
    }
}