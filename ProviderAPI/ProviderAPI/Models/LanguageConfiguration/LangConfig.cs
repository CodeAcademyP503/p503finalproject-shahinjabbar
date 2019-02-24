using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.LanguageConfiguration
{
    public class LangConfig
    {
        public int Id { get; set; }

        [Required]
        public string LangName { get; set; }
    }
}
