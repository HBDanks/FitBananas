using System.ComponentModel.DataAnnotations;
using System;

namespace FitBananas.Models
{
    public class BikeTotal
    {
        [Key]
        public int BikeTotalId { get; set; }
        public int Distance { get; set; }
        public int Elevation_Gain { get; set; }

        public DateTime CreatedAt{ get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // foreign key to athlete stats
        public int AthleteStatsId { get; set; }

        public AthleteStats UserStats { get; set; }
    }
}