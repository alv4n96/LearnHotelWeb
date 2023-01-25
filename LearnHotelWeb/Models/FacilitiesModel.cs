using LearnHotelWeb.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace LearnHotelWeb.Models
{
    public class FacilitiesModel
    { 

        [Key] public int FaciId { get; set; }
        [Required] public int FaciCagroId { get; set; }
        [Required] public int FaciHotelId { get; set; }
        [Required] public string FaciName { get; set; }
        public string FaciDescription { get; set; }
        public int FaciMaxNumber { get; set; }
        public FaciMeasureUnitEnum FaciMeasureUnit { get; set; }
        [Required] public string FaciRoomNumber { get; set; }
        [Required] public DateOnly FaciStartDate { get; set; }
        [Required] public DateOnly FaciEndDate { get; set; }
        [Required] public decimal FaciLowPrice { get; set; }
        [Required] public decimal FaciHighPrice { get; set; }
        [Required] public decimal FaciRatePrice { get; set; }
        public float FaciDiscount { get; set; }
        public float FaciTaxRate { get; set; }
        public DateTime FaciModifiedDate { get; set; } = DateTime.Now;

    }
}
