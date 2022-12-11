
using Linedata.DataMaintenance.Repository.Models;

namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class IssuerResponseDto
    {
        public List<IssuerDto> Issuers { get; set; } = new List<IssuerDto>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
