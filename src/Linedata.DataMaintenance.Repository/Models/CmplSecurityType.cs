namespace Linedata.DataMaintenance.Repository.Models
{
    public partial class CmplSecurityType
    {
        public byte Deleted { get; set; }
        public int CmplSecurityTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string Mnemonic { get; set; } = null!;
        public bool StandardType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
