namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Match")]
    public partial class Match
    {
        public int MatchID { get; set; }

        public int Team1ID { get; set; }

        public int Team2ID { get; set; }

        public int TournamentID { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Venue { get; set; }

        [Required]
        [StringLength(50)]
        public string VenueCapacity { get; set; }

        [Column(TypeName = "date")]
        public DateTime MatchDate { get; set; }

        public int Week { get; set; }
    }
}
