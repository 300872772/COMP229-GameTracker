using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameTracker.Models;
using System.Web.ModelBinding;
using System.Data.SqlClient;
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
             using (gametracker db = new gametracker())
            {
                Match newMatch = new Match();
                //foreach (var m in db.Matches) 
                var allRows = (from p in db.Matches where p.MatchID ==1 select p).ToList();

                matchDate.InnerText = "2016-10-14";
                tournament.InnerText = "Lalega";
                matchWeek.InnerText = "Week40";
                String team1, team2, team1flag, team2flag,goal1,goal2;

             /*   var data = from u in db.Matches where u.MatchID == 5 select u;
                foreach (var item in data)
                {
                    Div1.InnerHtml += item.MatchID.ToString() + "<br>";
                }*/

                foreach (var match in db.Matches)
                {
                    team1 = "";
                    team2 = "";
                    team1flag = "";
                    team2flag = "";
                    goal1 = "";
                    goal2 = "";

                    gameData.InnerHtml += "<div class='row containerDecorationMatchBody'  runat='server'>";
                    foreach (var team in db.Teams)
                    {
                        if (team.TeamID == match.Team1ID)
                        {
                            team1 = team.TeamName;
                            team1flag=team.Flag;
                        }
                        if (team.TeamID == match.Team2ID)
                        {
                            team2 = team.TeamName;
                            team2flag = team.Flag;
                        }

                    }
                    foreach (var MatchStatistic in db.MatchStatistics)
                    {
                        if (MatchStatistic.MatchID == match.MatchID)
                        {
                            goal1 = MatchStatistic.T1Goal.ToString();
                            goal2 = MatchStatistic.T2Goal.ToString();
                        }

                    }
                    gameData.InnerHtml += " <div class='col-md-4'><img src='Assets/" + team1flag + ".png' class='img-responsive'><h4>" + team1 +" </h4></div>";
                       gameData.InnerHtml += " <div class='col-md-4'><h4> " + goal1 + "-" + goal2 + " </h4><img src='Assets/football.png' class='football'></div>";
                       gameData.InnerHtml += " <div class='col-md-4'><img src='Assets/" + team2flag + ".png' class='img-responsive'><h4> " + team2 + " </h4></div>";
           
                    gameData.InnerHtml += "</div><hr>";
                }
                
            }

           



        }

        protected void MatchButton_OnClick(object sender, EventArgs e) {
            Response.Redirect("default.aspx");
        }
    }
}