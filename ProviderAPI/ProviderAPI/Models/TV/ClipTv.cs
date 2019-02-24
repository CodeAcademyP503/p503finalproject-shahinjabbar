using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.TV
{
    public class ClipTv
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public decimal Balance { get; set; }

    }
}
