using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Bank
{
    public class XalqBank
    {
        public int Id { get; set; }

        [Required]
        public string LoanContractNumber { get; set; }
        
        [Required]
        public string PinCodeSerialNumber { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
