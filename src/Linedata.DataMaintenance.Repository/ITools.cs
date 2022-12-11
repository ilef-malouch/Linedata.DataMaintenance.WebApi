
namespace Linedata.DataMaintenance.Repository
{
    public interface ITools
    {
        public string? GetMonthDesc(short? n);
        public int? GetIssuerId(string? issuer);
        public string? GetMortgageDesc(short? n);
        public string? GetMortgageGenericTicker(short? n);
        public int? GetCmplSecurityTypeId(string? mnemonic, string? name);
        public int? GetCountryId(string? mnemonic);
        public string? GetCountryMnemonic(int? id);
        public int? GetExchangeId(string? mnemonic);
        public int? GetCurrencyId(string? mnemonic);
        public int? GetEntityFormId (string? mnemonic);
        public string? GetEntityFormMnemonic(short? id);
        public int? GetLegalFormId (string? mnemonic);
        public string? GetLegalFormMnemonic(short? id);
        public string? GetCounterpartyMnemonic(int? id);
        public short? GetMajorAssetId (string? mnemonic);
        public short? GetMinorAssetId (string? mnemonic);
    }
}
