namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class OptionDto
    {
        public string Symbol { get; set; }

        //public DateTime ExpirationDate { get; set; }
        public string? ProductId { get; set; }
        public string? Ticker { get; set; }
        public string? Reuters { get; set; }
    }
}
