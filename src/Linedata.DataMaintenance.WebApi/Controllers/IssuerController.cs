using AutoMapper;
using Linedata.DataMaintenance.Shared.DataAccess;
using Linedata.DataMaintenance.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Linedata.DataMaintenance.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IssuerController : ControllerBase
    {
        private readonly IIssuerService _issuerService;
        
        public IssuerController(IIssuerService issuerService)
        {
            _issuerService = issuerService;
        }

        //GET ISSUER NON DELETED BY ID
        // GET: Issuer/id/5
        [HttpGet("id/{id}")]
        public IActionResult GetIssuerById(int id)
        {
        var issuer = _issuerService.GetIssuerById(id);
            if (issuer == null)
                return BadRequest("Issuer Not Found");
            return Ok(issuer);
        }

        //ISSUER NON DELETED
        //GET: issuer/find
        [HttpGet("find/{page}")]
        public IActionResult GetIssuers(int page, string? shortName="", string? issuerName = "", string? entityClip = "", string? entityForm = "", string? legalForm = "", string? country = "")
        {
            var issuers = _issuerService.GetIssuers(page, shortName,  issuerName,  entityClip , entityForm , legalForm ,  country );
            if (issuers.Issuers.Count == 0)
                return BadRequest("Issuers Not Found");
            return Ok(issuers);
        }



    }
}
