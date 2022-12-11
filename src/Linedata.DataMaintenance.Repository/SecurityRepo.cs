using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository
{
    public class SecurityRepo : ISecurityRepo
    {
        private readonly DataContext _dataContext;
        private readonly ITools _tools;

        public SecurityRepo(DataContext dataContext, ITools tools)
        {
            _dataContext = dataContext;
            _tools = tools;
        }

        //Security  with id
        public async Task<Security> GetSecurityWithId(int id)
        {
            var security = _dataContext.Securities
                        .Where(se => se.SecurityId == id)
                        .Where(se => se.Deleted == false)
                        .FirstOrDefaultAsync();
            return await security;
        }

        //All equity securities non deleted 
        public async Task<List<Security>> GetAllSecuritiesEquity( string minorDesc)
        {
            var majorId = _dataContext.MajorAssets
                                .Where(m => m.Description.ToLower() == "Equity".ToLower())
                                .Select(s => s.MajorAssetId).FirstOrDefault();
            
            var minorId = _dataContext.MinorAssets
                                .Where(m => m.Description.ToLower() == minorDesc.ToLower())
                                .Select(s => s.MinorAssetId).FirstOrDefault();
            

            var securities = _dataContext.Securities
                                .Where(s => s.Deleted == false)
                                .Where(s => s.MajorAssetId == majorId)
                                .Where(s => s.MinorAssetId == minorId).ToListAsync();

            return await securities;
        }

        //Securities equity non deleted
        public async Task<List<Security>> GetSecuritiesEquity(string minorDesc, string? symbol, string? name, string? ticker, string? reuters, string? cusip, string? sedol, string? isin, string? issuer)
        {
            var securities = await this.GetAllSecuritiesEquity(minorDesc);
            if (!string.IsNullOrEmpty(symbol))
                securities = securities.Where(se => se.Symbol.ToLower() == symbol.ToLower()).ToList();

            if (!string.IsNullOrEmpty(name))
                securities = securities.Where(se => se.Name1.ToLower() == name.ToLower()).ToList();

            if (!string.IsNullOrEmpty(ticker))
                securities = securities.Where(se => se.UserId1.ToLower() == ticker.ToLower()).ToList();

            if (!string.IsNullOrEmpty(reuters))
                securities = securities.Where(se => se.UserId2.ToLower() == reuters.ToLower()).ToList();

            if (!string.IsNullOrEmpty(cusip))
                securities = securities.Where(se => se.UserId3.ToLower() == cusip.ToLower()).ToList();

            if (!string.IsNullOrEmpty(sedol))
                securities = securities.Where(se => se.UserId4.ToLower() == sedol.ToLower()).ToList();

            if (!string.IsNullOrEmpty(isin))
                securities = securities.Where(se => se.UserId5.ToLower() == isin.ToLower()).ToList();

            if (!string.IsNullOrEmpty(issuer))
                securities = securities.Where(se => se.IssuerId== _tools.GetIssuerId(issuer)).ToList();

            return securities;
        }

        //All Bond Forward securities non deleted 
        public async Task<List<Security>> GetAllSecuritiesBondForward()
        {
            var id = _dataContext.MajorAssets
                               .Where(m => m.Description.ToLower() == "Bond Forward".ToLower())
                               .Select(s => s.MajorAssetId).FirstOrDefault();

            var securities = _dataContext.Securities
                                .Where(s => s.Deleted == false)
                                .Where(s => s.MajorAssetId == id).ToListAsync();

            return await securities;
        }

        //Security Bond Forward non deleted 
        public async Task<List<Security>> GetSecuritiesBondForward(string? symbol, string? mortgageType, string? settlementMonth, string? agency, string? turm, double couponMin, double couponMax)
        {
            
            
            short id1;

            var securities = await this.GetAllSecuritiesBondForward();
            if (!string.IsNullOrEmpty(symbol))
                securities = securities.Where(se => se.Symbol.ToLower() == symbol.ToLower()).ToList();

            if (!string.IsNullOrEmpty(mortgageType))
            {
                 id1 = _dataContext.Mortgages
                       .Where(m => m.MortgageTypeDesc.ToLower() == mortgageType.ToLower())
                       .Select(m => m.MortgageTypeId)
                       .FirstOrDefault();

                securities = securities.Where(se => se.TbaUmbMortgageTypeId == id1).ToList();
            }

            if (!string.IsNullOrEmpty(settlementMonth))
            {
                id1 = _dataContext.SettlementMonths
                        .Where(m => m.SettlementMonthDesc.ToLower() == settlementMonth.ToLower())
                        .Select(m => m.SettlementMonthId)
                        .FirstOrDefault();

                securities = securities.Where(se => se.TbaUmbSettlementMonthId == id1).ToList();
            }

            if (!string.IsNullOrEmpty(agency))
                securities = securities.Where(se => se.Name1.ToLower().Contains(agency)).ToList();

            if (!string.IsNullOrEmpty(turm))
                securities = securities.Where(se => se.Name1.ToLower().Contains(turm +" Yr")).ToList();

            if (couponMin != 0)
                securities = securities.Where(se => se.Coupon >= couponMin).ToList();

            if (couponMax != 0)
                securities = securities.Where(se => se.Coupon <= couponMax).ToList();

            
            return securities;
        }

        //All Option securities non deleted 
        public async Task<List<Security>> GetAllSecuritiesOption()
        {
            var id = _dataContext.MajorAssets
                                .Where(m => m.Description.ToLower() == "Option".ToLower())
                                .Select(s => s.MajorAssetId).FirstOrDefault();

            var securities = _dataContext.Securities
                                .Where(s => s.Deleted == false)
                                .Where(s => s.MajorAssetId == id).ToListAsync();

            return await securities;
        }

        //Security Option non deleted
        public async Task<List<Security>> GetSecuritiesOption(string? symbol, string? name, string? ticker, string? reuters, string? issuer)
        {
            var securities = await this.GetAllSecuritiesOption();
            if (!string.IsNullOrEmpty(symbol))
                securities = securities.Where(se => se.Symbol.ToLower() == symbol.ToLower()).ToList();
            if (!string.IsNullOrEmpty(name))
                securities = securities.Where(se => se.Name1.ToLower() == name.ToLower()).ToList();
            if(!string.IsNullOrEmpty(ticker))
                securities = securities.Where(se => se.UserId1.ToLower() == ticker.ToLower()).ToList();
            if(!string.IsNullOrEmpty(reuters))
                securities = securities.Where((se) => se.UserId2.ToLower() == reuters.ToLower()).ToList();
            if (!string.IsNullOrEmpty(issuer))
                securities = securities.Where((se) => se.IssuerId == _tools.GetIssuerId(issuer)).ToList();
           
            return securities;
        }

        //All Fund securities non deleted 
        public async Task<List<Security>> GetAllSecuritiesFund()
        {
            var id = _dataContext.MajorAssets
                                .Where(m => m.Description.ToLower() == "Fund".ToLower())
                                .Select(s => s.MajorAssetId).FirstOrDefault();

            var securities = _dataContext.Securities
                                .Where(s => s.Deleted == false)
                                .Where(s => s.MajorAssetId == id).ToListAsync();

            return await securities;
        }

        //Security Fund non deleted
        public async Task<List<Security>> GetSecuritiesFund(string? symbol, string? name, string? ticker, string? cusip, string? issuer)
        {
            var securities = await this.GetAllSecuritiesFund();
            if (!string.IsNullOrEmpty(symbol))
                securities = securities.Where(se => se.Symbol.ToLower() == symbol.ToLower()).ToList();
            if (!string.IsNullOrEmpty(name))
                securities = securities.Where(se => se.Name1.ToLower() == name.ToLower()).ToList();
            if (!string.IsNullOrEmpty(ticker))
                securities = securities.Where(se => se.UserId1.ToLower() == ticker.ToLower()).ToList();
            if (!string.IsNullOrEmpty(cusip))
                securities = securities.Where((se) => se.UserId3.ToLower() == cusip.ToLower()).ToList();
            if (!string.IsNullOrEmpty(issuer))
                securities = securities.Where((se) => se.IssuerId == _tools.GetIssuerId(issuer)).ToList();
           
            return securities;
        }


        //All Futures securities non deleted 
        public async Task<List<Security>> GetAllSecuritiesFutures()
        {
            var id = _dataContext.MajorAssets
                                .Where(m => m.Description.ToLower() == "Futures".ToLower())
                                .Select(s => s.MajorAssetId).FirstOrDefault();

            var securities = _dataContext.Securities
                                .Where(s => s.Deleted == false)
                                .Where(s => s.MajorAssetId == id).ToListAsync();

            return await securities;
        }

        //Security Futures non deleted
        public async Task<List<Security>> GetSecuritiesFutures(string? symbol, string? name, string? issuer)
        {
            var securities = await this.GetAllSecuritiesFutures();
            if (!string.IsNullOrEmpty(symbol))
                securities = securities.Where(se => se.Symbol.ToLower() == symbol.ToLower()).ToList();
            if (!string.IsNullOrEmpty(name))
                securities = securities.Where(se => se.Name1.ToLower() == name.ToLower()).ToList();
            if (!string.IsNullOrEmpty(issuer))
                securities = securities.Where(se => se.IssuerId == _tools.GetIssuerId(issuer)).ToList();
            
            return securities;
        }

        //Delete security with id
        public void DeleteSecurityWithId(int id)
        {
            var security =  _dataContext.Securities.Find(id);
            security.Deleted = true;
            _dataContext.Entry(security).State = EntityState.Modified;

            _dataContext.SaveChangesAsync();


        }

        //Restore security with id
        public void RestoreSecurityWithId(int id)
        {
            var security = _dataContext.Securities.Find(id);
            security.Deleted = false;
            _dataContext.Entry(security).State = EntityState.Modified;

             _dataContext.SaveChanges();
            
        }

        //Add Security 
        public async Task<bool> AddSecurity(Security sec)
        {
            var security = _dataContext.Securities
                                .Where(se => se.Symbol == sec.Symbol)
                                .FirstOrDefault();
            if (security == null)
            {
                sec.SecurityId = _dataContext.Securities.Max(item => item.SecurityId) + 1;
                _dataContext.Securities.Add(sec);
                _dataContext.Entry(sec).State = EntityState.Added;
                try
                {
                    await _dataContext.SaveChangesAsync();
                    return true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;

                }
            }
            return false;
        }

        //Update securiity
        public async Task<bool> UpdateSecurityEquity(int id ,Security security)
        {
            
            var sec = _dataContext.Securities.Find(id);
            if(sec == null)
                return false;

           
            sec.Name1 = security.Name1;
            //LookthroughModelId
            sec.LookthroughDepthLimit = security.LookthroughDepthLimit;
            //Description
            // SicId
            sec.SecurityAttribute = security.SecurityAttribute;
            sec.CmplSecurityTypeId = security.CmplSecurityTypeId;

            sec.CountryId = security.CountryId;
            sec.ExchangeId = security.ExchangeId;
            sec.RiskCountryId = security.RiskCountryId;
            //OtcCcpId = CCP 
            sec.PrincipalCurrencyId = security.PrincipalCurrencyId;
            sec.IncomeCurrencyId = security.IncomeCurrencyId;
            sec.LegacyCurrencyId = security.LegacyCurrencyId;
            sec.SettlementCurrencyId = security.SettlementCurrencyId;
            sec.LotSize = security.LotSize;

            sec.IssuePrice = security.IssuePrice;
            sec.AnnualDividendRate = security.AnnualDividendRate;
            sec.ParValue = security.ParValue;
            //DividendFrequency
            //DividendDayCount
            sec.PricingFactor = security.PricingFactor;
            sec.IncomeFactor = security.IncomeFactor;
            //openingPrice
            //ClosingPrice

            sec.SharesOutstanding = security.SharesOutstanding;
            sec.ShareClass = security.ShareClass;
            sec.VotesPerShare = security.VotesPerShare;
            sec.HoldingPeriod = security.HoldingPeriod;
            sec.SettlementDaysOverride = security.SettlementDaysOverride;
            sec.AdrFlag = security.AdrFlag;
            sec.PrivatePlacement = security.PrivatePlacement;
            sec.SecuritiesRelatedFlag = security.SecuritiesRelatedFlag;
            sec.DtcEligibleFlag = security.DtcEligibleFlag;
            sec.RegulationSFlag = security.RegulationSFlag;
            sec.Section144aFlag = security.Section144aFlag;
            sec.IlliquidFlag = security.IlliquidFlag;
            sec.AffiliatedCoFlag = security.AffiliatedCoFlag;
            sec.RegisteredFlag = security.AffiliatedCoFlag;
                
            sec.ModifiedBy = 4;
            sec.ModifiedTime = DateTime.Now;

            try
            {
                _dataContext.Entry(sec).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
    }
}
