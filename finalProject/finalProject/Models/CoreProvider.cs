using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class CoreProvider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string TagName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string BackColor { get; set; }

        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 5)]
        public string ImagePath { get; set; }

        [StringLength(maximumLength: 70, MinimumLength = 2)]
        public string Text { get; set; }

        [Required]
        public int DataId { get; set; }

        [ForeignKey("LanguageConfigurationId")]
        [Required]
        public int LangId { get; set; }

        public LanguageConfiguration LanguageConfiguration { get; set; }
    }
}
