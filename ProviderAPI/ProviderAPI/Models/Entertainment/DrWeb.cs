using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Entertainment
{
    public class DrWeb
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public decimal Balance { get; set; }

        [ForeignKey("EntertainmentPrefixId")]
        public int EntertainmentPrefixId { get; set; }

        public EntertainmentPrefix EntertainmentPrefix { get; set; }
    }
}
