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
    public class utilityController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public utilityController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery]int langid, string prefix, string number, string provname)
        {
            if (provname == "Azeriqaz")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                                        join pref in apidbContext.UtilityPrefixes on lang.Id equals pref.LangConfigId
                                        join azeriqaz in apidbContext.AzeriQazes on pref.Id equals azeriqaz.UtilityPrefixId
                                        where lang.Id == langid && pref.PrefixValue == prefix && azeriqaz.AbonentCode == number
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
            else if (provname == "Azersu")
            {

                var azersus = await (from lang in apidbContext.LangConfigs
                                     join pref in apidbContext.UtilityPrefixes on lang.Id equals pref.LangConfigId
                                     join azersu in apidbContext.AzerSus on pref.Id equals azersu.UtilityPrefixId
                                     where lang.Id == langid && pref.PrefixValue == prefix && azersu.AbonentCode == number
                                     select azersu).FirstOrDefaultAsync();
                if (azersus == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azersus);
                }
            }
            else if (provname == "Azerishiq")
            {
                var azerishiqes = await (from lang in apidbContext.LangConfigs
                                         join pref in apidbContext.UtilityPrefixes on lang.Id equals pref.LangConfigId
                                         join azerishiq in apidbContext.AzerIshiqs on pref.Id equals azerishiq.UtilityPrefixId
                                         where lang.Id == langid && pref.PrefixValue == prefix && azerishiq.AbonentCode == number
                                         select azerishiq).FirstOrDefaultAsync();
                if (azerishiqes == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azerishiqes);
                }
            }
            else
            {
                return Ok();
            }

        }
    }
}