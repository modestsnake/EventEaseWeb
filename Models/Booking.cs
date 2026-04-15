using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEaseApp.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required]
        [Display(Name = "Venue")]
        public int VenueID { get; set; }

        [ForeignKey("VenueID")]
        public Venue? Venue { get; set; }

        [Required]
        [Display(Name = "Event")]
        public int EventID { get; set; }

        [ForeignKey("EventID")]
        public Event? Event { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string Status { get; set; } = "Confirmed";
    }
}
