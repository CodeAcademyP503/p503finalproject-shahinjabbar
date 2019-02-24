using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProviderAPI.Models.Context;

namespace ProviderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class stateController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public stateController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery]int langid, string prefix, string number, string provname)
        {
            if (provname == "Taxes")
            {
                var azercell = await (from lang in apidbContext.LangConfigs
                                      join pref in apidbContext.StatePrefixes on lang.Id equals pref.LangConfigId
                                      join taxes in apidbContext.Vns on pref.Id equals taxes.StatePrefixId
                                      where lang.Id == langid && pref.PrefixValue == prefix && taxes.VOEN == number
                                      select taxes).FirstOrDefaultAsync();
                if (azercell == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azercell);
                }
            }
            else
            {
                return Ok();
            }

        }

    }
}