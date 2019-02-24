using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Bank
{
    public class UniBank
    {
        public int Id { get; set; }

        [Required]
        public string CardPinId { get; set; }

        [Required]
        public string AgreementNumber { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
