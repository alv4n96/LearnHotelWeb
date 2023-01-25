
namespace LearnHotelWeb.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public short HotelRatingStar { get; set; }
        public string HotelPhoneNumber { get; set; }
        public DateTime HotelModifiedDate { get; set; } = DateTime.Now;
        public int HotelAddressId { get; set; }


    }
}
