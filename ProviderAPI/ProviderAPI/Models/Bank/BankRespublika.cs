using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Bank
{
    public class BankRespublika
    {
        public int Id { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string CardNumberId { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
