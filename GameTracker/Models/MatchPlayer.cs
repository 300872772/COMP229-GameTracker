namespace GameTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MatchPlayer
    {
        [Key]
        public int MatchID { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName1C { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName2G { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName3 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName4 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName5 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName6 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName7 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName8 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName9 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName10 { get; set; }

        [Required]
        [StringLength(50)]
        public string T1PlayerName11 { get; set; }
    }
}
