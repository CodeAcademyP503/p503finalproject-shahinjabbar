using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProviderAPI.Models.Utility;

namespace ProviderAPI.Models.State
{
    public class VN
    {
        public int Id { get; set; }

        [Required]
        public string VOEN { get; set; }


        [Required]
        public string User { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [ForeignKey("StatePrefixId")]
        public int StatePrefixId { get; set; }

        public StatePrefix StatePrefix { get; set; }
    }
}
