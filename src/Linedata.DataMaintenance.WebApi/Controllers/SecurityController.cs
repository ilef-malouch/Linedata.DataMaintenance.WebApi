
using Linedata.DataMaintenance.Repository.Models;
using Linedata.DataMaintenance.Shared.DataAccess;
using Linedata.DataMaintenance.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Linedata.DataMaintenance.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class SecurityController: ControllerBase
    {
        private readonly ISecurityService _securityService;
        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        //Security non deleted with id
        //GET: Security/id/1
        [HttpGet("id/{id}")]
        public async Task<ActionResult<Security>> GetSecuritywithId(int id)
        {
            var sec = await _securityService.GetSecuritywithId(id); 
            if (sec == null)
                return BadRequest("Security Not Found");

            return Ok(sec);
        }

        //Security equity non deleted
        //GET: Security/Equity/Common Stock
        [HttpGet("Equity/{minorDesc}")]
        public async Task<ActionResult<List<EquityDto>>> GetSecuritiesEquity(string minorDesc, string? symbol="", string? name="", string? ticker="", string? reuters="", string? cusip="", string? sedol="", string? isin="", string? issuer = "")
        {
            if (string.IsNullOrEmpty(symbol) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(ticker) && string.IsNullOrEmpty(reuters) && string.IsNullOrEmpty(cusip) && string.IsNullOrEmpty(sedol) && string.IsNullOrEmpty(isin) && string.IsNullOrEmpty(issuer))
                return BadRequest("At least one field must be provide!");

            var sec = await _securityService.GetSecuritiesEquity(minorDesc, symbol, name, ticker, reuters, cusip, sedol, isin, issuer);
            if (sec.Count == 0)
                return BadRequest("Securities Not Found");
            return Ok(sec);
        }

        //Security bond forward non deleted
        //GET: Security/BondForward
        [HttpGet("BondForward")]
        public async Task<ActionResult<List<BondForwardDto>>> GetSecuritiesBondForward( string? symbol = "", string? mortgageType = "", string? settlementMonth = "", string? agency = "", string? turm = "", double couponMin = 0, double couponMax = 0)
        {
            if (string.IsNullOrEmpty(symbol) && string.IsNullOrEmpty(mortgageType) && string.IsNullOrEmpty(settlementMonth) && string.IsNullOrEmpty(agency) && string.IsNullOrEmpty(turm) && couponMin == 0 && couponMax == 0)
                return BadRequest("At least one field must be provide!");
            var sec = await _securityService.GetSecuritiesBondForward(symbol, mortgageType, settlementMonth, agency, turm, couponMin, couponMax);
            if (sec.Count == 0)
                return BadRequest("Securities Not Found");
            return Ok(sec);
        }

        //Security option non deleted
        //GET: Security/option
        [HttpGet("Option")]
        public async Task<ActionResult<List<OptionDto>>> GetSecuritiesOption(string? symbol = "", string? name = "", string? ticker = "", string? reuters = "", string? issuer = "")
        {
            if (string.IsNullOrEmpty(symbol) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(ticker) && string.IsNullOrEmpty(reuters) && string.IsNullOrEmpty(issuer))
                return BadRequest("At least one field must be provide!");
            var sec = await _securityService.GetSecuritiesOption(symbol, name, ticker, reuters, issuer);
            if (sec.Count == 0)
                return BadRequest("Securities Not Found");
            return Ok(sec);
        }

        //Security fund non deleted
        //GET: Security/fund
        [HttpGet("Fund")]
        public async Task<ActionResult<List<FundDto>>> GetSecuritiesFund(string? symbol = "", string? name = "", string? ticker = "", string? cusip = "", string? issuer = "")
        {
            if (string.IsNullOrEmpty(symbol) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(ticker) && string.IsNullOrEmpty(cusip) && string.IsNullOrEmpty(issuer))
                return BadRequest("At least one field must be provide!");
            var sec = await _securityService.GetSecuritiesFund(symbol, name, ticker, cusip, issuer);
            if (sec.Count == 0)
                return BadRequest("Securities Not Found");
            return Ok(sec);
        }

        //Security futures non deleted
        //GET: Security/futures
        [HttpGet("Futures")]
        public async Task<ActionResult<List<FuturesDto>>> GetSecuritiesFutures(string? symbol = "", string? name = "", string? issuer = "")
        {
            if (string.IsNullOrEmpty(symbol) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(issuer))
                return BadRequest("At least one field must be provide!");
            var sec = await _securityService.GetSecuritiesFutures(symbol, name, issuer);
            if (sec.Count == 0)
                return BadRequest("Securities Not Found");
            return Ok(sec);
        }


        //Delete security with id
        //PUT: Security/deleteId/2
        [HttpPut("deleteId/{id}")]
        public IActionResult DeleteSecurityWithId(int id)
        {
             _securityService.DeleteSecurityWithId(id);
            return Ok("Security Deleted");
        }

        //Restore security with id
        //PUT: Security/restoreId/2
        [HttpPut("restoreId/{id}")]
        public IActionResult RestoreSecurityWithId(int id)
        {
            _securityService.RestoreSecurityWithId(id);
            return Ok("Security Restored");
        }

        //Add Security equity
        //POST: Security/add/equity
        [HttpPost("add/equity")]
        public async Task<ActionResult<EquityDtoInput>> AddSecurityEquity(EquityDtoInput secDto)
        {
            var result = await _securityService.AddSecurityEquity(secDto);
            if (result == true)
                return Ok(secDto);
            else
                return BadRequest("Security not added");
        }
        //Add Security fund
        //POST: Security/add/fund
        [HttpPost("add/fund")]
        public async Task<ActionResult<EquityDtoInput>> AddSecurityFund(FundDtoInput secDto)
        {
            var result = await _securityService.AddSecurityFund(secDto);
            if (result == true)
                return Ok(secDto);
            else
                return BadRequest("Security not added");
        }

        //Add Security futures
        //POST: Security/add/futures
        [HttpPost("add/futures")]
        public async Task<ActionResult<EquityDtoInput>> AddSecurityFutures(FuturesDtoInput secDto)
        {
            var result = await _securityService.AddSecurityFutures(secDto);
            if (result == true)
                return Ok(secDto);
            else
                return BadRequest("Security not added");
        }

        //UpdateSecurity equity
        //PUT: Security/update/equity/5
        [HttpPut("update/equity/{id}")]
        public async Task<ActionResult<EquityDtoInput>> UpdateSecurityEquity(int id, EquityDtoInput secDto)
        {
            var result = await _securityService.UpdateSecurityEquity(id,secDto);
            if (result == true)
                return Ok(secDto);
            else
                return BadRequest("Can't update the security");
        }


    }
}
