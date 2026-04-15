using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Venue
    {
        public int VenueID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [Required]
        [Range(1, 10000)]
        public int Capacity { get; set; }

        public string? ImageURL { get; set; }
    }
}
