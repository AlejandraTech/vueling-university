namespace StarWarsRoutes.Library.Contracts.DTOs
{
    public class PriceResponseDto
    {
        public decimal TotalAmount { get; set; }
        public decimal PricesPerLunarDay { get; set; }
        public TaxesDto Taxes { get; set; }
    }
}
