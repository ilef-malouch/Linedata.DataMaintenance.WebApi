using System.ComponentModel.DataAnnotations;

namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class EquityDtoInput :InputDto
    {
        public string? Ticker { get; set; } //UserId1
        public string? Reuters { get; set; } //UserId2
        public string? CUSIP { get; set; } //UserId3
        public string? SEDOL { get; set; } //UserId4
        public string? ISIN { get; set; } //UserId5
        //CycleId



    }
}
