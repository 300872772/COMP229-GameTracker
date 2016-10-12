namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PointTable")]
    public partial class PointTable
    {
        public int PointTableID { get; set; }

        public int TeamID { get; set; }

        public int TournamentID { get; set; }

        public int Year { get; set; }

        public int PL { get; set; }

        public int W { get; set; }

        public int L { get; set; }

        public int D { get; set; }

        public int GF { get; set; }

        public int GA { get; set; }

        public int GD { get; set; }

        public int PTS { get; set; }
    }
}
