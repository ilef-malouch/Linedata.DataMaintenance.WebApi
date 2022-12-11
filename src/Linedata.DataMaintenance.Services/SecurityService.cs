using Linedata.DataMaintenance.Repository;
using Linedata.DataMaintenance.Shared.DataAccess;
using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Services
{
    public class SecurityService : ISecurityService
    {
        private ISecurityRepo _securityRepo;
        private ITools _tools;
        private IMapping _mapping;

        public SecurityService(ISecurityRepo securityRepo, ITools tools, IMapping mapping)
        {
            _securityRepo = securityRepo;
            _tools = tools;
            _mapping = mapping;
        }

        //security with id
        public async Task<EquityDto> GetSecuritywithId(int id)
        {
            var s = await _securityRepo.GetSecurityWithId(id);
            if (s == null)
                return null;

            return (new EquityDto()
            {
                Name = s.Name1,
                Symbol = s.Symbol,
                Ticker = s.UserId1,
                Reuters = s.UserId2,
                CUSIP = s.UserId3,
                SEDOL = s.UserId4,
                ISIN = s.UserId5
            });
        }

        //Security equity non deleted 
        public async Task<List<EquityDto>> GetSecuritiesEquity(string minorDesc, string? symbol, string? name, string? ticker, string? reuters, string? cusip, string? sedol, string? isin, string? issuer)
        {
            var sec = await _securityRepo.GetSecuritiesEquity(minorDesc, symbol, name, ticker, reuters, cusip, sedol, isin, issuer);
            var result = sec.Select(s => new EquityDto()
            {
                Name = s.Name1,
                Symbol = s.Symbol,
                Ticker = s.UserId1,
                Reuters = s.UserId2,
                CUSIP = s.UserId3,
                SEDOL = s.UserId4,
                ISIN = s.UserId5
            }).ToList();
            return result;
        }

        //Security Bond Forward non deleted 
        public async Task<List<BondForwardDto>> GetSecuritiesBondForward(string? symbol, string? mortgageType, string? settlementMonth, string? agency, string? turm, double couponMin, double couponMax)
        {
            var sec = await _securityRepo.GetSecuritiesBondForward(symbol, mortgageType, settlementMonth, agency, turm, couponMin, couponMax);
            var result = sec.Select(s => new BondForwardDto()
            {
                Name = s.Name1,
                Symbol = s.Symbol,
                SettlementMonth = _tools.GetMonthDesc(s.TbaUmbSettlementMonthId),
                MortgageType = _tools.GetMortgageDesc(s.TbaUmbMortgageTypeId),
                GenericTicker = _tools.GetMortgageGenericTicker(s.TbaUmbMortgageTypeId),
                Coupon = s.Coupon,
                Ticker = s.UserId1,
                Reuters = s.UserId2,
                CUSIP = s.UserId3,
                SEDOL = s.UserId4,
                ISIN = s.UserId5
            })
             .ToList();
            return result;

        }

        //Security Option non deleted 
        public async Task<List<OptionDto>> GetSecuritiesOption(string? symbol, string? name, string? ticker, string? reuters, string? issuer)
        {
            var sec = await _securityRepo.GetSecuritiesOption(symbol, name, ticker, reuters, issuer);
            var result = sec.Select(s => new OptionDto()
            {
                Symbol = s.Symbol,
                ProductId = s.ProductId,
                Ticker = s.UserId1,
                Reuters = s.UserId2,
            })
                .ToList();

            return result;

        }

        //Security Fund non deleted 
        public async Task<List<FundDto>> GetSecuritiesFund(string? symbol, string? name, string? ticker, string? cusip, string? issuer)
        {
            var sec = await _securityRepo.GetSecuritiesFund(symbol, name, ticker, cusip, issuer);
            var result = sec.Select(s => new FundDto()
            {
                Symbol = s.Symbol,
                Ticker = s.UserId1,
                CUSIP = s.UserId3,
            })
                .ToList();

            return result;

        }
        //Security Futures non deleted 
        public async Task<List<FuturesDto>> GetSecuritiesFutures(string? symbol, string? name, string? issuer)
        {
            var sec = await _securityRepo.GetSecuritiesFutures(symbol, name, issuer);
            var result = sec.Select(s => new FuturesDto()
            {
                Symbol = s.Symbol,
                MaturityDate = s.MaturityDate,
                ProductId = s.ProductId
            })
                .ToList();
            return result;

        }

        //Delete security with id
        public void DeleteSecurityWithId(int id)
        {
            _securityRepo.DeleteSecurityWithId(id);
        }
        //Restore security with id
        public void RestoreSecurityWithId(int id)
        {
            _securityRepo.RestoreSecurityWithId(id);
        }

        //Add Security Equity
        public async Task<bool> AddSecurityEquity(EquityDtoInput secDto)
        {

            var sec = _mapping.MappingEquity(secDto);
            sec.CreatedTime = DateTime.Now;
            var result = await _securityRepo.AddSecurity(sec);
            return result;
        }

        //Add ssecurity fund
        public async Task<bool> AddSecurityFund(FundDtoInput secDto)
        {
            var sec = _mapping.MappingFund(secDto);
            sec.CreatedTime = DateTime.Now;
            var result = await _securityRepo.AddSecurity(sec);
            return result;
        }

        //Add security Futures
        public async Task<bool> AddSecurityFutures(FuturesDtoInput secDto)
        {
            var sec = _mapping.MappingFutures(secDto);
            sec.CreatedTime = DateTime.Now;
            var result = await _securityRepo.AddSecurity(sec);
            return result;
        }

        //Update Security Equity
        public async Task<bool> UpdateSecurityEquity(int id, EquityDtoInput secDto)
        {
            var sec = _mapping.MappingEquity(secDto);
            var result = await _securityRepo.UpdateSecurityEquity(id, sec);
            return result;
        }
    }
}
