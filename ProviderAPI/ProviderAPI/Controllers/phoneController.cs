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
    public class phoneController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public phoneController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery] string number, string provname)
        {
            if (provname == "AzEuroTelPhone")
            {
                var azeriqazes = await (from alfa in apidbContext.AzeuroTelPhones
                                        where alfa.Number == number
                                        select alfa).FirstOrDefaultAsync();
                if (azeriqazes == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(azeriqazes);
                }
            }
            else if (provname == "Catel")
            {
                var azeriqazes = await (from alfa in apidbContext.Catels
                                        where alfa.Number == number
                                        select alfa).FirstOrDefaultAsync();
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