﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class HomeButtonText
    {
        public int id { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey("LanguageConfigurationId")]
        [Required]
        public int LangId { get; set; }

        public LanguageConfiguration LanguageConfiguration { get; set; }
    }
}
