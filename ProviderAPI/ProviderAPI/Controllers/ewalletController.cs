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
    public class ewalletController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public ewalletController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery]int langid, string prefix, string number, string provname)
        {
            if (provname == "AzerPay")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                                        join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                                        join azeriqaz in apidbContext.AzerPays on pref.Id equals azeriqaz.PrefixId
                                        where lang.Id == langid && pref.PrefixValue == prefix && azeriqaz.Number == number
                                        select azeriqaz).FirstOrDefaultAsync();
                if (azeriqazes == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azeriqazes);
                }
            }
            else if (provname == "Portmanat")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                    join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                    join azeriqaz in apidbContext.PortManats on pref.Id equals azeriqaz.PrefixId
                    where lang.Id == langid && pref.PrefixValue == prefix && azeriqaz.Number == number
                    select azeriqaz).FirstOrDefaultAsync();
                if (azeriqazes == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azeriqazes);
                }
            }
            else
            {
                return Ok();
            }

        }
    }
}