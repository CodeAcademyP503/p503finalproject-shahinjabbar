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
    public class EntertainmentController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public EntertainmentController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery]int langid, string prefix, string number, string provname)
        {
            if (provname == "DrWeb")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                                        join pref in apidbContext.EntertainmentPrefixes on lang.Id equals pref.LangConfigId
                                        join azeriqaz in apidbContext.DrWebs on pref.Id equals azeriqaz.EntertainmentPrefixId
                                        where lang.Id == langid && pref.Value == prefix && azeriqaz.Number==number
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
            else if (provname == "Eset")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                    join pref in apidbContext.EntertainmentPrefixes on lang.Id equals pref.LangConfigId
                    join azeriqaz in apidbContext.Esets on pref.Id equals azeriqaz.EntertainmentPrefixId
                    where lang.Id == langid && pref.Value == prefix && azeriqaz.Number == number
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
            else if (provname == "Kaspersky")
            {
                var azeriqazes = await (from lang in apidbContext.LangConfigs
                    join pref in apidbContext.EntertainmentPrefixes on lang.Id equals pref.LangConfigId
                    join azeriqaz in apidbContext.Kasperskies on pref.Id equals azeriqaz.EntertainmentPrefixId
                    where lang.Id == langid && pref.Value == prefix && azeriqaz.Number == number
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