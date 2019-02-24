using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class LanguageConfiguration
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:50,MinimumLength = 2)]
        public string LangName { get; set; }

        [Required]
        [StringLength(maximumLength:500,MinimumLength = 4)]
        public string PhotoPath { get; set; }

    }
}
