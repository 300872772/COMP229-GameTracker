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

namespace GameTracker
{
    public partial class Team : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TeamData();
        }



        protected void TeamData()
        {

            // connect to EF DB
            using (gametracker db = new gametracker())
            {

                // query the Team Table using EF and LINQ
                var teamTables = (from teams in db.Teams
                                  select new
                                  {

                                      Team_Name = teams.TeamName,
                                      Team_Short_Name = teams.TeamShortName,
                                      PL1 = teams.PlayerName1,
                                      PL2 = teams.PlayerName2,
                                      PL3 = teams.PlayerName3,
                                      PL4 = teams.PlayerName4,
                                      PL5 = teams.PlayerName5,
                                      PL6 = teams.PlayerName6,
                                      PL7 = teams.PlayerName7,
                                      PL8 = teams.PlayerName8,
                                      PL9 = teams.PlayerName9,
                                      PL10 = teams.PlayerName10,
                                      PL11 = teams.PlayerName11,
                                      PL12 = teams.PlayerName12,
                                      PL13 = teams.PlayerName13,
                                      PL14 = teams.PlayerName14,
                                      PL15 = teams.PlayerName15
                                  }).ToList();

                TeamGridView.DataSource = teamTables;
                TeamGridView.DataBind();


            }
        }
    }
}