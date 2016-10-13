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

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {




        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (gametracker db = new gametracker())
            {
                // use the student model to create a new student object and 
                // save a new record

                Match newMatch = new Match();

                int MatchID = 0;

                if (Request.QueryString.Count > 0) // our URL has a STUDENTID in it
                {
                    // get the id from the URL
                    //   MatchID = Convert.ToInt32(Request.QueryString["StudentID"]);

                    // get the current student from EF db
                    //  newStudent = (from student in db.Students
                    //               where student.StudentID == StudentID
                    //               select student).FirstOrDefault();
                }

                // add form data to the new student record
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



                // use LINQ to ADO.NET to add / insert new student into the db

                if (MatchID == 0)
                {
                    db.Matches.Add(newMatch);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated students page
                Response.Redirect("~/default.aspx");




            }
        }
    }
}