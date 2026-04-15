using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public string? ImageURL { get; set; }
    }
}
