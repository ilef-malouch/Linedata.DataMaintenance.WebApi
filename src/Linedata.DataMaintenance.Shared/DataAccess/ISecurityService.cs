using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Shared.DataAccess
{
    public interface ISecurityService
    {
        //security with id
        public Task<EquityDto> GetSecuritywithId (int id);


        //Security equity non deleted 
        public Task<List<EquityDto>> GetSecuritiesEquity(string minorDesc ,string? symbol, string? name, string? ticker, string? reuters, string? cusip, string? sedol, string? isin, string? issuer);

        //Security Bond Forward non deleted 
        public Task<List<BondForwardDto>> GetSecuritiesBondForward(string? symbol, string? mortgageType, string? settlementMonth, string? agency, string? turm, double couponMin, double couponMax);

        //Security Option non deleted 
        public Task<List<OptionDto>> GetSecuritiesOption(string? symbol, string? name, string? ticker, string? reuters, string? isuuer);

        //Security Fund non deleted 
        public Task<List<FundDto>> GetSecuritiesFund(string? symbol, string? name, string? ticker, string? cusip, string? issuer);

        //Security Futures non deleted 
        public Task<List<FuturesDto>> GetSecuritiesFutures(string? symbol, string? name, string? issuer);


        //Delete security with id
        public void DeleteSecurityWithId (int id);

        //Restore security with id
        public void RestoreSecurityWithId(int id);
        

        //Add Security Equity
        public Task<bool> AddSecurityEquity(EquityDtoInput secDto);

        //Add Security Equity
        public Task<bool> AddSecurityFund(FundDtoInput secDto);

        //Add Security Equity
        public Task<bool> AddSecurityFutures(FuturesDtoInput secDto);


        //Update security Equity
        public Task<bool> UpdateSecurityEquity(int id, EquityDtoInput secDto);
    }
}
