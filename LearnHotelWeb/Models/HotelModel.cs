
using System.ComponentModel.DataAnnotations;

namespace LearnHotelWeb.Models
{
    public class HotelModel
    {
        [Key]
        public int HotelId { get; set; }
        [Required]
        public int HotelAddressId { get; set; }
        [Required]
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public short HotelRatingStar { get; set; }
        [Required]
        public string HotelPhoneNumber { get; set; }
        public DateTime HotelModifiedDate { get; set; } = DateTime.Now;
    }
}
