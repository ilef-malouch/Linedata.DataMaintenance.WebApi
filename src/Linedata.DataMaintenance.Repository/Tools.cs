using Linedata.DataMaintenance.Repository.Models;

namespace Linedata.DataMaintenance.Repository
{
    public class Tools : ITools
    {
        private readonly DataContext _dataContext;
        public Tools(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public string? GetMonthDesc(short? id)
        {
            if (id == null)
                return string.Empty;
            return _dataContext.SettlementMonths
                .Where(m => m.SettlementMonthId == id)
                .Select(m => m.SettlementMonthDesc)
                .FirstOrDefault();
        }

        public int? GetIssuerId(string? issuer)
        {
            if(string.IsNullOrEmpty(issuer))
                return null;
            return _dataContext.Issuers
                        .Where(m => m.ShortName.ToLower() == issuer.ToLower())
                        .Select(m => m.IssuerId)
                        .FirstOrDefault();
        }
        public string? GetMortgageDesc(short? id)
        {
            if (!id.HasValue)
                return string.Empty;
            return _dataContext.Mortgages
                       .Where(m => m.MortgageTypeId == id)
                       .Select(m => m.MortgageTypeDesc)
                       .FirstOrDefault();
        }
        public string? GetMortgageGenericTicker(short? id)
        {
            if (!id.HasValue)
                return string.Empty;
            return _dataContext.Mortgages
                       .Where(m => m.MortgageTypeId == id)
                       .Select(m => m.GenericTicker)
                       .FirstOrDefault();
        }

        public int? GetCmplSecurityTypeId(string? mnemonic, string? name)
        {
            if(string.IsNullOrEmpty(mnemonic) && string.IsNullOrEmpty(name))
                return null;
            return _dataContext.CmplSecurityTypes
                    .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                    .Select(se => se.CmplSecurityTypeId)
                    .FirstOrDefault();
        }

        public int? GetCountryId(string? mnemonic)
        {
            if(string.IsNullOrEmpty(mnemonic))
                return null;
            return _dataContext.Countries
                       .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                       .Select(se => se.CountryId)
                       .FirstOrDefault();
        }

        public string? GetCountryMnemonic(int? id)
        {
            if (!id.HasValue)
                return string.Empty;

            return _dataContext.Countries
                        .Where(m => m.CountryId == id)
                        .Select(_country => _country.Mnemonic)
                        .FirstOrDefault();
        }

        public int? GetExchangeId(string? mnemonic)
        {
            if(string.IsNullOrEmpty(mnemonic))
                return null;
            return _dataContext.Exchanges
                      .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                      .Select(se => se.ExchangeId)
                      .FirstOrDefault();
        }

        public int? GetCurrencyId(string? mnemonic)
        {
            if (string.IsNullOrEmpty(mnemonic))
                return null;
            return _dataContext.Currencies
                      .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                      .Select(se => se.SecurityId)
                      .FirstOrDefault();
        }

        public int? GetEntityFormId(string? mnemonic)
        {
            if (string.IsNullOrEmpty(mnemonic))
                return null;
            return _dataContext.EntityForms
                        .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                        .Select(se => se.EntityFormId)
                        .FirstOrDefault();
        }

        public string? GetEntityFormMnemonic(short? id)
        {
            if (!id.HasValue)
                return string.Empty;
            return _dataContext.EntityForms
                            .Where(m => m.EntityFormId == id)
                            .Select(se => se.Mnemonic)
                            .FirstOrDefault();
        }

        public int? GetLegalFormId(string mnemonic)
        {
            if (string.IsNullOrEmpty(mnemonic))
                return null;
            return _dataContext.LegalForms
                       .Where(se => se.Mnemonic.ToLower() == mnemonic.ToLower())
                       .Select(se => se.LegalFormId)
                       .FirstOrDefault();
        }
        public string? GetLegalFormMnemonic(short? id)
        {
            if (!id.HasValue)
                return string.Empty;
            return _dataContext.LegalForms
                        .Where(m => m.LegalFormId == id)
                        .Select(se => se.Mnemonic)
                        .FirstOrDefault();
        }

        public string? GetCounterpartyMnemonic(int? id)
        {
            if (!id.HasValue)
                return String.Empty;
            return _dataContext.Counterparty
                        .Where(m => m.CounterpartyId == id)
                        .Select(se => se.Mnemonic)
                        .FirstOrDefault();
        }

        public short? GetMajorAssetId(string? desc)
        {
            if (string.IsNullOrEmpty(desc))
                return null;
            return _dataContext.MajorAssets
                        .Where(m => m.Description.ToLower() == desc.ToLower())
                        .Select(se => se.MajorAssetId)
                        .FirstOrDefault();
        }

        public short? GetMinorAssetId(string? desc)
        {
            if (string.IsNullOrEmpty(desc))
                return null;
            var result = _dataContext.MinorAssets
                        .Where(m => m.Description.ToLower() == desc.ToLower())
                        .Select(se => se.MinorAssetId)
                        .FirstOrDefault();
            return result;
        }
    }
    }

