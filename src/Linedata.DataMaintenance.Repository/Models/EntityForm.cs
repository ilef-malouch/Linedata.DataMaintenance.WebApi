
namespace Linedata.DataMaintenance.Repository.Models
{
    public class EntityForm
    {
        public short EntityFormId { get; set; }
        public string Mnemonic { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
