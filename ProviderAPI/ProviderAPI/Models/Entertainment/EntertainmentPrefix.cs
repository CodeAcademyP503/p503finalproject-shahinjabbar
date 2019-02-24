using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProviderAPI.Models.LanguageConfiguration;

namespace ProviderAPI.Models.Entertainment
{
    public class EntertainmentPrefix
    {
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }

        [ForeignKey("LangConfigId")]
        public int LangConfigId { get; set; }

        public LangConfig LangConfig { get; set; }
    }
}
