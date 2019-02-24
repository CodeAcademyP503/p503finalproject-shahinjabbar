using ProviderAPI.Models.Mobile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Utility
{
    public class AzeriQaz
    {
        public int Id { get; set; }

        [Required]
        public string AbonentCode { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [ForeignKey("UtilityPrefixId")]
        public int UtilityPrefixId { get; set; }

        public UtilityPrefix UtilityPrefix { get; set; }

    }
}
