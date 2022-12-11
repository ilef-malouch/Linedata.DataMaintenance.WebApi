
namespace Linedata.DataMaintenance.Repository.Models
{
    public class MinorAsset
    {
        public short MinorAssetId{ get; set; }
        public string? Mnemonic { get; set; }
        public string? Description { get; set; }
        public float PricingFactor { get; set; }
        public float IncomeFactor { get; set; }
    }
}
