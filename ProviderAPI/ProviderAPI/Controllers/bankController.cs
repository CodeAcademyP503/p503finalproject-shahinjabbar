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
    public class bankController : ControllerBase
    {
        private readonly APIDBContext apidbContext;

        public bankController(APIDBContext _apidbContext)
        {
            apidbContext = _apidbContext;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetData([FromQuery] string number, string secondnumber, string provname)
        {
            if (provname == "AccessBank")
            {
                var accesses = await (from bank in apidbContext.AccessBanks
                                      where bank.CustomerId == number && bank.IdentityCardNumber == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "AtaBank")
            {
                var accesses = await (from bank in apidbContext.AtaBanks
                                      where bank.CustomerCode == number && bank.LoanAccountNumber == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "AzerTurkBank")
            {
                var accesses = await (from bank in apidbContext.AzerTurkBanks
                                      where bank.AccountNumber == number && bank.PinCode == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "BankofBaku")
            {
                var accesses = await (from bank in apidbContext.BankOfBakus
                                      where bank.AccountNumber == number && bank.CardNumberId == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "BankRespublika")
            {
                var accesses = await (from bank in apidbContext.BankRespublikas
                                      where bank.AccountNumber == number && bank.CardNumberId == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "ExpressBank")
            {
                var accesses = await (from bank in apidbContext.ExpressBanks
                                      where bank.CustomerId == number && bank.PinCode == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }

            else if (provname == "Irshad")
            {
                var accesses = await (from bank in apidbContext.Irshads
                                      where bank.CustomerCode == number && bank.PIN == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "Kapitalbank")
            {
                var accesses = await (from bank in apidbContext.KapitalBanks
                                      where bank.CustomerCode == number && bank.DateOfBirth == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "Unibank")
            {
                var accesses = await (from bank in apidbContext.UniBanks
                                      where bank.CardPinId == number && bank.AgreementNumber == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else if (provname == "XalqBank")
            {
                var accesses = await (from bank in apidbContext.XalqBanks
                                      where bank.LoanContractNumber == number && bank.PinCodeSerialNumber == secondnumber
                                      select bank
                    ).FirstOrDefaultAsync();
                if (accesses == null)
                {
                    return NotFound();
                }
                else
                {
                    return new ObjectResult(accesses);
                }
            }
            else
            {
                return Ok();
            }
        }
    }
}