namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MatchStatistic
    {
        [Key]
        public int MatchStatisticsID { get; set; }

        public int MatchID { get; set; }

        public int T1Goal { get; set; }

        public int T1TotalShot { get; set; }

        public int T1ShotInbox { get; set; }

        public int T1ShotOutbox { get; set; }

        public int T1Corner { get; set; }

        public int T1ShotAccuracy { get; set; }

        public int T1EarningPoints { get; set; }

        public int T2Goal { get; set; }

        public int T2TotalShot { get; set; }

        public int T3ShotInbox { get; set; }

        public int T4ShotOutbox { get; set; }

        public int T5Corner { get; set; }

        public int T6ShotAccuracy { get; set; }

        public int T7EarningPoints { get; set; }
    }
}
