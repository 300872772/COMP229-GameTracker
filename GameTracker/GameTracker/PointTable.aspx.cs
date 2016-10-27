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
    public partial class PointTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PointData();
        }

        protected void PointData()
        {

            // connect to EF DB
            using (gametracker db = new gametracker())
            {

                // query the Matches Table using EF and LINQ
                var pointTables = (from allPoint in db.PointTables
                                   join team in db.Teams on allPoint.TeamID equals team.TeamID
                                   join tournament in db.Tournaments on allPoint.TournamentID
                                   equals tournament.TournamentID
                                   orderby tournament.TournamentName ascending
                                   select new
                                   {

                                       Year = allPoint.Year,
                                       Tournament_Name = tournament.TournamentName,
                                       Team_Name = team.TeamName,
                                       PL = allPoint.PL,
                                       W = allPoint.W,
                                       L = allPoint.L,
                                       D = allPoint.D,
                                       GF = allPoint.GF,
                                       GA = allPoint.GA,
                                       GD = allPoint.GD,
                                       PTS = allPoint.PTS
                                   }).ToList();

                PointTableGridView.DataSource = pointTables;
                PointTableGridView.DataBind();


            }





        }
    }
}