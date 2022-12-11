namespace Linedata.DataMaintenance.Repository.Models
{
    public partial class Issuer
    {
        public int IssuerId { get; set; }
        public bool Deleted { get; set; }
        public bool InactiveFlag { get; set; }
        public string ShortName { get; set; } = null!;
        public string IssuerName { get; set; } = null!;
        public string? SicId { get; set; }
        public DateTime? InceptionDate { get; set; }
        public int? CountryId { get; set; }
        public string? EntityClip { get; set; }
        public short? EntityFormId { get; set; }
        public short? LegalFormId { get; set; }
        public string? Department { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalId { get; set; }
        public int? AddressCountry { get; set; }
        public double? TotalVotingShares { get; set; }
        public double? TotalParentVotingShares { get; set; }
        public int PhoneIndex { get; set; }
        public string? UserId1 { get; set; }
        public string? UserId2 { get; set; }
        public string? UserId3 { get; set; }
        public string? UserId4 { get; set; }
        public string? UserId5 { get; set; }
        public string? UserId6 { get; set; }
        public string? UserId7 { get; set; }
        public string? UserId8 { get; set; }
        public string? UserId9 { get; set; }
        public string? UserId10 { get; set; }
        public string? UserId11 { get; set; }
        public string? UserId12 { get; set; }
        public string? UserId13 { get; set; }
        public string? UserId14 { get; set; }
        public string? UserId15 { get; set; }
        public string? UserId16 { get; set; }
        public string? UserField1 { get; set; }
        public string? UserField2 { get; set; }
        public string? UserField3 { get; set; }
        public string? UserField4 { get; set; }
        public double? UserField5 { get; set; }
        public double? UserField6 { get; set; }
        public double? UserField7 { get; set; }
        public double? UserField8 { get; set; }
        public string? UserField9 { get; set; }
        public string? UserField10 { get; set; }
        public string? UserField11 { get; set; }
        public string? UserField12 { get; set; }
        public double? UserField13 { get; set; }
        public double? UserField14 { get; set; }
        public double? UserField15 { get; set; }
        public double? UserField16 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public short? SourceSystemId { get; set; }
        public string? ClientIssuerId { get; set; }
        public int? UltimateParentIssuerId { get; set; }
        public int? DomicileCountryId { get; set; }
        public int? RiskCountryId { get; set; }
        public int? IncCountryId { get; set; }
        public double? TotalNonVotingShares { get; set; }
        public double? TotalPrincipalOutstanding { get; set; }
        public double? TotalEquityOutstanding { get; set; }
        public double? TotalLoansOutstanding { get; set; }
        public double? TotalMarketCapitalization { get; set; }
        public double? TotalMmktOutstanding { get; set; }
        public int? CounterpartyId { get; set; }
        public int? IssuerAuditId { get; set; }
        public DateTime? AsofTime { get; set; }
        public byte? DoNotAudit { get; set; }
    }
}
