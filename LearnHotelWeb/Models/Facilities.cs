using System.ComponentModel.DataAnnotations;

namespace LearnHotelWeb.Models
{
    public class Facilities
    {
        public int FaciId { get; set; }
        public int FaciCagroId { get; set; }
        public int FaciHotelId { get; set; }
        public string FaciName { get; set; }
        public string FaciDescription { get; set; }
        public int FaciMaxNumber { get; set; }
        public string FaciMeasureUnit { get; set; }
        public string FaciRoomNumber { get; set; }
        public DateOnly FaciStartDate { get; set; }
        public DateOnly FaciEndDate { get; set; }
        public decimal FaciLowPrice { get; set; }
        public decimal FaciHighPrice { get; set; }
        public decimal FaciRatePrice { get; set; }
        public float FaciDiscount { get; set; }
        public float FaciTaxRate { get; set; }
        public DateTime FaciModifiedDate { get; set; }
        
    }
}
