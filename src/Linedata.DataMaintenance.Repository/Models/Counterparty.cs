
namespace Linedata.DataMaintenance.Repository.Models
{
    public class Counterparty
    {
        public byte Deleted { get; set; }
        public int CounterpartyId { get; set; }
        public string Name { get; set; } = null!;
        public string Mnemonic { get; set; } = null!;
        public short? SourceSystemId { get; set; }
        public string? ClientCounterpartyId { get; set; }
    }
}
