using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameTracker.Models;
using System.Web.ModelBinding;


namespace GameTracker
{
    public partial class MatchDataAddForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Use EF to conect to the server
            using (gametracker db = new gametracker())
            {
                

                Match newMatch = new Match();
                var matches = (from allMatches in db.Matches select allMatches);

                List<String> list = new List<String>();


            }

        }

        protected void StudentsGridView_RowDeleting(object sender, GridViewDeletedEventArgs e)
        { }
        protected void StudentsGridView_PageIndexChanging(object sender, EventArgs e)
        { }

        protected void StudentsGridView_RowDataBound(object sender, GridViewSortEventArgs e)
        { }

        protected void StudentsGridView_Sorting(object sender, GridViewSortEventArgs e)
        { }


        protected void CancelButton_Click(object sender, EventArgs e)
        {




        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (gametracker db = new gametracker())
            {
           

                Match newMatch = new Match();

                int MatchID = 0;

                newMatch.Team1ID = Convert.ToInt32(team1ID.Text);
                newMatch.Team2ID = Convert.ToInt32(team2ID.Text);
                newMatch.TournamentID = Convert.ToInt32(tournamentID.Text);
                newMatch.City = city.Text;
                newMatch.Venue = venue.Text;
                newMatch.VenueCapacity = venuecapacity.Text;
                string enteredDate = matchdate.Text.Trim();
                DateTime date = DateTime.Parse(enteredDate);
                newMatch.MatchDate = date;
                newMatch.Week = Convert.ToInt32(team1ID.Text);



                if (MatchID == 0)
                {
                    db.Matches.Add(newMatch);
                }

              
                db.SaveChanges();

                
                Response.Redirect("~/default.aspx");




            }
        }
    }
}