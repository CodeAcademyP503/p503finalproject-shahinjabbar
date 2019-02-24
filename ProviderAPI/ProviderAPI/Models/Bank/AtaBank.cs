using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Bank
{
    public class AtaBank
    {
        public int Id { get; set; }

        [Required]
        public string CustomerCode { get; set; }

        [Required]
        public string LoanAccountNumber { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
