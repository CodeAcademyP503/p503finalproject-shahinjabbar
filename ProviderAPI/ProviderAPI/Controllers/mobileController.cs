using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using ProviderAPI.Models.Context;
using ProviderAPI.Models.Mobile;
using Newtonsoft.Json;

namespace ProviderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mobileController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public mobileController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery]int langid, string prefix, string number, string provname)
        {
            if (provname == "Azercell")
            {
                var azercell = await (from lang in apidbContext.LangConfigs
                                      join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                                      join azerc in apidbContext.Azercells on pref.Id equals azerc.PrefixId
                                      where lang.Id == langid && pref.PrefixValue == prefix && azerc.Number == number
                                      select azerc).FirstOrDefaultAsync();
                if (azercell == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azercell);
                }
            }
            else if (provname == "Bakcell")
            {
                var bakcell = await (from lang in apidbContext.LangConfigs
                                     join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                                     join bak in apidbContext.Bakcells on pref.Id equals bak.PrefixId
                                     where lang.Id == langid && pref.PrefixValue == prefix && bak.Number == number
                                     select bak).FirstOrDefaultAsync();
                if (bakcell == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(bakcell);
                }
            }
            else if (provname == "Nar")
            {
                var nars = await (from lang in apidbContext.LangConfigs
                                  join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                                  join nar in apidbContext.Nars on pref.Id equals nar.PrefixId
                                  where lang.Id == langid && pref.PrefixValue == prefix && nar.Number == number
                                  select nar).FirstOrDefaultAsync();
                if (nars == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(nars);
                }
            }
            else if (provname == "Naxtel")
            {
                var naxtels = await (from lang in apidbContext.LangConfigs
                                     join pref in apidbContext.Prefix on lang.Id equals pref.LangConfigId
                                     join naxtel in apidbContext.Naxtels on pref.Id equals naxtel.PrefixId
                                     where lang.Id == langid && pref.PrefixValue == prefix && naxtel.Number == number
                                     select naxtel).FirstOrDefaultAsync();
                if (naxtels == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(naxtels);
                }
            }
            else
            {
                return Ok();
            }

        }
    }
}