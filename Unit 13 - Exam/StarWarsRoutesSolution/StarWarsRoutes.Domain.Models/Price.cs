namespace StarWarsRoutes.Domain.Models
{
    public class Price
    {
        public decimal PricePerLunarDay { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
