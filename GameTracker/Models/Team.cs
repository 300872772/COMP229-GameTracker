namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        public int TeamID { get; set; }

        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }

        [Required]
        [StringLength(10)]
        public string TeamShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string Flag { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName1 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName2 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName3 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName4 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName5 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName6 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName7 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName8 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName9 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName10 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName11 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName12 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName13 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName14 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerName15 { get; set; }
    }
}
