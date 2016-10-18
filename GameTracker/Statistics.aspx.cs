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

namespace GameTracker
{
    public partial class Statistics : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            MatchID_Statistics();

        }

        protected void Default_Statistics()
        {

        }
        protected void MatchID_Statistics()
        {
            int SQLMatchID = Convert.ToInt32(Request.QueryString["MatchID"]);



            // connect to EF DB
            using (gametracker db = new gametracker())
            {

                // query the Matches Table using EF and LINQ
                var matches = (from allMatches in db.Matches
                               join teams1 in db.Teams on allMatches.Team1ID equals teams1.TeamID
                               join teams2 in db.Teams on allMatches.Team2ID equals teams2.TeamID
                               join matchStatistic in db.MatchStatistics on allMatches.MatchID
                               equals matchStatistic.MatchID
                               where allMatches.MatchID == SQLMatchID
                               select new
                               {
                                   MatchID = allMatches.MatchID,
                                   MatchDate = allMatches.MatchDate,
                                   TeamName1 = teams1.TeamName,
                                   Flag1 = "~/Assets/" + teams1.Flag + ".gif",
                                   Goal1 = matchStatistic.T1Goal,
                                   TotalShots1 = matchStatistic.T1TotalShot,
                                   CornerCick1 = matchStatistic.T1Corner,
                                   ShotInside1 = matchStatistic.T1ShotInbox,
                                   ShotOutside1 = matchStatistic.T1ShotOutbox,
                                   ShotAccuracy1 = matchStatistic.T1ShotAccuracy,
                                   Point1 = matchStatistic.T1EarningPoints,
                                   TeamName2 = teams2.TeamName,
                                   Flag2 = "~/Assets/" + teams2.Flag + ".gif",
                                   Goal2 = matchStatistic.T2Goal,
                                   TotalShots2 = matchStatistic.T2TotalShot,
                                   CornerCick2 = matchStatistic.T2Corner,
                                   ShotInside2 = matchStatistic.T2ShotInbox,
                                   ShotOutside2 = matchStatistic.T2ShotOutbox,
                                   ShotAccuracy2 = matchStatistic.T2ShotAccuracy,
                                   Point2 = matchStatistic.T2EarningPoints,
                               }).ToList();

                List<MatchStatistics> teamList = new List<MatchStatistics>();
                
                foreach (var data in matches)
                {
                    String MatchResult1 = "";
                    String MatchResult2 = "";
                    if (data.Goal1 > data.Goal2)
                    {
                        MatchResult1 = "Won";
                        MatchResult2 = "Lost";
                    }
                    else if (data.Goal1 < data.Goal2)
                    {
                        MatchResult1 = "Lost";
                        MatchResult2 = "Won"; 
                    }
                    else {
                        MatchResult1 = "Drawn";
                        MatchResult2 = "Drawn";
                    }

                        teamList.Add(new MatchStatistics { Details = "Club", Team1 = data.TeamName1, Team2 = data.TeamName2 });
                    teamList.Add(new MatchStatistics { Details = "Winning Status", Team1 = MatchResult1, Team2 = MatchResult2 });
                    teamList.Add(new MatchStatistics { Details = "Gloas", Team1 =  data.Goal1.ToString(), Team2 = data.Goal2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Total Shots",Team1 = data.TotalShots1.ToString(), Team2 = data.TotalShots2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Conrner Cick", Team1 = data.CornerCick1.ToString(), Team2 = data.CornerCick2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Shots Inside", Team1 = data.ShotInside1.ToString(), Team2 = data.ShotInside2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Shots Outside", Team1 = data.ShotOutside1.ToString(), Team2 = data.ShotOutside2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Shot Accuricy", Team1 = data.ShotAccuracy1.ToString(), Team2 = data.ShotAccuracy2.ToString() });
                    teamList.Add(new MatchStatistics { Details = "Points Earned", Team1 = data.Point1.ToString(), Team2 = data.Point2.ToString() });

                    //  StatisticsData.InnerHtml = "<h1>" + data.TeamName1 + "</h1>";

                }

                StatisticsGridView.DataSource = teamList;
                StatisticsGridView.DataBind();

               
            }
        }

       


    }

    class MatchStatistics
    {
        public String Details { get; set; }
        public String Team1 { get; set; }
        public String Team2 { get; set; }

    }
}