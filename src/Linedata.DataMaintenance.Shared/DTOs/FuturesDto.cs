namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class FuturesDto
    {
        public string Symbol { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string? ProductId { get; set; }
    }
}
