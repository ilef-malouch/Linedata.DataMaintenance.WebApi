
namespace Linedata.DataMaintenance.Repository.Models
{
    public class LegalForm
    {
        public short LegalFormId { get; set; }
        public string Mnemonic { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
