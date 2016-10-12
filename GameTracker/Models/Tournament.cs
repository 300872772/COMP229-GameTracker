namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tournament")]
    public partial class Tournament
    {
        public int TournamentID { get; set; }

        [Required]
        [StringLength(50)]
        public string TournamentName { get; set; }
    }
}
