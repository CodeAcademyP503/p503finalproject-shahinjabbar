using ProviderAPI.Models.LanguageConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.Mobile
{
    public class Prefix
    {
        public int Id { get; set; }
        [Required]
        public string PrefixValue { get; set; }

        [ForeignKey("LangConfigId")]
        public int LangConfigId { get; set; }

        public LangConfig LangConfig { get; set; }

    }
}
