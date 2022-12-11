using Linedata.DataMaintenance.Repository.Models;

namespace Linedata.DataMaintenance.Repository
{
    public interface ISecurityRepo
    {
        //Security with id
        public Task<Security> GetSecurityWithId(int id);


        //All equity securities non deleted 
        public  Task<List<Security>> GetAllSecuritiesEquity(string minorDesc);

        //Security equity non deleted 
        public  Task<List<Security>> GetSecuritiesEquity(string minorDesc, string? symbol, string? name, string? ticker, string? reuters, string? cusip, string? sedol, string? isin, string? issuer);


        //All Bond Forward securities non deleted 
        public Task<List<Security>> GetAllSecuritiesBondForward();

        //Security Bond Forward non deleted 
        public Task<List<Security>> GetSecuritiesBondForward(string? symbol, string? mortgageType, string? settlementMonth, string? agency, string? turm, double couponMin, double couponMax);


        //All Option securities non deleted
        public Task<List<Security>> GetAllSecuritiesOption();

        //Security Option non deleted 
        public Task<List<Security>> GetSecuritiesOption(string? symbol, string? name, string? ticker, string? reuters, string? issuer);


        //All Fund securities non deleted
        public Task<List<Security>> GetAllSecuritiesFund();

        //Security Fund non deleted 
        public Task<List<Security>> GetSecuritiesFund(string? symbol, string? name, string? ticker, string? cusip, string? issuer);


        //All Futures securities non deleted
        public Task<List<Security>> GetAllSecuritiesFutures();

        //Security Futures non deleted 
        public Task<List<Security>> GetSecuritiesFutures(string? symbol, string? name, string? issuer);


        //Delete security with id
        public void DeleteSecurityWithId(int id);
        //Restore security with id
        public void RestoreSecurityWithId(int id);


        //Add Security 
        public Task<bool> AddSecurity(Security sec);


        //Updata security Equity
        public Task<bool> UpdateSecurityEquity(int id, Security security);



    }
}
