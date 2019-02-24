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
    public class internetController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public internetController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery] string number, string provname)
        {
            if (provname == "Avirtel")
            {
                var azeriqazes = await (from alfa in apidbContext.Avirtels
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
            else if (provname == "AzerOnline")
            {
                var azeriqazes = await (from alfa in apidbContext.AzerOnlines
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
            else if (provname == "AzEuroTel")
            {
                var azeriqazes = await (from alfa in apidbContext.AzeuroTels
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
            else if (provname == "Azincom")
            {
                var azeriqazes = await (from alfa in apidbContext.Azincoms
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